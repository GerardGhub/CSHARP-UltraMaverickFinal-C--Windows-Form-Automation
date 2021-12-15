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
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class frmNewStoreOrderApproved : MaterialForm
    {
        //Main Classs
        myclasses myClass = new myclasses();
        myclasses xClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        //Data Set Initialization
        public DataSet dset = new DataSet();
        DataSet dset2 = new DataSet();
        DataSet dset3 = new DataSet();
        DataSet dSet = new DataSet();
        //Variable Declaration
        int p_id = 0;
        string Rpt_Path = "";
        public frmNewStoreOrderApproved()
        {
            InitializeComponent();
        }
        public int sp_user_id { get; set; }
        public string mode { get; set; }


        //Class Binding to oTher window

        public int sp_order_id { get; set; }
        public string sp_date_ordered { get; set; }
        public string sp_fox { get; set; }
        public string sp_store_name { get; set; }
        public string sp_route { get; set; }
        public string sp_area { get; set; }
        public string sp_category { get; set; }
        public string sp_item_code { get; set; }
        public string sp_description { get; set; }
        public string sp_uom { get; set; }
        public string sp_qty { get; set; }

        private void frmAddNewStoreOrderApproved_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.ShowDataActivated();
            this.DataRefresher();

            myglobal.global_module = "Active";

            this.loadCategoryDropdown();
            this.loadStoreDropdown();
            this.loadDateOrderDropdown();
            //Load The Data With Stored Procedure
            //this.LoadDataWithParamsOrders();
    
            if (this.mode == "start")
            {
                this.ConnectionInit();
                this.load_search();
                this.mode = "";
            }
            else
            {
                this.ConnectionInit();
                this.dset_emp1.Clear();

                this.dset_emp1 = objStorProc.sp_getMajorTables("searchorderForApprovalinDryWH_isApproved");
                DataView dv = new DataView(this.dset_emp1.Tables[0]);

                this.dgvStoreOrderApproval.DataSource = dv;
                this.lbltotaldata.Text = dgvStoreOrderApproval.RowCount.ToString();

            }
            this.SaveButtonManipulator();
            this.DesignerSerializationVisibilityOninit();
        }

        private void ShowDataActivated()
        {
            this.matRadioActive.Checked = true;
        }

        private void  DesignerSerializationVisibilityOninit()
        {
            //Order ID for Genus System
            this.dgvStoreOrderApproval.Columns["order_id"].Visible = false;
            //Order Primary KEy
            this.dgvStoreOrderApproval.Columns["primary_id"].Visible = false;
        }
        private void SaveButtonManipulator()
        {
            if (this.labelSelectedSum.Text == "0")
            {
                this.matbtnPrint.Visible = false;
            }
            else if (num == 0)
            {
                this.matbtnPrint.Visible = false;
            }
            else
            {
                this.matbtnPrint.Visible = true;
            }
        }

        public void loadDateOrderDropdown()
        {
            try
            {


                myClass.fillComboBoxStoreOrderApproval(this.cmbDateOrder, "tblStoreOrderDryWH_dropdown_Approval_Order_Date_isApproved", this.dSet);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        int num = 0;
        private void dgvReprinting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isChecked = (bool)dgvStoreOrderApproval.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
            CheckCount(isChecked);
        }

        private void CheckCount(bool isChecked)
        {
            if (isChecked)
            {
                num++;
            }
            else
            {
                num--;
            }
            this.labelSelectedSum.Text = "Selected Items: " + num;
            this.labelSelectedSum.Visible = true;
            this.SaveButtonManipulator();
            this.EditManipulator();
        }
        private void EditManipulator()
        {
            if (this.num == 1)
            {
                this.matbtnPrint.Visible = true;
                this.matbtnEdit.Visible = true;
            }
            else
            {
                this.matbtnEdit.Visible = false;

            }
        }

        DataSet dset_emp1 = new DataSet();
        private void load_search()
        {

            this.dset_emp1.Clear();

            this.dset_emp1 = objStorProc.sp_getMajorTables("searchorderForApprovalinDryWH_isApproved");

            this.doSearch();


        }
        private void doSearch()
        {
            try
            {
                if (this.dset_emp1.Tables.Count > 0)
                {
                    DataView dv = new DataView(this.dset_emp1.Tables[0]);
                    if (myglobal.global_module == "EMPLOYEE")
                    {

                    }
                    else if (myglobal.global_module == "Active")
                    {

                        dv.RowFilter = "  category = '" + this.matcmbPackaging.Text + "' and  store_name = '" + this.metroCmbStoreCode.Text + "'  and is_approved_prepa_date = '" + this.bunifuPrepaDate.Text + "'     ";
                        //dv.RowFilter = "  category = '" + this.matcmbPackaging.Text + "' and  store_name = '" + this.metroCmbStoreCode.Text + "'  and is_approved_prepa_date = '" + this.bunifuPrepaDate.Text + "'   or date_ordered = '" + this.cmbDateOrder.Text + "'       ";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {
                        //dv.RowFilter = "visitors_lastname like '%" + txtsearch.Text + "%' or visitors_firstname like '%" + txtsearch.Text + "%'";
                    }
                    this.dgvStoreOrderApproval.DataSource = dv;
                    this.lbltotaldata.Text = dgvStoreOrderApproval.RowCount.ToString();

                    //gerard
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 20.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            //END
        }
        private void DataRefresher()
        {
            this.dset = g_objStoredProcCollection.sp_IDGenerator(0, "resetreceivingreprint", "", "", 6);
            sp_user_id = userinfo.user_id;
        }

        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            if (myClass.g_objStoredProc.getConnected() == true)
            {
                g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections();


                this.Rpt_Path = ULTRAMAVERICK.Properties.Settings.Default.fdg;


                this.dgvStoreOrderApproval.Columns[0].Width = 50;// The id column
                this.dgvStoreOrderApproval.Columns[3].Width = 150;// The id column

            }
            else
            {
                MessageBox.Show("Unable to connect in sql server", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }


        public void loadCategoryDropdown()
        {
            try
            {


                myClass.fillComboBoxStoreOrderApproval(this.matcmbPackaging, "tblStoreOrderDryWH_dropdown_Approval_isApproved", this.dSet);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        public void loadStoreDropdown()
        {
            try
            {


                myClass.fillComboBoxDepartment(this.metroCmbStoreCode, "tblStore_dropdown_isApproved", this.dSet);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        private void dgvStoreOrderApproval_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvStoreOrderApproval.Rows)
            {
                if (1 == Convert.ToDouble(row.Cells["DateDiff"].Value) || 0 == Convert.ToDouble(row.Cells["DateDiff"].Value))
                {

                    row.Cells["DateDiff"].Style.BackColor = Color.Green;
                    row.Cells["selected"].Style.BackColor = Color.Green;

                    //dgvStoreOrderApproval.Rows[Convert.ToInt32(row.Cells["DateDiff"].Value)].DefaultCellStyle.BackColor = Color.Green;
                }
                else if (2 == Convert.ToDouble(row.Cells["DateDiff"].Value) || 3 == Convert.ToDouble(row.Cells["DateDiff"].Value) || 4 == Convert.ToDouble(row.Cells["DateDiff"].Value) || 5 == Convert.ToDouble(row.Cells["DateDiff"].Value))
                {
                    row.Cells["DateDiff"].Style.BackColor = Color.Yellow;
                    row.Cells["selected"].Style.BackColor = Color.Yellow;
                    //this.dgvStoreOrderApproval.Rows[Convert.ToInt32(row.Cells["DateDiff"].Value)].DefaultCellStyle.BackColor = Color.Yellow;

                }
     
            else
                {

                    // Use it in order to colorize all cells of the row
                    row.Cells["DateDiff"].Style.BackColor = Color.White;
                    row.Cells["selected"].Style.BackColor = Color.White;
                    //this.dgvStoreOrderApproval.Rows[Convert.ToInt32(row.Cells["DateDiff"].Value)].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void cmbDateOrder_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.load_search();
        }

        private void matcmbPackaging_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.load_search();
        }

        private void metroCmbStoreCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.load_search();
        }

        private void bunifuPrepaDate_ValueChanged(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.load_search();
        }
    }
}
