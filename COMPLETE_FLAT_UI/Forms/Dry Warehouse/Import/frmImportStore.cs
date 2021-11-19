using COMPLETE_FLAT_UI.Models;
using ExcelDataReader;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULTRAMAVERICK.Class;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Import
{
    public partial class frmImportStore : MaterialForm
    {
        myclasses xClass = new myclasses();
        DataSet dSet = new DataSet();
        DataSet dSet_temp = new DataSet();
        IStoredProcedures objStorProc = null;

        myclasses myClass = new myclasses();
        string mode = "";
        public frmImportStore()
        {
            InitializeComponent();
        }
        public string item_id_main { get; set; }
        public string item_code_main { get; set; }
        public string item_description_main { get; set; }
        public string item_type_main { get; set; }
        public string item_class_main { get; set; }
        public string major_category_main { get; set; }
        public string sub_category_main { get; set; }
        public string primary_unit_main { get; set; }
        public string conversion_main { get; set; }
        public string mat_row_number { get; set; }
        public int user_id { get; set; }
        //Date
        public string sp_pr_number { get; set; }
        public string sp_pr_date { get; set; }
        public string sp_po_number { get; set; }
        public string sp_po_date { get; set; }
        public string sp_qty_order { get; set; }

        public string sp_qty_delivered { get; set; }
        public string sp_qty_billed { get; set; }

        public string sp_unit_price { get; set; }
        public string sp_user_id { get; set; }
        public string sp_supplier { get; set; }

        // Additional Model for Expiration Lookup on QC Checklist
        public string sp_item_class { get; set; }
        public string sp_major_category { get; set; }
        public string sp_sub_category { get; set; }
        public string sp_item_type { get; set; }
        //Expirable
        public string sp_is_expirable { get; set; }
        //Storer
        public string sp_store_name { get; set; }
        public string sp_store_code { get; set; }
        public string sp_store_area { get; set; }
        public string sp_store_route { get; set; }

        private void frmImportStore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ultraMaverickDBDataSet.tbl_stores' table. You can move, or remove it, as needed.
            this.tbl_storesTableAdapter.Fill(this.ultraMaverickDBDataSet.tbl_stores);

            objStorProc = xClass.g_objStoredProc.GetCollections();
            // TODO: This line of code loads data into the 'ultraMaverickDBDataSet.Project_Po_Summary' table. You can move, or remove it, as needed.
            //this.project_Po_SummaryTableAdapter.Fill(this.ultraMaverickDBDataSet.Project_Po_Summary);
            //// TODO: This line of code loads data into the 'ultraMaverickDBDataSet.Raw_Materials_Dry' table. You can move, or remove it, as needed.
            //this.project_Po_SummaryTableAdapter.Fill(this.ultraMaverickDBDataSet.Project_Po_Summary);
            dgvRawMats.Columns[0].Width = 100;// The id column 
            this.CallOthers();
            //this.VisibilityOffInDataGrid();
        }
        DataTableCollection tableCollection;
        private void matBtnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cbosheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cbosheet.Items.Add(table.TableName); // add sheet into combo box
                        }
                    }

                }

            }
        }
        private void CallOthers()
        {
            this.lbltotalrecords.Text = dgvRawMats.Rows.Count.ToString();
            this.user_id = userinfo.user_id;
            this.materialCard3.Visible = false;
            this.matbtnUpload.Visible = false;

        }
        private void cbosheet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.CallOthers();


            this.matbtnUpload.Visible = true;
            this.mode = "";
            dgvRawMats_CurrentCellChanged(sender, e);

            if (lbltotalrecords.Text == "0")
            {

            }
            else
            {
                mattxtSearch_TextChanged(sender, e);
            }
        }

        private void mattxtSearch_TextChanged(object sender, EventArgs e)
        {
            this.SearchMethodJarVarCallingSP();
            this.doSearchInTextBox();
        }


        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();  //Clear the Fucking data set


            dset_emp_SearchEngines = objStorProc.sp_getMajorTables("RawMatsBindingPoImport");

        }
        private void doSearchInTextBox()
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

                        dv.RowFilter = "item_code = '" + item_code_main + "' ";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dgvUnits.DataSource = dv;

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



        private void dgvRawMats_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvRawMats.CurrentRow != null)
            {
                if (dgvRawMats.CurrentRow.Cells["store_name"].Value != null)
                {
                    this.sp_store_name = dgvRawMats.CurrentRow.Cells["store_name"].Value.ToString();
                    this.sp_store_code = dgvRawMats.CurrentRow.Cells["store_code"].Value.ToString();
                    this.sp_store_area = dgvRawMats.CurrentRow.Cells["store_area"].Value.ToString();
                    this.sp_store_route = dgvRawMats.CurrentRow.Cells["store_route"].Value.ToString();
                    if (lbltotalrecords.Text == "0")
                    {

                    }
                    else
                    {
                        this.mat_row_number = Convert.ToInt32(dgvRawMats.CurrentCell.RowIndex).ToString();
                    }
                    mattxtSearch_TextChanged(sender, e);


                }
            }
        }

        private void cbosheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                DataTable dt = tableCollection[cbosheet.SelectedItem.ToString()];
                //dgvRawMats.DataSource = dt;
                if (dt != null)
                {
                    List<store_masterlist> Import_Stores = new List<store_masterlist>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        store_masterlist Store = new store_masterlist();


                        Store.store_name = dt.Rows[i]["Store"].ToString();
                        Store.store_code = dt.Rows[i]["Code"].ToString();
                        Store.store_area = dt.Rows[i]["Area"].ToString();
                        Store.store_route = dt.Rows[i]["Route"].ToString();

                        Import_Stores.Add(Store);
                    }
                    drymaterialsBindingSource.DataSource = Import_Stores;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.CallOthers();
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            cbosheet.Enabled = true;
        }
    }
}
