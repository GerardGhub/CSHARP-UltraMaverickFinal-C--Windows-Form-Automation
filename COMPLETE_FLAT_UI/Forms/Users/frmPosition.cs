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
    public partial class frmPosition : Form
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
        public frmPosition()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPosition_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
         
            getAllPosition(); // all UserFile Management
            lstPosition_Click(sender, e); // Click Thge ListView
            myglobal.global_module = "Active"; // Mode for Searching
            load_search(); //Bind the Information
            HideDataGrid(); // Hide the DataGrid
            loadDepartment(); // Loading the Depeartment

        }


        public void loadDepartment()
        {
            ready = false;
            myClass.fillComboBoxDepartment(cbodepartment, "department_dropdown", dSet);
            ready = true;
     
            lblDepartmentID.Text = cbodepartment.SelectedValue.ToString();
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

                        dv.RowFilter = "position_name like '%" + txtname.Text + "%'";

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
                txtname.Focus();
                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtname.Focus();
                return;
            }
        }
        public void load_search()
        {
            dset_emp.Clear();

            if (myglobal.global_module == "EMPLOYEE")
            { dset_emp = objStorProc.sp_getMajorTables("employee"); }
            else if (myglobal.global_module == "MICRO")
            { dset_emp = objStorProc.sp_getMajorTables("micro_raw_materialsnew"); }
            else if (myglobal.global_module == "Active")
            { dset_emp = objStorProc.sp_getMajorTables("positioncurrentcellchanged"); }
            else if (myglobal.global_module == "InActive")
            { dset_emp = objStorProc.sp_getMajorTables("InactiveFeedCode"); }
            else if (myglobal.global_module == "MACRO")
            { dset_emp = objStorProc.sp_getMajorTables("macro_raw_materialsnew"); }
            else if (myglobal.global_module == "RESIGNED EMPLOYEE")
            { dset_emp = objStorProc.sp_getMajorTables("employee_B"); }
            else if (myglobal.global_module == "PHONEBOOK")
            { dset_emp = objStorProc.sp_getMajorTables("phonebook"); }
            else if (myglobal.global_module == "DA")
            { dset_emp = objStorProc.sp_getMajorTables("get_da"); }
            else if (myglobal.global_module == "ATTENDANCE")
            { dset_emp = objStorProc.sp_getMajorTables("attendance_monitoring"); }
            else if (myglobal.global_module == "VISITORS")
            { dset_emp = objStorProc.sp_getMajorTables("visitors"); }

            doSearch();

        }

        public void HideDataGrid()
        {
            dgv_table.Visible = false;
        }
        private void getAllPosition()
        {
            ready = false;
            myClass.fillListBox(lstPosition, "position", dSet);
            ready = true;
            lbltotalrecords.Text = lstPosition.Items.Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            mode = "add";
            btnUpdateTool.Visible = true;
            btnAddTool.Visible = false;
      
            lstPosition.Enabled = false;

            txtname.Enabled = true;
            txtname.Text = string.Empty;
            btnCancelTool.Visible = true;


            txtCreatedAt.Text = (dNow.ToString("M/d/yyyy"));
            txtCreatedBy.Text = userinfo.emp_name.ToUpper();
            txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            btnUpdateTool.Visible = true;
            btnEditTool.Visible = false;
            cbodepartment.Enabled = true;
            loadDepartment();
            txtname.Focus();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lstPosition.Enabled = true;
            btnCancelTool.Visible = false;
            btnAddTool.Visible = true;
            txtname.Enabled = false;
            btnUpdateTool.Visible = false;
            btnEditTool.Visible = true;
            btnDeleteTool.Visible = true;
            cbodepartment.Enabled = false;
        }

        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Save the New Position " + txtname.Text + "", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (txtname.Text.Trim() == "")
                {


                    FillRequiredTextbox();
                    txtname.BackColor = Color.Yellow;
                    txtname.Focus();
                    return;
                }
      

          
                else
                {
                    if (saveMode())
                    {
                        getAllPosition();
                        if (lstPosition.Items.Count > 0)
                        {
                            int index = lstPosition.FindString(txtModifiedAt.Text, 0);
                            if (index == -1) { index = 0; }
                            lstPosition.SelectedIndex = index;
                        }

                        mode = "";
                        SaveSuccessfully();
                        btnUpdateTool.Visible = false;
                        btnAddTool.Visible = true;
                        btnCancelTool.Visible = false;
                        lstPosition.Enabled = true;
                        btnEditTool.Visible = true;
                        btnDeleteTool.Visible = true;
                        cbodepartment.Enabled = false;
                        lstPosition_Click(sender, e);
                    }
                }
      
                txtname.Enabled = false;

            }
            else
            {

                return;
            }
        }
        public void PositionAlreadyTaken()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Position Already Exist!";
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

        public bool saveMode()
        {
            if (mode == "add")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_position(0, 
                    txtname.Text.Trim(), "", "","","","","", "validate");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    PositionAlreadyTaken();
                    txtname.Focus();
                    return false;
                }
                else
                {
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_position(0, 
                txtname.Text.Trim(), 
                lblDepartmentID.Text.Trim(), 
                txtCreatedBy.Text.Trim(), 
                txtCreatedAt.Text.Trim(), 
                txtModifiedBy.Text.Trim(), 
                txtModifiedAt.Text.Trim(), 
                txtCreatedByAndUserID.Text.Trim(), 
                "add");

                    return true;
                }

            }

            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_position(temp_id, 
                    txtname.Text.Trim(), "", 
                    txtCreatedByAndUserID.Text.Trim(),"","","","", "getbyname");

                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_position(temp_id, txtname.Text.Trim(), "", "","","","","", "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == temp_id)
                    {
                        dSet.Clear();
                        dSet = g_objStoredProcCollection.sp_position(temp_id, 
                            txtname.Text.Trim(), lblDepartmentID.Text.Trim(), 
                            txtCreatedBy.Text.Trim(), 
                            txtCreatedAt.Text.Trim(), 
                            txtModifiedBy.Text.Trim(), 
                            txtModifiedAt.Text.Trim(), 
                            txtCreatedByAndUserID.Text.Trim(), "edit");

                        return true;
                    }
                    else
                    {
                        PositionAlreadyTaken();
                        txtname.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_position(temp_id,
                        txtname.Text.Trim(), lblDepartmentID.Text.Trim(),
                        txtCreatedBy.Text.Trim(),
                        txtCreatedAt.Text.Trim(),
                        txtModifiedBy.Text.Trim(),
                        txtModifiedAt.Text.Trim(),
                        txtCreatedByAndUserID.Text.Trim(), "edit");
                    return true;
                }
            }
            else if (mode == "delete")
            {
                dSet.Clear();


                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_position(temp_id, "", "", "","","","","", "delete");

                return true;
            }

            return false;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            metroButtonSave_Click(sender, e);
        }

        private void lstPosition_Click(object sender, EventArgs e)
        {
            doSearch();
            showvalue();
        }
        private void showvalue()
        {
            if (ready == true)
            {
                if (lstPosition.Items.Count > 0)
                {
                    temp_id = Convert.ToInt32(lstPosition.SelectedValue.ToString());
                    txtname.Text = lstPosition.Text;
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lstPosition.Enabled = false;
          
            if (lstPosition.Items.Count > 0)
            {
                mode = "edit";
                txtname.Enabled = true;
                txtname.ReadOnly = false;
            
                txtname.Enabled = true;



                btnEditTool.Visible = false;
                btnAddTool.Visible = false;
                btnCancelTool.Visible = true;
                btnDeleteTool.Visible = false;
                btnUpdateTool.Visible = true;
                cbodepartment.Enabled = true;
                txtModifiedAt.Text = (dNow.ToString("M/d/yyyy"));
                txtModifiedBy.Text = userinfo.emp_name.ToUpper();
            }

        }

        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Delete the User Information ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (lstPosition.Items.Count > 0)
                {
                 
                    mode = "delete";
                    if (saveMode())
                    {
                        getAllPosition();
                        if (lstPosition.Items.Count > 0)
                        {
                            int index = lstPosition.FindString(txtname.Text, 0);
                            if (index == -1) { index = 0; }
                            lstPosition.SelectedIndex = index;
                        }

                        mode = "";
                        lstPosition.Enabled = true;
                        DeletedSuccessfully();
                        load_search();
                        doSearch();

                        btnEditTool.Visible = true;
                        lstPosition_Click(sender, e);
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


        private void btnDelete_Click(object sender, EventArgs e)
        {
            metroButtonDelete_Click(sender, e);
        }

        private void lstPosition_CursorChanged(object sender, EventArgs e)
        {
            doSearch();
            showvalue();
        }

        private void lstPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            doSearch();
            showvalue();
        }

        private void lstPosition_SelectedValueChanged(object sender, EventArgs e)
        {
            doSearch();
            showvalue();
        }

        private void dgv_table_CurrentCellChanged(object sender, EventArgs e)
        {
            showPositionDetails();
        }
        public void showPositionDetails()
        {
            if (dgv_table.RowCount > 0)
            {
                if (dgv_table.CurrentRow != null)
                {
                    if (dgv_table.CurrentRow.Cells["position_name"].Value != null)
                    {


                        txtname.Text = dgv_table.CurrentRow.Cells["position_name"].Value.ToString();
                        cbodepartment.Text = dgv_table.CurrentRow.Cells["department_id"].Value.ToString();
                        txtCreatedBy.Text = dgv_table.CurrentRow.Cells["created_by"].Value.ToString();
                        txtCreatedAt.Text = dgv_table.CurrentRow.Cells["created_at"].Value.ToString();

                        txtModifiedBy.Text = dgv_table.CurrentRow.Cells["modified_by"].Value.ToString();

                        txtModifiedAt.Text = dgv_table.CurrentRow.Cells["modified_date"].Value.ToString();



                    }

                }
            }
        }

        private void cbodepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            lblDepartmentID.Text = cbodepartment.SelectedValue.ToString();
        }

        private void btnAddTool_Click(object sender, EventArgs e)
        {
            mode = "add";
            btnUpdateTool.Visible = true;
            btnAddTool.Visible = false;
         
            lstPosition.Enabled = false;

            txtname.Enabled = true;
            txtname.Text = string.Empty;
            btnCancelTool.Visible = true;


            txtCreatedAt.Text = (dNow.ToString("M/d/yyyy"));
            txtCreatedBy.Text = userinfo.emp_name.ToUpper();
            txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            btnUpdateTool.Visible = true;
            btnEditTool.Visible = false;
            cbodepartment.Enabled = true;
            loadDepartment();
            txtname.Focus();
        }

        private void btnCancelTool_Click(object sender, EventArgs e)
        {
            lstPosition.Enabled = true;
            btnCancelTool.Visible = false;
            btnAddTool.Visible = true;
            txtname.Enabled = false;
            btnUpdateTool.Visible = false;
            btnEditTool.Visible = true;
            btnDeleteTool.Visible = true;
            cbodepartment.Enabled = false;
        }

        private void btnUpdateTool_Click(object sender, EventArgs e)
        {
            metroButtonSave_Click(sender, e);
        }

        private void btnEditTool_Click(object sender, EventArgs e)
        {
            lstPosition.Enabled = false;

            if (lstPosition.Items.Count > 0)
            {
                mode = "edit";
                txtname.Enabled = true;
                txtname.ReadOnly = false;

                txtname.Enabled = true;



                btnEditTool.Visible = false;
                btnAddTool.Visible = false;
                btnCancelTool.Visible = true;
                btnDeleteTool.Visible = false;
                btnUpdateTool.Visible = true;
                cbodepartment.Enabled = true;
                txtModifiedAt.Text = (dNow.ToString("M/d/yyyy"));
                txtModifiedBy.Text = userinfo.emp_name.ToUpper();
            }
        }

        private void btnDeleteTool_Click(object sender, EventArgs e)
        {
            metroButtonDelete_Click(sender, e);
        }
    }
}
