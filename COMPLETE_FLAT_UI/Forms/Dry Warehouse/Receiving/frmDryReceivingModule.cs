using COMPLETE_FLAT_UI.Models;
using CrystalDecisions.CrystalReports.Engine;
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

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmDryReceivingModule : MaterialForm
    {

        DataSet dSet = new DataSet();
        DataSet dSet_temp = new DataSet();
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        int numExpirableItems = 0;
        string Rpt_Path = "";
        ReportDocument rpt = new ReportDocument();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        public frmDryReceivingModule()
        {
            InitializeComponent();
        }

        public string totalRecords { get; set; }
        public int p_id { get; set; }
        public int MajorCategoryNo { get; set; }
        public string sp_item_code { get; set; }
        public string sp_item_description { get; set; }
        public string sp_added_by { get; set; }
        public string sp_added_by_userid { get; set; }
        public string sp_final_id { get; set; }
        public double sp_receiving_qty { get; set; }
        public string sp_total_remaining_po { get; set; }
        public string sp_warehouse_reject_approval { get; set; }
        public int sp_projection_id { get; set; }
        public int SP_ExpirationSetPoint { get; set; }
        public string SpPoDate { get; set; }
        public string SpPrNo { get; set; }
        public string SpPRDate { get; set; }

        public string SpFK_Sub_Category_SubCategoryDesc { get; set; }
        public int SpFK_Sub_Category_IsExpirable { get; set; }


        private void frmDryReceivingModule_Load(object sender, EventArgs e)
        {
            this.firstLoad();
            this.sp_added_by = userinfo.emp_name.ToString();
            this.sp_added_by_userid = userinfo.user_id.ToString();
            this.mattxtbarcode.Focus();
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            this.mattxtbarcode.Focus();

        }



        private void showLatestID()      
        {
            try
            {
               
                myClass.fillDataGridView(dgvReceivedID, "tblDryWHReceiving_last_id", dSet);
         
  
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }



        private void firstLoad()
        {
            mattxtlotno.BackColor = Color.Red;

            DateTime dNow = DateTime.Now;
            this.crV1.Visible = false;
            this.dgvReceivedID.Visible = false;
            this.mattxtreceivingdate.Text = (dNow.ToString("M/d/yyyy"));
            this.dgvMajorCategory.Visible = false;
            this.materialCard2.Visible = false;
            this.materialCard3.Visible = false;
            this.mattxtReceived.Visible = false;
            this.matbtnCancel.Visible = false;
        }

        private void mattxtbarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.scanBarcode();
            }
        }

    


        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            this.dset_emp_SearchEngines.Clear();
            this.dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("Po_Receiving_Warehouse_CheckingBinding");

        }

        DataSet dset_emp_SearchEnginesNearlyExpiry = new DataSet();
        private void SearchMethodJarVarCallingSPNearlyExpiry()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEnginesNearlyExpiry.Clear();


            dset_emp_SearchEnginesNearlyExpiry = g_objStoredProcCollection.sp_getMajorTables("Po_Receiving_Warehouse_CheckingBinding_NearlyExpiry");

        }


        private void doSearchInTextBoxCmb()
        {
            try
            {


                if (dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEngines.Tables[0]);
                 
                    if (myglobal.global_module == "Active")
                    {


                        //Gerard Singian Developer Man




                        dv.RowFilter = "item_code = '" + mattxtbarcode.Text + "'";

                    }
                 
                    this.dgvMajorCategory.DataSource = dv;
                    totalRecords = dgvMajorCategory.RowCount.ToString();
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

        private void doSearchInTextBoxCmbNearlyExpiry()
        {
            try
            {


                if (dset_emp_SearchEnginesNearlyExpiry.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEnginesNearlyExpiry.Tables[0]);

                    if (myglobal.global_module == "Active")
                    {


                        //Gerard Singian Developer Man




                        dv.RowFilter = "item_code = '" + mattxtbarcode.Text + "'";

                    }

                    this.dgvMajorCategory.DataSource = dv;
                    totalRecords = dgvMajorCategory.RowCount.ToString();
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



        private void scanBarcode()
        {

            //Check the Item Code if exist on the fucking system
            dSet.Clear();
            dSet = g_objStoredProcCollection.sp_Raw_Materials_Dry(0,
                mattxtbarcode.Text,
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                0,
                "",
                "getdetailsforBulkInsertItemCode");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_Raw_Materials_Dry(0,
                    mattxtbarcode.Text,
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    0,
                    "",
                    "getRMforReceivingDryWH");
                if (dSet.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Good");
                    this.SearchMethodJarVarCallingSP();
                    this.doSearchInTextBoxCmb();

                    if(totalRecords == "0")
                    {
                  
                        this.scanBarcodeNearlyExpiry();

                        this.mattxtbarcode.Text = String.Empty;
                        this.mattxtbarcode.Focus();
                    }
                    else
                    {
                        this.mattxtbarcode.Text = String.Empty;
                        this.GlobalStatePopup.ItemDescription = this.mattxtitemdesc.Text;
                       this.GlobalStatePopup.ItemFoundforReceiving();
                        this.materialCard2.Visible = true;
                        this.materialCard3.Visible = true;
                        this.mattxtReceived.Visible = true;
                        this.matbtnCancel.Visible = true;

                        //Remove Some Data
                        this.mattxtqtyReceived.Text = String.Empty;
                        this.mattxtlotno.Text = String.Empty;
                        this.mattxtLotDescription.Text = String.Empty;
                        //mattxtqtyreject.Text = String.Empty;
                        this.mattxtqtyreject_TextChanged(new object(), new System.EventArgs());
                    }
                }
                else
                {
            
                    this.GlobalStatePopup.RMNotExistReceiving();
                    this.mattxtbarcode.Text = String.Empty;
                    this.mattxtbarcode.Focus();
                    return;
                }


                }
            else
            {
                this.GlobalStatePopup.RawMaterialNotExist();
                this.mattxtbarcode.Text = String.Empty;
                this.mattxtbarcode.Focus();
                return;

            }


        }


        private void scanBarcodeNearlyExpiry()
        {

            dSet.Clear();
            dSet = g_objStoredProcCollection.sp_Raw_Materials_Dry(0,
                mattxtbarcode.Text,
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                0,
                "",
                "getdetailsforBulkInsertItemCode");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_Raw_Materials_Dry(0,
                    mattxtbarcode.Text,
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    0,
                    "",
                    "getRMforReceivingDryWH");
                if (dSet.Tables[0].Rows.Count > 0)
                {
                    this.SearchMethodJarVarCallingSPNearlyExpiry();
                    this.doSearchInTextBoxCmbNearlyExpiry();

                    if (totalRecords == "0")
                    {
                        //MessageBox.Show("Buje");
                        //return;
                        this.GlobalStatePopup.RMNotExistReceiving();
                        this.mattxtbarcode.Text = String.Empty;
                        this.mattxtbarcode.Focus();
                    }
                    else
                    {
                        this.mattxtbarcode.Text = String.Empty;
                        this.GlobalStatePopup.ItemDescription = this.mattxtitemdesc.Text;
                        this.GlobalStatePopup.ItemFoundforReceiving();
                        this.materialCard2.Visible = true;
                        this.materialCard3.Visible = true;
                        this.mattxtReceived.Visible = true;
                        this.matbtnCancel.Visible = true;

                        //Remove Some Data
                        this.mattxtqtyReceived.Text = String.Empty;
                        this.mattxtlotno.Text = String.Empty;
                        this.mattxtLotDescription.Text = String.Empty;
                        //mattxtqtyreject.Text = String.Empty;
                        this.mattxtqtyreject_TextChanged(new object(), new System.EventArgs());
                    }
                }
                else
                {

                    this.GlobalStatePopup.RMNotExistReceiving();
                    this.mattxtbarcode.Text = String.Empty;
                    this.mattxtbarcode.Focus();
                    return;
                }


            }
            else
            {
                this.GlobalStatePopup.RawMaterialNotExist();
                this.mattxtbarcode.Text = String.Empty;
                this.mattxtbarcode.Focus();
                return;

            }


        }


        private void dgvMajorCategory_CurrentCellChanged(object sender, EventArgs e)
        {
            this.showValueCell();
            //Nearly Expiry Item Iconic Buto
            this.StateLoadofExpiryItemAcceptanceOnBarcoding();


            //For Non Expirable Itemss
            if(this.matdaysExpiry.Text == "0")
            {
                this.pictureBoxExpiry.Visible = false;
            }
        }

        private void showValueCell()
        {
            if (this.dgvMajorCategory.Rows.Count > 0)
            {
                if (this.dgvMajorCategory.CurrentRow != null)
                {
                    if (this.dgvMajorCategory.CurrentRow.Cells["item_code"].Value != null)
                    {
                        this.p_id = Convert.ToInt32(this.dgvMajorCategory.CurrentRow.Cells["PrimaryID"].Value);
                        this.sp_projection_id = Convert.ToInt32(this.dgvMajorCategory.CurrentRow.Cells["ProjectID"].Value);
                        this.mattxtitemcode.Text = this.dgvMajorCategory.CurrentRow.Cells["item_code"].Value.ToString();
                        this.mattxtitemdesc.Text = this.dgvMajorCategory.CurrentRow.Cells["item_description"].Value.ToString();
                        this.mattxtSupplier.Text = this.dgvMajorCategory.CurrentRow.Cells["Supplier"].Value.ToString();
                        this.mattxtmfgdate.Text = this.dgvMajorCategory.CurrentRow.Cells["mfg_date"].Value.ToString();
                        this.mattxtexpirydate.Text = this.dgvMajorCategory.CurrentRow.Cells["expiration_date"].Value.ToString();
                        this.matdaysExpiry.Text = this.dgvMajorCategory.CurrentRow.Cells["DaysToExpired"].Value.ToString();
                        this.MajorCategoryNo = Convert.ToInt32(this.dgvMajorCategory.CurrentRow.Cells["major_category"].Value);
                        this.mattxtcategory.Text = this.dgvMajorCategory.CurrentRow.Cells["major_category_desc"].Value.ToString();
                        this.mattxtqtyuom.Text = this.dgvMajorCategory.CurrentRow.Cells["qty_uom"].Value.ToString();
                        this.mattxtponumber.Text = this.dgvMajorCategory.CurrentRow.Cells["po_number"].Value.ToString();
                        this.SP_ExpirationSetPoint = Convert.ToInt32(this.dgvMajorCategory.CurrentRow.Cells["EXPIRATIONSETPOINT"].Value);
                        this.SpPoDate = this.dgvMajorCategory.CurrentRow.Cells["po_date"].Value.ToString();
                        this.SpPRDate = this.dgvMajorCategory.CurrentRow.Cells["pr_date"].Value.ToString();
                        this.SpPrNo = this.dgvMajorCategory.CurrentRow.Cells["pr_number"].Value.ToString();
                        this.matbtnSubCategory.Text = this.dgvMajorCategory.CurrentRow.Cells["sub_category"].Value.ToString();
                        this.SpFK_Sub_Category_IsExpirable = Convert.ToInt32(this.dgvMajorCategory.CurrentRow.Cells["is_expirable"].Value);

                        this.mattxtqtyreject.Text = this.dgvMajorCategory.CurrentRow.Cells["totalreject"].Value.ToString();
                        if (this.totalRecords == "1")
                        {
                            this.mattxtsoh.Text = this.dgvMajorCategory.CurrentRow.Cells["total_received"].Value.ToString();

                            
                        }
                        else
                        {
                            //int sum = 0;
                            //for (int i = 0; i < this.dgvMajorCategory.Rows.Count; ++i)
                            //{
                            //    sum += Convert.ToInt32(this.dgvMajorCategory.Rows[i].Cells["total_received"].Value);
                            //}
                            //this.mattxtsoh.Text = sum.ToString();
                        
                                int sum2 = 0;
                                for (int i = 0; i < this.dgvMajorCategory.Rows.Count; ++i)
                                {
                                    sum2 += Convert.ToInt32(this.dgvMajorCategory.Rows[i].Cells["TOTALRECEIVEDFINAL"].Value);
                                }
                                this.mattxtsoh.Text = sum2.ToString();
                            
                        }
                        this.sp_total_remaining_po = dgvMajorCategory.CurrentRow.Cells["totalremainingpo"].Value.ToString();
                        this.sp_warehouse_reject_approval = dgvMajorCategory.CurrentRow.Cells["WH_Reject_Approval"].Value.ToString();

                        if (this.sp_warehouse_reject_approval == "1")                
                        {
                            this.mattxtactualdelivery.Text = this.dgvMajorCategory.CurrentRow.Cells["WH_Reject_QTY"].Value.ToString();
                            //this.mattxtqtyreject.Text = "0";

                        }
                        else
                        {
                            //MessageBox.Show("0");
                            this.mattxtactualdelivery.Text = this.dgvMajorCategory.CurrentRow.Cells["actual_delivery"].Value.ToString();


                        }
                        if(this.matdaysExpiry.Text == String.Empty)
                        {
                            this.matdaysExpiry.Text = "0";              
                        }



                        //MessageBox.Show(p_id.ToString());
                        //DateTime temp;
                        //temp = Convert.ToDateTime(this.mattxtexpirydate.Text);
                        //this.mattxtexpirydate.Text = temp.ToString("dd/MM/yyyy"); // or "MM/dd/yyyy"
                    }
                }
            }
        }

        private void mattxtqtyReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(mattxtqtyReceived.Text + ch, out x))
            {
                e.Handled = true;
            }



        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectLot_Click(object sender, EventArgs e)
        {
            frmChooseLotNumber showModal = new frmChooseLotNumber(this, this.matbtnSubCategory.Text);
            showModal.ShowDialog();


   
        }

        private void mattxtqtyReceived_TextChanged(object sender, EventArgs e)
        {
            //Removing an Entry 
            try
            {


              mattxtupdatedstocks.Text = (float.Parse(mattxtsoh.Text) + float.Parse(mattxtqtyReceived.Text)).ToString();
            }
            catch (Exception)
            {


            }

            if (mattxtqtyReceived.Text == String.Empty)
            {
                try
                {


                    mattxtupdatedstocks.Text = String.Empty;
                }
                catch (Exception)
                {


                }
            }
          
        }

        private void mattxtactualdelivery_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
   

        private void mattxtReceived_Click(object sender, EventArgs e)
        {

        }





  
        private void StateLoadofExpiryItemAcceptance()
        {
            if (this.SP_ExpirationSetPoint < Convert.ToInt32(this.matdaysExpiry.Text))
            {
                //MessageBox.Show("Inside!");
                numExpirableItems = 0;
         

            }
            else
            {
                numExpirableItems = 1;
             

                //MessageBox.Show("Outside" + this.SP_ExpirationSetPoint);
            }
        }


        private void mattxtReceived_Click_1(object sender, EventArgs e)
        {

            if (this.mattxtqtyReceived.Text.Trim() == string.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
      
                return;
            }

            if(this.mattxtqtyReceived.Text == "0")
            {
                this.GlobalStatePopup.InvalidQuantity();

                return;
            }

            double orderActual;
            double currentrejectActual;
            double rejecttotal;


            orderActual = double.Parse(this.mattxtactualdelivery.Text);
            currentrejectActual = double.Parse(this.mattxtqtyReceived.Text);
            rejecttotal = double.Parse(this.mattxtqtyreject.Text);

            if (orderActual < currentrejectActual)
            {
                // code

                this.GlobalStatePopup.LessThanQtyReceived();
                this.mattxtqtyReceived.Text = String.Empty;
                this.mattxtqtyReceived.Focus();
                return;
            }
            else
            {
                //MessageBox.Show("Bebes");
                //return;
            }


            if (this.mattxtlotno.Text.Trim() == string.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                frmChooseLotNumber LotSelection = new frmChooseLotNumber(this, this.mattxtcategory.Text);
                LotSelection.ShowDialog();
                return;
            }
            if (this.mattxtLotDescription.Text.Trim() == string.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                frmChooseLotNumber LotSelection = new frmChooseLotNumber(this, this.mattxtcategory.Text);
                LotSelection.ShowDialog();
                return;
            }


       

            double order;
            double currentreject;
       

            order = double.Parse(this.mattxtactualdelivery.Text);
            currentreject = double.Parse(this.mattxtqtyreject.Text);
     

            if (order < currentreject)
            {
                // code
  
                this.GlobalStatePopup.LessThanQtyReceived();
                this.btnAddRejetModal_Click(sender, e);
                return;
            }
            else
            {
                //MessageBox.Show("Bebes");
                //return;
            }

            //proceess of repack kupra
            if (currentreject == 0)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to received?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    this.SummaryComputation(); //Inject 11/25/2021

               

                    //Second Summary of Queryy Disposal of Rejection Remarks
                    this.dSet.Clear();
                    this.dSet = g_objStoredProcCollection.sp_tblDryWHReceiving(0,
                        p_id,
                        this.mattxtitemcode.Text,
                        this.mattxtitemdesc.Text,
                        this.sp_receiving_qty.ToString(), "",
                        this.sp_added_by,
                        this.sp_added_by, "",
                        this.mattxtSupplier.Text,
                        this.mattxtlotno.Text,
                        this.mattxtLotDescription.Text,
                        this.mattxtmfgdate.Text,
                        this.mattxtexpirydate.Text,
                        this.mattxtcategory.Text,
                        this.mattxtqtyuom.Text,
                        this.mattxtqtyreject.Text, 
                        Convert.ToInt32(this.mattxtponumber.Text), 
                        Convert.ToInt32(sp_added_by_userid),
                        this.numExpirableItems.ToString(), 
                        this.SpPoDate,
                        this.SpPrNo,
                        this.SpPRDate,
                        this.matbtnSubCategory.Text.Trim(),
                        this.SpFK_Sub_Category_IsExpirable, "","",
                        "rejected_status_timer_dispossal");

                    //Second Summary of Queryy Disposal of Rejection Remarks RE == QA  ON NA 3/4/2022
                    this.dSet.Clear();
                    this.dSet = g_objStoredProcCollection.sp_tblDryWHReceiving(0,
                        p_id,
                        this.mattxtitemcode.Text,
                        this.mattxtitemdesc.Text,
                        this.sp_receiving_qty.ToString(), "",
                        this.sp_added_by,
                        this.sp_added_by, "",
                        this.mattxtSupplier.Text,
                        this.mattxtlotno.Text,
                        this.mattxtLotDescription.Text,
                        this.mattxtmfgdate.Text,
                        this.mattxtexpirydate.Text,
                        this.mattxtcategory.Text,
                        this.mattxtqtyuom.Text,
                        this.mattxtqtyreject.Text,
                        Convert.ToInt32(this.mattxtponumber.Text),
                        Convert.ToInt32(sp_added_by_userid), 
                        numExpirableItems.ToString(),
                        this.SpPoDate,
                        this.SpPrNo,
                        this.SpPRDate,
                        this.matbtnSubCategory.Text.Trim(),
                        this.SpFK_Sub_Category_IsExpirable,"", "",
                        "rejected_status_wh_re_qa");




                    //Computation Master Data

                    this.StateLoadofExpiryItemAcceptance();

                    //Commit the Data on The Database Stored procedure

                    this.dSet.Clear();
                    this.dSet = g_objStoredProcCollection.sp_tblDryWHReceiving(0,
                        p_id, mattxtitemcode.Text, 
                        this.mattxtitemdesc.Text, 
                        this.sp_receiving_qty.ToString(), "", 
                        this.sp_added_by, sp_added_by, "", 
                        this.mattxtSupplier.Text,
                        this.mattxtlotno.Text, 
                        this.mattxtLotDescription.Text, 
                        this.mattxtmfgdate.Text, mattxtexpirydate.Text, 
                        this.MajorCategoryNo.ToString(),
                        mattxtqtyuom.Text, 
                        this.mattxtqtyreject.Text, Convert.ToInt32(mattxtponumber.Text), 
                        Convert.ToInt32(sp_added_by_userid), 
                        this.numExpirableItems.ToString(),
                        this.SpPoDate, 
                        this.SpPrNo, 
                        this.SpPRDate,
                        this.matbtnSubCategory.Text.Trim(),
                        this.SpFK_Sub_Category_IsExpirable,
                        "",
                        "",
                        "add");
                    if (this.sp_warehouse_reject_approval =="1")
                    {

                  
                    this.dSet.Clear();
                    this.dSet = g_objStoredProcCollection.sp_tblDryWHReceiving(0,
                    p_id, mattxtitemcode.Text, 
                    this.mattxtitemdesc.Text,
                    this.sp_receiving_qty.ToString(), "",
                    this.sp_added_by, sp_added_by, "", 
                    this.mattxtSupplier.Text,
                    this.mattxtlotno.Text, 
                    this.mattxtLotDescription.Text, 
                    this.mattxtmfgdate.Text,
                    this.mattxtexpirydate.Text,
                    this.mattxtcategory.Text,
                    this.mattxtqtyuom.Text,
                    this.mattxtqtyreject.Text, 
                    Convert.ToInt32(mattxtponumber.Text), 
                    Convert.ToInt32(sp_added_by_userid),
                    this.numExpirableItems.ToString(),
                    this.SpPoDate,
                    this.SpPrNo,
                    this.SpPRDate,
                    this.matbtnSubCategory.Text.Trim(),
                    this.SpFK_Sub_Category_IsExpirable, "", "",
                    "updated_rejected_partial");

                        //Second Summary of Queryy Disposal of Rejection Remarks
                        this.dSet.Clear();
                        this.dSet = g_objStoredProcCollection.sp_tblDryWHReceiving(0,
                            p_id,
                            this.mattxtitemcode.Text,
                            this.mattxtitemdesc.Text,
                            this.sp_receiving_qty.ToString(), "",
                            this.sp_added_by,
                            this.sp_added_by, "",
                            this.mattxtSupplier.Text,
                            this.mattxtlotno.Text,
                            this.mattxtLotDescription.Text,
                            this.mattxtmfgdate.Text,
                            this.mattxtexpirydate.Text,
                            this.mattxtcategory.Text,
                            this.mattxtqtyuom.Text,
                            this.mattxtqtyreject.Text, 
                            Convert.ToInt32(this.mattxtponumber.Text), 
                            Convert.ToInt32(sp_added_by_userid),
                            this.numExpirableItems.ToString(),
                            this.SpPoDate,
                            this.SpPrNo,
                            this.SpPRDate,
                            this.matbtnSubCategory.Text.Trim(),
                            this.SpFK_Sub_Category_IsExpirable,"","",

                            "rejected_status_timer_dispossal");
                    }

                    this.GlobalStatePopup.SuccessfullyReceived();
                    this.showLatestID();
                    //this.SummaryComputation();

                    this.PrintingProcess();
                    this.frmDryReceivingModule_Load(sender, e);
                }
                else
                {
                    return;
                }
            }
            else 
            {
        
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure " +
                    "you want to received the Qty?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {




                    this.SummaryComputation();
           

                    //Second Summary of Queryy Disposal of Rejection Remarks
                    this.dSet.Clear();
                    this.dSet = g_objStoredProcCollection.sp_tblDryWHReceiving(0,
                        p_id,
                        this.mattxtitemcode.Text,
                        this.mattxtitemdesc.Text,
                        this.sp_receiving_qty.ToString(), "",
                        this.sp_added_by,
                        this.sp_added_by, "", 
                        this.mattxtSupplier.Text,
                        this.mattxtlotno.Text,
                        this.mattxtLotDescription.Text, 
                        this.mattxtmfgdate.Text, 
                        this.mattxtexpirydate.Text, 
                        this.mattxtcategory.Text, 
                        this.mattxtqtyuom.Text, 
                        this.mattxtqtyreject.Text, 
                        Convert.ToInt32(this.mattxtponumber.Text), 
                        Convert.ToInt32(sp_added_by_userid),
                        this.numExpirableItems.ToString(),
                        this.SpPoDate,
                        this.SpPrNo,
                        this.SpPRDate,
                        this.matbtnSubCategory.Text.Trim(),
                        this.SpFK_Sub_Category_IsExpirable,"","",
                        "rejected_status_timer_dispossal");



                    //Second Summary of Queryy Disposal of Rejection Remarks RE == QA
                    this.dSet.Clear();
                    this.dSet = g_objStoredProcCollection.sp_tblDryWHReceiving(0,
                        p_id,
                        this.mattxtitemcode.Text, 
                        this.mattxtitemdesc.Text, 
                        this.sp_receiving_qty.ToString(), "", 
                        this.sp_added_by, 
                        this.sp_added_by, "", 
                        this.mattxtSupplier.Text,
                        this.mattxtlotno.Text, 
                        this.mattxtLotDescription.Text, 
                        this.mattxtmfgdate.Text, 
                        this.mattxtexpirydate.Text, 
                        this.mattxtcategory.Text, 
                        this.mattxtqtyuom.Text, 
                        this.mattxtqtyreject.Text, 
                        Convert.ToInt32(this.mattxtponumber.Text), 
                        Convert.ToInt32(sp_added_by_userid),
                        this.numExpirableItems.ToString(),
                        this.SpPoDate,
                        this.SpPrNo,
                        this.SpPRDate,
                        this.matbtnSubCategory.Text.Trim(),
                        this.SpFK_Sub_Category_IsExpirable,"","",
                        "rejected_status_wh_re_qa'");

                    //Conversion Master Details
                    this.StateLoadofExpiryItemAcceptance();



                    //Commit Data on The Database Stored Procedure
                    this.dSet.Clear();
                    this.dSet = g_objStoredProcCollection.sp_tblDryWHReceiving(0,
                        p_id,
                        this.mattxtitemcode.Text,
                        this.mattxtitemdesc.Text,
                        this.sp_receiving_qty.ToString(), "",
                        this.sp_added_by,
                        this.sp_added_by, "",
                        this.mattxtSupplier.Text,
                        this.mattxtlotno.Text,
                        this.mattxtLotDescription.Text, 
                        this.mattxtmfgdate.Text, 
                        this.mattxtexpirydate.Text, 
                        this.mattxtcategory.Text, 
                        this.mattxtqtyuom.Text, 
                        this.mattxtqtyreject.Text, 
                        Convert.ToInt32(mattxtponumber.Text), 
                        Convert.ToInt32(sp_added_by_userid),
                        this.numExpirableItems.ToString(),
                        this.SpPoDate,
                        this.SpPrNo,
                        this.SpPRDate,
                        this.matbtnSubCategory.Text.Trim(),
                        this.SpFK_Sub_Category_IsExpirable,"","",
                        "add");

                    if (this.sp_warehouse_reject_approval == "1")
                    {


                        this.dSet.Clear();
                        this.dSet = g_objStoredProcCollection.sp_tblDryWHReceiving(0,
                            p_id,
                            this.mattxtitemcode.Text,
                            this.mattxtitemdesc.Text,
                            this.sp_receiving_qty.ToString(), "",
                            this.sp_added_by,
                            this.sp_added_by, "",
                            this.mattxtSupplier.Text,
                            this.mattxtlotno.Text,
                            this.mattxtLotDescription.Text,
                            this.mattxtmfgdate.Text,
                            this.mattxtexpirydate.Text,
                            this.mattxtcategory.Text,
                            this.mattxtqtyuom.Text,
                            this.mattxtqtyreject.Text, 
                            Convert.ToInt32(this.mattxtponumber.Text), 
                            Convert.ToInt32(sp_added_by_userid), 
                            numExpirableItems.ToString(),
                            this.SpPoDate,
                            this.SpPrNo,
                            this.SpPoDate,
                            this.matbtnSubCategory.Text.Trim(),
                            this.SpFK_Sub_Category_IsExpirable,"","",
                            "updated_rejected_partial");



                    }




                    this.GlobalStatePopup.SuccessfullyReceived();
                    this.showLatestID();
                    //this.SummaryComputation();

                    this.PrintingProcess();

                    //Update Projects Partial PO Actual Remaining

                    double qtytotalPo;
                    double QtyReject;
                    double qtyReturnSummary;
               

                    qtytotalPo = double.Parse(sp_total_remaining_po);
                    QtyReject = double.Parse(mattxtqtyreject.Text);

                    qtyReturnSummary = qtytotalPo + QtyReject;

                    this.dSet.Clear();
                    this.dSet = g_objStoredProcCollection.sp_tblDryWHReceiving(0,
                        p_id,
                        this.mattxtitemcode.Text,
                        this.mattxtitemdesc.Text,
                        qtyReturnSummary.ToString(), "",
                        this.sp_added_by, sp_added_by, "",
                        this.mattxtSupplier.Text,
                        this.mattxtlotno.Text,
                        this.mattxtLotDescription.Text,
                        this.mattxtmfgdate.Text,
                        this.mattxtexpirydate.Text,
                        this.mattxtcategory.Text,
                        this.mattxtqtyuom.Text, 
                        this.mattxtqtyreject.Text, 
                        Convert.ToInt32(mattxtponumber.Text), 
                        Convert.ToInt32(sp_added_by_userid),
                        this.numExpirableItems.ToString(),
                        this.SpPoDate,
                        this.SpPrNo,
                        this.SpPRDate,
                           this.matbtnSubCategory.Text.Trim(),
                        this.SpFK_Sub_Category_IsExpirable,"","",
                        "rejectComeback");
                    this.frmDryReceivingModule_Load(sender, e);
                }
                else
                {
                    return;
                }
            }
      

        }



        private void SummaryComputation()
        {
            //sp_final_id = (float.Parse(sp_final_id) + 1).ToString();
            double qtyReceiving;
            double rejected;


            qtyReceiving = double.Parse(mattxtactualdelivery.Text);
            rejected = double.Parse(mattxtqtyreject.Text);


            sp_receiving_qty = qtyReceiving - rejected;
        }
        private void PrintingProcess()
        {
            Rpt_Path = ULTRAMAVERICK.Properties.Settings.Default.fdg;



            PrintDialog printDialog = new PrintDialog();
            rpt.Load(Rpt_Path + "\\DryReceivingBarcode.rpt");

            //rpt.SetDatabaseLogon("sa", "ULtR@MaVD3p0t2o22");

            rpt.Refresh();
            myglobal.DATE_REPORT2 = sp_final_id;

            rpt.SetParameterValue("@mystringid", sp_final_id);



            crV1.ReportSource = rpt;
            crV1.Refresh();



            rpt.PrintOptions.PrinterName = printDialog.PrinterSettings.PrinterName;


            rpt.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate, printDialog.PrinterSettings.ToPage, printDialog.PrinterSettings.ToPage);

        }
  

        private void btnAddRejetModal_Click(object sender, EventArgs e)
        {

            //Notify the User if the Transactioin already approve by QC Superviosr
            if (this.sp_warehouse_reject_approval == "1")
            {
                this.GlobalStatePopup.QCReceiverAlreadyApproved();
            }
           
                frmAddNewPartialRejectReceiving showModal = new frmAddNewPartialRejectReceiving(this, mattxtitemdesc.Text, mattxtactualdelivery.Text, p_id, Convert.ToInt32(mattxtponumber.Text), sp_projection_id);
                showModal.ShowDialog();
        }

        private void dgvReceivedID_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvReceivedID.Rows.Count > 0)
            {
                if (dgvReceivedID.CurrentRow != null)
                {
                    if (dgvReceivedID.CurrentRow.Cells["id"].Value != null)
                    {

                        this.sp_final_id = dgvReceivedID.CurrentRow.Cells["id"].Value.ToString();

                    }
                }
            }
        }

        private void mattxtqtyreject_TextChanged(object sender, EventArgs e)
        {
            try
            {


                this.mattxtupdatedstocks.Text = (float.Parse(mattxtsoh.Text) + float.Parse(mattxtqtyReceived.Text)).ToString();
            }
            catch (Exception)
            {


            }
            try
            {


                this.mattxtqtyReceived.Text = (float.Parse(mattxtactualdelivery.Text) - float.Parse(mattxtqtyreject.Text)).ToString();
            }
            catch (Exception)
            {


            }


            if (mattxtqtyReceived.Text == String.Empty)
            {
                try
                {


                    this.mattxtupdatedstocks.Text = String.Empty;
                }
                catch (Exception)
                {


                }
            }




        }





        private void StateLoadofExpiryItemAcceptanceOnBarcoding()
        {
            if (this.SP_ExpirationSetPoint < Convert.ToInt32(this.matdaysExpiry.Text))
            {


                this.pictureBoxExpiry.Visible = false;
      

            }
            else
            {

                this.pictureBoxExpiry.Visible = true;

            }
        }




        private void matbtnCancel_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.frmDryReceivingModule_Load(sender, e);
            }
            else
            {
                return;
            }


            }
    }
}
