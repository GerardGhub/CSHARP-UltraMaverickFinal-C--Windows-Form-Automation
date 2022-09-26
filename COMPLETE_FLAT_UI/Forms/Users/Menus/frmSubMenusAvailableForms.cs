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
    public partial class frmSubMenusAvailableForms : MaterialForm
    {
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        IStoredProcedures g_objStoredProcCollection = null;
        readonly myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        public Byte[] imageByte = null;

        string mode = "";
        int p_id = 0;
        int temp_hid = 0;
        DateTime dNow = DateTime.Now;
        readonly Available_Menu AvailableMenuEntity = new Available_Menu();

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
            this.ConnectionInit();
            this.displayChildFormsData();
            this.GetRadionDataChanged();
            this.textBox1.Text = String.Empty;
        }

        public void ConnectionInit()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }
        private void GetRadionDataChanged()
        {
            this.matRadioActive.Checked = true;
        }


   
        private void displayChildFormsData()    
        {
            try
            {
               
                this.myClass.fillDataGridView(this.dgvChildForms, "available_menu", dSet);

                this.lbltotalrecords.Text = this.dgvChildForms.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void displayChildFormsDataInActive()      //method for loading available_menus
        {
            try
            {

                this.myClass.fillDataGridView(this.dgvChildForms, "available_menu_inactive", dSet);

                this.lbltotalrecords.Text = this.dgvChildForms.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }




     
        private void btn_visible(Boolean val)
        {
            this.btnAddTool.Visible = val;
            this.btnEditTool.Visible = val;
            this.btnDeleteTool.Visible = val;
            this.btnUpdateTool.Visible = !val;
            this.btnCancelTool.Visible = !val;
        }

        private void btnCancelTool_Click(object sender, EventArgs e)
        {
            this.mode = "";
            this.btn_visible(true);
            this.dgvChildForms_CurrentCellChanged(sender, e);
        }

        private void dgvChildForms_CurrentCellChanged(object sender, EventArgs e)
        {
            this.ShowValue();
        }

        private void ShowValue()
        {
            if (this.dgvChildForms.Rows.Count > 0)
            {
                if (this.dgvChildForms.CurrentRow != null)
                {
                    if (this.dgvChildForms.CurrentRow.Cells["menu_id"].Value != null)
                    {
                        this.p_id = Convert.ToInt32(this.dgvChildForms.CurrentRow.Cells["menu_id"].Value);
                        this.AvailableMenuEntity.Menu_Id = Convert.ToInt32(this.dgvChildForms.CurrentRow.Cells["menu_id"].Value);
                        this.AvailableMenuEntity.Menu_Form_Name = this.dgvChildForms.CurrentRow.Cells["menu_form_name"].Value.ToString();
                        this.AvailableMenuEntity.Menu_Name = this.dgvChildForms.CurrentRow.Cells["menu_name"].Value.ToString();
                        this.AvailableMenuEntity.Count = this.dgvChildForms.CurrentRow.Cells["count"].Value.ToString();
                        this.AvailableMenuEntity.MajorMenuID = Convert.ToInt32(this.dgvChildForms.CurrentRow.Cells["MajorMenuID"].Value);
                    }
                }
            }
        }


      


        private void dgvChildForms_CurrentCellChanged_1(object sender, EventArgs e)
        {
            if (this.mode == "add")
            {
                this.dgvChildForms.Enabled = false;
            }
            else
            {
                this.dgvChildForms.Enabled = true;
               
            }
            this.ShowValue();
        }






        DataSet dset_emp = new DataSet();
        private void SearchSubMenuData()
        {
            if (this.matRadioActive.Checked == true)
            {
                this.dset_emp = this.g_objStoredProcCollection.sp_getMajorTables("available_menu_Major");
            }
            else
            {
                this.dset_emp = this.g_objStoredProcCollection.sp_getMajorTables("available_menu_Major_InActive");
            }


            if (this.dset_emp.Tables.Count > 0)
            {
                DataView dv = new DataView(this.dset_emp.Tables[0]);


                dv.RowFilter = "menu_name = '" + this.MatTxtSearchBox.Text + "' or menu_form_name like '%" + this.MatTxtSearchBox.Text + "%' ";



                this.dgvChildForms.DataSource = dv;
                this.lbltotalrecords.Text = dgvChildForms.RowCount.ToString();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
            this.dgvChildForms.Enabled = false;
            btn_visible(false);



            FrmAddNewSubMenu addNew =
             new FrmAddNewSubMenu(
             this,
             userinfo.user_id,
             "ADD",
             this.AvailableMenuEntity.Menu_Id,
             this.AvailableMenuEntity.Menu_Name,
             this.AvailableMenuEntity.Count,
             this.AvailableMenuEntity.Menu_Form_Name,
             this.AvailableMenuEntity.MajorMenuID
             );
            addNew.ShowDialog();


        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.dgvChildForms.RowCount > 0)
            {
                this.temp_hid = dgvChildForms.CurrentRow.Index;
         
                this.btn_visible(false);

                FrmAddNewSubMenu addNew =
                new FrmAddNewSubMenu(
                this,
                userinfo.user_id,
                "EDIT",
                this.AvailableMenuEntity.Menu_Id,
                this.AvailableMenuEntity.Menu_Name,
                this.AvailableMenuEntity.Count,
                this.AvailableMenuEntity.Menu_Form_Name,
                this.AvailableMenuEntity.MajorMenuID
                );
                addNew.ShowDialog();


            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (this.dgvChildForms.Rows.Count > 0)
            {
                if (this.matRadioActive.Checked == true)
                {

                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to deactivate the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        this.mode = "delete";

                        this.dSet_temp.Clear();
                        this.dSet_temp = g_objStoredProcCollection
                            .sp_available_menu(this.AvailableMenuEntity.Menu_Id,
                            this.AvailableMenuEntity.Menu_Form_Name,
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "delete");

                        this.GlobalStatePopup.InactiveSuccessfully();
                        this.btnCancelTool_Click("", e);
                        this.frmChildAvailableForms_Load(sender, e);

                    }

                    else
                    {
                        return;
                    }
                }
                else
                {

                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to activate the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.mode = "activate";

                        this.dSet_temp.Clear();
                        this.dSet_temp = g_objStoredProcCollection
                            .sp_available_menu(this.AvailableMenuEntity.Menu_Id,
                            this.AvailableMenuEntity.Menu_Form_Name,
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "activate");

                        this.GlobalStatePopup.ActivatedSuccessfully();
                        this.btnCancelTool_Click("", e);
                        this.frmChildAvailableForms_Load(sender, e);

                    }

                    else
                    {
                        return;
                    }


                }

            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            mode = "";
            this.btn_visible(true);
            this.dgvChildForms_CurrentCellChanged(sender, e);
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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.toolStripButton5_Click(sender,  e);
            this.frmChildAvailableForms_Load(sender, e);
        }

        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                this.ConnectionInit();
                this.displayChildFormsData();
            }
            else
            {
                this.btnDeleteTool.Text = "&Activate";
                this.ConnectionInit();
                this.displayChildFormsDataInActive();
            }
        }

        private void matRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                this.btnDeleteTool.Text = "&InActive";
                this.ConnectionInit();
                this.displayChildFormsData();
            }
            else
            {
                this.ConnectionInit();
                this.displayChildFormsDataInActive();
            }
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {
   
            this.SearchSubMenuData();
        }

        private void MatTxtSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
