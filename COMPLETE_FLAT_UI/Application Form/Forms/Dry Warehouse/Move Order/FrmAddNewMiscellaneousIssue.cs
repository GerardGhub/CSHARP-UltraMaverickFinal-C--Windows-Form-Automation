using COMPLETE_FLAT_UI.Models;
using MaterialSkin.Controls;
using System;
using System.Data;
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
            this.Text = "Add New Miscellaneouse Issue";
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
            if (this.MatCmbExpiryDate.Text == String.Empty)
            {
                this.MatBtnSave.Visible = false;
            }
            else
            {
                this.MatBtnSave.Visible=true;
            }
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
            if (this.MatCmbExpiryDate.Text == String.Empty)
            {
                return;
            }
            int IndexOf = 0;
            this.MatTxtReceivingID.Text = MatCmbExpiryDate.SelectedValue.ToString();


            //Date Conversion
            DateTime dt = new DateTime();
            string lstrDate = this.MatCmbExpiryDate.Text;
            dt = Convert.ToDateTime(lstrDate);
            string ExpDate = dt.ToString("yyyy-MM-dd");


            IndexOf = MatCmbExpiryDate.SelectedIndex;
            xClass.DataSetRMMoverOrderIssue = g_objStoredProcCollection.
                sp_getMinorTables("TblDryWHReceiving_dropdown_binding", null, this.MatCmbItemCode.Text.Trim(), ExpDate, null, null);
            this.MatTxtQuantity.Text = xClass.DataSetRMMoverOrderIssue.Tables[0].Rows[IndexOf]["qty_received"].ToString();
            this.MatTxtTransactionType.Text = xClass.DataSetRMMoverOrderIssue.Tables[0].Rows[IndexOf]["transaction_type"].ToString();
            this.MatTxtLotNo.Text = xClass.DataSetRMMoverOrderIssue.Tables[0].Rows[IndexOf]["lot_no"].ToString();
            this.MatTxtLotDesc.Text = xClass.DataSetRMMoverOrderIssue.Tables[0].Rows[IndexOf]["lot_description"].ToString();
            this.MatTxtReceivedDate.Text = xClass.DataSetRMMoverOrderIssue.Tables[0].Rows[IndexOf]["date_added"].ToString();
            this.DryWHIssueEntity.Supplier = xClass.DataSetRMMoverOrderIssue.Tables[0].Rows[IndexOf]["supplier"].ToString();
            this.MatTxtAvailableStock.Text = xClass.DataSetRMMoverOrderIssue.Tables[0].Rows[IndexOf]["RESERVED"].ToString();
            this.CalculateBetweenTwoDateGetTheDays();
        }

        public void CalculateBetweenTwoDateGetTheDays()
        {
            DateTime d1 = Convert.ToDateTime(this.MatTxtReceivedDate.Text);
            DateTime d2 = Convert.ToDateTime(this.MatCmbExpiryDate.Text);
            TimeSpan t = d2 - d1;
            double NrOfDays = t.TotalDays;
            this.MatTxtExpiryDays.Text = NrOfDays.ToString("N0");
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

            if (this.MatTxtQtyOut.Text == "0")
            {
                this.GlobalStatePopup.InvalidQuantity();
                this.MatTxtQtyOut.Text = String.Empty;
                this.MatTxtQtyOut.Select();
                return;
            }

            double Reserved;
            double Order;
            Reserved = double.Parse(this.MatTxtAvailableStock.Text);
            Order = double.Parse(this.MatTxtQtyOut.Text);

            if (Order > Reserved)
            {
                this.GlobalStatePopup.GreaterThanActualRemainingQty();
                this.MatTxtQtyOut.Text = String.Empty;
                this.MatTxtQtyOut.Select();
                return;
            }

            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save a new data? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    Convert.ToInt32(this.MatTxtQtyOut.Text),
                    Convert.ToInt32(this.MatTxtReceivingID.Text),
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

        private void FrmAddNewMiscellaneousIssue_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.textBox1.Text = "FormClose";
        }
    }
}
