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

        public frmServeStorePreparation(frmDryPreparationStore frm,
            string Dry_Order_GUID,
            string Barcode_id,
            string Item_Description,
            string Unit_Of_Measure,
            string Converted_Qty,
            string Preparation_Date,
            string Qty_Served
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
        }

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

        private void frmServeStorePreparation_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class

            myglobal.global_module = "Active"; // Mode for Searching

            this.StaticWindowState();
            this.SearchMethodJarVarCallingSP();
            this.doSearchInTextBoxCmb();


            //Inventory Look Up
            this.SearchMethodJarVarCallingSPReceivingIDInventory();
            this.doSearchInTextBoxCmbRecID();
            //DataGrid Visible False
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
                    if (myglobal.global_module == "EMPLOYEE")
                    {

                    }
                    else if (myglobal.global_module == "Active")
                    {
                        //Gerard Singian Developer Man

                        dv.RowFilter = "id = '" + this.matTxtReceivingbarcodeID.Text + "'   ";

                    }

                    this.gunaDgvReceivedIDInventory.DataSource = dv;
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
            this.matTxtQtyRelease.Text = Sp_Qty_Served;
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
                        //p_id = Convert.ToInt32(dgvStoreOrderApproval.CurrentRow.Cells["primary_id"].Value);
                        this.mattxtItemCode.Text = this.dgvStoreOrderApproval.CurrentRow.Cells["item_code"].Value.ToString();
        
                    }
                }
            }
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
            popup.BodyColor = Color.Crimson;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }

        private void matBtnSave_Click(object sender, EventArgs e)
        {
            if (this.mattxtQtyServe.Text == String.Empty)
            {
                FillRequiredTextbox();
               this.mattxtQtyServe.Focus();
                return;
            }


            double InputQtyServe;

            double ActualRemainingofReceivingID;

           InputQtyServe = double.Parse(this.mattxtQtyServe.Text);
            ActualRemainingofReceivingID = double.Parse(this.matTxtQtyRemaining.Text);
     

            if (InputQtyServe > ActualRemainingofReceivingID)
            {
                //MessageBox.Show("A");
                GreaterThanActualRemainingQty();
                this.mattxtQtyServe.Text = String.Empty;
                this.mattxtQtyServe.Focus();
                return;
            }
            else
            {
                //MessageBox.Show("B");
                //return;
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
                //MessageBox.Show("" + firstEntrySolution);

                if (firstEntrySolution > TextBoxQuantityInputState)
                {
                    //MessageBox.Show("A");
                    //return;
                }
                else if(firstEntrySolution == TextBoxQuantityInputState)
                {
                    //MessageBox.Show("A1");
                    //return;
                }
                else
                {
                    this.GreaterThanAllocatedQty();
                    this.mattxtQtyServe.Text = String.Empty;
                    this.mattxtQtyServe.Focus();
                    //MessageBox.Show("B");
                    return;
                }

            }


            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to serve  the raw material? ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

            }
            else
            {
                return;
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
            "add");


            double ActualQuantityReleased;

            double ActualQuantityServed;

            double ActualQuantityOrder;

            double TotalQuantityServeState;


            ActualQuantityReleased = double.Parse(this.matTxtQtyRelease.Text);
            ActualQuantityServed = double.Parse(this.mattxtQtyServe.Text);
            ActualQuantityOrder = double.Parse(this.matTxtOrderQty.Text);

            TotalQuantityServeState = ActualQuantityReleased + ActualQuantityServed;

            if(ActualQuantityOrder == TotalQuantityServeState)
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
                "", this.Sp_User_ID.ToString(),
                Convert.ToInt32(this.Sp_Material_Id),
                "update_dry_orders");

                if (ActualQuantityReleased == 0)
                {
                    //Bulk Repack Based on Order
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
                    "bulk_produce_store_timestamp");
                }
            }
        

            else
            {
                //Update Start Time Stamp
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
                "start_dry_orders_store_timestamp");
      
            }



            this.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }
        public void GreaterThanAllocatedQty()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Greater than Allocated Qty";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Crimson;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }

        public void GreaterThanActualRemainingQty()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Greater than Actual Remaining Qty";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Crimson;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }


        private void frmServeStorePreparation_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.textBox1.Text = "ItemServe";
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

                    }
                }
            }
        }
    }
}
