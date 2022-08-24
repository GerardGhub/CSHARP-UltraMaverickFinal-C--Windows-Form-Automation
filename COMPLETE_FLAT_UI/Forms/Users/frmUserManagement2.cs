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
        myclasses myClass = new myclasses();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        IStoredProcedures g_objStoredProcCollection = null;
        UserFile User = new UserFile();
        DataSet dSet_temp = new DataSet();
        int temp_id = 0;

        Boolean ready = false;
        DataSet dSet = new DataSet();
        string mode = "";
        public frmUserManagement2()
        {
            InitializeComponent();
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string RightsName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Department { get; set; }
        public string Positionx { get; set; }
        public string Unitx { get; set; }
        public string UserSection { get; set; }
        public string ReceivingStatus { get; set; }
        public string Gender { get; set; }



        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }
        private void frmUserManagement2_Load(object sender, EventArgs e)
        {

            this.ConnectionInit();


            this.displayUsers();
            this.matRadioActive.Checked = true;
            this.textBox1.Text = String.Empty;
            matRadioActive_CheckedChanged(sender, e);
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
        public void FormClose()
        {
            this.Close();
        }
        public void displayUsers()     
        {

            this.myClass.fillDataGridView(this.dgvUsers, "usercurrentcellchangedminor", dSet);
            this.lbltotalrecords.Text = this.dgvUsers.RowCount.ToString();
        }

        public void InactiveDisplayUsers()
        {

            this.myClass.fillDataGridView(this.dgvUsers, "Inactiveusercurrentcellchangedminor", dSet);
            this.lbltotalrecords.Text = this.dgvUsers.RowCount.ToString();
        }

        private void dgvUsers_CurrentCellChanged(object sender, EventArgs e)
        {
            showActiveUser();

            Name = User.Employee_Name;
            LastName = User.Employee_Name;
            RightsName = User.User_Rights_Name;
            UserName = User.UserName;
            Password = User.Password;
            Department = User.Department;
            Positionx = User.Position;
            Unitx = User.Unit;
            UserSection = User.User_Section;
            Gender = User.Gender;
            ReceivingStatus = User.Receiving_Status;
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
                       User.Employee_Name = this.dgvUsers.CurrentRow.Cells["employee_name"].Value.ToString();
                       User.Employee_LastName = this.dgvUsers.CurrentRow.Cells["employee_lastname"].Value.ToString();
                       User.User_Rights_Name = this.dgvUsers.CurrentRow.Cells["user_rights_name"].Value.ToString();
                       User.UserName = this.dgvUsers.CurrentRow.Cells["username"].Value.ToString();
                       User.Password = this.dgvUsers.CurrentRow.Cells["password"].Value.ToString();
                       User.Position = this.dgvUsers.CurrentRow.Cells["Position"].Value.ToString();
                       User.User_Section = this.dgvUsers.CurrentRow.Cells["user_section"].Value.ToString();
                       User.Unit = this.dgvUsers.CurrentRow.Cells["Unit"].Value.ToString();
                       User.Receiving_Status  = this.dgvUsers.CurrentRow.Cells["receiving_status"].Value.ToString();                   
                       User.Department = this.dgvUsers.CurrentRow.Cells["department_name"].Value.ToString();
                       User.Gender = dgvUsers.CurrentRow.Cells["gender"].Value.ToString();
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
            if(mattxtSearch.Text == String.Empty)
            {
                displayUsers();
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
               User.Employee_Name,
               User.Employee_LastName,
               User.User_Rights_Name,
               User.UserName,
               User.Password,
               User.Department,
               User.Position,
               User.Unit,
               User.User_Section,
               User.Receiving_Status,
               User.Gender,
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

                //this.ConnectionINit();
                this.displayUsers();

                this.textBox1.Text = String.Empty;
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
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to deactivate ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                    //}

                }
                else
                {

                    toolStrip2.Visible = true;
                    return;
                }
            }


            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to deactivate ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (dgvUsers.Rows.Count > 0)
                    {

                        mode = "activate";
                        if (saveMode())
                        {




                            mode = "";
                            this.GlobalStatePopup.ActivatedSuccessfully();
                            toolStrip2.Visible = true;
                            frmUserManagement2_Load(sender, e);



                        }
                    }
                    //}

                }
                else
                {

                    toolStrip2.Visible = true;
                    return;
                }
            }

        }


   
        private void btnEditTool_Click(object sender, EventArgs e)
        {
   
                
            toolStrip2.Visible = false;
            frmEditUser addNew = new frmEditUser(
               this,
               Name,
               LastName,
               RightsName,
               UserName,
               Password,
               Department,
               Positionx,
               Unitx,
               UserSection,
               ReceivingStatus,
               User.Gender,
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.toolStrip2.Visible = false;
            frmAddnewUserModal addNew = new frmAddnewUserModal(
                this,
                "Edit",
                User.Employee_Name,
                User.Employee_LastName,
                User.User_Rights_Name,
                User.UserName,
                User.Password,
                User.Department,
                User.Position,
                User.Unit,
                User.User_Section,
                User.Receiving_Status,
                User.Gender,
                temp_id
                );
            addNew.ShowDialog();
        }

        private void mattxtSearch_TextChanged_1(object sender, EventArgs e)
        {
               this.load_search();
                doSearchOnMaterialTextBox();
            
          

        }

        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioActive.Checked == true)
            {
         
                this.BtnInactive.Text = "&InActive";


                this.ConnectionInit();
                this.displayUsers();


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

        private void matRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioActive.Checked == true)
            {

                this.BtnInactive.Text = "&InActive";


                this.ConnectionInit();
                this.displayUsers();


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
    }
}
