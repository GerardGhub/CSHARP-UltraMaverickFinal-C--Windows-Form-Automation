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
    public partial class frmWarehouses : MaterialForm
    {

        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        Major_Category MajorCategoryEntity = new Major_Category();
        string mode = "";

        DateTime dNow = DateTime.Now;



        DataSet dSet_temp = new DataSet();

        public frmWarehouses()
        {
            InitializeComponent();
        }


        private void FrmMajorCategory_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.ShowMajorCategoryData();
    
            this.TextBox1.Text = String.Empty;
            this.CheckBoxActivated();
        }

        private void CheckBoxActivated()
        {
            this.matRadioActive.Checked = true;
        }

        private void ConnectionInit()
        {
            this.g_objStoredProcCollection = this.myClass.g_objStoredProc.GetCollections(); 
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

        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();

            if(this.matRadioActive.Checked == true)
            {
                this.dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("Major_CategoryMajor");
            }
            else
            {
                this.dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("Major_CategoryMajorInActive");
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

                        dv.RowFilter = "major_category_desc like '%" + this.MatTxtSearchBox.Text + "%'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    this.dgvMajorCategory.DataSource = dv;
                    this.lbltotalrecords.Text = this.dgvMajorCategory.RowCount.ToString();
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


        private void ShowMajorCategoryData()      //method for loading available_menus
        {
            try
            {
  
                this.myClass.fillDataGridView(this.dgvMajorCategory, "Major_Category", dSet);
                this.lbltotalrecords.Text = this.dgvMajorCategory.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }


        private void ShowMajorCategoryDataInActive()      //method for loading available_menus
        {
            try
            {

                this.myClass.fillDataGridView(this.dgvMajorCategory, "Major_CategoryInActive", dSet);
                this.lbltotalrecords.Text = this.dgvMajorCategory.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }



        private void dgvMajorCategory_CurrentCellChanged(object sender, EventArgs e)
        {
            ShowValueCell();
        }

        private void ShowValueCell()
        {
            if (dgvMajorCategory.Rows.Count > 0)
            {
                if (dgvMajorCategory.CurrentRow != null)
                {
                    if (dgvMajorCategory.CurrentRow.Cells["major_category_desc"].Value != null)
                    {
                        this.MajorCategoryEntity.Major_Category_Id = Convert.ToInt32(dgvMajorCategory.CurrentRow.Cells["major_category_id"].Value);
                        this.MajorCategoryEntity.Major_Category_Desc = dgvMajorCategory.CurrentRow.Cells["major_category_desc"].Value.ToString();
                        this.MajorCategoryEntity.Mc_Added_By = dgvMajorCategory.CurrentRow.Cells["mc_added_by"].Value.ToString();
                        this.MajorCategoryEntity.Mc_Added_At = dgvMajorCategory.CurrentRow.Cells["mc_added_at"].Value.ToString();
                        this.MajorCategoryEntity.Mc_Updated_At = dgvMajorCategory.CurrentRow.Cells["mc_updated_at"].Value.ToString();
                        this.MajorCategoryEntity.Mc_Updated_By = dgvMajorCategory.CurrentRow.Cells["mc_updated_by"].Value.ToString();
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
            this.matBtnSave.Visible = true;
   


            this.MajorCategoryEntity.Mode = "ADD";
            FrmAddBNewWarehouses addNew =
            new FrmAddBNewWarehouses(this,
            userinfo.user_id,
            this.MajorCategoryEntity.Major_Category_Desc,
            this.MajorCategoryEntity.Mode,
            this.MajorCategoryEntity.Major_Category_Id);
            addNew.ShowDialog();

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.matBtnCancel.Visible = false;
            this.mode = "";
            this.matBtnEdit.Visible = true;
            this.matBtnSave.Visible = false;
            this.matBtnNew.Visible = true;
            this.matBtnDelete.Visible = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (this.dgvMajorCategory.Rows.Count > 0)
            {
                if (this.matRadioActive.Checked == true)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to deactivate the data", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        this.mode = "delete";
                        this.dSet_temp.Clear();
                        this.dSet_temp = g_objStoredProcCollection
                            .sp_Major_Category(this.MajorCategoryEntity.Major_Category_Id,
                            "",
                            "",
                            "",
                            "",
                            "",
                            "delete");
                        this.GlobalStatePopup.InactiveSuccessfully();
                        this.FrmMajorCategory_Load(sender, e);


                    }

                    else
                    {
                        return;
                    }
                }
                else

                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to deactivate the data", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        this.mode = "activate";
                        this.dSet_temp.Clear();
                        this.dSet_temp = g_objStoredProcCollection
                            .sp_Major_Category(this.MajorCategoryEntity.Major_Category_Id,
                            "",
                            "",
                            "",
                            "",
                            "",
                            "activate");
                        this.GlobalStatePopup.ActivatedSuccessfully();
                        this.FrmMajorCategory_Load(sender, e);


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
            this.mode = "edit";
            this.matBtnDelete.Visible = false;
            this.matBtnCancel.Visible = true;
            this.matBtnNew.Visible = false;
            this.matBtnEdit.Visible = false;
            this.matBtnSave.Visible = true;


            this.MajorCategoryEntity.Mode = "EDIT";
            FrmAddBNewWarehouses addNew =
            new FrmAddBNewWarehouses(this,
            userinfo.user_id,
            this.MajorCategoryEntity.Major_Category_Desc,
            this.MajorCategoryEntity.Mode,
            this.MajorCategoryEntity.Major_Category_Id);
            addNew.ShowDialog();
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void MattxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (this.mattxtSearch.Text == String.Empty)
            {
                this.ShowMajorCategoryData();
            }
            if (this.lbltotalrecords.Text == "0")
            {

            }
            else
            {
                if (mode == "add")
                {

                }
                else
                {
                    this.doSearchInTextBoxCmb();
                }

            }
        }

 


        private void txtmajorCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.toolStripButton5_Click(sender, e);
            this.FrmMajorCategory_Load(sender, e);
        }

        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {

                this.matBtnDelete.Text = "&InActive";

                this.ShowMajorCategoryData();
            
            }
            else if (matRadioNotActive.Checked == true)
            {

                this.matBtnDelete.Text = "&Activate";
                this.ShowMajorCategoryDataInActive();
                
            }
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.SearchMethodJarVarCallingSP();
            this.doSearchInTextBoxCmb();
        }

        private void matRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {

                this.matBtnDelete.Text = "&InActive";

                this.ShowMajorCategoryData();

            }
            else if (matRadioNotActive.Checked == true)
            {

                this.matBtnDelete.Text = "&Activate";
                this.ShowMajorCategoryDataInActive();

            }
        }
    }
}
