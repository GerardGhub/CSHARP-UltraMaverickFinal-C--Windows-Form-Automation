using COMPLETE_FLAT_UI.Models;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ULTRAMAVERICK.Forms.Dry_Warehouse.External.Preparation;
using ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module;
using ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module.Major_Process.Class_Form;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class frmStoreOrderforApproval : MaterialForm
    {
        readonly myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        public DataSet dset = new DataSet();
        DataSet dset2 = new DataSet();
        int LatestForeignKeyInMasterStoreTable = 0;
        DataSet dSet = new DataSet();
        DataSet dSetCheckStoreCount = new DataSet();
        DataSet dSetCategoryPartialValidation = new DataSet();
        int forApprovalDateNeededValidation = 0;
  
        int p_id = 0;
        string datastorage;
        string Rpt_Path = "";
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        readonly frmNewStoreOrderApprovedClasses FormClass = new frmNewStoreOrderApprovedClasses();
        readonly myglobal GlobalVariable = new myglobal();
        string selection_mode = "";
        readonly string  modesplashScreenError = "";
        int DateValidCount = 0;
        int NotDateValidCount = 0;
        int MyCurrentRowIndex = 0;
        int DateValidCountSelected = 0;
        int NotDateValidCountSelected = 0;

        public frmStoreOrderforApproval()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }


        private void ConnectionOpen()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections

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



        private void frmStoreOrderforApproval_Load(object sender, EventArgs e)
        {       
            this.CheckTheForApprovalRadioButton();
            this.ConnectionOpen();
            this.ShowRawMaterialforApproval();   
           this.ValidatedItemforApproval();
     
            if(this.modesplashScreenError == "1")
            {            
                return;
            }
            this.VisibilityFalseDataGrid();
            if (this.lbltotaldata.Text == "0")
            {
                this.bunifuPrepaDate.Enabled = false;
                this.matcmbCategory.Enabled = false;
                this.matbtnApprove.Visible = false;
                this.matbtnCancel.Visible = false;
            }
            else
            {

                this.matcmbCategory.Enabled = true;

                if(num != 0)
                {
                    this.matbtnApprove.Visible = true;
                    this.matbtnCancel.Visible = true;
                }
                else
                {
                    this.matbtnApprove.Visible = false;
                    this.matbtnCancel.Visible = false;
                }
                       
                this.Load_search();
                selection_mode = "0";
            }
            if(lbltotaldata.Text == "0")
            {
            
            }
            else
            {
                this.GlobalVariable.for_approval_store_module_formLoad = "1";
            }
            this.LoadAreaDropdown();
            if (this.DateValidCount != 0 || this.NotDateValidCount != 0)
            {

            }
            else
            {
                this.GrandTotalSummary();
            }
            }


        private void GrandTotalSummary()
        {
 
            for (int i = 0; i < this.dgvStoreOrderApproval.RowCount; i++)
            {
          
                if (Convert.ToDateTime(this.dgvStoreOrderApproval.Rows[i].Cells["dateNeeded"].Value) > DateTime.Now.Date
                    || Convert.ToDateTime(this.dgvStoreOrderApproval.Rows[i].Cells["dateNeeded"].Value) == DateTime.Now.Date)

                {
                    DateValidCount++;
                    this.lblvalid.Text = DateValidCount.ToString();

                this.lblValidSelected.Text = this.DateValidCountSelected.ToString();

                    
                }
                else
                {
                    NotDateValidCount++;
          
                    this.lblnotvalid.Text = NotDateValidCount.ToString();

                    this.lblnotSelected.Text = this.NotDateValidCountSelected.ToString();
                }
            }


            if(this.DateValidCount == 0)
            {
                this.DateValidCount = 0;

                this.lblvalid.Text = DateValidCount.ToString();

                this.lblValidSelected.Text = this.DateValidCountSelected.ToString();
            }

            if(this.NotDateValidCount == 0)
            {
                this.NotDateValidCount = 0;

                this.lblnotvalid.Text = this.NotDateValidCountSelected.ToString();

                this.lblnotSelected.Text = this.NotDateValidCountSelected.ToString();
            }

            
        }

        private void GrandTotalSummarySelectedIncrement ()
        {

            this.NotDateValidCountSelected = 0;
            this.lblnotSelected.Text = NotDateValidCountSelected.ToString();

            this.DateValidCountSelected = 0;
            this.lblValidSelected.Text = this.DateValidCountSelected.ToString();

            for (int i = 0; i < this.dgvStoreOrderApproval.RowCount; i++)
            {

                if (Convert.ToDateTime(this.dgvStoreOrderApproval.Rows[i].Cells["dateNeeded"].Value) > DateTime.Now.Date
                    || Convert.ToDateTime(this.dgvStoreOrderApproval.Rows[i].Cells["dateNeeded"].Value) == DateTime.Now.Date)

                {
                    this.DateValidCountSelected++;
                    this.lblValidSelected.Text = DateValidCountSelected.ToString();              
                }
                else
                {
                    NotDateValidCountSelected++;
                    this.lblnotSelected.Text = NotDateValidCountSelected.ToString();
                }
            }
        }

        private void GrandTotalSummarySelectedDecrement()
        {

            for (int i = 0; i < this.dgvStoreOrderApproval.RowCount; i++)
            {

                if (Convert.ToDateTime(this.dgvStoreOrderApproval.Rows[i].Cells["dateNeeded"].Value) > DateTime.Now.Date
                    || Convert.ToDateTime(this.dgvStoreOrderApproval.Rows[i].Cells["dateNeeded"].Value) == DateTime.Now.Date)

                {
                    DateValidCountSelected--;
                    this.lblValidSelected.Text = DateValidCountSelected.ToString();
                }
                else
                {
                    NotDateValidCountSelected--;
                    this.lblnotSelected.Text = NotDateValidCountSelected.ToString();

                }
            }
        }

        public void LoadAreaDropdown()
        {
            try
            {
                if (this.matRadioForAllocation.Checked  == true)
                {
                    myClass.fillComboBoxStoreOrderApprovalSync(this.cmbArea, "tblStoreOrderDryWH_dropdown_ApprovalAreaBinding_RadioAllocation", this.dSet, this.matcmbCategory.Text, "", this.matcmbCategory.Text, "");

                }
                else if (this.matRadioForApproval.Checked == true)
                {
                    myClass.fillComboBoxStoreOrderApprovalSync(this.cmbArea, "tblStoreOrderDryWH_dropdown_ApprovalAreaBinding", this.dSet, this.matcmbCategory.Text, "", this.matcmbCategory.Text, "");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CheckTheForApprovalRadioButton()
        {
            if (this.matRadioForAllocation.Checked == false && this.matRadioForApproval.Checked == false)
            {
                this.matRadioForApproval.Checked = true;
            }        
        }


        private void VisibilityFalseDataGrid()
        {
            if (this.lbltotaldata.Text != "0")
            {
                if(this.MatRadioBtnInactive.Checked == true)
                {
                    this.dgvStoreOrderApproval.Columns["is_active"].Visible = false;
                    this.dgvStoreOrderApproval.Columns["is_cancelled"].Visible = false;

                    this.dgvStoreOrderApproval.Columns["is_cancelled_by"].Visible = true;
                    this.dgvStoreOrderApproval.Columns["is_cancelled_date"].Visible = true;
                    this.dgvStoreOrderApproval.Columns["is_cancelled_reason"].Visible = true;
                    this.dgvStoreOrderApproval.Columns["id"].Visible = false;
                }
            
                else
                {
                    this.dgvStoreOrderApproval.Columns["is_cancelled_by"].Visible = false;
                    this.dgvStoreOrderApproval.Columns["is_cancelled_date"].Visible = false;
                    this.dgvStoreOrderApproval.Columns["is_cancelled_reason"].Visible = false;
                }

               
                this.dgvStoreOrderApproval.Columns["order_id"].Visible = false;
                this.dgvStoreOrderApproval.Columns["primary_id"].Visible = false;
                this.dgvStoreOrderApproval.Columns["AVERAGE_ORDER_DAY_SET_UP"].Visible = false;
                this.dgvStoreOrderApproval.Columns["ORDERS"].Visible = false;
                this.dgvStoreOrderApproval.Columns["QTY_RECEIVED_ORDER"].Visible = false;
                this.dgvStoreOrderApproval.Columns["TOTAL_COLUMN_ALLOCATED_QTY"].Visible = false;
 
            }


        }



        private void ValidatedItemforApproval()
        {
            if (this.GlobalStatePopup.Total_item_for_allocation == "0")
            {
                this.ReturnFunctionality();
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
                        if (MetroFramework.MetroMessageBox.Show(this, "You have " + this.GlobalStatePopup.Total_item_for_allocation + " item for Allocation? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            frmAllocationModule sistema = new frmAllocationModule();
                            sistema.MaximizeBox = false;
                            sistema.MinimizeBox = false;
                            sistema.ShowDialog();
                        }
                        else
                        {
                            this.GlobalStatePopup.YouHaveItemForAllocation();
                            this.ReturnFunctionality();
                        }
                    }                
                    this.GlobalVariable.message_window_occur_for_approval_store_module = "1";

                }

            }
        }
        private void DataGridColumnDisabledEditing()
        {
            this.dgvStoreOrderApproval.Columns["primary_id"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["order_id"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["fox"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["store_name"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["route"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["area"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["category"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["item_code"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["description"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["uom"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["qty"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["date_added"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["StockOnHand"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["ALLOCATION_QTY"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["ORDERS"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["date_ordered"].ReadOnly = true;
        }
        private void ReturnFunctionality()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); 
            this.DataRefresher();
            myglobal.global_module = "Active";

            if(this.matRadioForApproval.Checked == true)
            {
                this.loadCategoryDropdown();
            }
            else if (this.matRadioForAllocation.Checked == true)
            {
                this.LoadCategoryDropdownForAllocation();
            }
          
            this.InitiliazeDatePickerMinDate();
            this.FormClass.mode = "";
            this.dset_emp1.Clear();
            this.dset_emp1 = g_objStoredProcCollection.sp_getMajorTables("searchorderForApprovalinDryWH");
            DataView dv = new DataView(this.dset_emp1.Tables[0]);

            this.dgvStoreOrderApproval.DataSource = dv;
            this.lbltotaldata.Text = dgvStoreOrderApproval.RowCount.ToString();
            if (this.lbltotaldata.Text == "0")
            {
                this.groupColorCoding.Visible = false;
            }
            else
            {
                this.groupColorCoding.Visible = true;
            }

            this.SaveButtonManipulator();
            this.DataGridColumnDisabledEditing();

        }


        private void ShowRawMaterialforApproval()   
        {
            try
            {
                myClass.fillDataGridView(this.dgvFindDataForAlocation, "Raw_Materials_Dry_Allocation", dSet);
                this.GlobalStatePopup.Total_item_for_allocation = this.dgvFindDataForAlocation.RowCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void InitiliazeDatePickerMinDate()
        {
            this.bunifuPrepaDate.MinDate = DateTime.Now;
            this.bunifuPrepaDate.MaxDate = DateTime.Now.AddDays(30);
        }
      
        public void loadCategoryDropdown()
        {
            try
            {
                this.myClass
                .fillComboBoxStoreOrderApproval(this.matcmbCategory, 
                "tblStoreOrderDryWH_dropdown_Approval",
                 this.dSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

public void LoadCategoryDropdownForAllocation()
{
    try
    {
        myClass.fillComboBoxStoreOrderApproval(this.matcmbCategory, "tblStoreOrderDryWH_dropdown_Approval_For_Allocation", this.dSet);
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
}

        DataSet dset_emp1 = new DataSet();
        private void Load_search()
        {
            this.dset_emp1.Clear();
            if (this.matRadioForAllocation.Checked == true)
            {
                this.dset_emp1 = g_objStoredProcCollection.sp_getMajorTables("searchorderForApprovalinDryWHRadioAllocate");
            }
            else if (this.matRadioForApproval.Checked == true)
            {
                this.dset_emp1 = g_objStoredProcCollection.sp_getMajorTables("searchorderForApprovalinDryWH");
            }
            this.doSearch();
        }

        private void DataRefresher()
        {
            this.dset = g_objStoredProcCollection
            .sp_IDGenerator(0, 
            "resetreceivingreprint", 
            "", 
            "", 
            6, 0);
            this.FormClass.sp_user_id = userinfo.user_id;
        }


        private void doSearch()
        {
            try
            {
                if (this.dset_emp1.Tables.Count > 0)
                {
                    DataView dv = new DataView(this.dset_emp1.Tables[0]);
                        dv.RowFilter = "  category = '" + this.matcmbCategory.Text + "'  ";    
                    this.dgvStoreOrderApproval.DataSource = dv;
                    this.lbltotaldata.Text = dgvStoreOrderApproval.RowCount.ToString();
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
     
        private void matcmbPackaging_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.selection_mode = "1";
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections();

            this.Load_search();

            if (this.lbltotaldata.Text == "0")
            {

            }
            else
            {
                this.TaggingConflictCategoryValidation();
            }
            this.LoadAreaDropdown();
        }



        private void TaggingConflictCategoryValidation()
        {
           
            this.dset2.Clear();
            this.dset2 = g_objStoredProcCollection.sp_Store_Preparation_Logs(0,
            this.matcmbCategory.Text,
            this.bunifuPrepaDate.Text,
            "", 
            "", 
            "", 
            "", 
            "", 
            "",
            0,
            this.matcmbCategory.Text,
            "", 
            "",
            0,
            "check_if_already_prepared_conflict_category_getcount");

            if (dset2.Tables[0].Rows.Count > 0)
            {
                

            this.dSet.Clear();
            this.dSet = g_objStoredProcCollection.sp_Store_Preparation_Logs(0,
            this.matcmbCategory.Text.Trim(),
            this.bunifuPrepaDate.Text.Trim(),
            "",
            "",
            "",
            "", 
            "", 
            "",
            0,
            this.matcmbCategory.Text.Trim(),
            "", 
            "", 0,
            "check_if_already_prepared_conflict_category");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    this.DoubleTaggingNotFound();
                }
                else
                {
          
                    if (num ==0)
                    {

                    }
                    else
                    {
                        this.GlobalStatePopup.TripleTaggingCategoryInformation();
                    }
                    if (dSet.Tables.Count.ToString() == "2")
                    {
                        this.DoubleTaggingFound(); 
                    }                                      
                }
            }
            else
            {              
                this.DoubleTaggingNotFound();
            }
        }



        private void DoubleTaggingFound()
        {
            this.dgvStoreOrderApproval.Enabled = false;
            this.materialCheckboxSelectAll.Enabled = false ;
        }

        private void DoubleTaggingNotFound()
        {
            this.dgvStoreOrderApproval.Enabled = true;
            this.materialCheckboxSelectAll.Enabled = true;
        }



        private void lbltotaldata_TextChanged(object sender, EventArgs e)
        {     
            if (this.lbltotaldata.Text == "0")
            {
                this.materialCheckboxSelectAll.Visible = false;
                this.labelSelectedSum.Visible = false;
                this.matbtnEdit.Visible = false;
                this.matbtnApprove.Visible = false;
                this.matbtnCancel.Visible = false;
                this.bunifuPrepaDate.Enabled = false;
            }
            else
            {
                if(this.matRadioForAllocation.Checked == true)
                {
                    this.materialCheckboxSelectAll.Visible = false;
                    this.dgvStoreOrderApproval.Columns["selected"].Visible = false;
                    this.lblAllocationRemarks.Visible = true;
                    this.bunifuPrepaDate.Enabled = false;
                    this.cmbArea.Enabled = false;
                    if (this.dgvStoreOrderApproval.RowCount > 0)
                    {
                        this.matcmbCategory.Enabled = true;
                    }

                    }
                else if (this.MatRadioBtnInactive.Checked == true)
                {
                    this.materialCheckboxSelectAll.Visible = false;
                    this.dgvStoreOrderApproval.Columns["selected"].Visible = false;
                    this.lblAllocationRemarks.Visible = false;
                }
                else
                {
                    this.materialCheckboxSelectAll.Visible = true;
                    this.dgvStoreOrderApproval.Columns["selected"].Visible = true;
                    this.lblAllocationRemarks.Visible = false;
                    this.bunifuPrepaDate.Enabled = true;
                    this.cmbArea.Enabled = true;
                    this.matcmbCategory.Enabled = true;
                }                   
            }
        }


        int num = 0;
        private void dgvReprinting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bool isChecked = (bool)dgvStoreOrderApproval.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
                CheckCount(isChecked);
                this.StateChangeOnTaggingPreparationDate();

                if (Convert.ToDateTime(this.dgvStoreOrderApproval.Rows[e.RowIndex].Cells["dateNeeded"].Value) > DateTime.Now.Date
                    || Convert.ToDateTime(this.dgvStoreOrderApproval.Rows[e.RowIndex].Cells["dateNeeded"].Value) == DateTime.Now.Date)
                {
                    if(this.NotDateValidCountSelected == 0)
                    {
                        this.matbtnApprove.Enabled = true;
                    }
                    else
                    {
                        this.matbtnApprove.Enabled = false;
                    }         
                }
                else
                {                
                    if (this.NotDateValidCountSelected == 0)
                    {
                        this.matbtnApprove.Enabled = true;
                    }
                    else
                    {
                        this.matbtnApprove.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }



        private void StateChangeOnTaggingPreparationDate()
        {
            if (this.num == 0)
            {
    
            }
            else
            {
                this.bunifuPrepaDate.Enabled = true;
            }
        }


        private void ValidateDateNeededforApproval()
        {
            if (Convert.ToDateTime(this.dgvStoreOrderApproval.Rows[this.MyCurrentRowIndex].Cells["dateNeeded"].Value) > DateTime.Now.Date
                || Convert.ToDateTime(this.dgvStoreOrderApproval.Rows[this.MyCurrentRowIndex].Cells["dateNeeded"].Value) == DateTime.Now.Date)
            {
       
                if (Convert.ToBoolean(this.dgvStoreOrderApproval.Rows[this.MyCurrentRowIndex].Cells["selected"].Value = true))
                {
                    this.DateValidCountSelected++;
                    this.lblValidSelected.Text = this.DateValidCountSelected.ToString();
                }
                else
                {
                    this.DateValidCountSelected--;
                    this.lblValidSelected.Text = this.DateValidCountSelected.ToString();
                }
            }
            else
            {
             
                if (Convert.ToBoolean(dgvStoreOrderApproval.Rows[this.MyCurrentRowIndex].Cells["selected"].Value = true))
                {
      
                    this.NotDateValidCountSelected++;
                    this.lblnotSelected.Text = this.NotDateValidCountSelected.ToString();
                }
                else if (Convert.ToBoolean(dgvStoreOrderApproval.Rows[this.MyCurrentRowIndex].Cells["selected"].Value = false))
                {
          
                    this.NotDateValidCountSelected = NotDateValidCount - 1;
                    this.lblnotSelected.Text = this.NotDateValidCountSelected.ToString();
                }

            }
        }

        
        private void CheckCount(bool isChecked)
        {
            if (isChecked)
            {
                num++;
    
                if (this.materialCheckboxSelectAll.Checked == true && this.materialCheckboxSelectAll.Checked == false)
                {

                }
                else
                {
                    this.ValidateDateNeededforApproval();
                }
            }
            else
            {
                num--;

                if (Convert.ToDateTime(this.dgvStoreOrderApproval.Rows[this.MyCurrentRowIndex].Cells["dateNeeded"].Value) > DateTime.Now.Date
                    || Convert.ToDateTime(this.dgvStoreOrderApproval.Rows[this.MyCurrentRowIndex].Cells["dateNeeded"].Value) == DateTime.Now.Date)
                {
                    this.DateValidCountSelected--;
                    this.lblValidSelected.Text = this.DateValidCountSelected.ToString();
                }
                else
                {
                    this.NotDateValidCountSelected = NotDateValidCountSelected - 1;
                    this.lblnotSelected.Text = this.NotDateValidCountSelected.ToString();
                }
            }
            this.labelSelectedSum.Text = "Selected Items: " + num;
            this.labelSelectedSum.Visible = true;
            this.SaveButtonManipulator();
            this.EditManipulator();
        }
        private void EditManipulator()
        {
            if(this.num == 1)
            {
                this.matbtnApprove.Visible = true;
                this.matbtnCancel.Visible = true;
                this.matbtnEdit.Visible = true;
            }
            else
            {
                this.matbtnEdit.Visible = false;

            }
        }

        private void dgvReprinting_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStoreOrderApproval.Rows[e.RowIndex].Cells["selected"].ReadOnly == false)
            {
                bool isChecked = (bool)dgvStoreOrderApproval.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
                CheckCount(isChecked);
            }
        }

        private void lbltotaldata_Click(object sender, EventArgs e)
        {

        }
        private void ApproveFunctionality()
        {

            for (int i = 0; i <= dgvStoreOrderApproval.RowCount - 1; i++)
            {
                try
                {
                    if (dgvStoreOrderApproval.CurrentRow != null)
                    {

                        if (Convert.ToBoolean(dgvStoreOrderApproval.Rows[i].Cells["selected"].Value) == true)
                        {
                            if (datastorage == this.dgvStoreOrderApproval.Rows[i].Cells["fox"].Value.ToString())
                            {
                                this.dgvStoreOrderApproval.CurrentCell = this.dgvStoreOrderApproval.Rows[i].Cells[this.dgvStoreOrderApproval.CurrentCell.ColumnIndex];
                                dset = g_objStoredProcCollection
                                .sp_IDGenerator(int.Parse(dgvStoreOrderApproval.Rows[i].Cells["primary_id"].Value.ToString()),
                                "PUTStoreOrderApproval",
                                this.bunifuPrepaDate.Text,
                                this.FormClass.sp_user_id.ToString(),
                                1,
                                this.LatestForeignKeyInMasterStoreTable);

                                //this.ExecuteMasterTablePreparationStore();
                            }
                            else
                            {
                                this.dSetCheckStoreCount.Clear();
                                this.dSetCheckStoreCount = g_objStoredProcCollection.sp_getMajorTables("Dry_Wh_Order_Parent_Store");


                                this.LatestForeignKeyInMasterStoreTable = Convert.ToInt32(this.dSetCheckStoreCount.Tables[0].Rows[0]["LatestNumber"]);



                                this.dgvStoreOrderApproval.CurrentCell = this.dgvStoreOrderApproval.Rows[i].Cells[this.dgvStoreOrderApproval.CurrentCell.ColumnIndex];
                                dset = g_objStoredProcCollection
                                .sp_IDGenerator(int.Parse(dgvStoreOrderApproval.Rows[i].Cells["primary_id"].Value.ToString()),
                                "PUTStoreOrderApproval",
                                this.bunifuPrepaDate.Text,
                                this.FormClass.sp_user_id.ToString(),
                                1,
                                this.LatestForeignKeyInMasterStoreTable);

                                this.ExecuteMasterTablePreparationStore();
                            }
                            datastorage = this.dgvStoreOrderApproval.Rows[i].Cells["fox"].Value.ToString();



                        }
                        else
                        {


                        }
                        //MessageBox.Show(datastorage);
                    }
                }
                catch (Exception ex)
                {

                    this.dgvStoreOrderApproval.CurrentCell = this.dgvStoreOrderApproval.Rows[i].Cells[this.dgvStoreOrderApproval.CurrentCell.ColumnIndex];
    
                    MessageBox.Show(ex.Message);
                }

            }
    
            //this.ExecuteMasterTablePreparationStore();
            this.GlobalStatePopup.ApprovedSuccessfully();
            this.materialCheckboxSelectAll.Checked = false;
            this.labelSelectedSum.Visible = false;
    

            this.num = 0;
            this.matbtnEdit.Visible = false;

            this.DateValidCount = 0;
            this.NotDateValidCount = 0;

           this.frmStoreOrderforApproval_Load(new object(), new System.EventArgs());
          
        }

        private void GetParentIDCountinStore()
        {

            this.dSet.Clear();
            this.dSet = g_objStoredProcCollection.sp_getMajorTables("Dry_Wh_Order_Parent_Store");



            int Contract_id = Convert.ToInt32(dSet.Tables[0].Rows[0]["LatestNumber"]);

            //MessageBox.Show(Contract_id.ToString());
        }

        private void ExecuteMasterTablePreparationStore()
        {
            //this.ConnectionOpen();
            //this.dSetCheckStoreCount.Clear();
            //this.dSetCheckStoreCount = objStorProc.sp_getMajorTables("Dry_Wh_Order_Parent_Store");


            //this.LatestForeignKeyInMasterStoreTable = Convert.ToInt32(this.dSetCheckStoreCount.Tables[0].Rows[0]["LatestNumber"]);


            dset2.Clear();
            dset2 = g_objStoredProcCollection.sp_Dry_Wh_Order_Parent(0,
             "",
            this.FormClass.sp_fox,
            this.FormClass.sp_store_name,
            this.FormClass.sp_route,
            this.FormClass.sp_area,
            this.FormClass.sp_category, 
            0,
            "1",
            userinfo.user_id,
            "GETDATE()",
            this.bunifuPrepaDate.Text,
             "1",
            "add");
        }



        private void CancelFunctionality()
        {


            for (int i = 0; i <= dgvStoreOrderApproval.RowCount - 1; i++)
            {
                try
                {
                    if (dgvStoreOrderApproval.CurrentRow != null)
                    {

                        if (Convert.ToBoolean(dgvStoreOrderApproval.Rows[i].Cells["selected"].Value) == true)
                        {
                            this.dgvStoreOrderApproval.CurrentCell = 
                            this.dgvStoreOrderApproval.Rows[i].Cells[this.dgvStoreOrderApproval.CurrentCell.ColumnIndex];
                            dset = g_objStoredProcCollection
                            .sp_IDGenerator(int.Parse(dgvStoreOrderApproval.Rows[i].Cells["primary_id"].Value.ToString()), 
                            "CancelStoreOrderApprovalIndividual", 
                            this.textBox2Cancel.Text, 
                            this.FormClass.sp_user_id.ToString(), 1,0);

                        }
                        else
                        {


                        }
                    }
                }
                catch (Exception ex)
                {

                 
                    MessageBox.Show(ex.Message);
                }

            }

            this.GlobalStatePopup.CancelledSuccessfully();
            this.materialCheckboxSelectAll.Checked = false;
            this.labelSelectedSum.Visible = false;


            this.num = 0;
            this.matbtnEdit.Visible = false;
            this.textBox2Cancel.Text = String.Empty;
            this.frmStoreOrderforApproval_Load(new object(), new System.EventArgs());

        }




        private void matbtnPrint_Click(object sender, EventArgs e)
        {
            //this.dSetCheckStoreCount.Clear();
            //this.dSetCheckStoreCount = objStorProc.sp_getMajorTables("Dry_Wh_Order_Parent_Store");
            //if (this.dSetCheckStoreCount.Tables.Count == 0)
            //{

            //}
            //else
            //{

            //    this.LatestForeignKeyInMasterStoreTable = Convert.ToInt32(this.dSetCheckStoreCount.Tables[0].Rows[0]["LatestNumber"]);
            //    //MessageBox.Show(LatestForeignKeyInMasterStoreTable.ToString());
            //}

            //Code for Approval on The Preparation Date 
            if (this.lbltotaldata.Text == "0")
            {

            }
            else
            {
    
                if (num == 0)
                {
                    return;
                }



                dset2.Clear();
                dset2 = g_objStoredProcCollection.sp_Store_Preparation_Logs(0,
                this.matcmbCategory.Text,
                this.bunifuPrepaDate.Text,
                "",
                "",
                "",
                "",
                "",
                "",
                0,
                this.matcmbCategory.Text,
                "",
                "", 
                0,
                "check_if_already_prepared_conflict_category_getcount");

                if (dset2.Tables[0].Rows.Count > 0)
                {

            
                    this.dSet.Clear();
                    this.dSet = g_objStoredProcCollection.sp_Store_Preparation_Logs(
                    0,
                    this.matcmbCategory.Text,
                    this.bunifuPrepaDate.Text,
                    "", 
                    "", 
                    "", 
                    "", 
                    "", 
                    "", 
                    0,
                    this.matcmbCategory.Text, 
                    "", 
                    "",
                    0,
                    "check_if_already_prepared_conflict_category");

                    if (this.dSet.Tables[0].Rows.Count > 0)
                    {
 
                        this.dSetCategoryPartialValidation.Clear();
                        this.dSetCategoryPartialValidation = g_objStoredProcCollection.sp_Store_Preparation_Logs(0,
                        this.matcmbCategory.Text,
                        this.bunifuPrepaDate.Text,
                        "", 
                        "", 
                        "", 
                        "", 
                        "", 
                        "",
                        0,
                        this.matcmbCategory.Text.Trim(), 
                        "", 
                        "",
                        0,
                        "check_if_already_prepared_conflict_category_validation");
                        if (dSetCategoryPartialValidation.Tables[0].Rows.Count > 0)
                        {

                        }
                        else
                        {


                            if (dSet.Tables[0].Rows.Count.ToString() == "3")
                            {

  
                                this.GlobalStatePopup.TripleTaggingCategoryInformation();

                                this.DoubleTaggingFound();
                                return;
                            }
                        }

                    }
                    else
                    {
                        

                            if (dSet.Tables[0].Rows.Count.ToString() == "3")
                        {


                            this.GlobalStatePopup.TripleTaggingCategoryInformation();
                            this.DoubleTaggingFound();
                            return;
                        }


                    }



                }
                else
                {
               
               
                    this.DoubleTaggingNotFound();
                }

            }

            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections



            



            this.ShowRawMaterialforApproval();
     
            if (this.matRadioForAllocation.Checked == true)
            {
        
                //Start
                if (this.GlobalStatePopup.Total_item_for_allocation == "0")
                {
                    //Start Blocked

                    if (MetroFramework.MetroMessageBox.Show(this, "Approve the consolidated order? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        this.ApproveFunctionality();
                    }
                    else
                    {

                        return;
                    }


                    //End Blocked Peru


                }
                else
                {
                    this.GlobalStatePopup.AllocationiSRequiredNotify();
                    return;
                }

                //End
            }
            else if(this.matRadioForApproval.Checked == true)
            {
                //Start Blocked
          
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_Store_Preparation_Logs(0,
               this.matcmbCategory.Text,
                this.bunifuPrepaDate.Text,
                "", "", "", "", "", "", 0,
                  this.matcmbCategory.Text, "", "", 0,
                "check_if_already_prepared_conflict_category");

                if (dSet.Tables[0].Rows.Count > 0)
                {

                    if (dSet.Tables[0].Rows.Count.ToString() == "1")
                    {
                        if (MetroFramework.MetroMessageBox.Show(this, "You have 1 existing category tagged, Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            this.ApproveFunctionality();
                        }
                        else
                        {

                            return;
                        }
                    }
                    else if (dSet.Tables[0].Rows.Count.ToString() == "2")
                    {

                        //Data Set for Validation
                        //Validate that Partial tagging is allowed on the fucking system
                        dSetCategoryPartialValidation.Clear();
                        dSetCategoryPartialValidation = g_objStoredProcCollection.sp_Store_Preparation_Logs(0,
                       this.matcmbCategory.Text,
                        this.bunifuPrepaDate.Text,
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        0,
                          this.matcmbCategory.Text,
                          "",
                          "", 0,
                        "check_if_already_prepared_conflict_category_validation");
                        if (dSetCategoryPartialValidation.Tables[0].Rows.Count > 0)
                        {
                            if (MetroFramework.MetroMessageBox.Show(this, "You have 30 existing category tagged, Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                this.ApproveFunctionality();
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            if (MetroFramework.MetroMessageBox.Show(this, "You have 2 existing category tagged, Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                this.ApproveFunctionality();
                            }
                            else
                            {

                                return;
                            }
                        }
                    }
                    else
                    {

                        if (MetroFramework.MetroMessageBox.Show(this, "Approve the consolidated order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            this.ApproveFunctionality();
                        }
                        else
                        {

                            return;
                        }
                    }

                }
                else
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Approve the consolidated order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        this.ApproveFunctionality();
                    }
                    else
                    {

                        return;
                    }
                }

                //End Blocked Loop ElseIf
            }



        }

        private void materialCheckboxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            this.materialCheckboxSelectAll.Text = "UnSelect ALL";

            for (int i = 0; i < this.dgvStoreOrderApproval.RowCount; i++) 
            {

                this.dgvStoreOrderApproval.Rows[i].Cells[0].Value = true;

                if (this.forApprovalDateNeededValidation == 1)
                {
                    this.matbtnApprove.Enabled = false;
                }
                else if (this.forApprovalDateNeededValidation == 0)
                {
                    this.matbtnApprove.Enabled = true;
                }
            }


            if (this.materialCheckboxSelectAll.Checked ==true)
            {
                this.labelSelectedSum.Visible = true;
                this.labelSelectedSum.Text = "Selected Items: " + this.dgvStoreOrderApproval.RowCount.ToString();
                this.num = this.dgvStoreOrderApproval.RowCount;
                this.SaveButtonManipulator();
                this.GrandTotalSummarySelectedIncrement();
            }
            else
            {          
                this.materialCheckboxSelectAll.Text = "Select ALL";
                for (int i = 0; i < dgvStoreOrderApproval.RowCount; i++) { dgvStoreOrderApproval.Rows[i].Cells[0].Value = false; }
                this.labelSelectedSum.Text = "Selected Items: " + 0;
                this.num = 0;
                this.SaveButtonManipulator();
                this.GrandTotalSummarySelectedDecrement();
                this.frmStoreOrderforApproval_Load(sender, e);
            }

            this.StateChangeOnTaggingPreparationDate();
        }



        private void SaveButtonManipulator()
        {
            if (this.labelSelectedSum.Text == "0")
            {
                this.matbtnApprove.Visible = false;
                this.matbtnCancel.Visible = false;
            }
            else if(num == 0)
            {
                this.matbtnApprove.Visible = false;
                this.matbtnCancel.Visible = false;
                   
            }
            else
            {
                this.matbtnApprove.Visible = true;
                this.matbtnCancel.Visible = true;
            }
        }



        private void labelSelectedSum_TextChanged(object sender, EventArgs e)
        {
            this.SaveButtonManipulator();    
        }

        private void matbtnEdit_Click(object sender, EventArgs e)
        {
            this.matbtnEdit.Visible = false;
            this.matbtnApprove.Visible = false;
            this.matbtnCancel.Visible = false;
        
            frmEditConsolidatedOrder mywipwh = new frmEditConsolidatedOrder(this, 
                p_id,
                this.FormClass.sp_order_id,
                this.FormClass.sp_date_ordered,
                this.FormClass.sp_fox,
                this.FormClass.sp_store_name,
                this.FormClass.sp_route,
                this.FormClass.sp_area,
                this.FormClass.sp_category,
                this.FormClass.sp_item_code,
                this.FormClass.sp_description,
                this.FormClass.sp_uom,
                this.FormClass.sp_qty,
                this.FormClass.sp_StockOnHand,
                this.FormClass.sp_Allocated_Qty,
                this.FormClass.Sp_Reserved_Qty,
                this.FormClass.Sp_Allocation_Identity
                );
            mywipwh.ShowDialog();
        }

        private void dgvReprinting_CurrentCellChanged(object sender, EventArgs e)
        {
            this.showDataGridDataValueChanged();
        }

        private void showDataGridDataValueChanged()
        {
            if (this.dgvStoreOrderApproval.Rows.Count > 0)
            {
                if (this.dgvStoreOrderApproval.CurrentRow != null)
                {
                    if (this.dgvStoreOrderApproval.CurrentRow.Cells["fox"].Value != null)
                    {
                        p_id = Convert.ToInt32(this.dgvStoreOrderApproval.CurrentRow.Cells["primary_id"].Value);
                        this.MyCurrentRowIndex = this.dgvStoreOrderApproval.CurrentCell.RowIndex;
                       this.FormClass.sp_order_id = Convert.ToInt32(this.dgvStoreOrderApproval.CurrentRow.Cells["order_id"].Value);
                        this.FormClass.sp_date_ordered = this.dgvStoreOrderApproval.CurrentRow.Cells["date_ordered"].Value.ToString();
                        this.FormClass.sp_fox = this.dgvStoreOrderApproval.CurrentRow.Cells["fox"].Value.ToString();
                        this.FormClass.sp_store_name = this.dgvStoreOrderApproval.CurrentRow.Cells["store_name"].Value.ToString();
                        this.FormClass.sp_route = this.dgvStoreOrderApproval.CurrentRow.Cells["route"].Value.ToString();
                        this.FormClass.sp_area = this.dgvStoreOrderApproval.CurrentRow.Cells["area"].Value.ToString();
                        this.FormClass.sp_category = this.dgvStoreOrderApproval.CurrentRow.Cells["category"].Value.ToString();
                        this.FormClass.sp_item_code = this.dgvStoreOrderApproval.CurrentRow.Cells["item_code"].Value.ToString();
                        this.FormClass.sp_description = this.dgvStoreOrderApproval.CurrentRow.Cells["description"].Value.ToString();
                        this.FormClass.sp_uom = this.dgvStoreOrderApproval.CurrentRow.Cells["uom"].Value.ToString();
                        this.FormClass.sp_qty = this.dgvStoreOrderApproval.CurrentRow.Cells["qty"].Value.ToString();
                        this.FormClass.sp_StockOnHand = this.dgvStoreOrderApproval.CurrentRow.Cells["StockOnHand"].Value.ToString();
                        this.FormClass.sp_Allocated_Qty = this.dgvStoreOrderApproval.CurrentRow.Cells["ALLOCATION_QTY"].Value.ToString();
                        this.FormClass.Sp_Reserved_Qty = this.dgvStoreOrderApproval.CurrentRow.Cells["RESERVED"].Value.ToString();
                        this.FormClass.Sp_Allocation_Identity = Convert.ToInt32(this.dgvStoreOrderApproval.CurrentRow.Cells["primary_id"].Value);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {       
            this.materialCheckboxSelectAll.Text = "Select All";
            //Reset the NUmber 
            this.textBox1.Text = String.Empty;
            this.num = 0;
            this.labelSelectedSum.Visible = false;
            this.frmStoreOrderforApproval_Load(sender, e);
        }

        private void dgvStoreOrderApproval_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (this.MatRadioBtnInactive.Checked == true)
            {
                return;
            }
             else
            {
                foreach (DataGridViewRow row in dgvStoreOrderApproval.Rows)
                {
                    if (Convert.ToDouble(row.Cells["ORDERS"].Value) >= Convert.ToDouble(row.Cells["StockOnHand"].Value))
                    {
                        if (this.matRadioForAllocation.Checked == true)
                        {
                            row.Cells["qty"].Style.SelectionBackColor = Color.DarkOrange;
                            row.Cells["qty"].Style.SelectionForeColor = Color.Black;
                            row.Cells["qty"].Style.BackColor = Color.DarkOrange;
                        }
                    }
                    else
                    {
                        row.Cells["qty"].Style.BackColor = Color.White;
                    }


                    if (Convert.ToDouble(row.Cells["qty"].Value) < Convert.ToDouble(row.Cells["AVERAGE_ORDER"].Value))
                    {
                        //QTY remove
                        row.Cells["AVERAGE_ORDER"].Style.SelectionBackColor = Color.Crimson;
                        row.Cells["AVERAGE_ORDER"].Style.SelectionForeColor = Color.Black;
                        row.Cells["AVERAGE_ORDER"].Style.BackColor = Color.Crimson;
                    }


                    if (Convert.ToDouble(row.Cells["StockOnHand"].Value) == Convert.ToDouble(row.Cells["ALLOCATION_QTY"].Value))
                    {

                        row.Cells["qty"].Style.BackColor = Color.White;
                    }

                    if (Convert.ToDouble(row.Cells["StockOnHand"].Value) == 0)
                    {

                        row.Cells["StockOnHand"].Style.SelectionBackColor = Color.Crimson;
                        row.Cells["StockOnHand"].Style.SelectionForeColor = Color.Black;
                        row.Cells["StockOnHand"].Style.BackColor = Color.Crimson;
                    }


                    if (Convert.ToDouble(row.Cells["ALLOCATION_QTY"].Value) != 0)
                    {

                        if (this.matRadioForAllocation.Checked == true )
                        {
                            row.Cells["qty"].Style.SelectionBackColor = Color.DarkOrange;
                            row.Cells["qty"].Style.SelectionForeColor = Color.Black;
                            row.Cells["qty"].Style.BackColor = Color.DarkOrange;
                       
                        if (Convert.ToDouble(row.Cells["ORDERS"].Value) == Convert.ToDouble(row.Cells["TOTAL_COLUMN_ALLOCATED_QTY"].Value))
                            {

                                row.Cells["qty"].Style.BackColor = Color.White;
                            }
                            else
                            {
                                row.Cells["qty"].Style.SelectionBackColor = Color.DarkOrange;
                                row.Cells["qty"].Style.SelectionForeColor = Color.Black;
                                row.Cells["qty"].Style.BackColor = Color.DarkOrange;
                            }
                        }

                    }

                    if(row.Cells["dateNeeded"].Value == null)
                    {
            
                    }

                    if (Convert.ToDateTime(row.Cells["dateNeeded"].Value) > DateTime.Now.Date
                        || Convert.ToDateTime(row.Cells["dateNeeded"].Value) == DateTime.Now.Date)

                    {
                     }
                    else
                    {
                        this.forApprovalDateNeededValidation = 1;
                    }
                   
                }


            }

        }

        private void bunifuPrepaDate_ValueChanged(object sender, EventArgs e)
        {
            if (this.lbltotaldata.Text == "0")
            {

            }
            else
            {
                this.TaggingConflictCategoryValidation();
            }
        }

        private void matRadioForAllocation_CheckedChanged(object sender, EventArgs e)
        {
            this.ConnectionOpen();
            this.DataRefresher();
            this.ShowRawMaterialforApproval();
            if (this.matRadioForApproval.Checked == true)
            {
                this.loadCategoryDropdown();        
            }
            else if (this.matRadioForAllocation.Checked == true)
            {
                this.LoadCategoryDropdownForAllocation();
                if (this.dgvStoreOrderApproval.RowCount > 0)
                {
                    this.matcmbCategory.Enabled = true;
                }
            }
            this.matcmbPackaging_SelectionChangeCommitted(sender, e); 
        }



        private void matRadioForApproval_CheckedChanged(object sender, EventArgs e)
        {
            this.ConnectionOpen();
            if (this.matRadioForApproval.Checked == true)
            {
                this.loadCategoryDropdown();
            }
            else if (this.matRadioForAllocation.Checked == true)
            {
                this.LoadCategoryDropdownForAllocation();
            }
            if (this.GlobalVariable.for_approval_store_module_formLoad == "1")
            {
                g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); 
                this.Load_search();
            }
        }

        private void cmbArea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.FindAreaLocation();
        }

        private void FindAreaLocation()
        {
            this.dset_emp1.Clear();

            if(this.matRadioForAllocation.Checked == true)
            {
                this.dset_emp1 = g_objStoredProcCollection.sp_getMajorTables("searchorderForApprovalinDryWHRadioAllocate");
            }
            else
            {
                this.dset_emp1 = g_objStoredProcCollection.sp_getMajorTables("searchorderForApprovalinDryWH");
            }
            try
            {
                if (this.dset_emp1.Tables.Count > 0)
                {
                    DataView dv = new DataView(this.dset_emp1.Tables[0]);
                    if (myglobal.global_module == "GERARD SINGIAN")
                    {

                    }
                    else if (myglobal.global_module == "Active")
                    {
                        dv.RowFilter = "  category = '" + this.matcmbCategory.Text + "' and area = '" + this.cmbArea.Text + "'  ";
                    }
                    this.dgvStoreOrderApproval.DataSource = dv;
                    this.lbltotaldata.Text = dgvStoreOrderApproval.RowCount.ToString();
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
        }

        private void dgvStoreOrderApproval_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvStoreOrderApproval.ClearSelection();
        }

        private void matbtnCancel_Click(object sender, EventArgs e)
        {
            frmCancelExternalApprovedOrder FormCancelOrderRemarks = new frmCancelExternalApprovedOrder(this, this.matbtnCancel.Text);
            FormCancelOrderRemarks.ShowDialog();
        }

        private void textBox2Cancel_TextChanged(object sender, EventArgs e)
        {
            if(textBox2Cancel.Text == String.Empty)
            {
               
            }
            else
            {
                this.CancelFunctionality();
            }
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
                this.ConnectionOpen();
                this.SearchInactiveMaterial();
        }

        private void SearchInactiveMaterial()
        {
                try
                {
                this.myClass.fillDataGridView(this.dgvStoreOrderApproval, "SearchorderForApprovalinDryWHCancel", dSet);
                this.lbltotaldata.Text = this.dgvStoreOrderApproval.RowCount.ToString();
                this.VisibilityFalseDataGrid();
                 }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            if (this.lbltotaldata.Text == "0")
            {
                this.dgvStoreOrderApproval.Columns["is_active"].Visible = false;
                this.dgvStoreOrderApproval.Columns["is_cancelled"].Visible = false;
            }
        }

        private void matRadioForAllocation_Click(object sender, EventArgs e)
        {
            this.matRadioForAllocation_CheckedChanged(sender, e);
        }

        private void matRadioForApproval_Click(object sender, EventArgs e)
        {
            this.matRadioForApproval_CheckedChanged(sender, e);
        }

        private void MatRadioBtnInactive_Click(object sender, EventArgs e)
        {
            this.materialRadioButton1_CheckedChanged(sender, e);
        }

        private void labelSelectedSum_Click(object sender, EventArgs e)
        {

        }
    }
}
