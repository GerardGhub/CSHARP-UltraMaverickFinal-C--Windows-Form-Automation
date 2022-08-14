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

        TblCustomersRepository TblCustomerRepo = new TblCustomersRepository();
        TblCustomers TblCustomersEntity = new TblCustomers();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();

        string mode = "";
        int p_id = 0;

        DateTime dNow = DateTime.Now;



        DataSet dSet_temp = new DataSet();

        public FrmAddNewMiscellaneousReceipt()
        {
            InitializeComponent();
        }

        private void AddNewMiscellaneousReceipt_Load(object sender, EventArgs e)
        {
            this.ConnetionString();
            this.LoadItemCodeDropdown();
            this.MatDtpMFtgDate.MaxDate = DateTime.Today;
            this.MatDtpExpDate.MinDate = DateTime.Today;
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
            this.MatTxtCategory.Text = xClass.DataSetRMMoverOrderReceipt.Tables[0].Rows[IndexOf]["sub_category"].ToString();
    



            //this.MatTxtCategory.Text = xClass.SubCategory.ToString();

        }

        private void MatDtpMFtgDate_ValueChanged(object sender, EventArgs e)
        {
            this.CalculateBetweenTwoDateGetTheDays();
        }
        public void CalculateBetweenTwoDateGetTheDays()
        {
            DateTime d1 = Convert.ToDateTime(this.MatDtpMFtgDate.Text);
            DateTime d2 = Convert.ToDateTime(this.MatDtpExpDate.Text);
            TimeSpan t = d2 - d1;
            double NrOfDays = t.TotalDays;
            this.MatTxtExpiryDays.Text = NrOfDays.ToString();
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
    }
}
