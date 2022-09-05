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
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class FrmEditStore : MaterialForm
    {   //Main Constructor Bugok

        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;

 
        DataSet dSet = new DataSet();
        Tbl_Stores Tbl_StoresEntity = new Tbl_Stores();
        frmListofStore ths;
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        public FrmEditStore(frmListofStore frm, int store_id, string store_name, 
            string store_route, string store_area, string store_code, string region)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.Tbl_StoresEntity.Store_Code = store_code;
            this.Tbl_StoresEntity.Store_Name = store_name;
            this.Tbl_StoresEntity.Store_Route = store_route;
            this.Tbl_StoresEntity.Store_Area = store_area;
            this.Tbl_StoresEntity.Stored_Id = store_id;
            this.Tbl_StoresEntity.Region = region;
        }



        public string Sp_user_id { get; set; }


        private void frmEditStore_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
 
            this.BindDataintoTextBox();

        }

        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }

        public void loadRegionDropdown()
        {

            myClass.fillComboBoxDepartment(this.metroCmbRegion, "tblRegion_dropdown", dSet);


            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
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
            this.mattxtStoreCode.Text = this.Tbl_StoresEntity.Store_Code;
            this.mattxtStoreName.Text = this.Tbl_StoresEntity.Store_Name;
            this.cmbStoreRoute.Text = this.Tbl_StoresEntity.Store_Route;
            this.cmbStoreArea.Text = this.Tbl_StoresEntity.Store_Area;
            this.Sp_user_id = userinfo.user_id.ToString();
            this.Tbl_StoresEntity.Stored_Id = this.Tbl_StoresEntity.Stored_Id;
            this.metroCmbRegion.Text = this.Tbl_StoresEntity.Region;
 
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void MaterialButton1_Click(object sender, EventArgs e)
        {
            if (this.mattxtStoreName.Text == String.Empty)
            {
                this.mattxtStoreName.Focus();
                this.GlobalStatePopup.FillRequiredFields();
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



            if (this.Tbl_StoresEntity.Store_Name == this.mattxtStoreName.Text)
            {
                this.SaveFunctionaliTY();
            }
            else
            {

                //Check The store if existg on the system
                this.dSet.Clear();
                this.dSet = g_objStoredProcCollection.sp_tbl_stores(0,
                    this.mattxtStoreName.Text,
                    this.Tbl_StoresEntity.Store_Area,
                    this.mattxtStoreCode.Text.Trim(),
                    this.Tbl_StoresEntity.Store_Route,
                    Convert.ToString(Sp_user_id),
                    "",
                    Convert.ToString(Sp_user_id),
                    "",
                    this.metroCmbRegion.Text,
                    "getbyname");

                if (this.dSet.Tables[0].Rows.Count > 0)
                {

                    this.GlobalStatePopup.DataAlreadyExist();
                    this.mattxtStoreCode.Text = String.Empty;
                    this.mattxtStoreCode.Focus();
                    return;

                }
                else
                {
                    this.SaveFunctionaliTY();
                }


     

            }

        }

        private void SaveFunctionaliTY()
        {
            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                dSet.Clear();
                dSet = g_objStoredProcCollection
                    .sp_tbl_stores(Convert.ToInt32(
                    this.Tbl_StoresEntity.Stored_Id),
                    this.mattxtStoreName.Text.Trim(),
                    this.cmbStoreArea.Text.Trim(),
                    this.mattxtStoreCode.Text.Trim(),
                    this.cmbStoreRoute.Text.Trim(),
                    Convert.ToString(Sp_user_id), "",
                    Convert.ToString(Sp_user_id), "",
                    this.metroCmbRegion.Text, "edit");
                this.GlobalStatePopup.UpdatedSuccessfully();
                this.Close();

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

        private void metroCmbRegion_Click(object sender, EventArgs e)
        {
            this.loadRegionDropdown();
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
