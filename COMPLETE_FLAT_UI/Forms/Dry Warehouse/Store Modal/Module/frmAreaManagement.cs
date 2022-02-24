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
using ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmAreaManagement : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();


        int p_id = 0;

        DateTime dNow = DateTime.Now;



        DataSet dSet_temp = new DataSet();
        public frmAreaManagement()
        {
            InitializeComponent();
        }

        public string sp_user_id { get; set; }
        public string sp_area_name { get; set; }
        public string sp_typeof_mode { get; set; }
        private void frmAreaManagement_Load(object sender, EventArgs e)
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            this.objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            this.sp_user_id = userinfo.user_id.ToString();
            this.showStoreArea();
            this.LoadRecords();
            this.LoadingrefresherOrb();

            this.SearchMethodJarVarCallingSP();
        }

        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            this.dset_emp_SearchEngines.Clear();


            this.dset_emp_SearchEngines = objStorProc.sp_getMajorTables("tblAreaSpMajor");

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



        private void showStoreArea()    //method for loading available_menus
        {
            try
            {

                xClass.fillDataGridView(dgvRawMats, "tblAreaSpMinor", dSet);

                lbltotalrecords.Text = dgvRawMats.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.dgvRawMats.Columns["area_id"].Visible = false;
            this.dgvRawMats.Columns["is_active"].Visible = false;
            //this.dgvRawMats.Columns["modified_at"].Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            frmAreaManagement_Load(sender, e);
        }

        private void matBtnNew_Click(object sender, EventArgs e)
        {
            this.sp_typeof_mode = "add";

            matBtnNew.Visible = false;
            matBtnEdit.Visible = false;
            frmAddNewArea addNew = new frmAddNewArea(this, sp_user_id, sp_area_name, sp_typeof_mode, p_id);
            addNew.ShowDialog();
        }

        private void dgvRawMats_CurrentCellChanged(object sender, EventArgs e)
        {
            this.showValueCell();
        }

        private void showValueCell()
        {
            if (dgvRawMats.Rows.Count > 0)
            {
                if (dgvRawMats.CurrentRow != null)
                {
                    if (dgvRawMats.CurrentRow.Cells["area_name"].Value != null)
                    {
                        p_id = Convert.ToInt32(dgvRawMats.CurrentRow.Cells["area_id"].Value);
                        sp_area_name = dgvRawMats.CurrentRow.Cells["area_name"].Value.ToString();


                    }
                }
            }
        }

        private void matBtnEdit_Click(object sender, EventArgs e)
        {
            this.sp_typeof_mode = "edit";
            this.matBtnNew.Visible = false;
            this.matBtnEdit.Visible = false;
            frmAddNewArea addNew = new frmAddNewArea(this, sp_user_id, sp_area_name, sp_typeof_mode, p_id);
            addNew.ShowDialog();
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

                        dv.RowFilter = "area_name like '%" + txtSearch.Text + "%'";

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





        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (this.lbltotalrecords.Text == "0")
            {

            }
            else
            {
                this.doSearchInTextBoxCmb();
            }
            if (this.txtSearch.Text == "")
            {
                this.doSearchInTextBoxCmb();
            }
        }
    }
}
