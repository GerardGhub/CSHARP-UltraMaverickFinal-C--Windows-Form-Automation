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
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module
{
    public partial class frmManualAllocationController : MaterialForm
    {
       frmAllocationModule ths;
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        DataSet dSet = new DataSet();
        myclasses myClass = new myclasses();
        myclasses xClass = new myclasses();
        DataSet dset2 = new DataSet();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        string mode = "";

        public frmManualAllocationController(frmAllocationModule frm, int store_order_key, 
            float StockOnHand, string Store_Name, int Allocated_Quantity, 
            int Total_Allocated_Qty, string Item_Code, string Item_Description, string Unit_Of_Measure, int Qty_Order_Partial)
        {
            InitializeComponent();
            ths = frm;
            textBox2.TextChanged += new EventHandler(textBox2_TextChanged);
            this.TransactionIdentity = store_order_key;
            this.StockOnHandInventory = StockOnHand;
            this.StoreName = Store_Name;
            this.AllocatedQtyPartial = Allocated_Quantity;
            this.TotalAllocatedQuantity = Total_Allocated_Qty;
            this.ItemCode = Item_Code;
            this.ItemDescription = Item_Description;
            this.UnitOfMeasure = Unit_Of_Measure;
            this.QtyOrderPartial = Qty_Order_Partial;

            this.StoredQtyOrderPartial = Allocated_Quantity;
        }

        private void frmManualAllocationController_Load(object sender, EventArgs e)
        {
            this.WindowLoadState();
            this.ComputationofAvailableQuantityMaster();
            this.SolidBinderofNumber();
        }

        private void SolidBinderofNumber()
        {
            this.matTxtUpdatedBalance.Text = "0";
        }

        private void ComputationofAvailableQuantityMaster()
        {
            double StockOnHand;
            double TotalAllocatedQuantity;
            double BalanceQuantity;



            StockOnHand = double.Parse(this.matTxtStockOnHand.Text);
            TotalAllocatedQuantity = double.Parse(this.matTxtTotalAllocatedQty.Text);
            //BalanceQuantity = double.Parse(this.mattxtBalance.Text);

            BalanceQuantity = StockOnHand - TotalAllocatedQuantity;
            this.mattxtBalance.Text = BalanceQuantity.ToString();
        }

        private void WindowLoadState()
        {
            this.matTransactionID.Text = this.TransactionIdentity.ToString();
            this.matTxtStockOnHand.Text = this.StockOnHandInventory.ToString();
            this.matTxtStoreName.Text = this.StoreName.ToString();
            this.mattxtAllocatedQty.Text = this.AllocatedQtyPartial.ToString();
            this.matTxtTotalAllocatedQty.Text = this.TotalAllocatedQuantity.ToString();
            this.matTxtItemCode.Text = this.ItemCode.ToString();
            this.mattxtItemDesc.Text = this.ItemDescription.ToString();
            this.matTxtUom.Text = this.UnitOfMeasure.ToString();
            this.matTxtQtyOrder.Text = this.QtyOrderPartial.ToString();


            this.StoredQtyOrderPartial = this.StoredQtyOrderPartial;
        }

        public int TransactionIdentity { get; set; }
        public float StockOnHandInventory { get; set; }
        public string StoreName { get; set; }
        public int AllocatedQtyPartial { get; set; }
        public int TotalAllocatedQuantity { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string UnitOfMeasure { get; set; }
        public int QtyOrderPartial { get; set; }

        public int StoredQtyOrderPartial { get; set; }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ths.textBox2.Text = textBox2.Text;
        }

        private void matbtnManualAllocation_Click(object sender, EventArgs e)
        {
            if(this.mattxtAllocatedQty.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.mattxtAllocatedQty.Focus();
                return;
            }

            if (this.matTxtUpdatedBalance.Text.Contains("-"))
            {
                this.GlobalStatePopup.GreaterThanActualRemainingQty();
                this.mattxtBalance.Text = "0";
                this.mattxtAllocatedQty.Text = String.Empty;
                this.mattxtAllocatedQty.Focus();

                return;
            }

            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to allocate the order quantity?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                textBox2_TextChanged(sender, e);
            }
            else
            {
                return;
            }
        
        }

        private void mattxtAllocatedQty_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if(this.mattxtBalance.Text == String.Empty)
                {

                }
                else
                {

                    double PartialQty;
                    double CurrentQty;

                   PartialQty = double.Parse(this.StoredQtyOrderPartial.ToString());
                   CurrentQty = double.Parse(this.mattxtAllocatedQty.Text);

                    if(CurrentQty > PartialQty)
                    {
                        MessageBox.Show("A for Higher");
                        //For crementation
                        this.matTxtUpdatedBalance.Text = (float.Parse(this.StoredQtyOrderPartial.ToString()) - float.Parse(this.mattxtAllocatedQty.Text) + float.Parse(this.mattxtBalance.Text)).ToString();

                        if(this.matTxtUpdatedBalance.Text.Contains("-"))
                        {
                            this.GlobalStatePopup.GreaterThanActualRemainingQty();
                            this.mattxtBalance.Text = "0";
                            this.mattxtAllocatedQty.Text = String.Empty;
                            this.mattxtAllocatedQty.Focus();

                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("B for Lower");
                        //For Decrementation
                        this.matTxtUpdatedBalance.Text = (float.Parse(this.StoredQtyOrderPartial.ToString()) - float.Parse(this.mattxtAllocatedQty.Text)).ToString();

                    }
                    return;
                 

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

            if (this.mattxtAllocatedQty.Text == String.Empty)
            {
                this.matTxtUpdatedBalance.Text = "0";
            }
        }

        private void frmManualAllocationController_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.textBox2.Text = "FormClosing";
        }
    }
}
