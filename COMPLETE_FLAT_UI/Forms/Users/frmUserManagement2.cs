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
using System.IO;
using ULTRAMAVERICK.API.Entities;

namespace ULTRAMAVERICK.Forms.Users
{
    public partial class frmUserManagement2 : MaterialForm
    {
        readonly myclasses myClass = new myclasses();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        IStoredProcedures g_objStoredProcCollection = null;
        DataSet dSet_temp = new DataSet();
        int temp_id = 0;
        readonly UserFile UserFileEntity = new UserFile();
        DataSet dSet = new DataSet();
        string mode = "";


        public frmUserManagement2()
        {
            InitializeComponent();
        }
  
 
        private void ConnectionInit()
        {
            this.g_objStoredProcCollection = 
            this.myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }

        private void frmUserManagement2_Load(object sender, EventArgs e)
        {

            this.ConnectionInit();

            this.DisplayUsers();
            this.matRadioActive.Checked = true;
            this.StringEmpty();
 
            this.MatRadioActive_CheckedChanged(sender, e);
        }
 
        public void StringEmpty()
        {
            this.textBox1.Text = String.Empty;
            this.textBox2.Text = String.Empty;
        }


        public void load_search()
        {
            try
            {
                if (this.matRadioActive.Checked == true)
                {

                    this.dset_emp.Clear();
                    this.dset_emp = g_objStoredProcCollection.sp_getMajorTables("usercurrentcellchanged");
                }
                else
                {

                    this.dset_emp.Clear();
                    this.dset_emp = g_objStoredProcCollection.sp_getMajorTables("InactiveUserCurrentCellChanged");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



             
               
        }
        DataSet dset_emp = new DataSet();
        public void doSearchOnMaterialTextBox()
        {
            try
            {
                if (dset_emp.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp.Tables[0]);
              

                        dv.RowFilter = "employee_name like '%" + mattxtSearch.Text + "%'";

              
                    dgvUsers.DataSource = dv;
                    lbltotalrecords.Text = dgvUsers.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtuser.Focus();
                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtuser.Focus();
                return;
            }
        }
   
        public void DisplayUsers()     
        {

            this.myClass.fillDataGridView(this.dgvUsers, "usercurrentcellchangedminor", dSet);
            this.lbltotalrecords.Text = this.dgvUsers.RowCount.ToString();
        }

        public void InactiveDisplayUsers()
        {

            this.myClass.fillDataGridView(this.dgvUsers, "Inactiveusercurrentcellchangedminor", dSet);
            this.lbltotalrecords.Text = this.dgvUsers.RowCount.ToString();
        }

        private void DgvUsers_CurrentCellChanged(object sender, EventArgs e)
        {
            showActiveUser();

            UserFileEntity.Employee_Name = UserFileEntity.Employee_Name;
            UserFileEntity.Employee_LastName = UserFileEntity.Employee_LastName;
            UserFileEntity.User_Rights_Name = UserFileEntity.User_Rights_Name;
            UserFileEntity.UserName = UserFileEntity.UserName;
            UserFileEntity.Password = UserFileEntity.Password;
            UserFileEntity.Department = UserFileEntity.Department;
            UserFileEntity.Position = UserFileEntity.Position;
            UserFileEntity.Unit = UserFileEntity.Unit;
            UserFileEntity.User_Section = UserFileEntity.User_Section;
            UserFileEntity.Gender = UserFileEntity.Gender;
            UserFileEntity.Receiving_Status = UserFileEntity.Receiving_Status;
        }

        public void showActiveUser()
        {

            if (dgvUsers.RowCount > 0)
            {
                if (dgvUsers.CurrentRow != null)
                {
                    if (dgvUsers.CurrentRow.Cells["username"].Value != null)
                    {

                       temp_id = Convert.ToInt32(dgvUsers.CurrentRow.Cells["userfile_id"].Value.ToString());
                        UserFileEntity.Employee_Name = this.dgvUsers.CurrentRow.Cells["employee_name"].Value.ToString();
                        UserFileEntity.Employee_LastName = this.dgvUsers.CurrentRow.Cells["employee_lastname"].Value.ToString();
                        UserFileEntity.User_Rights_Name = this.dgvUsers.CurrentRow.Cells["user_rights_name"].Value.ToString();
                        UserFileEntity.UserName = this.dgvUsers.CurrentRow.Cells["username"].Value.ToString();
                        UserFileEntity.Password = this.dgvUsers.CurrentRow.Cells["password"].Value.ToString();
                        UserFileEntity.Position = this.dgvUsers.CurrentRow.Cells["Position"].Value.ToString();
                        UserFileEntity.User_Section = this.dgvUsers.CurrentRow.Cells["user_section"].Value.ToString();
                        UserFileEntity.Unit = this.dgvUsers.CurrentRow.Cells["Unit"].Value.ToString();
                        UserFileEntity.Receiving_Status  = this.dgvUsers.CurrentRow.Cells["receiving_status"].Value.ToString();
                        UserFileEntity.Department = this.dgvUsers.CurrentRow.Cells["department_name"].Value.ToString();
                        UserFileEntity.Gender = dgvUsers.CurrentRow.Cells["gender"].Value.ToString();
                        if (this.lblGenderSelected.Text == "Male")
                        {
                            this.matRadioMale.Checked = true;
                        }
                        else if (this.lblGenderSelected.Text == "Female")
                        {
                            this.matRadioFemale.Checked = true;
                        }
                        else
                        {
                            this.matRadioFemale.Checked = false;
                            this.matRadioMale.Checked = false;
                        }

                    }

                }
            }

        }

        private void mattxtSearch_TextChanged(object sender, EventArgs e)
        {
            if(this.mattxtSearch.Text == String.Empty)
            {
                this.DisplayUsers();
            }
            else
            {
                doSearchOnMaterialTextBox();
            }
        }


        private void btnAddTool_Click(object sender, EventArgs e)
        {
            this.toolStrip2.Visible = false;
           frmAddnewUserModal addNew = new frmAddnewUserModal(
               this,
               "Add",
               UserFileEntity.Employee_Name,
               UserFileEntity.Employee_LastName,
               UserFileEntity.User_Rights_Name,
               UserFileEntity.UserName,
               UserFileEntity.Password,
               UserFileEntity.Department,
               UserFileEntity.Position,
               UserFileEntity.Unit,
               UserFileEntity.User_Section,
               UserFileEntity.Receiving_Status,
               UserFileEntity.Gender,
               temp_id
               );
            addNew.ShowDialog();
        }

        public void ActivitiesLogs(string logs)
        {

            try
            {
                const string location = @"aActivities";

                if (!File.Exists(location))
                {
                    var createText = "New Activities Logs" + Environment.NewLine;
                    File.WriteAllText(location, createText);
                }
                var appendLogs = "Activities Logs: " + logs + " " + DateTime.Now + Environment.NewLine;
                File.AppendAllText(location, appendLogs);
            }
            catch (Exception ex)
            {
                const string location = @"aActivities";
                if (!File.Exists(location))
                {
                    TextWriter file = File.CreateText(@"C:\aActivities");
                    var createText = "New Activities Logs" + Environment.NewLine;

                    File.WriteAllText(location, createText);

                }
                var appendLogs = ex.Message + logs + DateTime.Now + Environment.NewLine;
                File.AppendAllText(location, appendLogs);

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "SaveGerardSingian")
            {

                if (this.lbltotalrecords.Text == "0")
                {

                }
                else
                {
                    this.toolStrip2.Visible = true;
                }

    
                this.frmUserManagement2_Load(sender, e);
        

            }


        }
       
        public bool saveMode()
        {
            if (mode == "delete")
            {



                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_userfile(temp_id, "", "", "", "delete");

             
            }
            else if (mode == "activate")
            {
                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_userfile(temp_id, "", "", "", "activate");

            }
            return true;
        }

        private void btnDeleteTool_Click(object sender, EventArgs e)
        {
            toolStrip2.Visible = false;

            if (this.matRadioActive.Checked == true)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to deactivate?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (dgvUsers.Rows.Count > 0)
                    {

                        mode = "delete";
                        if (saveMode())
                        {




                            mode = "";
                            this.GlobalStatePopup.InactiveSuccessfully();
                            toolStrip2.Visible = true;
                            frmUserManagement2_Load(sender, e);



                        }
                    }
                    

                }
                else
                {

                    toolStrip2.Visible = true;
                    return;
                }
            }


            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to activate ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (dgvUsers.Rows.Count > 0)
                    {

                        mode = "activate";
                        if (saveMode())
                        {




                            mode = "";
                            this.GlobalStatePopup.ActivatedSuccessfully();
                            this.toolStrip2.Visible = true;
                            this.frmUserManagement2_Load(sender, e);



                        }
                    }
                    

                }
                else
                {

                    this.toolStrip2.Visible = true;
                    return;
                }
            }

        }


   
        private void btnEditTool_Click(object sender, EventArgs e)
        {
                  
            toolStrip2.Visible = false;
            frmEditUser addNew = new frmEditUser(
               this,
               UserFileEntity.Employee_Name,
               UserFileEntity.Employee_LastName,
               UserFileEntity.User_Rights_Name,
               UserFileEntity.UserName,
               UserFileEntity.Password,
               UserFileEntity.Department,
               UserFileEntity.Position,
               UserFileEntity.Unit,
               UserFileEntity.User_Section,
               UserFileEntity.Receiving_Status,
               UserFileEntity.Gender,
                temp_id);
            addNew.ShowDialog();
        }

        private void dgvUsers_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //var grid = sender as DataGridView;
            //var rowIdx = (e.RowIndex + 1).ToString();

            //var centerFormat = new StringFormat()
            //{
            //    // right alignment might actually make more sense for numbers
            //    Alignment = StringAlignment.Center,
            //    LineAlignment = StringAlignment.Center
            //};

            //var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            //e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);





        }

        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check the value of the e.ColumnIndex property if you want to apply this formatting only so some rcolumns.
            if (e.Value != null)
            {
                e.Value = e.Value.ToString().ToUpper();
                e.FormattingApplied = true;
            }
        }



        private void MattxtSearch_TextChanged_1(object sender, EventArgs e)
        {
               this.load_search();
                this.doSearchOnMaterialTextBox();
            
          

        }

        private void MatRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioActive.Checked == true)
            {
         
                this.BtnInactive.Text = "&InActive";


                this.ConnectionInit();
                this.DisplayUsers();


            }
            else if (matRadioNotActive.Checked == true)
            {
            
                this.BtnInactive.Text = "&Activate";

                this.ConnectionInit();
                this.InactiveDisplayUsers();

            }
            else
            {

            }

        }

        private void MatRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioActive.Checked == true)
            {

                this.BtnInactive.Text = "&InActive";


                this.ConnectionInit();
                this.DisplayUsers();


            }
            else if (matRadioNotActive.Checked == true)
            {

                this.BtnInactive.Text = "&Activate";

                this.ConnectionInit();
                this.InactiveDisplayUsers();

            }
            else
            {

            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox2.Text == "SaveGerardSingian")
            {
                this.toolStrip2.Visible = true;
                this.frmUserManagement2_Load(sender, e);
            }
        }

        private void MattxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
