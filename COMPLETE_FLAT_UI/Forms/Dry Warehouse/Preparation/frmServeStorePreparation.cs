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
            string Preparation_Date
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
        }

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
                        //this.sp_route = this.dgvStoreOrderApproval.CurrentRow.Cells["route"].Value.ToString();
                        //this.sp_area = this.dgvStoreOrderApproval.CurrentRow.Cells["area"].Value.ToString();
                        //this.sp_approved_preparation_date = this.dgvStoreOrderApproval.CurrentRow.Cells["approved_preparation_date"].Value.ToString();
                        //this.sp_ordered_date = this.dgvStoreOrderApproval.CurrentRow.Cells["date_ordered"].Value.ToString();

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
            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to add a new  raw material ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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


            this.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void frmServeStorePreparation_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.textBox1.Text = "ItemServe";
        }
    }
}
