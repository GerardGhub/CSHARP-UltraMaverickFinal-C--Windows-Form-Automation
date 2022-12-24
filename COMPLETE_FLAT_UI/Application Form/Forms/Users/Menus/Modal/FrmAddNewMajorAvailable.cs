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
    public partial class FrmAddNewMajorAvailable : MaterialForm
    {
        frmMajorMenuAvailableForms ths;
        DataSet dSet = new DataSet();
        readonly myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        readonly ParentForms ParentFormEntity = new ParentForms();
        readonly ParentFormsRepository ParentFormsRepo = new ParentFormsRepository();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        int temp_id = 0;
        public FrmAddNewMajorAvailable(frmMajorMenuAvailableForms frm,
            int UserId,
            string Mode,
            int ParentId,
            string ParentName)
        {
            InitializeComponent();
            ths = frm;
            this.ParentFormEntity.Created_By = UserId.ToString();
            this.ParentFormEntity.Mode = Mode;
            this.ParentFormEntity.Parent_Id = ParentId;
            this.ParentFormEntity.Parent_Form_Name = ParentName;
        }

        private void FrmAddNewParentForm_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.getAllParentMenu();
            this.DisplayUserRightsData();

            if (this.ParentFormEntity.Mode == "Add")
            {
                this.Text = "Add New Menu";
               
            }
            else
            {
                this.Text = "Update Menu";
                this.txtMaterialMenu.Text = this.ParentFormEntity.Parent_Form_Name;
        
            }
        }

        private void DisplayUserRightsData()      //method for loading available_menus
        {

            this.myClass.fillDataGridView(dgvUserRights, "user_rights", dSet);

        }
        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }

   

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void FrmAddNewMajorAvailable_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.textBox1.Text = "FormClosed";
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {

            if (this.txtMaterialMenu.Text.Trim() == "")
            {

                this.GlobalStatePopup.FillRequiredFields();
                this.txtMaterialMenu.BackColor = Color.Yellow;
                this.txtMaterialMenu.Focus();
                return;
            }

            if (this.ParentFormEntity.Mode == "Add")
            {

                this.dSet.Clear();
                this.dSet = this.g_objStoredProcCollection
                    .sp_ParentForms(0,
                    this.txtMaterialMenu.Text.Trim(),
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "validate");

                if (this.dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();
                    this.txtMaterialMenu.Focus();
                    return;
                }

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to save?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    this.dSet.Clear();
                    this.dSet = this.g_objStoredProcCollection
                    .sp_ParentForms(0,
                    this.txtMaterialMenu.Text.Trim(),
                    DateTime.Now.ToString(),
                    userinfo.user_id.ToString(),
                    this.ParentFormEntity.Updated_At,
                    this.ParentFormEntity.Created_By,
                    userinfo.user_id.ToString(),
                    this.ParentFormEntity.Department,
                    "add");
                    this.ConnectionInit();
          
                    this.getAllParentMenu();
                    this.showvalue();
                    this.UserForLoop();


                }
                else
                {

                    return;
                }

            }
            //edit data
            else

            {

                if (this.ParentFormEntity.Parent_Form_Name == this.txtMaterialMenu.Text.Trim())
                {

                }
                else
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_ParentForms(0,
                        txtMaterialMenu.Text.Trim(), "", "", "", "", "", "", "validate");

                    if (dSet.Tables[0].Rows.Count > 0)
                    {
                        this.GlobalStatePopup.DataAlreadyExist();
                        this.txtMaterialMenu.Focus();
                        return;
                    }
                }

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_ParentForms(ParentFormEntity.Parent_Id,
                        this.txtMaterialMenu.Text.Trim(),
                        DateTime.Now.ToString(),
                        this.ParentFormEntity.Created_By,
                        DateTime.Now.ToString(),
                        this.ParentFormEntity.Created_By,
                        this.ParentFormEntity.Created_By,
                        "",
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


        private void getAllParentMenu()
        {
            myClass.fillListBoxMajorMenu(lstParentMenu, "ParentFormsListView", dSet);
        }


        public void UserForLoop()
        {
        

            dSet.Clear();
            dSet = g_objStoredProcCollection
                   .sp_userfileIncrement(0,
                Convert.ToInt32(ParentFormEntity.UserRightsId),
                "s10",
                "s9",
               "s8",
                "7",
                "s6",
                "s5",
                "s4",
                "s3",
                "s2",
                Convert.ToInt32(this.temp_id).ToString(),
                Convert.ToInt32(this.temp_id).ToString(), "addModuleRightsMajorPartial");

            if (this.dgvUserRights.Rows.Count >= 1)
            {
                int i = this.dgvUserRights.CurrentRow.Index + 1;
                if (i >= -1 && i < this.dgvUserRights.Rows.Count)
                    this.dgvUserRights.CurrentCell = this.dgvUserRights.Rows[i].Cells[0];
                else
                {

                    this.DisplayUserRightsData();
                    this.GlobalStatePopup.SuccessFullySave();
                    this.Close();
                    return;
                }

            }
            this.UserForLoop();

        }

        private void dgvUserRights_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.dgvUserRights.Rows.Count > 0)
            {
                if (this.dgvUserRights.CurrentRow != null)
                {
                    if (this.dgvUserRights.CurrentRow.Cells["user_rights_name"].Value != null)
                    {
                        this.ParentFormEntity.UserRightsId = Convert.ToInt32(this.dgvUserRights.CurrentRow.Cells["user_rights_id"].Value);

                    }
                }
            }

        }

        private void txtMaterialMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void lstParentMenu_SelectedValueChanged(object sender, EventArgs e)
        {
         
         
            
        }

        private void showvalue()
        {

            if (lstParentMenu.Items.Count > 0)
            {
                temp_id = Convert.ToInt32(lstParentMenu.SelectedValue.ToString());

                //MessageBox.Show(lstParentMenu.SelectedValue.ToString());
            }


        }

        private void lstParentMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lstParentMenu_CursorChanged(object sender, EventArgs e)
        {
         
        }

        private void MatBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }




}
