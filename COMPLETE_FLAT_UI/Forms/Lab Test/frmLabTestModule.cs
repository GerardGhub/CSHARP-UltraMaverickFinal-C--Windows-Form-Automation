using COMPLETE_FLAT_UI.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Wizard.Helpers;

namespace ULTRAMAVERICK.Forms.Lab_Test
{
    public partial class frmLabTestModule : MaterialForm
    {

  
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();

        public Byte[] imageByte = null;
        int p_id = 0;

        DateTime dNow = DateTime.Now;

        DataSet dSet_temp = new DataSet();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        public frmLabTestModule()
        {
            InitializeComponent();
        }

        public string SpQAApprovalDate { get; set; }
        public int SpUseridentity { get; set; }
        public string SpFirstName { get; set; }
        public string SpItemDescription { get; set; }
        public string SpLabResultReleasedDate { get; set; }
        public string SpTransactionType { get; set; }
        public string SpQuantity { get; set; }
        public string SpRemainingQuantity { get; set; }
        public string SpMftgDate { get; set; }
        public string SpExpiryDate { get; set; }
        public string SpLotNumber { get; set; }
        public string SpItemImage { get; set; }
        public string SpDateOfLastUsed { get; set; }
        public string SpExpiryDays { get; set; }
        public string SpRMDateLastUsedPreparation { get; set; }
        public string SpRemarks { get; set; }
        public string SpLabStatus { get; set; }
        public string SplblLabRequestDate { get; set; }
        public string SpHistorical { get; set; }
        public string SpAging { get; set; }
        public string FkReceivingID { get; set; }
        public string SpQAApprovalStatus { get; set; }
        public string SpLabResultRemarks { get; set; }
        public string ExtendedShelfLife { get; set; }
        public string SpDepartment { get; set; }
        public string SpQAApprovalBy { get; set; }
        public string SpLabResultReleasedBy { get; set; }
        public string SpLabSubRemarks { get; set; }
        public string SpLaboratoryProcedure { get; set; }
        public string SpLabAccessCode { get; set; }
        public string SpLabRequestBy { get; set; }

        public bool Sp_Tsqa_Approval_Status { get; set; }
        public int SpPoNumber { get; set; }
        public int SpPrNumber { get; set; }
        public string SpPoDate { get; set; }
        public string SpPrDate { get; set; }
        public string SpLabCancelledRemarks { get; set; }
        public bool SpQASupervisorApprovalStatus { get; set; }
        public int Year { get; }
        public string monthName { get; set; }
        public string SpTotalLabtestRecords { get; set; }
        public string SpTotalLabtestRecordsCount { get; set; }

        private void frmLabTestModule_Load(object sender, EventArgs e)
        {
            this.ConnectionInitialization();
            this.showRawMaterialsNearlyExpiry();
            this.WindowLoadState();


     

        }


        private void AutoGeneratingLabAccessCode()
        {
            return;
            DateTime myDateTime = DateTime.Now;
            string year = myDateTime.Year.ToString();

            string sMonth = DateTime.Now.ToString("MM");


            int monthNumber = Convert.ToInt32(sMonth); //1-12  
            if (sMonth == "01")
            {
                monthName = "A";
            }
            else if (sMonth == "02")
            {
                monthName = "B";
            }
            else if (sMonth == "03")
            {
                monthName = "C";
            }
            else if (sMonth == "04")
            {
                monthName = "D";
            }
            else if (sMonth == "05")
            {
                monthName = "E";
            }
            else if (sMonth == "06")
            {
                monthName = "F";
            }
            else if (sMonth == "07")
            {
                monthName = "G";
            }
            else if (sMonth == "08")
            {
                monthName = "H";
            }
            else if (sMonth == "09")
            {
                monthName = "I";
            }
            else if (sMonth == "10")
            {
                monthName = "J";
            }
            else if (sMonth == "11")
            {
                monthName = "K";
            }
            else if (sMonth == "12")
            {
                monthName = "L";
            }


            //string monthName = new DateTimeFormatInfo().GetMonthName(monthNumber);
            if(this.txtLabAccessCode.Text == String.Empty)
            {
                if (this.matViewLabRecords.Visible == true)
                {
                    this.txtLabAccessCode.Text = year.ToString() + "-" + monthName + "-" + SpTotalLabtestRecordsCount;

                }

            }


            //txtLabAccessCode.Text = String.Empty;

        }

