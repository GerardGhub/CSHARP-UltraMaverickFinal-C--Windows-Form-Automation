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
            string qty)
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

        //User Binding  Class 

        public int user_id { get; set; }

        private void frmEditConsolidatedOrder_Load(object sender, EventArgs e)
        {
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
            this.mattxtQtyOrder.Text = this.sp_qty;
            //primary key
            this.sp_primary_id = this.sp_primary_id;
            //MessageBox.Show(""+sp_primary_id);
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
                this.FillRequiredTextbox();
                this.mattxtUpdatedQty.Focus();
                return;
            }



            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update the  Information?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                this.ConnectionInit();

                //MessageBox.Show(""+sp_primary_id);
                dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(sp_primary_id,
                sp_primary_id,
                sp_date_ordered,
                sp_fox,
                sp_store_name,
                sp_route,
                sp_area,
                sp_category,
                sp_item_code,
                sp_description,
                sp_uom,
                this.mattxtUpdatedQty.Text,
                "1",
                "",
                 Convert.ToInt32(user_id).ToString(),
                "edit");
                this.UpdatedSuccessfully();
                this.Close();
                }
            else
            {
                return;
            }

        }

        public void UpdatedSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Updated Successfully";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
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
        public void FillRequiredTextbox()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "FILL UP THE REQUIRED FIELDS";
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
            //if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            //{
            //    e.Handled = true;
            //}


            //

        }
    }
}
