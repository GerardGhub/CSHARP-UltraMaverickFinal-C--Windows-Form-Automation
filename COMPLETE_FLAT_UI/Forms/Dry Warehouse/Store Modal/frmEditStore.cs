using COMPLETE_FLAT_UI.Models;
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
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class frmEditStore : MaterialForm
    {   //Main Constructor Bugok
        myclasses xClass = new myclasses();

        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        DataSet dSet_temp = new DataSet();
        DataSet dSet = new DataSet();

        frmListofStore ths;
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        public frmEditStore(frmListofStore frm, string store_code, string store_name, 
            string store_route, string store_area, string store_id)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.SpStoreCode = store_code;
            this.SpStoreName = store_name;
            this.SpStoreRoute = store_route;
            this.SpStoreArea = store_area;
            this.Sp_Store_Id = store_id;
        }

        public string SpStoreCode { get; set; }
        public string SpStoreName { get; set; }
        public string SpStoreRoute { get; set; }
        public string SpStoreArea { get; set; }
        public string sp_user_id { get; set; }
        public string Sp_Store_Id { get; set; }

        private void frmEditStore_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            this.BindDataintoTextBox();
        }

        public void loadRouteDropdown()
        {

            myClass.fillComboBoxDepartment(cmbStoreRoute, "tblRoute_dropdown", dSet);


            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }


        public void loadAreaDropdown()
        {

            myClass.fillComboBoxDepartment(cmbStoreArea, "tblArea_dropdown", dSet);


            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        private void BindDataintoTextBox()
        {
            //Store Infromation Binding
            this.mattxtStoreCode.Text = this.SpStoreCode;
            this.mattxtStoreName.Text = this.SpStoreName;
            this.cmbStoreRoute.Text = this.SpStoreRoute;
            this.cmbStoreArea.Text = this.SpStoreArea;
            this.sp_user_id = userinfo.user_id.ToString();
            this.Sp_Store_Id = this.Sp_Store_Id;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (this.mattxtStoreName.Text == String.Empty)
            {
                this.mattxtStoreName.Focus();
                this.GlobalStatePopup.FillRequiredFields();
                return;
            }

            //Check The store if existg on the system
            //dSet.Clear();
            //dSet = objStorProc.sp_tbl_stores(0,
            //    this.mattxtStoreName.Text.ToString(),
            //    this.cmbStoreArea.Text,
            //    this.mattxtStoreCode.Text.Trim(),
            //    this.cmbStoreRoute.Text,
            //    Convert.ToString(sp_user_id), "", Convert.ToString(sp_user_id), "", "getbystorecode");

            //if (dSet.Tables[0].Rows.Count > 0)
            //{
            //    //RawMatsAlreadyExist();
            //    this.GlobalStatePopup.DataAlreadyExist();
            //    this.mattxtStoreCode.Text = String.Empty;
            //    this.mattxtStoreCode.Focus();
            //    return;

            //}


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
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                dSet.Clear();
                dSet = objStorProc.sp_tbl_stores(Convert.ToInt32(this.Sp_Store_Id),
                    this.mattxtStoreName.Text.Trim(),
                    this.cmbStoreArea.Text.Trim(),
                    this.mattxtStoreCode.Text.Trim(),
                    this.cmbStoreRoute.Text.Trim(),
                    Convert.ToString(sp_user_id), "", Convert.ToString(sp_user_id), "", "edit");
                this.GlobalStatePopup.UpdatedSuccessfully();
                this.frmEditStore_Load(sender, e);
            }
            else
            {
                return;
            }


        }

        private void frmEditStore_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.textBox1.Text = "Gerard Singian";
        }

        private void cmbStoreRoute_Click(object sender, EventArgs e)
        {
            this.loadRouteDropdown();
        }

        private void cmbStoreArea_Click(object sender, EventArgs e)
        {
            this.loadAreaDropdown();
        }
    }
}
