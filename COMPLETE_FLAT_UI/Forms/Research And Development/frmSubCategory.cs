using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMPLETE_FLAT_UI.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Forms.Research_And_Development.Modal;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Research_And_Development
{
    public partial class frmSubCategory : MaterialForm
    {

        IStoredProcedures g_objStoredProcCollection = null;
        readonly myclasses myClass = new myclasses();
        readonly DataSet dSet = new DataSet();
        readonly Sub_Category SubCategoryEntity = new Sub_Category();
        string mode = "";
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();


        DataSet dSet_temp = new DataSet();
        public frmSubCategory()
        {
            InitializeComponent();
        }
    
        private void frmSubCategory_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();

            this.ShowSubCategoryData();
            this.CheckBoxActivated();
            this.TextBox1.Text = String.Empty;
        }

        private void CheckBoxActivated()
        {
            this.matRadioActive.Checked = true;
        }
        private void ConnectionInit()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }
        private void ShowSubCategoryData()      //method for loading available_menus
        {
            try
            {
        
                myClass.fillDataGridView(dgvSubCategory, "Sub_Category", dSet);
         
                lbltotalrecords.Text = dgvSubCategory.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            dgvSubCategory.Columns["is_active"].Visible = false;

        }

        private void ShowSubCategoryDataInActive()      //method for loading available_menus
        {
            try
            {

                myClass.fillDataGridView(dgvSubCategory, "Sub_CategoryInActive", dSet);

                lbltotalrecords.Text = dgvSubCategory.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            dgvSubCategory.Columns["is_active"].Visible = false;

        }


   



        private void dgvMajorCategory_CurrentCellChanged(object sender, EventArgs e)
        {
            this.ShowValueCell();
        }

        private void ShowValueCell()
        {
            if (dgvSubCategory.Rows.Count > 0)
            {
                if (dgvSubCategory.CurrentRow != null)
                {
                    if (dgvSubCategory.CurrentRow.Cells["sub_category_desc"].Value != null)
                    {
                        this.SubCategoryEntity.Sub_Category_Id = Convert.ToInt32(dgvSubCategory.CurrentRow.Cells["sub_category_id"].Value);
                        this.SubCategoryEntity.Sub_Category_Desc = dgvSubCategory.CurrentRow.Cells["sub_category_desc"].Value.ToString();
                        this.SubCategoryEntity.Sc_Added_By = dgvSubCategory.CurrentRow.Cells["sc_added_by"].Value.ToString();
                        this.SubCategoryEntity.Sc_Added_At = dgvSubCategory.CurrentRow.Cells["sc_added_at"].Value.ToString();
                        this.SubCategoryEntity.Sc_Updated_At = dgvSubCategory.CurrentRow.Cells["sc_updated_at"].Value.ToString();
                        this.SubCategoryEntity.Sc_Updated_By = dgvSubCategory.CurrentRow.Cells["sc_updated_by"].Value.ToString();
                        this.SubCategoryEntity.Is_Expirable = dgvSubCategory.CurrentRow.Cells["is_expirable"].Value.ToString();

              
                      
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.mode = "add";
            this.matBtnEdit.Visible = false;
            this.matBtnCancel.Visible = true;
            this.matBtnNew.Visible = false;
            this.matBtnDelete.Visible = false;
    



            this.SubCategoryEntity.Mode = "ADD";
            FrmAddNewCategory addNew =
            new FrmAddNewCategory(this,
            userinfo.user_id,
            this.SubCategoryEntity.Sub_Category_Desc,
            this.SubCategoryEntity.Mode,
            this.SubCategoryEntity.Sub_Category_Id,
            this.SubCategoryEntity.Is_Expirable);
            addNew.ShowDialog();

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.matBtnCancel.Visible = false;
            this.mode = "";
            this.matBtnEdit.Visible = true;

            this.matBtnNew.Visible = true;
            this.matBtnDelete.Visible = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (this.dgvSubCategory.Rows.Count > 0)
            {
                if (this.matRadioActive.Checked == true)
                {

                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to deactivate the data", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {


                        this.mode = "delete";

                        this.dSet_temp.Clear();
                        this.dSet_temp = this.g_objStoredProcCollection
                            .sp_Sub_Category(this.SubCategoryEntity.Sub_Category_Id,
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "delete");
                        this.GlobalStatePopup.InactiveSuccessfully();
                        this.frmSubCategory_Load(sender, e);

                    }

                    else
                    {
                        return;
                    }

                }
                else
                {

                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update the data", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {


                        this.mode = "activate";

                        this.dSet_temp.Clear();
                        this.dSet_temp = this.g_objStoredProcCollection
                            .sp_Sub_Category(this.SubCategoryEntity.Sub_Category_Id,
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "activate");
                        this.GlobalStatePopup.ActivatedSuccessfully();
                        this.frmSubCategory_Load(sender, e);

                    }

                    else
                    {
                        return;
                    }



                }





            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            mode = "edit";
            matBtnDelete.Visible = false;
            matBtnCancel.Visible = true;
            matBtnNew.Visible = false;
            matBtnEdit.Visible = false;



            this.SubCategoryEntity.Mode = "EDIT";
            FrmAddNewCategory addNew =
            new FrmAddNewCategory(this,
            userinfo.user_id,
            this.SubCategoryEntity.Sub_Category_Desc,
            this.SubCategoryEntity.Mode,
            this.SubCategoryEntity.Sub_Category_Id,
            this.SubCategoryEntity.Is_Expirable);
            addNew.ShowDialog();

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
 
        }

  

   

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //refresh
            this.toolStripButton5_Click(sender, e);
            this.frmSubCategory_Load(sender, e);
        }

        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {

                this.matBtnDelete.Text = "&InActive";

                this.ShowSubCategoryData();

            }
            else if (this.matRadioNotActive.Checked == true)
            {

                this.matBtnDelete.Text = "&Activate";
                this.ShowSubCategoryDataInActive();

            }
        }

        private void matRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {

                this.matBtnDelete.Text = "&InActive";

                this.ShowSubCategoryData();

            }
            else if (this.matRadioNotActive.Checked == true)
            {

                this.matBtnDelete.Text = "&Activate";
                this.ShowSubCategoryDataInActive();

            }
        }



        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();

            if (this.matRadioActive.Checked == true)
            {
                this.dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("Sub_CategoryMajor");
            }
            else
            {
                this.dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("Sub_CategoryMajorInActive");
            }

        }

        private void doSearchInTextBoxCmb()
        {
            try
            {


                if (this.dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(this.dset_emp_SearchEngines.Tables[0]);
                    if (myglobal.global_module == "EMPLOYEE")
                    {

                    }
                    else if (myglobal.global_module == "Active")
                    {


                        //Gerard Singian Developer Man

                        dv.RowFilter = "sub_category_desc like '%" + this.MatTxtSearchBox.Text + "%'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    this.dgvSubCategory.DataSource = dv;
                    this.lbltotalrecords.Text = this.dgvSubCategory.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found xxx!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }




        }


        private void MatTxtSearchBox_TextChanged(object sender, EventArgs e)
        {
            this.SearchMethodJarVarCallingSP();
            this.doSearchInTextBoxCmb();
        }

        private void MatTxtSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        //

    }
}
