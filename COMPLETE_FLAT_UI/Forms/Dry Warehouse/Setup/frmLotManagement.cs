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
using ULTRAMAVERICK.Forms.Dry_Warehouse.Setup;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmLotManagement : MaterialForm
    {

        IStoredProcedures g_objStoredProcCollection = null;
        readonly myclasses myClass = new myclasses();
        private DataSet dSet = new DataSet();

   
        int p_id = 0;



        DataSet dSet_temp = new DataSet();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        public frmLotManagement()
        {
            InitializeComponent();
        }
        //User Binding
        public string Sp_user_id { get; set; }
        public string ErrorDetails { get; set; }
        public string Sp_id { get; set; }
        public string Sp_lot_number { get; set; }
        public string Sp_description { get; set; }
        public string Sp_category { get; set; }
        public string Sp_Total_SKU { get; set; }
        private void frmLotManagement_Load(object sender, EventArgs e)
        {
            this.ConnectionInitializer();
            Sp_user_id = userinfo.user_id.ToString();
            this.ShowLotMasterlist();
            this.LoadingrefresherOrb();
            this.SearchMethodJarVarCallingSP();
            this.IfTheISNullOrEmpty();
        }


        private void ConnectionInitializer()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }
        private void IfTheISNullOrEmpty()
        {
            if(this.lbltotalrecords.Text != "0")
            {
                this.matRadioActive.Checked = true;
            }
        

       
        }

        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("lot_management_MajorList");

        }

        private void SearchMethodJarVarCallingSPForDeactivate()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("lot_management_MajorList_Deactivated");

        }

        private void LoadingrefresherOrb()
        {

            if (this.textBox1.Text == "data Already Save!")
            {
                this.matBtnEdit.Visible = false;
            }
            else if (this.textBox1.Text == "Gerard Singian")
            {
                this.textBox1.Text = string.Empty;
                this.matBtnNew.Visible = true;
                this.matBtnEdit.Visible = true;
            }
            else
            {


            }




            myglobal.global_module = "Active"; // Mode for Searching

        }

        private void ShowLotMasterlist()      //method for loading available_menus
        {
            try
            {
           
                this.myClass.fillDataGridView(this.dgvLotData ,"lot_management", dSet);
     
                this.lbltotalrecords.Text = this.dgvLotData.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }


        private void ShowLotMasterlistDeactivated()      //method for loading available_menus
        {
            try
            {
             
                this.myClass.fillDataGridView(this.dgvLotData, "lot_management_deactivated", dSet);
        
                this.lbltotalrecords.Text = this.dgvLotData.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void MatBtnNew_Click(object sender, EventArgs e)
        {
            matBtnNew.Visible = false;
            matBtnEdit.Visible = false;
            frmAddNewLotModal addNew = new frmAddNewLotModal(this, Sp_user_id);
            addNew.ShowDialog();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           frmLotManagement_Load(sender, e);
        }

       
        DataSet dset_emp_SearchEngines = new DataSet();
        private void DoSearchInTextBoxCmb()
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




                        dv.RowFilter = "lot_number = '" + mattxtSearch.Text + "' or description like '%" + mattxtSearch.Text + "%' ";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dgvLotData.DataSource = dv;
                    lbltotalrecords.Text = dgvLotData.RowCount.ToString();
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

        private void matBtnEdit_Click(object sender, EventArgs e)
        {
            this.matBtnNew.Visible = false;
            this.matBtnEdit.Visible = false;
           frmUpdateLotData addNew = new frmUpdateLotData(this, 
               this.Sp_user_id, 
               this.Sp_lot_number, 
               this.Sp_description, 
               this.Sp_category, this.p_id, this.Sp_Total_SKU);
            addNew.ShowDialog();
        }

        private void DgvLotData_CurrentCellChanged(object sender, EventArgs e)
        {
            this.ShowValueCell();
        }

        private void ShowValueCell()
        {
            if (dgvLotData.Rows.Count > 0)
            {
                if (dgvLotData.CurrentRow != null)
                {
                    if (dgvLotData.CurrentRow.Cells["lot_number"].Value != null)
                    {
                        this.p_id = Convert.ToInt32(this.dgvLotData.CurrentRow.Cells["id"].Value);
                        this.Sp_lot_number = this.dgvLotData.CurrentRow.Cells["lot_number"].Value.ToString();
                        this.Sp_description = this.dgvLotData.CurrentRow.Cells["description"].Value.ToString();
                        this.Sp_category = this.dgvLotData.CurrentRow.Cells["category"].Value.ToString();
                        this.Sp_Total_SKU = this.dgvLotData.CurrentRow.Cells["TOTALSKU"].Value.ToString();
                   
                    }
                }
            }
        }

        private void DgvLotData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check the value of the e.ColumnIndex property if you want to apply this formatting only so some rcolumns.
            if (e.Value != null)
            {
                e.Value = e.Value.ToString().ToUpper();
                e.FormattingApplied = true;
            }
        }

        private void MatBtnViewItems_Click(object sender, EventArgs e)
        {

            frmViewItemsInLotArea mywipwh = new frmViewItemsInLotArea(this, 
                Sp_lot_number, 
                Sp_description, 
                Sp_category);
            mywipwh.ShowDialog();


        }

        private void MaterialButton1_Click(object sender, EventArgs e)
        {
            if(this.Sp_Total_SKU != "0")
            {
                this.GlobalStatePopup.ErrorNotify(this.ErrorDetails);
                return;
            }

            if(this.matBtnStatuses.Text=="DEACTIVATE")
            {

        
            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to deactivate the data "+Sp_description+"?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.dSet.Clear();
                this.dSet = g_objStoredProcCollection.sp_lot_management(p_id,
                    this.Sp_user_id, 
                    "LotDescription", 
                    "MajorCategoryId", 
                    "CreatedBY", 
                    "",
                    "Sample",
                    "", 
                    "delete");
                this.GlobalStatePopup.UpdatedSuccessfully();
                this.matRadioNotActive.Checked = true;
            }
                else if (this.matRadioNotActive.Checked == true)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to activate the data" + Sp_description + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        this.dSet.Clear();
                        this.dSet = g_objStoredProcCollection.sp_lot_management(p_id,
                            this.Sp_user_id,
                            "LotDescription",
                            "MajorCategoryId",
                            "CreatedBY",
                            "", 
                            "Sample", 
                            "",
                            "activate");
                        this.GlobalStatePopup.UpdatedSuccessfully();
                        this.matRadioActive.Checked = true;
                    }
                    else
                    {
                        return;
                    }
                }
            //End of Else if fucking Sh!t
                else
            {
                return;
            }


            }







        }

        private void MattxtSearch_TextChanged_1(object sender, EventArgs e)
        {
            if(this.matRadioActive.Checked == true)
            {
                this.SearchMethodJarVarCallingSP();
                this.DoSearchInTextBoxCmb();
            }
            else if(this.matRadioNotActive.Checked == true)
            {
                this.SearchMethodJarVarCallingSPForDeactivate();
                this.DoSearchInTextBoxCmb();

            }
         
        }

        private void MatRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if(this.matRadioActive.Checked == true)
            {
                this.matRadioActive.Checked = false;
            }
            else
            {
                this.matRadioNotActive.Checked = true;
                this.matBtnStatuses.Text = "ACTIVATE";
                this.ConnectionInitializer();
                this.ShowLotMasterlistDeactivated();
                if(this.lbltotalrecords.Text == "0")
                {
                    this.matBtnStatuses.Visible = false;
                }

            }

        }

        private void MatRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if(matRadioNotActive.Checked == true)
            {
                this.matRadioActive.Checked = false;

            }
            else
            {
                this.matRadioActive.Checked = true;
           

                this.matBtnStatuses.Text = "DEACTIVATE";
                this.frmLotManagement_Load(sender, e);
            }

             
 
        }

    
    }
}
