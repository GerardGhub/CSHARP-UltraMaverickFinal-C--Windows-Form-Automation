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
    public partial class frmStoreOrderforApproval : MaterialForm
    {
        myclasses myClass = new myclasses();
        myclasses xClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        public DataSet dset = new DataSet();
        DataSet dset2 = new DataSet();
        DataSet dset3 = new DataSet();

        //ReportDocument rpt = new ReportDocument();
        string Rpt_Path = "";
        DataSet dSet = new DataSet();
        IStoredProcedures objStorProc = null;


        public frmStoreOrderforApproval()
        {
            InitializeComponent();
        }

        private void frmStoreOrderforApproval_Load(object sender, EventArgs e)
        {

            this.ConnectionInit();

            this.DataRefresher();

            myglobal.global_module = "Active";
            
            this.loadCategoryDropdown();
            this.loadStoreDropdown();
            this.loadDateOrderDropdown();
            //Load The Data With Stored Procedure
            //this.LoadDataWithParamsOrders();
            this.InitiliazeDatePickerMinDate();
            //this.load_search();
        }
        private void InitiliazeDatePickerMinDate()
        {
            this.bunifuPrepaDate.MinDate = DateTime.Now;
        }
        public void loadDateOrderDropdown()
        {
            try
            {


                myClass.fillComboBoxStoreOrderApproval(this.cmbDateOrder, "tblStoreOrderDryWH_dropdown_Approval_Order_Date", this.dSet);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            if (myClass.g_objStoredProc.getConnected() == true)
            {
                g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections();


                this.Rpt_Path = ULTRAMAVERICK.Properties.Settings.Default.fdg;


                this.dgvReprinting.Columns[0].Width = 50;// The id column
                this.dgvReprinting.Columns[3].Width = 150;// The id column

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

        
            myClass.fillComboBoxStoreOrderApproval(this.matcmbPackaging, "tblStoreOrderDryWH_dropdown_Approval", this.dSet);

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


                myClass.fillComboBoxDepartment(this.metroCmbStoreCode, "tblStore_dropdown", this.dSet);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        DataSet dset_emp1 = new DataSet();
        private void load_search()
        {

            this.dset_emp1.Clear();

            this.dset_emp1 = objStorProc.sp_getMajorTables("searchorderForApprovalinDryWH");

            this.doSearch();


        }

        private void DataRefresher()
        {
            this.dset = g_objStoredProcCollection.sp_IDGenerator(0, "resetreceivingreprint", "", "", 6);
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

                        dv.RowFilter = "  category = '" + this.matcmbPackaging.Text + "' and  store_name = '" + this.metroCmbStoreCode.Text + "'  and  date_ordered = '" + this.cmbDateOrder.Text + "'      ";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {
                        //dv.RowFilter = "visitors_lastname like '%" + txtsearch.Text + "%' or visitors_firstname like '%" + txtsearch.Text + "%'";
                    }
                    this.dgvReprinting.DataSource = dv;
                    this.lbltotaldata.Text = dgvReprinting.RowCount.ToString();

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
        private void LoadDataWithParamsOrders()
        {
            this.ConnectionInit();
            MessageBox.Show(this.metroCmbStoreCode.Text);
            this.dset = g_objStoredProcCollection.sp_IDGenerator(1, "SearchStoreOrderforApproval", "All", this.matcmbPackaging.Text,0);
                this.dgvReprinting.DataSource = dset.Tables[0];
                for (int i = 0; i <= dgvReprinting.RowCount; i++)
                {
                    try
                    {
                        this.dgvReprinting.Rows[i].Cells["selected"].Value = false;
                    }
                    catch (Exception) { }
                }




                this.lbltotaldata.Text = dgvReprinting.RowCount.ToString();
            //MessageBox.Show(this.metroCmbStoreCode.Text);
        }
        private void matcmbPackaging_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //this.LoadDataWithParamsOrders();
            this.ConnectionInit();
            this.load_search();
        }

        private void metroCmbStoreCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //this.LoadDataWithParamsOrders();
            this.ConnectionInit();
            this.load_search();
        }

        private void cmbDateOrder_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.load_search();
        }
    }
}
