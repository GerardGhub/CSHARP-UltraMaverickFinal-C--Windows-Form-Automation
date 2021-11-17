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

        private void frmImportStore_Load(object sender, EventArgs e)
        {

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
            //this.SearchMethodJarVarCallingSP();
            //this.doSearchInTextBox();
        }

        private void dgvRawMats_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvRawMats.CurrentRow != null)
            {
                if (dgvRawMats.CurrentRow.Cells["item_code"].Value != null)
                {
                    this.item_id_main = dgvRawMats.CurrentRow.Cells["PrimaryID"].Value.ToString();
                    this.item_code_main = dgvRawMats.CurrentRow.Cells["item_code"].Value.ToString();
                    this.item_description_main = dgvRawMats.CurrentRow.Cells["item_description"].Value.ToString();
                    this.sp_qty_order = dgvRawMats.CurrentRow.Cells["qty_order"].Value.ToString();
                    this.primary_unit_main = dgvRawMats.CurrentRow.Cells["qty_uom"].Value.ToString();
                    this.sp_po_number = dgvRawMats.CurrentRow.Cells["po_number"].Value.ToString();
                    this.sp_pr_number = dgvRawMats.CurrentRow.Cells["pr_number"].Value.ToString();
                    this.sp_po_date = dgvRawMats.CurrentRow.Cells["po_date"].Value.ToString();
                    this.sp_pr_date = dgvRawMats.CurrentRow.Cells["pr_date"].Value.ToString();
                    this.sp_unit_price = dgvRawMats.CurrentRow.Cells["unit_price"].Value.ToString();
                    this.sp_supplier = dgvRawMats.CurrentRow.Cells["supplier"].Value.ToString();

                    this.sp_qty_delivered = dgvRawMats.CurrentRow.Cells["qty_delivered"].Value.ToString();
                    this.sp_qty_billed = dgvRawMats.CurrentRow.Cells["qty_billed"].Value.ToString();
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
    }
}
