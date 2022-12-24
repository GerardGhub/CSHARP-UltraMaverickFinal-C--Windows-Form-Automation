using COMPLETE_FLAT_UI.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULTRAMAVERICK.API.Data;
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Users.Menus.Modal
{
    public partial class FrmAddNewModule : MaterialForm
    {
        frmModulesAvailableForms ths;
        string SubMenuModuleBindId = "";
        DataSet dSet = new DataSet();
        DataSet dSetCheckAvailableMenuCount = new DataSet();
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        Available_Menu_GrandChild Available_Menu_GrandChild_Entity = new Available_Menu_GrandChild();
        Available_Menu_GrandChildRepository Available_Menu_GrandChild_Repo = new Available_Menu_GrandChildRepository();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        int temp_id = 0;
        int GetLatestKeyOfMenuIdentity = 0;

        public FrmAddNewModule(
            frmModulesAvailableForms frm,
            int UserId,
            string Mode,
            int MenuId,
            string MenuName,
            string MenuFormName,
            string ParentMenu,
            string ChildForm,
            int SubMenuId
            )
        {
            InitializeComponent();
            ths = frm;
            this.Available_Menu_GrandChild_Entity.Created_By = userinfo.user_id.ToString();
            this.Available_Menu_GrandChild_Entity.Updated_By = userinfo.user_id.ToString();
            this.Available_Menu_GrandChild_Entity.Mode = Mode;
            this.Available_Menu_GrandChild_Entity.Menu_Id = MenuId;
            this.Available_Menu_GrandChild_Entity.Menu_Name = MenuName;
            this.Available_Menu_GrandChild_Entity.Menu_Form_Name = MenuFormName;
            this.Available_Menu_GrandChild_Entity.Parent_Menu = ParentMenu;
            this.SubMenuModuleBindId = SubMenuId.ToString();
            this.Available_Menu_GrandChild_Entity.ChildForm = ChildForm;

        }

        private void FrmAddNewModule_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();

            this.LoadChildMenuDropDown();


            if (this.Available_Menu_GrandChild_Entity.Mode == "Add")
            {
                this.Text = "Add New Module";
                this.displayUserRightsData();
            }
            else
            {
                this.Text = "Update Module";
                this.txtgchild.Text = Available_Menu_GrandChild_Entity.Menu_Name;
                this.txtfname.Text = Available_Menu_GrandChild_Entity.Menu_Form_Name;
                this.cboChildMenu.Text = Available_Menu_GrandChild_Entity.ChildForm;
           

            }
        }


        private void displayUserRightsData()
        {

            this.myClass.fillDataGridView(this.dgvUserRights, "user_rights", dSet);
        }

        public void LoadChildMenuDropDown()
        {

            this.myClass.fillComboBoxDepartment(this.cboChildMenu, "childform_dropdown", dSet);

            this.Available_Menu_GrandChild_Entity.Parent_Menu = this.cboChildMenu.SelectedValue.ToString();
        }

        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }

        private void FrmAddNewModule_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.textBox1.Text = "FormClosed";
        }

        private void cboChildMenu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Available_Menu_GrandChild_Entity.Parent_Menu = this.cboChildMenu.SelectedValue.ToString();

        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
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

            if (this.cboChildMenu.Text.Trim() == string.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.cboChildMenu.Focus();
                return;
            }

            if (this.Available_Menu_GrandChild_Entity.Parent_Menu == string.Empty)
            {

                this.GlobalStatePopup.FillRequiredFields();
                this.cboChildMenu.Focus();
                return;
            }


            string SelectionSubMenu = "";

            if (this.Available_Menu_GrandChild_Entity.Mode == "Add")
            {
                this.Available_Menu_GrandChild_Entity.Menu_Name = String.Empty;
                //SelectionSubMenu = SubMenuModuleBindId;
                SelectionSubMenu = this.Available_Menu_GrandChild_Entity.Parent_Menu;
            }
            else
            {
                //SelectionSubMenu = this.Available_Menu_GrandChild_Entity.Parent_Menu;
                SelectionSubMenu = SubMenuModuleBindId;
            }

            if (this.Available_Menu_GrandChild_Entity.Parent_Menu == SelectionSubMenu
                && this.Available_Menu_GrandChild_Entity.Menu_Name == this.txtgchild.Text
                && this.Available_Menu_GrandChild_Entity.Menu_Form_Name == this.txtfname.Text)

            {

                this.SaveFunctionality();
            }
            else
            {
                this.dSet.Clear();
                this.dSet = this.g_objStoredProcCollection
                    .sp_available_menu_grandChild(
                    0,
                    this.txtgchild.Text,
                         this.txtfname.Text,
                    this.Available_Menu_GrandChild_Entity.Parent_Menu,
               
                    "",
                    "",
                    "",
                    "",
                    "getbyname");

                if (this.dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();
                    this.txtgchild.Text = string.Empty;
                    this.txtfname.Text = string.Empty;
                    this.txtgchild.Focus();
                    return;
                }
                else
                {
                    this.SaveFunctionality();
                }
            }




            }


        private void SaveFunctionality()
        {

            if (this.Available_Menu_GrandChild_Entity.Mode == "Add")
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to add the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_available_menu_grandChild(0,
                        this.txtgchild.Text.Trim(),
                        this.txtfname.Text.Trim(),
                        this.Available_Menu_GrandChild_Entity.Parent_Menu,
                        this.Available_Menu_GrandChild_Entity.Created_At,
                        this.Available_Menu_GrandChild_Entity.Created_By,
                        this.Available_Menu_GrandChild_Entity.Updated_At,
                        this.Available_Menu_GrandChild_Entity.Updated_By,
                        "add");

                    this.GlobalStatePopup.UpdatedSuccessfully();
                    this.GetLatestCountOfSubMenu();
                    this.LoadLoopBulkInsert();
                    this.displayUserRightsData();
                }
                else
                {
                    return;
                }
            }
            else

            {

           


                //Start of Edit
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    this.dSet.Clear();
                    this.dSet = this.g_objStoredProcCollection
                    .sp_available_menu_grandChild(
                    this.Available_Menu_GrandChild_Entity.Menu_Id,
                    this.txtgchild.Text.Trim(),
                    this.txtfname.Text.Trim(),
                    this.Available_Menu_GrandChild_Entity.Parent_Menu,
                    this.Available_Menu_GrandChild_Entity.Created_At,
                    this.Available_Menu_GrandChild_Entity.Created_By,
                    this.Available_Menu_GrandChild_Entity.Updated_At,
                    this.Available_Menu_GrandChild_Entity.Updated_By,
                    "edit");

                    this.GlobalStatePopup.UpdatedSuccessfully();
                    this.Close();
                }
                else
                {
                    return;
                }

                //End of Edit


            }

        }

        private void LoadLoopBulkInsert()
        {
            dSet.Clear();
            dSet = g_objStoredProcCollection.sp_userfileIncrement(0,
                Convert.ToInt32(this.Available_Menu_GrandChild_Entity.UserRightsId),
                "s",
                "s",
               "s",
                "s",
                "s",
                "s",
                "s",
                "s",
                "s",
                Convert.ToInt32(this.GetLatestKeyOfMenuIdentity).ToString(),
                Convert.ToInt32(this.GetLatestKeyOfMenuIdentity).ToString(), "addModuleRightsModulePartial");

            if (this.dgvUserRights.Rows.Count >= 1)
            {
                int i = this.dgvUserRights.CurrentRow.Index + 1;
                if (i >= -1 && i < this.dgvUserRights.Rows.Count)
                    this.dgvUserRights.CurrentCell = dgvUserRights.Rows[i].Cells[0];
                else
                {
                    //LastLine();
                    this.GlobalStatePopup.SuccessFullySave();
                    this.Close();

                    return;
                }

            }
            this.LoadLoopBulkInsert();
        }

        private void dgvUserRights_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.dgvUserRights.Rows.Count > 0)
            {
                if (this.dgvUserRights.CurrentRow != null)
                {
                    if (this.dgvUserRights.CurrentRow.Cells["user_rights_name"].Value != null)
                    {
 
                        this.Available_Menu_GrandChild_Entity.UserRightsId = Convert.ToInt32(this.dgvUserRights.CurrentRow.Cells["user_rights_id"].Value);

                    }
                }
            }
        }


        private void GetLatestCountOfSubMenu()      //method for loading available_menus
        {
            try
            {
                this.dSetCheckAvailableMenuCount.Clear();
                this.dSetCheckAvailableMenuCount = g_objStoredProcCollection.sp_getMajorTables("Available_Menu_GranChild_Latest_Id");
                this.GetLatestKeyOfMenuIdentity = Convert.ToInt32(this.dSetCheckAvailableMenuCount.Tables[0].Rows[0]["LatestNumber"]);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void txtgchild_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void cboChildMenu_Click(object sender, EventArgs e)
        {
            if (this.Available_Menu_GrandChild_Entity.Mode == "Add")
            { }
            else { this.displayUserRightsData(); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void MatBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
