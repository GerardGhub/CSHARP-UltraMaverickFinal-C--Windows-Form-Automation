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

namespace ULTRAMAVERICK.Forms.Users
{
    public partial class frmDepartment : Form
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;

        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        myglobal pointer_module = new myglobal();
        DateTime dNow = DateTime.Now;
        string mode = "";
        DataSet dSet = new DataSet();
        Boolean ready = false;
        int temp_id = 0;
        DataSet dSet_temp = new DataSet();
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class

            getAllDepartment(); // all Department Management
            lstDepartment_Click(sender, e); // Click Thge ListView
            myglobal.global_module = "Active"; // Mode for Searching
            load_search(); //Bind the Information
            HideDataGrid(); // Hide the DataGrid
            LoadLocation(); // Loading the Depeartment
        }

        DataSet dset_emp = new DataSet();
        void doSearch()
        {
            try
            {
                if (dset_emp.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp.Tables[0]);
                    if (myglobal.global_module == "EMPLOYEE")
                    {

                    }
                    else if (myglobal.global_module == "Active")
                    {

                        dv.RowFilter = "department_name like '%" + txtdepartment.Text + "%'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dgv_table.DataSource = dv;
                    //lblrecords.Text = dgv_table.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdepartment.Focus();
                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdepartment.Focus();
                return;
            }
        }
        public void load_search()
        {
            dset_emp.Clear();

            if (myglobal.global_module == "EMPLOYEE")
            { dset_emp = objStorProc.sp_getMajorTables("employee"); }
     
            else if (myglobal.global_module == "Active")
            { dset_emp = objStorProc.sp_getMajorTables("departmentcurrentcellchanged"); }
            else if (myglobal.global_module == "InActive")
            { dset_emp = objStorProc.sp_getMajorTables("InactiveFeedCode"); }
          

            doSearch();

        }

        public void HideDataGrid()
        {
            dgv_table.Visible = false;
        }


        private void getAllDepartment()
        {
            ready = false;
            myClass.fillListBox(lstDepartment, "department", dSet);
            ready = true;
            lbltotalrecords.Text = lstDepartment.Items.Count.ToString();
        }

        private void BtnModuleClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DepartmentAlreadyTaken()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Department Already Exist!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Red;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }

        public bool saveMode()
        {
            if (mode == "add")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_department(0,
                    txtdepartment.Text.Trim(), "", "", "", "", "", "", "validate");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    DepartmentAlreadyTaken();
                    txtdepartment.Focus();
                    return false;
                }
                else
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_department(0,
                    txtdepartment.Text.Trim(),
                    txtCreatedBy.Text.Trim(),
                    txtCreatedAt.Text.Trim(),
                    txtModifiedAt.Text.Trim(),
                    txtModifiedBy.Text.Trim(),
                    txtCreatedByAndUserID.Text.Trim(),
                    lblLocationID.Text.Trim(),
                    "add");

                    return true;
                }

            }

            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_position(temp_id,
                    txtdepartment.Text.Trim(), "",
                    txtCreatedByAndUserID.Text.Trim(), "", "", "", "", "getbyname");

                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_department(temp_id, txtdepartment.Text.Trim(), "", "", "", "", "", "", "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == temp_id)
                    {
                        dSet.Clear();
                        dSet = g_objStoredProcCollection.sp_department(temp_id,
                            txtdepartment.Text.Trim(), 
                            txtCreatedBy.Text.Trim(),
                            txtCreatedAt.Text.Trim(),
                            txtModifiedAt.Text.Trim(),
                            txtModifiedBy.Text.Trim(),
                            txtCreatedByAndUserID.Text.Trim(),
                            lblLocationID.Text.Trim(),
                            "edit");

                        return true;
                       
                    }
                    else
                    {
                        DepartmentAlreadyTaken();
                        txtdepartment.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_department(temp_id,
                        txtdepartment.Text.Trim(),
                        txtCreatedBy.Text.Trim(),
                        txtCreatedAt.Text.Trim(),
                        txtModifiedAt.Text.Trim(),
                        txtModifiedBy.Text.Trim(),
                        txtCreatedByAndUserID.Text.Trim(),
                        lblLocationID.Text.Trim(),
                        "edit");
                    return true;
                }
            }
            else if (mode == "delete")
            {
                dSet.Clear();


                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_department(temp_id, "", "", "", "", "", "", "", "delete");

                return true;
            }

            return false;
        }


        private void btnAddTool_Click(object sender, EventArgs e)
        {
            mode = "add";
            btnUpdateTool.Visible = true;
            btnAddTool.Visible = false;

            lstDepartment.Enabled = false;

            txtdepartment.Enabled = true;
            txtdepartment.Text = string.Empty;
            btnCancelTool.Visible = true;


            txtCreatedAt.Text = (dNow.ToString("M/d/yyyy"));
            txtCreatedBy.Text = userinfo.emp_name.ToUpper();
            txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            btnUpdateTool.Visible = true;
            btnEditTool.Visible = false;
             cboLocation.Enabled = true;
            LoadLocation();
            txtdepartment.Focus();
        }

        private void LoadLocation()
        {
            ready = false;
            myClass.fillComboBoxDepartment(cboLocation, "location_dropdown", dSet);
            ready = true;
        }

        private void btnUpdateTool_Click(object sender, EventArgs e)
        {
            metroButtonSave_Click(sender, e);
        }
        public void SaveSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Successfully Save";
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
        public void FillRequiredTextbox()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "FILL UP THE REQUIRED FIELDS";
            popup.ContentColor = Color.Black;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Red;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }
        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Save the New Department " + txtdepartment.Text + "", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (txtdepartment.Text.Trim() == "")
                {


                    FillRequiredTextbox();
                    txtdepartment.BackColor = Color.Yellow;
                    txtdepartment.Focus();
                    return;
                }



                else
                {
                    if (saveMode())
                    {
                        getAllDepartment();
                        if (lstDepartment.Items.Count > 0)
                        {
                            int index = lstDepartment.FindString(txtModifiedAt.Text, 0);
                            if (index == -1) { index = 0; }
                            lstDepartment.SelectedIndex = index;
                        }

                        mode = "";
                        SaveSuccessfully();
                        frmDepartment_Load(sender, e);
                        btnUpdateTool.Visible = false;
                        btnAddTool.Visible = true;
                        btnCancelTool.Visible = false;
                        lstDepartment.Enabled = true;
                        btnEditTool.Visible = true;
                        btnDeleteTool.Visible = true;
                        cboLocation.Enabled = false;
                        lstDepartment_Click(sender, e);
                    }
                }

                txtdepartment.Enabled = false;

            }
            else
            {

                return;
            }
        }

        private void lstDepartment_Click(object sender, EventArgs e)
        {
            doSearch();
            showvalue();
        }

        private void showvalue()
        {
            if (ready == true)
            {
                if (lstDepartment.Items.Count > 0)
                {
                    temp_id = Convert.ToInt32(lstDepartment.SelectedValue.ToString());
                    txtdepartment.Text = lstDepartment.Text;
                }

            }
        }

        private void btnDeleteTool_Click(object sender, EventArgs e)
        {
            metroButtonDelete_Click(sender, e);
        }

        public void DeletedSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Deleted Successfully";
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


        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Delete the Department Information ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (lstDepartment.Items.Count > 0)
                {

                    mode = "delete";
                    if (saveMode())
                    {
                        getAllDepartment();
                        if (lstDepartment.Items.Count > 0)
                        {
                            int index = lstDepartment.FindString(txtdepartment.Text, 0);
                            if (index == -1) { index = 0; }
                            lstDepartment.SelectedIndex = index;
                        }

                        mode = "";
                        lstDepartment.Enabled = true;
                        DeletedSuccessfully();
                        load_search();
                        doSearch();

                        btnEditTool.Visible = true;
                        lstDepartment_Click(sender, e);
                    }
                }
                //}

            }
            else
            {

                btnEditTool.Visible = true;
                return;
            }
        }

        private void btnEditTool_Click(object sender, EventArgs e)
        {
            lstDepartment.Enabled = false;

            if (lstDepartment.Items.Count > 0)
            {
                mode = "edit";
                txtdepartment.Enabled = true;
                txtdepartment.ReadOnly = false;

               



                btnEditTool.Visible = false;
                btnAddTool.Visible = false;
                btnCancelTool.Visible = true;
                btnDeleteTool.Visible = false;
                btnUpdateTool.Visible = true;
                cboLocation.Enabled = true;
                txtModifiedAt.Text = (dNow.ToString("M/d/yyyy"));
                txtModifiedBy.Text = userinfo.emp_name.ToUpper();
            }
        }

        private void btnCancelTool_Click(object sender, EventArgs e)
        {
           lstDepartment.Enabled = true;
            btnCancelTool.Visible = false;
            btnAddTool.Visible = true;
            txtdepartment.Enabled = false;
            btnUpdateTool.Visible = false;
            btnEditTool.Visible = true;
            btnDeleteTool.Visible = true;
            cboLocation.Enabled = false;
        }

        private void dgv_table_CurrentCellChanged(object sender, EventArgs e)
        {
            showDepartmentDetails();
        }
        private void showDepartmentDetails()
        {
            if (dgv_table.RowCount > 0)
            {
                if (dgv_table.CurrentRow != null)
                {
                    if (dgv_table.CurrentRow.Cells["department_name"].Value != null)
                    {


                        txtdepartment.Text = dgv_table.CurrentRow.Cells["department_name"].Value.ToString();
                        cboLocation.Text = dgv_table.CurrentRow.Cells["location_id"].Value.ToString();
                        txtCreatedBy.Text = dgv_table.CurrentRow.Cells["created_by"].Value.ToString();
                        txtCreatedAt.Text = dgv_table.CurrentRow.Cells["created_at"].Value.ToString();

                        txtModifiedBy.Text = dgv_table.CurrentRow.Cells["updated_by"].Value.ToString();

                        txtModifiedAt.Text = dgv_table.CurrentRow.Cells["updated_at"].Value.ToString();



                    }

                }
            }
        }

        private void cboLocation_SelectedValueChanged(object sender, EventArgs e)
        {
            //lblLocationID.Text = cboLocation.SelectedValue.ToString();
        }

        private void lstDepartment_CursorChanged(object sender, EventArgs e)
        {
            doSearch();
            showvalue();
        }

        private void lstDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            doSearch();
            showvalue();
        }


        private void lstDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            doSearch();
            showvalue();
        }

        private void txtCreatedByAndUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboLocation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblLocationID.Text = cboLocation.SelectedValue.ToString();
        }
    }
}
