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
        int temp_id = 0;
        int GetLatestKeyOfMenuIdentity = 0;

        public FrmAddNewSubMenu(
            frmSubMenusAvailableForms frm,
            int UserId,
            string Mode,
            int MenuId,
            string MenuName,
            string Count,
            string MenuFormName)
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

        }

        private void FrmAddNewSubMenu_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();

            this.displayUserRightsData();
            if (this.Available_MenuEntity.Mode == "Add")
            {
                this.Text = "Add New Sub Menu";
                this.getLoadDropdownParentMenu();
            }
            else
            {
                this.Text = "Update Sub Menu";

                this.cboParentMenu.Text = Available_MenuEntity.Count;
                this.txtmname.Text = this.Available_MenuEntity.Menu_Name;
                this.txtfname.Text = this.Available_MenuEntity.Menu_Form_Name;

            }

        }


        private void displayUserRightsData()      
        {
            this.myClass.fillDataGridView(dgvUserRights, "user_rights", dSet);
        }


        public void getLoadDropdownParentMenu()
        {

            this.myClass.fillComboBoxDepartment(this.cboParentMenu, "parentform_dropdown", dSet);

            this.Available_MenuEntity.Count = this.cboParentMenu.SelectedValue.ToString();

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
            if (this.cboParentMenu.Text == String.Empty)
            {
            this.GlobalStatePopup.FillRequiredFields();
            this.cboParentMenu.Focus();
            return;
            }
            else if (this.txtmname.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.txtmname.Focus();
                return;
            }
            else if (this.txtfname.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.txtfname.Focus();
                return;
            }



            if (this.Available_MenuEntity.Mode == "Add")
            {

                this.dSet.Clear();
                this.dSet = this.g_objStoredProcCollection
                .sp_available_menu(0,
                this.txtmname.Text,
                "",
                "",
                "",
                "",
                "",
                "",
                "getbyname");

                if (this.dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();
                    this.txtmname.Focus();
                    return;
                }
                else
                {
                    //metroSave_Click(sender, e);

                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to save the data", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        dSet.Clear();
                        dSet = g_objStoredProcCollection.sp_available_menu(0,
                        this.txtmname.Text.Trim(),
                        this.txtfname.Text.Trim(),
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
            }

            else
            {

                //Start
                this.dSet.Clear();
                this.dSet = this.g_objStoredProcCollection
                .sp_available_menu(0,
                this.txtmname.Text,
                "",
                "",
                "",
                "",
                "",
                "",
                "getbyname");

               
                    if (this.txtmname.Text == this.Available_MenuEntity.Menu_Name)
                    {
                    //MessageBox.Show(this.Available_MenuEntity.Menu_Name.ToString());
                }
                    else
                    {
                        if (this.dSet.Tables[0].Rows.Count > 0)
                        {
                            this.GlobalStatePopup.DataAlreadyExist();
                            this.txtmname.Focus();
                            return;
                        }
                    }

 
            
          

                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update the data", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        dSet.Clear();
                        dSet = g_objStoredProcCollection.sp_available_menu(
                        this.Available_MenuEntity.Menu_Id,
                        this.txtmname.Text.Trim(),
                        this.txtfname.Text.Trim(),
                        this.Available_MenuEntity.Count,
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

                



                //End
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
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void cboParentMenu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Available_MenuEntity.Count = this.cboParentMenu.SelectedValue.ToString();

        }

        private void cboParentMenu_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Available_MenuEntity.Count = this.cboParentMenu.SelectedValue.ToString();
        }

        private void cboParentMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboParentMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboParentMenu_Click(object sender, EventArgs e)
        {
            this.getLoadDropdownParentMenu();
        }
    }
}