        private void AlphaVeticalSequence()
        {

        }

        
        private void loadImage()
        {
            //sp_user_id = primary_key;

            //dsImage = g_objStoredProcCollection.sp_employee_new(sp_user_id, "", "getImage");
            //              imageByte = (Byte[])(dsImage.Tables[0].Rows[0]["image_employee"]);
            try
            {

                //imageByte = System.Text.Encoding.UTF8.GetBytes(SpItemImage);
                if (imageByte.Length == 0)
                {
                    loadDefaultImage();
                }
                else
                {
                    try
                    {

                        pbImage.Image = Image.FromStream(new MemoryStream(imageByte));

                    }
                    catch (Exception exception)
                    {
                        this.Show();
                        MessageBox.Show(exception.Message);
                        loadDefaultImage();
                        //MessageBox.Show("Error  :  Image of" + txtname.Text + "  Failed To Load. \n\n" + exception.Message, "HR Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception) { loadDefaultImage(); }
        }


        private void loadDefaultImage()
        {
            try
            {
       
                pbImage.Image = null;
                pbImage.Refresh();
                pbImage.BackgroundImage = new Bitmap(Properties.Resources.Buddy);
                // Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\Resources\Buddy.png");
                imageByte = new byte[Convert.ToInt32(null)];
             
            }
            catch (Exception)
            {

            }
        }


        private void WindowLoadState()
        {
            if (this.lbltotalrecords.Text != "0")
            {
                this.SearchMethodJarVarCallingSP();

            }
            else
            {
                this.MatBtnReceived.Visible = false;
                this.matBtnViewLabRecords.Visible = false;
                this.matViewLabRecords.Visible = false;
                this.btnCancelLabRequest.Visible = false;
            }
            this.SpUseridentity = userinfo.user_id;
            this.SpFirstName = userinfo.emp_name + userinfo.emp_lastname;
            this.SpDepartment = userinfo.department;
        }

        private void ConnectionInitialization()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
    
        }


        private void showRawMaterialsNearlyExpiry()   
        {
            try
            {

                myClass.fillDataGridView(this.dgvRawMats, "DryWarehouseNearlyExpiryLabTestViewing", dSet);

                this.lbltotalrecords.Text = this.dgvRawMats.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            this.DataGridVisibilityFalse();
        }



        private void DataGridVisibilityFalse()
        {
            this.dgvRawMats.Columns["mfg_date"].Visible = false;
            this.dgvRawMats.Columns["date_added"].Visible = false;
            this.dgvRawMats.Columns["exp_date"].Visible = false;
            this.dgvRawMats.Columns["lot_description"].Visible = false;
            this.dgvRawMats.Columns["STANDARDEXPIRYDAYS"].Visible = false;
            this.dgvRawMats.Columns["lot_no"].Visible = false;
            this.dgvRawMats.Columns["lab_request_date"].Visible = false;
            this.dgvRawMats.Columns["qty_received"].Visible = false;
            this.dgvRawMats.Columns["qa_approval_status"].Visible = false;
            this.dgvRawMats.Columns["qa_approval_date"].Visible = false;
            this.dgvRawMats.Columns["lab_result_released_date"].Visible = false;
            this.dgvRawMats.Columns["transaction_type"].Visible = false;
            this.dgvRawMats.Columns["RM_ITEM_LAST_USED"].Visible = false;
            this.dgvRawMats.Columns["qa_approval_by"].Visible = false;
            this.dgvRawMats.Columns["lab_result_released_by"].Visible = false;
            this.dgvRawMats.Columns["lab_access_code"].Visible = false;
            this.dgvRawMats.Columns["lab_request_by"].Visible = false;
            this.dgvRawMats.Columns["po_date"].Visible = false;
            this.dgvRawMats.Columns["po_number"].Visible = false;
            this.dgvRawMats.Columns["pr_date"].Visible = false;
            this.dgvRawMats.Columns["pr_no"].Visible = false;
            this.dgvRawMats.Columns["lab_cancel_remarks"].Visible = false;
            this.dgvRawMats.Columns["qa_supervisor_is_approve_status"].Visible = false;
            this.dgvRawMats.Columns["TotalLabtestRecords"].Visible = false;
            this.dgvRawMats.Columns["TotalLabtestRecordsCount"].Visible = false;
            this.dgvRawMats.Columns["expiration_prompting"].Visible = false;
            this.dgvRawMats.Columns["sample_qty"].Visible = false;

            this.dgvRawMats.Columns["tsqa_approval_status"].Visible = false;
            this.dgvRawMats.Columns["tsqa_approval_by"].Visible = false;
            this.dgvRawMats.Columns["tsqa_approval_date"].Visible = false;
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }



        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            this.dset_emp_SearchEngines.Clear();
            this.dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("DryWarehouseNearlyExpiryLabTestViewingMajor");

        }

        
   


            private void doSearchInTextBoxCmb()
        {
            try
            {
                if (this.dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(this.dset_emp_SearchEngines.Tables[0]);


                    dv.RowFilter = "item_code = '" + txtSearch.Text + "'   ";


                    this.dgvRawMats.DataSource = dv;
                    this.lbltotalrecords.Text = this.dgvRawMats.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found Syntax Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found Evaluation Exception!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }




        }

        private void dgvRawMats_CurrentCellChanged(object sender, EventArgs e)
        {




            foreach (DataGridViewRow row in dgvRawMats.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 0) //Set your Column Index
                    {
                       row.Cells["RowSelectedCheckBox"].Value = false;

                    }

                  
                }
            }
            this.showValueCell();
            //this.AutoGeneratingLabAccessCode();



        }

        private void showValueCell()
        {

            if (dgvRawMats.Rows.Count > 0)
            {
                if (dgvRawMats.CurrentRow != null)
                {
                    if (dgvRawMats.CurrentRow.Cells["item_code"].Value != null)
                    {
                        p_id = Convert.ToInt32(this.dgvRawMats.CurrentRow.Cells["id"].Value);
                         this.matTxtItemCode.Text = this.dgvRawMats.CurrentRow.Cells["item_code"].Value.ToString();
                        this.siticoneHtmlLabelItemDesc.Text = this.dgvRawMats.CurrentRow.Cells["item_description"].Value.ToString();
                        this.SpItemDescription = this.dgvRawMats.CurrentRow.Cells["item_description"].Value.ToString();
                        this.SpRemainingQuantity = this.dgvRawMats.CurrentRow.Cells["remaining_qty"].Value.ToString();
                        this.matTxtCategory.Text = this.dgvRawMats.CurrentRow.Cells["category"].Value.ToString();
                        this.matTxtQty.Text = this.dgvRawMats.CurrentRow.Cells["qty_received"].Value.ToString();
                        this.matTxtMftgDate.Text = this.dgvRawMats.CurrentRow.Cells["mfg_date"].Value.ToString();
                        this.matTxtExpiryDate.Text = this.dgvRawMats.CurrentRow.Cells["lab_exp_date_extension"].Value.ToString();
                        this.matTxtExpiryDays.Text = this.dgvRawMats.CurrentRow.Cells["DAYSTOEXPIRED"].Value.ToString();
                        this.mattxtTransactionType.Text = this.dgvRawMats.CurrentRow.Cells["transaction_type"].Value.ToString();
                        this.mattxtLotNumber.Text = this.dgvRawMats.CurrentRow.Cells["lot_no"].Value.ToString();
                        this.SpLabStatus = this.dgvRawMats.CurrentRow.Cells["lab_status"].Value.ToString();
                        this.SplblLabRequestDate = this.dgvRawMats.CurrentRow.Cells["lab_request_date"].Value.ToString();
                        this.SpAging = this.dgvRawMats.CurrentRow.Cells["AGING"].Value.ToString();
                        this.FkReceivingID = this.dgvRawMats.CurrentRow.Cells["id"].Value.ToString();
                        this.SpHistorical = this.dgvRawMats.CurrentRow.Cells["HISTORY"].Value.ToString();
                        this.SpQAApprovalStatus = this.dgvRawMats.CurrentRow.Cells["qa_approval_status"].Value.ToString();
                        this.SpLabResultRemarks = this.dgvRawMats.CurrentRow.Cells["lab_result_remarks"].Value.ToString();
                        this.SpQAApprovalDate = this.dgvRawMats.CurrentRow.Cells["qa_approval_date"].Value.ToString();
                        this.SpLabResultReleasedDate = this.dgvRawMats.CurrentRow.Cells["lab_result_released_date"].Value.ToString();
                        this.matItemDateLastUsed.Text = this.dgvRawMats.CurrentRow.Cells["RM_ITEM_LAST_USED"].Value.ToString();
                        this.ExtendedShelfLife = this.dgvRawMats.CurrentRow.Cells["lab_exp_date_extension"].Value.ToString();
                        this.SpQAApprovalBy = this.dgvRawMats.CurrentRow.Cells["qa_approval_by"].Value.ToString();
                        this.SpLabResultReleasedBy = this.dgvRawMats.CurrentRow.Cells["lab_result_released_by"].Value.ToString();
                        this.SpLabSubRemarks = this.dgvRawMats.CurrentRow.Cells["lab_sub_remarks"].Value.ToString();
                        this.SpLaboratoryProcedure = this.dgvRawMats.CurrentRow.Cells["laboratory_procedure"].Value.ToString();
                        this.txtLabAccessCode.Text = this.dgvRawMats.CurrentRow.Cells["lab_access_code"].Value.ToString();
                        this.SpLabRequestBy = this.dgvRawMats.CurrentRow.Cells["lab_request_by"].Value.ToString();
                        this.SpPoNumber = Convert.ToInt32(this.dgvRawMats.CurrentRow.Cells["po_number"].Value);
                        this.SpPrNumber = Convert.ToInt32(this.dgvRawMats.CurrentRow.Cells["pr_no"].Value);
                        this.SpPoDate = this.dgvRawMats.CurrentRow.Cells["po_date"].Value.ToString();
                        this.SpPrDate = this.dgvRawMats.CurrentRow.Cells["pr_date"].Value.ToString();
                        this.SpLabCancelledRemarks = this.dgvRawMats.CurrentRow.Cells["lab_cancel_remarks"].Value.ToString();
                        this.TxtSampleQtyProvided.Text = this.dgvRawMats.CurrentRow.Cells["sample_qty"].Value.ToString();
               
                        if (this.lbltotalrecords.Text != "0")
                        {
                            this.SpQASupervisorApprovalStatus = Convert.ToBoolean(this.dgvRawMats.CurrentRow.Cells["qa_supervisor_is_approve_status"].Value);
                            this.Sp_Tsqa_Approval_Status = Convert.ToBoolean(this.dgvRawMats.CurrentRow.Cells["tsqa_approval_status"].Value);
                        }
                    
                        //this.SpItemImage = this.dgvRawMats.CurrentRow.Cells["item_image"].Value.ToString();
                        this.SpTotalLabtestRecords = this.dgvRawMats.CurrentRow.Cells["TotalLabtestRecords"].Value.ToString();
                        this.SpTotalLabtestRecordsCount = this.dgvRawMats.CurrentRow.Cells["TotalLabtestRecordsCount"].Value.ToString();
                        dgvRawMats.CurrentRow.Cells["RowSelectedCheckBox"].Value = true;

           
                        bool result = (int.Parse(this.TxtSampleQtyProvided.Text) == 0) ? this.TxtSampleQtyProvided.Enabled = true : this.TxtSampleQtyProvided.Enabled = false;
                        
                    }
                }
            }
            if(this.SpHistorical != "0")
            {
                this.matBtnViewLabRecords.Enabled = true;
            }
            else
            {
                this.matBtnViewLabRecords.Enabled = false;
            }


            if(this.SpLabStatus == "LAB REQUEST")
            {
                this.matViewLabRecords.Enabled = false;
                this.btnCancelLabRequest.Visible = true;
         
            }
           else if (this.SpLabStatus == "LAB APPROVED")
            {
                this.matViewLabRecords.Enabled = false;
                this.btnCancelLabRequest.Visible = true;

            }
            else if (this.SpLabStatus == "LAB RESULT")
            {
                this.matViewLabRecords.Enabled = false;
                this.btnCancelLabRequest.Visible = true;

            }
            else
            {
                this.matViewLabRecords.Enabled = true;
                this.btnCancelLabRequest.Visible = false;
              
            }

           if(this.SpLabStatus == "LAB REQUEST")
            {
                WizardBalloon1.Image = Properties.Resources.completed;
                this.lblPattern1.Visible = true;
            }
            else if (this.SpLabStatus == "LAB APPROVED")
            {
                WizardBalloon1.Image = Properties.Resources.completed;
                this.lblPattern1.Visible = true;
            }
            else if (this.SpLabStatus == "LAB RESULT")
            {
                WizardBalloon1.Image = Properties.Resources.completed;
                this.lblPattern1.Visible = true;
            }
            else
            {
                WizardBalloon1.Image = Properties.Resources.current;
                this.lblPattern1.Visible = false;
            }

           //2nd Level of Request
           if (this.lblPattern1.Visible == true)
            {
                this.WizardBalloon2.Image = Properties.Resources.current;       
            }
           else
            {
                this.WizardBalloon2.Image = Properties.Resources.pending;
            }

           if (this.SpQAApprovalStatus == "1")
            {
                this.WizardBalloon2.Image = Properties.Resources.completed;
                this.WizardBalloon3.Image = Properties.Resources.current;

                this.lblPattern2.Visible = true;
            }
           else
            {

                this.lblPattern2.Visible = false;
                this.WizardBalloon3.Image = Properties.Resources.pending;
            }



            if (this.SpLabStatus == "LAB REQUEST" && this.SpQAApprovalStatus == "1")
            {
                this.btnCancelLabRequest.Enabled = false;
            }
            else if (this.SpLabStatus == "LAB APPROVED" && this.SpQAApprovalStatus == "1")
            {
                this.btnCancelLabRequest.Enabled = false;
            }
            else if (this.SpLabStatus == "LAB RESULT" && this.SpQAApprovalStatus == "1")
            {
                this.btnCancelLabRequest.Enabled = false;
            }
            else
            {
                this.btnCancelLabRequest.Enabled = true;
            }
            //Jerusalem IF i forget you fire not gonna
            if(this.SpLabCancelledRemarks == "CANCELLED")
            {
                this.btnCancelLabRequest.Enabled = true;
            }

            //3this.SpLabResultRemarks != "0" 
            if (this.SpLabResultRemarks != "N/A")
            {
           
                this.WizardBalloon3.Image = Properties.Resources.completed;
                this.WizardBalloon4.Image = Properties.Resources.current;
                this.lblPattern3.Visible = true;
            }
            else
            {
                this.lblPattern3.Visible = false;
                this.WizardBalloon4.Image = Properties.Resources.pending;
            }

            if (this.SpQAApprovalStatus == "1" && this.SpLabResultRemarks != "0" 
                && this.SpQASupervisorApprovalStatus == true
                && this.Sp_Tsqa_Approval_Status == true)
            {
                this.MatBtnReceived.Visible = true;
            }
            else
            {
                this.MatBtnReceived.Visible = false;
            }

      

        }

        private void matViewLabRecords_Click(object sender, EventArgs e)
        {


            if (this.TxtSampleQtyProvided.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.TxtSampleQtyProvided.Focus();
                return;
            }
            //this.AutoGeneratingLabAccessCode();
            double RemainingQuantity;
            double SampleQuantity;

            RemainingQuantity = double.Parse(this.SpRemainingQuantity);
            SampleQuantity = double.Parse(this.TxtSampleQtyProvided.Text);

            if(SampleQuantity > RemainingQuantity)
            {
                this.GlobalStatePopup.GreaterThanActualRemainingQty();
                this.TxtSampleQtyProvided.Text = String.Empty;
                this.TxtSampleQtyProvided.Focus();
                return;
            }




            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to request a new data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.dSet.Clear();
                this.dSet = g_objStoredProcCollection.sp_dry_wh_lab_test_req_logs(0,
                    this.matTxtItemCode.Text.Trim(), 
                    this.SpItemDescription, 
                    this.matTxtCategory.Text.Trim(), 
                    this.matTxtQty.Text,
                    this.SpRemainingQuantity, 
                    this.matTxtExpiryDays.Text.Trim(), 
                    this.SpLabStatus, 
                    this.SpHistorical, 
                    this.SpAging,
                    "REMARKS", 
                    this.FkReceivingID, 
                    this.SpUseridentity.ToString(),
                    this.matTxtExpiryDate.Text.Trim(),
                    this.txtLabAccessCode.Text.Trim(),
                    this.SpPoNumber,
                    this.SpPrNumber,
                    Convert.ToDecimal(this.TxtSampleQtyProvided.Text),
                    "add");


                //Insert Logs
                this.dSet.Clear();
                this.dSet = g_objStoredProcCollection.sp_tblDryWHReceiving(p_id,
                p_id, 
                this.SpFirstName, 
                this.txtLabAccessCode.Text, 
                this.SpHistorical,
                this.SpDepartment,
                 this.matTxtExpiryDate.Text.Trim(), "0", "", "0",
                "0", "0", "0", "0",
                "0", "0", "0", 0, 0, "",
                "", "", "", "", 0,
                
                "dry_wh_lab_request");


                this.GlobalStatePopup.CommittedSuccessFully();
                this.frmLabTestModule_Load(sender, e);


            }
            else
            {
                return;
            }

                //End
            }

