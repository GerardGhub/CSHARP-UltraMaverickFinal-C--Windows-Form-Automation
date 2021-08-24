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
    public partial class frmUserRight : Form
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        DataSet dSet = new DataSet();
        Boolean ready = false;
        string mode = "";
        int p_id = 0;
        myclasses myClass = new myclasses();
        DataSet dSet_temp = new DataSet();
        public frmUserRight()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserRight_Load(object sender, EventArgs e)
        {
            objStorProc = xClass.g_objStoredProc.GetCollections();
            displayUserRights();
            listViewuser_rights_Click(sender, e);
            FalseButton();
          
            loadParentMenu();
            ListViewmenu.Enabled = false;
            dataView.Enabled = false;
            myglobal.global_module = "Active"; // Mode for Searching

            getAllTaggedParentMenu(); //Tagged Equal ==

        }
        public void loadParentMenu()
        {
            ready = false;
            myClass.fillComboBoxDepartment(cboParentMenu, "parentform_dropdown", dSet);
            ready = true;

            lblparentmenuid.Text = cboParentMenu.SelectedValue.ToString();
        }



        private void getAllTaggedParentMenu()
        {
            dset_emp = objStorProc.sp_getMajorTables("ParentFormsTaggedRightsMenu");

            if (dset_emp.Tables.Count > 0)
            {
                DataView dv = new DataView(dset_emp.Tables[0]);
                if (myglobal.global_module == "EMPLOYEE")
                {

                }
                else if (myglobal.global_module == "Active")
                {

                    dv.RowFilter = "user_rights_name = '" + txtRights.Text + "' ";

                }
                else if (myglobal.global_module == "VISITORS")
                {

                }
                dgvTagParentMenu.DataSource = dv;
                //lblrecords.Text = dgv_table.RowCount.ToString();
            }


        }

        private void getAllParentMenu()
        {
            dset_emp = objStorProc.sp_getMajorTables("ParentFormsRightsMenu");

            if (dset_emp.Tables.Count > 0)
            {
                DataView dv = new DataView(dset_emp.Tables[0]);
                if (myglobal.global_module == "EMPLOYEE")
                {

                }
                else if (myglobal.global_module == "Active")
                {

                    dv.RowFilter = "user_rights_name <> ('" + txtRights.Text + "')";

                }
                else if (myglobal.global_module == "VISITORS")
                {

                }
                dgvParentMenu.DataSource = dv;
                //lblrecords.Text = dgv_table.RowCount.ToString();
            }
          


        }

        public void FalseButton()

        {
            btnMenuUpdate.Enabled = false;
            btnRemoveMenu.Enabled = false;
            btnCancelListViewMenu.Enabled = false;
            btnSelectAll.Enabled = false;
            btnUnselectAll.Enabled = false;


        }
        public void displayUserRights()
        {
            ready = false;
            xClass.fillListBox(listViewuser_rights, "user_rights", dSet);
            ready = true;
            lbltotalrecordsrights.Text = listViewuser_rights.Items.Count.ToString();
        }

        private void listViewuser_rights_Click(object sender, EventArgs e)
        {
            btnDeleteTool.Visible = true;
            btnAddMenu.Visible = true;
            showvalue();
            loadMenu_byUsers();
        }
        public void showvalue()
        {
            if (ready == true)
            {
                if (listViewuser_rights.Items.Count > 0)
                {
                    p_id = Convert.ToInt32(listViewuser_rights.SelectedValue.ToString());
                    txtRights.Text = listViewuser_rights.Text;
                  
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            mode = "add";
            btnAddTool.Visible = false;

            btnUpdateTool.Visible = true;
            txtRights.ReadOnly = false;
            btnDeleteTool.Visible = false;
            btnAddMenu.Visible = false;
            txtRights.Text = "";
            txtRights.Focus();
            listViewuser_rights.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtRights.Text.Trim() == string.Empty)
            {
                FillUserRights();
                txtRights.Focus();
                return;

            }
            btnMetroSave_Click(sender, e);
         
        }

        void FillUserRights()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Fedora Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "WARNING FILL UP THE REQUIRED FIELDS ";
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
                dSet = objStorProc.sp_user_rights(0, txtRights.Text, "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    UserRightexists();
                    //MessageBox.Show(lblName.Text + " : [ " + txtRights.Text + " ] already exist...", lblName.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRights.Focus();
                    return false;
                }
                else
                {
                    dSet.Clear();
                    dSet = objStorProc.sp_user_rights(0, txtRights.Text, "add");


                    return true;
                }
            }
            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = objStorProc.sp_user_rights(0, txtRights.Text, "getbyname");

                dSet_temp.Clear();
                dSet_temp = objStorProc.sp_user_rights(p_id, txtRights.Text, "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == p_id)
                    {
                        dSet.Clear();
                        dSet = objStorProc.sp_user_rights(p_id, txtRights.Text, "edit");


                        return true;
                    }
                    else
                    {
                        //sample muna
                        //MessageBox.Show(lblName.Text + " : [ " + txtRights.Text + " ] already exist...", lblName.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtRights.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = objStorProc.sp_user_rights(p_id, txtRights.Text, "edit");

                    return true;
                }
            }
            else if (mode == "delete")
            {
                dSet.Clear();
                dSet = objStorProc.sp_user_rights(p_id, txtRights.Text, "delete");

                dSet_temp.Clear();
                dSet_temp = objStorProc.sp_user_rights(p_id, txtRights.Text, "delete");

                return true;
            }
            return false;
        }

        public void UserRightsUpdated()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Fedora Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "USER RIGHTS UPDATED";
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

        void UserRightexists()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Fedora Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "WARNING USER RIGHTS ALREADY EXISTS " + txtRights.Text + " ";
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            mode = "";
            btnAddTool.Visible = true;
            btnUpdateTool.Visible = false;
            btnEditTool.Visible = true;
            txtRights.ReadOnly = true;
            listViewuser_rights.Enabled = true;
            dataView.Visible = false;
            cboParentMenu.Visible = false;
            lblAvailableMenu.Visible = false;
        }

        private void btnMetroSave_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Save the New User Type", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (txtRights.Text.Trim() == string.Empty)
                {
                    FillUserRights();
                    txtRights.Focus();
                    //MessageBox.Show("Please enter " + lblName.Text + ". ", lblName.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (saveMode())
                    {
                        displayUserRights();
                        btnEditTool.Visible = true;
                        btnUpdateTool.Visible = false;
                        if (listViewuser_rights.Items.Count > 0)
                        {
                            int index = listViewuser_rights.FindString(txtRights.Text, 0);
                            if (index == -1) { index = 0; }
                            listViewuser_rights.SelectedIndex = index;
                        }
                        btnCancel_Click("", e);
                        btnAddTool.Visible = true;
                        UserRightsUpdated();
                    }
                }

            }
            else
            {

                return;
            }
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            dataView.Visible = true;
            lblAvailableMenu.Visible = true;
            btnCancelListViewMenu.Visible = true;
            dataView.Enabled = true;
            ListViewmenu.Enabled = true;
           listViewuser_rights.Enabled = false;

            cboParentMenu.Visible = true;
      

            btnAddTool.Visible = false;
            btnUpdateTool.Visible = false;
            btnDeleteTool.Visible = false;
            btnCancelTool.Visible = false;
            btnEditTool.Visible = false;
            cboParentMenu.Enabled = true;
            btnMenuUpdate.Visible = true;
            panel3Enabled();
            UpdateMenu();
            loadAvailableMenu();
            load_search_ChildMenu(); //Bind the Information
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

                        dv.RowFilter = "count = '" + lblparentmenuid.Text + "'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dataView.DataSource = dv;
                    //lblrecords.Text = dgv_table.RowCount.ToString();
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






       private  void doSearchTagParentMenu()
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

                        dv.RowFilter = "count = '" + lblparentmenuid.Text + "'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dgvTagParentMenu.DataSource = dv;
                    //lblrecords.Text = dgv_table.RowCount.ToString();
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


       
        public void load_search_ChildMenu()
        {
            dset_emp.Clear();

            if (myglobal.global_module == "EMPLOYEE")
            { dset_emp = objStorProc.sp_getMajorTables("employee"); }

            else if (myglobal.global_module == "Active")
            { dset_emp = objStorProc.sp_getMajorTables("ParentMenuTagging"); }
            else if (myglobal.global_module == "InActive")
            { dset_emp = objStorProc.sp_getMajorTables("InactiveFeedCode"); }


            doSearch();

        }

        public void load_search_TaggedChildMenu()
        {
            dset_emp.Clear();

            if (myglobal.global_module == "EMPLOYEE")
            { dset_emp = objStorProc.sp_getMajorTables("employee"); }

            else if (myglobal.global_module == "Active")
            { dset_emp = objStorProc.sp_getMajorTables("ParentMenuTagging"); }
            else if (myglobal.global_module == "InActive")
            { dset_emp = objStorProc.sp_getMajorTables("InactiveFeedCode"); }


            doSearchTagParentMenu();

        }


        public void panel3Enabled()
        {
            btnMenuUpdate.Enabled = true;
            btnRemoveMenu.Enabled = true;
            btnCancelListViewMenu.Enabled = true;
            btnSelectAll.Enabled = true;
            btnUnselectAll.Enabled = true;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mode = "edit";
            txtRights.ReadOnly = false;
            txtRights.Focus();
            listViewuser_rights.Enabled = false;
            btnUpdateTool.Visible = true;
            btnEditTool.Visible = false;
        }

        public void UpdateMenu()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Fedora Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Forms Available Activated Ready for Tagging !";
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

        private void btnCancelListViewMenu_Click(object sender, EventArgs e)
        {
            btnSelectAll.Visible = false;
            btnUnselectAll.Visible = false;
            dataView.Visible = false;
            cboParentMenu.Enabled = false;
            btnCancelListViewMenu.Visible = false;
    
            deselectAll();
            dataView.Enabled = false;
            ListViewmenu.Enabled = false;
            listViewuser_rights.Enabled = true;
            cboParentMenu.Visible = false;
            lblAvailableMenu.Visible = false;
            btnAddTool.Visible = true;
            btnUpdateTool.Visible = true;
            btnDeleteTool.Visible = true;
            btnCancelTool.Visible = true;
           
        }


        public void selectAll()
        {
            for (int i = 0; i < dataView.RowCount; i++) { dataView.Rows[i].Cells[0].Value = true; }
        }
        public void deselectAll()
        {
            for (int i = 0; i < dataView.RowCount; i++) { dataView.Rows[i].Cells[0].Value = false; }
        }

        private void listViewuser_rights_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadMenu_byUsers();
        }
         public void loadMenu_byUsers()
        {
            ready = false;
            xClass.fillListBox_Id(ListViewmenu, "filter_users", dSet, p_id, 0, 0);
            ready = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtRights.Text.Trim() == string.Empty)
            {
                SelectUserRights();
                listViewuser_rights.Enabled = true;
             
                txtRights.Focus();
             
                return;

            }
            metroButtonDelete_Click(sender, e);
        }

        public void SelectUserRights()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Fedora Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Please Select User Rights";
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

        public void UserRighstDeleted()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "USER RIGHTS DELETED SUCCESSFULLY !";
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

        public void AlreadyAddedOnYourParentMenu()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "This menu is already added on your rights !";
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

        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Removed The User Right ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (listViewuser_rights.Items.Count > 0)
                {
           

                    mode = "delete";
                    if (saveMode())
                    {
                        displayUserRights();
                        if (listViewuser_rights.Items.Count > 0)
                        {
                            int index = listViewuser_rights.FindString(txtRights.Text, 0);
                            if (index == -1) { index = 0; }
                            listViewuser_rights.SelectedIndex = index;
                        }
                        mode = "";
                        listViewuser_rights_Click(sender, e);
                        UserRighstDeleted();
                    }
                }
                //}

            }
            else
            {

                return;
            }
        }

        private void btnAddTool_Click(object sender, EventArgs e)
        {
            mode = "add";
            btnAddTool.Visible = false;
            btnCancelTool.Visible = true;
            btnUpdateTool.Visible = true;
            txtRights.ReadOnly = false;
            btnDeleteTool.Visible = false;
            btnAddMenu.Visible = false;
            txtRights.Text = "";
            txtRights.Focus();
            listViewuser_rights.Enabled = false;
        }

        private void btnCancelTool_Click(object sender, EventArgs e)
        {
            mode = "";
            btnAddTool.Visible = true;
            btnUpdateTool.Visible = false;
            btnEditTool.Visible = true;
            txtRights.ReadOnly = true;
            listViewuser_rights.Enabled = true;
            dataView.Visible = false;
            cboParentMenu.Visible = false;
            lblAvailableMenu.Visible = false;
        }

        private void btnEditTool_Click(object sender, EventArgs e)
        {
            mode = "edit";
            txtRights.ReadOnly = false;
            txtRights.Focus();
            listViewuser_rights.Enabled = false;
            btnUpdateTool.Visible = true;
            btnEditTool.Visible = false;
        }

        private void btnDeleteTool_Click(object sender, EventArgs e)
        {
            if (txtRights.Text.Trim() == string.Empty)
            {
                SelectUserRights();
                listViewuser_rights.Enabled = true;

                txtRights.Focus();

                return;

            }
            metroButtonDelete_Click(sender, e);
        }

        private void btnUpdateTool_Click(object sender, EventArgs e)
        {
            if (txtRights.Text.Trim() == string.Empty)
            {
                FillUserRights();
                txtRights.Focus();
                return;

            }
            btnMetroSave_Click(sender, e);
        }


        private void loadAvailableMenu()
        {
            //xClass.fillDataGridView(dataView, cboParentMenu.Text, dSet);
            //dataView.Columns[2].Width = 500;
            //dataView.Columns[1].Width = 50;
            //dataView.Columns[0].Width = 30;
            //dataView.Columns[2].HeaderText = "Menu Name";
            //dataView.Columns[3].Visible = false;
        }

        private void cbcategory_DropDownClosed(object sender, EventArgs e)
        {
            //loadAvailableMenu();
            //btnselect.Visible = true;
            //btndeselect.Visible = true;
        }

        private void cboParentMenu_SelectedValueChanged(object sender, EventArgs e)
        {

            lblparentmenuid.Text = cboParentMenu.SelectedValue.ToString();
            doSearch();
        }

        private void lblparentmenuid_Click(object sender, EventArgs e)
        {
         
        }

        private void TagParentMenu()
        {

            int x = 0;
            for (int i = 0; i < dgvParentMenu.RowCount; i++)
            {
                if (Convert.ToBoolean(dgvParentMenu.Rows[i].Cells[0].Value))
                    x++;
            }
            if (x <= 0)
            {
                MessageBox.Show("Please select a menu before updating.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                showvalue();
                for (int n = 0; n < dgvParentMenu.RowCount; n++)
                {
                    if (Convert.ToBoolean(dgvParentMenu.Rows[n].Cells[0].Value))
                    {
                        dSet.Clear();
                        dSet = objStorProc.sp_getMenu_by_user("get_already_added_forms", 0, p_id, Convert.ToInt32(dgvParentMenu.Rows[n].Cells[1].Value));
                        if (dSet.Tables[0].Rows.Count > 0)
                        {
                            string temp = dSet.Tables[0].Rows[0][2].ToString();
                            AlreadyAddedOnYourParentMenu();
                            //MessageBox.Show("This menu is already added on your rights: " + temp);
                            deselectAll();
                            return;
                        }
                    }
                }

                for (int i = 0; i < dgvParentMenu.RowCount; i++)
                {
                    dSet.Clear();
                    if (Convert.ToBoolean(dgvParentMenu.Rows[i].Cells[0].Value))
                    {
                        dSet = objStorProc.sp_user_rights_details(0, p_id, Convert.ToInt32(dgvParentMenu.Rows[i].Cells[1].Value), "add");
                    }
                }

                loadMenu_byUsers();
                SaveUpdateMenuNotifications();
                btnUnselectAll_Click(new object(), new System.EventArgs());
                btnCancelListViewMenu_Click(new object(), new System.EventArgs());
                load_search_ChildMenu(); // Select the Child
            
            }



        }

        private void SaveUpdateMenuNotifications()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "SUCCESSFULLY UPDATE THE FORMS";
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

        private void btnMenuUpdate_Click(object sender, EventArgs e)
        {
            int x = 0;
            for (int i = 0; i < dataView.RowCount; i++)
            {
                if (Convert.ToBoolean(dataView.Rows[i].Cells[0].Value))
                    x++;
            }
            if (x <= 0)
            {
                MessageBox.Show("Please select a menu before updating.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                showvalue();
                for (int n = 0; n < dataView.RowCount; n++)
                {
                    if (Convert.ToBoolean(dataView.Rows[n].Cells[0].Value))
                    {
                        dSet.Clear();
                        dSet = objStorProc.sp_getMenu_by_user("get_already_added_forms", 0, p_id, Convert.ToInt32(dataView.Rows[n].Cells[1].Value));
                        if (dSet.Tables[0].Rows.Count > 0)
                        {
                            string temp = dSet.Tables[0].Rows[0][2].ToString();
                            MessageBox.Show("This menu is already added on your rights: " + temp);
                            deselectAll();
                            return;
                        }
                    }
                }

                for (int i = 0; i < dataView.RowCount; i++)
                {
                    dSet.Clear();
                    if (Convert.ToBoolean(dataView.Rows[i].Cells[0].Value))
                    {
                        dSet = objStorProc.sp_user_rights_details(0, p_id, Convert.ToInt32(dataView.Rows[i].Cells[1].Value), "add");
                    }
                }

                loadMenu_byUsers();
                SaveUpdateMenuNotifications();
                btnUnselectAll_Click(sender, e);
                btnCancelListViewMenu_Click(sender, e);
                //panel1.Enabled = true;
            }


        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            selectAll();
        }

        private void btnUnselectAll_Click(object sender, EventArgs e)
        {
            deselectAll();
        }

        private void dataView_DoubleClick(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Insert The Policy", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                btnMenuUpdate_Click(sender, e);
                //this.ParentForm.Refresh();

            }
            else
            {

                return;
            }
        }

        private void dgvParentMenu_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void txtRights_TextChanged(object sender, EventArgs e)
        {
            if(lbltotalrecordsrights.Text.Trim() == "0")
            {

            }
            else
            {
                getAllTaggedParentMenu(); //Tagged Equal ==

                getAllParentMenu();
            }
        
        }

        private void dgvParentMenu_DoubleClick(object sender, EventArgs e)
        {

            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Insert The Policy", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                TagParentMenu();
             

            }
            else
            {

                return;
            }



        }

        private void dgvTagParentMenu_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
    }
}
