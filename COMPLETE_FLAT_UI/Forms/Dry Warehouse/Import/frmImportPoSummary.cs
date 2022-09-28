using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMPLETE_FLAT_UI.Models;
using ExcelDataReader;
using MaterialSkin;
using MaterialSkin.Controls;
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.Class;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;
using Z.Dapper.Plus;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Import
{
    public partial class frmImportPoSummary : MaterialForm
    {

        DataSet dSet = new DataSet();
        DataSet dSet_temp = new DataSet();
        private IStoredProcedures objStorProc = null;
        readonly myclasses myClass = new myclasses();
        string mode = "";
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        public frmImportPoSummary()
        {
            InitializeComponent();
        }

        public string ErrorDetails { get; set; }
        public string Item_id_main { get; set; }
        public string Item_code_main { get; set; }
        public string Item_description_main { get; set; }
        public string Item_type_main { get; set; }
        public string Item_class_main { get; set; }
        public string Major_category_main { get; set; }
        public string Sub_category_main { get; set; }
        public string Primary_unit_main { get; set; }
        public string Conversion_main { get; set; }
        public string Mat_row_number { get; set; }
        public int User_id { get; set; }
        //Date
        public string Sp_pr_number { get; set; }
        public string Sp_pr_date { get; set; }
        public string Sp_po_number { get; set; }
        public string Sp_po_date { get; set; }
        public string Sp_qty_order { get; set; }

        public string Sp_qty_delivered { get; set; }
        public string Sp_qty_billed { get; set; }

        public string Sp_unit_price { get; set; }
        public string Sp_user_id { get; set; }
        public string Sp_supplier { get; set; }

        // Additional Model for Expiration Lookup on QC Checklist
        public string Sp_item_class { get; set; }
        public string Sp_major_category { get; set; }
        public string Sp_sub_category { get; set; }
        public string Sp_item_type { get; set; }
        //Expirable
        public string Sp_is_expirable { get; set; }

        private void ConnectionInit()
        {
            objStorProc = myClass.g_objStoredProc.GetCollections();
        }
        private void frmImportPoSummary_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();

            dgvRawMats.Columns[0].Width = 100;// The id column 
            this.CallOthers();
            this.VisibilityOffInDataGrid();
        }
        private void VisibilityOffInDataGrid()

        {
            this.mattxtSearch.Visible = false;
            this.dgvUnits.Visible = false;
            this.dgvRawMats.Columns["Active"].Visible = false;
            this.dgvRawMats.Columns["PrimaryID"].Visible = false;
            this.dgvRawMats.Columns["created_by"].Visible = false;
            this.dgvRawMats.Columns["created_at"].Visible = false;
        }
        private void CallOthers()
        {
            this.lbltotalrecords.Text = this.dgvRawMats.Rows.Count.ToString();
            this.User_id = userinfo.user_id;
            this.materialCard3.Visible = false;


        }
        DataTableCollection tableCollection;
        private void matBtnBrowse_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void cbosheet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.CallOthers();


            this.matbtnUpload.Visible = true;
            this.mode = "";
            dgvRawMats_CurrentCellChanged(sender, e);

            if(lbltotalrecords.Text == "0")
            {

            }
            else
            {
                mattxtSearch_TextChanged(sender, e);
            }
   
        

            }

        private void dgvRawMats_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvRawMats.CurrentRow != null)
            {
                if (dgvRawMats.CurrentRow.Cells["item_code"].Value != null)
                {
                    this.Item_id_main = dgvRawMats.CurrentRow.Cells["PrimaryID"].Value.ToString();
                    this.Item_code_main = dgvRawMats.CurrentRow.Cells["item_code"].Value.ToString();
                    this.Item_description_main = dgvRawMats.CurrentRow.Cells["item_description"].Value.ToString();
                    this.Sp_qty_order = dgvRawMats.CurrentRow.Cells["qty_order"].Value.ToString();
                    this.Primary_unit_main = dgvRawMats.CurrentRow.Cells["qty_uom"].Value.ToString();
                    this.Sp_po_number = dgvRawMats.CurrentRow.Cells["po_number"].Value.ToString();
                    this.Sp_pr_number = dgvRawMats.CurrentRow.Cells["pr_number"].Value.ToString();
                    this.Sp_po_date = dgvRawMats.CurrentRow.Cells["po_date"].Value.ToString();
                    this.Sp_pr_date = dgvRawMats.CurrentRow.Cells["pr_date"].Value.ToString();
                    this.Sp_unit_price = dgvRawMats.CurrentRow.Cells["unit_price"].Value.ToString();
                    this.Sp_supplier = dgvRawMats.CurrentRow.Cells["supplier"].Value.ToString();
                    this.Sp_qty_delivered = dgvRawMats.CurrentRow.Cells["qty_delivered"].Value.ToString();
                    this.Sp_qty_billed = dgvRawMats.CurrentRow.Cells["qty_billed"].Value.ToString();
                    if (this.lbltotalrecords.Text == "0")
                    {

                    }
                    else
                    {
                        this.Mat_row_number = Convert.ToInt32(dgvRawMats.CurrentCell.RowIndex).ToString();
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
                    List<Approve_po_summary> Import_ApprovedPO_rawMats = new List<Approve_po_summary>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Approve_po_summary Import_ApprovedPO_rawMat = new Approve_po_summary();

                        Import_ApprovedPO_rawMat.ProjectID = dt.Rows[i]["PO Number"].ToString();
                        Import_ApprovedPO_rawMat.Pr_number = dt.Rows[i]["Pr Number"].ToString();
                        Import_ApprovedPO_rawMat.Pr_date = dt.Rows[i]["PR Date"].ToString();
                        Import_ApprovedPO_rawMat.Po_number = dt.Rows[i]["PO Number"].ToString();
                        Import_ApprovedPO_rawMat.Po_date = dt.Rows[i]["PO Date"].ToString();
                        Import_ApprovedPO_rawMat.Item_code = dt.Rows[i]["Item Code"].ToString();
                        Import_ApprovedPO_rawMat.Item_description = dt.Rows[i]["Item Description"].ToString();
                        Import_ApprovedPO_rawMat.ProjectName = dt.Rows[i]["Item Description"].ToString();
                        Import_ApprovedPO_rawMat.Qty_order = dt.Rows[i]["Qty Ordered"].ToString();
                        Import_ApprovedPO_rawMat.Actual_remaining_receiving = dt.Rows[i]["Qty Ordered"].ToString();

                        Import_ApprovedPO_rawMat.Qty_delivered = dt.Rows[i]["Qty Delivered"].ToString();
                        Import_ApprovedPO_rawMat.Qty_billed = dt.Rows[i]["Qty Billed"].ToString();
                        Import_ApprovedPO_rawMat.Qty_uom = dt.Rows[i]["UOM"].ToString();
                        Import_ApprovedPO_rawMat.Unit_price = dt.Rows[i]["Unit Price"].ToString();
                        Import_ApprovedPO_rawMat.Supplier = dt.Rows[i]["Vendor Name"].ToString();
                        Import_ApprovedPO_rawMats.Add(Import_ApprovedPO_rawMat);
                    }
                    drymaterialsBindingSource.DataSource = Import_ApprovedPO_rawMats;
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

        private void dgvRawMats_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            //var grid = sender as DataGridView;
            //var rowIdx = (e.RowIndex + 1).ToString();

            //var centerFormat = new StringFormat()
            //{
            //    // right alignment might actually make more sense for numbers
            //    Alignment = StringAlignment.Center,
            //    LineAlignment = StringAlignment.Center
            //};

            //var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            //e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void SaveMethod1()
        {
            dSet.Clear();
            dSet = objStorProc.sp_Raw_Materials_Dry(0,
                Item_code_main,
                Item_type_main,
                Item_class_main,
                Major_category_main,
                Sub_category_main,
                Primary_unit_main,
                "",
                "",
                "",
                "",
                "",
                "",
                0,
                "",
                "getdetailsforBulkInsertItemCode");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();


         

            }
            else
            {
                mode = "error";

                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;
                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].Cells["item_code"].Style.SelectionBackColor = Color.DarkOrange;
            }



            //PO Number

            dSet.Clear();
            dSet = objStorProc.sp_Raw_Materials_Dry(0,
                Sp_po_number, 
                Item_type_main, 
                Item_class_main, 
                Major_category_main, 
                Sub_category_main, 
                Primary_unit_main,
                "",
                "",
                "",
                "",
                "",
                "",
                0,
                "",
                "getPoNumber");

            if (dSet.Tables[0].Rows.Count > 0)
            {

                mode = "error";

                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;
                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].Cells["po_number"].Style.SelectionBackColor = Color.DarkOrange;
            }
            else
            {


            }

            //Validate Qty Order if String or Not "[^0-9]"))]
            decimal d;
            if (decimal.TryParse(Sp_qty_order, out d))
            {
      
               
            }
            else
            {
             
                mode = "error";

                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;
                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].Cells["qty_order"].Style.SelectionBackColor = Color.DarkOrange;
            }

            //Validate Qty Order Delivered if String or Not "[^0-9]"))]
            decimal d4;
            if (decimal.TryParse(Sp_qty_delivered, out d4))
            {


            }
            else
            {

                mode = "error";

                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;
                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].Cells["qty_delivered"].Style.SelectionBackColor = Color.DarkOrange;
            }


            //Validate Qty Order Billed if String or Not "[^0-9]"))]
            decimal d6;
            if (decimal.TryParse(Sp_qty_billed, out d6))
            {


            }
            else
            {

                mode = "error";

                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;
                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].Cells["qty_billed"].Style.SelectionBackColor = Color.DarkOrange;
            }



            //Validate Unit Price if Number Gago!
            decimal d2;
            if (decimal.TryParse(Sp_unit_price, out d2))
            {


            }
            else
            {

                mode = "error";

                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;
                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].Cells["unit_price"].Style.SelectionBackColor = Color.DarkOrange;
            }


            //Primary Unit

            dSet.Clear();
            dSet = objStorProc.sp_Raw_Materials_Dry(0,
                Item_code_main, 
                Item_type_main, 
                Item_class_main, 
                Major_category_main, 
                Sub_category_main, 
                Primary_unit_main,
                "",
                "",
                "",
                "",
                "",
                "",
                0,"",
                "getdetailsforBulkInsertPrimaryUnit");

            if (dSet.Tables[0].Rows.Count > 0)
            {



            }
            else
            {

                mode = "error";
                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].Cells["qty_uom"].Style.SelectionBackColor = Color.DarkOrange;
                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;
            }

     

            if (dgvRawMats.Rows.Count >= 1)
            {
                int i = dgvRawMats.CurrentRow.Index + 1;
                if (i >= -1 && i < dgvRawMats.Rows.Count)
                    dgvRawMats.CurrentCell = dgvRawMats.Rows[i].Cells[0];
                else
                {


                    if (mode == "error")
                    {
                        this.GlobalStatePopup.ErrorNotify(this.ErrorDetails);
                    }
                    else
                    {

                        this.dgvRawMats.CurrentCell = this.dgvRawMats.Rows[0].Cells[this.dgvRawMats.CurrentCell.ColumnIndex];
                        this.InsertDataPerRow();
                    }

                    //MessageBox.Show("Your reach the limit ");
                    this.dgvRawMats.CurrentCell = this.dgvRawMats.Rows[0].Cells[this.dgvRawMats.CurrentCell.ColumnIndex];
                    return;
                }
            }

            this.SaveMethod1();
        }

        private void InsertDataPerRow()
        {
            dSet.Clear();
            dSet = objStorProc.sp_Raw_Materials_Dry(0,
                Item_code_main, 
                Item_type_main, 
                Item_class_main, 
                Major_category_main, 
                Sub_category_main, 
                Primary_unit_main, "", "", "", "", "", "",0,"", "getdetailsforBulkInsertItemCode");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();
 


            }
            else
            {
                this.mode = "error";

                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

            }



            //PO Number

            dSet.Clear();
            dSet = objStorProc.sp_Raw_Materials_Dry(0,
                Sp_po_number, 
                Item_type_main, 
                Item_class_main, 
                Major_category_main, 
                Sub_category_main, 
                Primary_unit_main, "", "", "", "", "", "",0,"", "getPoNumber");

            if (dSet.Tables[0].Rows.Count > 0)
            {

                this.mode = "error";

                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

            }
            else
            {


            }

            dSet.Clear();
            dSet = objStorProc.sp_projects(0,
                Sp_po_number,
                Sp_qty_order, 
                Item_description_main, 
                Sp_pr_number, 
                Sp_pr_date, 
                Sp_po_number, 
                Sp_po_date, 
                Item_code_main, 
                Item_description_main, 
                Sp_qty_order, 
                Sp_qty_delivered, 
                Sp_qty_billed, 
                Primary_unit_main,
                Sp_unit_price, 
                Sp_supplier, 
                Sp_item_class, 
                Sp_item_type, 
                Sp_major_category, 
                Sp_sub_category, 
                Sp_is_expirable, "add");



            if (dgvRawMats.Rows.Count >= 1)
            {
                int i = dgvRawMats.CurrentRow.Index + 1;
                if (i >= -1 && i < dgvRawMats.Rows.Count)
                    dgvRawMats.CurrentCell = dgvRawMats.Rows[i].Cells[0];
                else
                {


                    if (mode == "error")
                    {
                        this.GlobalStatePopup.ErrorNotify(this.ErrorDetails);
                    }
                    else
                    {

                        this.dgvRawMats.CurrentCell = this.dgvRawMats.Rows[0].Cells[this.dgvRawMats.CurrentCell.ColumnIndex];
                        this.saveMode();  //Update All Data here
                        this.GlobalStatePopup.ImportSuccessFully();
                    }

        
                    this.dgvRawMats.CurrentCell = this.dgvRawMats.Rows[0].Cells[this.dgvRawMats.CurrentCell.ColumnIndex];
                    return;
                }
            }

            this.InsertDataPerRow();
        }


        private string m_ConnectionString = ULTRAMAVERICK.Properties.Settings.Default.hr_application_conn2;
