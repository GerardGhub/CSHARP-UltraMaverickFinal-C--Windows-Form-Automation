using COMPLETE_FLAT_UI.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
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

        private void frmLabTestModule_Load(object sender, EventArgs e)
        {
            this.ConnectionInitialization();
            this.showRawMaterialsNearlyExpiry();
            this.WindowLoadState();
         
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
        }

        private void ConnectionInitialization()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            this.objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
        }


        private void showRawMaterialsNearlyExpiry()    //method for loading available_menus
        {
            try
            {

                xClass.fillDataGridView(this.dgvRawMats, "DryWarehouseNearlyExpiryLabTestViewing", dSet);

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
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }



        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            this.dset_emp_SearchEngines.Clear();


            this.dset_emp_SearchEngines = objStorProc.sp_getMajorTables("DryWarehouseNearlyExpiryLabTestViewingMajor");

        }


        private void doSearchInTextBoxCmb()
        {
            try
            {
                if (this.dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(this.dset_emp_SearchEngines.Tables[0]);


                    dv.RowFilter = "item_code like '%" + this.txtSearch.Text + "%' or item_description like '%" + this.txtSearch.Text + "%'   ";


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
            this.showValueCell();

   
          
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
                        this.matTxtExpiryDate.Text = this.dgvRawMats.CurrentRow.Cells["exp_date"].Value.ToString();
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
                        //this.SpItemImage = this.dgvRawMats.CurrentRow.Cells["item_image"].Value.ToString();

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
            else
            {
                this.btnCancelLabRequest.Enabled = true;
            }

            //3
            if (this.SpLabResultRemarks != "0")
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

            if (this.SpQAApprovalStatus == "1" && this.SpLabResultRemarks != "0")
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

            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to request a new data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.dSet.Clear();
                this.dSet = objStorProc.sp_dry_wh_lab_test_req_logs(0,
                    this.matTxtItemCode.Text, this.SpItemDescription, this.matTxtCategory.Text, this.matTxtQty.Text,
                    SpRemainingQuantity, this.matTxtExpiryDays.Text, this.SpLabStatus, this.SpHistorical, this.SpAging,
                    "REMARKS", FkReceivingID, this.SpUseridentity.ToString(), "add");


                //Insert Logs
                this.dSet.Clear();
                this.dSet = objStorProc.sp_tblDryWHReceiving(p_id,
                    p_id, "BUje", "0", "0", "", "0", "0", "", "0",
                    "0", "0", "0", "0",
                    "0", "0", "0", 0, 0, "", "dry_wh_lab_request");


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
                this.dSet = objStorProc.sp_tblDryWHReceiving(p_id,
                    p_id, "BUje", "0", "0", "", "0", "0", "", "0",
                    "0", "0", "0", "0",
                    "0", "0", "0", 0, 0,"0", "dry_wh_lab_request_cancel_by_drywh");

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

          
                this.dSet.Clear();
                this.dSet = objStorProc.sp_dry_wh_lab_test_req_logs(0,
                    this.p_id.ToString(), this.SpItemDescription, this.matTxtCategory.Text, this.matTxtQty.Text,
                    SpRemainingQuantity, this.matTxtExpiryDays.Text, this.SpLabStatus, this.SpHistorical, this.SpAging,
                    "REMARKS", FkReceivingID, this.SpUseridentity.ToString(), "cancel");

                this.dSet.Clear();
                this.dSet = objStorProc.sp_tblDryWHReceiving(p_id,
                    p_id, "BUje", "0", "0", "", "0", "0", "", "0",
                    "0", "0", "0", "0",
                    "0", "0", "0", 0, 0, "0", "dry_wh_lab_request_cancel_by_drywh");

                this.GlobalStatePopup.CommittedSuccessFully();
                this.frmLabTestModule_Load(sender, e);
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
                this.dSet = objStorProc.sp_tblDryWHReceiving(p_id,
                    p_id, "BUje", "0", "0", "", "0", "0", "", "0",
                    "0", "0", "0", "0",
                    "0", "0", "0", 0, 0,"0", "dry_wh_lab_result_received_by_drywh");

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
    }
}