        private void matBtnNew_Click(object sender, EventArgs e)
        {

            DryWhLabTestRecentLogs fm = new DryWhLabTestRecentLogs();
            fm.ShowDialog();
        }

        private void btnCancelLabRequest_Click(object sender, EventArgs e)
        {
            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Cancel the lab test request?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.dSet.Clear();
                this.dSet = g_objStoredProcCollection.sp_tblDryWHReceiving(p_id,
                    p_id, "BUje", "0", "0", "", "0", "0", "", "0",
                    "0", "0", "0", "0",
                    "0", "0", "0", 0, 0,"0",
                    "","","", "", 0,
                    
                    "dry_wh_lab_request_cancel_by_drywh");

                this.GlobalStatePopup.CommittedSuccessFully();
                this.frmLabTestModule_Load(sender, e);
            }
            else
            {
                return;
            }

            }

        private void ChooseImage_MouseHover(object sender, EventArgs e)
        {
            this.GlobalStatePopup.BallonNotifyHover();
        }

        private void ChooseImage_MouseLeave(object sender, EventArgs e)
        {
            this.GlobalStatePopup.BallonNotifyHover();
        }

        private void siticoneHtmlLabel1_MouseHover(object sender, EventArgs e)
        {
            this.GlobalStatePopup.BallonNotifyHover();
        }

