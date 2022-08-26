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
using ULTRAMAVERICK.Forms.Users.Menus.Modal;
using ULTRAMAVERICK.API.Entities;

namespace ULTRAMAVERICK.Forms.Users
{
    public partial class frmMajorAvailableForms : MaterialForm
    {
 
        public Byte[] imageByte = null;
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        myglobal pointer_module = new myglobal();
        DateTime dNow = DateTime.Now;
        string mode = "";
        DataSet dSet = new DataSet();
        Boolean ready = false;
        //int temp_id = 0;
        DataSet dSet_temp = new DataSet();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        ParentForms ParentFormEntity = new ParentForms();

        public frmMajorAvailableForms()
        {
            InitializeComponent();
        }
        MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;

        public string sp_department_id { get; set; }
        public int temp_id { get; set; }
        public string sp_user_rights_id { get; set; }
        public string sp_created_at { get; set; }
        public string Sp_CreatedByAndUserID { get; set; }
        public string Sp_modified_at { get; set; }
        private void frmParentAvailableForms_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections

            myglobal.global_module = "Active"; // Mode for Searching
            this.load_search(); //Bind the Information
      


            this.getAllParentMenu(); // all Parent Menu Forms

            this.loadDepartment();  //Call the Department
            this.displayUserRightsData();
            this.textBox1.Text = String.Empty;
        }


        private void displayUserRightsData()      //method for loading available_menus
        {
   
            myClass.fillDataGridView(dgvUserRights, "user_rights", dSet);
      

        }
        public void loadDepartment()
        {
            myClass.fillComboBoxDepartment(cboDepartmentMaterial, "department_dropdown", dSet);
            sp_department_id = cboDepartmentMaterial.SelectedValue.ToString();
        }

        private void  getAllParentMenu()
        {

            try
            {

                this.myClass.fillDataGridView(this.DgvMajorMenu, "ParentForms", this.dSet);

                this.lbltotalrecords.Text = DgvMajorMenu.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddTool_Click(object sender, EventArgs e)
        {
            mode = "add";
            cboDepartmentMaterial.Visible = true;
            txtMaterialDepartment.Visible = false;

            materialBtnNew.Visible = false;

      

            txtMaterialMenu.Enabled = true;
            txtMaterialMenu.Text = string.Empty;
           matBtnCancel.Visible = true;


           sp_created_at = (dNow.ToString("M/d/yyyy"));
            txtCreatedBy.Text = userinfo.emp_name.ToUpper();
            this.Sp_CreatedByAndUserID = userinfo.user_id.ToString();
            matBtnSave.Visible = true;
            matBtnEDit.Visible = false;
            cboDepartmentMaterial.Enabled = true;
            loadDepartment();
            txtMaterialMenu.Focus();
        }

        private void btnCancelTool_Click(object sender, EventArgs e)
        {

            matBtnCancel.Visible = false;
            materialBtnNew.Visible = true;
            txtMaterialMenu.Enabled = false;
            matBtnSave.Visible = false;
            matBtnEDit.Visible = true;
            matBtnDelete.Visible = true;
            cboDepartmentMaterial.Enabled = false;
            cboDepartmentMaterial.Visible = false;
            txtMaterialDepartment.Visible = true;
        }

        private void btnUpdateTool_Click(object sender, EventArgs e)
        {
            metroButtonSave_Click(sender, e);
        }



        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Save the New Parent Menu " + txtMaterialMenu.Text + "", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (this.txtMaterialMenu.Text.Trim() == "")
                {


                    this.GlobalStatePopup.FillRequiredFields();
                    this.txtMaterialMenu.BackColor = Color.Yellow;
                    this.txtMaterialMenu.Focus();
                    return;
                }



                else
                {
                    if (saveMode())
                    {
                        //getAllParentMenu();
          

                        mode = "";
                        this.GlobalStatePopup.SuccessFullySave();
                        frmParentAvailableForms_Load(sender, e);
                        matBtnSave.Visible = false;
                        materialBtnNew.Visible = true;
                        matBtnCancel.Visible = false;
                
                        matBtnEDit.Visible = true;
                        matBtnDelete.Visible = true;
                        cboDepartmentMaterial.Enabled = false;
                        lstParentMenu_Click(sender, e);
                    }
                }

                txtMaterialMenu.Enabled = false;

            }
            else
            {

                return;
            }
        }

    


