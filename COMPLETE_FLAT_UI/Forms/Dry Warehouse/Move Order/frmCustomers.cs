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
using ULTRAMAVERICK.Forms.Dry_Warehouse.Add_Modal;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Move_Order
{
    public partial class frmCustomers : MaterialForm
    {
        myclasses xClass = new myclasses();

        TblCustomersRepository TblCustomerRepo = new TblCustomersRepository();
        TblCustomers TblCustomersEntity = new TblCustomers();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        int dSetDynamic = 0;
        string mode = "";
        int p_id = 0;

        DateTime dNow = DateTime.Now;



        DataSet dSet_temp = new DataSet();


        public frmCustomers()
        {
            InitializeComponent();
        }

        public string sp_bind_selected { get; set; }
  



        private void FrmCustomers_Load(object sender, EventArgs e)
        {

            this.ConnetionString();
            this.ShowDataActivated();
            myglobal.global_module = "Active"; // Mode for Searching
            this.matRadioActive_CheckedChanged(sender, e);
            this.textBox1.Text = String.Empty;
            this.TblCustomersEntity.Cust_Added_By = userinfo.user_id;
 

        }

        private void ConnetionString()
        {
            this.g_objStoredProcCollection = this.myClass.g_objStoredProc.GetCollections(); 
        }
        private void ShowDataActivated()
        {
            this.matRadioActive.Checked = true;   
        }


  


        private void dgvitemClass_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvCustomers.ClearSelection();
        }

        private void matRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
            this.sp_bind_selected = "1";
            this.matBtnDelete.Text = "&InActive";


            this.TblCustomerRepo.GetCustomer(dgvCustomers);
            this.lbltotalrecords.Text = this.dgvCustomers.RowCount.ToString();

            }
            else if (matRadioNotActive.Checked == true)
            {
                this.sp_bind_selected = "0";
                this.matBtnDelete.Text = "&Activate";


                this.TblCustomerRepo.GetCustomerDeactivated(dgvCustomers);
                this.lbltotalrecords.Text = this.dgvCustomers.RowCount.ToString();
            }
            else
            {

            }
      
       
        }


        private void dgvitemClass_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.dgvCustomers.Rows.Count > 0)
            {
                if (this.dgvCustomers.CurrentRow != null)
                {
                    if (this.dgvCustomers.CurrentRow.Cells["cust_name"].Value != null)
                    {
                        this.p_id = Convert.ToInt32(this.dgvCustomers.CurrentRow.Cells["cust_id"].Value);
                        this.TblCustomersEntity.Cust_Name = this.dgvCustomers.CurrentRow.Cells["cust_name"].Value.ToString();
                        this.TblCustomersEntity.Cust_Type = this.dgvCustomers.CurrentRow.Cells["cust_type"].Value.ToString();
                        this.TblCustomersEntity.Cust_Company = this.dgvCustomers.CurrentRow.Cells["cust_company"].Value.ToString();
                        this.TblCustomersEntity.Cust_Mobile = Convert.ToInt32(this.dgvCustomers.CurrentRow.Cells["cust_mobile"].Value);
                        this.TblCustomersEntity.Cust_LeadMan = this.dgvCustomers.CurrentRow.Cells["cust_leadman"].Value.ToString();
                        this.TblCustomersEntity.Cust_Address = this.dgvCustomers.CurrentRow.Cells["cust_address"].Value.ToString();
                    }
                }
            }
        }

        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioActive.Checked == true)
            {
                this.sp_bind_selected = "1";
                this.matBtnDelete.Text = "&InActive";


                this.TblCustomerRepo.GetCustomer(dgvCustomers);
                this.lbltotalrecords.Text = this.dgvCustomers.RowCount.ToString();


            }
            else if (matRadioNotActive.Checked == true)
            {
                this.sp_bind_selected = "0";
                this.matBtnDelete.Text = "&Activate";
              
                this.TblCustomerRepo.GetCustomerDeactivated(dgvCustomers);
                this.lbltotalrecords.Text = this.dgvCustomers.RowCount.ToString();

            }
            else
            {

            }
        }
        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSPInactive()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            this.dset_emp_SearchEngines.Clear();
            this.dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("MoveOrder_Customers_InActive_Major");
        }

        private void doSearchInTextBox()
        {
           
            try
            {
             

                if (this.matRadioActive.Checked == true)
                {
                    this.dSetDynamic = this.TblCustomerRepo.dSet.Tables.Count;
                }
                else
                {
                    this.dSetDynamic = this.dset_emp_SearchEngines.Tables.Count;
                }

                if (this.dSetDynamic > 0)
                {

                    if (this.matRadioActive.Checked == true)
                    {

                        DataView dv = new DataView(this.TblCustomerRepo.dSet.Tables[0]);

                        dv.RowFilter = "cust_name like '%" + mattxtSearch.Text + "%' " +
                            "or cust_type like '%" + mattxtSearch.Text + "%' ";
                        this.dgvCustomers.DataSource = dv;

                    }
                    else
                    {
                        DataView dv = new DataView(this.dset_emp_SearchEngines.Tables[0]);

                        dv.RowFilter = "cust_name like '%" + mattxtSearch.Text + "%' " +
                            "or cust_type like '%" + mattxtSearch.Text + "%' ";
                        this.dgvCustomers.DataSource = dv;

                    }



          
                    this.lbltotalrecords.Text = this.dgvCustomers.RowCount.ToString();
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





        private void mattxtSearch_TextChanged(object sender, EventArgs e)
        {
         
            this.ConnetionString();
            if (this.matRadioActive.Checked == true)
            {
              
                this.TblCustomerRepo.GetCustomerSearchMajor(TblCustomersEntity.TotalRecords);
                this.doSearchInTextBox();
            }
            else
            {
                this.SearchMethodJarVarCallingSPInactive();
                this.doSearchInTextBox();
            }

            //    }

            //if (this.lbltotalrecords.Text == "0")
            //{

            //}
            //else
            //{
            //    if (mode == "add")
            //    {

            //    }
            //    else
            //    {
            //        doSearchInTextBox();
            //    }

            //}
            //if (this.mattxtSearch.Text == String.Empty)
            //{
            //    this.TblCustomerRepo.GetCustomer(dgvCustomers);
            //    this.lbltotalrecords.Text = this.dgvCustomers.RowCount.ToString();
            //}
        }

        private void matBtnNew_Click(object sender, EventArgs e)
        {
            this.TblCustomersEntity.Mode = "add";

            this.matBtnNew.Visible = false;
            this.matBtnEdit.Visible = false;
            this.matBtnCancel.Visible = true;
            frmNewCustomer addNew = new frmNewCustomer(this, 
            userinfo.user_id,
            "Add",
            this.TblCustomersEntity.Cust_Name,
            this.TblCustomersEntity.Cust_Type,
            this.TblCustomersEntity.Cust_Company,
            this.TblCustomersEntity.Cust_Mobile,
            this.TblCustomersEntity.Cust_LeadMan,
            this.TblCustomersEntity.Cust_Address,
            p_id
            );
            addNew.ShowDialog();
        }

 

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
         
            this.matBtnCancel_Click(sender, e);
            this.FrmCustomers_Load(sender, e);
        }

        private void matBtnCancel_Click(object sender, EventArgs e)
        {
            this.matBtnNew.Visible = true;
            this.matBtnEdit.Visible = true;
            this.matBtnCancel.Visible = false;
        }

        private void metroFinalSaving_Click(object sender, EventArgs e)
        {

        }

        private void matBtnDelete_Click(object sender, EventArgs e)
        {

            if (this.matRadioActive.Checked == true)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to deactivate? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.TblCustomerRepo.PutDeactivatedCustomer(
                        p_id,
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                       TblCustomersEntity.Cust_Added_By,
                        "",
                        "",
                        "",
                        false,
                        "delete");
                    this.GlobalStatePopup.UpdatedSuccessfully();
                    this.FrmCustomers_Load(sender, e);
                }
                else
                {
                    return;
                }

            }
            else
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to activate? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.TblCustomerRepo.PutActivatedCustomer(
                        p_id,
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                       TblCustomersEntity.Cust_Added_By,
                        "",
                        "",
                        "",
                        false,
                        "PutActivatedCustomer");
                    this.GlobalStatePopup.UpdatedSuccessfully();
                    this.FrmCustomers_Load(sender, e);
                }
                else
                {
                    return;
                }




            }


        }

        private void matBtnEdit_Click(object sender, EventArgs e)
        {
            frmNewCustomer addNew = new frmNewCustomer(this,
                userinfo.user_id,
                "Edit",
               this.TblCustomersEntity.Cust_Name,
               this.TblCustomersEntity.Cust_Type,
               this.TblCustomersEntity.Cust_Company,
               this.TblCustomersEntity.Cust_Mobile,
               this.TblCustomersEntity.Cust_LeadMan,
               this.TblCustomersEntity.Cust_Address,
               p_id
                );
            addNew.ShowDialog();
        }
    }
}
