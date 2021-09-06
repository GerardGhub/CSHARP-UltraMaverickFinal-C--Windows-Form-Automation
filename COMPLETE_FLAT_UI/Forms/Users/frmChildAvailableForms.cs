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
    public partial class frmChildAvailableForms : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();

        string mode = "";
        int p_id = 0;
        int temp_hid = 0;
        DateTime dNow = DateTime.Now;
        Boolean ready = false;


        DataSet dSet_temp = new DataSet();

        public frmChildAvailableForms()
        {
            InitializeComponent();
        }

        private void BtnModuleClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChildAvailableForms_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            displayChildFormsData();
            loadParentMenu();
            displayUserRightsData();
        }
        private void displayUserRightsData()      //method for loading available_menus
        {

            xClass.fillDataGridView(dgvUserRights, "user_rights", dSet);


        }

        public void loadParentMenu()
        {
          
          
            //ready = false;
            myClass.fillComboBoxDepartment(cboParentMenu, "parentform_dropdown", dSet);
            //ready = true;

            txtcount.Text = cboParentMenu.SelectedValue.ToString();

        }

        private void displayChildFormsData()      //method for loading available_menus
        {
            try
            {
                ready = false;
                xClass.fillDataGridView(dgvChildForms, "available_menu", dSet);
                ready = true;
                lbltotalrecords.Text = dgvChildForms.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }



        private void txt_read_only(Boolean val)
        {
            txtfname.ReadOnly = val;
            txtmname.ReadOnly = val;
            txtcount.ReadOnly = val;

            if (val == false)
            {
                if (mode == "add")
                {
                    txtmname.Text = "";
                    txtfname.Text = "";
                    txtcount.Text = "";
                    txtmname.Focus();
                }
                else
                {
                    txtmname.Focus();
                }
            }

        }

        private void btnAddTool_Click(object sender, EventArgs e)
        {
            mode = "add";
            btn_visible(false);
            txt_read_only(false);
            txtmname.Enabled = true;
            txtfname.Enabled = true;
            txtcount.Enabled = true;
            cboParentMenu.Text = String.Empty;
            txtModifiedAt.Text = String.Empty;
            txtModifiedBy.Text = String.Empty;
            cboParentMenu.Enabled = true;
            txtcount.Text = cboParentMenu.SelectedValue.ToString(); //Binding First Meet
            txtCreatedAt.Text = (dNow.ToString("M/d/yyyy"));
            txtCreatedBy.Text = userinfo.emp_name.ToUpper();
            txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            txtmname.Select();
            txtmname.Focus();

        }
        private void btn_visible(Boolean val)
        {
            btnAddTool.Visible = val;
            btnEditTool.Visible = val;
            btnDeleteTool.Visible = val;
    

            btnUpdateTool.Visible = !val;
            btnCancelTool.Visible = !val;
        }

        private void btnCancelTool_Click(object sender, EventArgs e)
        {
            mode = "";
            txt_read_only(true);
            btn_visible(true);
            dgvChildForms_CurrentCellChanged(sender, e);
            txtmname.Enabled = false;
            txtfname.Enabled = false;
            cboParentMenu.Enabled = false;
        }

        private void dgvChildForms_CurrentCellChanged(object sender, EventArgs e)
        {
            showValue();
        }

        private void showValue()
        {
            if (dgvChildForms.Rows.Count > 0)
            {
                if (dgvChildForms.CurrentRow != null)
                {
                    if (dgvChildForms.CurrentRow.Cells["menu_id"].Value != null)
                    {
                        p_id = Convert.ToInt32(dgvChildForms.CurrentRow.Cells["menu_id"].Value);
                        txtfname.Text = dgvChildForms.CurrentRow.Cells["menu_form_name"].Value.ToString();
                        txtmname.Text = dgvChildForms.CurrentRow.Cells["menu_name"].Value.ToString();
                        cboParentMenu.Text = dgvChildForms.CurrentRow.Cells["count"].Value.ToString();
                        txtCreatedAt.Text = dgvChildForms.CurrentRow.Cells["created_at"].Value.ToString();
                        txtCreatedBy.Text = dgvChildForms.CurrentRow.Cells["created_by"].Value.ToString();
                        txtCreatedAt.Text = dgvChildForms.CurrentRow.Cells["updated_at"].Value.ToString();
                        txtModifiedBy.Text = dgvChildForms.CurrentRow.Cells["updated_by"].Value.ToString();
                    }
                }
            }
        }


        private void cboParentMenu_SelectedValueChanged(object sender, EventArgs e)
        {
            txtcount.Text = cboParentMenu.SelectedValue.ToString();
        }

        private void dgvChildForms_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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


        public void FillRequiredFields()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Fill up the required fields!";
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

        public void ChildMenuAlreadyExist()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Child Menu Already Exist!";
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

        private void UpdateNotifications()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "SUCCESSFULLY UPDATE FORM INFORMATION";
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


        private void metroSave_Click(object sender, EventArgs e)
        {
            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update the Child Form Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                if (cboParentMenu.Text.Trim() == string.Empty)
                {
                    FillRequiredFields();
                    cboParentMenu.Focus();


                    return;
                }


                if (txtmname.Text.Trim() == string.Empty)
                {
                    FillRequiredFields();
                    txtmname.Focus();


                    return;
                }

                if (txtfname.Text.Trim() == string.Empty)
                {
                    FillRequiredFields();
                    txtfname.Focus();
                    return;
                }

                if (txtcount.Text.Trim() == string.Empty)
                {

                    FillRequiredFields();
                    txtcount.Focus();
                    return;
                }

                else
                {
                    if (saveMode())
                    {
                        //displayChildFormsData();
                        string tmode = mode;

                        if (tmode == "add")
                        {
                            dgvChildForms.CurrentCell = dgvChildForms[0, dgvChildForms.Rows.Count - 1];
                            UpdateNotifications();
                        }
                        else
                        {
                            dgvChildForms.CurrentCell = dgvChildForms[0, temp_hid];

                        }
                        btnCancelTool_Click(sender, e);
                        UpdateNotifications();
                    }
                    else

                        metroFinalSaving_Click(sender, e);
                    return;
                }
            }

            else
            {
                return;
            }


            //End

        }

        public bool saveMode()      //method for saving of data base on mode (add,edit,delete)
        {

            if (mode == "add")
            {
                dSet.Clear();
                dSet = objStorProc.sp_available_menu(0, txtmname.Text, "", "","","","","", "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    ChildMenuAlreadyExist();

                    txtmname.Text = string.Empty;
                    txtmname.Focus();
                    return false;
                }
                else
                {

                    dSet.Clear();
                    dSet = objStorProc.sp_available_menu(0, txtmname.Text.Trim(), 
                        txtfname.Text.Trim(), 
                        txtcount.Text.Trim(), 
                        txtCreatedAt.Text.Trim(), 
                        txtCreatedBy.Text.Trim(), 
                        txtModifiedAt.Text.Trim(), 
                        txtModifiedBy.Text.Trim(), "add");

                    displayChildFormsData();
                    matBtnNext_Click(new object(), new System.EventArgs());
                    displayUserRightsData();
                    displayChildFormsData();
                    return true;
                }
            }
            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = objStorProc.sp_available_menu(0, txtmname.Text, "", "","","","","", "getbyname");

                dSet_temp.Clear();
                dSet_temp = objStorProc.sp_available_menu(p_id, txtmname.Text, "", "","","","","", "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == p_id)
                    {
                        dSet.Clear();
                        dSet = objStorProc.sp_available_menu(p_id, txtmname.Text.Trim(), 
                            txtfname.Text.Trim(), 
                            txtcount.Text.Trim(), 
                            txtCreatedAt.Text.Trim(), 
                            txtCreatedBy.Text.Trim(), 
                            txtModifiedAt.Text.Trim(), 
                            txtModifiedBy.Text.Trim(), "edit");
                        UpdateNotifications();
               
                        return true;
                    }
                    else
                    {
                        ChildMenuAlreadyExist();
                        txtmname.Text = String.Empty;
                        txtmname.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = objStorProc.sp_available_menu(p_id, txtmname.Text.Trim(), 
                        txtfname.Text.Trim(), 
                        txtcount.Text.Trim(), 
                        txtCreatedAt.Text.Trim(), 
                        txtCreatedBy.Text.Trim(), 
                        txtModifiedAt.Text.Trim(), 
                        txtModifiedBy.Text.Trim(), "edit");

       
                }
            }
            else if (mode == "delete")
            {
         
                dSet_temp.Clear();
                dSet_temp = objStorProc.sp_available_menu(p_id, txtmname.Text, "", "","","","","", "delete");

                return true;
            }
            return false;
        }


        private void btnUpdateTool_Click(object sender, EventArgs e)
        {
            dSet.Clear();
            dSet = objStorProc.sp_available_menu(0, txtmname.Text, "", "", "", "", "", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                ChildMenuAlreadyExist();

            
                txtmname.Focus();
                return;
            }
            else
            {
                metroSave_Click(sender, e);
            }


        }

        private void metroFinalSaving_Click(object sender, EventArgs e)
        {
            if (txtmname.Text.Trim() == string.Empty)
            {
                FillRequiredFields();
                txtfname.Focus();
                return;
            }

            if (txtfname.Text.Trim() == string.Empty)
            {
                FillRequiredFields();
                txtfname.Focus();
            }
            else
            {
                if (saveMode())
                {
                    displayChildFormsData();
                    string tmode = mode;

                    if (tmode == "add")
                    {
                        dgvChildForms.CurrentCell = dgvChildForms[0, dgvChildForms.Rows.Count - 1];
                    }
                    else
                    {
                        dgvChildForms.CurrentCell = dgvChildForms[0, temp_hid];
                    }
                    btnCancelTool_Click(sender, e);
                }
                else
          
                    return;
            }
        }

        private void btnEditTool_Click(object sender, EventArgs e)
        {
            txtModifiedAt.Text = (dNow.ToString("M/d/yyyy"));
            txtModifiedBy.Text = userinfo.emp_name.ToUpper();
            if (dgvChildForms.RowCount > 0)
            {
                temp_hid = dgvChildForms.CurrentRow.Index;
                txtfname.Enabled = true;
                txtmname.Enabled = true;
                txtcount.Enabled = true;
                cboParentMenu.Enabled = true;
                mode = "edit";

                btn_visible(false);
                txt_read_only(false);
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

        private void btnDeleteTool_Click(object sender, EventArgs e)
        {
            if (dgvChildForms.Rows.Count > 0)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to delete the ChildForm Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {




               
                    mode = "delete";

                    if (saveMode())
                    {
                        DeletedSuccessfully();
                        displayChildFormsData();

                        btnCancelTool_Click("", e);
                    }
                }

                else
                {
                    return;
                }






            }



        }

        private void materialBtnNew_Click(object sender, EventArgs e)
        {
            mode = "add";
            btn_visible(false);
            txt_read_only(false);
            txtmname.Enabled = true;
            txtfname.Enabled = true;
            txtcount.Enabled = true;
            cboParentMenu.Text = String.Empty;
            txtModifiedAt.Text = String.Empty;
            txtModifiedBy.Text = String.Empty;
            cboParentMenu.Enabled = true;
            txtcount.Text = cboParentMenu.SelectedValue.ToString(); //Binding First Meet
            txtCreatedAt.Text = (dNow.ToString("M/d/yyyy"));
            txtCreatedBy.Text = userinfo.emp_name.ToUpper();
            txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            txtmname.Select();
            txtmname.Focus();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            txtModifiedAt.Text = (dNow.ToString("M/d/yyyy"));
            txtModifiedBy.Text = userinfo.emp_name.ToUpper();
            if (dgvChildForms.RowCount > 0)
            {
                temp_hid = dgvChildForms.CurrentRow.Index;
                txtfname.Enabled = true;
                txtmname.Enabled = true;
                txtcount.Enabled = true;
                cboParentMenu.Enabled = true;
                mode = "edit";

                btn_visible(false);
                txt_read_only(false);
            }
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            dSet.Clear();
            dSet = objStorProc.sp_available_menu(0, txtmname.Text, "", "", "", "", "", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                ChildMenuAlreadyExist();


                txtmname.Focus();
                return;
            }
            else
            {
                metroSave_Click(sender, e);
            }
        }

        private void materialButton1_Click_2(object sender, EventArgs e)
        {
            if (dgvChildForms.Rows.Count > 0)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to delete the ChildForm Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {





                    mode = "delete";

                    if (saveMode())
                    {
                        DeletedSuccessfully();
                        displayChildFormsData();

                        btnCancelTool_Click("", e);
                    }
                }

                else
                {
                    return;
                }






            }

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            mode = "";
            txt_read_only(true);
            btn_visible(true);
            dgvChildForms_CurrentCellChanged(sender, e);
            txtmname.Enabled = false;
            txtfname.Enabled = false;
            cboParentMenu.Enabled = false;
        }

        private void dgvChildForms_CurrentCellChanged_1(object sender, EventArgs e)
        {
            showValue();
        }

        private void metroComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            txtcount.Text = cboParentMenu.SelectedValue.ToString();
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
                        txtRightsID.Text = dgvUserRights.CurrentRow.Cells["user_rights_id"].Value.ToString();

                    }
                }
            }
        }

        private void matBtnNext_Click(object sender, EventArgs e)
        {
            //showValue();

            dSet.Clear();
            dSet = g_objStoredProcCollection.sp_userfile(0,
                Convert.ToInt32(txtRightsID.Text),
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
                Convert.ToInt32(p_id).ToString(), "addModuleRightsSubMenuPartial");

            if (dgvUserRights.Rows.Count >= 1)
            {
                int i = dgvUserRights.CurrentRow.Index + 1;
                if (i >= -1 && i < dgvUserRights.Rows.Count)
                    dgvUserRights.CurrentCell = dgvUserRights.Rows[i].Cells[0];
                else
                {
                    //LastLine();
        
                    return;
                }

            }
            matBtnNext_Click(sender, e);
        }

        private void materialButton1_Click_3(object sender, EventArgs e)
        {
           
        }

        private void cboParentMenu_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}
