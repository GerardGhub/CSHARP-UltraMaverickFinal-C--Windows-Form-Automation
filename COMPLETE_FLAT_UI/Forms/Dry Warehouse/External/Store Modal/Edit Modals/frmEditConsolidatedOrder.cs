using COMPLETE_FLAT_UI.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class frmEditConsolidatedOrder : MaterialForm
    {
        frmStoreOrderforApproval ths;
        DataSet dSet = new DataSet();
        myclasses myClass = new myclasses();
        myclasses xClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        frmNewStoreOrderApproved FormClass = new frmNewStoreOrderApproved();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        public frmEditConsolidatedOrder(frmStoreOrderforApproval frm, 
            int primary_id,
            int order_id, 
            string date_ordered,
            string fox,
            string store_name,
            string route,
            string area,
            string category,
            string item_code,
            string description,
            string uom,
            string qty,
            string StockOnHand,
            string Allocated_Qty,
            string ReservedQuantity,
            int AllocationID)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.sp_primary_id = primary_id;
            this.sp_order_id = order_id;
            this.sp_date_ordered = date_ordered;
            this.sp_fox = fox;
            this.sp_store_name = store_name;
            this.sp_route = route;
            this.sp_area = area;
            this.sp_category = category;
            this.sp_item_code = item_code;
            this.sp_description = description;
            this.sp_uom = uom;
            this.sp_qty = qty;
            this.sp_StockOnHand = StockOnHand;
            this.sp_Allocated_Qty = Allocated_Qty;
            this.SpReservedQuantity = ReservedQuantity;
            this.SpAllocationIDentity = AllocationID;

        }
        //Class Binding to oTher window
        public int sp_primary_id { get; set; }
        public int sp_order_id { get; set; }
        public string sp_date_ordered { get; set; }
        public string sp_fox { get; set; }
        public string sp_store_name { get; set; }
        public string sp_route { get; set; }
        public string sp_area { get; set; }
        public string sp_category { get; set; }
        public string sp_item_code { get; set; }
        public string sp_description { get; set; }
        public string sp_uom { get; set; }
        public string sp_qty { get; set; }
        public string sp_StockOnHand { get; set; }
        public string sp_Allocated_Qty { get; set; }
        public string SpReservedQuantity { get; set; }
     
        public int SpAllocationIDentity { get; set; }
        public int user_id { get; set; }

        private void frmEditConsolidatedOrder_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.BindDataintoTextBox();
            this.mattxtUpdatedQty.Focus();


        }

        private void BindDataintoTextBox()
        {
            //Store Infromation Binding
            this.txtMatStoreCode.Text = this.sp_fox;
            this.mattxtStore.Text = this.sp_store_name;
            this.matxtxRoute.Text = this.sp_route;
            this.mattxtArea.Text = this.sp_area;
            //Item Information Binding
            this.mattxtCategory.Text = this.sp_category;
            this.mattxtItemCode.Text = this.sp_item_code;
            this.matxtDescription.Text = this.sp_description;
            this.mattxtUOm.Text = this.sp_uom;
            //Quantity Adjustment
            if(this.sp_Allocated_Qty == "0")
            {
                this.mattxtQtyOrder.Text = this.sp_qty;
            }
            else
            {
                this.mattxtQtyOrder.Text = this.sp_Allocated_Qty;
            }
 
            //primary key
            this.sp_primary_id = this.sp_primary_id;
            this.sp_StockOnHand = this.sp_StockOnHand;
            this.sp_Allocated_Qty = this.sp_Allocated_Qty;
            this.SpAllocationIDentity = this.SpAllocationIDentity;
            this.matTxtReservedQuantity.Text = SpReservedQuantity;

            this.user_id = userinfo.user_id;
            //MessageBox.Show(""+sp_primary_id);

        

            //MessageBox.Show(displayed_value);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void frmEditConsolidatedOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.textBox1.Text = "GerardFormClosed";
        }

        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
        }

        private void matBtnSave_Click(object sender, EventArgs e)
        {
            if(this.mattxtUpdatedQty.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.mattxtUpdatedQty.Focus();
                return;
            }

            //if (this.sp_Allocated_Qty == this.sp_StockOnHand)
            //{
                double QuantityOrder;
                double UpdatedQuantityOrder;
                //double ReservedQty; 


                QuantityOrder = double.Parse(this.mattxtUpdatedQty.Text);
                UpdatedQuantityOrder = double.Parse(this.mattxtQtyOrder.Text) + double.Parse(this.matTxtReservedQuantity.Text);


           


                    if (UpdatedQuantityOrder > QuantityOrder)
                    {
                         this.OnExecuteUpdate();
                    }
                    else if (UpdatedQuantityOrder == QuantityOrder)
                    {
                         this.OnExecuteUpdate();
                    }
                    else
                    {
                    this.GlobalStatePopup.GreaterThanAllocatedQty();
                    this.mattxtUpdatedQty.Text = String.Empty;
                    this.mattxtUpdatedQty.Focus();

                    return;
                    }
          
     
    

        }

   
        private void OnExecuteUpdate()
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update the  Information?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
                objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class

                if (this.sp_Allocated_Qty == "0")
                {


                    this.dSet.Clear();
                    this.dSet = objStorProc.sp_dry_wh_orders(
                    this.sp_primary_id,
                    this.sp_primary_id,
                    this.sp_date_ordered,
                    this.sp_fox,
                    this.sp_store_name,
                    this.sp_route,
                    this.sp_area,
                    this.sp_category,
                    this.sp_item_code,
                    this.sp_description,
                    this.sp_uom,
                    this.mattxtUpdatedQty.Text,
                    "1",
                    "",
                    Convert.ToInt32(user_id).ToString(),
                    "edit");
                }
                else
                {
                    double qtyvalue = double.Parse(this.mattxtQtyOrder.Text);

                    string displayed_value = qtyvalue.ToString("N0");


                    this.dSet.Clear();
                    this.dSet = objStorProc.sp_Allocation_Logs(
                     this.SpAllocationIDentity,

                    "",
                      displayed_value,
                    this.mattxtUpdatedQty.Text,
                    this.user_id.ToString(),
                    "",
                    this.SpAllocationIDentity.ToString(),
                    0,
                    0,
                    "edit_store_order_qty");
                }

                this.GlobalStatePopup.UpdatedSuccessfully();

                this.Close();


            }
            else
            {
                return;
            }
        }
 


        private void mattxtUpdatedQty_TextChanged(object sender, EventArgs e)
        {
            //get the textbox that fired the event
            var textBox = sender as TextBox;
            if (textBox == null) return;

            var text = textBox.Text;
            var output = new StringBuilder();
            //use this boolean to determine if the dot already exists
            //in the text so far.
            var dotEncountered = false;
            //loop through all of the text
            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                if (char.IsDigit(c))
                {
                    //append any digit.
                    output.Append(c);
                }
                else if (!dotEncountered && c == '.')
                {
                    //append the first dot encountered
                    output.Append(c);
                    dotEncountered = true;
                }

            }
            var newText = output.ToString();
            textBox.Text = newText;
            //set the caret to the end of text
      

        }

        private void mattxtUpdatedQty_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        

        }
    }
}
