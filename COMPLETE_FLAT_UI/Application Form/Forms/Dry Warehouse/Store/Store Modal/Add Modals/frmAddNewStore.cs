using COMPLETE_FLAT_UI.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class frmAddNewStore : MaterialForm
    {
        //Main Constructor Bugok
        readonly myclasses myClass = new myclasses();
        private IStoredProcedures g_objStoredProcCollection = null;
        DataSet dSet_temp = new DataSet();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        readonly Tbl_Stores Tbl_StoresEntity = new Tbl_Stores();
        DataSet dSet = new DataSet();
        frmListofStore ths;


        public frmAddNewStore(frmListofStore frm)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(TextBox1_TextChanged);
    

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        public string Sp_user_id { get; set; }

        private void FrmAddNewStore_Load(object sender, EventArgs e)
        {

            this.ConnectionInit();
            this.LoadAreaDropdown();
            this.LoadRouteDropdown();
            this.LoadRegionDropdown();
            this.WindowLoader();
            this.ClearComponents();
        }

        private void ConnectionInit()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }
 

        private void WindowLoader()
        {
            this.Sp_user_id = userinfo.user_id.ToString();
        }

        private void ClearComponents()
        {
            this.mattxtStoreCode.Text = String.Empty;
            this.mattxtStoreName.Text = String.Empty;
            this.mattxtStoreCode.Focus();
          
        }

        public void LoadRegionDropdown()
        {

            myClass.fillComboBoxDepartment(this.metroCmbRegion, "tblRegion_dropdown", dSet);


            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }


        public void LoadAreaDropdown()
        {

            myClass.fillComboBoxDepartment(cmbStoreArea, "tblArea_dropdown", dSet);


            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        public void LoadRouteDropdown()
        {

            myClass.fillComboBoxDepartment(cmbStoreRoute, "tblRoute_dropdown", dSet);


            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = this.textBox1.Text;
        }
 


        private void MaterialButton1_Click(object sender, EventArgs e)
        {
            if (this.mattxtStoreCode.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.mattxtStoreCode.Focus();
                return;
            }

            //Check The store if existg on the system
            this.dSet.Clear();
            this.dSet = g_objStoredProcCollection.sp_tbl_stores(0,
                this.Tbl_StoresEntity.Store_Name,
                this.Tbl_StoresEntity.Store_Area,
                this.mattxtStoreCode.Text.Trim(),
                this.Tbl_StoresEntity.Store_Route,
                Convert.ToString(Sp_user_id),
                "", 
                Convert.ToString(Sp_user_id),
                "",
                this.metroCmbRegion.Text,
                "getbystorecode");

            if (dSet.Tables[0].Rows.Count > 0)
            {
           
                this.GlobalStatePopup.DataAlreadyExist();
                this.mattxtStoreCode.Text = String.Empty;
                this.mattxtStoreCode.Focus();
                return;

            }
          

            if (this.mattxtStoreName.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.mattxtStoreName.Focus();
                return;
            }
            if (this.cmbStoreArea.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.cmbStoreArea.Focus();
                return;
            }

            if (this.cmbStoreRoute.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.cmbStoreRoute.Focus();
                return;
            }


            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save a new data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.dSet.Clear();
                this.dSet = g_objStoredProcCollection.sp_tbl_stores(0,
                    this.mattxtStoreName.Text.Trim(),
                    this.cmbStoreArea.Text.Trim(),
                    this.mattxtStoreCode.Text.Trim(),
                    this.cmbStoreRoute.Text.Trim(),
                    Convert.ToString(Sp_user_id), "",
                    Convert.ToString(Sp_user_id), 
                    "", 
                    this.metroCmbRegion.Text,
                    "add");
                this.GlobalStatePopup.SuccessFullySave();
                this.textBox1.Text = "Gerard Singian";
                this.textBox1.Text = String.Empty;
                this.Close();
            }
            else
            {
                return;
            }

            }

        private void FrmAddNewStore_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.textBox1.Text = "Gerard Singian";
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void MattxtStoreCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void mattxtStoreName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void MatBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
