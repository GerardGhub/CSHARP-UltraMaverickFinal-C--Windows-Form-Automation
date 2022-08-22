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
using ULTRAMAVERICK.Forms.Dry_Warehouse.Move_Order;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Add_Modal
{
    public partial class frmNewCustomer : MaterialForm
    {

        frmCustomers ths;
        DataSet dSet = new DataSet();
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        TblCustomersRepository TblCustomersRepositorys = new TblCustomersRepository();


        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        public frmNewCustomer(frmCustomers frm, string created_by)
        {
            InitializeComponent();
        }

        private void frmNewCustomer_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections

        }

        private void matBtnSave_Click(object sender, EventArgs e)
        {
            //Name
            if (this.txtMatName.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.txtMatName.Focus();
                return;
            }
            //Type 
            if (this.metroCmbType.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.metroCmbType.Focus();
                return;
            }
            //Company
            if (this.metroCmbCompany.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.metroCmbCompany.Focus();
                return;
            }
            //Mobile
            if (this.txtmatMobile.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.txtmatMobile.Focus();
                return;
            }
            //Lead Man
            if (this.matTxtLeadMan.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.matTxtLeadMan.Focus();
                return;
            }
            //Address
            if (this.txtMatAddress.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.txtMatAddress.Focus();
                return;
            }

            //Validation to minimize the duplicate fucking entries
            dSet.Clear();
            dSet = g_objStoredProcCollection.sp_tblCustomers(0,
                this.txtMatName.Text.Trim(),
                this.metroCmbType.Text.Trim(),             
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                false,
                "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.GlobalStatePopup.DataAlreadyExist();



                this.txtMatName.Focus();
                return;
            }
            else
            {
                this.MetroSave();
            }









        }


        private void MetroSave()
        {

            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save a new data? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.TblCustomersRepositorys
                    .AddCustomer(0, 
                    this.txtMatName.Text,
                    this.metroCmbType.Text, 
                    this.metroCmbCompany.Text, 
                    this.txtmatMobile.Text, 
                    this.matTxtLeadMan.Text, 
                    this.txtMatAddress.Text, 
                    Convert.ToString(user_info.user_id),
                    "",
                    "",
                    "",
                    false, 
                    "add");
                this.GlobalStatePopup.UpdatedSuccessfully();
                this.Close();
            }
            else
            {
                return;
            }

        }


      }
}
