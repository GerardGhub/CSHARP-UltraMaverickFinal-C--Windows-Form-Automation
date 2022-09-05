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
        TblCustomers TblCustomersEntity = new TblCustomers();
        TblCustomersRepository TblCustomersRepositorys = new TblCustomersRepository();

        
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        public frmNewCustomer(
            frmCustomers frm,
            int Created_by, 
            string Mode,
            string CustomerName,
            string CustomerType,
            string CustomerCompany,
            int Mobile,
            string LeadMan,
            string Address,
            int IndexOf
            )
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.TblCustomersEntity.Mode = Mode;
            this.TblCustomersEntity.Cust_Name = CustomerName;
            this.TblCustomersEntity.Cust_Type = CustomerType;
            this.TblCustomersEntity.Cust_Company = CustomerCompany;
            this.TblCustomersEntity.Cust_Mobile = Mobile;
            this.TblCustomersEntity.Cust_LeadMan = LeadMan;
            this.TblCustomersEntity.Cust_Address = Address;
            this.TblCustomersEntity.Cust_Id = IndexOf;
            this.TblCustomersEntity.Cust_Added_By = Created_by;
            this.TblCustomersEntity.Cust_Updated_by = Created_by.ToString();
        }

        private void frmNewCustomer_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections();
            this.TblCustomersEntity.Cust_Added_By = userinfo.user_id;
            


            if (this.TblCustomersEntity.Mode == "Add")
            {
                this.TblCustomersEntity.Cust_Added_By = this.TblCustomersEntity.Cust_Added_By;
            }
            else if (this.TblCustomersEntity.Mode =="Edit")
            {
                this.MatTxtName.Text = this.TblCustomersEntity.Cust_Name;
                this.metroCmbType.Text = this.TblCustomersEntity.Cust_Type;
                this.metroCmbCompany.Text = this.TblCustomersEntity.Cust_Company;
                this.TxtMobile.Text = Convert.ToString(this.TblCustomersEntity.Cust_Mobile);
                this.TxtLeadMan.Text = this.TblCustomersEntity.Cust_LeadMan;
                this.TxtAddress.Text = this.TblCustomersEntity.Cust_Address;
                this.TblCustomersEntity.Cust_Id = this.TblCustomersEntity.Cust_Id;
                this.TblCustomersEntity.Cust_Updated_by = this.TblCustomersEntity.Cust_Updated_by;
            }
     
        }

        private void matBtnSave_Click(object sender, EventArgs e)
        {
            //Name
            if (this.MatTxtName.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.MatTxtName.Focus();
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
            if (this.TxtMobile.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.TxtMobile.Focus();
                return;
            }
            //Lead Man
            if (this.TxtLeadMan.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.TxtLeadMan.Focus();
                return;
            }
            //Address
            if (this.TxtAddress.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.TxtAddress.Focus();
                return;
            }


            if (this.TblCustomersEntity.Mode == "Add")
            {

                //Validation to minimize the duplicate fucking entries
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_tblCustomers(0,
                    this.MatTxtName.Text.Trim(),
                    this.metroCmbType.Text.Trim(),
                    "",
                    "",
                    "",
                    "",
                    0,
                    "",
                    "",
                    "",
                    false,
                    "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();



                    this.MatTxtName.Focus();
                    return;
                }
                else
                {
                    this.MetroSave();

                }



            }
            else
            {

                if (this.TblCustomersEntity.Cust_Name == this.MatTxtName.Text)
                {

                }
                else
                {
                    this.dSet.Clear();
                    this.dSet = g_objStoredProcCollection.sp_tblCustomers(0,
                        this.MatTxtName.Text.Trim(),
                        this.metroCmbType.Text.Trim(),
                        "",
                        "",
                        "",
                        "",
                        0,
                        "",
                        "",
                        "",
                        false,
                        "getbyname");

                    if (dSet.Tables[0].Rows.Count > 0)
                    {
                        this.GlobalStatePopup.DataAlreadyExist();



                        this.MatTxtName.Focus();
                        return;
                    }
                }



                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.TblCustomersRepositorys
                        .PutCustomer(
                        this.TblCustomersEntity.Cust_Id,
                        this.MatTxtName.Text,
                        this.metroCmbType.Text,
                        this.metroCmbCompany.Text,
                        this.TxtMobile.Text,
                        this.TxtLeadMan.Text,
                        this.TxtAddress.Text,
                       TblCustomersEntity.Cust_Added_By,
                        "",
                        TblCustomersEntity.Cust_Updated_by,
                        "",
                        true,
                        "edit");
                    this.GlobalStatePopup.UpdatedSuccessfully();
                    this.Close();
                }
                else
                {
                    return;
                }



            }





        }


        private void MetroSave()
        {

            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save a new data? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.TblCustomersRepositorys
                    .AddCustomer(
                    0, 
                    this.MatTxtName.Text,
                    this.metroCmbType.Text, 
                    this.metroCmbCompany.Text, 
                    this.TxtMobile.Text, 
                    this.TxtLeadMan.Text, 
                    this.TxtAddress.Text,
                   TblCustomersEntity.Cust_Added_By,
                    "",
                    userinfo.user_id.ToString(),
                    "",
                    true, 
                    "add");
                this.GlobalStatePopup.UpdatedSuccessfully();
                this.Close();
            }
            else
            {
                return;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void frmNewCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.textBox1.Text = "FormClosed";
        }

        private void matTxtLeadMan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtMatAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void MatTxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
