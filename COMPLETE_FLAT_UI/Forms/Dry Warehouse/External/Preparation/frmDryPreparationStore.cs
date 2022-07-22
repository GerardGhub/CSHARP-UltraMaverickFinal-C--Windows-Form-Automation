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
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Preparation
{
    public partial class frmDryPreparationStore : MaterialForm
    {

        //Main Classs
        myclasses myClass = new myclasses();
        myclasses xClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        //Data Set Initialization
        public DataSet dset = new DataSet();
        DataSet dset2 = new DataSet();
        DataSet dset3 = new DataSet();
        DataSet dSet = new DataSet();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        //Variable Declaration
        //int p_id = 0;


        public frmDryPreparationStore()
        {
            InitializeComponent();
        }
        public string Sp_Qty_Serve { get; set; }
        public string sp_fox { get; set; }
        public string sp_route { get; set; }
        public string sp_area { get; set; }
        public string sp_approved_preparation_date { get; set; }


        //Receiving Table
        public string Sp_Receiving_ID_RecommendedFefo { get; set; }
        public string Sp_Expiration_Date { get; set; }
        public string Sp_Receiving_Item_Code { get; set; }
        public string Sp_Receiving_Actual_Remaining { get; set; }

        public string Sp_Material_Item_Description { get; set; }
        public string Sp_Unit_Of_Measure { get; set; }
        public string Sp_Converted_Qty { get; set; }
        public string sp_material_id { get; set; }

        public string Sp_Item_Code {get; set;}


        public int Sp_AssigneD_Task_By { get; set; }
        public string Sp_Start_By { get; set; }
        public string Sp_Employee_Name { get; set; }

        public string Sp_Is_WH_Cancel_Status { get; set; }
        public string Sp_Logistic_Checker_Cancelled { get; set; }
        public string Sp_Category { get; set; }
        public string Sp_Data_Refactoring_Status { get; set; }
        public string Sp_Remaining_Qty { get; set; }



        private void frmDryPreparation_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            this.dset.Clear();
            this.LoadWindowsExecution();
            this.loadCategoryDropdown();
            this.LoadStateVisibility();


            this.SearchMethodJarVarCallingSPPreparationPerStaffMigration();
            this.FormmLoadSearchState();



            if (this.lbltotalStoreforPreparation.Text == "0")
            {
     
            }
            else
            {
                this.dgvStoreOrderApproval.Columns["start_by_user_id"].Visible = false;
                this.dgvStoreOrderApproval.Columns["employee_name"].Visible = false;
                this.dgvStoreOrderApproval.Columns["category"].Visible = false;

                this.dgvStoreOrderApproval.Columns["TotalItemsOrder"].Visible = false;
                this.dgvStoreOrderApproval.Columns["start_by_user_id"].Visible = false;
                this.dgvStoreOrderApproval.Columns["employee_name"].Visible = false;
                //this.dgvStoreOrderApproval.Columns["Count"].Visible = false;
            }

          
            //MessageBox.Show("" + this.Sp_AssigneD_Task_By);
            if(this.lbltotaldata.Text =="0")
            {
                this.matbtnSave.Visible = false;
                this.matcmbCategory.Enabled = false;
                this.mattxtScanTheBarcode.Enabled = false;
                this.guna2DgvMaterialPreparation.DataSource = null;
            }
        }

        DataSet dset_emp_SearchEnginesPreparationPerStaff = new DataSet();
        private void SearchMethodJarVarCallingSPPreparationPerStaffMigration()
        {

            this.dset_emp_SearchEnginesPreparationPerStaff.Clear();
            this.dset_emp_SearchEnginesPreparationPerStaff = objStorProc.sp_getMajorTables("searchorderForApprovalinDryWH_isApprovedforPreparation");

        }

        private void FormmLoadSearchState()
        {
       
            try
            {


                if (dset_emp_SearchEnginesPreparationPerStaff.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEnginesPreparationPerStaff.Tables[0]);

                    try
                    {
           

                        //Start
                        if (this.cmbArea.Text == String.Empty)
                        {
                            dv.RowFilter = "(start_by_user_id = '" + this.Sp_AssigneD_Task_By + "' or start_by_user_id = '0')  and category = '" + this.matcmbCategory.Text + "'   ";
                            //MessageBox.Show("Meron" + this.Sp_AssigneD_Task_By +"");
                        }
                        else
                        {
                            dv.RowFilter = "(start_by_user_id = '" + this.Sp_AssigneD_Task_By + "' or start_by_user_id = '0')  and category = '" + this.matcmbCategory.Text + "'  and area = '" + this.cmbArea.Text + "'    ";
                            //MessageBox.Show("Wala");
                        }

                        //start_by_user_id = '" + this.Sp_AssigneD_Task_By + "' and category = '" +this.matcmbCategory.Text+"'  or start_by_user_id = '0'

                        this.dgvStoreOrderApproval.DataSource = dv;
                        this.lbltotalStoreforPreparation.Text = dgvStoreOrderApproval.RowCount.ToString();
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
            this.dset_emp_SearchEnginesReceivingIDFEFO = objStorProc.sp_getMajorTables("searchorderForReceivingIDFEFOStore_Major");

        }

        DataSet dset_emp_SearchEnginesReceivingInformationDset = new DataSet();
        private void SearchMethodJarVarCallingSPReceivingInformation()
        {

            this.dset_emp_SearchEnginesReceivingInformationDset.Clear();
            this.dset_emp_SearchEnginesReceivingInformationDset = objStorProc.sp_getMajorTables("searchorderForReceivinginDryWarehouse");

        }



        public void loadCategoryDropdown()
        {
            try
            {


                myClass.fillComboBoxStoreOrderApproval(this.matcmbCategory, "tblStoreOrderDryWH_dropdown_Already_Approved", this.dSet);

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
                        //txtselectweight.Text = dgvAllFeedCode.CurrentRow.Cells["Quantity"].Value.ToString();
                    }

             
              
                this.mattxtScanTheBarcode.Focus();
            }
        }



     private void ConnectionInit()
        {

            ////Connection CallBack
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
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
            dset2.Clear();
            dset2 = objStorProc.sp_Store_Preparation_Logs(0,
           this.matcmbCategory.Text,
            this.sp_approved_preparation_date,
            "ItemCode", "ItemDesc", "OrderQty", "Allocated QTY", "PrepaDate Added", "PrepaAdded By", 0,
              this.sp_fox, this.sp_route, this.sp_area,
            "validate_touched_event_preparation");

            if (dset2.Tables[0].Rows.Count > 0)
            {
       
                this.matbtnSave.Visible = false;

            }
            else
            {
                this.matbtnSave.Visible = true;


                if (this.Sp_Is_WH_Cancel_Status == "1")
                {
                    this.matbtnSave.Visible = false;
                }

            }

            }




        private void MaterialDatagridColumnVisibilittyFalse()
        {

            this.guna2DgvMaterialPreparation.Columns["date_ordered_materials"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["is_approved_preparation_date"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["fox"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["area"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["store_name"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["route"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["primary_id"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["converted_qty_original"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["AllocatedQTY"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["conversion"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["is_wh_checker_cancel"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["qty"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["data_refactoring_status"].Visible = false;
        }

        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            this.dset_emp_SearchEngines.Clear();


            this.dset_emp_SearchEngines = objStorProc.sp_getMajorTables("searchorderForApprovalinDryWH_isApprovedforPreparation_PerItems");

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
 
                    
                            dv.RowFilter = "fox = '" + this.sp_fox + "' and route = '" + this.sp_route + "' and area = '" + this.sp_area + "'   " + 
                            "and is_approved_preparation_date = '" + this.sp_approved_preparation_date + "'  and category = '" + this.Sp_Category + "'  ";


                    }

                    this.guna2DgvMaterialPreparation.DataSource = dv;
          
                    this.lbltotaldata.Text = this.guna2DgvMaterialPreparation.RowCount.ToString();

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

            //MessageBox.Show(this.sp_fox);
            if (this.dgvStoreOrderApproval.Rows.Count > 0)
            {
                if (this.dgvStoreOrderApproval.CurrentRow != null)
                {
                    if (this.dgvStoreOrderApproval.CurrentRow.Cells["store_name"].Value != null)
                    {
                        //p_id = Convert.ToInt32(dgvStoreOrderApproval.CurrentRow.Cells["primary_id"].Value);
                        this.sp_fox = this.dgvStoreOrderApproval.CurrentRow.Cells["fox"].Value.ToString();
                        this.sp_route = this.dgvStoreOrderApproval.CurrentRow.Cells["route"].Value.ToString();
                        this.sp_area = this.dgvStoreOrderApproval.CurrentRow.Cells["area"].Value.ToString();
                        this.sp_approved_preparation_date = this.dgvStoreOrderApproval.CurrentRow.Cells["approved_preparation_date"].Value.ToString();
                        this.Sp_Start_By = this.dgvStoreOrderApproval.CurrentRow.Cells["start_by_user_id"].Value.ToString();
                        this.Sp_Employee_Name = this.dgvStoreOrderApproval.CurrentRow.Cells["employee_name"].Value.ToString();
                        this.Sp_Category = this.dgvStoreOrderApproval.CurrentRow.Cells["category"].Value.ToString();
                        //this.sp_ordered_date = this.dgvStoreOrderApproval.CurrentRow.Cells["date_ordered"].Value.ToString();

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


                //myClass.fillComboBoxStoreOrderApprovalSync(this.cmbDateOrder, "tblStoreOrderDryWH_dropdown_Approval_Order_Date_isApproved", this.dSet, this.bunifuPrepaDate.Text, this.cmbDateOrder.Text, this.matcmbCategory.Text,this.metroCmbStoreCode.Text);
                myClass.fillComboBoxStoreOrderApprovalSync(this.cmbArea, "tblStoreOrderDryWH_dropdown_Already_Approved_AreaData", this.dSet, this.matcmbCategory.Text, this.matcmbCategory.Text, this.matcmbCategory.Text, "");

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
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class





            //Start of Validating the Received If if exist on the system
            dSet.Clear();
            dSet = objStorProc.sp_Store_Preparation_Logs(Convert.ToInt32(this.mattxtScanTheBarcode.Text), "",
               "", "", "", "", "","","",0,"","","", "check_if_the_barcode_is_exist");

            if (dSet.Tables[0].Rows.Count > 0)
            {

                //Start of Validating the Received If if exist on the system
                dset2.Clear();
                dset2 = objStorProc.sp_Store_Preparation_Logs(Convert.ToInt32(this.mattxtScanTheBarcode.Text), this.sp_approved_preparation_date,
                   this.sp_fox, "", "", "", "", "", "",0,"","","", "check_if_the_barcode_is_exist_information");


                if (dset2.Tables[0].Rows.Count > 0)
                {
                    //Find The Data On Receiving Information
                    this.SearchMethodJarVarCallingSPReceivingInformation();
                    //Method of Searching
                    this.doSearchInTextBoxCmbReceivingInformative();


                    //Binding The Receiving ID Check if the Inventory is Enough
                    this.CurrentCellChangeofRecommendedFefoID();

                    if(this.Sp_Receiving_Actual_Remaining == "0")
                    {
                        this.GlobalStatePopup.Popup_barcode_identity = mattxtScanTheBarcode.Text;
                        this.GlobalStatePopup.NotEnoughStockOnReceivingID();
                        this.mattxtScanTheBarcode.Text = String.Empty;
                        this.mattxtScanTheBarcode.Focus();

                        return;
                    }


                        //Interation Loop of Materials Order
                    this.FindTheExactItemCode();


            


                }
                else
                {

                    this.GlobalStatePopup.ReceivingBarcodeIdIsnotExist();
                    //MessageBox.Show("B");
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


                //MessageBox.Show(lbltotaldata.Text);
                //return;

                frmServeStorePreparation addNew = new frmServeStorePreparation(this,
                    this.sp_material_id,
                    this.mattxtScanTheBarcode.Text,
                    this.Sp_Material_Item_Description,
                    this.Sp_Unit_Of_Measure,
                    this.Sp_Converted_Qty,
                    this.sp_approved_preparation_date,
                     this.Sp_Qty_Serve,
                     this.sp_fox,
                     this.sp_route,
                     this.sp_area,
                     this.matcmbCategory.Text,
                     this.lbltotaldata.Text
                    );
                addNew.ShowDialog();
                this.mattxtScanTheBarcode.Text = String.Empty;
            }
            else
            {

      

            if (this.guna2DgvMaterialPreparation.Rows.Count >= 1)
            {
                int i = this.guna2DgvMaterialPreparation.CurrentRow.Index + 1;
                if (i >= -1 && i < this.guna2DgvMaterialPreparation.Rows.Count)
                    this.guna2DgvMaterialPreparation.CurrentCell = this.guna2DgvMaterialPreparation.Rows[i].Cells["item_code"];
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

            if (this.guna2DgvMaterialPreparation.Rows.Count > 0)
            {
                if (this.guna2DgvMaterialPreparation.CurrentRow != null)
                {
                    if (this.guna2DgvMaterialPreparation.CurrentRow.Cells["store_name"].Value != null)
                    {
                       
                        this.sp_material_id = this.guna2DgvMaterialPreparation.CurrentRow.Cells["primary_id"].Value.ToString();
                        this.Sp_Material_Item_Description = this.guna2DgvMaterialPreparation.CurrentRow.Cells["description"].Value.ToString();
                        this.Sp_Unit_Of_Measure = this.guna2DgvMaterialPreparation.CurrentRow.Cells["uom"].Value.ToString();
                        this.Sp_Converted_Qty = this.guna2DgvMaterialPreparation.CurrentRow.Cells["converted_qty"].Value.ToString();
                        this.Sp_Qty_Serve = this.guna2DgvMaterialPreparation.CurrentRow.Cells["Serve_Qty"].Value.ToString();
                        this.Sp_Item_Code = this.guna2DgvMaterialPreparation.CurrentRow.Cells["item_code"].Value.ToString();
                        this.Sp_Is_WH_Cancel_Status = this.guna2DgvMaterialPreparation.CurrentRow.Cells["is_wh_checker_cancel"].Value.ToString();
                        this.Sp_Data_Refactoring_Status = this.guna2DgvMaterialPreparation.CurrentRow.Cells["data_refactoring_status"].Value.ToString();
                        this.Sp_Remaining_Qty = this.guna2DgvMaterialPreparation.CurrentRow.Cells["Remaining_Qty"].Value.ToString();

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
                        string lstrDate = this.sp_approved_preparation_date;
                        dt = Convert.ToDateTime(lstrDate);
                        string lstrAdate = dt.ToString("yyyy-MM-dd");
                        this.sp_approved_preparation_date = lstrAdate;


                        //Sample Lang
                        dset2.Clear();
                        dset2 = objStorProc.sp_Store_Preparation_Logs(0,
                        this.sp_fox,
                        this.sp_approved_preparation_date,
                        this.Sp_Category,
                        "",
                       "",
                        "",
                        "", "",
                        0,
                        this.sp_fox, this.Sp_Category, "",
                        "select_StorePreparationLogsTBL_Deactivated");

                        if (dset2.Tables[0].Rows.Count > 0)
                        {

                            //MessageBox.Show("A");


                        }
                        else
                        {
                            //MessageBox.Show("B");
                            dSet.Clear();
                            dSet = objStorProc.sp_Store_Preparation_Logs(0,
                            this.sp_fox,
                            this.sp_approved_preparation_date,
                            this.Sp_Category,
                            "",
                           "",
                            "",
                            "", "",
                            0,
                            this.sp_fox, this.Sp_Category, "",
                            "update_StorePreparationLogsTBL_Deactivated");

                           this.matcmbCategory_SelectionChangeCommitted(new object(), new System.EventArgs());
                        }

                        // return;
                        // //Bug Animal
                        // dSet.Clear();
                        // dSet = objStorProc.sp_Store_Preparation_Logs(0,
                        // this.sp_fox,
                        // this.sp_approved_preparation_date,
                        // this.Sp_Category,
                        // "",
                        //"",
                        // "",
                        // "", "",
                        // 0,
                        // this.sp_fox, this.Sp_Category, "",
                        // "update_StorePreparationLogsTBL_Deactivated");
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
            string lstrDate = this.sp_approved_preparation_date;
            dt = Convert.ToDateTime(lstrDate);
            string lstrAdate = dt.ToString("yyyy-MM-dd");
            this.sp_approved_preparation_date = lstrAdate;

            //MessageBox.Show(this.sp_approved_preparation_date);
            //CheckIifAlreayHaveAnewRecord Buje
            dset3.Clear();
            dset3 = objStorProc.sp_Store_Preparation_Logs(0,
           this.matcmbCategory.Text,
            this.sp_approved_preparation_date,
            "ItemCode", "ItemDesc", "OrderQty", 
            "Allocated QTY", "PrepaDate Added", "PrepaAdded By", 0,
              this.sp_fox, this.sp_route, this.sp_area,
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
                        //p_id = Convert.ToInt32(dgvStoreOrderApproval.CurrentRow.Cells["primary_id"].Value);
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
            if(this.lbltotaldata.Text == "0")
            {
                //this.matViewItemPrepared.Visible = false;
                this.matcmbCategory_SelectionChangeCommitted(sender, e);

                if (this.lbltotalStoreforPreparation.Text == "0")
                {
                    this.frmDryPreparation_Load(sender, e);
                }

                this.matbtnSave.Visible = false;

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
                        //txtselectweight.Text = dgvAllFeedCode.CurrentRow.Cells["Quantity"].Value.ToString();
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
                dset3 = objStorProc.sp_Store_Preparation_Logs(0,
               this.matcmbCategory.Text,
                this.sp_approved_preparation_date,
                "ItemCode",
                "ItemDesc",
                "OrderQty",
                "Allocated QTY",
                "PrepaDate Added",
                "PrepaAdded By",
                0,
                this.sp_fox,
                this.sp_route,
                this.sp_area,
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
            this.sp_material_id,
            this.mattxtScanTheBarcode.Text,
            this.Sp_Material_Item_Description,
            this.Sp_Unit_Of_Measure,
            this.Sp_Converted_Qty,
            this.sp_approved_preparation_date,
            this.Sp_Qty_Serve,
            this.sp_fox,
            this.sp_route,
            this.sp_area
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
            if (guna2DgvMaterialPreparation.Columns[e.ColumnIndex].Name == "CANCEL")
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to cancel? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    dset2.Clear();
                    dset2 = objStorProc.sp_Store_order_force_cancel_logs(
                     0,
                    Convert.ToInt32(this.sp_material_id),
                    this.sp_fox,
                    this.Sp_Remaining_Qty,
                    this.Sp_AssigneD_Task_By.ToString(),
                    "",
                    Convert.ToInt32(this.sp_material_id),
                     this.Sp_Item_Code,
                    "add");
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
    }
}
