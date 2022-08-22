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

        string mode = "";
        int p_id = 0;

        DateTime dNow = DateTime.Now;



        DataSet dSet_temp = new DataSet();


        public frmCustomers()
        {
            InitializeComponent();
        }
        public string sp_created_at { get; set; }
        public string sp_created_by { get; set; }
        public string sp_modified_at { get; set; }
        public string sp_modified_by { get; set; }
        public string sp_bind_selected { get; set; }
        public string sp_user_id { get; set; }
        public string sp_area_name { get; set; }
        public string sp_typeof_mode { get; set; }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            this.ShowDataActivated();
            this.ConnetionString();
            myglobal.global_module = "Active"; // Mode for Searching


            //this.TblCustomerRepo.GetCustomerSearchMajor(TblCustomersEntity.TotalRecords);
            //this.lbltotalrecords.Text = TblCustomersEntity.TotalRecords.ToString();
            //this.SearchMethodJarVarCallingSP();
        }

        private void ConnetionString()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }
        private void ShowDataActivated()
        {
            this.matRadioActive.Checked = true;
        }


  

        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("MoveOrder_Customers_Active_Major");

        }

        private void dgvitemClass_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvCustomers.ClearSelection();
        }


      

    


        private void matRadioActive_CheckedChanged(object sender, EventArgs e)
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


                if (this.TblCustomerRepo.dSet.Tables.Count > 0)
                {
                    DataView dv = new DataView(this.TblCustomerRepo.dSet.Tables[0]);

                    if (myglobal.global_module == "Active")
                    {
                        dv.RowFilter = "cust_name like '%" + mattxtSearch.Text + "%' or cust_type like '%" + mattxtSearch.Text + "%' ";
                    }

                    this.dgvCustomers.DataSource = dv;
                    lbltotalrecords.Text = this.dgvCustomers.RowCount.ToString();
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
            if (sp_bind_selected == "1")
            {
                //this.SearchMethodJarVarCallingSP();
                this.TblCustomerRepo.GetCustomerSearchMajor(TblCustomersEntity.TotalRecords);
            }
            else
            {
                this.SearchMethodJarVarCallingSPInactive();
            }

        
            if (this.lbltotalrecords.Text == "0")
            {

            }
            else
            {
                if (mode == "add")
                {

                }
                else
                {
                    doSearchInTextBox();
                }

            }
            if (this.mattxtSearch.Text == String.Empty)
            {
                this.TblCustomerRepo.GetCustomer(dgvCustomers);
                this.lbltotalrecords.Text = this.dgvCustomers.RowCount.ToString();
            }
        }

        private void matBtnNew_Click(object sender, EventArgs e)
        {
            this.sp_typeof_mode = "add";

            matBtnNew.Visible = false;
            matBtnEdit.Visible = false;
           frmNewCustomer addNew = new frmNewCustomer(this, sp_user_id);
            addNew.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.TblCustomerRepo.GetCustomer(dgvCustomers);
            this.lbltotalrecords.Text = this.dgvCustomers.RowCount.ToString();
        }
    }
}
