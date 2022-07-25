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
    public partial class frmServeStorePreparation : MaterialForm
    {
        frmDryPreparationStore ths;
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
        //Variable Declaration
        int p_id = 0;
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();

        public frmServeStorePreparation(frmDryPreparationStore frm,
            string Dry_Order_GUID,
            string Barcode_id,
            string Item_Description,
            string Unit_Of_Measure,
            string Converted_Qty,
            string Preparation_Date,
            string Qty_Served,
            string Fox,
            string Route,
            string Area,
            string Category,
            string TotalRawMaterialPreparationActive,
            int FK_dry_wh_orders_parent_id
            )
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            Sp_Material_Id = Dry_Order_GUID;
            Sp_Barcode_Id = Barcode_id;
            Sp_Item_Desc = Item_Description;
            Sp_Unit_Of_Measure = Unit_Of_Measure;
            Sp_Converted_Qty = Converted_Qty;
            Sp_Preparation_Date = Preparation_Date;
            Sp_Qty_Served = Qty_Served;
            sp_Fox = Fox;
            sp_Route = Route;
            sp_Area = Area;
            Sp_Category = Category;
            Sp_TotalRawMaterialPreparationActive = TotalRawMaterialPreparationActive;
            Sp_FK_dry_wh_orders_parent_id = FK_dry_wh_orders_parent_id;
        }

        public string sp_Fox { get; set; }
        public string sp_Route { get; set; }
        public string sp_Area { get; set; }

        public string Sp_Qty_Served { get; set; }
        public string Sp_Preparation_Date { get; set; }
        public string Sp_Converted_Qty { get; set; }
        public string Sp_Unit_Of_Measure { get; set; }
        public string Sp_Item_Desc { get; set; }
        public string receiving_identity { get; set; }
        public string sp_item_code { get; set; }
        public string sp_item_description { get; set; }
        public string sp_quantity_serve { get; set; }
        public string sp_receiving_id { get; set; }
        public string sp_qty_order { get; set; }
        public string sp_uom { get; set; }
        public string Sp_Material_Id { get; set; }
        public string Sp_Barcode_Id { get; set; }
        public int Sp_User_ID { get; set; }
        public int Sp_RepackIncement { get; set; }

        public string TotalItemPreparedPerItemIncrementation { get; set; }

        public string TotalRecordofPrepared { get; set; }

        public string dgvStoreOrderApproval_Primary_ID { get; set; }
        public string dgvStoreOrderApproval_Is_wh_checker_cancel { get; set; }

        public string Sp_Category { get; set; }
        public string Sp_TotalRawMaterialPreparationActive { get; set; }

        public int Sp_FK_dry_wh_orders_parent_id { get; set; }

        private void frmServeStorePreparation_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); 
            objStorProc = xClass.g_objStoredProc.GetCollections(); 

            myglobal.global_module = "Active"; 

            this.StaticWindowState();
            this.SearchMethodJarVarCallingSP();
            this.doSearchInTextBoxCmb();


     
            this.SearchMethodJarVarCallingSPReceivingIDInventory();
            this.doSearchInTextBoxCmbRecID();

            this.DataGridVisibilyFalse();


            //MessageBox.Show(this.Sp_FK_dry_wh_orders_parent_id.ToString());
        }

        private void DataGridVisibilyFalse()
        {
            this.dgvStoreOrderApproval.Visible = false;
            this.gunaDgvReceivedIDInventory.Visible = false;
      
        }




        private void doSearchInTextBoxCmbRecID()
        {
            try
            {
                if (dset_emp_SearchEnginesReceivingIDInventory.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEnginesReceivingIDInventory.Tables[0]);
                    if (myglobal.global_module == "BOORAT")
                    {

                    }
                    else if (myglobal.global_module == "Active")
                    {
             

                        dv.RowFilter = "id = '" + this.matTxtReceivingbarcodeID.Text + "'   ";

                    }

                    this.gunaDgvReceivedIDInventory.DataSource = dv;
                  
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



        DataSet dset_emp_SearchEnginesReceivingIDInventory = new DataSet();
        private void SearchMethodJarVarCallingSPReceivingIDInventory()
        {
            this.dset_emp_SearchEnginesReceivingIDInventory.Clear();
            this.dset_emp_SearchEnginesReceivingIDInventory = objStorProc.sp_getMajorTables("searchorderForReceivingIDInventories");

        }




        private void StaticWindowState()
        {
            this.Sp_Material_Id = Sp_Material_Id;
            this.matTxtReceivingbarcodeID.Text = this.Sp_Barcode_Id;
            this.matTxtDescription.Text = this.Sp_Item_Desc;
            this.matTxtUOM.Text = this.Sp_Unit_Of_Measure;
            this.matTxtOrderQty.Text = this.Sp_Converted_Qty;
            this.Sp_Preparation_Date = this.Sp_Preparation_Date;
            this.Sp_User_ID = userinfo.user_id;
            this.matTxtQtyRelease.Text = this.Sp_Qty_Served;
            this.sp_Fox = this.sp_Fox;
            this.sp_Route = this.sp_Route;
            this.sp_Area = this.sp_Area;
            this.Sp_Category = this.Sp_Category;
            this.Sp_TotalRawMaterialPreparationActive = Sp_TotalRawMaterialPreparationActive;
            this.Sp_FK_dry_wh_orders_parent_id = this.Sp_FK_dry_wh_orders_parent_id;
        }

 

            DataSet dset_emp_SearchEngines = new DataSet();
            private void SearchMethodJarVarCallingSP()
            {
                this.dset_emp_SearchEngines.Clear();


                this.dset_emp_SearchEngines = objStorProc.sp_getMajorTables("searchorderForApprovalinDryWH_isApprovedforPreparation_PerItems_Serving");

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

                        dv.RowFilter = "primary_id = " + this.Sp_Material_Id + "   ";

                    }
                
                    this.dgvStoreOrderApproval.DataSource = dv;
                    //lbltotalrecords.Text = dgvRawMats.RowCount.ToString();
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




        private void dgvStoreOrderApproval_CurrentCellChanged(object sender, EventArgs e)
        {
            this.CurrentCellChangeofDgvStoreOrderApproval();
        }
        private void CurrentCellChangeofDgvStoreOrderApproval()
        {

            if (this.dgvStoreOrderApproval.Rows.Count > 0)
            {
                if (this.dgvStoreOrderApproval.CurrentRow != null)
                {
                    if (this.dgvStoreOrderApproval.CurrentRow.Cells["store_name"].Value != null)
                    {
                  
                        this.mattxtItemCode.Text = this.dgvStoreOrderApproval.CurrentRow.Cells["item_code"].Value.ToString();
                        this.dgvStoreOrderApproval_Primary_ID = this.dgvStoreOrderApproval.CurrentRow.Cells["primary_id"].Value.ToString();
                        this.dgvStoreOrderApproval_Is_wh_checker_cancel = this.dgvStoreOrderApproval.CurrentRow.Cells["is_wh_checker_cancel"].Value.ToString();

                
                       

                    }
                }
            }
        }



        DataSet SearchStoreItemPreparedWithCount = new DataSet();
        private void SearchMethodJarVarCallingSPSearchStoreItemPreparedWithCount()
        {
            this.SearchStoreItemPreparedWithCount.Clear();
            this.SearchStoreItemPreparedWithCount = objStorProc.sp_getMajorTables("SearchStoreItemPreparedWithCount");

        }
        private void doSearchSearchStoreItemPreparedWithCount()
        {
            try
            {
            

      
                    DateTime dt = new DateTime();
                    string lstrDate = this.Sp_Preparation_Date;
                    dt = Convert.ToDateTime(lstrDate);
                    string lstrAdate = dt.ToString("yyyy-MM-dd");
                    this.Sp_Preparation_Date = lstrAdate;
              

                    DataView dv = new DataView(SearchStoreItemPreparedWithCount.Tables[0]);
         

                        dv.RowFilter = "is_approved_prepa_date = " + lstrAdate + "   ";

                    

                    this.dgvPreparedItemDistinct.DataSource = dv;

                    this.TotalRecordofPrepared = dgvPreparedItemDistinct.RowCount.ToString();
               
            }

       



            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found Type 1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found Type 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

        }


        private void matBtnSave_Click(object sender, EventArgs e)
        {
            
            if (this.mattxtQtyServe.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
               this.mattxtQtyServe.Focus();
                return;
            }


            //If the Transaction is Virgin hindi pa nakantot
            if(this.matTxtQtyRelease.Text == "0")
            {
                double InputQtyServeUnused;
                double Order;

                InputQtyServeUnused = double.Parse(this.mattxtQtyServe.Text);
                Order = double.Parse(this.matTxtOrderQty.Text);

                if (InputQtyServeUnused > Order)
                {
                    this.GlobalStatePopup.GreaterThanActualRemainingQty();
                    this.mattxtQtyServe.Text = String.Empty;
                    this.mattxtQtyServe.Focus();
                    return;
                }


             }


            /// If You have a Existing Receiving
            double InputQtyServe;

            double ActualRemainingofReceivingID;

           InputQtyServe = double.Parse(this.mattxtQtyServe.Text);
            ActualRemainingofReceivingID = double.Parse(this.matTxtQtyRemaining.Text);
     

            if (InputQtyServe > ActualRemainingofReceivingID)
            {
          
                this.GlobalStatePopup.GreaterThanActualRemainingQty();
                this.mattxtQtyServe.Text = String.Empty;
                this.mattxtQtyServe.Focus();
                return;
            }
            else
            {
      
            }



            if (this.matTxtQtyRelease.Text == "0")
            {

            }
            else
            {
                double QuantityOrder;
                double QuantityRelease;
                double firstEntrySolution;

                double TextBoxQuantityInputState;

                QuantityOrder = double.Parse(this.matTxtOrderQty.Text);
                QuantityRelease = double.Parse(this.matTxtQtyRelease.Text);
                firstEntrySolution = QuantityOrder - QuantityRelease;
                TextBoxQuantityInputState = double.Parse(this.mattxtQtyServe.Text);
                

                if (firstEntrySolution > TextBoxQuantityInputState)
                {
      
                }
                else if(firstEntrySolution == TextBoxQuantityInputState)
                {
  
                }
                else
                {
                    this.GlobalStatePopup.GreaterThanAllocatedQty();
                    this.mattxtQtyServe.Text = String.Empty;
                    this.mattxtQtyServe.Focus();

                    return;
                }

            }


            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to serve? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
              
                //Mag miminus sya ng total Items Sa Dry Warehouse Orders Table
                if (this.dgvStoreOrderApproval_Is_wh_checker_cancel == "1")
                {
                    double ActualQuantityReleasedReturnType;

                    double ActualQuantityServedReturnType;

                    double ActualQuantityOrderReturnType;

                    double TotalQuantityServeStateReturnType;


                    ActualQuantityReleasedReturnType = double.Parse(this.matTxtQtyRelease.Text);
                    ActualQuantityServedReturnType = double.Parse(this.mattxtQtyServe.Text);
                    ActualQuantityOrderReturnType = double.Parse(this.matTxtOrderQty.Text);

                    TotalQuantityServeStateReturnType = ActualQuantityReleasedReturnType + ActualQuantityServedReturnType;

                    if (ActualQuantityOrderReturnType == TotalQuantityServeStateReturnType)
                    {

                        dSet.Clear();
                        dSet = objStorProc.sp_Store_Preparation_Logs(Convert.ToInt32(this.dgvStoreOrderApproval_Primary_ID),
                        this.sp_Fox,
                        this.Sp_Preparation_Date,
                        this.Sp_Category,
                        this.matTxtDescription.Text,
                        this.matTxtOrderQty.Text,
                        this.mattxtQtyServe.Text,
                        "", 
                        this.Sp_User_ID.ToString(),
                        Convert.ToInt32(this.Sp_Material_Id),
                        this.sp_Fox, 
                        this.Sp_Category, 
                        this.sp_Area,
                        this.Sp_FK_dry_wh_orders_parent_id,
                        "update_StorePreparationLogsTBL_prepared_allocated_qty");
                    }
                }


   
                dSet.Clear();
                dSet = objStorProc.sp_Store_Preparation_Logs(0,
                this.Sp_Barcode_Id,
                this.Sp_Preparation_Date,
                this.mattxtItemCode.Text,
                this.matTxtDescription.Text,
                this.matTxtOrderQty.Text,
                this.mattxtQtyServe.Text,
                "", this.Sp_User_ID.ToString(),
                Convert.ToInt32(this.Sp_Material_Id),
                this.sp_Fox, 
                Sp_Category, 
                this.sp_Area,
                this.Sp_FK_dry_wh_orders_parent_id,
                "add");

         

                // Summary Execution Per Row
                double QuantityReleasedData;
                double ActualQuantityServe;
                double SummaryDetailTransactionFormula;

                QuantityReleasedData = double.Parse(this.matTxtQtyRelease.Text);
                ActualQuantityServe = double.Parse(this.mattxtQtyServe.Text);
                SummaryDetailTransactionFormula = QuantityReleasedData + ActualQuantityServe;


                //Update Prepared Allocated Quantity base on Preparation
                dSet.Clear();
                dSet = objStorProc.sp_Store_Preparation_Logs(Convert.ToInt32(this.Sp_Material_Id),
                 SummaryDetailTransactionFormula.ToString(),
                this.Sp_Preparation_Date,
                this.mattxtItemCode.Text,
                this.matTxtDescription.Text,
                this.matTxtOrderQty.Text,
                this.mattxtQtyServe.Text,
                "", 
                this.Sp_User_ID.ToString(),
                Convert.ToInt32(this.Sp_Material_Id),
                this.sp_Fox, 
                this.sp_Route, 
                this.sp_Area,
                this.Sp_FK_dry_wh_orders_parent_id,
                "update_prepared_allocated_qty");



                //Update preparation
                if (Convert.ToDouble(this.matTxtOrderQty.Text) == SummaryDetailTransactionFormula)
                {

                    if (this.dgvStoreOrderApproval_Is_wh_checker_cancel == "1")
                    {
                        dSet.Clear();
                        dSet = objStorProc.sp_Store_Preparation_Logs(Convert.ToInt32(this.dgvStoreOrderApproval_Primary_ID),
                        this.sp_Fox,
                        this.Sp_Preparation_Date,
                        this.Sp_Category,
                        this.matTxtDescription.Text,
                        this.matTxtOrderQty.Text,
                        this.mattxtQtyServe.Text,
                        "", this.Sp_User_ID.ToString(),
                        Convert.ToInt32(this.Sp_Material_Id),
                        this.sp_Fox, 
                        this.sp_Route, 
                        this.sp_Area,
                        this.Sp_FK_dry_wh_orders_parent_id,
                        "update_StorePreparationLogsTBL_prepared_wh_cancell_NULL");
                    }

                }


                //Clear an etor sa zero

                //Date Conversion
                DateTime dt = new DateTime();
                string lstrDate = this.Sp_Preparation_Date;
                dt = Convert.ToDateTime(lstrDate);
                string lstrAdate = dt.ToString("yyyy-MM-dd");
                this.Sp_Preparation_Date = lstrAdate;

             

                this.SearchMethodJarVarCallingSPSearchStoreItemPreparedWithCount();
         
            

                try
                {
                    if (SearchStoreItemPreparedWithCount.Tables.Count > 0)
                    {



                        DataView dv = new DataView(SearchStoreItemPreparedWithCount.Tables[0]);


                        dv.RowFilter = "is_approved_prepa_date = '" + lstrAdate + "' and fox = '" + this.sp_Fox + "'   ";



                        this.dgvPreparedItemDistinct.DataSource = dv;

                        this.TotalRecordofPrepared = dgvPreparedItemDistinct.RowCount.ToString();

                    }
                }





                catch (SyntaxErrorException)
                {
                    MessageBox.Show("Invalid character found Type 1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
                catch (EvaluateException)
                {
                    MessageBox.Show("Invalid character found Type 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }


                //End Search


                //Initial Count of Repack   Incremented Bujerang
                double currentStateRepack;
                double currentStateQty;

                if (this.TotalRecordofPrepared == "0")
                {
                    if (this.dgvStoreOrderApproval_Is_wh_checker_cancel == "1")
                    {

                    }
                    else
                    {
                        this.dgvPreparedItemDistinct_CurrentCellChanged(sender, e);
                        this.TotalItemPreparedPerItemIncrementation = "0";
                        currentStateRepack = double.Parse(this.TotalItemPreparedPerItemIncrementation);

                        currentStateQty = currentStateRepack + 1;
                        this.Sp_RepackIncement = Convert.ToInt32(currentStateQty);
                    }
                }
                else
                {
                    //If you have a available fucking records
                    if (this.dgvStoreOrderApproval_Is_wh_checker_cancel == "1")
                    {
                        //Rekta Puyat
                        this.dgvPreparedItemDistinct_CurrentCellChanged(sender, e);


                        currentStateRepack = double.Parse(this.TotalItemPreparedPerItemIncrementation);

                        currentStateQty = currentStateRepack * 1;
                        this.Sp_RepackIncement = Convert.ToInt32(currentStateQty);

                    }
                    else
                    {
                        this.dgvPreparedItemDistinct_CurrentCellChanged(sender, e);
                        currentStateRepack = double.Parse(this.TotalItemPreparedPerItemIncrementation);

                        currentStateQty = currentStateRepack + 1;
                        this.Sp_RepackIncement = Convert.ToInt32(currentStateQty);
                    }
                }



                //Data Sets Dry Warehouse Order Total Items 2/18/2022 12:01 PM
                if (this.dgvStoreOrderApproval_Is_wh_checker_cancel == "1")
                {

                }
                else
                {
                    this.dSet.Clear();
                    this.dSet = objStorProc.sp_Store_Preparation_Logs(0,
                    this.Sp_RepackIncement.ToString(),
                    lstrAdate,
                    this.mattxtItemCode.Text,
                    this.matTxtDescription.Text,
                    this.matTxtOrderQty.Text,
                    this.mattxtQtyServe.Text,
                    "", this.Sp_User_ID.ToString(),
                    Convert.ToInt32(this.Sp_Material_Id),
                    this.sp_Fox, 
                    this.sp_Route, 
                    this.sp_Area,
                    this.Sp_FK_dry_wh_orders_parent_id,
                    "update_dry_orders_total_state_repack");
                }

                //Clear na this
            

                double ActualQuantityReleased;

                double ActualQuantityServed;

                double ActualQuantityOrder;

                double TotalQuantityServeState;


                ActualQuantityReleased = double.Parse(this.matTxtQtyRelease.Text);
                ActualQuantityServed = double.Parse(this.mattxtQtyServe.Text);
                ActualQuantityOrder = double.Parse(this.matTxtOrderQty.Text);

                TotalQuantityServeState = ActualQuantityReleased + ActualQuantityServed;

                if (ActualQuantityOrder == TotalQuantityServeState)
                {
                    //Update Status Already Repack
                    dSet.Clear();
                    dSet = objStorProc.sp_Store_Preparation_Logs(0,
                    this.Sp_Barcode_Id,
                    this.Sp_Preparation_Date,
                    this.mattxtItemCode.Text,
                    this.matTxtDescription.Text,
                    this.matTxtOrderQty.Text,
                    this.mattxtQtyServe.Text,
                    "", 
                    this.Sp_User_ID.ToString(),
                    Convert.ToInt32(this.Sp_Material_Id),
                     this.sp_Fox, 
                     this.sp_Route, 
                     this.sp_Area,
                     this.Sp_FK_dry_wh_orders_parent_id,
                    "update_dry_orders");

          

                    if (ActualQuantityReleased == 0)
                    {
                       
                        dSet.Clear();
                        dSet = objStorProc.sp_Store_Preparation_Logs(0,
                        this.Sp_Barcode_Id,
                        this.Sp_Preparation_Date,
                        this.mattxtItemCode.Text,
                        this.matTxtDescription.Text,
                        this.matTxtOrderQty.Text,
                        this.mattxtQtyServe.Text,
                        "",
                        this.Sp_User_ID.ToString(),
                        Convert.ToInt32(this.Sp_Material_Id),
                        this.sp_Fox,
                        this.sp_Route, 
                        this.sp_Area,
                        this.Sp_FK_dry_wh_orders_parent_id,
                        "bulk_produce_store_timestamp");



                        this.BulkSaveEntryIntoStoredProc();
                    }
                }


                else
                {
            
                    dSet.Clear();
                    dSet = objStorProc.sp_Store_Preparation_Logs(0,
                    this.Sp_Barcode_Id,
                    this.Sp_Preparation_Date,
                    this.mattxtItemCode.Text,
                    this.matTxtDescription.Text,
                    this.matTxtOrderQty.Text,
                    this.mattxtQtyServe.Text,
                    "",
                    this.Sp_User_ID.ToString(),
                    Convert.ToInt32(this.Sp_Material_Id),
                    this.sp_Fox,
                    this.sp_Route,
                    this.sp_Area, 
                    this.Sp_FK_dry_wh_orders_parent_id,
                    "start_dry_orders_store_timestamp");
                
    
                    this.BulkSaveEntryIntoStoredProc();

                }



  
                if (this.dgvStoreOrderApproval_Is_wh_checker_cancel == "1")
                {

                    if (this.Sp_TotalRawMaterialPreparationActive == "1")
                    {
                        dSet.Clear();
                        dSet = objStorProc.sp_Store_Preparation_Logs(Convert.ToInt32(this.dgvStoreOrderApproval_Primary_ID),
                        this.sp_Fox,
                        this.Sp_Preparation_Date,
                        this.Sp_Category,
                        this.matTxtDescription.Text,
                        this.matTxtOrderQty.Text,
                        this.mattxtQtyServe.Text,
                        "", this.Sp_User_ID.ToString(),
                        Convert.ToInt32(this.Sp_Material_Id),
                        this.sp_Fox, 
                        this.Sp_Category, 
                        this.sp_Area,
                        this.Sp_FK_dry_wh_orders_parent_id,
                        "update_StorePreparationLogsTBL_DataRefactoring");
                    }

                }



                this.Close();
            }
            else
            {
                return;
            }



   


        }

        private void BulkSaveEntryIntoStoredProc()
        {
            
            dSet.Clear();
            dSet = objStorProc.sp_Store_Preparation_Logs(0,
            this.Sp_Barcode_Id,
            this.Sp_Preparation_Date,
            this.mattxtItemCode.Text,
            this.matTxtDescription.Text,
            this.matTxtOrderQty.Text,
            this.mattxtQtyServe.Text,
            this.Sp_Category,
            this.Sp_User_ID.ToString(),
            Convert.ToInt32(this.Sp_Material_Id),
            this.sp_Fox,
            this.sp_Route,
            this.sp_Area,
            this.Sp_FK_dry_wh_orders_parent_id,
            "start_dry_orders_store_timestamp_overall");
        }









        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }
  



        private void frmServeStorePreparation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.mattxtQtyServe.Text == String.Empty)
            {
                this.textBox1.Text = "FormClosing";
            }
            else
            {
                this.textBox1.Text = "ItemServe";
            }
         
        }

        private void mattxtQtyServe_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(this.mattxtQtyServe.Text + ch, out x))
            {
                e.Handled = true;
            }
        }



        private void gunaDgvReceivedIDInventory_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.gunaDgvReceivedIDInventory.Rows.Count > 0)
            {
                if (this.gunaDgvReceivedIDInventory.CurrentRow != null)
                {
                    if (this.gunaDgvReceivedIDInventory.CurrentRow.Cells["item_code"].Value != null)
                    {
                        //p_id = Convert.ToInt32(dgvStoreOrderApproval.CurrentRow.Cells["primary_id"].Value);
                        this.matTxtQtyRemaining.Text = this.gunaDgvReceivedIDInventory.CurrentRow.Cells["qty_received"].Value.ToString();
                        this.matTxtExpDate.Text = this.gunaDgvReceivedIDInventory.CurrentRow.Cells["exp_date"].Value.ToString();
                        this.mattxttotalqtyreleased.Text = this.gunaDgvReceivedIDInventory.CurrentRow.Cells["TOTAL_QTY_PREPARED"].Value.ToString();
                    }
                }
            }
        }

        private void dgvPreparedItemDistinct_CurrentCellChanged(object sender, EventArgs e)
        {

            if (this.dgvPreparedItemDistinct.Rows.Count > 0)
            {
                if (this.dgvPreparedItemDistinct.CurrentRow != null)
                {
                    if (this.dgvPreparedItemDistinct.CurrentRow.Cells["is_approved_prepa_date"].Value != null)
                    {
                      
                        this.TotalItemPreparedPerItemIncrementation = this.dgvPreparedItemDistinct.CurrentRow.Cells["TotalPreparedPerItem"].Value.ToString();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.SearchMethodJarVarCallingSPSearchStoreItemPreparedWithCount();
            //doSearchSearchStoreItemPreparedWithCount();
            //MessageBox.Show(this.TotalItemPreparedPerItemIncrementation);
        }
    }
}
