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

namespace ULTRAMAVERICK.Forms.Users
{
    public partial class frmUserManagement2 : MaterialForm
    {
        //Main Constructor Bugok
        myclasses xClass = new myclasses();

        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        DataSet dSet_temp = new DataSet();
        int temp_id = 0;

        Boolean ready = false;
        DataSet dSet = new DataSet();
        string mode = "";
        public frmUserManagement2()
        {
            InitializeComponent();
        }
        public string sp_first_name { get; set; }
        public string sp_last_name { get; set; }
        public string sp_user_rights { get; set; }
        public string sp_username { get; set; }
        public string sp_password { get; set; }
        public string sp_department { get; set; }
        public string sp_position { get; set; }
        public string sp_unit { get; set; }
        public string sp_user_layout { get; set; }
        public string sp_requestor_type { get; set; }
        public string sp_receiving_status { get; set; }
        public string sp_gender { get; set; }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }
        private void frmUserManagement2_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class

            textBox1.Text = String.Empty;
            displayUsers();
            hiDeDatagridColumn();
            load_search();
        }

        private void  hiDeDatagridColumn()
        {
            //this.dgvUsers.Columns["user_rights_name"].Visible = false;
            //this.dgvUsers.Columns["password"].Visible = false;
            //this.dgvUsers.Columns["user_section"].Visible = false;
            //this.dgvUsers.Columns["receiving_status"].Visible = false;
            //this.dgvUsers.Columns["user_rights_name"].Visible = false;
            //this.dgvUsers.Columns["department_name"].Visible = false;
            //this.dgvUsers.Columns["type_of_approver"].Visible = false;
            //this.dgvUsers.Columns["gender"].Visible = false;
            //this.dgvUsers.Columns["Unit"].Visible = false;
        }

        public void load_search()
        {
            try
            {
                dset_emp.Clear();


                dset_emp = objStorProc.sp_getMajorTables("usercurrentcellchanged");
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
        private void displayUsers()     
        {
            ready = false;
            xClass.fillDataGridView(dgvUsers, "usercurrentcellchangedminor", dSet);
            ready = true;
            lbltotalrecords.Text = dgvUsers.RowCount.ToString();
        }

        private void dgvUsers_CurrentCellChanged(object sender, EventArgs e)
        {
            showActiveUser();
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
                       sp_first_name = dgvUsers.CurrentRow.Cells["employee_name"].Value.ToString();
                        sp_last_name = dgvUsers.CurrentRow.Cells["employee_lastname"].Value.ToString();
                      sp_user_rights = dgvUsers.CurrentRow.Cells["user_rights_name"].Value.ToString();
                  sp_username = dgvUsers.CurrentRow.Cells["username"].Value.ToString();
                        sp_password = dgvUsers.CurrentRow.Cells["password"].Value.ToString();
                       sp_position = dgvUsers.CurrentRow.Cells["Position"].Value.ToString();
                        sp_user_layout = dgvUsers.CurrentRow.Cells["user_section"].Value.ToString();
                        sp_unit = dgvUsers.CurrentRow.Cells["Unit"].Value.ToString();
                        sp_receiving_status = dgvUsers.CurrentRow.Cells["receiving_status"].Value.ToString();
                       sp_requestor_type = dgvUsers.CurrentRow.Cells["type_of_approver"].Value.ToString();
                       sp_department = dgvUsers.CurrentRow.Cells["department_name"].Value.ToString();
                        sp_gender = dgvUsers.CurrentRow.Cells["gender"].Value.ToString();
                        if (lblGenderSelected.Text == "Male")
                        {
                            matRadioMale.Checked = true;
                        }
                        else if (lblGenderSelected.Text == "Female")
                        {
                            matRadioFemale.Checked = true;
                        }
                        else
                        {
                            matRadioFemale.Checked = false;
                            matRadioMale.Checked = false;
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
            toolStrip2.Visible = false;
           frmAddnewUserModal addNew = new frmAddnewUserModal(this);
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
            if(this.textBox1.Text =="SaveGerardSingian")
            {
                if(this.lbltotalrecords.Text =="0")
                {

                }
                else
                {
                    this.toolStrip2.Visible = true;
                }

            
                this.displayUsers();
               
                this.textBox1.Text = String.Empty;
                this.frmUserManagement2_Load(sender, e);
            }
        }
        public void DeletedSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Removed Successfully";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Green;
            popup.Popup();

            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);

            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }
        public bool saveMode()
        {
            if (mode == "delete")
            {



                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_userfile(temp_id, "", "", "", "delete");

             
            }
            return true;
        }

        private void btnDeleteTool_Click(object sender, EventArgs e)
        {
            toolStrip2.Visible = false;
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Delete the User Information ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dgvUsers.Rows.Count > 0)
                {

                    mode = "delete";
                    if (saveMode())
                    {




                        mode = "";
                        DeletedSuccessfully();
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

        private void btnEditTool_Click(object sender, EventArgs e)
        {
            toolStrip2.Visible = false;
           frmEditUser addNew = new frmEditUser(this, sp_first_name , sp_last_name, sp_user_rights , sp_username
               ,sp_password , sp_department, sp_position, sp_unit, sp_user_layout, sp_requestor_type, sp_receiving_status,
               sp_gender, temp_id);
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
    }
}
