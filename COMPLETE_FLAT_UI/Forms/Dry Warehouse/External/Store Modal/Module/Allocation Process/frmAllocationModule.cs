using COMPLETE_FLAT_UI.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.Forms.Dry_Warehouse.External.Preparation;
using ULTRAMAVERICK.Forms.Dry_Warehouse.External.Store_Modal.Module.Allocation_Process;
using ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module.Allocation_Process.Class;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module
{
    public partial class frmAllocationModule : MaterialForm
    {
 

        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        string mode = "";
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        frmAllocationModuleClasses FormClass = new frmAllocationModuleClasses();
        int p_id = 0;

        private bool eventHookedUp;
        public int LineAllocationCancelCount = 0;
        DateTime dNow = DateTime.Now;
        //Boolean ready = false;

        int user_identity = 0;
        DataSet dSet_temp = new DataSet();
        public frmAllocationModule()
        {
            InitializeComponent();
        }


       
       public string ErrorDetails { get; set;}

        private void frmAllocationModule_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
           
            this.showRawMaterialsInDryWH();
   
            this.CallInitializeComponent();
            this.DisposeControlsWhenDataIsNull();
        }

        private void CallInitializeComponent()
        {
            this.FormClass.user_id = userinfo.user_id;
            this.user_identity = userinfo.user_id;
        }

        private void ConnectionInit()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections

        }

        private void showRawMaterialsInDryWH()    //method for loading available_menus
        {
            try
            {

                myClass.fillDataGridView(this.dgvStoreOrderApproval, "Raw_Materials_Dry_Allocation", dSet);

               this.lbltotaldata.Text = this.dgvStoreOrderApproval.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.DataGridVisibleFalseForDistinctItems();

        }


        DataSet dset_emp_SearchForAllocation = new DataSet();
        private void SearchMethodforAllocation()
        {

            this.dset_emp_SearchForAllocation.Clear();
            this.dset_emp_SearchForAllocation = g_objStoredProcCollection.sp_getMajorTables("Raw_Materials_Dry_Allocation_Major");

        }

        private void FormmLoadSearchAllocationMaster()
        {

            try
            {


                if (this.dset_emp_SearchForAllocation.Tables.Count > 0)
                {
                    DataView dv = new DataView(this.dset_emp_SearchForAllocation.Tables[0]);

                    try
                    {


                    
                            dv.RowFilter = "(item_code = '" + this.txtItemCode.Text + "' ";
                 
                        this.dgvStoreOrderApproval.DataSource = dv;
                        this.lbltotaldata.Text = dgvStoreOrderApproval.RowCount.ToString();
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


        private void DataGridVisibleFalseForDistinctItems()
        {
            this.dgvStoreOrderApproval.Columns["selected"].Visible = false;
            this.dgvStoreOrderApproval.Columns["total_row"].Visible = false;
            this.dgvStoreOrderApproval.Columns["GRANDTOTAL_COL_QTY"].Visible = false;
            this.dgvStoreOrderApproval.Columns["COUNT_ORDER"].Visible = false;
            this.dgvStoreOrderApproval.Columns["p_nearly_expiry_desc"].Visible = false;
            this.dgvStoreOrderApproval.Columns["is_expirable"].Visible = false;
            this.dgvStoreOrderApproval.Columns["DAYSTOEXPIRED"].Visible = false;
        }


        private void dgvStoreOrderApproval_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                this.showDataGridDataValueChanged();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            
       
        }



        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; 
            dset_emp_SearchEngines.Clear();
            dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("searchorderForApprovalinDryWH_Allocation");    
        }


        private void hideFindColumninDataGridViewer()
        {

            this.dgvFindStoreOrders.Columns["order_id"].Visible = false;
            this.dgvFindStoreOrders.Columns["fox"].Visible = false;
            this.dgvFindStoreOrders.Columns["DgvBtnDispossal"].Visible = false;
            this.dgvFindStoreOrders.Columns["area"].Visible = false;
            this.dgvFindStoreOrders.Columns["category"].Visible = false;
            this.dgvFindStoreOrders.Columns["date_added"].Visible = false;
            this.dgvFindStoreOrders.Columns["route"].Visible = false;
            this.dgvFindStoreOrders.Columns["primary_id"].Visible = false;
            this.dgvFindStoreOrders.Columns["total_row"].Visible = false;
            this.dgvFindStoreOrders.Columns["uom"].Visible = false;
            this.dgvFindStoreOrders.Columns["item_code_find"].Visible = false;

        }


        private void doSearchInTextBox()
        {
            try
            {


                if (this.dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(this.dset_emp_SearchEngines.Tables[0]);
                    if (myglobal.global_module == "EMPLOYEE")
                    {

                    }
                    else if (myglobal.global_module == "Active")
                    {
                        // Changing the Sort order to descending
                        dv.Sort = "primary_id DESC";
                        dv.RowFilter = "item_code like '%" + this.txtItemCode.Text + "%' ";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                   this.dgvFindStoreOrders.DataSource = dv;
                    this.lbltotalStoreOrder.Text = this.dgvFindStoreOrders.RowCount.ToString();
                    if(this.lbltotalStoreOrder.Text != "0")
                    {
                        this.lbltotalStoreOrder.Visible = true;
                    }
                    else
                    {
                        this.lbltotalStoreOrder.Visible = false;
                    }
                    this.txtTotalStore.Text = this.dgvFindStoreOrders.RowCount.ToString();
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

        private void showDataGridDataValueChanged()
        {
            if (this.dgvStoreOrderApproval.Rows.Count > 0)
            {
                if (this.dgvStoreOrderApproval.CurrentRow != null)
                {
                    if (this.dgvStoreOrderApproval.CurrentRow.Cells["item_code"].Value != null)
                    {
                    
                        this.txtItemCode.Text = this.dgvStoreOrderApproval.CurrentRow.Cells["item_code"].Value.ToString();
                        this.txtitemDescription.Text = this.dgvStoreOrderApproval.CurrentRow.Cells["description"].Value.ToString();
                        this.txtCategory.Text = this.dgvStoreOrderApproval.CurrentRow.Cells["sub_category"].Value.ToString();
                        this.txtSoh.Text = this.dgvStoreOrderApproval.CurrentRow.Cells["StockOnHand"].Value.ToString();
                        this.txtReserve.Text = this.dgvStoreOrderApproval.CurrentRow.Cells["RESERVED"].Value.ToString();
                    }
                }
            }
        }

        private void txtItemCode_TextChanged(object sender, EventArgs e)
        {
            this.ConnectionInit();

            this.SearchMethodJarVarCallingSP();

            this.doSearchInTextBox();
            if(this.lbltotalStoreOrder.Text =="0")
            {

            }
            
            else
            {
                this.hideFindColumninDataGridViewer();
                this.SumofTotalOrderDataGridView();
                this.SumofTotalAllocatedDataGridView();

                //foreach (DataGridViewRow row in dgvFindStoreOrders.Rows)
                //{

                //    if (Convert.ToDateTime(row.Cells["date_ordered"].Value) > DateTime.Now.Date)
                //    {
                //        this.matBtnSave.Enabled = true;
                //    }
                //    else
                //    {
                //        this.matBtnSave.Enabled = false;
                //    }
                //}
            }

            //if(this.lbltotalStoreOrder.Text =="0")
            //{

            //}
            //else
            //{
            //    //this.SelectAllCheckBoxOnDataGrid(); //remove muna
            //}
         
          
       
   



            }


            private void DisposeControlsWhenDataIsNull()
        {
            if (this.lbltotalStoreOrder.Text == "0" && this.lbltotaldata.Text == "0")
            {

                this.lblqtyAllocatedFinal.Visible = false;
                this.lbldataLabel.Visible = false;
                this.lbltotalStoreOrder.Visible = false;
                this.lblshowItemsFinder.Visible = false;
                this.matCardFindAllocation.Visible = false;
                this.groupBox1AdditionlOrderUI.Visible = false;
                this.matbtnManualAllocation.Visible = false;
                this.matbtnNewAllocate.Visible = false;
                this.lbltotaldata.Visible = false;
                this.lblitems.Visible = false;
                this.dgvStoreOrderApproval.Enabled = false;
                this.matBtnSave.Visible = false;
            }
            else
            {
                this.matBtnSave.Visible = true;
                this.lblqtyAllocatedFinal.Visible = true;
                this.lbldataLabel.Visible = true;
                this.lblshowItemsFinder.Visible = true;
                this.matCardFindAllocation.Visible = true;
                this.groupBox1AdditionlOrderUI.Visible = true;
                this.dgvStoreOrderApproval.Enabled = true;

                this.AllocationDataGridReadOnly();
            }

            this.lblqtyAllocatedFinal.Visible = false;
            this.lbldataLabel.Visible = false;
        }

        private void AllocationDataGridReadOnly()
        {
            this.dgvFindStoreOrders.Columns["store_name"].ReadOnly = true;
            this.dgvFindStoreOrders.Columns["item_code_find"].ReadOnly = true;
            this.dgvFindStoreOrders.Columns["uom"].ReadOnly = true;
            this.dgvFindStoreOrders.Columns["qty"].ReadOnly = true;
            this.dgvFindStoreOrders.Columns["date_ordered"].ReadOnly = true;
            this.dgvFindStoreOrders.Columns["primary_id"].ReadOnly = true;

            this.dgvFindStoreOrders.Columns["fox"].ReadOnly = true;
            this.dgvFindStoreOrders.Columns["route"].ReadOnly = true;
            this.dgvFindStoreOrders.Columns["area"].ReadOnly = true;
            this.dgvFindStoreOrders.Columns["category"].ReadOnly = true;
            this.dgvFindStoreOrders.Columns["total_row"].ReadOnly = true;
            this.dgvFindStoreOrders.Columns["order_id"].ReadOnly = true;
            this.dgvFindStoreOrders.Columns["date_added"].ReadOnly = true;
            this.dgvFindStoreOrders.Columns["DgvBtnDispossal"].ReadOnly = true;
            if (this.matBtnSave.Enabled == true)
            {
                this.dgvFindStoreOrders.Columns["ALLOCATION_QTY_FIND"].ReadOnly = true;
            }

        }
        private void SelectAllCheckBoxOnDataGrid()
        {

            for (int i = 0; i < this.dgvFindStoreOrders.RowCount; i++) { this.dgvFindStoreOrders.Rows[i].Cells["selected2"].Value = true; }
        }

        private void SumofTotalOrderDataGridView()
        {
            int sum = 0;
            for (int i = 0; i < this.dgvFindStoreOrders.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(this.dgvFindStoreOrders.Rows[i].Cells["qty"].Value);
            }
            this.txtQtyOrder.Text = sum.ToString();
        }

        private void SumofTotalAllocatedDataGridView()
        {

            int sum = 0;
            for (int i = 0; i < this.dgvFindStoreOrders.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(this.dgvFindStoreOrders.Rows[i].Cells["ALLOCATION_QTY_FIND"].Value);
            }
            this.lblqtyAllocatedFinal.Text = sum.ToString();
        }



        private void matBtnSave_Click(object sender, EventArgs e)
        {

            
            if(this.txtReserve.Text == "0")
            {
                this.GlobalStatePopup.NotEnoughStock();
                return;
            }


            if (MetroFramework.MetroMessageBox.Show(this, "Do you want to allocate?", "Confirmation", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.ConnectionInit();
     
                this.SenderTextChangedValue();
    
                this.MethodPost();
            }
            else

            {
                return;
            }

        }

        private void MethodPost()
        {

            this.ComputationofAllocationQuantity();


            //this.lblAllocatedQty.Text = CurrentComputationMemory.ToString();
            this.InsertDataPerRow();

            //MessageBox.Show("Bobo akio");
            //return;

            if (this.dgvFindStoreOrders.Rows.Count >= 1)
            {
                int i = this.dgvFindStoreOrders.CurrentRow.Index + 1;
                if (i >= -1 && i < this.dgvFindStoreOrders.Rows.Count)
                    this.dgvFindStoreOrders.CurrentCell = this.dgvFindStoreOrders.Rows[i].Cells[1];
                else
                {


                    if (mode == "error")
                    {
                        this.GlobalStatePopup.ErrorNotify(this.ErrorDetails);
                    }
                    else
                    {


                        this.dgvFindStoreOrders.CurrentCell = this.dgvFindStoreOrders.Rows[0].Cells[this.dgvFindStoreOrders.CurrentCell.ColumnIndex];

                    }

                
                    this.SenderTextChangedValue();
                    this.matbtnNewAllocate.Visible = true;
                    this.GlobalStatePopup.AllocatedSuccessfully();
                    this.matBtnSave.Enabled = false;
                    this.dgvStoreOrderApproval.Enabled = false;

                    if (this.matBtnSave.Enabled == false)
                    {
                        this.dgvFindStoreOrders.Columns["ALLOCATION_QTY_FIND"].ReadOnly = false;
                    }
                        this.dgvFindStoreOrders.CurrentCell = this.dgvFindStoreOrders.Rows[0].Cells[this.dgvFindStoreOrders.CurrentCell.ColumnIndex];
                    ////For Decrementation
                    this.lblvariance.Text = (float.Parse(this.txtReserve.Text.ToString()) - float.Parse(this.lblqtyAllocatedFinal.Text)).ToString();

                    return;
                }
            }
        
            this.MethodPost();
        }



        private void SenderTextChangedValue()
        {
            this.txtItemCode_TextChanged(new object(), new System.EventArgs());
            this.txtReserve_TextChanged(new object(), new System.EventArgs());
        }
        private void InsertDataPerRow()
        {
            try
            {
                this.dSet.Clear();
                this.dSet = g_objStoredProcCollection.sp_Allocation_Logs(
                p_id,
                this.txtItemCode.Text.Trim(),
                this.txtitemDescription.Text.Trim(),
                this.lblAllocatedQty.Text.Trim(),
                this.FormClass.user_id.ToString(), "",
                p_id.ToString(),
                Convert.ToInt32(this.lbltotalStoreOrder.Text.Trim()),
                Convert.ToInt32(this.txtQtyOrder.Text.Trim()),
                "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {

                this.dSet.Clear();
                this.dSet = g_objStoredProcCollection.sp_Allocation_Logs(p_id,
                this.txtItemCode.Text.Trim(), this.txtitemDescription.Text.Trim(), 
                this.lblAllocatedQty.Text.Trim(),
                this.FormClass.user_id.ToString(),
                "", p_id.ToString(), 
                Convert.ToInt32(this.lbltotalStoreOrder.Text.Trim()), 
                Convert.ToInt32(this.txtQtyOrder.Text.Trim()),
                "delete");
                }



                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_Allocation_Logs(0,
                    this.txtItemCode.Text.Trim(), 
                    this.txtitemDescription.Text.Trim(), 
                    this.lblAllocatedQty.Text.Trim(),
                    this.FormClass.user_id.ToString(), 
                    "", 
                    p_id.ToString(), 
                    Convert.ToInt32(this.lbltotalStoreOrder.Text.Trim()), 
                    Convert.ToInt32(this.txtQtyOrder.Text.Trim()),
                    "add");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


           
        }



        private void ComputationofAllocationQuantity()
        {

            try
            {
                double orderActual;
                double totalOrderQuantity;
                double totalPercentage;
                double StockOnHandQty;


                orderActual = double.Parse(this.FormClass.sp_qty_finder);
                totalOrderQuantity = double.Parse(this.txtQtyOrder.Text);
                StockOnHandQty = double.Parse(this.txtReserve.Text);
                totalPercentage = orderActual / totalOrderQuantity * StockOnHandQty;
                this.lblAllocatedQty.Text = totalPercentage.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }


        private void dgvFindStoreOrders_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.lbltotalStoreOrder.Text == "0")
                {

                }
                else
                {
                    this.showDataGridDataValueChangedFinder();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

      

        }
        private void showDataGridDataValueChangedFinder()
        {
            if (this.dgvFindStoreOrders.Rows.Count > 0)
            {
                if (this.dgvFindStoreOrders.CurrentRow != null)
                {
                    if (this.dgvFindStoreOrders.CurrentRow.Cells["qty"].Value != null)
                    {
                     
                        p_id = Convert.ToInt32(this.dgvFindStoreOrders.CurrentRow.Cells["primary_id"].Value);                  
                        this.FormClass.sp_qty_finder = this.dgvFindStoreOrders.CurrentRow.Cells["qty"].Value.ToString();
                        this.FormClass.sp_total_row_allocated = Convert.ToInt32(this.dgvFindStoreOrders.CurrentRow.Cells["total_row"].Value);
                        this.FormClass.Sp_Store_Name = this.dgvFindStoreOrders.CurrentRow.Cells["store_name"].Value.ToString();
                        this.FormClass.Allocated_Quantity = Convert.ToInt32(this.dgvFindStoreOrders.CurrentRow.Cells["ALLOCATION_QTY_FIND"].Value);
                        this.FormClass.UnitOfMeasure = this.dgvFindStoreOrders.CurrentRow.Cells["uom"].Value.ToString();

                    }
                }
            }
        }
        

        private void txtSoh_TextChanged(object sender, EventArgs e)
        {
            //if(this.txtSoh.Text == this.lblqtyAllocatedFinal.Text)
            //{
            //    this.matBtnSave.Enabled = false;
            //}
            //else
            //{
            //    this.matBtnSave.Enabled = true;
            //}

            //if (this.FormClass.sp_total_row_allocated == Convert.ToInt32(this.lbltotalStoreOrder.Text))
            //{
     
            //}
            //else

            //{
            //    this.matBtnSave.Enabled = true;
            //}
            //if(this.txtSoh.Text == "0")
            //{
            //    //this.matBtnSave.Enabled = false;
            //    //AutoAllocate
            //}
        
    


        }

        private void dgvFindStoreOrders_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }

        private void lbltotalStoreOrder_TextChanged(object sender, EventArgs e)
        {
            if(this.lbltotalStoreOrder.Text == "0")
            {
                this.lblvariancedesc.Visible = false;
                this.lblvariancedesc.Visible = false;
                this.lblvariance.Visible = false;
            }
            else
            {
                this.lblvariancedesc.Visible = true;
                this.lblvariancedesc.Visible = true;
                this.lblvariance.Visible = true;
            }

        }

        private void dgvFindStoreOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
          
            foreach (DataGridViewRow row in dgvFindStoreOrders.Rows)
            {

                if (row.Cells["ALLOCATION_QTY_FIND"].Value.ToString() == string.Empty)
                {
                    return;
                }
            }
            //MessageBox.Show(DateTime.Now.ToString());
            foreach (DataGridViewRow row in dgvFindStoreOrders.Rows)
            {
             
             


                    if (Convert.ToDouble(row.Cells["ALLOCATION_QTY_FIND"].Value) == 0)
                {
                    // row.DefaultCellStyle.BackColor = Color.LightSalmon; // Use it in order to colorize all cells of the row

                    row.Cells["ALLOCATION_QTY_FIND"].Style.BackColor = Color.WhiteSmoke;
                    row.Cells["item_code_find"].Style.BackColor = Color.DarkOrange;
                    row.Cells["store_name"].Style.BackColor = Color.DarkOrange;
                    row.Cells["uom"].Style.BackColor = Color.DarkOrange;
                    row.Cells["qty"].Style.BackColor = Color.DarkOrange;
                    //row.Cells["date_ordered"].Style.BackColor = Color.DarkOrange;
                    row.Cells["date_ordered"].Style.BackColor = Color.DarkOrange;


                    row.Cells["store_name"].Style.SelectionBackColor = Color.DarkOrange;
                    row.Cells["item_code_find"].Style.SelectionBackColor = Color.DarkOrange;
                    row.Cells["uom"].Style.SelectionBackColor = Color.DarkOrange;
                    //row.Cells["date_ordered"].Style.SelectionBackColor = Color.DarkOrange;
                    row.Cells["ALLOCATION_QTY_FIND"].Style.SelectionBackColor = Color.WhiteSmoke;
                    row.Cells["qty"].Style.SelectionBackColor = Color.DarkOrange;


                    row.Cells["store_name"].Style.SelectionForeColor = Color.Black;
                    row.Cells["item_code_find"].Style.SelectionForeColor = Color.Black;
                    row.Cells["uom"].Style.SelectionForeColor = Color.Black;
                    row.Cells["date_ordered"].Style.SelectionForeColor = Color.White;
                    row.Cells["ALLOCATION_QTY_FIND"].Style.SelectionForeColor = Color.Red;
                    row.Cells["ALLOCATION_QTY_FIND"].Style.ForeColor = Color.Red;
                    row.Cells["ALLOCATION_QTY_FIND"].Style.Font = new Font("Roboto", 10, FontStyle.Bold);
                    row.Cells["qty"].Style.SelectionForeColor = Color.Black;
                }
        
            
                else
                {

                    row.Cells["ALLOCATION_QTY_FIND"].Style.BackColor = Color.Yellow;
                    row.Cells["item_code_find"].Style.BackColor = Color.Yellow;
                    row.Cells["store_name"].Style.BackColor = Color.Yellow;
                    row.Cells["uom"].Style.BackColor = Color.Yellow;
                    row.Cells["qty"].Style.BackColor = Color.Yellow;
                    row.Cells["date_ordered"].Style.BackColor = Color.Yellow;
                    row.Cells["date_ordered"].Style.BackColor = Color.Yellow;



                    row.Cells["store_name"].Style.SelectionBackColor = Color.Yellow;
                    row.Cells["item_code_find"].Style.SelectionBackColor = Color.Yellow;
                    row.Cells["uom"].Style.SelectionBackColor = Color.Yellow;
                    row.Cells["date_ordered"].Style.SelectionBackColor = Color.Yellow;
                    row.Cells["ALLOCATION_QTY_FIND"].Style.SelectionBackColor = Color.Yellow;
                    row.Cells["qty"].Style.SelectionBackColor = Color.Yellow;


                    row.Cells["store_name"].Style.SelectionForeColor = Color.Black;
                    row.Cells["item_code_find"].Style.SelectionForeColor = Color.Black;
                    row.Cells["uom"].Style.SelectionForeColor = Color.Black;
                    row.Cells["date_ordered"].Style.SelectionForeColor = Color.Black;
                    row.Cells["ALLOCATION_QTY_FIND"].Style.SelectionForeColor = Color.Crimson;
                    row.Cells["qty"].Style.SelectionForeColor = Color.Black;
                }

                }

            }



        private void matbtnManualAllocation_Click(object sender, EventArgs e)
        {
            this.matbtnManualAllocation.Visible = false;
            this.matbtnNewAllocate.Visible = false;
            frmManualAllocationController ManualAllocation =
             new frmManualAllocationController(this, this.p_id, Convert.ToInt32(this.txtReserve.Text), this.FormClass.Sp_Store_Name, 
             this.FormClass.Allocated_Quantity, Convert.ToInt32(this.lblqtyAllocatedFinal.Text), this.txtItemCode.Text, this.txtitemDescription.Text, 
             this.FormClass.UnitOfMeasure, Convert.ToInt32(this.FormClass.sp_qty_finder)
             );
            ManualAllocation.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.SenderTextChangedValue();


            if(this.lblqtyAllocatedFinal.Text !="0")
            {
                this.matBtnSave.Enabled = false;
                this.matbtnManualAllocation.Visible = true;
                this.matbtnNewAllocate.Visible = true;

            }
            if(this.textBox2.Text == "Save")
            {
                this.GlobalStatePopup.UpdatedSuccessfully();
            }

            this.textBox2.Text = String.Empty;
          
        }

        private void lblAllocatedQty_Click(object sender, EventArgs e)
        {

        }

        private void matbtnNewAllocate_Click(object sender, EventArgs e)
        {
            if (this.lblqtyAllocatedFinal.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                return;
            }

            if (this.lblvariance.Text.Contains("-"))
            {
                this.GlobalStatePopup.GreaterThanActualRemainingQtyInformation();
                return;
            }

        
        
            
            
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to allocate the new order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.dgvFindStoreOrders.CurrentCell = this.dgvFindStoreOrders.Rows[0].Cells[this.dgvFindStoreOrders.CurrentCell.ColumnIndex];
      
            
                foreach (DataGridViewRow row in dgvFindStoreOrders.Rows)
                {

                   
                    try
                    {
                        this.dgvFindStoreOrders_CurrentCellChanged(sender, e);
                        //MessageBox.Show(row.Cells["primary_id"].Value.ToString());
                        dSet.Clear();
                        dSet = g_objStoredProcCollection.sp_Allocation_Logs(0,
                            "",
                            "",
                            row.Cells["ALLOCATION_QTY_FIND"].Value.ToString(),
                            this.FormClass.user_id.ToString(),
                            "",
                             row.Cells["primary_id"].Value.ToString(),
                            0,
                            0,
                            "edit");
                        this.GlobalStatePopup.UpdatedSuccessfully();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }

                //End of fucking iteration brainy



                this.matbtnNewAllocate.Visible = false;
                this.matbtnManualAllocation.Visible = false;
                if (this.matBtnSave.Enabled == true)
                {
                    this.dgvFindStoreOrders.Columns["ALLOCATION_QTY_FIND"].ReadOnly = true;
                }
                    //
                    this.lbltotalStoreOrder.Text = "0";
             
                this.frmAllocationModule_Load(sender, e);
            }
            else
            {
                return;
            }

        }

        private void dgvStoreOrderApproval_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }

        private void dgvStoreOrderApproval_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //foreach (DataGridViewRow row in dgvStoreOrderApproval.Rows)
            //{
            //    if (Convert.ToDouble(row.Cells["DAYSTOEXPIRED"].Value) < Convert.ToDouble(row.Cells["p_nearly_expiry_desc"].Value) && Convert.ToString(row.Cells["is_expirable"].Value) == "1")
            //    {
            //        // row.DefaultCellStyle.BackColor = Color.LightSalmon; // Use it in order to colorize all cells of the row

            //        row.Cells["item_code"].Style.BackColor = Color.Crimson;
            //        row.Cells["description"].Style.BackColor = Color.Crimson;
            //        row.Cells["sub_category"].Style.BackColor = Color.Crimson;
            //        row.Cells["ORDERS"].Style.BackColor = Color.Crimson;
            //        row.Cells["StockOnHand"].Style.BackColor = Color.Crimson;
            //        row.Cells["Allocation_qty"].Style.BackColor = Color.Crimson;
            //        row.Cells["DAYSTOEXPIRED"].Style.BackColor = Color.Crimson;





            //        row.Cells["item_code"].Style.SelectionBackColor = Color.DarkSlateGray;
            //        row.Cells["description"].Style.SelectionBackColor = Color.Crimson;
            //        row.Cells["sub_category"].Style.SelectionBackColor = Color.Crimson;
            //        row.Cells["ORDERS"].Style.SelectionBackColor = Color.Crimson;
            //        row.Cells["StockOnHand"].Style.SelectionBackColor = Color.Crimson;
            //        row.Cells["Allocation_qty"].Style.SelectionBackColor = Color.Crimson;
            //        row.Cells["DAYSTOEXPIRED"].Style.SelectionBackColor = Color.Crimson;





            //        row.Cells["item_code"].Style.SelectionForeColor = Color.White;
            //        row.Cells["description"].Style.SelectionForeColor = Color.White;
            //        row.Cells["sub_category"].Style.SelectionForeColor = Color.White;
            //        row.Cells["ORDERS"].Style.SelectionForeColor = Color.White;
            //        row.Cells["StockOnHand"].Style.SelectionForeColor = Color.White;
            //        row.Cells["Allocation_qty"].Style.SelectionForeColor = Color.White;
            //        row.Cells["DAYSTOEXPIRED"].Style.SelectionForeColor = Color.White;
            //    }

             

            //    else
            //    {

            //        row.Cells["item_code"].Style.BackColor = Color.White;
            //        row.Cells["description"].Style.BackColor = Color.White;
            //        row.Cells["sub_category"].Style.BackColor = Color.White;
            //        row.Cells["ORDERS"].Style.BackColor = Color.White;
            //        row.Cells["StockOnHand"].Style.BackColor = Color.White;
            //        row.Cells["Allocation_qty"].Style.BackColor = Color.White;
            //        row.Cells["DAYSTOEXPIRED"].Style.BackColor = Color.White;




            //        row.Cells["item_code"].Style.SelectionBackColor = Color.DarkSlateGray;
            //        row.Cells["description"].Style.SelectionBackColor = Color.DarkSlateGray;
            //        row.Cells["sub_category"].Style.SelectionBackColor = Color.DarkSlateGray;
            //        row.Cells["ORDERS"].Style.SelectionBackColor = Color.DarkSlateGray;
            //        row.Cells["StockOnHand"].Style.SelectionBackColor = Color.DarkSlateGray;
            //        row.Cells["Allocation_qty"].Style.SelectionBackColor = Color.DarkSlateGray;
            //        row.Cells["DAYSTOEXPIRED"].Style.SelectionBackColor = Color.DarkSlateGray;


            //        row.Cells["item_code"].Style.SelectionForeColor = Color.White;
            //        row.Cells["description"].Style.SelectionForeColor = Color.White;
            //        row.Cells["sub_category"].Style.SelectionForeColor = Color.White;
            //        row.Cells["ORDERS"].Style.SelectionForeColor = Color.White;
            //        row.Cells["StockOnHand"].Style.SelectionForeColor = Color.White;
            //        row.Cells["Allocation_qty"].Style.SelectionForeColor = Color.White;
            //        row.Cells["DAYSTOEXPIRED"].Style.SelectionForeColor = Color.White;
            //    }
            //}
        }

        private void lblqtyAllocatedFinal_TextChanged(object sender, EventArgs e)
        {
    

            double StockOnHand;
            double AllocatedQty;

            StockOnHand = double.Parse(this.txtReserve.Text);
            AllocatedQty = double.Parse(this.lblqtyAllocatedFinal.Text);


            if (AllocatedQty > StockOnHand)
            {
             
                this.matbtnNewAllocate.Enabled = false;
                if (this.lblAllocatedQty.Text.Contains("-"))
                {
                    this.GlobalStatePopup.GreaterThanActualRemainingQty();


                    return;
                }
                else
                {
                    this.GlobalStatePopup.GreaterThanActualRemainingQty();

                    return;
                }
            }
            else
            {
                this.matbtnNewAllocate.Enabled = true;
            }

            if (this.lblvariance.Text =="1")
            {
                this.matbtnNewAllocate.Enabled = true;
            }
            else if (this.lblvariance.Text == "0")
            {
                this.matbtnNewAllocate.Enabled = true;
            }

       

 
        }

     




   

      
        private void dgvFindStoreOrders_KeyDown(object sender, KeyEventArgs e)
        {
           


        }

        private void dgvFindStoreOrders_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //foreach (DataGridViewRow row in dgvFindStoreOrders.Rows)
            //{
            //    if (row.Cells["ALLOCATION_QTY_FIND"].Value.ToString() == string.Empty)
            //    {
            //        return;
            //    }
            //}
            //this.SumofTotalAllocatedDataGridView();
            ////For Decrementation
            //this.lblvariance.Text = (float.Parse(this.txtSoh.Text.ToString()) - float.Parse(this.lblqtyAllocatedFinal.Text)).ToString();

    

        }

        private void ColumnDataGridStoreOrders1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }



            //only one decimal point is allowed
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }


            private void dgvFindStoreOrders_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgvFindStoreOrders_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            foreach (DataGridViewRow row in dgvFindStoreOrders.Rows)
            {
                if (row.Cells["ALLOCATION_QTY_FIND"].Value.ToString() == string.Empty)
                {
                    return;
                }
            }


            try
            {
                e.Control.KeyPress -= new KeyPressEventHandler(ColumnDataGridStoreOrders1_KeyPress);
                if (dgvFindStoreOrders.Columns["ALLOCATION_QTY_FIND"].Index > 0) //Desired Column
                {
                    TextBox tb = e.Control as TextBox;
                    if (tb != null)
                    {
                        tb.KeyPress += new KeyPressEventHandler(ColumnDataGridStoreOrders1_KeyPress);
             
                    }
                }

                //I just want to pick up on changes to column 2  
                if (dgvFindStoreOrders.Columns["ALLOCATION_QTY_FIND"].Index > 0)
                {
                    if (!this.eventHookedUp)
                    {
                        e.Control.KeyDown += this.Cell_KeyDown;
                        this.eventHookedUp = true;
                    }
                }
                else
                {
                    e.Control.KeyDown -= this.Cell_KeyDown;
                    this.eventHookedUp = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Cell_KeyDown(object sender, KeyEventArgs e)
        {
           
            try
            {

                this.SumofTotalAllocatedDataGridView();

                    this.showDataGridDataValueChangedFinder();

                    ////For Decrementation
                    this.lblvariance.Text = (float.Parse(this.txtReserve.Text.ToString()) - float.Parse(this.lblqtyAllocatedFinal.Text)).ToString();
   

            }
                //Saving Partial Data
                
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void sample_Click(object sender, EventArgs e)
        {
            //Saving Partial Data
            dgvFindStoreOrders_CurrentCellChanged(sender, e);
            if (this.matbtnNewAllocate.Visible == true)
            {


                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to allocate the order quantity?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //MessageBox.Show("Data Executed!");
                    //this.ConnectionInit();
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_Allocation_Logs(0,
                        "",
                        "",
                        this.FormClass.Allocated_Quantity.ToString(),
                        this.FormClass.user_id.ToString(),
                        "",
                        this.p_id.ToString(),
                        0,
                        0,
                        "edit");
                    this.GlobalStatePopup.UpdatedSuccessfully();
                    this.ConnectionInit();
                    this.doSearchInTextBox();

                }
                else
                {
                    return;
                }


            }
        }

       



        private void dgvFindStoreOrders_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                dgvFindStoreOrders.Rows[e.RowIndex].ErrorText =
                    "0";
                e.Cancel = true;
            }
        }

        private void dgvFindStoreOrders_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (this.lbltotaldata.Text == "0")
            {

            }
            else
            {
     

                this.SumofTotalAllocatedDataGridView();
     

                this.showDataGridDataValueChangedFinder();

            
                this.lblvariance.Text = (float.Parse(this.txtReserve.Text.ToString()) - float.Parse(this.lblqtyAllocatedFinal.Text)).ToString();

            }
      
        }

        private void dgvStoreOrderApproval_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //this.dgvStoreOrderApproval.ClearSelection();
        }

        private void txtReserve_TextChanged(object sender, EventArgs e)
        {
            if (this.txtReserve.Text == this.lblqtyAllocatedFinal.Text)
            {
                this.matBtnSave.Enabled = false;
            }
            else
            {
                this.CheckIFGreatherThanDateNeeded();
                //this.matBtnSave.Enabled = true;
                //MessageBox.Show("11");
            }

            if (this.FormClass.sp_total_row_allocated == Convert.ToInt32(this.lbltotalStoreOrder.Text))
            {

            }
            else

            {
                this.CheckIFGreatherThanDateNeeded();
                //this.matBtnSave.Enabled = true;
                //MessageBox.Show("12");
            }
      
        }


        //Add Global Interger
        private void CheckIFGreatherThanDateNeeded()
        {
            int DateNeededFromNowTrappings = 0;
            foreach (DataGridViewRow row in dgvFindStoreOrders.Rows)
            {

                if (Convert.ToDateTime(row.Cells["date_ordered"].Value) > DateTime.Now.Date)
                {
                    if(DateNeededFromNowTrappings != 1)
                    {
                        this.matBtnSave.Enabled = true;
                    }

                }
                else
                {
                    DateNeededFromNowTrappings = 1;
                    this.matBtnSave.Enabled = false;
                }
            }
        }



        public void CancelRawMaterials()
        {
          
            dSet = g_objStoredProcCollection.sp_IDGenerator(
            int.Parse(this.p_id.ToString()),
            "CancelStoreOrderApprovalIndividual",
            this.textBox2Cancel.Text.Trim(),
            this.user_identity.ToString(), 1, 0);
        }
        private void dgvFindStoreOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvFindStoreOrders.Columns[e.ColumnIndex].Name == "CANCEL")
            {
                frmCancelAllocationOrder FormCancelOrderRemarks = 
                new frmCancelAllocationOrder(this, "CANCEL");
                FormCancelOrderRemarks.ShowDialog();

                //if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to cancel? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                //{






                //}
                //else
                //{
                //    return;
                //}
            }
        }

        private void CancelFunctionality()
        {
    

            dSet = g_objStoredProcCollection.sp_IDGenerator(
            int.Parse(this.p_id.ToString()),
            "CancelStoreOrderApprovalIndividual",
            this.textBox2Cancel.Text.Trim(),
            this.user_identity.ToString(), 1, 0);
        }
        private void textBox2Cancel_TextChanged(object sender, EventArgs e)
        {
         
         
            if (textBox2Cancel.Text == String.Empty)
            {
        
            }
            else
            {
              
               
                    this.CancelFunctionality();
                    this.txtItemCode_TextChanged(sender, e);

                    //this.ConnectionInit();
                    //SearchMethodforAllocation();
                    //FormmLoadSearchAllocationMaster();

                    this.GlobalStatePopup.CancelledSuccessfully();
               
            }
        }

        private void lbltotalStoreOrder_TextChanged_1(object sender, EventArgs e)
        {
            if (this.lbltotalStoreOrder.Text == "0")
            {
                this.frmAllocationModule_Load(sender, e);
            }
           
        }

        private void lbltotalStoreOrder_Click(object sender, EventArgs e)
        {

        }

        private void dgvFindStoreOrders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvFindStoreOrders.Rows)
            {

                if (Convert.ToDateTime(row.Cells["date_ordered"].Value) > DateTime.Now.Date)
                {
                    this.matBtnSave.Enabled = true;
                }
                else
                {
                    this.matBtnSave.Enabled = false;
                }
            }
        }

        ///
    }
}
