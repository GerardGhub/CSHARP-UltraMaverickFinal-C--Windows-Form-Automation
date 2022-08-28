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
using ULTRAMAVERICK.API.Entities;

namespace ULTRAMAVERICK.Forms.Users
{
    public partial class frmSubMenusAvailableForms : MaterialForm
    {
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        public Byte[] imageByte = null;

        string mode = "";
        int p_id = 0;
        int temp_hid = 0;
        DateTime dNow = DateTime.Now;
        Boolean ready = false;
        Available_Menu AvailableMenuEntity = new Available_Menu();

        DataSet dSet_temp = new DataSet();

        public frmSubMenusAvailableForms()
        {
            InitializeComponent();
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

        private void frmChildAvailableForms_Load(object sender, EventArgs e)
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            this.displayChildFormsData();
            this.loadParentMenu();
            this.displayUserRightsData();
        }
        private void displayUserRightsData()      //method for loading available_menus
        {

            myClass.fillDataGridView(dgvUserRights, "user_rights", dSet);


        }

        public void loadParentMenu()
        {
          
            this.myClass.fillComboBoxDepartment(cboParentMenu, "parentform_dropdown", dSet);

            this.txtcount.Text = cboParentMenu.SelectedValue.ToString();

        }

        private void displayChildFormsData()      //method for loading available_menus
        {
            try
            {
               
                this.myClass.fillDataGridView(dgvChildForms, "available_menu", dSet);

                this.lbltotalrecords.Text = dgvChildForms.RowCount.ToString();
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
            dgvChildForms.Enabled = true;
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
                        this.p_id = Convert.ToInt32(dgvChildForms.CurrentRow.Cells["menu_id"].Value);
                        this.txtfname.Text = dgvChildForms.CurrentRow.Cells["menu_form_name"].Value.ToString();
                        this.txtmname.Text = dgvChildForms.CurrentRow.Cells["menu_name"].Value.ToString();
                        this.cboParentMenu.Text = dgvChildForms.CurrentRow.Cells["count"].Value.ToString();
 
                    }
                }
            }
        }


      

     


     

 


        private void metroSave_Click(object sender, EventArgs e)
        {
            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update the Sub Menu Form Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                if (cboParentMenu.Text.Trim() == string.Empty)
                {
                   this.GlobalStatePopup.FillRequiredFields();
                    cboParentMenu.Focus();


                    return;
                }


                if (txtmname.Text.Trim() == string.Empty)
                {
                    this.GlobalStatePopup.FillRequiredFields();
                    txtmname.Focus();


                    return;
                }

                if (txtfname.Text.Trim() == string.Empty)
                {
                    this.GlobalStatePopup.FillRequiredFields();
                    this.txtfname.Focus();
                    return;
                }

                if (txtcount.Text.Trim() == string.Empty)
                {

                    this.GlobalStatePopup.FillRequiredFields();
                    this.txtcount.Focus();
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
                            this.GlobalStatePopup.UpdatedSuccessfully();
                        }
                        else
                        {
                            dgvChildForms.CurrentCell = dgvChildForms[0, temp_hid];

                        }
                        btnCancelTool_Click(sender, e);
                        this.GlobalStatePopup.UpdatedSuccessfully();
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
                dSet = g_objStoredProcCollection.sp_available_menu(0, txtmname.Text, "", "","","","","", "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();

                    txtmname.Text = string.Empty;
                    txtmname.Focus();
                    return false;
                }
                else
                {

                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_available_menu(0, 
                    this.txtmname.Text.Trim(), 
                    this.txtfname.Text.Trim(), 
                    this.txtcount.Text.Trim(), 
                    this.AvailableMenuEntity.Created_At, 
                    this.AvailableMenuEntity.Created_By, 
                    this.AvailableMenuEntity.Updated_At, 
                    this.AvailableMenuEntity.Updated_By, "add");

                    this.displayChildFormsData();
                    this.matBtnNext_Click(new object(), new System.EventArgs());
                    this.displayUserRightsData();
                    this.displayChildFormsData();
                    return true;
                }
            }
            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_available_menu(0, txtmname.Text, "", "","","","","", "getbyname");

                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_available_menu(p_id, txtmname.Text, "", "","","","","", "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == p_id)
                    {
                        dSet.Clear();
                        dSet = g_objStoredProcCollection.sp_available_menu(p_id, txtmname.Text.Trim(), 
                            this.txtfname.Text.Trim(), 
                            this.txtcount.Text.Trim(), 
                            this.AvailableMenuEntity.Created_At, 
                            this.AvailableMenuEntity.Created_By, 
                            this.AvailableMenuEntity.Updated_At, 
                            this.AvailableMenuEntity.Updated_By, "edit");
                        this.GlobalStatePopup.UpdatedSuccessfully();

                        return true;
                    }
                    else
                    {
                        this.GlobalStatePopup.DataAlreadyExist();
                        txtmname.Text = String.Empty;
                        txtmname.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_available_menu(
                        this.p_id, 
                        this.txtmname.Text.Trim(), 
                        this.txtfname.Text.Trim(), 
                        this.txtcount.Text.Trim(), 
                        this.AvailableMenuEntity.Created_At, 
                        this.AvailableMenuEntity.Created_By, 
                        this.AvailableMenuEntity.Updated_At, 
                        this.AvailableMenuEntity.Updated_By
                        , "edit");

       
                }
            }
            else if (mode == "delete")
            {
         
                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_available_menu(p_id, txtmname.Text, "", "","","","","", "delete");

                return true;
            }
            return false;
        }


     

        private void metroFinalSaving_Click(object sender, EventArgs e)
        {
            if (this.txtmname.Text.Trim() == string.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.txtfname.Focus();
                return;
            }

            if (txtfname.Text.Trim() == string.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
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

   


 

        private void dgvChildForms_CurrentCellChanged_1(object sender, EventArgs e)
        {
            if (mode == "add")
            {
                dgvChildForms.Enabled = false;
            }
            else
            {
                dgvChildForms.Enabled = true;
               
            }
            showValue();
        }

        private void metroComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //txtcount.Text = cboParentMenu.SelectedValue.ToString();
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


            dSet.Clear();
            dSet = g_objStoredProcCollection.sp_userfileIncrement(0,
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
                 Convert.ToInt32(p_id).ToString(),
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

   

        private void cboParentMenu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.txtcount.Text = cboParentMenu.SelectedValue.ToString();
            SearchSubMenuData();
            this.txtmname.Text = String.Empty;
            this.txtfname.Text = String.Empty;
  
        }


        DataSet dset_emp = new DataSet();
        private void SearchSubMenuData()
        {
            dset_emp = g_objStoredProcCollection.sp_getMajorTables("available_menu_Major");

            if (dset_emp.Tables.Count > 0)
            {
                DataView dv = new DataView(dset_emp.Tables[0]);


                dv.RowFilter = "parent_id = '" + txtcount.Text + "' and menu_name like '%" + mattxtSearch.Text + "%' ";



                dgvChildForms.DataSource = dv;
                lbltotalrecords.Text = dgvChildForms.RowCount.ToString();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            mode = "add";
            dgvChildForms.Enabled = false;
            btn_visible(false);
            txt_read_only(false);
            txtmname.Enabled = true;
            txtfname.Enabled = true;
            txtcount.Enabled = true;
            cboParentMenu.Text = String.Empty;
            cboParentMenu.Enabled = true;
            txtcount.Text = cboParentMenu.SelectedValue.ToString(); //Binding First Meet
            txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            txtmname.Select();
            txtmname.Focus();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            dSet.Clear();
            dSet = g_objStoredProcCollection
                .sp_available_menu(0, txtmname.Text, "", "", "", "", "", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.GlobalStatePopup.DataAlreadyExist();
                this.txtmname.Focus();
                return;
            }
            else
            {
                metroSave_Click(sender, e);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.dgvChildForms.RowCount > 0)
            {
                this.temp_hid = dgvChildForms.CurrentRow.Index;
                this.txtfname.Enabled = true;
                this.txtmname.Enabled = true;
                this.txtcount.Enabled = true;
                this.cboParentMenu.Enabled = true;
                this.mode = "edit";
                this.btn_visible(false);
                this.txt_read_only(false);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (dgvChildForms.Rows.Count > 0)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to inactive the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    mode = "delete";

                    if (saveMode())
                    {
                        this.GlobalStatePopup.InactiveSuccessfully();
                        this.displayChildFormsData();
                        this.btnCancelTool_Click("", e);
                    }
                }

                else
                {
                    return;
                }
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            mode = "";
            txt_read_only(true);
            btn_visible(true);
            dgvChildForms_CurrentCellChanged(sender, e);
            txtmname.Enabled = false;
            txtfname.Enabled = false;
            cboParentMenu.Enabled = false;
        }

        private void mattxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (mattxtSearch.Text == "")
            {
                displayChildFormsData();
            }

            SearchSubMenuData();

        }

        private void txtcount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvChildForms_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check the value of the e.ColumnIndex property if you want to apply this formatting only so some rcolumns.
            if (e.Value != null)
            {
                e.Value = e.Value.ToString().ToUpper();
                e.FormattingApplied = true;
            }
        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtmname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
