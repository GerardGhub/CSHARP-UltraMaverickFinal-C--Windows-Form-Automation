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
using ULTRAMAVERICK.API.Data;
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Move_Order
{
    public partial class FrmAddNewMiscellaneousReceipt : MaterialForm
    {
        myclasses xClass = new myclasses();
       frmDryWhMiscellaneousReceipts ths;

        TblCustomersRepository TblCustomerRepo = new TblCustomersRepository();
        TblCustomers TblCustomersEntity = new TblCustomers();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();


        DateTime dNow = DateTime.Now;

        int Useridentity = 0;

        DataSet dSet_temp = new DataSet();

        public FrmAddNewMiscellaneousReceipt(frmDryWhMiscellaneousReceipts frm)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
        }

        private void AddNewMiscellaneousReceipt_Load(object sender, EventArgs e)
        {
            this.ConnetionString();
            this.LoadItemCodeDropdown();
            this.MatDtpMFtgDate.MaxDate = DateTime.Today;
            this.MatDtpExpDate.MinDate = DateTime.Today;
            MatCmbItemCode_SelectionChangeCommitted(sender, e);
            this.Useridentity = userinfo.user_id;
        }
        private void ConnetionString()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }
        public void LoadItemCodeDropdown()
        {

         myClass.fillComboBoxRMDryItemCode(MatCmbItemCode, "Item_Code_dropdown", dSet);

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        private void MatCmbItemCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int IndexOf = 0;
            this.MatTxtItemDescription.Text = MatCmbItemCode.SelectedValue.ToString();

       
            IndexOf = MatCmbItemCode.SelectedIndex;
            xClass.DataSetRMMoverOrderReceipt = g_objStoredProcCollection.sp_getMinorTables("Item_Code_dropdown", null, null, null, null, null);
            this.MatTxtCategory.Text = xClass.DataSetRMMoverOrderReceipt.Tables[0].Rows[IndexOf]["major_category"].ToString();
    



            //this.MatTxtCategory.Text = xClass.SubCategory.ToString();

        }

        private void MatDtpMFtgDate_ValueChanged(object sender, EventArgs e)
        {
            this.CalculateBetweenTwoDateGetTheDays();
        }
        public void CalculateBetweenTwoDateGetTheDays()
        {
            //DateTime d1 = Convert.ToDateTime(this.MatDtpMFtgDate.Text);
            DateTime d1 = Convert.ToDateTime(DateTime.Now);
            DateTime d2 = Convert.ToDateTime(this.MatDtpExpDate.Text);
            TimeSpan t = d2 - d1;
            double NrOfDays = t.TotalDays;
            this.MatTxtExpiryDays.Text = NrOfDays.ToString("N0");
        }

        private void MatDtpExpDate_ValueChanged(object sender, EventArgs e)
        {
            this.CalculateBetweenTwoDateGetTheDays();
        }

        private void materialTextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

        }

        private void FrmAddNewMiscellaneousReceipt_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (this.MatTxtParentDescription.Text == String.Empty)
            //{

            //}
            //else
            //{
            //    ths.GpInfo.Text = "Transaction for " + this.MatTxtParentDescription.Text;
            //    ths.MatTxtLotNo.Text = this.MatTxtLotNo.Text;
            //    ths.MatTxtLotDescription.Text = this.MatTxtLotDesc.Text;
            //    ths.MatBtnNew.Enabled = true;
            //}
            this.textBox1.Text = "FormClose";
        
        }

        private void MatBtnSave_Click(object sender, EventArgs e)
        {
            if (this.MatTxtExpiryDays.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.MatDtpMFtgDate.Focus();
                return;
            }

            if (this.MatTxtQuantity.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.MatTxtQuantity.Focus();
                return;
            }

            if (this.MatTxtLotNo.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.MatTxtLotNo.Focus();
                return;
            }

            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save a new data? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                try
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection
                    .Sp_DryWHReceipt(0,
                    ths.MatTxtParentDescription.Text.Trim(),
                    0,
                    Convert.ToInt32(this.MatTxtLotNo.Text.Trim()),
                    this.MatTxtLotDesc.Text.Trim(),
                    this.MatDtpMFtgDate.Text.Trim(),
                    this.MatDtpExpDate.Text.Trim(),
                    this.MatTxtExpiryDays.Text.Trim(),
                    this.MatCmbItemCode.Text.Trim(),
                    this.MatTxtItemDescription.Text.Trim(),
                    this.MatTxtCategory.Text.Trim(),
                    ths.MatCmbSupplierCode.Text.Trim(),
                    Convert.ToDouble(this.MatTxtQuantity.Text.Trim()),
                    ths.matCmbRemarks.Text.Trim(),
                    Convert.ToString(this.Useridentity),
                    "",
                    true,
                    "add");

                    this.GlobalStatePopup.SuccessfullyReceived();
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }



            }
            else
            {
                return;
            }


            }

        private void btnSelectLot_Click(object sender, EventArgs e)
        {
            FrmChooseLotNumberMoveOrder showModal = new FrmChooseLotNumberMoveOrder(this, this.MatTxtCategory.Text);
            showModal.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }
    }
}
