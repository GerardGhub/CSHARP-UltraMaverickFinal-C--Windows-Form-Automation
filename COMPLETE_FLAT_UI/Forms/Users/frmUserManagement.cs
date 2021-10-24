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

namespace ULTRAMAVERICK.Forms.Users
{
    public partial class frmUserManagement : MaterialForm
    {
        //Main Constructor Bugok
        myclasses xClass = new myclasses();
        public Byte[] imageByte = null;

        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        DataSet dSet_temp = new DataSet();
        int temp_id = 0;
        int s_id = 0;
        Boolean ready = false;
        DataSet dSet = new DataSet();
        string mode = "";
        public frmUserManagement()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            loadUser_type(); // Load the UserType at User Rights
            getAllUsers(); // all UserFile Management
            lstUsers_Click(sender, e); // Click Thge ListView
            myglobal.global_module = "Active"; // Mode for Searching
            //loadPositionDropDown(); // show Dta
            load_search(); //Bind the Information
            HideDataGrid(); // Hide the DataGrid
            lstUsers.Enabled = true;
            loadDepartment(); // Loading the Depeartment
            loadRequestorType(); //Load Requestor Types
            //loadUnit();
            RefresherOnLoadingThePage();
         
        }

        public void doSearchOnMaterialTextBox()
        {
            //try
            //{
            //    if (dset_emp.Tables.Count > 0)
            //    {
            //        DataView dv = new DataView(dset_emp.Tables[0]);
            //        if (myglobal.global_module == "EMPLOYEE")
            //        {

            //        }
            //        else if (myglobal.global_module == "Active")
            //        {

            //            dv.RowFilter = "employee_name = '" + mattxtSearch.Text + "'";

            //        }
            //        else if (myglobal.global_module == "VISITORS")
            //        {

            //        }
            //        dgvChildForms.DataSource = dv;
            //        lblrecords.Text = dgv_table.RowCount.ToString();
            //    }
            //}
            //catch (SyntaxErrorException)
            //{
            //    MessageBox.Show("Invalid character found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtuser.Focus();
            //    return;
            //}
            //catch (EvaluateException)
            //{
            //    MessageBox.Show("Invalid character found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtuser.Focus();
            //    return;
            //}
        }

        private void RefresherOnLoadingThePage()
        {
            lblgenderLabel.BackColor = Color.Transparent;
            matRadioMale.Enabled = false;
            matRadioFemale.Enabled = false;
        }
      
        public void loadUnit()
        {


            ready = false;
            xClass.fillComboBoxFilter(cboUnit, "filter_section_dropdown", dSet, lblDepartmentID.Text, 0);
            ready = true;
            s_id = showValue(cboUnit);


            //ready = false;
            //myClass.fillComboBoxSearch(cboUnit, "DepartmentUnit_dropdown", dSet, 1);
            //ready = true;

            //lblUnitID.Text = cboUnit.SelectedValue.ToString();
        }

        public int showValue(ComboBox cbo)
        {
            int ids = 0;
            if (ready == true)
            {
                if (cbo.Items.Count > 0)
                {
                    ids = Convert.ToInt32(cbo.SelectedValue.ToString());
                }
            }
            return ids;
        }


        public void loadRequestorType()
        {
            ready = false;
            myClass.fillComboBoxDepartment(cboRequestorType, "TypeofApprover_dropdown", dSet);
            ready = true;

            lblRequestorTypeID.Text = cboRequestorType.SelectedValue.ToString();
        }

        public void loadDepartment()
        {
            ready = false;
            myClass.fillComboBoxDepartment(cbodepartment, "department_dropdown", dSet);
            ready = true;

            lblDepartmentID.Text = cbodepartment.SelectedValue.ToString();
        }
        public void loadPositionDropDown()
        {


            ready = false;
            xClass.fillComboBoxFilter(cboPosition, "filter_position_dropdown", dSet, lblDepartmentID.Text, 0);
            ready = true;
            s_id = showValue(cboPosition);


        }
        public void HideDataGrid()
        {
            dgv_table.Visible = false;
        }
        private void getAllUsers()
        {
            ready = false;
            myClass.fillListBox(lstUsers, "users", dSet);
            ready = true;
            lbltotalrecords.Text = lstUsers.Items.Count.ToString();
        }
        DataSet dset_emp = new DataSet();
       public void doSearch()
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

