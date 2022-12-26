using COMPLETE_FLAT_UI.Models;
using System;
using System.Data;
using System.Windows.Forms;
using ULTRAMAVERICK.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using ULTRAMAVERICK.Forms.Users.Menus.Modal;
using ULTRAMAVERICK.API.Entities;

namespace ULTRAMAVERICK.Forms.Users
{
    public partial class frmMajorMenuAvailableForms : MaterialForm
    {
 
        public Byte[] imageByte = null;
        readonly myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        myglobal pointer_module = new myglobal();
        DateTime dNow = DateTime.Now;
        DataSet dSet = new DataSet();
        DataSet dSet_temp = new DataSet();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        readonly ParentForms ParentFormEntity = new ParentForms();

        public frmMajorMenuAvailableForms()
        {
            InitializeComponent();
        }
        MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;

        private void frmParentAvailableForms_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            myglobal.global_module = "Active"; 
            this.getAllParentMenu();
            this.textBox1.Text = String.Empty;
            this.GetRadionDataChanged();
        }

        private void ConnectionInit()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections();
        }

        private void GetRadionDataChanged()
        {
            this.matRadioActive.Checked = true;
        }

  
        private void  getAllParentMenu()
        {
            try
            {
                this.myClass.fillDataGridView(this.DgvMajorMenu, "ParentForms", this.dSet);

                this.lbltotalrecords.Text = this.DgvMajorMenu.RowCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getAllParentMenuInactive()
        {
            try
            {

                this.myClass.fillDataGridView(this.DgvMajorMenu, "ParentFormsInactive", this.dSet);

                this.lbltotalrecords.Text = this.DgvMajorMenu.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        DataSet dset_emp = new DataSet();
        private void doSearch()
        {
            try
            {
                if (dset_emp.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp.Tables[0]);
                    if (myglobal.global_module == "EMPLOYEE")
                    {

                    }
                    else if (myglobal.global_module == "Active")
                    {

                        dv.RowFilter = "parent_form_name like '%" + this.mattxtSearch.Text + "%'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    this.DgvMajorMenu.DataSource = dv;
                    this.lbltotalrecords.Text = this.DgvMajorMenu.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
               this.mattxtSearch.Focus();
                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.mattxtSearch.Focus();
                return;
            }
        }
        public void load_search()
        {
            dset_emp.Clear();

            if (this.matRadioActive.Checked == true)
            {
                if (myglobal.global_module == "Active")
                { dset_emp = g_objStoredProcCollection.sp_getMajorTables("ParentFormscurrentcellchanged"); }
            }

            else
            {
                if (myglobal.global_module == "Active")
                { dset_emp = g_objStoredProcCollection.sp_getMajorTables("ParentFormscurrentcellchangedInActive"); }
            }



       
       
            this.doSearch();

        }



        private void PutInactiveData()
        {
            if (this.matRadioActive.Checked == true)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to deactivate?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (Convert.ToInt32(this.lbltotalrecords.Text) > 0)
                    {

                        this.dSet_temp.Clear();
                        this.dSet_temp = this.g_objStoredProcCollection
                        .sp_ParentForms(
                       this.ParentFormEntity.Parent_Id,
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "delete");

                        this.GlobalStatePopup.InactiveSuccessfully();
                        this.frmParentAvailableForms_Load(new object(), new System.EventArgs());

                    }


                }
                else
                {
                    this.matBtnEDit.Visible = true;
                    return;
                }

            }

            else
            {
                //
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to activate?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Convert.ToInt32(this.lbltotalrecords.Text) > 0)
                    {



                        this.dSet_temp.Clear();
                        this.dSet_temp = this.g_objStoredProcCollection
                        .sp_ParentForms(
                       this.ParentFormEntity.Parent_Id,
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "activate");

                        this.GlobalStatePopup.ActivatedSuccessfully();
                        this.frmParentAvailableForms_Load(new object(), new System.EventArgs());

                    }


                }
                else
                {

                    this.matBtnEDit.Visible = true;
                    return;
                }

            }

        }


        private void btnAddTool_Click_1(object sender, EventArgs e)
        {
            this.matBtnDelete.Visible = false;
            this.materialBtnNew.Visible = false;
            this.matBtnCancel.Visible = true;
            this.matBtnEDit.Visible = false;


           FrmAddNewMajorAvailable addNew = 
            new  FrmAddNewMajorAvailable(
            this,
            userinfo.user_rights_id,
            "Add", 
            this.ParentFormEntity.Parent_Id,
            this.ParentFormEntity.Parent_Form_Name
            );
            addNew.ShowDialog();
        }

        private void btnCancelTool_Click_1(object sender, EventArgs e)
        {      
        this. matBtnCancel.Visible = false;
        this.materialBtnNew.Visible = true;
        this.matBtnDelete.Visible = true;
        this.matBtnSave.Visible = false;
        this.matBtnEDit.Visible = true;
        this.matBtnDelete.Visible = true;
        }

        private void btnDeleteTool_Click_1(object sender, EventArgs e)
        {
            this.PutInactiveData();
        }

        private void btnUpdateTool_Click_1(object sender, EventArgs e)
        {
        }

        private void btnEditTool_Click(object sender, EventArgs e)
        {         
                if (Convert.ToInt32(this.lbltotalrecords.Text) > 0)
                {   
                    this.matBtnEDit.Visible = false;
                    this.materialBtnNew.Visible = false;
                    this.matBtnCancel.Visible = true;
                    this.matBtnDelete.Visible = false;
                    this.matBtnSave.Visible = true;

                    FrmAddNewMajorAvailable addNew =
                    new FrmAddNewMajorAvailable(
                    this,
                    userinfo.user_id,
                    "Edit",
                    this.ParentFormEntity.Parent_Id,
                    this.ParentFormEntity.Parent_Form_Name
                    );
                    addNew.ShowDialog();
            }
            }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.btnCancelTool_Click_1(sender, e);
            this.frmParentAvailableForms_Load(sender, e);
        }

        private void DgvMajorMenu_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.DgvMajorMenu.Rows.Count > 0)
            {
                if (this.DgvMajorMenu.CurrentRow != null)
                {
                    if (this.DgvMajorMenu.CurrentRow.Cells["parent_form_name"].Value != null)
                    {
                        this.ParentFormEntity.Total_Touched = Convert.ToInt32(this.DgvMajorMenu.CurrentRow.Cells["TOTAL_TOUCHED"].Value);
                        this.ParentFormEntity.Parent_Form_Name = this.DgvMajorMenu.CurrentRow.Cells["parent_form_name"].Value.ToString();
                        this.ParentFormEntity.Parent_Id = Convert.ToInt32(this.DgvMajorMenu.CurrentRow.Cells["parent_id"].Value);
                        if (this.ParentFormEntity.Total_Touched == 0)
                        {
                            this.matBtnEDit.Enabled = true;
                        }
                        else
                        {
                            this.matBtnEDit.Enabled = false;
                        }

                    }
                }
            }
        }

        private void mattxtSearch_TextChanged(object sender, EventArgs e)
        {
            this.load_search();
        }

        private void matRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                this.matBtnDelete.Text = "&InActive";
                this.ConnectionInit();
                this.getAllParentMenu();
            }
            else
            {
                this.ConnectionInit();
                this.getAllParentMenuInactive();
            }
        }

        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                this.ConnectionInit();
                this.getAllParentMenu();
            }
            else
            {
                this.matBtnDelete.Text = "&Activate";
                this.ConnectionInit();
                this.getAllParentMenuInactive();
            }
        }

        private void mattxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