        public bool saveMode()
        {
            if (mode == "add")
            {
               
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_ParentForms(0,
                    txtMaterialMenu.Text.Trim(),
                        sp_created_at,
                    txtCreatedBy.Text.Trim(),
                    this.Sp_modified_at,
                    txtModifiedBy.Text.Trim(),
                    this.Sp_CreatedByAndUserID,
                    sp_department_id,
                    "add");

                    getAllParentMenu();
                    matBtnNext_Click(new object(), new System.EventArgs());
                    return true;
                

            }

            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_ParentForms(temp_id,
                    txtMaterialMenu.Text.Trim(), "",
                    this.Sp_CreatedByAndUserID, "", "", "", "", "getbyname");

                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_ParentForms(temp_id, txtMaterialMenu.Text.Trim(), "", "", "", "", "", "", "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == temp_id)
                    {
                        dSet.Clear();
                        dSet = g_objStoredProcCollection.sp_ParentForms(temp_id,
                            txtMaterialMenu.Text.Trim(),
                                 this.sp_created_at,
                            this.txtCreatedBy.Text.Trim(),                      
                            this.Sp_modified_at,
                            this.txtModifiedBy.Text.Trim(),
                            this.Sp_CreatedByAndUserID,
                            this.sp_department_id,
                            "edit");

                        return true;
                    }
                    else
                    {
                        this.GlobalStatePopup.DataAlreadyExist();
                        this.txtMaterialMenu.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_ParentForms(temp_id,
                        this.txtMaterialMenu.Text.Trim(),
                            this.sp_created_at,
                        this.txtCreatedBy.Text.Trim(),
                        this.Sp_modified_at,
                        this.txtModifiedBy.Text.Trim(),
                        this.Sp_CreatedByAndUserID,
                       this.sp_department_id,
                        "edit");

                    return true;
                }
            }
            else if (mode == "delete")
            {
                dSet.Clear();


                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_ParentForms(temp_id, "", "", "", "", "", "", "", "delete");

                return true;
            }

            return false;
        }


        private void lstParentMenu_Click(object sender, EventArgs e)
        {
            if(mode=="add")
            {
           
            }
            else
            {
                doSearch();

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

                        dv.RowFilter = "parent_form_name like '%" + txtMaterialMenu.Text + "%'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dgv_table.DataSource = dv;
                    //lblrecords.Text = dgv_table.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaterialMenu.Focus();
                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaterialMenu.Focus();
                return;
            }
        }
        public void load_search()
        {
            dset_emp.Clear();

            
            if (myglobal.global_module == "Active")
            { dset_emp = g_objStoredProcCollection.sp_getMajorTables("ParentFormscurrentcellchanged"); }
       
            this.doSearch();

        }



 

        private void matBtnEDit_Click(object sender, EventArgs e)
        {


            if (Convert.ToInt32(this.lbltotalrecords.Text) > 0)
            {
                this.mode = "edit";
                this.txtMaterialMenu.Enabled = true;
                this.txtMaterialMenu.ReadOnly = false;
                this.matBtnEDit.Visible = false;
                this.materialBtnNew.Visible = false;
                this.matBtnCancel.Visible = true;
                this.matBtnDelete.Visible = false;
                this.matBtnSave.Visible = true;
                this.cboDepartmentMaterial.Enabled = true;
                this.Sp_modified_at = (dNow.ToString("M/d/yyyy"));
                this.txtModifiedBy.Text = userinfo.emp_name.ToUpper();
            }
        }

