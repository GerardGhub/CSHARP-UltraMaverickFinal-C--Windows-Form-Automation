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

namespace ULTRAMAVERICK.Forms.Users
{
    public partial class frmMajorAvailableForms : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        public Byte[] imageByte = null;
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        myglobal pointer_module = new myglobal();
        DateTime dNow = DateTime.Now;
        string mode = "";
        DataSet dSet = new DataSet();
        Boolean ready = false;
        int temp_id = 0;
        DataSet dSet_temp = new DataSet();


        public frmMajorAvailableForms()
        {
            InitializeComponent();
        }
        MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;

        public string sp_department_id { get; set; }

        public string sp_user_rights_id { get; set; }
        public string sp_created_at { get; set; }
        public string Sp_CreatedByAndUserID { get; set; }
        public string Sp_modified_at { get; set; }
        private void frmParentAvailableForms_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class

            myglobal.global_module = "Active"; // Mode for Searching
            load_search(); //Bind the Information
      


            getAllParentMenu(); // all Parent Menu Forms

            loadDepartment();  //Call the Department
            displayUserRightsData();
        }


        private void displayUserRightsData()      //method for loading available_menus
        {
   
            xClass.fillDataGridView(dgvUserRights, "user_rights", dSet);
      

        }
        public void loadDepartment()
        {
            ready = false;
            myClass.fillComboBoxDepartment(cboDepartmentMaterial, "department_dropdown", dSet);
            ready = true;

            sp_department_id = cboDepartmentMaterial.SelectedValue.ToString();
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
            cboDepartmentMaterial.Visible = true;
            txtMaterialDepartment.Visible = false;

            materialBtnNew.Visible = false;

           lstParentMenu.Enabled = false;

            txtMaterialMenu.Enabled = true;
            txtMaterialMenu.Text = string.Empty;
           matBtnCancel.Visible = true;


           sp_created_at = (dNow.ToString("M/d/yyyy"));
            txtCreatedBy.Text = userinfo.emp_name.ToUpper();
            this.Sp_CreatedByAndUserID = userinfo.user_id.ToString();
            matBtnSave.Visible = true;
            matBtnEDit.Visible = false;
            cboDepartmentMaterial.Enabled = true;
            loadDepartment();
            txtMaterialMenu.Focus();
        }

        private void btnCancelTool_Click(object sender, EventArgs e)
        {
            lstParentMenu.Enabled = true;
            matBtnCancel.Visible = false;
            materialBtnNew.Visible = true;
            txtMaterialMenu.Enabled = false;
            matBtnSave.Visible = false;
            matBtnEDit.Visible = true;
            matBtnDelete.Visible = true;
            cboDepartmentMaterial.Enabled = false;
            cboDepartmentMaterial.Visible = false;
            txtMaterialDepartment.Visible = true;
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
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Save the New Parent Menu " + txtMaterialMenu.Text + "", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (txtMaterialMenu.Text.Trim() == "")
                {


                    FillRequiredTextbox();
                    txtMaterialMenu.BackColor = Color.Yellow;
                    txtMaterialMenu.Focus();
                    return;
                }



                else
                {
                    if (saveMode())
                    {
                        //getAllParentMenu();
                        if (lstParentMenu.Items.Count > 0)
                        {
                            int index = lstParentMenu.FindString(this.Sp_modified_at, 0);
                            if (index == -1) { index = 0; }
                            lstParentMenu.SelectedIndex = index;
                        }

                        mode = "";
                        SaveSuccessfully();
                        frmParentAvailableForms_Load(sender, e);
                        matBtnSave.Visible = false;
                        materialBtnNew.Visible = true;
                        matBtnCancel.Visible = false;
                        lstParentMenu.Enabled = true;
                        matBtnEDit.Visible = true;
                        matBtnDelete.Visible = true;
                        cboDepartmentMaterial.Enabled = false;
                        lstParentMenu_Click(sender, e);
                    }
                }

                txtMaterialMenu.Enabled = false;

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
                //dSet.Clear();
                //dSet = g_objStoredProcCollection.sp_ParentForms(0,
                //    txtMaterialMenu.Text.Trim(), "", "", "", "", "", "", "validate");

                //if (dSet.Tables[0].Rows.Count > 0)
                //{
                //    ParentMenuAlreadyTaken();
                //    txtMaterialMenu.Focus();
                //    return false;
                //}
                //else
                //{
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_ParentForms(0,
                    txtMaterialMenu.Text.Trim(),
                        sp_created_at,
                    txtCreatedBy.Text.Trim(),
                    this.Sp_modified_at,
                    txtModifiedBy.Text.Trim(),
                    this.Sp_CreatedByAndUserID,
                    sp_department_id,
                    "add");

                    getAllParentMenu();
                    matBtnNext_Click(new object(), new System.EventArgs());
                    return true;
                //}

            }

            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_ParentForms(temp_id,
                    txtMaterialMenu.Text.Trim(), "",
                    this.Sp_CreatedByAndUserID, "", "", "", "", "getbyname");

                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_ParentForms(temp_id, txtMaterialMenu.Text.Trim(), "", "", "", "", "", "", "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == temp_id)
                    {
                        dSet.Clear();
                        dSet = g_objStoredProcCollection.sp_ParentForms(temp_id,
                            txtMaterialMenu.Text.Trim(),
                                 this.sp_created_at,
                            this.txtCreatedBy.Text.Trim(),                      
                            this.Sp_modified_at,
                            this.txtModifiedBy.Text.Trim(),
                            this.Sp_CreatedByAndUserID,
                            this.sp_department_id,
                            "edit");

                        return true;
                    }
                    else
                    {
                        ParentMenuAlreadyTaken();
                        txtMaterialMenu.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_ParentForms(temp_id,
                        this.txtMaterialMenu.Text.Trim(),
                            this.sp_created_at,
                        this.txtCreatedBy.Text.Trim(),
                        this.Sp_modified_at,
                        this.txtModifiedBy.Text.Trim(),
                        this.Sp_CreatedByAndUserID,
                       this.sp_department_id,
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
            if(mode=="add")
            {
           
            }
            else
            {
                doSearch();
                showvalue();
            }
   
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

                        dv.RowFilter = "parent_form_name like '%" + txtMaterialMenu.Text + "%'";

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
                txtMaterialMenu.Focus();
                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaterialMenu.Focus();
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
                    txtMaterialMenu.Text = lstParentMenu.Text;
                }

            }
        }

        private void matBtnEDit_Click(object sender, EventArgs e)
        {
            lstParentMenu.Enabled = false;

            if (lstParentMenu.Items.Count > 0)
            {
                this.mode = "edit";
                this.txtMaterialMenu.Enabled = true;
                this.txtMaterialMenu.ReadOnly = false;
                this.matBtnEDit.Visible = false;
                this.materialBtnNew.Visible = false;
                this.matBtnCancel.Visible = true;
                this.matBtnDelete.Visible = false;
                this.matBtnSave.Visible = true;
                this.cboDepartmentMaterial.Enabled = true;
                this.Sp_modified_at = (dNow.ToString("M/d/yyyy"));
                this.txtModifiedBy.Text = userinfo.emp_name.ToUpper();
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
                            int index = lstParentMenu.FindString(txtMaterialMenu.Text, 0);
                            if (index == -1) { index = 0; }
                            lstParentMenu.SelectedIndex = index;
                        }

                        mode = "";
                        lstParentMenu.Enabled = true;
                        DeletedSuccessfully();
                        load_search();
                        doSearch();

                        matBtnEDit.Visible = true;
                        lstParentMenu_Click(sender, e);
                    }
                }
                //}

            }
            else
            {

                matBtnEDit.Visible = true;
                return;
            }
        }

        private void dgv_table_CurrentCellChanged(object sender, EventArgs e)
        {
            this.showParentMenuDetails();
        }
        private void showParentMenuDetails()
        {
            if (this.dgv_table.RowCount > 0)
            {
                if (this.dgv_table.CurrentRow != null)
                {
                    if (this.dgv_table.CurrentRow.Cells["parent_form_name"].Value != null)
                    {
                        this.txtMaterialMenu.Text = dgv_table.CurrentRow.Cells["parent_form_name"].Value.ToString();                
                        this.txtCreatedBy.Text = dgv_table.CurrentRow.Cells["created_by"].Value.ToString();
                        this.sp_created_at = dgv_table.CurrentRow.Cells["created_at"].Value.ToString();
                        this.txtMaterialDepartment.Text = dgv_table.CurrentRow.Cells["department"].Value.ToString();
                        this.txtModifiedBy.Text = dgv_table.CurrentRow.Cells["updated_by"].Value.ToString();
                        this.Sp_modified_at = dgv_table.CurrentRow.Cells["updated_at"].Value.ToString();
                    }

                }
            }
        }

        private void lstParentMenu_CursorChanged(object sender, EventArgs e)
        {
            //doSearch();
            if (mode == "add")
            {
          
            }
            else
            {
                showvalue();
            }
        }

        private void lstParentMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //doSearch();
            if (mode == "add")
            {
            
            }
            else
            {
                showvalue();
            }
        }

        private void lstParentMenu_SelectedValueChanged(object sender, EventArgs e)
        {
            //doSearch();
            if (mode == "add")
            {
            
            }
            else
            {
                showvalue();
            }
        }

        private void cboDepartmentMaterial_SelectedValueChanged(object sender, EventArgs e)
        {
          sp_department_id = cboDepartmentMaterial.SelectedValue.ToString();
        }

        private void BtnModuleClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboDepartmentMaterial_SelectionChangeCommitted(object sender, EventArgs e)
        {
           sp_department_id = cboDepartmentMaterial.SelectedValue.ToString();
        }

        private void txtMaterialMenu_TextChanged(object sender, EventArgs e)
        {
            if(lbltotalrecords.Text =="0")
            {

            }
            else
            {
                //showvalue();
                //doSearch();
            }
          
       
        }

        private void materialBtnNew_Click(object sender, EventArgs e)
        {
            mode = "add";
            cboDepartmentMaterial.Visible = true;
            txtMaterialDepartment.Visible = false;
            matBtnDelete.Visible = false;
            materialBtnNew.Visible = false;

            lstParentMenu.Enabled = false;

            txtMaterialMenu.Enabled = true;
            txtMaterialMenu.Text = string.Empty;
            matBtnCancel.Visible = true;


            sp_created_at = (dNow.ToString("M/d/yyyy"));
            txtCreatedBy.Text = userinfo.emp_name.ToUpper();
            this.Sp_CreatedByAndUserID = userinfo.user_id.ToString();
            matBtnSave.Visible = true;
            matBtnEDit.Visible = false;
            cboDepartmentMaterial.Enabled = true;
            loadDepartment();
            txtMaterialMenu.Focus();
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cboDepartmentMaterial_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
           sp_department_id = cboDepartmentMaterial.SelectedValue.ToString();
        }

        private void matBtnDelete_Click(object sender, EventArgs e)
        {
            metroButtonDelete_Click(sender, e);
        }

        private void matBtnCancel_Click(object sender, EventArgs e)
        {
            lstParentMenu.Enabled = true;
            matBtnCancel.Visible = false;
            materialBtnNew.Visible = true;
            txtMaterialMenu.Enabled = false;
            matBtnDelete.Visible = true;
            matBtnSave.Visible = false;
            matBtnEDit.Visible = true;
            matBtnDelete.Visible = true;
            cboDepartmentMaterial.Enabled = false;
            cboDepartmentMaterial.Visible = false;
            txtMaterialDepartment.Visible = true;
        }

        private void matBtnSave_Click(object sender, EventArgs e)
        {
            metroButtonSave_Click(sender, e);
        }

        private void LastLine()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Fedora Notifications";
            popup.ContentText = "YOU ARE ALREADY IN THE LAST LINE";
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Red;
            popup.Popup();

            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            //popup.AnimationDuration = 1000;
            //popup.ShowOptionsButton.ToString();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);

            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }


        private void InsertMajorMenuasPartial()
        {

            dSet.Clear();
            dSet = g_objStoredProcCollection.sp_userfileIncrement(0,
                Convert.ToInt32(sp_user_rights_id),
                "s",
                "s",
               "s",
                "s",
                "s",
                "s",
                "s",
                "s",
                "s",
                "s",
                Convert.ToInt32(temp_id).ToString(), "addModuleRightsMajorPartial");
        }

        private void matBtnNext_Click(object sender, EventArgs e)
        {
            showvalue();

            dSet.Clear();
            dSet = g_objStoredProcCollection.sp_userfileIncrement(0,
                Convert.ToInt32(sp_user_rights_id),
                "s10",
                "s9",
               "s8",
                "7",
                "s6",
                "s5",
                "s4",
                "s3",
                "s2",
                Convert.ToInt32(temp_id).ToString(),
                Convert.ToInt32(temp_id).ToString(), "addModuleRightsMajorPartial");

            if (dgvUserRights.Rows.Count >= 1)
            {
                int i = dgvUserRights.CurrentRow.Index + 1;
                if (i >= -1 && i < dgvUserRights.Rows.Count)
                    dgvUserRights.CurrentCell = dgvUserRights.Rows[i].Cells[0];
                else
                {
                    //LastLine();
                    displayUserRightsData();
                    //txtselectweight.Text = dgvAllFeedCode.CurrentRow.Cells["Quantity"].Value.ToString();
                    //timer1_Tick(sender, e);
                    //txtweighingscale.Focus();
                    return;
                }

            }
            matBtnNext_Click(sender, e);

        }

        private void dgvUserRights_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvUserRights.Rows.Count > 0)
            {
                if (dgvUserRights.CurrentRow != null)
                {
                    if (dgvUserRights.CurrentRow.Cells["user_rights_name"].Value != null)
                    {
                        //p_id = Convert.ToInt32(dgvChildForms.CurrentRow.Cells["menu_id"].Value);
                        sp_user_rights_id = dgvUserRights.CurrentRow.Cells["user_rights_id"].Value.ToString();
  
                    }
                }
            }
        }

        private void btnAddTool_Click_1(object sender, EventArgs e)
        {
            this.mode = "add";
            this.cboDepartmentMaterial.Visible = true;
            this.txtMaterialDepartment.Visible = false;
            this.matBtnDelete.Visible = false;
            this.materialBtnNew.Visible = false;

            this.lstParentMenu.Enabled = false;

            this.txtMaterialMenu.Enabled = true;
            this.txtMaterialMenu.Text = string.Empty;
            this.matBtnCancel.Visible = true;


            this.sp_created_at = (dNow.ToString("M/d/yyyy"));
            this.txtCreatedBy.Text = userinfo.emp_name.ToUpper();
            this.Sp_CreatedByAndUserID = userinfo.user_id.ToString();
            this.matBtnSave.Visible = true;
            this.matBtnEDit.Visible = false;
            this.cboDepartmentMaterial.Enabled = true;
            this.loadDepartment();
            this.txtMaterialMenu.Focus();
        }

        private void btnCancelTool_Click_1(object sender, EventArgs e)
        {
            lstParentMenu.Enabled = true;
            matBtnCancel.Visible = false;
            materialBtnNew.Visible = true;
            txtMaterialMenu.Enabled = false;
            matBtnDelete.Visible = true;
            matBtnSave.Visible = false;
            matBtnEDit.Visible = true;
            matBtnDelete.Visible = true;
            cboDepartmentMaterial.Enabled = false;
            cboDepartmentMaterial.Visible = false;
            txtMaterialDepartment.Visible = true;
        }

        private void btnDeleteTool_Click_1(object sender, EventArgs e)
        {
            metroButtonDelete_Click(sender, e);
        }

        private void btnUpdateTool_Click_1(object sender, EventArgs e)
        {

            if(mode =="add")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_ParentForms(0,
                    txtMaterialMenu.Text.Trim(), "", "", "", "", "", "", "validate");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    ParentMenuAlreadyTaken();
                    txtMaterialMenu.Focus();
                    return;
                }
            }
            metroButtonSave_Click(sender, e);
        }

        private void btnEditTool_Click(object sender, EventArgs e)
        {
            
                this.lstParentMenu.Enabled = false;

                if (this.lstParentMenu.Items.Count > 0)
                {
                    this.mode = "edit";
                    this.txtMaterialMenu.Enabled = true;
                    this.txtMaterialMenu.ReadOnly = false;
                    this.matBtnEDit.Visible = false;
                    this.materialBtnNew.Visible = false;
                    this.matBtnCancel.Visible = true;
                    this.matBtnDelete.Visible = false;
                    this.matBtnSave.Visible = true;
                    this.cboDepartmentMaterial.Enabled = true;
                    this.Sp_modified_at = (dNow.ToString("M/d/yyyy"));
                    this.txtModifiedBy.Text = userinfo.emp_name.ToUpper();
                }
            }

        private void txtMaterialMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
