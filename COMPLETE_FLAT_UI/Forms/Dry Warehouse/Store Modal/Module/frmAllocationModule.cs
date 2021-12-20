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

        int p_id = 0;

        DateTime dNow = DateTime.Now;
        //Boolean ready = false;


        DataSet dSet_temp = new DataSet();
        public frmAllocationModule()
        {
            InitializeComponent();
        }

        public string sp_item_code { get; set; }
        public string sp_item_description { get; set; }
        public string sp_qty_finder { get; set; }
        public double MemoryLogsQty { get; set; }

        public int user_id { get; set; }

        private void frmAllocationModule_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.showRawMaterialsInDryWH();

            this.MemoryLogsQty = 0;
            this.CallInitializeComponent();
        }

        private void CallInitializeComponent()
        {
            this.user_id = userinfo.user_id;
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
            //this.dgvRawMats.Columns["item_id"].Visible = false;

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
            //this.SumofTotalSOHDataGridView();
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

        private void SumofTotalSOHDataGridView()
        {
            int sum = 0;
            for (int i = 0; i < dgvFindStoreOrders.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvFindStoreOrders.Rows[i].Cells["SOH"].Value);
            }
            this.txtSoh.Text = sum.ToString();
        }


        private void ErrorNotify()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Allocation Interupt Check the data to proceed";
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
        private void matBtnSave_Click(object sender, EventArgs e)
        {

            //double CurrentComputationMemory;



            //    CurrentComputationMemory = double.Parse(this.lblAllocatedQty.Text);


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
                        this.ErrorNotify();
                    }
                    else
                    {


                        this.dgvFindStoreOrders.CurrentCell = this.dgvFindStoreOrders.Rows[0].Cells[this.dgvFindStoreOrders.CurrentCell.ColumnIndex];
         
                    }

                    MessageBox.Show("SuccessFully Insert");
                    txtItemCode_TextChanged(sender, e);
                    this.dgvFindStoreOrders.CurrentCell = this.dgvFindStoreOrders.Rows[0].Cells[this.dgvFindStoreOrders.CurrentCell.ColumnIndex];
                    return;
                }
            }
            ///Ending
            ///
        
        }
        private void InsertDataPerRow()
        {
            dSet.Clear();
            dSet = objStorProc.sp_Allocation_Logs(0,
                this.txtItemCode.Text.Trim(), this.txtitemDescription.Text.Trim(), this.lblAllocatedQty.Text.Trim(), this.user_id.ToString(), "", p_id.ToString(),"add");
        }



        private void ComputationofAllocationQuantity()
        {

            double orderActual;
            double totalOrderQuantity;
            double totalPercentage;
            double StockOnHandQty;

 
            orderActual = double.Parse(this.sp_qty_finder);
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

                      this.sp_qty_finder = this.dgvFindStoreOrders.CurrentRow.Cells["qty"].Value.ToString();
       
                    }
                }
            }
        }

    }
}
