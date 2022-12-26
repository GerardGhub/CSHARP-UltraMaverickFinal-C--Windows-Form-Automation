using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;
using ULTRAMAVERICK.API.Data;
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Users.Menus.Modal
{
    public partial class FrmAddNewSubMenu : MaterialForm
    {
        frmSubMenusAvailableForms ths;
        DataSet dSet = new DataSet();
        DataSet dSetCheckAvailableMenuCount = new DataSet();
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        Available_Menu Available_MenuEntity = new Available_Menu();
        Available_MenuRepository Available_MenuRepo = new Available_MenuRepository();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        string SelectionMajorMenu = "";
        string MajorMenuCount = "";

        int Touch = 0;
        int GetLatestKeyOfMenuIdentity = 0;

        public FrmAddNewSubMenu(
            frmSubMenusAvailableForms frm,
            int UserId,
            string Mode,
            int MenuId,
            string MenuName,
            string Count,
            string MenuFormName,
            int MajorMenuID)
        {
            InitializeComponent();
            ths = frm;
            this.Available_MenuEntity.Created_By = UserId.ToString();
            this.Available_MenuEntity.Updated_By = UserId.ToString();
            this.Available_MenuEntity.Mode = Mode;
            this.Available_MenuEntity.Menu_Id = MenuId;
            this.Available_MenuEntity.Menu_Name = MenuName;
            this.Available_MenuEntity.Count = Count;
            this.Available_MenuEntity.Menu_Form_Name = MenuFormName;
            this.Available_MenuEntity.MajorMenuID = MajorMenuID;
            this.MajorMenuCount = Count;

        }

        private void FrmAddNewSubMenu_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();

            this.displayUserRightsData();
            if (this.Available_MenuEntity.Mode == "ADD")
            {
                this.Text = "Add New Sub Menu";
                this.Available_MenuEntity.Mode = this.Available_MenuEntity.Mode;
                this.getLoadDropdownParentMenu();
            }
            else
            {
                this.Text = "Update Sub Menu";
                this.CboParentMenu.Text = Available_MenuEntity.Count;
                this.Available_MenuEntity.Mode = this.Available_MenuEntity.Mode;
                this.Txtmname.Text = this.Available_MenuEntity.Menu_Name;
                this.Txtfname.Text = this.Available_MenuEntity.Menu_Form_Name;
                this.Available_MenuEntity.MajorMenuID = this.Available_MenuEntity.MajorMenuID;
            }

        }

        private void displayUserRightsData()
        {
            this.myClass.fillDataGridView(dgvUserRights, "user_rights", dSet);
        }

        public void getLoadDropdownParentMenu()
        {

            this.myClass.fillComboBoxDepartment(this.CboParentMenu, "parentform_dropdown", dSet);

            this.Available_MenuEntity.Count = this.CboParentMenu.SelectedValue.ToString();

        }

        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void FrmAddNewSubMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.textBox1.Text = "FormClosed";
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            if (this.CboParentMenu.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.CboParentMenu.Focus();
                return;
            }
            else if (this.Txtmname.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.Txtmname.Focus();
                return;
            }
            else if (this.Txtfname.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.Txtfname.Focus();
                return;
            }


            if (this.Available_MenuEntity.Mode == "ADD")
            {
                this.Available_MenuEntity.Menu_Form_Name = String.Empty;
                if (this.Touch == 0)
                {
                    this.getLoadDropdownParentMenu();
                }
                else
                {
                    this.SelectionMajorMenu = this.Available_MenuEntity.Count;
                }
           
            }
            else
            {
                this.SelectionMajorMenu = this.Available_MenuEntity.MajorMenuID.ToString();
                if (this.Touch == 0)
                {
                    this.Available_MenuEntity.Count = this.Available_MenuEntity.MajorMenuID.ToString();
                }
                else
                {
                    this.Available_MenuEntity.Count = this.Available_MenuEntity.Count;
                }
         
            }


            if (this.Available_MenuEntity.Menu_Name == this.Txtmname.Text
                && this.Available_MenuEntity.Menu_Form_Name == this.Txtfname.Text
                && this.Available_MenuEntity.Count == this.SelectionMajorMenu)
            {
                this.SaveFunctionality();
            }
            else
            {
                this.dSet.Clear();
                this.dSet = this.g_objStoredProcCollection
                .sp_available_menu(0,
                this.Txtmname.Text,
                this.Txtfname.Text,
                 this.Available_MenuEntity.Count,
                "",
                "",
                "",
                "",
                "getbyname");

                if (this.dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();
                    this.Txtmname.Focus();
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
            if (this.Available_MenuEntity.Mode == "ADD")
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to save the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_available_menu(0,
                    this.Txtmname.Text.Trim(),
                    this.Txtfname.Text.Trim(),
                    this.Available_MenuEntity.Count,
                    this.Available_MenuEntity.Created_At,
                    this.Available_MenuEntity.Created_By,
                    this.Available_MenuEntity.Updated_At,
                    this.Available_MenuEntity.Updated_By,
                    "add");
                    this.ConnectionInit();
                    this.GetLatestCountOfSubMenu();
                    this.LoopOverAll();
                    this.displayUserRightsData();
                }
                else
                {
                    return;
                }
            }
            else
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
  
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_available_menu(
                    this.Available_MenuEntity.Menu_Id,
                    this.Txtmname.Text.Trim(),
                    this.Txtfname.Text.Trim(),
                    this.Available_MenuEntity.MajorMenuID.ToString(),
                    this.Available_MenuEntity.Created_At,
                    this.Available_MenuEntity.Created_By,
                    this.Available_MenuEntity.Updated_At,
                    this.Available_MenuEntity.Updated_By,
                    "edit");

                    this.GlobalStatePopup.UpdatedSuccessfully();
                    this.Close();
                }
               else
                {
                    return;
                }
            }
        }

  

        private void GetLatestCountOfSubMenu()      //method for loading available_menus
        {
            try
            {
                this.dSetCheckAvailableMenuCount.Clear();
                this.dSetCheckAvailableMenuCount = g_objStoredProcCollection.sp_getMajorTables("Available_Menu_Latest_Id");
                this.GetLatestKeyOfMenuIdentity = Convert.ToInt32(this.dSetCheckAvailableMenuCount.Tables[0].Rows[0]["LatestNumber"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void LoopOverAll()
        {
            dSet.Clear();
            dSet = g_objStoredProcCollection.sp_userfileIncrement(0,
                Convert.ToInt32(this.Available_MenuEntity.User_Rights_Id),
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
                Convert.ToInt32(this.GetLatestKeyOfMenuIdentity).ToString(), "addModuleRightsSubMenuPartial");;

            if (this.dgvUserRights.Rows.Count >= 1)
            {
                int i = this.dgvUserRights.CurrentRow.Index + 1;
                if (i >= -1 && i < this.dgvUserRights.Rows.Count)
                    this.dgvUserRights.CurrentCell = this.dgvUserRights.Rows[i].Cells[0];
                else
                {
                    //LastLine();
                    this.GlobalStatePopup.SuccessFullySave();
                    this.Close();
                    return;
                }

            }
            this.LoopOverAll();
        }


        private void dgvUserRights_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.dgvUserRights.Rows.Count > 0)
            {
                if (this.dgvUserRights.CurrentRow != null)
                {
                    if (this.dgvUserRights.CurrentRow.Cells["user_rights_name"].Value != null)
                    {
                       
                        this.Available_MenuEntity.User_Rights_Id = 
                       Convert.ToInt32(this.dgvUserRights.CurrentRow.Cells["user_rights_id"].Value);

                    }
                }
            }

        }

        private void txtmname_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.myClass.TextBoxToUpperCase(e);
        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.myClass.TextBoxToUpperCase(e);
        }


        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Touch = 1;
            this.Available_MenuEntity.Count = this.CboParentMenu.SelectedValue.ToString();
            this.Available_MenuEntity.MajorMenuID = Convert.ToInt32(this.CboParentMenu.SelectedValue);
        }

        private void cboParentMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboParentMenu_Click(object sender, EventArgs e)
        {
            this.getLoadDropdownParentMenu();
        }

        private void MatBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