//sample


        public bool saveMode()

        {

            Sp_user_id= userinfo.user_id.ToString(); // ID of User
            dSet.Clear();
            dSet = objStorProc.sp_Raw_Materials_Dry(0,
                Convert.ToString(User_id), 
                Item_type_main, 
                Item_class_main, 
                Major_category_main, 
                Sub_category_main, 
                Primary_unit_main, "", "", "", "", "", Sp_user_id,0,"", "final_save_bulk_data_status_POSummary");

            return false;

        }

      





        private void matbtnUpload_Click(object sender, EventArgs e)
        {
            if (this.lbltotalrecords.Text == "0")
            {
                //return;
            }

            if (this.cbosheet.Text.Trim() == string.Empty)
            {
            }
            else
            {

                this.matbtnUpload.Visible = false;
                this.dgvRawMats.CurrentCell = this.dgvRawMats.Rows[0].Cells[this.dgvRawMats.CurrentCell.ColumnIndex];

                //Start
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to upload the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.SaveMethod1();
                }
                else
                {
                    this.matbtnUpload.Visible = true;
                    return;
                }


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

                        dv.RowFilter = "item_code = '" + Item_code_main + "' ";

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





        private void dgvUnits_CurrentCellChanged(object sender, EventArgs e)
        {

            if (this.dgvUnits.CurrentRow != null)
            {
                if (this.dgvUnits.CurrentRow.Cells["item_code"].Value != null)
                {
                    this.Sp_item_class = this.dgvUnits.CurrentRow.Cells["item_class"].Value.ToString();
                    this.Sp_item_type = this.dgvUnits.CurrentRow.Cells["item_type"].Value.ToString();
                    this.Sp_major_category = this.dgvUnits.CurrentRow.Cells["major_category"].Value.ToString();
                    this.Sp_sub_category = this.dgvUnits.CurrentRow.Cells["sub_category"].Value.ToString();
                    this.Sp_is_expirable = this.dgvUnits.CurrentRow.Cells["is_expirable"].Value.ToString();

                }
            }

        }

        private void dgvRawMats_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            myClass.DataGridViewBindingClearSelection(this.dgvRawMats);
        }
    }
}
