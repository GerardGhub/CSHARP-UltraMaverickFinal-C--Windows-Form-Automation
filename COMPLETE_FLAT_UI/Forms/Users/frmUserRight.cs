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
            ListViewmenu.Enabled = false;
            dataView.Enabled = false;
    
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
        }

        private void listViewuser_rights_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            mode = "add";
            btnNew.Visible = false;
    
            btnUpdate.Visible = true;
            txtRights.ReadOnly = false;
            btnDelete.Visible = false;
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
            btnNew.Visible = true;
            btnUpdate.Visible = false;
            btnEdit.Visible = true;
            txtRights.ReadOnly = true;
            listViewuser_rights.Enabled = true;
            dataView.Visible = false;
            cbcategory.Visible = false;
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
                        btnEdit.Visible = true;
                        btnUpdate.Visible = false;
                        if (listViewuser_rights.Items.Count > 0)
                        {
                            int index = listViewuser_rights.FindString(txtRights.Text, 0);
                            if (index == -1) { index = 0; }
                            listViewuser_rights.SelectedIndex = index;
                        }
                        btnCancel_Click("", e);
                        btnNew.Visible = true;
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
 
            cbcategory.Visible = true;
    

            btnNew.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnCancel.Visible = false;
            btnEdit.Visible = false;
            panel3Enabled();
            UpdateMenu();
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
            btnUpdate.Visible = true;
            btnEdit.Visible = false;
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
          
           btnCancelListViewMenu.Visible = false;
    
            deselectAll();
            dataView.Enabled = false;
            ListViewmenu.Enabled = false;
            listViewuser_rights.Enabled = true;
            cbcategory.Visible = false;
            lblAvailableMenu.Visible = false;
            btnNew.Visible = true;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            btnCancel.Visible = true;
           
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
            popup.TitleText = "Fedora Notifications";
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
            //popup.AnimationDuration = 1000;
            //popup.ShowOptionsButton.ToString();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            //txtMainInput.Focus();
            //txtMainInput.Select();
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
                    //if (MessageBox.Show("Are you sure you want to delete this record?", lblName.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    //{
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
    }
}
