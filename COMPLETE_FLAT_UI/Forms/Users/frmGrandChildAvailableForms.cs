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
    public partial class frmGrandChildAvailableForms : Form
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;

        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();

        string mode = "";
        int p_id = 0;
        int temp_hid = 0;
        DateTime dNow = DateTime.Now;
        Boolean ready = false;


        DataSet dSet_temp = new DataSet();

        public frmGrandChildAvailableForms()
        {
            InitializeComponent();
        }

        private void BtnModuleClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGrandChildAvailableForms_Load(object sender, EventArgs e)
        {
            objStorProc = xClass.g_objStoredProc.GetCollections();
            displayGrandChildFormsData();

            loadChildMenu();
        }

        public void loadChildMenu()
        {
            ready = false;
            myClass.fillComboBoxDepartment(cboChildMenu, "childform_dropdown", dSet);
            ready = true;

            txtcountChildId.Text = cboChildMenu.SelectedValue.ToString();
        }

        private void displayGrandChildFormsData()      //method for loading available_menus
        {
            ready = false;
            xClass.fillDataGridView(dgvGrandChildForms, "available_menu_grandChild", dSet);
            ready = true;
            lbltotalrecords.Text = dgvGrandChildForms.RowCount.ToString();
        }

        private void dgvGrandChildForms_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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


        private void btn_visible(Boolean val)
        {
            btnAddTool.Visible = val;
            btnEditTool.Visible = val;
            btnDeleteTool.Visible = val;


            btnUpdateTool.Visible = !val;
            btnCancelTool.Visible = !val;
        }


        private void txt_read_only(Boolean val)
        {
            txtfname.ReadOnly = val;
            txtgchild.ReadOnly = val;
            txtcountChildId.ReadOnly = val;

            if (val == false)
            {
                if (mode == "add")
                {
                    txtgchild.Text = "";
                    txtfname.Text = "";
                    txtcountChildId.Text = "";
                    txtgchild.Focus();
                }
                else
                {
                    txtgchild.Focus();
                }
            }

        }

        private void btnAddTool_Click(object sender, EventArgs e)
        {
            mode = "add";
            btn_visible(false);
            txt_read_only(false);
            txtgchild.Enabled = true;
            txtfname.Enabled = true;
            txtcountChildId.Enabled = true;
            cboChildMenu.Text = String.Empty;
            txtModifiedAt.Text = String.Empty;
            txtModifiedBy.Text = String.Empty;
            cboChildMenu.Enabled = true;
            txtcountChildId.Text = cboChildMenu.SelectedValue.ToString(); //Binding First Meet
            txtCreatedAt.Text = (dNow.ToString("M/d/yyyy"));
            txtCreatedBy.Text = userinfo.emp_name.ToUpper();
            txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            txtgchild.Select();
            txtgchild.Focus();
        }

        public void GrandChildMenuAlreadyExist()
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


        private void btnUpdateTool_Click(object sender, EventArgs e)
        {
            dSet.Clear();
            dSet = objStorProc.sp_available_menu_grandChild(0, txtgchild.Text, "", "", "", "", "", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                GrandChildMenuAlreadyExist();


                txtgchild.Focus();
                return;
            }
            else
            {
                metroSave_Click(sender, e);
            }

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

                if (cboChildMenu.Text.Trim() == string.Empty)
                {
                    FillRequiredFields();
                    cboChildMenu.Focus();


                    return;
                }


                if (txtgchild.Text.Trim() == string.Empty)
                {
                    FillRequiredFields();
                    txtgchild.Focus();


                    return;
                }

                if (txtfname.Text.Trim() == string.Empty)
                {
                    FillRequiredFields();
                    txtfname.Focus();
                    return;
                }

                if (txtcountChildId.Text.Trim() == string.Empty)
                {

                    FillRequiredFields();
                    txtcountChildId.Focus();
                    return;
                }

                else
                {
                    if (saveMode())
                    {
                        displayGrandChildFormsData();
                        string tmode = mode;

                        if (tmode == "add")
                        {
                            dgvGrandChildForms.CurrentCell = dgvGrandChildForms[0, dgvGrandChildForms.Rows.Count - 1];
                            UpdateNotifications();
                        }
                        else
                        {
                            dgvGrandChildForms.CurrentCell = dgvGrandChildForms[0, temp_hid];

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

        private void btnCancelTool_Click(object sender, EventArgs e)
        {
            mode = "";
            txt_read_only(true);
            btn_visible(true);
            dgvGrandChildForms_CurrentCellChanged(sender, e);
            txtgchild.Enabled = false;
            txtfname.Enabled = false;
            cboChildMenu.Enabled = false;
        }

        private void dgvGrandChildForms_CurrentCellChanged(object sender, EventArgs e)
        {

        }


        public bool saveMode()      //method for saving of data base on mode (add,edit,delete)
        {

            if (mode == "add")
            {
                dSet.Clear();
                dSet = objStorProc.sp_available_menu_grandChild(0, txtgchild.Text, "", "", "", "", "", "", "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    GrandChildMenuAlreadyExist();

                    txtgchild.Text = string.Empty;
                    txtgchild.Focus();
                    return false;
                }
                else
                {
                    dSet.Clear();
                    dSet = objStorProc.sp_available_menu_grandChild(0, 
                        txtgchild.Text.Trim(),
                        txtfname.Text.Trim(),
                        txtcountChildId.Text.Trim(),
                        txtCreatedAt.Text.Trim(),
                        txtCreatedBy.Text.Trim(),
                        txtModifiedAt.Text.Trim(),
                        txtModifiedBy.Text.Trim(), "add");

                    return true;
                }
            }
            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = objStorProc.sp_available_menu_grandChild(0, 
                    txtgchild.Text, "", "", "", "", "", "", "getbyname");

                dSet_temp.Clear();
                dSet_temp = objStorProc.sp_available_menu_grandChild(p_id, 
                    txtgchild.Text, "", "", "", "", "", "", "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == p_id)
                    {
                        dSet.Clear();
                        dSet = objStorProc.sp_available_menu_grandChild(p_id, 
                            txtgchild.Text.Trim(),
                            txtfname.Text.Trim(),
                            txtcountChildId.Text.Trim(),
                            txtCreatedAt.Text.Trim(),
                            txtCreatedBy.Text.Trim(),
                            txtModifiedAt.Text.Trim(),
                            txtModifiedBy.Text.Trim(), "edit");
                        UpdateNotifications();

                        return true;
                    }
                    else
                    {
                        GrandChildMenuAlreadyExist();
                        txtgchild.Text = String.Empty;
                        txtgchild.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = objStorProc.sp_available_menu_grandChild(p_id, 
                        txtgchild.Text.Trim(),
                        txtfname.Text.Trim(),
                        txtcountChildId.Text.Trim(),
                        txtCreatedAt.Text.Trim(),
                        txtCreatedBy.Text.Trim(),
                        txtModifiedAt.Text.Trim(),
                        txtModifiedBy.Text.Trim(), "edit");


                }
            }
            else if (mode == "delete")
            {

                dSet_temp.Clear();
                dSet_temp = objStorProc.sp_available_menu_grandChild(p_id, 
                    txtgchild.Text, "", "", "", "", "", "", "delete");

                return true;
            }
            return false;
        }




        private void metroFinalSaving_Click(object sender, EventArgs e)
        {

            if (cboChildMenu.Text.Trim() == string.Empty)
            {
                FillRequiredFields();
                cboChildMenu.Focus();
                return;
            }

            if (txtgchild.Text.Trim() == string.Empty)
            {
                FillRequiredFields();
                txtgchild.Focus();
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
                    displayGrandChildFormsData();
                    string tmode = mode;

                    if (tmode == "add")
                    {
                        dgvGrandChildForms.CurrentCell = dgvGrandChildForms[0, dgvGrandChildForms.Rows.Count - 1];
                    }
                    else
                    {
                        dgvGrandChildForms.CurrentCell = dgvGrandChildForms[0, temp_hid];
                    }
                    btnCancelTool_Click(sender, e);
                }
                else

                    return;
            }
        }

        private void cboChildMenu_SelectedValueChanged(object sender, EventArgs e)
        {
            txtcountChildId.Text = cboChildMenu.SelectedValue.ToString();
        }
    }
}