        private void siticoneHtmlLabel1_Click(object sender, EventArgs e)
        {
            this.GlobalStatePopup.BallonNotifyHover();
            MessageBox.Show("Samop");
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            this.GlobalStatePopup.WizzardMesage1 = this.SplblLabRequestDate;
            this.GlobalStatePopup.BallonNotifyHover();
        }

        private void matBtnCancel_Click(object sender, EventArgs e)
        {
            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Cancel the lab test request?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                if (this.SpLabCancelledRemarks == "CANCELLED")
                {
                    

                this.dSet.Clear();
                this.dSet = g_objStoredProcCollection.sp_tblDryWHReceiving(p_id,
                p_id, "BUje", "0", "0", "", "0", "0", "", "0",
                "0", "0", "0", "0",
                "0", "0", "0", 0, 0, "0",
                "", "", "","", 0,
                "dry_wh_lab_request_cancel_by_qa_resetall");

                this.GlobalStatePopup.CommittedSuccessFully();
                this.frmLabTestModule_Load(sender, e);

                }
                else
                {


                this.dSet.Clear();
                this.dSet = g_objStoredProcCollection.sp_dry_wh_lab_test_req_logs(0,
                this.p_id.ToString(),
                this.SpItemDescription,
                this.matTxtCategory.Text.Trim(),
                this.matTxtQty.Text.Trim(),
                SpRemainingQuantity,
                this.matTxtExpiryDays.Text.Trim(),
                this.SpLabStatus,
                this.SpHistorical,
                this.SpAging,
                "REMARKS",
                FkReceivingID,
                this.SpUseridentity.ToString(),
                this.matTxtExpiryDate.Text.Trim(),
                this.txtLabAccessCode.Text.Trim(),
                this.SpPoNumber,
                this.SpPrNumber,
                Convert.ToDecimal(this.TxtSampleQtyProvided.Text),
                "cancel");

                this.dSet.Clear();
                this.dSet = g_objStoredProcCollection.sp_tblDryWHReceiving(p_id,
                p_id, "BUje", "0", "0", "", "0", "0", "", "0",
                "0", "0", "0", "0",
                "0", "0", "0", 0, 0, "0",
                "", "", "","",0,
                "dry_wh_lab_request_cancel_by_drywh");

                this.GlobalStatePopup.CommittedSuccessFully();
                this.frmLabTestModule_Load(sender, e);
                }
            }
            else
            {
                return;
            }

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
      
