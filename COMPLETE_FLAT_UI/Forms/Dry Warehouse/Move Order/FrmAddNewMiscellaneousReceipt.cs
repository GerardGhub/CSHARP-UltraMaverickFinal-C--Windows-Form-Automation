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
            this.MatTxtItemDescription.Text = MatCmbItemCode.SelectedValue.ToString();
        }
    }
}