                        dv.RowFilter = "username = '" + txtuser.Text + "'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dgv_table.DataSource = dv;
                    lblrecords.Text = dgv_table.RowCount.ToString();
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
        public void load_search()
        {
            try
            {

      

            dset_emp.Clear();

            if (myglobal.global_module == "EMPLOYEE")
            { dset_emp = objStorProc.sp_getMajorTables("employee"); }
            else if (myglobal.global_module == "MICRO")
            { dset_emp = objStorProc.sp_getMajorTables("micro_raw_materialsnew"); }
            else if (myglobal.global_module == "Active")
            { dset_emp = objStorProc.sp_getMajorTables("usercurrentcellchanged"); }
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        public void loadUser_type()
        {
            ready = false;
            myClass.fillComboBox(cbousertype, "user_type", dSet);
            ready = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lstUsers_Click(object sender, EventArgs e)
        {
        
            showvalue();
            doSearch();
            showActiveUser();
        }

        private void showvalue()
        {
            if (ready == true)
            {
                if (lstUsers.Items.Count > 0)
                {
                    temp_id = Convert.ToInt32(lstUsers.SelectedValue.ToString());
                    txtuser.Text = lstUsers.Text;
                }

            }
        }

    
        private void EmptyTextField()
        {
            txtname.Text = String.Empty;
            txtLastName.Text = String.Empty;
            cbousertype.Text = String.Empty;
            cboPosition.Text = String.Empty;
            txtuser.Text = String.Empty;
            txtpassword.Text = String.Empty;
            cmbLocation.Text = String.Empty;
            cmbNotif.Text = String.Empty;
            cbodepartment.Text = string.Empty;
            cboRequestorType.Text = string.Empty;
        }

        private void disable_text(Boolean e)
        {
           
            txtname.ReadOnly = e;
            txtuser.ReadOnly = e;
            txtpassword.ReadOnly = e;
            txtLastName.ReadOnly = e;
            cboPosition.Enabled = false;
            cbousertype.Enabled = !e;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            metroButtonSave_Click(sender, e);
        }

        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Save the New User " + txtname.Text + "", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (txtname.Text.Trim() == "")
                {
                 

                    FillRequiredTextbox();
                    txtname.BackColor = Color.Yellow;
                    txtname.Focus();
                    return;
                }
                if (txtLastName.Text.Trim() == "")
                {


                    FillRequiredTextbox();
                    txtLastName.BackColor = Color.Yellow;
                    txtLastName.Focus();
                    return;
                }
                if (cbousertype.Text.Trim() == "")
                {
                  
                    FillRequiredTextbox();
                    cbousertype.BackColor = Color.Yellow;
                    cbousertype.Focus();
                    return;
                }
                if (cboPosition.Text.Trim() == "")
                {

                    FillRequiredTextbox();
                    cboPosition.BackColor = Color.Yellow;
                    cboPosition.Focus();
                    return;
                }
                if (cboRequestorType.Text.Trim() == "")
                {

                    FillRequiredTextbox();
                    cboRequestorType.BackColor = Color.Yellow;
                    cboRequestorType.Focus();
                    return;
                }
                if (txtuser.Text.Trim() == "")
                {
                    
                    FillRequiredTextbox();
                    txtuser.BackColor = Color.Yellow;
                    txtuser.Focus();
                    return;
                }
                if (txtpassword.Text.Trim() == "")
                {
                   
                    FillRequiredTextbox();
                    txtpassword.BackColor = Color.Yellow;
                    txtpassword.Focus();
                    return;
                }
                if(lblGenderSelected.Text.Trim() == "")
                {
                    FillRequiredTextbox();
                    lblgenderLabel.BackColor = Color.Yellow;
                    return;
                }
                else
                {
                    if (saveMode())
                    {
                        getAllUsers();
                        if (lstUsers.Items.Count > 0)
                        {
                            int index = lstUsers.FindString(txtuser.Text, 0);
                            if (index == -1) { index = 0; }
                            lstUsers.SelectedIndex = index;
                        }

                        mode = "";
                        SaveSuccessfully();
                        frmUserManagement_Load(sender, e);
                        visible_button(true);
                        disable_text(true);

                        lstUsers_Click(sender, e);
                     
                    }
                }
                cmbLocation.Enabled = false;
                cmbNotif.Enabled = false;
                txtname.Enabled = false;

            }
            else
            {

                return;
            }
        }

        public bool saveMode()
        {
            if (mode == "add")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_userfile(0, txtuser.Text.Trim(), "", "", "validate");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    UserNameAlreadyTaken();
                    txtuser.Focus();
                    return false;
                }
                else
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_userfile(0, 
                        Convert.ToInt32(lblrightsID.Text), 
                        txtuser.Text.Trim(), 
                        txtpassword.Text.Trim(), 
                        txtname.Text.Trim(), 
                        cmbLocation.Text.Trim(), 
                        cmbNotif.Text.Trim(), 
                        lblPositionId.Text.Trim(), 
                        txtLastName.Text.Trim(), 
                        lblDepartmentID.Text.Trim(), 
                        lblRequestorTypeID.Text.Trim(), 
                        lblUnitID.Text.Trim(),
                        lblGenderSelected.Text.Trim(),
                        imageByte,
                        "add");

                    return true;
                }

            }
            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_userfile(temp_id, 
                    txtuser.Text.Trim(), "", 
                    cmbLocation.Text.Trim(), "getbyname");

                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_userfile(temp_id, 
                    txtuser.Text.Trim(), "", "", "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == temp_id)
                    {
                        dSet.Clear();
                        dSet = g_objStoredProcCollection.sp_userfile(temp_id, 
                            Convert.ToInt32(cbousertype.SelectedValue.ToString()), 
                            txtuser.Text.Trim(), 
                            txtpassword.Text.Trim(), 
                            txtname.Text.Trim(), 
                            cmbLocation.Text.Trim(), 
                            cmbNotif.Text.Trim(), 
                            lblPositionId.Text.Trim(), 
                            txtLastName.Text.Trim(), 
                            lblDepartmentID.Text.Trim(),
                            lblRequestorTypeID.Text.Trim(), 
                            lblUnitID.Text.Trim(),
                            lblGenderSelected.Text.Trim(),
                            imageByte,
                            "edit");
                        matRadioMale.Enabled = false;
                        matRadioFemale.Enabled = false;
                        return true;
                    }
                    else
                    {
                        UserNameAlreadyTaken();
                        txtuser.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_userfile(temp_id, 
                        Convert.ToInt32(cbousertype.SelectedValue.ToString()), 
                        txtuser.Text.Trim(), 
                        txtpassword.Text.Trim(), 
                        txtname.Text.Trim(), 
                        cmbLocation.Text.Trim(), 
                        cmbNotif.Text.Trim(), 
                        lblPositionId.Text.Trim(), 
                        txtLastName.Text.Trim(), 
                        lblDepartmentID.Text.Trim(), 
                        lblRequestorTypeID.Text.Trim(), 
                        lblUnitID.Text.Trim(),
                        lblGenderSelected.Text.Trim(),
                        imageByte,
                        "edit");

                    matRadioMale.Enabled = false;
                    matRadioFemale.Enabled = false;
                    return true;
                }
            }
            else if (mode == "delete")
            {
                dSet.Clear();


                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_userfile(temp_id, "", "", "", "delete");

                return true;
            }

            return false;
        }


        private void visible_button(Boolean e)
        {
            btnAddTool.Visible = e;
            btnEditTool.Visible = e;
            btnDeleteTool.Visible = e;
            btnUpdateTool.Visible = !e;
            btnCancel.Visible = !e;
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

        public void UserNameAlreadyTaken()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Username Already Taken!";
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

        public void UpdateSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Updated Successfully";
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


        private void btnEdit_Click(object sender, EventArgs e)
        {
            lstUsers.Enabled = false;
            cmbLocation.Enabled = true;
            cmbNotif.Enabled = true;
            if (lstUsers.Items.Count > 0)
            {
                mode = "edit";
                txtname.Enabled = true;
                txtname.ReadOnly = false;
                cbousertype.Enabled = true;
                txtuser.Enabled = true;
                txtuser.ReadOnly = false;
                txtpassword.Enabled = true;
                txtpassword.ReadOnly = false;
         
                btnEditTool.Visible = false;
                btnCancelTool.Visible = true;
                txtLastName.Enabled = true;
                btnUpdateTool.Visible = true;
                cboPosition.Enabled = true;
                btnDeleteTool.Visible = false;
            }

            }

        private void metroButtonUpdate_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Update the User Information ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (lstUsers.Items.Count > 0)
                {
                    //if (MessageBox.Show("Are you sure you want to update this record?", "Users", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    //{
                    mode = "edit";
                    if (saveMode())
                    {
                        getAllUsers();
                        if (lstUsers.Items.Count > 0)
                        {
                            int index = lstUsers.FindString(txtuser.Text, 0);
                            if (index == -1) { index = 0; }
                            lstUsers.SelectedIndex = index;
                        }

                        mode = "";
                   
                        UpdateSuccessfully();
                        frmUserManagement_Load(sender, e);
                        visible_button(true);
                        disable_text(true);
                        load_search();
                        doSearch();
                
                        btnEditTool.Visible = true;
                        lstUsers_Click(sender, e);
                        lstUsers.Enabled = false;
                    }
                }
                //}
                cmbLocation.Enabled = false;
                cmbNotif.Enabled = false;
            }
            else
            {
          
                btnEditTool.Visible = true;
                lstUsers.Enabled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metroButtonUpdate_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            metroButtonDelete_Click(sender, e);
        }

        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Delete the User Information ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (lstUsers.Items.Count > 0)
                {
                   
                    mode = "delete";
                    if (saveMode())
                    {
                        getAllUsers();
                        if (lstUsers.Items.Count > 0)
                        {
                            int index = lstUsers.FindString(txtuser.Text, 0);
                            if (index == -1) { index = 0; }
                            lstUsers.SelectedIndex = index;
                        }

                        mode = "";
                        visible_button(true);
                        disable_text(true);
                        DeletedSuccessfully();
                        load_search();
                        doSearch();
                   
                        btnEditTool.Visible = true;
                        lstUsers_Click(sender, e);
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
            //showActiveUser();
        }

        public void showActiveUser()
        {

            if (dgv_table.RowCount > 0)
            {
                if (dgv_table.CurrentRow != null)
                {
                    if (dgv_table.CurrentRow.Cells["username"].Value != null)
                    {
                       

                        txtname.Text = dgv_table.CurrentRow.Cells["employee_name"].Value.ToString();
                       txtLastName.Text = dgv_table.CurrentRow.Cells["employee_lastname"].Value.ToString();
                        cbousertype.Text = dgv_table.CurrentRow.Cells["user_rights_name"].Value.ToString();
                        txtuser.Text = dgv_table.CurrentRow.Cells["username"].Value.ToString();
                        txtpassword.Text = dgv_table.CurrentRow.Cells["password"].Value.ToString();
                        cboPosition.Text = dgv_table.CurrentRow.Cells["Position"].Value.ToString();
                        cmbLocation.Text = dgv_table.CurrentRow.Cells["user_section"].Value.ToString();
                        cboUnit.Text = dgv_table.CurrentRow.Cells["Unit"].Value.ToString();
                        cmbNotif.Text = dgv_table.CurrentRow.Cells["receiving_status"].Value.ToString();
                        cboRequestorType.Text = dgv_table.CurrentRow.Cells["type_of_approver"].Value.ToString();

                        lblGenderSelected.Text = dgv_table.CurrentRow.Cells["gender"].Value.ToString();
                        if(lblGenderSelected.Text == "Male")
                        {
                            matRadioMale.Checked = true;
                        }
                        else if(lblGenderSelected.Text =="Female")
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

        private void lstUsers_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lstUsers_CursorChanged(object sender, EventArgs e)
        {

            if(mode == "add")
            {

            }
            else
            {
                doSearch();
                showvalue();
            }
        
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (mode == "add")
            {

            }
            else
            {
                doSearch();
                showvalue();
            }

        }

        private void lstUsers_SelectedValueChanged(object sender, EventArgs e)
        {

            if (mode == "add")
            {

            }
            else
            {
                doSearch();
                showvalue();
            }



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            //doSearch();
            //showvalue();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            btnAddTool.Visible = true;
            btnUpdateTool.Visible = false;
            btnEditTool.Visible = true;
            btnDeleteTool.Visible = true;
            btnCancelTool.Visible = false;
            cboPosition.Enabled = false;
            txtLastName.Enabled = false;
            cbodepartment.Enabled = false;
            cboRequestorType.Enabled = false;
            mode = "";
        }

        private void cboPosition_SelectedValueChanged(object sender, EventArgs e)
        {

            //lblPositionId.Text = cboPosition.SelectedValue.ToString();

            //
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            if (mode == "add")
            {
                
            
            }
            else
            {
                doSearch();
                showActiveUser();
            }
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {

            showActiveUser();
        }

        private void cbodepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            lblDepartmentID.Text = cbodepartment.SelectedValue.ToString();
            //loadUnit();

            if (cbodepartment.Text.Trim() != "")
            {
                loadUnit();
                cboUnit.Text = String.Empty;
            }


            if (cbodepartment.Text.Trim() != "")
            {
                loadPositionDropDown();
                cboPosition.Text = String.Empty;
            }
        }

        private void cboRequestorType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboRequestorType.Text == "Requestor")
            {
                materialCard3RequestorSetup.Visible = true;
            }
            else
            {
                materialCard3RequestorSetup.Visible = false;
            }

        }

        private void btnAddTool_Click(object sender, EventArgs e)
        {
            mode = "add";
            btnUpdateTool.Visible = true;
            btnAddTool.Visible = false;
       
            txtname.Focus();
            txtname.Enabled = true;


            cbousertype.Enabled = true;
            cbousertype.Text = String.Empty;

            cboUnit.Enabled = true;
            txtpassword.Enabled = true;
            txtpassword.Text = String.Empty;

            btnDeleteTool.Visible = false;
            txtuser.Enabled = true;
            txtuser.Text = String.Empty;

            btnEditTool.Visible = false;
            btnUpdateTool.Visible = true;
            txtLastName.Enabled = true;
            disable_text(false);
            cmbLocation.Enabled = true;
            cmbNotif.Enabled = true;
            btnCancelTool.Visible = true;
            cboPosition.Enabled = true;
            cbodepartment.Enabled = true;
            cboRequestorType.Enabled = true;
            EmptyTextField();
            txtname.Text = String.Empty;
            txtname.Focus();
        }

        private void btnEditTool_Click(object sender, EventArgs e)
        {
            lstUsers.Enabled = false;
            cmbLocation.Enabled = true;
            cmbNotif.Enabled = true;
            if (lstUsers.Items.Count > 0)
            {
                mode = "edit";
                txtname.Enabled = true;
                txtname.ReadOnly = false;
                cbousertype.Enabled = true;
                txtuser.Enabled = true;
                txtuser.ReadOnly = false;
                txtpassword.Enabled = true;
                txtpassword.ReadOnly = false;
              
                btnEditTool.Visible = false;
                btnCancelTool.Visible = true;
                txtLastName.Enabled = true;
                btnUpdateTool.Visible = true;
                cboPosition.Enabled = true;
                btnDeleteTool.Visible = false;
                cboRequestorType.Enabled = true;
            }

        }

        private void btnDeleteTool_Click(object sender, EventArgs e)
        {
            metroButtonDelete_Click(sender, e);
        }

        private void btnCancelTool_Click(object sender, EventArgs e)
        {
            btnAddTool.Visible = true;
            btnUpdateTool.Visible = false;
            btnEditTool.Visible = true;
            btnDeleteTool.Visible = true;
            btnCancelTool.Visible = false;
            cboPosition.Enabled = false;
            txtLastName.Enabled = false;
            cbodepartment.Enabled = false;
            cboRequestorType.Enabled = false;
            cboUnit.Enabled = false;
            mode = "";
        }

        private void btnUpdateTool_Click(object sender, EventArgs e)
        {
            metroButtonSave_Click(sender, e);
        }

        private void cboPosition_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblPositionId.Text = cboPosition.SelectedValue.ToString();

        }

        private void cboRequestorType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblRequestorTypeID.Text = cboRequestorType.SelectedValue.ToString();
       
        }

        private void cbodepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //lblDepartmentID.Text = cbodepartment.SelectedValue.ToString();
            ////loadUnit();

            //if (cbodepartment.Text.Trim() != "")
            //{
            //    loadUnit();
            //    cboUnit.Text = String.Empty;
            //}


            //if (cbodepartment.Text.Trim() != "")
            //{
            //    loadPositionDropDown();
            //    cboPosition.Text = String.Empty;
            //}
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            mode = "add";
            btnUpdateTool.Visible = true;
            btnAddTool.Visible = false;

            txtname.Focus();
            txtname.Enabled = true;


            cbousertype.Enabled = true;
            cbousertype.Text = String.Empty;

            cboUnit.Enabled = true;
            txtpassword.Enabled = true;
            txtpassword.Text = String.Empty;

            btnDeleteTool.Visible = false;
            txtuser.Enabled = true;
            txtuser.Text = String.Empty;

            btnEditTool.Visible = false;
            btnUpdateTool.Visible = true;
            txtLastName.Enabled = true;
            disable_text(false);
            cmbLocation.Enabled = true;
            cmbNotif.Enabled = true;
            btnCancelTool.Visible = true;
            cboPosition.Enabled = true;
            cbodepartment.Enabled = true;
            cboRequestorType.Enabled = true;
            EmptyTextField();
            txtname.Text = String.Empty;
            txtname.Focus();
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            mode = "add";
            btnUpdateTool.Visible = true;
            btnAddTool.Visible = false;
            lstUsers.Enabled = false;
            txtname.Focus();
            txtname.Enabled = true;
            cboUnit.Text = String.Empty;

            cbousertype.Enabled = true;
            cbousertype.Text = String.Empty;

            cboUnit.Enabled = true;
            txtpassword.Enabled = true;
            txtpassword.Text = String.Empty;

            btnDeleteTool.Visible = false;
            txtuser.Enabled = true;
            txtuser.Text = String.Empty;

            btnEditTool.Visible = false;
            btnUpdateTool.Visible = true;
            txtLastName.Enabled = true;
            disable_text(false);
            cmbLocation.Enabled = true;
            cmbNotif.Enabled = true;
            btnCancelTool.Visible = true;
            cboPosition.Enabled = true;
            cbodepartment.Enabled = true;
            cboRequestorType.Enabled = true;
            EmptyTextField();
            txtname.Text = String.Empty;
            txtname.Focus();
        }

        private void materialButton1_Click_2(object sender, EventArgs e)
        {
            lstUsers_Click(sender, e);

            //Bind Start to eliminate the error in converting using Left Joins
            lblPositionId.Text = cboPosition.SelectedValue.ToString();
            lblUnitID.Text = cboUnit.SelectedValue.ToString();
            //End animal ka1
            lstUsers.Enabled = false;
            cmbLocation.Enabled = true;
            cmbNotif.Enabled = true;
            if (lstUsers.Items.Count > 0)
            {
                mode = "edit";
                txtname.Enabled = true;
                txtname.ReadOnly = false;
                cbousertype.Enabled = true;
                txtuser.Enabled = true;
                txtuser.ReadOnly = false;
                txtpassword.Enabled = true;
                txtpassword.ReadOnly = false;
                matRadioMale.Enabled = true;
                matRadioFemale.Enabled = true;
                btnEditTool.Visible = false;
                btnCancelTool.Visible = true;
                txtLastName.Enabled = true;
                btnUpdateTool.Visible = true;
                cboPosition.Enabled = true;
                btnDeleteTool.Visible = false;
                cboRequestorType.Enabled = true;
                btnAddTool.Visible = false;
                txtLastName.ReadOnly = false;
            }
        }

   
        private void materialButton1_Click_4(object sender, EventArgs e)
        {
            metroButtonDelete_Click(sender, e);
        }

        private void materialButton1_Click_3(object sender, EventArgs e)
        {
            if (txtname.Text.Trim() == "")
            {


                FillRequiredTextbox();
                txtname.BackColor = Color.Yellow;
                txtname.Focus();
                return;
            }
            if (txtLastName.Text.Trim() == "")
            {


                FillRequiredTextbox();
                txtLastName.BackColor = Color.Yellow;
                txtLastName.Focus();
                return;
            }
            if (cbousertype.Text.Trim() == "")
            {

                FillRequiredTextbox();
                cbousertype.BackColor = Color.Yellow;
                cbousertype.Focus();
                return;
            }
            if (cboPosition.Text.Trim() == "")
            {

                FillRequiredTextbox();
                cboPosition.BackColor = Color.Yellow;
                cboPosition.Focus();
                return;
            }
            if (cboRequestorType.Text.Trim() == "")
            {

                FillRequiredTextbox();
                cboRequestorType.BackColor = Color.Yellow;
                cboRequestorType.Focus();
                return;
            }
            if (txtuser.Text.Trim() == "")
            {

                FillRequiredTextbox();
                txtuser.BackColor = Color.Yellow;
                txtuser.Focus();
                return;
            }
            if (txtpassword.Text.Trim() == "")
            {

                FillRequiredTextbox();
                txtpassword.BackColor = Color.Yellow;
                txtpassword.Focus();
                return;
            }
            if (lblGenderSelected.Text.Trim() == "")
            {
                FillRequiredTextbox();
                lblgenderLabel.BackColor = Color.Yellow;
                return;
            }

            metroButtonSave_Click(sender, e);
        }



        private void materialButton1_Click_5(object sender, EventArgs e)
        {
        EnableTrueExtrover();
        
        EnabledFalseByCancelling();
        mode = "";
        }

        private void EnableTrueExtrover()
        {
            btnAddTool.Visible = true;

            btnEditTool.Visible = true;
            btnDeleteTool.Visible = true;
            lstUsers.Enabled = true;
        }
        private void EnabledFalseByCancelling()
        {
            btnCancelTool.Visible = false;
            cboPosition.Enabled = false;
            txtLastName.Enabled = false;
            txtname.Enabled = false;
            cbousertype.Enabled = false;
            txtuser.Enabled = false;
            txtpassword.Enabled = false;
            cmbLocation.Enabled = false;
            cmbNotif.Enabled = false;
            btnUpdateTool.Visible = false;
            matRadioMale.Enabled = false;
            matRadioFemale.Enabled = false;
            materialCard3RequestorSetup.Visible = false;
            cbodepartment.Enabled = false;
            cboRequestorType.Enabled = false;
            cboUnit.Enabled = false;
        }

        private void lblRequestorTypeID_Click(object sender, EventArgs e)
        {
  
        }

        private void lblRequestorTypeID_TextChanged(object sender, EventArgs e)
        {
            if (cboRequestorType.Text == "Requestor")
            {
                materialCard3RequestorSetup.Visible = true;
            }
            else
            {
                materialCard3RequestorSetup.Visible = false;
            }
        }

        private void txtuser_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cbousertype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblrightsID.Text =  cbousertype.SelectedValue.ToString();
        }

        private void cboUnit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblUnitID.Text = cboUnit.SelectedValue.ToString();
        }

        private void cboLocation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblrightsID.Text = cbousertype.SelectedValue.ToString();
        }

        private void matRadioMale_CheckedChanged(object sender, EventArgs e)
        {
            if(matRadioMale.Checked == true)
            {
                lblGenderSelected.Text = "Male";
                lblgenderLabel.BackColor = Color.Transparent;
            }
            else if(matRadioFemale.Checked == true)
            {
                lblGenderSelected.Text = "Female";
                lblgenderLabel.BackColor = Color.Transparent;
            }
            else
            {
                lblGenderSelected.Text = String.Empty;
            }
        }

        private void matRadioFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioMale.Checked == true)
            {
                lblGenderSelected.Text = "Male";
            }
            else if (matRadioFemale.Checked == true)
            {
                lblGenderSelected.Text = "Female";
            }
            else
            {
                lblGenderSelected.Text = String.Empty;
            }
        }

        private void metroComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if(mode =="add")
            {

            if (cboRequestorType.Text == "Requestor")
            {
                materialCard3RequestorSetup.Visible = true;
            }
            else
            {
                materialCard3RequestorSetup.Visible = false;
            }
            }
        }

        private void metroComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblRequestorTypeID.Text = cboRequestorType.SelectedValue.ToString();
        }

        private void metroComboBox1_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            lblPositionId.Text = cboPosition.SelectedValue.ToString();
        }

        private void metroComboBox1_SelectionChangeCommitted_2(object sender, EventArgs e)
        {
            lblUnitID.Text = cboUnit.SelectedValue.ToString();
        }

        private void metroComboBox1_SelectedValueChanged_1(object sender, EventArgs e)
        {
            lblDepartmentID.Text = cbodepartment.SelectedValue.ToString();
            //loadUnit();

            if (cbodepartment.Text.Trim() != "")
            {
                loadUnit();
                cboUnit.Text = String.Empty;
            }


            if (cbodepartment.Text.Trim() != "")
            {
                loadPositionDropDown();
                cboPosition.Text = String.Empty;
            }
        }

        private void lblgenderLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
