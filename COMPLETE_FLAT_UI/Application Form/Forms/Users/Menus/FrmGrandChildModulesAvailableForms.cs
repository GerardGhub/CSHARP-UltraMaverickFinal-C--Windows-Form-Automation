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
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        IStoredProcedures g_objStoredProcCollection = null;
        public Byte[] imageByte = null;
        readonly myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        readonly Available_Menu_GrandChild AvailableMenuGrandChildEntity = new Available_Menu_GrandChild();
        string mode = "";
        int p_id = 0;
        int temp_hid = 0;
        DateTime dNow = DateTime.Now;



        DataSet dSet_temp = new DataSet();

        public frmModulesAvailableForms()
        {
            InitializeComponent();
        }
        public string Sp_RightsID { get; set; }

        private void frmGrandChildAvailableForms_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.displayGrandChildFormsData();
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



   

        DataSet dset_emp = new DataSet();
        private void SearchGrandChildData()
        {

            if (this.matRadioActive.Checked == true)
            {
                this.dset_emp = this.g_objStoredProcCollection
                .sp_getMajorTables("SearchGrandChildForms");
            }
            else
            {
                this.dset_emp = this.g_objStoredProcCollection
                .sp_getMajorTables("SearchGrandChildForms_InActive");
            }


            if (this.dset_emp.Tables.Count > 0)
            {
                DataView dv = new DataView(this.dset_emp.Tables[0]);
                dv.RowFilter = "menu_form_name = '" + this.MatTxtSearchBox.Text + "'" +
                "or menu_name like '%"+this.MatTxtSearchBox.Text+ "%' " +
                "or count like '%" + this.MatTxtSearchBox.Text + "%'" +
                "or childform like '%" + this.MatTxtSearchBox.Text + "%' ";
                this.dgvGrandChildForms.DataSource = dv;
                this.lbltotalrecords.Text = dgvGrandChildForms.RowCount.ToString();
            }
        }

     
        private void displayGrandChildFormsData()      //method for loading available_menus
        {
  
            this.myClass.fillDataGridView(this.dgvGrandChildForms, "available_menu_grandChild", dSet);
            this.lbltotalrecords.Text = this.dgvGrandChildForms.RowCount.ToString();
        }

        private void displayGrandChildFormsDataInActive()      //method for loading available_menus
        {

            this.myClass.fillDataGridView(this.dgvGrandChildForms, "available_menu_grandChild_InActive", dSet);
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

        }




        private void btnCancelTool_Click(object sender, EventArgs e)
        {
            this.mode = "";
            this.txt_read_only(true);
            this.btn_visible(true);
            this.dgvGrandChildForms_CurrentCellChanged(sender, e);
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
                        this.AvailableMenuGrandChildEntity.Parent_Menu = dgvGrandChildForms.CurrentRow.Cells["count"].Value.ToString();
                       this.AvailableMenuGrandChildEntity.ChildForm = dgvGrandChildForms.CurrentRow.Cells["ChildForm"].Value.ToString();
                        this.AvailableMenuGrandChildEntity.Created_At = dgvGrandChildForms.CurrentRow.Cells["created_at"].Value.ToString();
                        this.AvailableMenuGrandChildEntity.Created_By = dgvGrandChildForms.CurrentRow.Cells["created_by"].Value.ToString();
                        this.AvailableMenuGrandChildEntity.Updated_At = dgvGrandChildForms.CurrentRow.Cells["updated_at"].Value.ToString();
                        this.AvailableMenuGrandChildEntity.Updated_By = dgvGrandChildForms.CurrentRow.Cells["updated_by"].Value.ToString();
                        this.AvailableMenuGrandChildEntity.SubMenuID = Convert.ToInt32(dgvGrandChildForms.CurrentRow.Cells["parent_menu"].Value);

                    }
                }
            }
        }


   


        private void dgvChildForms_CurrentCellChanged(object sender, EventArgs e)
        {
            this.ShowValue();
        }



 

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            mode = "add";
            this.btn_visible(false);
            this.txt_read_only(false);



            FrmAddNewModule addNew =
             new FrmAddNewModule(
             this,
             userinfo.user_id,
             "Add",
             this.AvailableMenuGrandChildEntity.Menu_Id,
             this.AvailableMenuGrandChildEntity.Menu_Name,
             this.AvailableMenuGrandChildEntity.Menu_Form_Name,
             this.AvailableMenuGrandChildEntity.Parent_Menu,
             this.AvailableMenuGrandChildEntity.ChildForm,
             this.AvailableMenuGrandChildEntity.SubMenuID);
            addNew.ShowDialog();




        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.dgvGrandChildForms.RowCount > 0)
            {
                this.temp_hid = dgvGrandChildForms.CurrentRow.Index;

                this.mode = "edit";
                this.btn_visible(false);
                this.txt_read_only(false);


                FrmAddNewModule addNew =
                 new FrmAddNewModule(
                 this,
                 userinfo.user_id,
                 "Edit",
                 this.AvailableMenuGrandChildEntity.Menu_Id,
                 this.AvailableMenuGrandChildEntity.Menu_Name,
                 this.AvailableMenuGrandChildEntity.Menu_Form_Name,
                 this.AvailableMenuGrandChildEntity.Parent_Menu,
                 this.AvailableMenuGrandChildEntity.ChildForm,
                 this.AvailableMenuGrandChildEntity.SubMenuID);
                 addNew.ShowDialog();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {


          
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (this.dgvGrandChildForms.Rows.Count > 0)
            {

                if (this.matRadioActive.Checked == true)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to inactive the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        this.mode = "delete";
 

                        this.dSet_temp.Clear();
                        this.dSet_temp = g_objStoredProcCollection
                            .sp_available_menu_grandChild(
                            this.AvailableMenuGrandChildEntity.Menu_Id,
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            userinfo.user_id.ToString(),
                            "delete");
                        this.GlobalStatePopup.InactiveSuccessfully();
                        this.btnCancelTool_Click("", e);
                        this.frmGrandChildAvailableForms_Load(sender, e);
                    }

                    else
                    {
                        return;
                    }
                }

                else
                {
                    //Start of Activation

                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to activate the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        this.mode = "activate";
                      
                        this.dSet_temp.Clear();
                        this.dSet_temp = g_objStoredProcCollection
                            .sp_available_menu_grandChild(
                            this.AvailableMenuGrandChildEntity.Menu_Id,
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            userinfo.user_id.ToString(),
                            "activate");
                        this.GlobalStatePopup.ActivatedSuccessfully();
                        this.btnCancelTool_Click("", e);
                        this.frmGrandChildAvailableForms_Load(sender, e);
                    }

                    else
                    {
                        return;
                    }


                    //End of Activation
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
            this.mode = "";
            this.txt_read_only(true);
            this.btn_visible(true);
            this.dgvGrandChildForms_CurrentCellChanged(sender, e);
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

        private void MatTxtSearchBox_TextChanged(object sender, EventArgs e)
        {
            this.SearchGrandChildData();
        }

        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                this.ConnectionInit();
                this.displayGrandChildFormsData();
            }
            else
            {
                this.btnDeleteTool.Text = "&Activate";
                this.ConnectionInit();
                this.displayGrandChildFormsDataInActive();
            }
        }

        private void matRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                this.btnDeleteTool.Text = "&InActive";
                this.ConnectionInit();
                this.displayGrandChildFormsData();
            }
            else
            {
                this.ConnectionInit();
                this.displayGrandChildFormsDataInActive();
            }

        }

        private void MatTxtSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
