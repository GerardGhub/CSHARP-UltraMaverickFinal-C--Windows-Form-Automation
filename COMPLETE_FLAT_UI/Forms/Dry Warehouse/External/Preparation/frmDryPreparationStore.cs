using COMPLETE_FLAT_UI.Models;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Preparation
{
    public partial class frmDryPreparationStore : MaterialForm
    {
        //Main Classs
        readonly myclasses xClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        //Data Set Initialization
        public DataSet dset = new DataSet();
        DataSet dset2 = new DataSet();
        DataSet dset3 = new DataSet();
        DataSet dSet = new DataSet();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();


        public frmDryPreparationStore()
        {
            InitializeComponent();
        }
        public string Sp_Qty_Serve { get; set; }
        public string Sp_fox { get; set; }
        public string Sp_route { get; set; }
        public string Sp_area { get; set; }
        public string Sp_approved_preparation_date { get; set; }


        //Receiving Table
        public string Sp_Receiving_ID_RecommendedFefo { get; set; }
        public string Sp_Expiration_Date { get; set; }
        public string Sp_Receiving_Item_Code { get; set; }
        public string Sp_Receiving_Actual_Remaining { get; set; }

        public string Sp_Material_Item_Description { get; set; }
        public string Sp_Unit_Of_Measure { get; set; }
        public string Sp_Converted_Qty { get; set; }
        public string Sp_material_id { get; set; }

        public string Sp_Item_Code {get; set;}


        public int Sp_AssigneD_Task_By { get; set; }
        public string Sp_Start_By { get; set; }
        public string Sp_Employee_Name { get; set; }

        public string Sp_Is_WH_Cancel_Status { get; set; }
        public string Sp_Logistic_Checker_Cancelled { get; set; }
        public string Sp_Category { get; set; }
        public string Sp_Data_Refactoring_Status { get; set; }
        public string Sp_Remaining_Qty { get; set; }

        public int Sp_id { get; set; }




        private void frmDryPreparation_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.dset.Clear();
            this.LoadWindowsExecution();

            this.loadCategoryDropdown();

            this.LoadStateVisibility();

            this.SearchMethodJarVarCallingSPPreparationPerStaffMigration();
        
            this.FormmLoadSearchState();

            this.ValidateifTheTotalDataiSZero();

            this.cmbArea_SelectionChangeCommitted(sender,e);

        }

        private void ValidateifTheTotalDataiSZero()
        {
            if (this.lbltotaldata.Text == "0")
            {
          
                this.matbtnSave.Visible = false;
                this.MatcmbCategory.Enabled = false;
                this.mattxtScanTheBarcode.Enabled = false;
                this.Guna2DgvMaterialPreparation.DataSource = null;
            }

        }

        private  void DataGridParentVisibleFalse()
        {

          
                this.dgvStoreOrderApproval.Columns["start_by_user_id"].Visible = false;
                this.dgvStoreOrderApproval.Columns["employee_name"].Visible = false;
                this.dgvStoreOrderApproval.Columns["category"].Visible = false;
                this.dgvStoreOrderApproval.Columns["id"].Visible = false;
                this.dgvStoreOrderApproval.Columns["TotalItemsOrder"].Visible = false;
                this.dgvStoreOrderApproval.Columns["start_by_user_id"].Visible = false;
                this.dgvStoreOrderApproval.Columns["employee_name"].Visible = false;

            
        }

        DataSet dset_emp_SearchEnginesPreparationPerStaff = new DataSet();
        private void SearchMethodJarVarCallingSPPreparationPerStaffMigration()
        {

            this.dset_emp_SearchEnginesPreparationPerStaff.Clear();
            this.dset_emp_SearchEnginesPreparationPerStaff =
            g_objStoredProcCollection.sp_getMajorTables("searchorderForApprovalinDryWH_isApprovedforPreparation");

        }



        private void FormmLoadSearchState()
        {
            if (this.MatcmbCategory.Text == String.Empty)
            {

            }
            else

            {
                if (this.cmbArea.Text == String.Empty)
                {
                    this.loadAreaDropdown();
                }
                else
                {

                }


            }

            
            try
            {
                //Gerrad

                if (dset_emp_SearchEnginesPreparationPerStaff.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEnginesPreparationPerStaff.Tables[0]);

                    try
                    {
           

                        //Start
                        if (this.cmbArea.Text == String.Empty)
                        {
                            //MessageBox.Show(this.Sp_AssigneD_Task_By.ToString());
                            dv.RowFilter = "(start_by_user_id = '" + this.Sp_AssigneD_Task_By + "' or start_by_user_id = '0')  and category = '" + this.MatcmbCategory.Text + "'   ";
             
                        }
                        else
                        {
                        
                            dv.RowFilter = "(start_by_user_id = '" + this.Sp_AssigneD_Task_By + "' or start_by_user_id = '0')  and category = '" + this.MatcmbCategory.Text + "'  and area = '" + this.cmbArea.Text + "'    ";
                     
                        }

                        //start_by_user_id = '" + this.Sp_AssigneD_Task_By + "' and category = '" +this.matcmbCategory.Text+"'  or start_by_user_id = '0'

                        this.dgvStoreOrderApproval.DataSource = dv;
                        this.lbltotalStoreforPreparation.Text = dgvStoreOrderApproval.RowCount.ToString();
                    
                        this.DataGridParentVisibleFalse();
                        //End
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

      
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


        private void LoadStateVisibility()
        {
            //Visibility
            this.gunaDgvReceivingFEFO.Visible = false;
            this.gunaDgvScanFinder.Visible = false;
        }


        DataSet dset_emp_SearchEnginesReceivingIDFEFO = new DataSet();
        private void SearchMethodJarVarCallingSPReceivingIDFEFODB()
        {
     
            this.dset_emp_SearchEnginesReceivingIDFEFO.Clear();
            this.dset_emp_SearchEnginesReceivingIDFEFO = g_objStoredProcCollection.sp_getMajorTables("searchorderForReceivingIDFEFOStore_Major");

        }

        DataSet dset_emp_SearchEnginesReceivingInformationDset = new DataSet();
        private void SearchMethodJarVarCallingSPReceivingInformation()
        {

            this.dset_emp_SearchEnginesReceivingInformationDset.Clear();
            this.dset_emp_SearchEnginesReceivingInformationDset = g_objStoredProcCollection.sp_getMajorTables("searchorderForReceivinginDryWarehouse");

        }



        public void loadCategoryDropdown()
        {
            try
            {
                xClass.fillComboBoxStoreOrderApproval(this.MatcmbCategory, "tblStoreOrderDryWH_dropdown_Already_Approved", this.dSet);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }



        private void LoadWindowsExecution()
        {
            this.dgvStoreOrderApproval.Enabled = false;
            this.Sp_AssigneD_Task_By = userinfo.user_id;
        }

        private void matRadioNext_CheckedChanged(object sender, EventArgs e)
        {
          
        }




        private void NextDatainDryStorePreparationEntry()
        {
            if (this.dgvStoreOrderApproval.Rows.Count >= 1)
            {
                int i = this.dgvStoreOrderApproval.CurrentRow.Index + 1;
                if (i >= -1 && i < this.dgvStoreOrderApproval.Rows.Count)
                    this.dgvStoreOrderApproval.CurrentCell = this.dgvStoreOrderApproval.Rows[i].Cells[0];
                else
                {
                    this.GlobalStatePopup.LastLineofPreparationSubject();
  
                    this.mattxtScanTheBarcode.Focus();
                    return;
                }
            }
            this.mattxtScanTheBarcode.Focus();
        }

        private void matRadioPrevious_CheckedChanged(object sender, EventArgs e)
        {

            if (this.lbltotaldata.Text == "0")
            {

            }

            else
            {
               


                    int prev = this.dgvStoreOrderApproval.CurrentRow.Index - 1;
                    if (prev >= 0)
                    {

                        this.dgvStoreOrderApproval.CurrentCell = this.dgvStoreOrderApproval.Rows[prev].Cells[this.dgvStoreOrderApproval.CurrentCell.ColumnIndex];
                    }
                    else
                    {
                        this.GlobalStatePopup.FirstLineofPreparationSubject();
                        this.mattxtScanTheBarcode.Focus();

                    }

             
              
                this.mattxtScanTheBarcode.Focus();
            }
        }



     private void ConnectionInit()
        {
            g_objStoredProcCollection = xClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }

        private void dgvStoreOrderApproval_CurrentCellChanged(object sender, EventArgs e)
        {       
           this.CurrentCellChangeofDgvStoreOrderApproval();
            this.ConnectionInit();
            this.SearchMethodJarVarCallingSP();
            if (this.lbltotalStoreforPreparation.Text == "0")
            {

            }
            else
            {
                myglobal.global_module = "Active"; // Mode for Searching
            }


            this.doSearchInTextBoxCmb();
            //return;
            if (this.lbltotaldata.Text != "0")
            {
                this.MaterialDatagridColumnVisibilittyFalse(); //pako
            }
            if (this.lbltotaldata.Text == "0")
            {
                this.matbtnSave.Visible = false;
            }
            this.textBox1.Text = String.Empty;

            this.PreparationValidationRequiredToSave();
            this.PartialReceivingAwaitResponse();

                //ending for Loop
            

        }

        private void PreparationValidationRequiredToSave()
        {

            //CheckIifAlreayHaveAnewRecord
            this.dset2.Clear();
            this.dset2 = g_objStoredProcCollection.sp_Store_Preparation_Logs(0,
           this.MatcmbCategory.Text,
            this.Sp_approved_preparation_date,
            "ItemCode",
            "ItemDesc",
            "OrderQty",
            "Allocated QTY",
            "PrepaDate Added",
            "PrepaAdded By", 0,
             this.Sp_fox, 
             this.Sp_route, 
             this.Sp_area, 0,
            "validate_touched_event_preparation");

            if (dset2.Tables[0].Rows.Count > 0)
            {
       
                this.matbtnSave.Visible = false;

            }
            else
            {
                if(this.lbltotalStoreforPreparation.Text == "0")
                {
                   
                }
                else
                {
                    //////this.matbtnSave.Visible = true;
                }



                if (this.Sp_Is_WH_Cancel_Status == "1")
                {
                    this.matbtnSave.Visible = false;
                }

            }

            }




        private void MaterialDatagridColumnVisibilittyFalse()
        {

            this.Guna2DgvMaterialPreparation.Columns["date_ordered_materials"].Visible = false;
            this.Guna2DgvMaterialPreparation.Columns["is_approved_preparation_date"].Visible = false;
            this.Guna2DgvMaterialPreparation.Columns["fox"].Visible = false;
            this.Guna2DgvMaterialPreparation.Columns["area"].Visible = false;
            this.Guna2DgvMaterialPreparation.Columns["store_name"].Visible = false;
            this.Guna2DgvMaterialPreparation.Columns["route"].Visible = false;
            this.Guna2DgvMaterialPreparation.Columns["primary_id"].Visible = false;
            //this.Guna2DgvMaterialPreparation.Columns["converted_qty_original"].Visible = false;
            this.Guna2DgvMaterialPreparation.Columns["AllocatedQTY"].Visible = false;
            this.Guna2DgvMaterialPreparation.Columns["conversion"].Visible = false;
            this.Guna2DgvMaterialPreparation.Columns["is_wh_checker_cancel"].Visible = false;
            this.Guna2DgvMaterialPreparation.Columns["qty"].Visible = false;
            this.Guna2DgvMaterialPreparation.Columns["data_refactoring_status"].Visible = false;
            this.Guna2DgvMaterialPreparation.Columns["FK_dry_wh_orders_parent_id"].Visible = false;
        }

        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            this.dset_emp_SearchEngines.Clear();
            this.dset_emp_SearchEngines = g_objStoredProcCollection
            .sp_getMajorTables("searchorderForApprovalinDryWH_isApprovedforPreparation_PerItems");

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
 
                    
                            dv.RowFilter = "fox = '" + this.Sp_fox + "' " +
                            "and route = '" + this.Sp_route + "' " +
                            "and area = '" + this.Sp_area + "'   " + 
                            "and is_approved_preparation_date = '" + this.Sp_approved_preparation_date + "'  and category = '" + this.Sp_Category + "' and FK_dry_wh_orders_parent_id ='"+this.Sp_id+ "'   ";


                    }

                    this.Guna2DgvMaterialPreparation.DataSource = dv;
          
                    this.lbltotaldata.Text = this.Guna2DgvMaterialPreparation.RowCount.ToString();
  

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





        private void CurrentCellChangeofDgvStoreOrderApproval()
        {


            if (this.dgvStoreOrderApproval.Rows.Count > 0)
            {
                if (this.dgvStoreOrderApproval.CurrentRow != null)
                {
                    if (this.dgvStoreOrderApproval.CurrentRow.Cells["store_name"].Value != null)
                    {
                        this.Sp_id = Convert.ToInt32(dgvStoreOrderApproval.CurrentRow.Cells["id"].Value);
                        this.Sp_fox = this.dgvStoreOrderApproval.CurrentRow.Cells["fox"].Value.ToString();
                        this.Sp_route = this.dgvStoreOrderApproval.CurrentRow.Cells["route"].Value.ToString();
                        this.Sp_area = this.dgvStoreOrderApproval.CurrentRow.Cells["area"].Value.ToString();
                        this.Sp_approved_preparation_date = this.dgvStoreOrderApproval.CurrentRow.Cells["approved_preparation_date"].Value.ToString();
                        this.Sp_Start_By = this.dgvStoreOrderApproval.CurrentRow.Cells["start_by_user_id"].Value.ToString();
                        this.Sp_Employee_Name = this.dgvStoreOrderApproval.CurrentRow.Cells["employee_name"].Value.ToString();
                        this.Sp_Category = this.dgvStoreOrderApproval.CurrentRow.Cells["category"].Value.ToString();
                   
                    }
                }
            }
        }

        private void matcmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.SearchMethodJarVarCallingSPPreparationPerStaffMigration();
            this.FormmLoadSearchState();
            this.RefactoringResetEnhancement();
            this.loadAreaDropdown();



         
        }








        public void loadAreaDropdown()
        {
            try
            {


                xClass.fillComboBoxStoreOrderApprovalSync(this.cmbArea, "tblStoreOrderDryWH_dropdown_Already_Approved_AreaData", this.dSet, this.MatcmbCategory.Text, this.MatcmbCategory.Text, this.MatcmbCategory.Text, "");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }


 

        private void mattxtScanTheBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            int checkLengthofTextboxes = this.mattxtScanTheBarcode.Text.Length;


            if (checkLengthofTextboxes == 10)
            {
                this.mattxtScanTheBarcode.Text = String.Empty;
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                this.ScanBarcode();
            }
        }







  

        private void ScanBarcode()
        {

            if(this.mattxtScanTheBarcode.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.mattxtScanTheBarcode.Focus();
                return;
            }

            //Connection Binding to Stored Procedure
            g_objStoredProcCollection = xClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            g_objStoredProcCollection = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class





            //Start of Validating the Received If if exist on the system
            this.dSet.Clear();
            this.dSet = g_objStoredProcCollection
                .sp_Store_Preparation_Logs(Convert.ToInt32(this.mattxtScanTheBarcode.Text), 
                "",
                "", 
                "",
                "", 
                "", 
                "",
                "",
                "",
                0,
                "",
                "",
                "", 
                0, 
                "check_if_the_barcode_is_exist");

            if (dSet.Tables[0].Rows.Count > 0)
            {

                //Start of Validating the Received If if exist on the system
                this.dset2.Clear();
                this.dset2 = g_objStoredProcCollection.sp_Store_Preparation_Logs(
                    Convert.ToInt32(this.mattxtScanTheBarcode.Text), 
                   this.Sp_approved_preparation_date,
                   this.Sp_fox,
                   "", 
                   "", 
                   "", 
                   "", 
                   "", 
                   "",
                   0,
                   "",
                   "",
                   "",
                   0, 
                   "check_if_the_barcode_is_exist_information");


                if (dset2.Tables[0].Rows.Count > 0)
                {
        
                    this.SearchMethodJarVarCallingSPReceivingInformation();
  
                    this.doSearchInTextBoxCmbReceivingInformative();



                    this.CurrentCellChangeofRecommendedFefoID();

                    if(this.Sp_Receiving_Actual_Remaining == "0")
                    {
                        this.GlobalStatePopup.Popup_barcode_identity = mattxtScanTheBarcode.Text;
                        this.GlobalStatePopup.NotEnoughStockOnReceivingID();
                        this.mattxtScanTheBarcode.Text = String.Empty;
                        this.mattxtScanTheBarcode.Focus();

                        return;
                    }


            
                    this.FindTheExactItemCode();


            


                }
                else
                {

                    this.GlobalStatePopup.ReceivingBarcodeIdIsnotExist();
     
                    //Buje Malakas
                    this.mattxtScanTheBarcode.Text = String.Empty;
                    this.mattxtScanTheBarcode.Focus();

                    return;
                }



            }
            else
            {
                this.GlobalStatePopup.ReceivingBarcodeIdIsnotExist();
                //Buje Malakas
                this.mattxtScanTheBarcode.Text = String.Empty;
                this.mattxtScanTheBarcode.Focus();

                return;
            }

        }

        private void FindTheExactItemCode()
        {
            if (this.Sp_Receiving_Item_Code == this.Sp_Item_Code)
            {
                //FEFO Method Validation Entry
                this.SearchMethodJarVarCallingSPReceivingIDFEFODB();
                //xClass.fillDataGridView(this.gunaDgvReceivingFEFO, "searchorderForReceivingIDFEFOStore", dset3);
                this.doSearchInTextBoxCmbReceivingIDFefo();

                if (this.mattxtScanTheBarcode.Text.Trim() == this.Sp_Receiving_ID_RecommendedFefo)
                {

                }
                else
                {
                    this.GlobalStatePopup.PopperSp_Receiving_ID_RecommendedFefo = this.Sp_Receiving_ID_RecommendedFefo;
                    this.GlobalStatePopup.FeFoInformation();
                }


               

                frmServeStorePreparation addNew = new frmServeStorePreparation(this,
                this.Sp_material_id,
                this.mattxtScanTheBarcode.Text,
                this.Sp_Material_Item_Description,
                this.Sp_Unit_Of_Measure,
                this.Sp_Converted_Qty,
                this.Sp_approved_preparation_date,
                this.Sp_Qty_Serve,
                this.Sp_fox,
                this.Sp_route,
                this.Sp_area,
                this.MatcmbCategory.Text,
                this.lbltotaldata.Text,
                this.Sp_id,
                this.Sp_Remaining_Qty
                    );
                addNew.ShowDialog();
                this.mattxtScanTheBarcode.Text = String.Empty;
            }
            else
            {

      

            if (this.Guna2DgvMaterialPreparation.Rows.Count >= 1)
            {
                int i = this.Guna2DgvMaterialPreparation.CurrentRow.Index + 1;
                if (i >= -1 && i < this.Guna2DgvMaterialPreparation.Rows.Count)
                    this.Guna2DgvMaterialPreparation.CurrentCell = this.Guna2DgvMaterialPreparation.Rows[i].Cells["item_code"];
                //Cell na 0
                else
                {


   
                    return;
                }
                this.FindTheExactItemCode();
            }

            }

        }

        private void doSearchInTextBoxCmbReceivingIDFefo()
        {

            //MessageBox.Show(this.Sp_Receiving_ID_RecommendedFefo);
            try
            {
                if (dset_emp_SearchEnginesReceivingIDFEFO.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEnginesReceivingIDFEFO.Tables[0]);

                    //Gerard Singian Developer Man

                    dv.RowFilter = "item_code = '" + this.Sp_Item_Code + "'   ";



                    this.gunaDgvReceivingFEFO.DataSource = dv;
                    //lbltotalrecords.Text = dgvRawMats.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found MasterGit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found MasterGit2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

        }

        private void doSearchInTextBoxCmbReceivingInformative()
        {

            //MessageBox.Show(this.Sp_Receiving_ID_RecommendedFefo);
            try
            {
                if (this.dset_emp_SearchEnginesReceivingInformationDset.Tables.Count > 0)
                {
                    DataView dv = new DataView(this.dset_emp_SearchEnginesReceivingInformationDset.Tables[0]);

                    //Gerard Singian Developer Man

                    dv.RowFilter = "id = '" + this.mattxtScanTheBarcode.Text + "'   ";



                    this.gunaDgvReceivingFEFO.DataSource = dv;
                    //lbltotalrecords.Text = dgvRawMats.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found MasterGit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found MasterGit2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

        }


        private void mattxtScanTheBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
            e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
            e.Handled = true;
            }
        }

        private void guna2DgvMaterialPreparation_CurrentCellChanged(object sender, EventArgs e)
        {
            this.CurrentCellChangeofRawMaterials();
        }


        private void CurrentCellChangeofRawMaterials()
        {

            if (this.Guna2DgvMaterialPreparation.Rows.Count > 0)
            {
                if (this.Guna2DgvMaterialPreparation.CurrentRow != null)
                {
                    if (this.Guna2DgvMaterialPreparation.CurrentRow.Cells["store_name"].Value != null)
                    {
                       
                        this.Sp_material_id = this.Guna2DgvMaterialPreparation.CurrentRow.Cells["primary_id"].Value.ToString();
                        this.Sp_Material_Item_Description = this.Guna2DgvMaterialPreparation.CurrentRow.Cells["description"].Value.ToString();
                        this.Sp_Unit_Of_Measure = this.Guna2DgvMaterialPreparation.CurrentRow.Cells["uom"].Value.ToString();
                        this.Sp_Converted_Qty = this.Guna2DgvMaterialPreparation.CurrentRow.Cells["converted_qty"].Value.ToString();
                        this.Sp_Qty_Serve = this.Guna2DgvMaterialPreparation.CurrentRow.Cells["Serve_Qty"].Value.ToString();
                        this.Sp_Item_Code = this.Guna2DgvMaterialPreparation.CurrentRow.Cells["item_code"].Value.ToString();
                        this.Sp_Is_WH_Cancel_Status = this.Guna2DgvMaterialPreparation.CurrentRow.Cells["is_wh_checker_cancel"].Value.ToString();
                        this.Sp_Data_Refactoring_Status = this.Guna2DgvMaterialPreparation.CurrentRow.Cells["data_refactoring_status"].Value.ToString();
                        this.Sp_Remaining_Qty = this.Guna2DgvMaterialPreparation.CurrentRow.Cells["Remaining_Qty"].Value.ToString();

                    }
                }
            }

         


        }

        private void RefactoringResetEnhancement()
        {
            if (this.lbltotaldata.Text != "0")
            {
                try
                {
                    if (this.Sp_Is_WH_Cancel_Status == "1" && this.Sp_Data_Refactoring_Status != "1")
                    {

                        //Date Conversion
                        DateTime dt = new DateTime();
                        string lstrDate = this.Sp_approved_preparation_date;
                        dt = Convert.ToDateTime(lstrDate);
                        string lstrAdate = dt.ToString("yyyy-MM-dd");
                        this.Sp_approved_preparation_date = lstrAdate;


        
                        this.dset2.Clear();
                        this.dset2 = g_objStoredProcCollection.sp_Store_Preparation_Logs(0,
                        this.Sp_fox,
                        this.Sp_approved_preparation_date,
                        this.Sp_Category,
                        "",
                       "",
                        "",
                        "", "",
                        0,
                        this.Sp_fox, 
                        this.Sp_Category,
                        "", 0,
                        "select_StorePreparationLogsTBL_Deactivated");

                        if (dset2.Tables[0].Rows.Count > 0)
                        {

                     ;


                        }
                        else
                        {
                     
                            this.dSet.Clear();
                            this.dSet = g_objStoredProcCollection.sp_Store_Preparation_Logs(0,
                            this.Sp_fox,
                            this.Sp_approved_preparation_date,
                            this.Sp_Category,
                            "",
                           "",
                            "",
                            "", "",
                            0,
                            this.Sp_fox,
                            this.Sp_Category,
                            "", 0,
                            "update_StorePreparationLogsTBL_Deactivated");

                           this.matcmbCategory_SelectionChangeCommitted(new object(), new System.EventArgs());
                        }

  
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "ItemServe")
            {
                this.matViewItemPrepared.Enabled = true;
                this.dgvStoreOrderApproval_CurrentCellChanged(sender, e);
        
            }
            else if (this.textBox1.Text == "FormClosing")
            {
                this.RefactoringResetEnhancement();
            }
            else
            {

            }
        }
        //Bearer Token  Update the Fucking Preparation Table Logs
        private void PartialReceivingAwaitResponse()
        {
            //Date Conversion
            DateTime dt = new DateTime();
            string lstrDate = this.Sp_approved_preparation_date;
            dt = Convert.ToDateTime(lstrDate);
            string lstrAdate = dt.ToString("yyyy-MM-dd");
            this.Sp_approved_preparation_date = lstrAdate;

          
            this.dset3.Clear();
            this.dset3 = g_objStoredProcCollection.sp_Store_Preparation_Logs(0,
            this.MatcmbCategory.Text,
            this.Sp_approved_preparation_date,
            "ItemCode", 
            "ItemDesc", 
            "OrderQty", 
            "Allocated QTY", 
            "PrepaDate Added", 
            "PrepaAdded By", 
            0,
            this.Sp_fox,
            this.Sp_route,
            this.Sp_area, 0,
            "show_prepared_raw_materials");

            if (dset3.Tables[0].Rows.Count > 0)
            {

                this.matViewItemPrepared.Visible = true;

            }
            else
            {
                this.matViewItemPrepared.Visible = false;

            }
        }

        private void gunaDgvReceivingFEFO_CurrentCellChanged(object sender, EventArgs e)
        {
            this.CurrentCellChangeofRecommendedFefoID();
        }
        private void CurrentCellChangeofRecommendedFefoID()
        {

            if (this.gunaDgvReceivingFEFO.Rows.Count > 0)
            {
                if (this.gunaDgvReceivingFEFO.CurrentRow != null)
                {
                    if (this.gunaDgvReceivingFEFO.CurrentRow.Cells["id"].Value != null)
                    {
                        this.Sp_Receiving_ID_RecommendedFefo = this.gunaDgvReceivingFEFO.CurrentRow.Cells["id"].Value.ToString();
                        this.Sp_Expiration_Date = this.gunaDgvReceivingFEFO.CurrentRow.Cells["exp_date"].Value.ToString();
                        this.Sp_Receiving_Item_Code = this.gunaDgvReceivingFEFO.CurrentRow.Cells["codes"].Value.ToString();
                        this.Sp_Receiving_Actual_Remaining = this.gunaDgvReceivingFEFO.CurrentRow.Cells["Remaining_Qty"].Value.ToString();
                    }
                }
            }
        }

  

        private void lbltotaldata_TextChanged(object sender, EventArgs e)
        {
            if (this.lbltotalStoreforPreparation.Text == "0")
            {
                this.frmDryPreparation_Load(sender, e);
            }
            else
            {
                if (this.lbltotaldata.Text == "0")
                {
                   


                    this.dset2.Clear();
                    this.dset2 = g_objStoredProcCollection.sp_Store_order_force_cancel_logs(
                    this.Sp_id,
                    Convert.ToInt32(this.Sp_material_id),
                    this.Sp_fox,
                    this.Sp_Remaining_Qty,
                    this.Sp_AssigneD_Task_By.ToString(),
                    "",
                    Convert.ToInt32(this.Sp_material_id),
                     this.Sp_Item_Code,
                    "update");

                    this.ConnectionInit();
                    this.loadCategoryDropdown();
                    this.matcmbCategory_SelectionChangeCommitted(sender, e);

                    this.matbtnSave.Visible = false;
          

                }
               


            }


       
        }

        private void matRadioNext_Click(object sender, EventArgs e)
        {
            if (this.lbltotaldata.Text == "0")
            {

            }
            else
            {
               
                    this.NextDatainDryStorePreparationEntry();
                
            }
            this.RefactoringResetEnhancement();
        }

        private void matRadioPrevious_Click(object sender, EventArgs e)
        {
            if (this.lbltotaldata.Text == "0")
            {

            }

            else
            {
              


                    int prev = this.dgvStoreOrderApproval.CurrentRow.Index - 1;
                    if (prev >= 0)
                    {

                        this.dgvStoreOrderApproval.CurrentCell = this.dgvStoreOrderApproval.Rows[prev].Cells[this.dgvStoreOrderApproval.CurrentCell.ColumnIndex];
                    }
                    else
                    {
                        this.GlobalStatePopup.FirstLineofPreparationSubject();
                        this.mattxtScanTheBarcode.Focus();
                    }

               
                this.mattxtScanTheBarcode.Focus();
            }
            this.RefactoringResetEnhancement();
        }

  

        private void matbtnSave_Click(object sender, EventArgs e)
        {

            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                dset3.Clear();
                dset3 = g_objStoredProcCollection.sp_Store_Preparation_Logs(0,
               this.MatcmbCategory.Text,
                this.Sp_approved_preparation_date,
                "ItemCode",
                "ItemDesc",
                "OrderQty",
                "Allocated QTY",
                "PrepaDate Added",
                "PrepaAdded By",
                0,
                this.Sp_fox,
                this.Sp_route,
                this.Sp_area,
                0,
                "bulk_proceed_preparation");


                this.GlobalStatePopup.CommittedSuccessFully();
                this.frmDryPreparation_Load(sender, e);
            }
            else
            {
                return;
            }


            }



        private void matViewItemPrepared_Click(object sender, EventArgs e)
        {
            this.matViewItemPrepared.Enabled = false;
            this.matbtnSave.Visible = false;
            frmViewStoreItemPrepared addNew = new frmViewStoreItemPrepared(this,
            this.Sp_material_id,
            this.mattxtScanTheBarcode.Text,
            this.Sp_Material_Item_Description,
            this.Sp_Unit_Of_Measure,
            this.Sp_Converted_Qty,
            this.Sp_approved_preparation_date,
            this.Sp_Qty_Serve,
            this.Sp_fox,
            this.Sp_route,
            this.Sp_area
            );
            addNew.ShowDialog();
            //
           
        }

        private void matcmbCategory_Click(object sender, EventArgs e)
        {

            this.loadCategoryDropdown();
        }

        private void guna2DgvMaterialPreparation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (Guna2DgvMaterialPreparation.Columns[e.ColumnIndex].Name == "CANCEL")
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to cancel? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.dset2.Clear();
                    this.dset2 = g_objStoredProcCollection.sp_Store_order_force_cancel_logs(
                     0,
                    Convert.ToInt32(this.Sp_material_id),
                    this.Sp_fox,
                    this.Sp_Remaining_Qty,
                    this.Sp_AssigneD_Task_By.ToString(),
                    "",
                    Convert.ToInt32(this.Sp_material_id),
                     this.Sp_Item_Code,
                    "add");


                    if (this.Sp_Qty_Serve == "0")
                    {
                        this.dset2.Clear();
                        this.dset2 = g_objStoredProcCollection.sp_Store_order_force_cancel_logs(
                         Convert.ToInt32(this.Sp_material_id),
                        Convert.ToInt32(this.Sp_material_id),
                        this.Sp_fox,
                        this.Sp_Remaining_Qty,
                        this.Sp_AssigneD_Task_By.ToString(),
                        "",
                        Convert.ToInt32(this.Sp_material_id),
                         this.Sp_Item_Code,
                        "deactivate_dry_order_store");
                    }
                    else
                    {
                        this.dset2.Clear();
                        this.dset2 = g_objStoredProcCollection.sp_Store_order_force_cancel_logs(
                        Convert.ToInt32(this.Sp_material_id),
                        Convert.ToInt32(this.Sp_material_id),
                        this.Sp_fox,
                        this.Sp_Remaining_Qty,
                        this.Sp_AssigneD_Task_By.ToString(),
                        "",
                        Convert.ToInt32(this.Sp_material_id),
                         this.Sp_Item_Code,
                        "force_prepared_dry_store_orders");
                    }


                    this.dgvStoreOrderApproval_CurrentCellChanged(sender, e);


                    this.GlobalStatePopup.CancelledSuccessfully();
                }
                else
                {
                    return;
                }

            }
                    //back


            }

      

        private void dgvStoreOrderApproval_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);

        }

        private void cmbArea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.FormmLoadSearchState();
        }

        private void mattxtScanTheBarcode_TextChanged(object sender, EventArgs e)
        {

        }

   

        private void LbltotalStoreforPreparation_TextChanged(object sender, EventArgs e)
        {

            if (this.lbltotalStoreforPreparation.Text == "0")
            {
                this.mattxtScanTheBarcode.Enabled = false;
                this.mattxtScanTheBarcode.Visible = false;
                this.materialCard4.Visible = false;
                this.MatManipulatorNextPrev.Enabled = false;

                this.matcmbCategory_SelectionChangeCommitted(sender, e);
            }
            else
            {
                this.mattxtScanTheBarcode.Visible = true;
                this.materialCard4.Visible = true;
                this.mattxtScanTheBarcode.Enabled = true;
                this.MatManipulatorNextPrev.Enabled = true;
            }
        }

        private void LbltotalStoreforPreparation_Click(object sender, EventArgs e)
        {

        }
    }
}