        private void btnDeleteTool_Click(object sender, EventArgs e)
        {
            metroButtonDelete_Click(sender, e);
        }

  

        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to deactivate?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (Convert.ToInt32(this.lbltotalrecords.Text) > 0)
                {

                    mode = "delete";
                    if (saveMode())
                    {

               

                        mode = "";

                        this.dSet_temp.Clear();
                        this.dSet_temp = g_objStoredProcCollection.sp_ParentForms(this.ParentFormEntity.Parent_Id, "", "", "", "", "", "", "", "delete");

                        this.GlobalStatePopup.InactiveSuccessfully();
                        this.getAllParentMenu();
                        load_search();
                        doSearch();


                    }
                }
                //}

            }
            else
            {

                matBtnEDit.Visible = true;
                return;
            }
        }

        private void dgv_table_CurrentCellChanged(object sender, EventArgs e)
        {
            this.showParentMenuDetails();
        }
        private void showParentMenuDetails()
        {
            if (this.dgv_table.RowCount > 0)
            {
                if (this.dgv_table.CurrentRow != null)
                {
                    if (this.dgv_table.CurrentRow.Cells["parent_form_name"].Value != null)
                    {
                        this.txtMaterialMenu.Text = dgv_table.CurrentRow.Cells["parent_form_name"].Value.ToString();                
                        this.txtCreatedBy.Text = dgv_table.CurrentRow.Cells["created_by"].Value.ToString();
                        this.sp_created_at = dgv_table.CurrentRow.Cells["created_at"].Value.ToString();
                        this.txtMaterialDepartment.Text = dgv_table.CurrentRow.Cells["department"].Value.ToString();
                        this.txtModifiedBy.Text = dgv_table.CurrentRow.Cells["updated_by"].Value.ToString();
                        this.Sp_modified_at = dgv_table.CurrentRow.Cells["updated_at"].Value.ToString();
                    }

                }
            }
        }


        



   

        private void txtMaterialMenu_TextChanged(object sender, EventArgs e)
        {
    
          
       
        }

 



        private void cboDepartmentMaterial_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
           sp_department_id = cboDepartmentMaterial.SelectedValue.ToString();
        }

      
     




        private void matBtnNext_Click(object sender, EventArgs e)
        {
        

            dSet.Clear();
            dSet = g_objStoredProcCollection.sp_userfileIncrement(0,
                Convert.ToInt32(sp_user_rights_id),
                "s10",
                "s9",
               "s8",
                "7",
                "s6",
                "s5",
                "s4",
                "s3",
                "s2",
                Convert.ToInt32(temp_id).ToString(),
                Convert.ToInt32(temp_id).ToString(), "addModuleRightsMajorPartial");

            if (dgvUserRights.Rows.Count >= 1)
            {
                int i = dgvUserRights.CurrentRow.Index + 1;
                if (i >= -1 && i < dgvUserRights.Rows.Count)
                    dgvUserRights.CurrentCell = dgvUserRights.Rows[i].Cells[0];
                else
                {

                    displayUserRightsData();

                    return;
                }

            }
            matBtnNext_Click(sender, e);

        }

        private void dgvUserRights_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvUserRights.Rows.Count > 0)
            {
                if (dgvUserRights.CurrentRow != null)
                {
                    if (dgvUserRights.CurrentRow.Cells["user_rights_name"].Value != null)
                    {
                        sp_user_rights_id = dgvUserRights.CurrentRow.Cells["user_rights_id"].Value.ToString();
  
                    }
                }
            }
        }

        private void btnAddTool_Click_1(object sender, EventArgs e)
        {
            this.mode = "add";
            this.cboDepartmentMaterial.Visible = true;
            this.txtMaterialDepartment.Visible = false;
            this.matBtnDelete.Visible = false;
            this.materialBtnNew.Visible = false;


            this.txtMaterialMenu.Enabled = true;
            this.txtMaterialMenu.Text = string.Empty;
            this.matBtnCancel.Visible = true;


            this.sp_created_at = (dNow.ToString("M/d/yyyy"));
            this.txtCreatedBy.Text = userinfo.emp_name.ToUpper();
            this.Sp_CreatedByAndUserID = userinfo.user_id.ToString();
    
            this.matBtnEDit.Visible = false;
            this.cboDepartmentMaterial.Enabled = true;
            this.loadDepartment();
            this.txtMaterialMenu.Focus();


           FrmAddNewMajorAvailable addNew = 
            new  FrmAddNewMajorAvailable(
            this,
            userinfo.user_id,
            "Add", 
            this.ParentFormEntity.Parent_Id,
            this.ParentFormEntity.Parent_Form_Name
            );
            addNew.ShowDialog();



        }

        private void btnCancelTool_Click_1(object sender, EventArgs e)
        {
      
            matBtnCancel.Visible = false;
            materialBtnNew.Visible = true;
            txtMaterialMenu.Enabled = false;
            matBtnDelete.Visible = true;
            matBtnSave.Visible = false;
            matBtnEDit.Visible = true;
            matBtnDelete.Visible = true;
            cboDepartmentMaterial.Enabled = false;
            cboDepartmentMaterial.Visible = false;
            txtMaterialDepartment.Visible = true;
        }

        private void btnDeleteTool_Click_1(object sender, EventArgs e)
        {
            this.metroButtonDelete_Click(sender, e);
        }

        private void btnUpdateTool_Click_1(object sender, EventArgs e)
        {

            if(mode =="add")
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
            metroButtonSave_Click(sender, e);
        }

        private void btnEditTool_Click(object sender, EventArgs e)
        {
            
  

                if (Convert.ToInt32(this.lbltotalrecords.Text) > 0)
                {
                    this.mode = "edit";
                    this.txtMaterialMenu.Enabled = true;
                    this.txtMaterialMenu.ReadOnly = false;
                    this.matBtnEDit.Visible = false;
                    this.materialBtnNew.Visible = false;
                    this.matBtnCancel.Visible = true;
                    this.matBtnDelete.Visible = false;
                    this.matBtnSave.Visible = true;
                    this.cboDepartmentMaterial.Enabled = true;
                    this.Sp_modified_at = (dNow.ToString("M/d/yyyy"));
                    this.txtModifiedBy.Text = userinfo.emp_name.ToUpper();


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

        private void txtMaterialMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
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
    }
}
