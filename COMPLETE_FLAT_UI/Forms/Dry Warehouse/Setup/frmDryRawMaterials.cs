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
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmDryRawMaterials : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();

 
        int p_id = 0;
     
        DateTime dNow = DateTime.Now;
        //Boolean ready = false;


        DataSet dSet_temp = new DataSet();
        public frmDryRawMaterials()
        {
            InitializeComponent();
        }
        public string items_code { get; set; }
        public string items_description { get; set; }
        public string items_class { get; set; }
        public string majors_category { get; set; }
        public string subs_category { get; set; }
        public string primarys_unit { get; set; }
        public string conversions { get; set; }
        public string items_type { get; set; }
        public string is_active { get; set; }
        public string primarys_key { get; set; }
        public string sp_user_id { get; set; }
        private void frmDryRawMaterials_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.sp_user_id = userinfo.user_id.ToString();
            this.showRawMaterialsInDryWH();
            this.LoadRecords();
            this.LoadingrefresherOrb();

            this.SearchMethodJarVarCallingSP();
        }


        private void ConnectionInit()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            this.objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
        }

        private void LoadRecords()
        {
            if (this.lbltotalrecords.Text == "0")
            {

            }
            else
            {
                this.matBtnEdit.Visible = true;
            }
        }
        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            this.dset_emp_SearchEngines.Clear();


            this.dset_emp_SearchEngines = objStorProc.sp_getMajorTables("Raw_Materials_Dry_Major");

        }


        private void doSearchInTextBoxCmb()
        {
            try
            {


                if (dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEngines.Tables[0]);
                    if (myglobal.global_module == "EMPLOYEE")
                    {

                    }
                    else if (myglobal.global_module == "Active")
                    {


                        //Gerard Singian Developer Man




                        dv.RowFilter = "item_description like '%" + mattxtSearch.Text + "%'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dgvRawMats.DataSource = dv;
                    lbltotalrecords.Text = dgvRawMats.RowCount.ToString();
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





        private void LoadingrefresherOrb()
        {

            if(textBox1.Text == "data Already Save!")
            {
                matBtnEdit.Visible = false;
            }
            else if(textBox1.Text == "Gerard Singian")
            {
                textBox1.Text = string.Empty;
                matBtnNew.Visible = true;
                matBtnEdit.Visible = true;
            }
            else
            {
         
                
            }


      

            myglobal.global_module = "Active"; // Mode for Searching

        }
        private void showRawMaterialsInDryWH()    //method for loading available_menus
        {
            try
            {
             
                xClass.fillDataGridView(this.dgvRawMats, "Raw_Materials_Dry", dSet);
            
                this.lbltotalrecords.Text = this.dgvRawMats.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.dgvRawMats.Columns["item_id"].Visible = false;

        }

        private void matBtnNew_Click(object sender, EventArgs e)
        {
            matBtnNew.Visible = false;
            matBtnEdit.Visible = false;
            frmAddNewItemModal addNew = new frmAddNewItemModal(this, sp_user_id);
            addNew.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            frmDryRawMaterials_Load(sender, e);
        }

        private void matBtnEdit_Click(object sender, EventArgs e)
        {
            matBtnEdit.Visible = false;
            matBtnNew.Visible = false;
            frmEditItemModal mywipwh = new frmEditItemModal(this, sp_user_id,items_code, 
                items_description,
                items_class,
                majors_category,
                subs_category,
                primarys_unit,
                conversions,
                items_type,
                primarys_key
                );
            mywipwh.ShowDialog();
        }

        private void dgvRawMats_CurrentCellChanged(object sender, EventArgs e)
        {
            showValueCell();
        }

        private void showValueCell()
        {
            if (dgvRawMats.Rows.Count > 0)
            {
                if (dgvRawMats.CurrentRow != null)
                {
                    if (dgvRawMats.CurrentRow.Cells["item_description"].Value != null)
                    {
                        p_id = Convert.ToInt32(dgvRawMats.CurrentRow.Cells["item_id"].Value);
                        primarys_key = dgvRawMats.CurrentRow.Cells["item_id"].Value.ToString();
                        items_code = dgvRawMats.CurrentRow.Cells["item_code"].Value.ToString();
                        items_description = dgvRawMats.CurrentRow.Cells["item_description"].Value.ToString();
                        items_class = dgvRawMats.CurrentRow.Cells["item_class"].Value.ToString();
                        majors_category = dgvRawMats.CurrentRow.Cells["major_category"].Value.ToString();
                        subs_category = dgvRawMats.CurrentRow.Cells["sub_category"].Value.ToString();
                        primarys_unit = dgvRawMats.CurrentRow.Cells["primary_unit"].Value.ToString();
                        conversions = dgvRawMats.CurrentRow.Cells["conversion"].Value.ToString();
                        items_type = dgvRawMats.CurrentRow.Cells["item_type"].Value.ToString();
                    }
                }
            }
        }

        private void mattxtSearch_TextChanged(object sender, EventArgs e)
        {
            if(lbltotalrecords.Text =="0")
            {
              
            }
            else
            {
                doSearchInTextBoxCmb();
            }
            if(mattxtSearch.Text == "")
            {
                doSearchInTextBoxCmb();
            }
        }

        private void guna2cmbMajorCat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            doSearchInTextBoxCmb();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void mattxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
    }

