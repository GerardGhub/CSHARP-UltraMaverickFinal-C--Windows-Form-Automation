using COMPLETE_FLAT_UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;
using MaterialSkin;
using MaterialSkin.Controls;
using ULTRAMAVERICK.Forms.Users.Modal;
using ULTRAMAVERICK.API.Entities;

namespace ULTRAMAVERICK.Forms.Users
{
    public partial class frmDepartment : MaterialForm
    {
        readonly myclasses myClass = new myclasses();
        private IStoredProcedures g_objStoredProcCollection = null;
        DateTime dNow = DateTime.Now;
        string mode = "";
        DataSet dSet = new DataSet();
        DataSet dSet_temp = new DataSet();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        readonly Department DeptEntity = new Department();

        public frmDepartment()
        {
            InitializeComponent();
        }
        public string sp_location_id { get; set; }

        public void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }
        private void frmDepartment_Load(object sender, EventArgs e)
        {

            this.ConnectionInit();

            this.getAllDepartment(); 

            myglobal.global_module = "Active";

            this.getRadionDataChanged();
            this.textBox1.Text = String.Empty;
        }

        private void getRadionDataChanged()
        {
            this.matRadioActive.Checked = true;

        }

        DataSet dset_emp = new DataSet();
        public void doSearch()
        {
            try
            {
                if (dset_emp.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp.Tables[0]);
            

                        dv.RowFilter = "department_name like '%" + this.mattxtSearch.Text + "%'";

                    this.DgvDepartment.DataSource = dv;
                    this.lbltotalrecords.Text = DgvDepartment.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
        }
        public void load_search()
        {
            dset_emp.Clear();

            if (this.matRadioActive.Checked == true)
            {
                dset_emp = g_objStoredProcCollection.sp_getMajorTables("departmentcurrentcellchanged");
            }

              else
            {
                dset_emp = g_objStoredProcCollection.sp_getMajorTables("departmentcurrentcellchangedinactive");
            }


            doSearch();
            this.DgvDepartment.Columns["is_active"].Visible = false;

        }

  


        private void getAllDepartment()
        {


            try
            {

                this.myClass.fillDataGridView(DgvDepartment, "Department_Active", this.dSet);

                this.lbltotalrecords.Text = DgvDepartment.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void getAllDepartmentInactive()
        {


            try
            {

                this.myClass.fillDataGridView(DgvDepartment, "Department_InActive", this.dSet);

                this.lbltotalrecords.Text = DgvDepartment.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnModuleClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }







        private void btnUpdateTool_Click(object sender, EventArgs e)
        {
            metroButtonSave_Click(sender, e);
        }

        private void metroButtonSave_Click(object sender, EventArgs e)
        {

        }

        private void lstDepartment_Click(object sender, EventArgs e)
        {
            if (mode == "add")
            {
              
            }
            else
            {
                doSearch();
         
            }
        }



        private void btnDeleteTool_Click(object sender, EventArgs e)
        {
            metroButtonDelete_Click(sender, e);
        }




        private void metroButtonDelete_Click(object sender, EventArgs e)
        {

            if (this.matRadioActive.Checked == true)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to inactive?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (Convert.ToInt32(this.lbltotalrecords.Text) > 0)
                    {


                        dSet_temp.Clear();
                        dSet_temp = g_objStoredProcCollection.sp_department(this.DeptEntity.Department_Id, 
                            "", 
                            "", 
                            "", 
                            "", 
                            userinfo.user_id.ToString(), 
                            "",
                            "", 
                            "delete");
                        this.GlobalStatePopup.InactiveSuccessfully();
                        this.frmDepartment_Load(sender, e);
                    }


                }
                else
                {

                    btnEditTool.Visible = true;
                    return;
                }

            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to activate ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (Convert.ToInt32(this.lbltotalrecords.Text) > 0)
                    {


                        dSet_temp.Clear();
                        dSet_temp = g_objStoredProcCollection.sp_department(this.DeptEntity.Department_Id, 
                            "", 
                            "", 
                            "", 
                            "",
                                       userinfo.user_id.ToString(),
                            "",
                            "",
                            "activate");
                        this.GlobalStatePopup.ActivatedSuccessfully();
                        this.frmDepartment_Load(sender, e);
                    }


                }
                else
                {

                    btnEditTool.Visible = true;
                    return;
                }

            }
        }

  

       

   






        private void neww_Click(object sender, EventArgs e)
        {
            mode = "ADD";
            btnUpdateTool.Visible = true;
            btnAddTool.Visible = false;
            btnDeleteTool.Visible = false;
    


            btnCancelTool.Visible = true;


            btnUpdateTool.Visible = true;
            btnEditTool.Visible = false;


                FrmAddNewDepartment addNew = new FrmAddNewDepartment(this,
                userinfo.user_id,
                "ADD", 
                this.DeptEntity.Department_Id, 
                this.DeptEntity.Department_Name
                );
                addNew.ShowDialog();


        }

        private void editt_Click(object sender, EventArgs e)
        {


            if (Convert.ToInt32(this.lbltotalrecords.Text) > 0)
            {
                mode = "edit";



                btnEditTool.Visible = false;
                btnAddTool.Visible = false;
                btnCancelTool.Visible = true;
                btnDeleteTool.Visible = false;
                btnUpdateTool.Visible = true;


                FrmAddNewDepartment addNew = new FrmAddNewDepartment(this,
                userinfo.user_id,
                "EDIT", 
                this.DeptEntity.Department_Id, 
                this.DeptEntity.Department_Name
                );
                addNew.ShowDialog();


            }
        }

        private void cancels_Click(object sender, EventArgs e)
        {

            btnCancelTool.Visible = false;
            btnAddTool.Visible = true;
            btnUpdateTool.Visible = false;
            btnEditTool.Visible = true;
            btnDeleteTool.Visible = true;
          
        }

        private void removee_Click(object sender, EventArgs e)
        {
            metroButtonDelete_Click(sender, e);
        }

        private void savee_Click(object sender, EventArgs e)
        {
            metroButtonSave_Click(sender, e);
        }

        private void txtdepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cancels_Click(sender, e);
            frmDepartment_Load(sender, e);
        }

        private void DgvDepartment_CurrentCellChanged(object sender, EventArgs e)
        {
            this.showDepartmentDetails();
        }

        private void showDepartmentDetails()
        {
            if (DgvDepartment.RowCount > 0)
            {
                if (DgvDepartment.CurrentRow != null)
                {
                    if (DgvDepartment.CurrentRow.Cells["department_name"].Value != null)
                    {
                        this.DeptEntity.Department_Id = Convert.ToInt32(DgvDepartment.CurrentRow.Cells["department_id"].Value);
                        this.DeptEntity.Department_Name = DgvDepartment.CurrentRow.Cells["department_name"].Value.ToString();                       
                    }

                }
            }
        }

        private void mattxtSearch_TextChanged(object sender, EventArgs e)
        {           
            this.load_search();
        }

        private void MatRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                this.btnDeleteTool.Text = "&InActive";
                this.ConnectionInit();
                this.getAllDepartment(); 
            }
            else
            {
                this.ConnectionInit();
                this.getAllDepartmentInactive();
            }
        }

        private void MatRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                this.ConnectionInit();
                this.getAllDepartment();
            }
            else
            {
                this.btnDeleteTool.Text = "&Activate";
                this.ConnectionInit();
                this.getAllDepartmentInactive();
            }
        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mattxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
