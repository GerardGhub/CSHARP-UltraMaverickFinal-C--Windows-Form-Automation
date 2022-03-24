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
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class frmAddNewStore : MaterialForm
    {
        //Main Constructor Bugok
        myclasses xClass = new myclasses();

        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        DataSet dSet_temp = new DataSet();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
    
        Boolean ready = false;
        DataSet dSet = new DataSet();
        string mode = "";
        frmListofStore ths;
        public frmAddNewStore(frmListofStore frm)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
    

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        public string sp_user_id { get; set; }
        public string sp_store_code { get; set; }
        public string sp_store_name { get; set; }
        public string sp_store_area { get; set; }
        public string sp_store_route { get; set; }
        private void frmAddNewStore_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            this.loadAreaDropdown();
            this.loadRouteDropdown();
            this.loadRegionDropdown();
            this.WindowLoader();
            this.ClearComponents();
        }


        private void WindowLoader()
        {
            this.sp_user_id = userinfo.user_id.ToString();
        }

        private void ClearComponents()
        {
            this.mattxtStoreCode.Text = String.Empty;
            this.mattxtStoreName.Text = String.Empty;
            this.mattxtStoreCode.Focus();
          
        }

        public void loadRegionDropdown()
        {

            myClass.fillComboBoxDepartment(this.metroCmbRegion, "tblRegion_dropdown", dSet);


            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }


        public void loadAreaDropdown()
        {

            myClass.fillComboBoxDepartment(cmbStoreArea, "tblArea_dropdown", dSet);


            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        public void loadRouteDropdown()
        {

            myClass.fillComboBoxDepartment(cmbStoreRoute, "tblRoute_dropdown", dSet);


            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = this.textBox1.Text;
        }
 


        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (this.mattxtStoreCode.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.mattxtStoreCode.Focus();
                return;
            }

            //Check The store if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_tbl_stores(0,
                sp_store_name,
                sp_store_area,
                mattxtStoreCode.Text.Trim(),
                sp_store_route,
                Convert.ToString(sp_user_id), "", Convert.ToString(sp_user_id), "", "getbystorecode");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();
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
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to add a new data ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                dSet.Clear();
                dSet = objStorProc.sp_tbl_stores(0,
                    this.mattxtStoreName.Text.Trim(),
                    this.cmbStoreArea.Text.Trim(),
                    this.mattxtStoreCode.Text.Trim(),
                    this.cmbStoreRoute.Text.Trim(),
                    Convert.ToString(sp_user_id), "", Convert.ToString(sp_user_id), "", "add");
                this.GlobalStatePopup.CommittedSuccessFully();
                this.frmAddNewStore_Load(sender, e);
            }
            else
            {
                return;
            }

            }

        private void frmAddNewStore_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.textBox1.Text = "Gerard Singian";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void mattxtStoreCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void mattxtStoreName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
