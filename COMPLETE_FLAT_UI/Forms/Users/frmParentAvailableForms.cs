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
    public partial class frmParentAvailableForms : Form
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
        public frmParentAvailableForms()
        {
            InitializeComponent();
        }

        private void frmParentAvailableForms_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class

            myglobal.global_module = "Active"; // Mode for Searching
            load_search(); //Bind the Information
      


            getAllParentMenu(); // all Parent Menu Forms

            loadDepartment();  //Call the Department
        }

        public void loadDepartment()
        {
            ready = false;
            myClass.fillComboBoxDepartment(cboDepartment, "department_dropdown", dSet);
            ready = true;

            lblDepartmentID.Text = cboDepartment.SelectedValue.ToString();
        }

        private void  getAllParentMenu()
        {
            ready = false;
            myClass.fillListBox(lstParentMenu, "ParentForms", dSet);
            ready = true;
            lbltotalrecords.Text = lstParentMenu.Items.Count.ToString();
        }

        private void btnAddTool_Click(object sender, EventArgs e)
        {
            mode = "add";
            btnUpdateTool.Visible = true;
            btnAddTool.Visible = false;

           lstParentMenu.Enabled = false;

            txtmenu.Enabled = true;
            txtmenu.Text = string.Empty;
            btnCancelTool.Visible = true;


            txtCreatedAt.Text = (dNow.ToString("M/d/yyyy"));
            txtCreatedBy.Text = userinfo.emp_name.ToUpper();
            txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            btnUpdateTool.Visible = true;
            btnEditTool.Visible = false;
            cboDepartment.Enabled = true;
            loadDepartment();
            txtmenu.Focus();
        }

        private void btnCancelTool_Click(object sender, EventArgs e)
        {
            lstParentMenu.Enabled = true;
            btnCancelTool.Visible = false;
            btnAddTool.Visible = true;
            txtmenu.Enabled = false;
            btnUpdateTool.Visible = false;
            btnEditTool.Visible = true;
            btnDeleteTool.Visible = true;
            cboDepartment.Enabled = false;
        }

        private void btnUpdateTool_Click(object sender, EventArgs e)
        {
            metroButtonSave_Click(sender, e);
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
        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Save the New Parent Menu " + txtmenu.Text + "", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (txtmenu.Text.Trim() == "")
                {


                    FillRequiredTextbox();
                    txtmenu.BackColor = Color.Yellow;
                    txtmenu.Focus();
                    return;
                }



                else
                {
                    if (saveMode())
                    {
                        getAllParentMenu();
                        if (lstParentMenu.Items.Count > 0)
                        {
                            int index = lstParentMenu.FindString(txtModifiedAt.Text, 0);
                            if (index == -1) { index = 0; }
                            lstParentMenu.SelectedIndex = index;
                        }

                        mode = "";
                        SaveSuccessfully();
                        frmParentAvailableForms_Load(sender, e);
                        btnUpdateTool.Visible = false;
                        btnAddTool.Visible = true;
                        btnCancelTool.Visible = false;
                        lstParentMenu.Enabled = true;
                        btnEditTool.Visible = true;
                        btnDeleteTool.Visible = true;
                        cboDepartment.Enabled = false;
                        lstParentMenu_Click(sender, e);
                    }
                }

                txtmenu.Enabled = false;

            }
            else
            {

                return;
            }
        }

        public void ParentMenuAlreadyTaken()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Parent Menu Already Exist!";
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
                dSet = g_objStoredProcCollection.sp_ParentForms(0,
                    txtmenu.Text.Trim(), "", "", "", "", "", "", "validate");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    ParentMenuAlreadyTaken();
                    txtmenu.Focus();
                    return false;
                }
                else
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_ParentForms(0,
                    txtmenu.Text.Trim(),                
                    txtCreatedAt.Text.Trim(),
                    txtCreatedBy.Text.Trim(),
                    txtModifiedAt.Text.Trim(),
                    txtModifiedBy.Text.Trim(),
                    txtCreatedByAndUserID.Text.Trim(),
                    lblDepartmentID.Text.Trim(),
                    "add");

                    return true;
                }

            }

            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_ParentForms(temp_id,
                    txtmenu.Text.Trim(), "",
                    txtCreatedByAndUserID.Text.Trim(), "", "", "", "", "getbyname");

                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_ParentForms(temp_id, txtmenu.Text.Trim(), "", "", "", "", "", "", "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == temp_id)
                    {
                        dSet.Clear();
                        dSet = g_objStoredProcCollection.sp_ParentForms(temp_id,
                            txtmenu.Text.Trim(),
                            txtCreatedAt.Text.Trim(),
                            txtCreatedBy.Text.Trim(),                      
                            txtModifiedAt.Text.Trim(),
                            txtModifiedBy.Text.Trim(),
                            txtCreatedByAndUserID.Text.Trim(),
                            lblDepartmentID.Text.Trim(),
                            "edit");

                        return true;
                    }
                    else
                    {
                        ParentMenuAlreadyTaken();
                        txtmenu.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_ParentForms(temp_id,
                        txtmenu.Text.Trim(),
                        txtCreatedAt.Text.Trim(),
                        txtCreatedBy.Text.Trim(),
                        txtModifiedAt.Text.Trim(),
                        txtModifiedBy.Text.Trim(),
                        txtCreatedByAndUserID.Text.Trim(),
                        lblDepartmentID.Text.Trim(),
                        "edit");

                    return true;
                }
            }
            else if (mode == "delete")
            {
                dSet.Clear();


                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_ParentForms(temp_id, "", "", "", "", "", "", "", "delete");

                return true;
            }

            return false;
        }


        private void lstParentMenu_Click(object sender, EventArgs e)
        {
            doSearch();
            showvalue();
        }

        DataSet dset_emp = new DataSet();
        private void doSearch()
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

                        dv.RowFilter = "parent_form_name like '%" + txtmenu.Text + "%'";

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
                txtmenu.Focus();
                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmenu.Focus();
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
            { dset_emp = objStorProc.sp_getMajorTables("ParentFormscurrentcellchanged"); }
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



        private void showvalue()
        {
            if (ready == true)
            {
                if (lstParentMenu.Items.Count > 0)
                {
                    temp_id = Convert.ToInt32(lstParentMenu.SelectedValue.ToString());
                    txtmenu.Text = lstParentMenu.Text;
                }

            }
        }

        private void btnEditTool_Click(object sender, EventArgs e)
        {
            lstParentMenu.Enabled = false;

            if (lstParentMenu.Items.Count > 0)
            {
                mode = "edit";
                txtmenu.Enabled = true;
                txtmenu.ReadOnly = false;





                btnEditTool.Visible = false;
                btnAddTool.Visible = false;
                btnCancelTool.Visible = true;
                btnDeleteTool.Visible = false;
                btnUpdateTool.Visible = true;
                cboDepartment.Enabled = true;
                txtModifiedAt.Text = (dNow.ToString("M/d/yyyy"));
                txtModifiedBy.Text = userinfo.emp_name.ToUpper();
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
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Delete the Parent Menu Information ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (lstParentMenu.Items.Count > 0)
                {

                    mode = "delete";
                    if (saveMode())
                    {
                        getAllParentMenu();
                        if (lstParentMenu.Items.Count > 0)
                        {
                            int index = lstParentMenu.FindString(txtmenu.Text, 0);
                            if (index == -1) { index = 0; }
                            lstParentMenu.SelectedIndex = index;
                        }

                        mode = "";
                        lstParentMenu.Enabled = true;
                        DeletedSuccessfully();
                        load_search();
                        doSearch();

                        btnEditTool.Visible = true;
                        lstParentMenu_Click(sender, e);
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

        private void dgv_table_CurrentCellChanged(object sender, EventArgs e)
        {
            showParentMenuDetails();
        }
        private void showParentMenuDetails()
        {
            if (dgv_table.RowCount > 0)
            {
                if (dgv_table.CurrentRow != null)
                {
                    if (dgv_table.CurrentRow.Cells["parent_form_name"].Value != null)
                    {


                        txtmenu.Text = dgv_table.CurrentRow.Cells["parent_form_name"].Value.ToString();
                        cboDepartment.Text = dgv_table.CurrentRow.Cells["department"].Value.ToString();
                        txtCreatedBy.Text = dgv_table.CurrentRow.Cells["created_by"].Value.ToString();
                        txtCreatedAt.Text = dgv_table.CurrentRow.Cells["created_at"].Value.ToString();

                        txtModifiedBy.Text = dgv_table.CurrentRow.Cells["updated_by"].Value.ToString();

                        txtModifiedAt.Text = dgv_table.CurrentRow.Cells["updated_at"].Value.ToString();



                    }

                }
            }
        }

        private void lstParentMenu_CursorChanged(object sender, EventArgs e)
        {
            doSearch();
            showvalue();
        }

        private void lstParentMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            doSearch();
            showvalue();
        }

        private void lstParentMenu_SelectedValueChanged(object sender, EventArgs e)
        {
            doSearch();
            showvalue();
        }

        private void cboDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
           lblDepartmentID.Text = cboDepartment.SelectedValue.ToString();
        }

        private void BtnModuleClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