            this.doSearchInTextBoxCmb();


            if (this.txtSearch.Text == String.Empty)
            {
                this.showRawMaterialsNearlyExpiry();
            }
        }

        private void lblPattern2_MouseHover(object sender, EventArgs e)
        {
            this.GlobalStatePopup.WizzardMesage2 = this.SpQAApprovalDate;
            this.GlobalStatePopup.BallonNotifyHover2();
        }

        private void lblPattern3_MouseHover(object sender, EventArgs e)
        {
            this.GlobalStatePopup.WizzardMesage3 = this.SpLabResultReleasedDate;
            this.GlobalStatePopup.BallonNotifyHover3();
        }

        private void MatBtnReceived_Click(object sender, EventArgs e)
        {
            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to received the Lab Result?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                this.dSet.Clear();
                this.dSet = g_objStoredProcCollection.sp_tblDryWHReceiving(
                    p_id,
                    p_id,
                    this.SpFirstName, 
                    this.ExtendedShelfLife,
                    this.SpQAApprovalBy,
                    "1",
                    this.SpQAApprovalDate,
                    this.SpLabResultReleasedBy,
                    this.SpLabResultReleasedDate,
                    this.SpLabResultRemarks,
                    this.SpLabSubRemarks,
                    this.ExtendedShelfLife,
                    this.SpLaboratoryProcedure,
                    this.SplblLabRequestDate,
                    this.SpLabRequestBy,
                    this.SpLabRequestBy,
                    this.SpPoNumber.ToString(),
                    0, 
                    0,
                    this.SpPoDate,
                    this.SpPrNumber.ToString(),
                    this.SpPrDate,
                    "",
                    "",
                        0,

                    "dry_wh_lab_result_received_by_drywh");
                
                this.GlobalStatePopup.LabTestResultSuccessFullyReceived();
                this.frmLabTestModule_Load(sender, e);
            }
            else
            {
                return;
            }
           //End of Transaction
            }

        private void mattxtTransactionType_TextChanged(object sender, EventArgs e)
        {

        }

        private void matBtnViewLabRecords_Click(object sender, EventArgs e)
        {
            frmLabTestHistoricalPerReceivingID ViewLabHistory =
             new frmLabTestHistoricalPerReceivingID(this, this.p_id);
            ViewLabHistory.ShowDialog();
        }

        private void dgvRawMats_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            foreach (DataGridViewRow row in dgvRawMats.Rows)
            {
                if (Convert.ToString(row.Cells["lab_cancel_remarks"].Value) == "CANCELLED")
                {


                    row.Cells["item_code"].Style.BackColor = Color.Crimson;
                    row.Cells["item_description"].Style.BackColor = Color.Crimson;
                    row.Cells["category"].Style.BackColor = Color.Crimson;
                    row.Cells["qty_received"].Style.BackColor = Color.Crimson;
                    row.Cells["exp_date"].Style.BackColor = Color.Crimson;
                    row.Cells["remaining_qty"].Style.BackColor = Color.Crimson;
                    row.Cells["DAYSTOEXPIRED"].Style.BackColor = Color.Crimson;
                    row.Cells["lab_status"].Style.BackColor = Color.Crimson;
                    row.Cells["HISTORY"].Style.BackColor = Color.Crimson;
                    row.Cells["lab_exp_date_extension"].Style.BackColor = Color.Crimson;
                    row.Cells["lab_sub_remarks"].Style.BackColor = Color.Crimson;
                    row.Cells["laboratory_procedure"].Style.BackColor = Color.Crimson;
                    row.Cells["AGING"].Style.BackColor = Color.Crimson;
                    row.Cells["lab_result_remarks"].Style.BackColor = Color.Crimson;


                    row.Cells["item_code"].Style.SelectionBackColor = Color.Crimson;
                    row.Cells["item_description"].Style.SelectionBackColor = Color.Crimson;
                    row.Cells["category"].Style.SelectionBackColor = Color.Crimson;
                    row.Cells["qty_received"].Style.SelectionBackColor = Color.Crimson;
                    row.Cells["exp_date"].Style.SelectionBackColor = Color.Crimson;
                    row.Cells["remaining_qty"].Style.SelectionBackColor = Color.Crimson;
                    row.Cells["DAYSTOEXPIRED"].Style.SelectionBackColor = Color.Crimson;
                    row.Cells["lab_status"].Style.SelectionBackColor = Color.Crimson;
                    row.Cells["HISTORY"].Style.SelectionBackColor = Color.Crimson;
                    row.Cells["lab_exp_date_extension"].Style.SelectionBackColor = Color.Crimson;
                    row.Cells["lab_sub_remarks"].Style.SelectionBackColor = Color.Crimson;
                    row.Cells["laboratory_procedure"].Style.SelectionBackColor = Color.Crimson;
                    row.Cells["AGING"].Style.SelectionBackColor = Color.Crimson;
                    row.Cells["lab_result_remarks"].Style.SelectionBackColor = Color.Crimson;


                    row.Cells["item_code"].Style.SelectionForeColor = Color.White;
                    row.Cells["item_description"].Style.SelectionForeColor = Color.White;
                    row.Cells["category"].Style.SelectionForeColor = Color.White;
                    row.Cells["qty_received"].Style.SelectionForeColor = Color.White;
                    row.Cells["exp_date"].Style.SelectionForeColor = Color.White;
                    row.Cells["remaining_qty"].Style.SelectionForeColor = Color.White;
                    row.Cells["DAYSTOEXPIRED"].Style.SelectionForeColor = Color.White;
                    row.Cells["lab_status"].Style.SelectionForeColor = Color.White;
                    row.Cells["HISTORY"].Style.SelectionForeColor = Color.White;
                    row.Cells["lab_exp_date_extension"].Style.SelectionForeColor = Color.White;
                    row.Cells["lab_sub_remarks"].Style.SelectionForeColor = Color.White;
                    row.Cells["laboratory_procedure"].Style.SelectionForeColor = Color.White;
                    row.Cells["AGING"].Style.SelectionForeColor = Color.White;
                    row.Cells["lab_result_remarks"].Style.SelectionForeColor = Color.White;
                }



                else
                {

                    row.Cells["item_code"].Style.BackColor = Color.White;
                    row.Cells["item_description"].Style.BackColor = Color.White;
                    row.Cells["category"].Style.BackColor = Color.White;
                    row.Cells["qty_received"].Style.BackColor = Color.White;
                    row.Cells["exp_date"].Style.BackColor = Color.White;
                    row.Cells["remaining_qty"].Style.BackColor = Color.White;
                    row.Cells["DAYSTOEXPIRED"].Style.BackColor = Color.White;
                    row.Cells["lab_status"].Style.BackColor = Color.White;
                    row.Cells["HISTORY"].Style.BackColor = Color.White;
                    row.Cells["lab_exp_date_extension"].Style.BackColor = Color.White;
                    row.Cells["lab_sub_remarks"].Style.BackColor = Color.White;
                    row.Cells["laboratory_procedure"].Style.BackColor = Color.White;
                    row.Cells["AGING"].Style.BackColor = Color.White;
                    row.Cells["lab_result_remarks"].Style.BackColor = Color.White;



                    row.Cells["item_code"].Style.SelectionBackColor = Color.DarkSlateGray;
                    row.Cells["item_description"].Style.SelectionBackColor = Color.DarkSlateGray;
                    row.Cells["category"].Style.SelectionBackColor = Color.DarkSlateGray;
                    row.Cells["qty_received"].Style.SelectionBackColor = Color.DarkSlateGray;
                    row.Cells["exp_date"].Style.SelectionBackColor = Color.DarkSlateGray;
                    row.Cells["remaining_qty"].Style.SelectionBackColor = Color.DarkSlateGray;
                    row.Cells["DAYSTOEXPIRED"].Style.SelectionBackColor = Color.DarkSlateGray;
                    row.Cells["lab_status"].Style.SelectionBackColor = Color.DarkSlateGray;
                    row.Cells["HISTORY"].Style.SelectionBackColor = Color.DarkSlateGray;
                    row.Cells["lab_exp_date_extension"].Style.SelectionBackColor = Color.DarkSlateGray;
                    row.Cells["lab_sub_remarks"].Style.SelectionBackColor = Color.DarkSlateGray;
                    row.Cells["laboratory_procedure"].Style.SelectionBackColor = Color.DarkSlateGray;
                    row.Cells["AGING"].Style.SelectionBackColor = Color.DarkSlateGray;
                    row.Cells["lab_result_remarks"].Style.SelectionBackColor = Color.DarkSlateGray;


                    row.Cells["item_code"].Style.SelectionForeColor = Color.White;
                    row.Cells["item_description"].Style.SelectionForeColor = Color.White;
                    row.Cells["category"].Style.SelectionForeColor = Color.White;
                    row.Cells["qty_received"].Style.SelectionForeColor = Color.White;
                    row.Cells["exp_date"].Style.SelectionForeColor = Color.White;
                    row.Cells["remaining_qty"].Style.SelectionForeColor = Color.White;
                    row.Cells["DAYSTOEXPIRED"].Style.SelectionForeColor = Color.White;
                    row.Cells["lab_status"].Style.SelectionForeColor = Color.White;
                    row.Cells["HISTORY"].Style.SelectionForeColor = Color.White;
                    row.Cells["lab_exp_date_extension"].Style.SelectionForeColor = Color.White;
                    row.Cells["lab_sub_remarks"].Style.SelectionForeColor = Color.White;
                    row.Cells["laboratory_procedure"].Style.SelectionForeColor = Color.White;
                    row.Cells["AGING"].Style.SelectionForeColor = Color.White;
                    row.Cells["lab_result_remarks"].Style.SelectionForeColor = Color.White;
                }

                if (Convert.ToString(row.Cells["lab_result_remarks"].Value) == "0" )
                {
                    row.Cells["lab_result_remarks"].Value = "N/A";
                    //row.Cells["lab_result_remarks"].Visible.Equals(false);
                }
           

            }


        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.AutoGeneratingLabAccessCode();
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
         
            MessageBox.Show(this.SpQASupervisorApprovalStatus.ToString());
            if (this.SpQASupervisorApprovalStatus == true)
            {
                this.MatBtnReceived.Visible = true;
            }
        }

        private void matItemDateLastUsed_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSampleQtyProvided_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(this.TxtSampleQtyProvided.Text + ch, out x))
            {
                e.Handled = true;
            }
        }
    }
}
