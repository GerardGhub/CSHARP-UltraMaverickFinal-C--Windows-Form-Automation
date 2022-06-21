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
using ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Add_Modals;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module
{
    public partial class frmRegion : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        int p_id = 0;
        DateTime dNow = DateTime.Now;
        DataSet dSet_temp = new DataSet();


        public frmRegion()
        {
            InitializeComponent();
        }

        public string sp_user_id { get; set; }
        public string sp_area_name { get; set; }
        public string sp_typeof_mode { get; set; }

        private void frmRegion_Load(object sender, EventArgs e)
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            this.objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            this.sp_user_id = userinfo.user_id.ToString();
            this.showStoreRoute();
            this.LoadRecords();
            this.LoadingrefresherOrb();

            this.SearchMethodJarVarCallingSP();


        }


        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            this.dset_emp_SearchEngines.Clear();
            this.dset_emp_SearchEngines = objStorProc.sp_getMajorTables("tblRegionSpMajor");

        }

        private void showStoreRoute()    //method for loading available_menus
        {
            try
            {

                xClass.fillDataGridView(this.dgvRegion, "tblRegionSpMinor", dSet);

                this.lbltotalrecords.Text = this.dgvRegion.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void LoadingrefresherOrb()
        {
            this.sp_typeof_mode = "";
            if (textBox1.Text == "data Already Save!")
            {
                matBtnEdit.Visible = false;
            }
            else if (textBox1.Text == "Gerard Singian")
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
        private void LoadRecords()
        {
            if (lbltotalrecords.Text == "0")
            {

            }
            else
            {
                this.matBtnEdit.Visible = true;
            }
        }





        private void doSearchInTextBoxCmb()
        {
            try
            {


                if (dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEngines.Tables[0]);
                 
                    if (myglobal.global_module == "Active")
                    {
          
                        dv.RowFilter = "region_description  like '%" + txtSearch.Text + "%'";

                    }
    
                    this.dgvRegion.DataSource = dv;
                    this.lbltotalrecords.Text = this.dgvRegion.RowCount.ToString();
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

        private void showValueCell()
        {
            if (this.dgvRegion.Rows.Count > 0)
            {
                if (this.dgvRegion.CurrentRow != null)
                {
                    if (this.dgvRegion.CurrentRow.Cells["region_description"].Value != null)
                    {
                        this.p_id = Convert.ToInt32(dgvRegion.CurrentRow.Cells["region_id"].Value);
                        sp_area_name = dgvRegion.CurrentRow.Cells["region_description"].Value.ToString();


                    }
                }
            }
        }

        private void dgvRawMats_CurrentCellChanged_1(object sender, EventArgs e)
        {
            this.showValueCell();
        }

        private void matBtnEdit_Click(object sender, EventArgs e)
        {
            this.sp_typeof_mode = "edit";
            this.matBtnNew.Visible = false;
            this.matBtnEdit.Visible = false;
            frmAddNewRegion UpdateModal = new frmAddNewRegion(this, sp_user_id, sp_area_name, sp_typeof_mode, p_id);
            UpdateModal.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (lbltotalrecords.Text == "0")
            {

            }
            else
            {
                doSearchInTextBoxCmb();
            }
            if (txtSearch.Text == "")
            {
                doSearchInTextBoxCmb();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.frmRegion_Load(sender, e);
        }

        private void matBtnNew_Click(object sender, EventArgs e)
        {
            this.sp_typeof_mode = "add";

            this.matBtnNew.Visible = false;
            this.matBtnEdit.Visible = false;
            frmAddNewRegion addNew = new frmAddNewRegion(this, sp_user_id, sp_area_name, sp_typeof_mode, p_id);
            addNew.ShowDialog();
        }
    }
}
