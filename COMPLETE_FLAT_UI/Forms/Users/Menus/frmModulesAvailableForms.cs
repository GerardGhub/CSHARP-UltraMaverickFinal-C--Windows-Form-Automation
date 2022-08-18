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
    public partial class frmModulesAvailableForms : MaterialForm
    {
        myclasses xClass = new myclasses();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        IStoredProcedures g_objStoredProcCollection = null;
        public Byte[] imageByte = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();

        string mode = "";
        int p_id = 0;
        int temp_hid = 0;
        DateTime dNow = DateTime.Now;
        Boolean ready = false;


        DataSet dSet_temp = new DataSet();

        public frmModulesAvailableForms()
        {
            InitializeComponent();
        }

        private void BtnModuleClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string sp_created_at { get; set; }
        public string sp_created_by { get; set; }
        public string sp_modified_at { get; set; }
        public string sp_modified_by { get; set; }
        public string Sp_RightsID { get; set; }

        private void frmGrandChildAvailableForms_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            this.displayGrandChildFormsData();
            this.loadChildMenu();
            this.displayUserRightsData();  
        }

    
    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.ExStyle = cp.ExStyle | 0x2000000;
            return cp;
        }
    }

    private void displayUserRightsData()      //method for loading available_menus
        {

            xClass.fillDataGridView(dgvUserRights, "user_rights", dSet);


        }

        DataSet dset_emp = new DataSet();
        private void SearchGrandChildData()
        {
            dset_emp = g_objStoredProcCollection.sp_getMajorTables("SearchGrandChildForms");

            if (dset_emp.Tables.Count > 0)
            {
                DataView dv = new DataView(dset_emp.Tables[0]);
                dv.RowFilter = "search = '" + txtcountChildId.Text + "' and menu_name like '%"+mattxtSearch.Text+ "%' ";
                this.dgvGrandChildForms.DataSource = dv;
                this.lbltotalrecords.Text = dgvGrandChildForms.RowCount.ToString();
            }
        }

        public void loadChildMenu()
        {
            this.ready = false;
            myClass.fillComboBoxDepartment(this.cboChildMenu, "childform_dropdown", dSet);
            this.ready = true;
            this.txtcountChildId.Text = this.cboChildMenu.SelectedValue.ToString();
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
            this.btnAddTool.Visible = val;
            this.btnEditTool.Visible = val;
            this.btnDeleteTool.Visible = val;
            this.btnUpdateTool.Visible = !val;
            this.btnCancelTool.Visible = !val;
        }


        private void txt_read_only(Boolean val)
        {
            this.txtfname.ReadOnly = val;
            this.txtgchild.ReadOnly = val;
            this.txtcountChildId.ReadOnly = val;

            if (val == false)
            {
                if (this.mode == "add")
                {
                    this.txtgchild.Text = "";
                    this.txtfname.Text = "";
                    this.txtcountChildId.Text = "";
                    this.txtgchild.Focus();
                }
                else
                {
                    this.txtgchild.Focus();
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
            sp_modified_at = String.Empty;
            sp_modified_by = String.Empty;
            cboChildMenu.Enabled = true;
            txtcountChildId.Text = cboChildMenu.SelectedValue.ToString(); //Binding First Meet
            sp_created_at = (dNow.ToString("M/d/yyyy"));
            sp_created_by = userinfo.emp_name.ToUpper();
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
            //dSet.Clear();
            //dSet = objStorProc.sp_available_menu_grandChild(0, txtgchild.Text, "", "", "", "", "", "", "getbyname");

            //if (dSet.Tables[0].Rows.Count > 0)
            //{
            //    GrandChildMenuAlreadyExist();


            //    txtgchild.Focus();
            //    return;
            //}
            //else
            //{
            metroSave_Click(sender, e);
            //}

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
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update the Module Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
                        //displayGrandChildFormsData();
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
                        //btnCancelTool_Click(sender, e);
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
            showValue();
        }
        private void showValue()
        {
            if (dgvGrandChildForms.Rows.Count > 0)
            {
                if (dgvGrandChildForms.CurrentRow != null)
                {
                    if (dgvGrandChildForms.CurrentRow.Cells["menu_id"].Value != null)
                    {
                        p_id = Convert.ToInt32(dgvGrandChildForms.CurrentRow.Cells["menu_id"].Value);
                        txtfname.Text = dgvGrandChildForms.CurrentRow.Cells["menu_form_name"].Value.ToString();
                        txtgchild.Text = dgvGrandChildForms.CurrentRow.Cells["menu_name"].Value.ToString();
                        txtParentName.Text = dgvGrandChildForms.CurrentRow.Cells["count"].Value.ToString();
                        cboChildMenu.Text = dgvGrandChildForms.CurrentRow.Cells["ChildForm"].Value.ToString();

                        sp_created_at = dgvGrandChildForms.CurrentRow.Cells["created_at"].Value.ToString();
                        sp_created_by = dgvGrandChildForms.CurrentRow.Cells["created_by"].Value.ToString();
                       sp_modified_at = dgvGrandChildForms.CurrentRow.Cells["updated_at"].Value.ToString();
                       sp_modified_by = dgvGrandChildForms.CurrentRow.Cells["updated_by"].Value.ToString();
                    }
                }
            }
        }


        public bool saveMode()      //method for saving of data base on mode (add,edit,delete)
        {

            if (mode == "add")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.Sp_available_menu_grandChild(0, txtgchild.Text, txtcountChildId.Text, "", "", "", "", "", "getbyname");

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
                    dSet = g_objStoredProcCollection.Sp_available_menu_grandChild(0,
                        txtgchild.Text.Trim(),
                        txtfname.Text.Trim(),
                        txtcountChildId.Text.Trim(),
                        sp_created_at,
                        sp_created_by,
                       sp_modified_at,
                       sp_modified_by, "add");


                    displayGrandChildFormsData();
                    matBtnNext_Click(new object(), new System.EventArgs());
                    displayUserRightsData();
                    displayGrandChildFormsData();

                    return true;
                }
            }
            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.Sp_available_menu_grandChild(0,
                    txtgchild.Text, "", "", "", "", "", "", "getbyname");

                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.Sp_available_menu_grandChild(p_id,
                    txtgchild.Text, "", "", "", "", "", "", "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == p_id)
                    {
                        dSet.Clear();
                        dSet = g_objStoredProcCollection.Sp_available_menu_grandChild(p_id,
                            txtgchild.Text.Trim(),
                            txtfname.Text.Trim(),
                            txtcountChildId.Text.Trim(),
                            sp_created_at,
                            sp_created_by,
                            sp_modified_at,
                            sp_modified_by, "edit");
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
                    dSet = g_objStoredProcCollection.Sp_available_menu_grandChild(p_id,
                        txtgchild.Text.Trim(),
                        txtfname.Text.Trim(),
                        txtcountChildId.Text.Trim(),
                        sp_created_at,
                        sp_created_by,
                       sp_modified_at,
                        sp_modified_by, "edit");


                }
            }
            else if (mode == "delete")
            {

                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.Sp_available_menu_grandChild(p_id,
                    txtgchild.Text, "", "", "", "", "", "", "delete");

                return true;
            }
            return false;
        }




        private void metroFinalSaving_Click(object sender, EventArgs e)
        {

            if (mode == "add")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.Sp_available_menu_grandChild(0,
                    txtgchild.Text.Trim(),
                    txtfname.Text.Trim(),
                    txtcountChildId.Text.Trim(),
                   sp_created_at,
                   sp_created_by,
                    sp_modified_at,
                    sp_modified_by, "add");
            }

            displayGrandChildFormsData();
       

        }

        private void cboChildMenu_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        private void btnEditTool_Click(object sender, EventArgs e)
        {
            sp_modified_at = (dNow.ToString("M/d/yyyy"));
            sp_modified_by = userinfo.emp_name.ToUpper();
            if (dgvGrandChildForms.RowCount > 0)
            {
                temp_hid = dgvGrandChildForms.CurrentRow.Index;
                txtfname.Enabled = true;
                txtgchild.Enabled = true;

                cboChildMenu.Enabled = true;
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
            //Start
            if (dgvGrandChildForms.Rows.Count > 0)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to delete the GrandChildForm Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    mode = "delete";

                    if (saveMode())
                    {
                        DeletedSuccessfully();
                        displayGrandChildFormsData();

                        btnCancelTool_Click("", e);
                    }
                }

                else
                {
                    return;
                }


            }




            //End
        }



        private void cboChildMenu_SelectionChangeCommitted(object sender, EventArgs e)
        {


            txtcountChildId.Text = cboChildMenu.SelectedValue.ToString();

            SearchGrandChildData();
            txtgchild.Text = String.Empty;
            txtfname.Text = String.Empty;
            sp_modified_at = String.Empty;
            sp_modified_by = String.Empty;
            txtParentName.Text = String.Empty;

        }

        private void metroComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtcountChildId.Text = cboChildMenu.SelectedValue.ToString();

            SearchGrandChildData();
            txtgchild.Text = String.Empty;
            txtfname.Text = String.Empty;
            sp_modified_at = String.Empty;
            sp_modified_by = String.Empty;
            txtParentName.Text = String.Empty;
        }

        private void dgvChildForms_CurrentCellChanged(object sender, EventArgs e)
        {
            showValue();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            mode = "add";
            btn_visible(false);
            txt_read_only(false);
            txtgchild.Enabled = true;
            txtfname.Enabled = true;
            txtcountChildId.Enabled = true;
            cboChildMenu.Text = String.Empty;
            sp_modified_at = String.Empty;
            sp_modified_by = String.Empty;
            cboChildMenu.Enabled = true;
            txtcountChildId.Text = cboChildMenu.SelectedValue.ToString(); //Binding First Meet
           sp_created_at = (dNow.ToString("M/d/yyyy"));
           sp_created_by = userinfo.emp_name.ToUpper();
            txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            txtgchild.Select();
            txtgchild.Focus();
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            sp_modified_at= (dNow.ToString("M/d/yyyy"));
            sp_modified_by = userinfo.emp_name.ToUpper();
            if (dgvGrandChildForms.RowCount > 0)
            {
                temp_hid = dgvGrandChildForms.CurrentRow.Index;
                txtfname.Enabled = true;
                txtgchild.Enabled = true;

                cboChildMenu.Enabled = true;
                mode = "edit";

                btn_visible(false);
                txt_read_only(false);
            }
        }

        private void materialButton1_Click_2(object sender, EventArgs e)
        {
            if (dgvGrandChildForms.Rows.Count > 0)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to delete the GrandChildForm Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    mode = "delete";

                    if (saveMode())
                    {
                        DeletedSuccessfully();
                        displayGrandChildFormsData();

                        btnCancelTool_Click("", e);
                    }
                }

                else
                {
                    return;
                }


            }

        }

        private void materialButton1_Click_3(object sender, EventArgs e)
        {
            mode = "";
            txt_read_only(true);
            btn_visible(true);
            dgvGrandChildForms_CurrentCellChanged(sender, e);
            txtgchild.Enabled = false;
            txtfname.Enabled = false;
            cboChildMenu.Enabled = false;
        }

        private void materialButton1_Click_4(object sender, EventArgs e)
        {
            metroSave_Click(sender, e);
        }

        private void dgvUserRights_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.dgvUserRights.Rows.Count > 0)
            {
                if (this.dgvUserRights.CurrentRow != null)
                {
                    if (this.dgvUserRights.CurrentRow.Cells["user_rights_name"].Value != null)
                    {
                        //p_id = Convert.ToInt32(dgvChildForms.CurrentRow.Cells["menu_id"].Value);
                        this.Sp_RightsID = this.dgvUserRights.CurrentRow.Cells["user_rights_id"].Value.ToString();

                    }
                }
            }
        }

        private void matBtnNext_Click(object sender, EventArgs e)
        {
            dSet.Clear();
            dSet = g_objStoredProcCollection.sp_userfileIncrement(0,
                Convert.ToInt32(this.Sp_RightsID),
                "s",
                "s",
               "s",
                "s",
                "s",
                "s",
                "s",
                "s",
                "s",
                Convert.ToInt32(p_id).ToString(),
                Convert.ToInt32(p_id).ToString(), "addModuleRightsModulePartial");

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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            mode = "add";
            btn_visible(false);
            txt_read_only(false);
            txtgchild.Enabled = true;
            txtfname.Enabled = true;
            txtcountChildId.Enabled = true;
            cboChildMenu.Text = String.Empty;
            sp_modified_at = String.Empty;
            sp_modified_by = String.Empty;
            cboChildMenu.Enabled = true;
            txtcountChildId.Text = cboChildMenu.SelectedValue.ToString(); //Binding First Meet
            sp_created_at = (dNow.ToString("M/d/yyyy"));
            sp_created_by = userinfo.emp_name.ToUpper();
            txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            txtgchild.Text = String.Empty;
            txtfname.Text = String.Empty;
            cboChildMenu.Text = String.Empty;
            txtgchild.Select();
            txtgchild.Focus();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            sp_modified_at = (dNow.ToString("M/d/yyyy"));
           sp_modified_by = userinfo.emp_name.ToUpper();
            if (dgvGrandChildForms.RowCount > 0)
            {
                temp_hid = dgvGrandChildForms.CurrentRow.Index;
                txtfname.Enabled = true;
                txtgchild.Enabled = true;

                cboChildMenu.Enabled = true;
                mode = "edit";

                btn_visible(false);
                txt_read_only(false);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            dSet.Clear();
            dSet = g_objStoredProcCollection.Sp_available_menu_grandChild(0, this.txtgchild.Text, 
                this.txtcountChildId.Text, "", "", "", "", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.GrandChildMenuAlreadyExist();

                this.txtgchild.Text = string.Empty;
                this.txtgchild.Focus();
                return ;
            }

            if (this.cboChildMenu.Text.Trim() == string.Empty)
            {
                this.FillRequiredFields();
                this.cboChildMenu.Focus();
                return;
            }


            if (this.txtgchild.Text.Trim() == string.Empty)
            {
                this.FillRequiredFields();
                this.txtgchild.Focus();
                return;
            }

            if (this.txtfname.Text.Trim() == string.Empty)
            {
                this.FillRequiredFields();
                this.txtfname.Focus();
                return;
            }

            if (txtcountChildId.Text.Trim() == string.Empty)
            {

                FillRequiredFields();
                txtcountChildId.Focus();
                return;
            }


            if (mode == "add")
            {
                //Start
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to add the Module Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    dSet.Clear();
                    dSet = g_objStoredProcCollection.Sp_available_menu_grandChild(0,
                        txtgchild.Text.Trim(),
                        txtfname.Text.Trim(),
                        txtcountChildId.Text.Trim(),
                       sp_created_at,
                       sp_created_by,
                        sp_modified_at,
                        sp_modified_by, "add");

                    UpdateNotifications();

                    displayGrandChildFormsData();
                    //add


                    matBtnNext_Click(new object(), new System.EventArgs());
                    displayUserRightsData();
                    displayGrandChildFormsData();
                    //End Additional Data

                    btnCancelTool_Click(sender, e);
                }
                else
                {
                    btnCancelTool_Click(sender, e);
                    return;
                }
            }



            if (mode == "edit")
            {
                //   Start
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update the Module Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    dSet.Clear();
                    dSet = g_objStoredProcCollection.Sp_available_menu_grandChild(p_id,
                        txtgchild.Text.Trim(),
                        txtfname.Text.Trim(),
                        txtcountChildId.Text.Trim(),
                       sp_created_at,
                       sp_created_by,
                        sp_modified_at,
                        sp_modified_by, "edit");
                    UpdateNotifications();


                    displayGrandChildFormsData();
                    btnCancelTool_Click(sender, e);
                }
                else
                {
                    btnCancelTool_Click(sender, e);
                    return;
                }
            }


            //metroSave_Click(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (dgvGrandChildForms.Rows.Count > 0)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to remove the Module Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    mode = "delete";

                    if (saveMode())
                    {
                        DeletedSuccessfully();
                        displayGrandChildFormsData();

                        btnCancelTool_Click("", e);
                    }
                }

                else
                {
                    return;
                }


            }
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //mode = "";
            //txt_read_only(true);
            //btn_visible(true);
            //dgvGrandChildForms_CurrentCellChanged(sender, e);
            //txtgchild.Enabled = false;
            //txtfname.Enabled = false;
            //cboChildMenu.Enabled = false;
        }

        private void btnCancelTool_Click_1(object sender, EventArgs e)
        {
            mode = "";
            txt_read_only(true);
            btn_visible(true);
            dgvGrandChildForms_CurrentCellChanged(sender, e);
            txtgchild.Enabled = false;
            txtfname.Enabled = false;
            cboChildMenu.Enabled = false;
        }

        private void mattxtSearch_TextChanged(object sender, EventArgs e)
        {

            if (mattxtSearch.Text == "")
            {
                displayGrandChildFormsData();
            }


          if(lbltotalrecords.Text =="0")
            {

            }
          else
            {
                SearchGrandChildData();
            }


                
            
        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtgchild_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void dgvGrandChildForms_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check the value of the e.ColumnIndex property if you want to apply this formatting only so some rcolumns.
            if (e.Value != null)
            {
                e.Value = e.Value.ToString().ToUpper();
                e.FormattingApplied = true;
            }
        }
    }
}
