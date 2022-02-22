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
using ULTRAMAVERICK.Forms.Dry_Warehouse.Setup;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmLotManagement : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();

   
        int p_id = 0;
 
        DateTime dNow = DateTime.Now;
        Boolean ready = false;


        DataSet dSet_temp = new DataSet();
        public frmLotManagement()
        {
            InitializeComponent();
        }
        //User Binding
        public string sp_user_id { get; set; }
        //Update
        public string sp_id { get; set; }
        public string sp_lot_number { get; set; }
        public string sp_description { get; set; }
        public string sp_category { get; set; }
        private void frmLotManagement_Load(object sender, EventArgs e)
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            this.objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            sp_user_id = userinfo.user_id.ToString();
            this.showLotMasterlist();
            this.LoadingrefresherOrb();
            this.SearchMethodJarVarCallingSP();
        }

        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = objStorProc.sp_getMajorTables("lot_management_major");

        }

        private void LoadingrefresherOrb()
        {

            if (this.textBox1.Text == "data Already Save!")
            {
                this.matBtnEdit.Visible = false;
            }
            else if (this.textBox1.Text == "Gerard Singian")
            {
                this.textBox1.Text = string.Empty;
                this.matBtnNew.Visible = true;
                this.matBtnEdit.Visible = true;
            }
            else
            {


            }




            myglobal.global_module = "Active"; // Mode for Searching

        }

        private void showLotMasterlist()      //method for loading available_menus
        {
            try
            {
                ready = false;
                xClass.fillDataGridView(dgvLotData ,"lot_management", dSet);
                ready = true;
                lbltotalrecords.Text = dgvLotData.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void matBtnNew_Click(object sender, EventArgs e)
        {
            matBtnNew.Visible = false;
            matBtnEdit.Visible = false;
            frmAddNewLotModal addNew = new frmAddNewLotModal(this, sp_user_id);
            addNew.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           frmLotManagement_Load(sender, e);
        }

        private void mattxtSearch_TextChanged(object sender, EventArgs e)
        {
            this.doSearchInTextBoxCmb();
        }
        DataSet dset_emp_SearchEngines = new DataSet();
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




                        dv.RowFilter = "lot_number like '%" + mattxtSearch.Text + "%'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dgvLotData.DataSource = dv;
                    lbltotalrecords.Text = dgvLotData.RowCount.ToString();
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

        private void matBtnEdit_Click(object sender, EventArgs e)
        {
            this.matBtnNew.Visible = false;
            this.matBtnEdit.Visible = false;
           frmUpdateLotData addNew = new frmUpdateLotData(this, sp_user_id, sp_lot_number, sp_description, sp_category, p_id);
            addNew.ShowDialog();
        }

        private void dgvLotData_CurrentCellChanged(object sender, EventArgs e)
        {
            this.showValueCell();
        }

        private void showValueCell()
        {
            if (dgvLotData.Rows.Count > 0)
            {
                if (dgvLotData.CurrentRow != null)
                {
                    if (dgvLotData.CurrentRow.Cells["lot_number"].Value != null)
                    {
                        p_id = Convert.ToInt32(dgvLotData.CurrentRow.Cells["id"].Value);
                        sp_lot_number = dgvLotData.CurrentRow.Cells["lot_number"].Value.ToString();
                        sp_description = dgvLotData.CurrentRow.Cells["description"].Value.ToString();
                        sp_category = dgvLotData.CurrentRow.Cells["category"].Value.ToString();
                   
                    }
                }
            }
        }

        private void dgvLotData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check the value of the e.ColumnIndex property if you want to apply this formatting only so some rcolumns.
            if (e.Value != null)
            {
                e.Value = e.Value.ToString().ToUpper();
                e.FormattingApplied = true;
            }
        }

        private void matBtnViewItems_Click(object sender, EventArgs e)
        {

            frmViewItemsInLotArea mywipwh = new frmViewItemsInLotArea(this, sp_lot_number, sp_description, sp_category);
            mywipwh.ShowDialog();


        }
    }
}
