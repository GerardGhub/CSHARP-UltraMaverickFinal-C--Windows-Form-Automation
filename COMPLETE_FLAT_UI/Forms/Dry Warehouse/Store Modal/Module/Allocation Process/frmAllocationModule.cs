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
using ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module.Allocation_Process.Class;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module
{
    public partial class frmAllocationModule : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        string mode = "";
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        frmAllocationModuleClasses FormClass = new frmAllocationModuleClasses();
        int p_id = 0;

        DateTime dNow = DateTime.Now;
        //Boolean ready = false;


        DataSet dSet_temp = new DataSet();
        public frmAllocationModule()
        {
            InitializeComponent();
        }


       

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
        }

        private void ConnectionInit()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            this.objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
        }

        private void showRawMaterialsInDryWH()    //method for loading available_menus
        {
            try
            {

                xClass.fillDataGridView(this.dgvStoreOrderApproval, "Raw_Materials_Dry_Allocation", dSet);

               this.lbltotaldata.Text = this.dgvStoreOrderApproval.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
            this.showDataGridDataValueChanged();
       
        }



        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = objStorProc.sp_getMajorTables("searchorderForApprovalinDryWH_Allocation");
     


        }


        private void hideFindColumninDataGridViewer()
        {
            this.dgvFindStoreOrders.Columns["order_id"].Visible = false;
            this.dgvFindStoreOrders.Columns["fox"].Visible = false;
            this.dgvFindStoreOrders.Columns["area_find"].Visible = false;
            this.dgvFindStoreOrders.Columns["category"].Visible = false;
            this.dgvFindStoreOrders.Columns["date_added"].Visible = false;
            this.dgvFindStoreOrders.Columns["route"].Visible = false;
            this.dgvFindStoreOrders.Columns["primary_id"].Visible = false;
            this.dgvFindStoreOrders.Columns["total_row"].Visible = false;

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

                        dv.RowFilter = "item_code like '%" + this.txtItemCode.Text + "%'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                   this.dgvFindStoreOrders.DataSource = dv;
                    this.lbltotalStoreOrder.Text = this.dgvFindStoreOrders.RowCount.ToString();
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
                        //p_id = Convert.ToInt32(this.dgvStoreOrderApproval.CurrentRow.Cells["primary_id"].Value);
  
                        this.txtItemCode.Text = this.dgvStoreOrderApproval.CurrentRow.Cells["item_code"].Value.ToString();
                        this.txtitemDescription.Text = this.dgvStoreOrderApproval.CurrentRow.Cells["description"].Value.ToString();
                        this.txtCategory.Text = this.dgvStoreOrderApproval.CurrentRow.Cells["sub_category"].Value.ToString();
                        this.txtSoh.Text = this.dgvStoreOrderApproval.CurrentRow.Cells["StockOnHand"].Value.ToString();
                    }
                }
            }
        }

        private void txtItemCode_TextChanged(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.SearchMethodJarVarCallingSP();
            this.doSearchInTextBox();
            this.hideFindColumninDataGridViewer();
            this.SumofTotalOrderDataGridView();
            this.SumofTotalAllocatedDataGridView();
            if(this.lbltotalStoreOrder.Text =="0")
            {

            }
            else
            {
                this.SelectAllCheckBoxOnDataGrid();
            }


        }
        private void DisposeControlsWhenDataIsNull()
        {
            if (this.lbltotalStoreOrder.Text == "0")
            {
                this.matBtnSave.Visible = false;
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
                this.lbltotalStoreOrder.Visible = true;
                this.lblshowItemsFinder.Visible = true;
                this.matCardFindAllocation.Visible = true;
                this.groupBox1AdditionlOrderUI.Visible = true;
                this.dgvStoreOrderApproval.Enabled = true;

                this.AllocationDataGridReadOnly();
            }
        }

        private void AllocationDataGridReadOnly()
        {
            this.dgvFindStoreOrders.Columns["store_name"].ReadOnly = true;
            this.dgvFindStoreOrders.Columns["description_find"].ReadOnly = true;
            this.dgvFindStoreOrders.Columns["item_code_find"].ReadOnly = true;
            this.dgvFindStoreOrders.Columns["uom"].ReadOnly = true;
            this.dgvFindStoreOrders.Columns["qty"].ReadOnly = true;
            this.dgvFindStoreOrders.Columns["date_ordered"].ReadOnly = true;
        }
        private void SelectAllCheckBoxOnDataGrid()
        {

            for (int i = 0; i < this.dgvFindStoreOrders.RowCount; i++) { this.dgvFindStoreOrders.Rows[i].Cells["selected2"].Value = true; }
        }

        private void SumofTotalOrderDataGridView()
        {
            int sum = 0;
            for (int i = 0; i < dgvFindStoreOrders.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvFindStoreOrders.Rows[i].Cells["qty"].Value);
            }
            this.txtQtyOrder.Text = sum.ToString();
        }

        private void SumofTotalAllocatedDataGridView()
        {
            int sum = 0;
            for (int i = 0; i < dgvFindStoreOrders.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvFindStoreOrders.Rows[i].Cells["ALLOCATION_QTY_FIND"].Value);
            }
            this.lblqtyAllocatedFinal.Text = sum.ToString();
        }



        private void matBtnSave_Click(object sender, EventArgs e)
        {

            //Allocation Validation if < 0 of the quantity
            if(this.txtSoh.Text == "0")
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

            if (this.dgvFindStoreOrders.Rows.Count >= 1)
            {
                int i = this.dgvFindStoreOrders.CurrentRow.Index + 1;
                if (i >= -1 && i < this.dgvFindStoreOrders.Rows.Count)
                    this.dgvFindStoreOrders.CurrentCell = this.dgvFindStoreOrders.Rows[i].Cells[0];
                else
                {


                    if (mode == "error")
                    {
                        this.GlobalStatePopup.ErrorNotify();
                    }
                    else
                    {


                        this.dgvFindStoreOrders.CurrentCell = this.dgvFindStoreOrders.Rows[0].Cells[this.dgvFindStoreOrders.CurrentCell.ColumnIndex];

                    }

                    //MessageBox.Show("SuccessFully Insert");
                    this.SenderTextChangedValue();
                    //this.showRawMaterialsInDryWH();
                    this.matbtnNewAllocate.Visible = true;
                    this.AllocatedSuccessfully();
                    this.matBtnSave.Enabled = false;
                    this.dgvStoreOrderApproval.Enabled = false;
                    this.matbtnManualAllocation.Visible = true;
                    this.dgvFindStoreOrders.CurrentCell = this.dgvFindStoreOrders.Rows[0].Cells[this.dgvFindStoreOrders.CurrentCell.ColumnIndex];
                    return;
                }
            }
            ///Ending
            ///
            this.MethodPost();
        }


        public void AllocatedSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Allocated Successfully!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 11F);
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
        private void SenderTextChangedValue()
        {
            txtItemCode_TextChanged(new object(), new System.EventArgs());
            txtSoh_TextChanged(new object(), new System.EventArgs());
        }
        private void InsertDataPerRow()
        {
            dSet.Clear();
            dSet = objStorProc.sp_Allocation_Logs(p_id,
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

                dSet.Clear();
                dSet = objStorProc.sp_Allocation_Logs(p_id,
                    this.txtItemCode.Text.Trim(), this.txtitemDescription.Text.Trim(), this.lblAllocatedQty.Text.Trim(), 
                    this.FormClass.user_id.ToString(), "", p_id.ToString(), Convert.ToInt32(this.lbltotalStoreOrder.Text.Trim()), Convert.ToInt32(this.txtQtyOrder.Text.Trim()),
                    "delete");
            }



            dSet.Clear();
            dSet = objStorProc.sp_Allocation_Logs(0,
                this.txtItemCode.Text.Trim(), this.txtitemDescription.Text.Trim(), this.lblAllocatedQty.Text.Trim(), 
                this.FormClass.user_id.ToString(), "", p_id.ToString(), Convert.ToInt32(this.lbltotalStoreOrder.Text.Trim()), Convert.ToInt32(this.txtQtyOrder.Text.Trim()),
                "add");
        }



        private void ComputationofAllocationQuantity()
        {

            double orderActual;
            double totalOrderQuantity;
            double totalPercentage;
            double StockOnHandQty;

 
            orderActual = double.Parse(this.FormClass.sp_qty_finder);
            totalOrderQuantity = double.Parse(this.txtQtyOrder.Text);
            StockOnHandQty = double.Parse(this.txtSoh.Text);
            totalPercentage = orderActual / totalOrderQuantity * StockOnHandQty;
            this.lblAllocatedQty.Text = totalPercentage.ToString();

        }


        private void dgvFindStoreOrders_CurrentCellChanged(object sender, EventArgs e)
        {
            if(this.lbltotalStoreOrder.Text == "0")
            {
            
            }
            else
            {
                this.showDataGridDataValueChangedFinder();
        
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
            if(this.txtSoh.Text == this.lblqtyAllocatedFinal.Text)
            {
                this.matBtnSave.Enabled = false;
            }
            else
            {
                this.matBtnSave.Enabled = true;
            }

            if (this.FormClass.sp_total_row_allocated == Convert.ToInt32(this.lbltotalStoreOrder.Text))
            {
     
            }
            else

            {
                this.matBtnSave.Enabled = true;
            }
            if(this.txtSoh.Text == "0")
            {
                //this.matBtnSave.Enabled = false;
                //AutoAllocate
            }
        
    


        }

        private void dgvFindStoreOrders_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }

        private void lbltotalStoreOrder_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void dgvFindStoreOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvFindStoreOrders.Rows)
            {
                if (Convert.ToDouble(row.Cells["ALLOCATION_QTY_FIND"].Value) == 0)
                {
                    // row.DefaultCellStyle.BackColor = Color.LightSalmon; // Use it in order to colorize all cells of the row

                    row.Cells["ALLOCATION_QTY_FIND"].Style.BackColor = Color.DarkOrange;
                    row.Cells["item_code_find"].Style.BackColor = Color.DarkOrange;
                    row.Cells["store_name"].Style.BackColor = Color.DarkOrange;
                    row.Cells["description_find"].Style.BackColor = Color.DarkOrange;
                    row.Cells["uom"].Style.BackColor = Color.DarkOrange;
                    row.Cells["qty"].Style.BackColor = Color.DarkOrange;
                    row.Cells["date_ordered"].Style.BackColor = Color.DarkOrange;
                    row.Cells["selected2"].Style.BackColor = Color.DarkOrange;


                    row.Cells["store_name"].Style.SelectionBackColor = Color.DarkOrange;
                    row.Cells["item_code_find"].Style.SelectionBackColor = Color.DarkOrange;
                    row.Cells["description_find"].Style.SelectionBackColor = Color.DarkOrange;
                    row.Cells["uom"].Style.SelectionBackColor = Color.DarkOrange;
                    row.Cells["date_ordered"].Style.SelectionBackColor = Color.DarkOrange;
                    row.Cells["ALLOCATION_QTY_FIND"].Style.SelectionBackColor = Color.DarkOrange;
                    row.Cells["qty"].Style.SelectionBackColor = Color.DarkOrange;


                    row.Cells["store_name"].Style.SelectionForeColor = Color.Black;
                    row.Cells["item_code_find"].Style.SelectionForeColor = Color.Black;
                    row.Cells["description_find"].Style.SelectionForeColor = Color.Black;
                    row.Cells["uom"].Style.SelectionForeColor = Color.Black;
                    row.Cells["date_ordered"].Style.SelectionForeColor = Color.Black;
                    row.Cells["ALLOCATION_QTY_FIND"].Style.SelectionForeColor = Color.Black;
                    row.Cells["qty"].Style.SelectionForeColor = Color.Black;
                }
                else
                {

                    row.Cells["ALLOCATION_QTY_FIND"].Style.BackColor = Color.Yellow;
                    row.Cells["item_code_find"].Style.BackColor = Color.Yellow;
                    row.Cells["store_name"].Style.BackColor = Color.Yellow;
                    row.Cells["description_find"].Style.BackColor = Color.Yellow;
                    row.Cells["uom"].Style.BackColor = Color.Yellow;
                    row.Cells["qty"].Style.BackColor = Color.Yellow;
                    row.Cells["date_ordered"].Style.BackColor = Color.Yellow;
                    row.Cells["selected2"].Style.BackColor = Color.Yellow;



                    row.Cells["store_name"].Style.SelectionBackColor = Color.Yellow;
                    row.Cells["item_code_find"].Style.SelectionBackColor = Color.Yellow;
                    row.Cells["description_find"].Style.SelectionBackColor = Color.Yellow;
                    row.Cells["uom"].Style.SelectionBackColor = Color.Yellow;
                    row.Cells["date_ordered"].Style.SelectionBackColor = Color.Yellow;
                    row.Cells["ALLOCATION_QTY_FIND"].Style.SelectionBackColor = Color.Yellow;
                    row.Cells["qty"].Style.SelectionBackColor = Color.Yellow;


                    row.Cells["store_name"].Style.SelectionForeColor = Color.Black;
                    row.Cells["item_code_find"].Style.SelectionForeColor = Color.Black;
                    row.Cells["description_find"].Style.SelectionForeColor = Color.Black;
                    row.Cells["uom"].Style.SelectionForeColor = Color.Black;
                    row.Cells["date_ordered"].Style.SelectionForeColor = Color.Black;
                    row.Cells["ALLOCATION_QTY_FIND"].Style.SelectionForeColor = Color.Black;
                    row.Cells["qty"].Style.SelectionForeColor = Color.Black;
                }
            }

            }



        private void matbtnManualAllocation_Click(object sender, EventArgs e)
        {
            this.matbtnManualAllocation.Visible = false;
            this.matbtnNewAllocate.Visible = false;
            frmManualAllocationController ManualAllocation =
             new frmManualAllocationController(this, this.p_id, Convert.ToInt32(this.txtSoh.Text), this.FormClass.Sp_Store_Name, 
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
            }

            //if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to allocate the order quantity?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //{

            //    dSet.Clear();
            //    dSet = objStorProc.sp_Allocation_Logs(0,
            //        "",
            //        "",
            //        this.mattxtAllocatedQty.Text.Trim(),
            //        this.UserId.ToString(),
            //        "",
            //        this.matTransactionID.Text.Trim(),
            //        0,
            //        0,
            //        "edit");

            //    this.textBox2.Text = "Save";
            //    this.textBox2_TextChanged(sender, e);
            //    this.Close();
            //}
            //else
            //{
            //    return;
            //}



            return;
            
            
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to allocate the new order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                this.matbtnNewAllocate.Visible = false;
                this.matbtnManualAllocation.Visible = false;
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
            foreach (DataGridViewRow row in dgvStoreOrderApproval.Rows)
            {
                if (Convert.ToDouble(row.Cells["DAYSTOEXPIRED"].Value) < Convert.ToDouble(row.Cells["p_nearly_expiry_desc"].Value) && Convert.ToString(row.Cells["is_expirable"].Value) == "1")
                {
                    // row.DefaultCellStyle.BackColor = Color.LightSalmon; // Use it in order to colorize all cells of the row

                    row.Cells["item_code"].Style.BackColor = Color.Crimson;
                    row.Cells["description"].Style.BackColor = Color.Crimson;
                    row.Cells["sub_category"].Style.BackColor = Color.Crimson;
                    row.Cells["ORDERS"].Style.BackColor = Color.Crimson;
                    row.Cells["StockOnHand"].Style.BackColor = Color.Crimson;
                    row.Cells["Allocation_qty"].Style.BackColor = Color.Crimson;
                    row.Cells["DAYSTOEXPIRED"].Style.BackColor = Color.Crimson;





                    row.Cells["item_code"].Style.SelectionBackColor = Color.DarkSlateGray;
                    row.Cells["description"].Style.SelectionBackColor = Color.Crimson;
                    row.Cells["sub_category"].Style.SelectionBackColor = Color.Crimson;
                    row.Cells["ORDERS"].Style.SelectionBackColor = Color.Crimson;
                    row.Cells["StockOnHand"].Style.SelectionBackColor = Color.Crimson;
                    row.Cells["Allocation_qty"].Style.SelectionBackColor = Color.Crimson;
                    row.Cells["DAYSTOEXPIRED"].Style.SelectionBackColor = Color.Crimson;





                    row.Cells["item_code"].Style.SelectionForeColor = Color.White;
                    row.Cells["description"].Style.SelectionForeColor = Color.White;
                    row.Cells["sub_category"].Style.SelectionForeColor = Color.White;
                    row.Cells["ORDERS"].Style.SelectionForeColor = Color.White;
                    row.Cells["StockOnHand"].Style.SelectionForeColor = Color.White;
                    row.Cells["Allocation_qty"].Style.SelectionForeColor = Color.White;
                    row.Cells["DAYSTOEXPIRED"].Style.SelectionForeColor = Color.White;
                }

             

                else
                {

                    row.Cells["item_code"].Style.BackColor = Color.White;
                    row.Cells["description"].Style.BackColor = Color.White;
                    row.Cells["sub_category"].Style.BackColor = Color.White;
                    row.Cells["ORDERS"].Style.BackColor = Color.White;
                    row.Cells["StockOnHand"].Style.BackColor = Color.White;
                    row.Cells["Allocation_qty"].Style.BackColor = Color.White;
                    row.Cells["DAYSTOEXPIRED"].Style.BackColor = Color.White;




                    row.Cells["item_code"].Style.SelectionBackColor = Color.DarkSlateGray;
                    row.Cells["description"].Style.SelectionBackColor = Color.DarkSlateGray;
                    row.Cells["sub_category"].Style.SelectionBackColor = Color.DarkSlateGray;
                    row.Cells["ORDERS"].Style.SelectionBackColor = Color.DarkSlateGray;
                    row.Cells["StockOnHand"].Style.SelectionBackColor = Color.DarkSlateGray;
                    row.Cells["Allocation_qty"].Style.SelectionBackColor = Color.DarkSlateGray;
                    row.Cells["DAYSTOEXPIRED"].Style.SelectionBackColor = Color.DarkSlateGray;


                    row.Cells["item_code"].Style.SelectionForeColor = Color.White;
                    row.Cells["description"].Style.SelectionForeColor = Color.White;
                    row.Cells["sub_category"].Style.SelectionForeColor = Color.White;
                    row.Cells["ORDERS"].Style.SelectionForeColor = Color.White;
                    row.Cells["StockOnHand"].Style.SelectionForeColor = Color.White;
                    row.Cells["Allocation_qty"].Style.SelectionForeColor = Color.White;
                    row.Cells["DAYSTOEXPIRED"].Style.SelectionForeColor = Color.White;
                }
            }
        }

        private void lblqtyAllocatedFinal_TextChanged(object sender, EventArgs e)
        {
    

            double StockOnHand;
            double AllocatedQty;

            StockOnHand = double.Parse(this.txtSoh.Text);
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


            //Ending
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            double StockOnHand;
            double AllocatedQty;

            StockOnHand = double.Parse(this.txtSoh.Text);
            AllocatedQty = double.Parse(this.lblqtyAllocatedFinal.Text);

            MessageBox.Show(StockOnHand.ToString());
            MessageBox.Show(AllocatedQty.ToString());

        }



        private void dgvFindStoreOrders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Pukk 2");
        }

        private void dgvFindStoreOrders_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Pukk 2");
            //this.SumofTotalAllocatedDataGridView();
            ////For Decrementation
            //this.lblvariance.Text = (float.Parse(this.txtSoh.Text.ToString()) - float.Parse(this.lblqtyAllocatedFinal.Text)).ToString();

       

            //if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to allocate the order quantity?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //{

            //    dSet.Clear();
            //    dSet = objStorProc.sp_Allocation_Logs(0,
            //        "",
            //        "",
            //        this.FormClass.Allocated_Quantity.ToString(),
            //        this.FormClass.user_id.ToString(),
            //        "",
            //        this.p_id.ToString(),
            //        0,
            //        0,
            //        "edit");
            //    this.GlobalStatePopup.UpdatedSuccessfully();
            //    this.ConnectionInit();
            //    this.doSearchInTextBox();
            //    //this.textBox2.Text = "Save";
            //    //this.textBox2_TextChanged(sender, e);
            //    //this.Close();
            //}
            //else
            //{
            //    return;
            //}

        }

   

        private void dgvFindStoreOrders_MouseEnter(object sender, EventArgs e)
        {

        }

        private void dgvFindStoreOrders_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Enter");
        }

        private void dgvFindStoreOrders_KeyDown(object sender, KeyEventArgs e)
        {
           if(this.matbtnNewAllocate.Visible == true)
            {
                if (e.KeyData == Keys.Enter)
                {
                    MessageBox.Show("Enter Pusssa");
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to allocate the order quantity?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        this.ConnectionInit();
                        dSet.Clear();
                        dSet = objStorProc.sp_Allocation_Logs(0,
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
                        //this.textBox2.Text = "Save";
                        //this.textBox2_TextChanged(sender, e);
                        //this.Close();
                    }
                    else
                    {
                        return;
                    }
                }

            }


        }

        private void dgvFindStoreOrders_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.SumofTotalAllocatedDataGridView();
            //For Decrementation
            this.lblvariance.Text = (float.Parse(this.txtSoh.Text.ToString()) - float.Parse(this.lblqtyAllocatedFinal.Text)).ToString();

            //if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to allocate the order quantity?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //{

            //    dSet.Clear();
            //    dSet = objStorProc.sp_Allocation_Logs(0,
            //        "",
            //        "",
            //        this.FormClass.Allocated_Quantity.ToString(),
            //        this.FormClass.user_id.ToString(),
            //        "",
            //        this.p_id.ToString(),
            //        0,
            //        0,
            //        "edit");
            //    this.GlobalStatePopup.UpdatedSuccessfully();
            //    this.ConnectionInit();
            //    this.doSearchInTextBox();
            //    //this.textBox2.Text = "Save";
            //    //this.textBox2_TextChanged(sender, e);
            //    //this.Close();
            //}
            //else
            //{
            //    return;
            //}

        }

        ///
    }
}
