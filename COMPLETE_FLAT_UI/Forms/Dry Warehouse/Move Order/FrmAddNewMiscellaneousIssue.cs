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
    public partial class FrmAddNewMiscellaneousIssue : MaterialForm
    {
        myclasses xClass = new myclasses();
        FrmDryWhMiscellaneouseIssue ths;

        TblCustomersRepository TblCustomerRepo = new TblCustomersRepository();
        DryWHIssue DryWHIssueEntity = new DryWHIssue();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();


        DateTime dNow = DateTime.Now;

        int Useridentity = 0;

        DataSet dSet_temp = new DataSet();

        public FrmAddNewMiscellaneousIssue(FrmDryWhMiscellaneouseIssue frm)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
        }

        private void FrmAddNewMiscellaneousIssue_Load(object sender, EventArgs e)
        {
            this.ConnetionString();
            this.LoadItemCodeDropdown();
            MatCmbItemCode_SelectionChangeCommitted(sender, e);
            this.Useridentity = userinfo.user_id;
        }

        public void LoadReceivingIdentityCmb()
        {

            myClass.fillCmbItemCode(MatCmbExpiryDate, "TblDryWHReceiving_dropdown", dSet, MatCmbItemCode.Text);
            this.MatCmbReceivingId_SelectionChangeCommitted(new object(), new System.EventArgs());
        }

        private void ConnetionString()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); 
        }
        public void LoadItemCodeDropdown()
        {

            myClass.fillComboBoxRMDryItemCode(MatCmbItemCode, "Item_Code_dropdown", dSet);

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void MatCmbItemCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int IndexOf = 0;
            this.MatTxtItemDescription.Text = MatCmbItemCode.SelectedValue.ToString();


            IndexOf = MatCmbItemCode.SelectedIndex;
            xClass.DataSetRMMoverOrderReceipt = g_objStoredProcCollection.sp_getMinorTables("Item_Code_dropdown", null, null, null, null, null);
            this.MatTxtCategory.Text = xClass.DataSetRMMoverOrderReceipt.Tables[0].Rows[IndexOf]["major_category"].ToString();

            this.LoadReceivingIdentityCmb();
        }

        private void MatTxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
           
        }

        private void MatCmbReceivingId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int IndexOf = 0;
            this.MatTxtReceivingID.Text = MatCmbExpiryDate.SelectedValue.ToString();


            IndexOf = MatCmbExpiryDate.SelectedIndex;
            //MessageBox.Show(IndexOf.ToString());
            //return;
            xClass.DataSetRMMoverOrderIssue = g_objStoredProcCollection.
                sp_getMinorTables("TblDryWHReceiving_dropdown", null, this.MatCmbItemCode.Text.Trim(), null, null, null);
            this.MatTxtQuantity.Text = xClass.DataSetRMMoverOrderIssue.Tables[0].Rows[IndexOf]["qty_received"].ToString();
            this.MatTxtTransactionType.Text = xClass.DataSetRMMoverOrderIssue.Tables[0].Rows[IndexOf]["transaction_type"].ToString();
            this.MatTxtLotNo.Text = xClass.DataSetRMMoverOrderIssue.Tables[0].Rows[IndexOf]["lot_no"].ToString();
            this.MatTxtLotDesc.Text = xClass.DataSetRMMoverOrderIssue.Tables[0].Rows[IndexOf]["lot_description"].ToString();
            this.MatTxtReceivedDate.Text = xClass.DataSetRMMoverOrderIssue.Tables[0].Rows[IndexOf]["date_added"].ToString();
            this.DryWHIssueEntity.Supplier = xClass.DataSetRMMoverOrderIssue.Tables[0].Rows[IndexOf]["supplier"].ToString();
            this.CalculateBetweenTwoDateGetTheDays();
        }

        public void CalculateBetweenTwoDateGetTheDays()
        {
            DateTime d1 = Convert.ToDateTime(this.MatTxtReceivedDate.Text);
            DateTime d2 = Convert.ToDateTime(this.MatCmbExpiryDate.Text);
            TimeSpan t = d2 - d1;
            double NrOfDays = t.TotalDays;
            this.MatTxtExpiryDays.Text = NrOfDays.ToString();
        }

        private void MatBtnSave_Click(object sender, EventArgs e)
        {
            if (this.MatTxtExpiryDays.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
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

            if (this.MatTxtQtyOut.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.MatTxtQtyOut.Focus();
                return;
            }


       
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save a new data? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                try
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection
                    .Sp_DryWHIssue(0,
                    ths.MatTxtParentDescription.Text.Trim(),
                    0,
                    Convert.ToInt32(this.MatTxtLotNo.Text.Trim()),
                    this.MatTxtLotDesc.Text.Trim(),
                    this.MatTxtReceivedDate.Text.Trim(),
                    this.MatCmbExpiryDate.Text.Trim(),
                    this.MatTxtExpiryDays.Text.Trim(),
                    this.MatCmbItemCode.Text.Trim(),
                    this.MatTxtItemDescription.Text.Trim(),
                    this.MatTxtCategory.Text.Trim(),
                    this.DryWHIssueEntity.Supplier,
                    Convert.ToDouble(this.MatTxtQuantity.Text.Trim()),
                    "",
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

        private void MatTxtQtyOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
