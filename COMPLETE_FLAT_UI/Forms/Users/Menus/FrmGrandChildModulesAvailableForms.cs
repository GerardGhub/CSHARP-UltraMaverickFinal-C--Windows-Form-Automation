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
using ULTRAMAVERICK.Forms.Users.Menus.Modal;

namespace ULTRAMAVERICK.Forms.Users
{
    public partial class frmModulesAvailableForms : MaterialForm
    {

        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        IStoredProcedures g_objStoredProcCollection = null;
        public Byte[] imageByte = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        Available_Menu_GrandChild AvailableMenuGrandChildEntity = new Available_Menu_GrandChild();
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
        public string Sp_RightsID { get; set; }

        private void frmGrandChildAvailableForms_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            this.displayGrandChildFormsData();
            //this.loadChildMenu();
            //this.displayUserRightsData();
            this.textBox1.Text = String.Empty;
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

        private void displayUserRightsData()      
        {

        this.myClass.fillDataGridView(dgvUserRights, "user_rights", dSet);
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
  
            this.myClass.fillDataGridView(this.dgvGrandChildForms, "available_menu_grandChild", dSet);
            this.lbltotalrecords.Text = this.dgvGrandChildForms.RowCount.ToString();
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




 




        private void metroSave_Click(object sender, EventArgs e)
        {
            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update the Module Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                if (this.cboChildMenu.Text.Trim() == string.Empty)
                {
                    this.GlobalStatePopup.FillRequiredFields();
                    this.cboChildMenu.Focus();
                    return;
                }


                if (this.txtgchild.Text.Trim() == string.Empty)
                {
                    this.GlobalStatePopup.FillRequiredFields();
                    this.txtgchild.Focus();
                    return;
                }

                if (this.txtfname.Text.Trim() == string.Empty)
                {
                    this.GlobalStatePopup.FillRequiredFields();
                    this.txtfname.Focus();
                    return;
                }

                if (this.txtcountChildId.Text.Trim() == string.Empty)
                {

                    this.GlobalStatePopup.FillRequiredFields();
                    this.txtcountChildId.Focus();
                    return;
                }

                else
                {
                    if (this.saveMode())
                    {
                        
                        string tmode = mode;

                        if (tmode == "add")
                        {
                            this.dgvGrandChildForms.CurrentCell = dgvGrandChildForms[0, dgvGrandChildForms.Rows.Count - 1];
                            this.GlobalStatePopup.UpdatedSuccessfully();
                        }
                        else
                        {
                            this.dgvGrandChildForms.CurrentCell = dgvGrandChildForms[0, temp_hid];

                        }
                
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
            this.ShowValue();
        }
        private void ShowValue()
        {
            if (dgvGrandChildForms.Rows.Count > 0)
            {
                if (dgvGrandChildForms.CurrentRow != null)
                {
                    if (dgvGrandChildForms.CurrentRow.Cells["menu_id"].Value != null)
                    {
                        p_id = Convert.ToInt32(dgvGrandChildForms.CurrentRow.Cells["menu_id"].Value);
                       this.AvailableMenuGrandChildEntity.Menu_Id = Convert.ToInt32(dgvGrandChildForms.CurrentRow.Cells["menu_id"].Value);
                       this.AvailableMenuGrandChildEntity.Menu_Form_Name = dgvGrandChildForms.CurrentRow.Cells["menu_form_name"].Value.ToString();
                       this.AvailableMenuGrandChildEntity.Menu_Name = dgvGrandChildForms.CurrentRow.Cells["menu_name"].Value.ToString();
                        txtParentName.Text = dgvGrandChildForms.CurrentRow.Cells["count"].Value.ToString();
                       this.AvailableMenuGrandChildEntity.ChildForm = dgvGrandChildForms.CurrentRow.Cells["ChildForm"].Value.ToString();
                        cboChildMenu.Text = dgvGrandChildForms.CurrentRow.Cells["ChildForm"].Value.ToString();

                        this.AvailableMenuGrandChildEntity.Created_At = dgvGrandChildForms.CurrentRow.Cells["created_at"].Value.ToString();
                        this.AvailableMenuGrandChildEntity.Created_By = dgvGrandChildForms.CurrentRow.Cells["created_by"].Value.ToString();
                        this.AvailableMenuGrandChildEntity.Updated_At = dgvGrandChildForms.CurrentRow.Cells["updated_at"].Value.ToString();
                        this.AvailableMenuGrandChildEntity.Updated_By = dgvGrandChildForms.CurrentRow.Cells["updated_by"].Value.ToString();

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
                    this.GlobalStatePopup.DataAlreadyExist();

                    this.txtgchild.Text = string.Empty;
                    this.txtgchild.Focus();
                    return false;
                }
                else
                {
                    this.dSet.Clear();
                    this.dSet = g_objStoredProcCollection.Sp_available_menu_grandChild(0,
                        this.txtgchild.Text.Trim(),
                        this.txtfname.Text.Trim(),
                        this.txtcountChildId.Text.Trim(),
                        this.AvailableMenuGrandChildEntity.Created_At,
                        this.AvailableMenuGrandChildEntity.Created_By,
                        this.AvailableMenuGrandChildEntity.Updated_At,
                        this.AvailableMenuGrandChildEntity.Updated_By,
                        "add");


                    this.displayGrandChildFormsData();
                    this.matBtnNext_Click(new object(), new System.EventArgs());
                    this.displayUserRightsData();
                    this.displayGrandChildFormsData();

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
                            this.txtgchild.Text.Trim(),
                            this.txtfname.Text.Trim(),
                            this.txtcountChildId.Text.Trim(),
                        this.AvailableMenuGrandChildEntity.Created_At,
                        this.AvailableMenuGrandChildEntity.Created_By,
                        this.AvailableMenuGrandChildEntity.Updated_At,
                        this.AvailableMenuGrandChildEntity.Updated_By,
                            "edit");
                        this.GlobalStatePopup.UpdatedSuccessfully();

                        return true;
                    }
                    else
                    {
                        this.GlobalStatePopup.DataAlreadyExist();
                        this.txtgchild.Text = String.Empty;
                        this.txtgchild.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.Sp_available_menu_grandChild(p_id,
                        this.txtgchild.Text.Trim(),
                        this.txtfname.Text.Trim(),
                        this.txtcountChildId.Text.Trim(),
                        this.AvailableMenuGrandChildEntity.Created_At,
                        this.AvailableMenuGrandChildEntity.Created_By,
                        this.AvailableMenuGrandChildEntity.Updated_At,
                        this.AvailableMenuGrandChildEntity.Updated_By,
                        "edit");


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
                    this.txtgchild.Text.Trim(),
                    this.txtfname.Text.Trim(),
                    this.txtcountChildId.Text.Trim(),
                    this.AvailableMenuGrandChildEntity.Created_At,
                    this.AvailableMenuGrandChildEntity.Created_By,
                    this.AvailableMenuGrandChildEntity.Updated_At,
                    this.AvailableMenuGrandChildEntity.Updated_By,
                    "add");
            }

            displayGrandChildFormsData();
       

        }

 








        private void metroComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.txtcountChildId.Text = cboChildMenu.SelectedValue.ToString();

            this.SearchGrandChildData();
            this.txtgchild.Text = String.Empty;
            this.txtfname.Text = String.Empty;
            this.txtParentName.Text = String.Empty;
        }

        private void dgvChildForms_CurrentCellChanged(object sender, EventArgs e)
        {
            this.ShowValue();
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
            cboChildMenu.Enabled = true;
            txtcountChildId.Text = cboChildMenu.SelectedValue.ToString(); //Binding First Meet
            txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            txtgchild.Text = String.Empty;
            txtfname.Text = String.Empty;
            cboChildMenu.Text = String.Empty;
            txtgchild.Select();
            txtgchild.Focus();



            FrmAddNewModule addNew =
             new FrmAddNewModule(
             this,
             userinfo.user_id,
             "Add",
             this.AvailableMenuGrandChildEntity.Menu_Id,
             this.AvailableMenuGrandChildEntity.Menu_Name,
             this.AvailableMenuGrandChildEntity.Menu_Form_Name,
             this.AvailableMenuGrandChildEntity.Parent_Menu,
             this.AvailableMenuGrandChildEntity.ChildForm);
            addNew.ShowDialog();




        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.dgvGrandChildForms.RowCount > 0)
            {
                temp_hid = dgvGrandChildForms.CurrentRow.Index;
                txtfname.Enabled = true;
                txtgchild.Enabled = true;

                cboChildMenu.Enabled = true;
                mode = "edit";

                btn_visible(false);
                txt_read_only(false);


                FrmAddNewModule addNew =
                 new FrmAddNewModule(
                 this,
                 userinfo.user_id,
                 "Edit",
                 this.AvailableMenuGrandChildEntity.Menu_Id,
                 this.AvailableMenuGrandChildEntity.Menu_Name,
                 this.AvailableMenuGrandChildEntity.Menu_Form_Name,
                 this.AvailableMenuGrandChildEntity.Parent_Menu,
                 this.AvailableMenuGrandChildEntity.ChildForm);
                addNew.ShowDialog();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            dSet.Clear();
            dSet = g_objStoredProcCollection.Sp_available_menu_grandChild(0, this.txtgchild.Text, 
                this.txtcountChildId.Text, "", "", "", "", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.GlobalStatePopup.DataAlreadyExist();
                this.txtgchild.Text = string.Empty;
                this.txtgchild.Focus();
                return ;
            }

            if (this.cboChildMenu.Text.Trim() == string.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.cboChildMenu.Focus();
                return;
            }


            if (this.txtgchild.Text.Trim() == string.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.txtgchild.Focus();
                return;
            }

            if (this.txtfname.Text.Trim() == string.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.txtfname.Focus();
                return;
            }

            if (txtcountChildId.Text.Trim() == string.Empty)
            {

                this.GlobalStatePopup.FillRequiredFields();
                this.txtcountChildId.Focus();
                return;
            }


            if (mode == "add")
            {
                //Start
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to add the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    dSet.Clear();
                    dSet = g_objStoredProcCollection.Sp_available_menu_grandChild(0,
                        this.txtgchild.Text.Trim(),
                        this.txtfname.Text.Trim(),
                        this.txtcountChildId.Text.Trim(),
                        this.AvailableMenuGrandChildEntity.Created_At,
                        this.AvailableMenuGrandChildEntity.Created_By,
                        this.AvailableMenuGrandChildEntity.Updated_At,
                        this.AvailableMenuGrandChildEntity.Updated_By,
                        "add");

                    this.GlobalStatePopup.UpdatedSuccessfully();
                    this.displayGrandChildFormsData();


                    this.matBtnNext_Click(new object(), new System.EventArgs());
                    this.displayUserRightsData();
                    this.displayGrandChildFormsData();


                    this.btnCancelTool_Click(sender, e);
                }
                else
                {
                    this.btnCancelTool_Click(sender, e);
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
                    this.AvailableMenuGrandChildEntity.Created_At,
                    this.AvailableMenuGrandChildEntity.Created_By,
                    this.AvailableMenuGrandChildEntity.Updated_At,
                    this.AvailableMenuGrandChildEntity.Updated_By,
                        "edit");
                    this.GlobalStatePopup.UpdatedSuccessfully();


                    this.displayGrandChildFormsData();
                    this.btnCancelTool_Click(sender, e);
                }
                else
                {
                    btnCancelTool_Click(sender, e);
                    return;
                }
            }


          
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (dgvGrandChildForms.Rows.Count > 0)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to inactive?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    mode = "delete";

                    if (saveMode())
                    {
                        this.GlobalStatePopup.InactiveSuccessfully();
                        this.displayGrandChildFormsData();

                        this.btnCancelTool_Click("", e);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.btnCancelTool_Click_1(sender, e);
            this.frmGrandChildAvailableForms_Load(sender, e);
        }
    }
}
