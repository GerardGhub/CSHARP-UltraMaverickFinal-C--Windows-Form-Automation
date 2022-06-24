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
using ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module;
using ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module.Major_Process.Class_Form;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Internal.Preparation
{
    public partial class frmInternalForScheduling : MaterialForm
    {
        myclasses myClass = new myclasses();
        myclasses xClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        //Data Set Initialization
        public DataSet dset = new DataSet();
        DataSet dset2 = new DataSet();

        DataSet dSet = new DataSet();

        DataSet dSetCategoryPartialValidation = new DataSet();


        //Variable Declaration
        int p_id = 0;
        int num = 0;

        string Rpt_Path = "";
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        frmNewStoreOrderApprovedClasses FormClass = new frmNewStoreOrderApprovedClasses();
        myglobal GlobalVariable = new myglobal();
        string selection_mode = "";
        string modesplashScreenError = "";


        public string Sp_department_id { get; set; }
        public string Sp_mrs_req_desc { get; set; }
        public string Sp_mrs_requested_by { get; set; }
        public string Sp_mrs_requested_date { get; set; }
        public string Sp_total_items { get; set; }

        public frmInternalForScheduling()
        {
            InitializeComponent();
        }


        private void VisibilityFalseDataGrid()
        {
            if (this.lbltotaldata.Text != "0")
            {
                this.dgvStoreOrderApproval.Columns["order_id"].Visible = false;
                this.dgvStoreOrderApproval.Columns["primary_id"].Visible = false;
                this.dgvStoreOrderApproval.Columns["AVERAGE_ORDER_DAY_SET_UP"].Visible = false;
                this.dgvStoreOrderApproval.Columns["StockOnHand"].Visible = false;
                this.dgvStoreOrderApproval.Columns["ORDERS"].Visible = false;
                this.dgvStoreOrderApproval.Columns["QTY_RECEIVED_ORDER"].Visible = false;
                this.dgvStoreOrderApproval.Columns["TOTAL_COLUMN_ALLOCATED_QTY"].Visible = false;
            }


        }


        private void DataRefresher()
        {
            this.dset = g_objStoredProcCollection.sp_IDGenerator(0, "resetreceivingreprint", "", "", 6);
            this.FormClass.sp_user_id = userinfo.user_id;
        }

        private void frmInternalForScheduling_Load(object sender, EventArgs e)
        {
            this.CheckTheForApprovalRadioButton();


            this.ConnectionOpen();
            //this.DataRefresher();


            //this.showRawMaterialforApproval();



            //this.ValidatedItemforApproval();





            //if (this.modesplashScreenError == "1")
            //{

            //    return;
            //}
            //this.VisibilityFalseDataGrid();
            //if (this.lbltotaldata.Text == "0")
            //{

            //}
            //else
            //{

            //    this.load_search();
            //    selection_mode = "0";
            //}
            //if (lbltotaldata.Text == "0")
            //{
            //    //MessageBox.Show("sdsds");
            //}
            //else
            //{
            //    this.GlobalVariable.for_approval_store_module_formLoad = "1";
            //}


            this.selection_mode = "1";
        }


        public void loadMRSDropdownForAllocation()
        {
            try
            {


                myClass.fillComboBoxStoreOrderApproval(this.matcmbCategory, "Internal_Order_For_Allocation", this.dSet);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }



        public void loadForScheduling()
        {
            try
            {


                myClass.fillComboBoxStoreOrderApproval(this.matcmbCategory, "Internal_Order_FilterByDate", this.dSet);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }


        private void doSearch()
        {
            try
            {
                if (this.dset_emp1.Tables.Count > 0)
                {
                    DataView dv = new DataView(this.dset_emp1.Tables[0]);
                   
                    if (myglobal.global_module == "Active")
                    {

                        dv.RowFilter = "  mrs_requested_date = '" + this.matcmbCategory.Text + "'  ";

                    }

                    this.dgvStoreOrderApproval.DataSource = dv;
                    this.lbltotaldata.Text = dgvStoreOrderApproval.RowCount.ToString();

                    //gerard
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 20.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            //END
        }

   



        DataSet dset_emp1 = new DataSet();
        private void load_search()
        {

            if (this.matRadioForApproval.Checked == true)
            {
                this.dset_emp1.Clear();

                this.dset_emp1 = objStorProc.sp_getMajorTables("searchMRSMasterDataSync");

                this.doSearch();
            }
            else if(this.matRadioForAllocation.Checked == true)
            {
                this.dset_emp1.Clear();

                this.dset_emp1 = objStorProc.sp_getMajorTables("searchMRSMasterDataSyncForAllocation");

                this.doSearch();
            }
  


        }

        private void ReturnFunctionality()
        {

            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class

            this.DataRefresher();
            myglobal.global_module = "Active";


            //Functionality Viewing of the Data Binding Source
            if (this.matRadioForApproval.Checked == true)
            {
                this.loadCategoryDropdown();
            }
            else if (this.matRadioForAllocation.Checked == true)
            {
                this.loadMRSDropdownForAllocation();
            }






            //this.InitiliazeDatePickerMinDate();
            this.FormClass.mode = "";




            //this.ConnectionInit();
            this.dset_emp1.Clear();

            this.dset_emp1 = objStorProc.sp_getMajorTables("searchorderForApprovalinDryWH");
            DataView dv = new DataView(this.dset_emp1.Tables[0]);

            this.dgvStoreOrderApproval.DataSource = dv;
            this.lbltotaldata.Text = dgvStoreOrderApproval.RowCount.ToString();
          

          
            this.DataGridColumnDisabledEditing();

        }

 

        private void DataGridColumnDisabledEditing()
        {
            if (this.dgvStoreOrderApproval.Rows.Count > 0)
            {


                this.dgvStoreOrderApproval.Columns["mrs_id"].ReadOnly = true;
                this.dgvStoreOrderApproval.Columns["department_id"].ReadOnly = true;
                this.dgvStoreOrderApproval.Columns["mrs_req_desc"].ReadOnly = true;
                this.dgvStoreOrderApproval.Columns["mrs_requested_by"].ReadOnly = true;
                this.dgvStoreOrderApproval.Columns["mrs_requested_date"].ReadOnly = true;
                this.dgvStoreOrderApproval.Columns["TOTAL_ITEMS"].ReadOnly = true;
            }
        }


      


        private void ValidatedItemforApproval()
        {
            if (this.GlobalStatePopup.Total_item_for_allocation == "0")
            {
                //this.ReturnFunctionality();
            }
            else
            {
                if (selection_mode == "1")
                {
                }
                else
                {



                    if (this.GlobalVariable.message_window_occur_for_approval_store_module != "1")
                    {
                        //Start Enabled for Sir Visoy 3/17/2021  JP
                        if (MetroFramework.MetroMessageBox.Show(this, "You have " + this.GlobalStatePopup.Total_item_for_allocation + " item for Allocation? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {

                            //this.modesplashScreenError = "1";

                            frmAllocationModule sistema = new frmAllocationModule();
                            sistema.MaximizeBox = false;
                            sistema.MinimizeBox = false;
                            sistema.ShowDialog();

                        }
                        else
                        {
                            //this.ReturnFunctionality();
                            //return;
                            this.GlobalStatePopup.YouHaveItemForAllocation();
                            //this.ReturnFunctionality();
                        }
                    }


                    //this.GlobalStatePopup.YouHaveItemForAllocation();
                    //this.ReturnFunctionality();
                    this.GlobalVariable.message_window_occur_for_approval_store_module = "1";
                    //END

                }

            }
        }


        private void showRawMaterialforApproval()    //method for loading available_menus
        {
            try
            {

                xClass.fillDataGridView(this.dgvFindDataForAlocation, "Raw_Materials_Dry_Allocation", dSet);

                this.GlobalStatePopup.Total_item_for_allocation = this.dgvFindDataForAlocation.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }




        public void loadCategoryDropdown()
        {
            try
            {
                //Walang For Allocation 

                myClass.fillComboBoxStoreOrderApproval(this.matcmbCategory, "Internal_Order_FilterByDate", this.dSet);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        private void ConnectionOpen()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            if (myClass.g_objStoredProc.getConnected() == true)
            {
                g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections();


                this.Rpt_Path = ULTRAMAVERICK.Properties.Settings.Default.fdg;


                this.dgvStoreOrderApproval.Columns[0].Width = 50;// The id column
                this.dgvStoreOrderApproval.Columns[3].Width = 150;// The id column

            }
            else
            {
                MessageBox.Show("Unable to connect in sql server", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        private void CheckTheForApprovalRadioButton()
        {
            if (this.matRadioForAllocation.Checked == false && this.matRadioForApproval.Checked == false)
            {
                this.matRadioForApproval.Checked = true;
                loadForScheduling();
            }

        }

        private void matcmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
            this.ConnectionOpen();
            this.load_search();
        }





        private void matRadioForAllocation_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Gerard");

            this.ConnectionOpen();
            this.loadMRSDropdownForAllocation();
            this.matcmbCategory_SelectionChangeCommitted(sender, e);

            //if (this.matRadioForApproval.Checked == true)
            //{
            //    this.matRadioForAllocation.Checked = true;
            //    this.ConnectionOpen();
            //    this.loadMRSDropdownForAllocation();
            //    this.matcmbCategory_SelectionChangeCommitted(sender, e);
            //}
        }

        private void matRadioForApproval_CheckedChanged(object sender, EventArgs e)
        {

            this.ConnectionOpen();
            this.loadForScheduling();
            this.matcmbCategory_SelectionChangeCommitted(sender, e);

            //if (this.matRadioForAllocation.Checked == false)
            //{
            //    this.matRadioForApproval.Checked = true;
            //    loadForScheduling();
            //}
            //if (this.matRadioForAllocation.Checked == true)
            //{
            //    this.matRadioForAllocation.Checked = false;
            //}

            //matcmbCategory_SelectionChangeCommitted(sender,e);

            //this.bunifuPrepaDate_ValueChanged(sender, e);


            //Functionality Viewing of the Data Binding Source
            //if (this.matRadioForAllocation.Checked == true)
            //{
            //    this.matRadioForApproval.Checked = true;
            //    this.loadForScheduling();
            //}
            //else if (this.matRadioForAllocation.Checked == true)
            //{
            //    this.loadMRSDropdownForAllocation();
            //}

            //if (this.matRadioForApproval.Checked == true)
            //{
            //    this.matRadioForAllocation.Checked = false;
            //    this.loadForScheduling();
            //}
            //else if (this.matRadioForAllocation.Checked == true)
            //{
            //    this.loadMRSDropdownForAllocation();
            //}


        }

        private void materialCheckboxSelectAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvStoreOrderApproval_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                //MessageBox.Show("Sample" + this.Sp_mrs_req_desc);
                this.dgvStoreOrderApproval.Enabled = false;
                //this.matbtnSave.Visible = false;
                ViewItemsInternalOrder addNew = 
            new ViewItemsInternalOrder(this,
             this.p_id,
             this.Sp_department_id,
             this.Sp_mrs_req_desc,
             this.Sp_mrs_requested_by,
             this.Sp_mrs_requested_date,
             this.Sp_total_items
             );
                addNew.ShowDialog();
                
            }
        }

        private void dgvStoreOrderApproval_CurrentCellChanged(object sender, EventArgs e)
        {
            this.showDataGridDataValueChanged();
        }



        private void showDataGridDataValueChanged()
        {
            if (this.dgvStoreOrderApproval.Rows.Count > 0)
            {
                if (this.dgvStoreOrderApproval.CurrentRow != null)
                {
                    if (this.dgvStoreOrderApproval.CurrentRow.Cells["department_id"].Value != null)
                    {
                        p_id = Convert.ToInt32(this.dgvStoreOrderApproval.CurrentRow.Cells["mrs_id"].Value);

                        this.Sp_department_id = this.dgvStoreOrderApproval.CurrentRow.Cells["department_id"].Value.ToString();
                        this.Sp_mrs_req_desc = this.dgvStoreOrderApproval.CurrentRow.Cells["mrs_req_desc"].Value.ToString();
                        this.Sp_mrs_requested_by = this.dgvStoreOrderApproval.CurrentRow.Cells["mrs_requested_by"].Value.ToString();
                        this.Sp_mrs_requested_date = this.dgvStoreOrderApproval.CurrentRow.Cells["mrs_requested_date"].Value.ToString();
                        this.Sp_total_items = this.dgvStoreOrderApproval.CurrentRow.Cells["TOTAL_ITEMS"].Value.ToString();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "TouchedScreen")
            {
                this.dgvStoreOrderApproval.Enabled = true;
                this.textBox1.Text = String.Empty;
                this.loadCategoryDropdown();
                this.matcmbCategory_SelectionChangeCommitted(sender, e);
            }

          
        }

        private void matbtnPrint_Click(object sender, EventArgs e)
        {

        }

        private void labelSelectedSum_TextChanged(object sender, EventArgs e)
        {
   

        }


      











    }
}
