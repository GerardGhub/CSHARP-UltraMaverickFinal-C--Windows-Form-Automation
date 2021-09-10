using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMPLETE_FLAT_UI.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmManageActivePrimaryUnit : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        DataSet dSet_temp = new DataSet();
        int p_id2 = 0;
        int p_id = 0;
        public frmManageActivePrimaryUnit()
        {
            InitializeComponent();
        }
        public string conversion_qty { get; set; }
        public string MyItemCode { get; set; }

        public string sp_active_pu_primary_id { get; set; }
        public string sp_active_pu_description { get; set; }
        public string sp_actve_pu_conversion { get; set; }
        public string sp_item_ide { get; set; }
        public string sp_item_primary_unit { get; set; }
        public string Unit_id { get; set; }

        public string sp_item_primary_id { get; set; }

        private void frmManageActivePrimaryUnit_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            lblUserID.Text = userinfo.user_id.ToString();
            showRawMaterialsInDryWH();
            SearchMethodJarVarCallingSP();
            SearchMethodJarVarCallingSPUnits();
            myglobal.global_module = "Active"; // Mode for Searching
            HideControls();
        }
        private void HideControls()
        {
            txtmatid.Visible = false;
        }

        DataSet dset_emp_SearchEnginesonUnit = new DataSet();
        private void SearchMethodJarVarCallingSPUnits()
        {
            dset_emp_SearchEnginesonUnit.Clear();


            dset_emp_SearchEnginesonUnit = objStorProc.sp_getMajorTables("PrimaryUnitManagementMajor");

        }


        //DataSet dset_emp_SearchingUnit = new DataSet();
        //private void SearchUnitsSP()
        //{
        //    dset_emp_SearchingUnit.Clear();


        //    dset_emp_SearchingUnit = objStorProc.sp_getMajorTables("Raw_Materials_Dry_IngredientsOnly_Major");

        //}

        private void doSearchInTextBoxPrimaryUnit()
        {
            try
            {


                if (dset_emp_SearchEnginesonUnit.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEnginesonUnit.Tables[0]);
                    if (myglobal.global_module == "EMPLOYEE")
                    {

                    }
                    else if (myglobal.global_module == "Active")
                    {


                        //Gerard Singian Developer Man




                        dv.RowFilter = "item_item_code = '" + MyItemCode + "' AND active_pu_conversion like '%" +txtmatSearchUnit.Text+"%' ";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dgvActiveUnits.DataSource = dv;
                    DataGridColumnHideUnit();
                    lbltotalRecordsActiveUnits.Text = dgvActiveUnits.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found xxx!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }




        }


        private void DataGridColumnHideUnit()
        {

            this.dgvActiveUnits.Columns["created_at_units"].Visible = false;
            this.dgvActiveUnits.Columns["created_by_units"].Visible = false;
            this.dgvActiveUnits.Columns["modified_at_units"].Visible = false;
            this.dgvActiveUnits.Columns["modified_by_units"].Visible = false;
            this.dgvActiveUnits.Columns["item_primary_id"].Visible = false;
            this.dgvActiveUnits.Columns["active_pu_primary_id"].Visible = false;
            this.dgvActiveUnits.Columns["item_item_code"].Visible = false;
            this.dgvActiveUnits.Columns["item_description_units"].Visible = false;
        }


        private void showRawMaterialsInDryWH()    //method for loading available_menus
        {
            try
            {

                xClass.fillDataGridView(dgvRawMats, "Raw_Materials_Dry_IngredientsOnly", dSet);
                DataGridColumnHide();
                lbltotalrecords.Text = dgvRawMats.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        private void DataGridColumnHide()
        {
            this.dgvRawMats.Columns["item_class"].Visible = false;
            this.dgvRawMats.Columns["major_category"].Visible = false;
            this.dgvRawMats.Columns["sub_category"].Visible = false;
            //this.dgvRawMats.Columns["primary_unit"].Visible = false;
            this.dgvRawMats.Columns["conversion"].Visible = false;
            this.dgvRawMats.Columns["item_type"].Visible = false;
            this.dgvRawMats.Columns["created_at"].Visible = false;
            this.dgvRawMats.Columns["created_by"].Visible = false;
            this.dgvRawMats.Columns["updated_at"].Visible = false;
            this.dgvRawMats.Columns["updated_by"].Visible = false;
        }
        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = objStorProc.sp_getMajorTables("Raw_Materials_Dry_Major");

        }
        private void doSearchInTextBoxCmb()
        {
            try
            {


                if (dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEngines.Tables[0]);
                    if (myglobal.global_module == "EMPLOYEE")
                    {

                    }
                    else if (myglobal.global_module == "Active")
                    {


                        //Gerard Singian Developer Man




                        dv.RowFilter = "item_description like '%" + mattxtSearch.Text + "%'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dgvRawMats.DataSource = dv;
                    DataGridColumnHide();
                    lbltotalrecords.Text = dgvRawMats.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found xxx!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }




        }


        private void dgvRawMats_CurrentCellChanged(object sender, EventArgs e)
        {
            showValueCell();
        }

        private void showValueCell()
        {
            if (dgvRawMats.Rows.Count > 0)
            {
                if (dgvRawMats.CurrentRow != null)
                {
                    if (dgvRawMats.CurrentRow.Cells["item_description"].Value != null)
                    {
                        p_id = Convert.ToInt32(dgvRawMats.CurrentRow.Cells["item_id"].Value);

                        txtmatItemDescription.Text = dgvRawMats.CurrentRow.Cells["item_description"].Value.ToString();
                        MyItemCode = dgvRawMats.CurrentRow.Cells["item_code"].Value.ToString();
                        txtmatid.Text = dgvRawMats.CurrentRow.Cells["item_id"].Value.ToString();
                        sp_item_primary_unit = dgvRawMats.CurrentRow.Cells["primary_unit"].Value.ToString();
                    }
                }
            }
        }

        private void mattxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (lbltotalrecords.Text == "0")
            {

            }
            else
            {
                doSearchInTextBoxCmb();

            }
            if (mattxtSearch.Text == "")
            {
                showRawMaterialsInDryWH();
            }



        }

        private void txtmatid_TextChanged(object sender, EventArgs e)
        {
            if (lbltotalrecords.Text == "0")
            {

            }
            else
            {
                doSearchInTextBoxPrimaryUnit();
            }
        }

        private void txtmatSearchUnit_TextChanged(object sender, EventArgs e)
        {
            if (lbltotalrecords.Text == "0")
            {

            }
            else
            {
                doSearchInTextBoxPrimaryUnit();
            }
                
        }

        private void dgvActiveUnits_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvActiveUnits.Rows.Count > 0)
            {
                if (dgvActiveUnits.CurrentRow != null)
                {
                    if (dgvActiveUnits.CurrentRow.Cells["active_pu_description"].Value != null)
                    {
                        p_id2 = Convert.ToInt32(dgvActiveUnits.CurrentRow.Cells["id"].Value);

                        conversion_qty = dgvActiveUnits.CurrentRow.Cells["active_pu_conversion"].Value.ToString();

                        mattxtPrimaryUnit.Text = dgvActiveUnits.CurrentRow.Cells["active_pu_description"].Value.ToString();
                        //Unit_id = dgvActiveUnits.CurrentRow.Cells["id"].Value.ToString();

                        sp_active_pu_primary_id = dgvActiveUnits.CurrentRow.Cells["active_pu_primary_id"].Value.ToString();
                        sp_item_primary_id = dgvActiveUnits.CurrentRow.Cells["item_primary_id"].Value.ToString();
                    }
                }
            }
        }

        private void btnAddTool_Click(object sender, EventArgs e)
        {
            toolStrip2.Visible = false;
            frmAddNewUomConversion addNew = new frmAddNewUomConversion(this, conversion_qty, mattxtPrimaryUnit.Text, MyItemCode, txtmatItemDescription.Text, sp_active_pu_primary_id, txtmatid.Text, sp_item_primary_unit);
            addNew.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Gerard Singian")
            {
                toolStrip2.Visible = true;
            }
            else if (textBox1.Text == "data Already Save!")
            {

                SearchMethodJarVarCallingSPUnits();

                doSearchInTextBoxPrimaryUnit();
            }
            else
            {

            }
        }
        public void InactiveSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Inactive Successfully";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Green;
            popup.Popup();

            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);

            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }

        private void btnDeleteTool_Click(object sender, EventArgs e)
        {

            if (dgvActiveUnits.Rows.Count > 0)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to inactive the primary unit conversion Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    dSet_temp.Clear();
                    dSet_temp = objStorProc.sp_PrimaryUnitManagement(p_id2, "", "", "", "", "", "", "", "", "", "", "", "delete");

                    InactiveSuccessfully();

                    SearchMethodJarVarCallingSPUnits();

                    doSearchInTextBoxPrimaryUnit();
                }
                else
                {
                    return;
                }


            }
        }

        public void ActivateSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Activate Successfully";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Green;
            popup.Popup();

            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);

            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }

        public void AlreadyHaveActivateConverions()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "You already have a active Primary Unit Conversion!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Red;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;
        }


        private void btnEditTool_Click(object sender, EventArgs e)
        {

            dSet.Clear();
            dSet = objStorProc.sp_PrimaryUnitManagement(0, sp_item_primary_id, "", "", "", "", "", "", "", "", "", "", "checkthedataActivate");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //dSet_temp.Clear();
                //dSet_temp = objStorProc.sp_PrimaryUnitManagement(p_id2, "", "", "", "", "", "", "", "", "", "", "", "delete");
                
                //AlreadyHaveActivateConverions();

                //return;
            }

            //Puke


            if (dgvActiveUnits.Rows.Count > 0)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to activate the primary unit conversion Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    dSet_temp.Clear();
                    dSet_temp = objStorProc.sp_PrimaryUnitManagement(Convert.ToInt32(txtmatid.Text), "", "", "", "", "", "", "", "", "", "", "", "inactiveall");

                    dSet_temp.Clear();
                    dSet_temp = objStorProc.sp_PrimaryUnitManagement(p_id2, "", "", "", "", "", "", "", "", "", "", "", "activate_conversion");


           

                    ActivateSuccessfully();

                    SearchMethodJarVarCallingSPUnits();

                    doSearchInTextBoxPrimaryUnit();
                }
                else
                {
                    return;
                }


            }


            //frmActivationofPrimaryUnit addNew = new frmActivationofPrimaryUnit(this);
            //addNew.ShowDialog();
        }
    }
}
