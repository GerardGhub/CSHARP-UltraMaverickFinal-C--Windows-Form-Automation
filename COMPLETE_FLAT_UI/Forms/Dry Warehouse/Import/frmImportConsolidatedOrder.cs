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
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.Class;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Import
{
    public partial class frmImportConsolidatedOrder : MaterialForm
    {
        myclasses xClass = new myclasses();
        DataSet dSet = new DataSet();
        DataSet dSet_temp = new DataSet();
        IStoredProcedures objStorProc = null;

        myclasses myClass = new myclasses();
        string mode = "";
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();

        public frmImportConsolidatedOrder()
        {
            InitializeComponent();
        }
     

        public string Mat_row_number { get; set; }
        public int User_id { get; set; }

        public string ErrorDetails { get; set; }

   
        public string Sp_is_expirable { get; set; }
      
        public int Sp_order_id { get; set; }
        public string Sp_date_ordered { get; set; }
        public string Sp_fox { get; set; }
        public string Sp_store_name { get; set; }
        public string Sp_route { get; set; }
        public string Sp_area { get; set; }
        public string Sp_category { get; set; }
        public string Sp_item_code { get; set; }
        public string Sp_description { get; set; }
        public string Sp_uom { get; set; }
        public string Sp_qty { get; set; }
        public string SpDateNeeded { get; set; }
        private void frmImportConsolidatedOrder_Load(object sender, EventArgs e)
        {

            this.dry_wh_ordersTableAdapter.Fill(this.ultraMaverickDBDataSet.dry_wh_orders);
          
            
            objStorProc = xClass.g_objStoredProc.GetCollections();
      
            this.dgvRawMats.Columns[0].Width = 100;// The id column 
            this.CallOthers();
            this.DataGridVisibleFalse();
        }

        private void DataGridVisibleFalse()
        {
            this.dgvRawMats.Columns["foxDataGridViewTextBoxColumn"].Visible = false;
            this.dgvRawMats.Columns["storenameDataGridViewTextBoxColumn"].Visible = false;
            this.dgvRawMats.Columns["dateorderedDataGridViewTextBoxColumn"].Visible = false;
            this.dgvRawMats.Columns["routeDataGridViewTextBoxColumn"].Visible = false;
            this.dgvRawMats.Columns["categoryDataGridViewTextBoxColumn"].Visible = false;
            this.dgvRawMats.Columns["itemcodeDataGridViewTextBoxColumn"].Visible = false;
            this.dgvRawMats.Columns["descriptionDataGridViewTextBoxColumn"].Visible = false;
            this.dgvRawMats.Columns["qtyDataGridViewTextBoxColumn"].Visible = false;
            this.dgvRawMats.Columns["areaDataGridViewTextBoxColumn"].Visible = false;
            this.dgvRawMats.Columns["uomDataGridViewTextBoxColumn"].Visible = false;
        }

            private void CallOthers()
        {
            this.lbltotalrecords.Text = dgvRawMats.Rows.Count.ToString();
            this.User_id = userinfo.user_id;
            this.materialCard3.Visible = false;


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

        private void cbosheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                DataTable dt = tableCollection[cbosheet.SelectedItem.ToString()];
       
                if (dt != null)
                {
                    List<Store_order_dry_wh_orders> Import_Stores = new List<Store_order_dry_wh_orders>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Store_order_dry_wh_orders Store = new Store_order_dry_wh_orders();


                        Store.Date_ordered = dt.Rows[i]["ORDER DATE"].ToString();
                        Store.Store_name = dt.Rows[i]["STORE"].ToString();
                        Store.Fox = dt.Rows[i]["STORE CODE"].ToString();
                        Store.Route = dt.Rows[i]["ROUTE"].ToString();
                        Store.Area = dt.Rows[i]["AREA"].ToString();
                        Store.Category = dt.Rows[i]["CATEGORY"].ToString();
                        Store.Item_code = dt.Rows[i]["ITEM CODE"].ToString();
                        Store.Description = dt.Rows[i]["DESCRIPTION"].ToString();
                        Store.Uom = dt.Rows[i]["UOM"].ToString();
                        Store.Qty = dt.Rows[i]["QUANTITY ORDER"].ToString();
                        Store.DateNeeded = dt.Rows[i]["DATE NEEDED"].ToString();

                        Import_Stores.Add(Store);
                    }
                    drywhordersBindingSource1.DataSource = Import_Stores;
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
            this.cbosheet.Enabled = true;
        
        }

        private void cbosheet_SelectionChangeCommitted(object sender, EventArgs e)
        {

            this.matbtnUpload.Visible = true;
            this.mode = "";
            dgvRawMats_CurrentCellChanged(sender, e);

            if (this.lbltotalrecords.Text == "0")
            {

            }
            else
            {
                this.mattxtSearch_TextChanged(sender, e);
            }
       
        }

        private void dgvRawMats_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.dgvRawMats.CurrentRow != null)
            {
                if (this.dgvRawMats.CurrentRow.Cells["store_name"].Value != null)
                {
           ;
                    this.Sp_date_ordered = this.dgvRawMats.CurrentRow.Cells["date_ordered"].Value.ToString();
                    this.Sp_fox = this.dgvRawMats.CurrentRow.Cells["fox"].Value.ToString();
                    this.Sp_store_name = this.dgvRawMats.CurrentRow.Cells["store_name"].Value.ToString();
                    this.Sp_route = this.dgvRawMats.CurrentRow.Cells["route"].Value.ToString();
                    this.Sp_area= this.dgvRawMats.CurrentRow.Cells["area"].Value.ToString();
                    this.Sp_category = this.dgvRawMats.CurrentRow.Cells["category"].Value.ToString();
                    this.Sp_item_code = this.dgvRawMats.CurrentRow.Cells["item_code"].Value.ToString();
                    this.Sp_description = this.dgvRawMats.CurrentRow.Cells["description"].Value.ToString();
                    this.Sp_uom = this.dgvRawMats.CurrentRow.Cells["uom"].Value.ToString();
                    this.Sp_qty = this.dgvRawMats.CurrentRow.Cells["qty"].Value.ToString();
                    this.SpDateNeeded = this.dgvRawMats.CurrentRow.Cells["DateNeeded"].Value.ToString();
                    if (this.lbltotalrecords.Text == "0")
                    {

                    }
                    else
                    {
                        this.Mat_row_number = Convert.ToInt32(this.dgvRawMats.CurrentCell.RowIndex).ToString();
                    }
                    mattxtSearch_TextChanged(sender, e);


                }
            }
        }

        private void mattxtSearch_TextChanged(object sender, EventArgs e)
        {
            //this.SearchMethodJarVarCallingSP();
            //this.doSearchInTextBox();
        }

        private void SaveMethod1()
        {
            //Check The store if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                Sp_date_ordered,
                Sp_fox,
                Sp_store_name,
                Sp_route,
                Sp_area,
                Sp_category,
                Sp_item_code,
                Sp_description,
                Sp_uom,
                Sp_qty,
                "1",
                "",
                "",
                this.SpDateNeeded,
                "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();




            }
            else
            {
                mode = "error";
          
                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

            }

            //Check The store Code if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                Sp_date_ordered,
                Sp_fox,
                Sp_store_name,
                Sp_route,
                Sp_area,
                Sp_category,
                Sp_item_code,
                Sp_description,
                Sp_uom,
                Sp_qty,
                "1",
                "",
                "",
                this.SpDateNeeded,
                "getbystore_code");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();




            }
            else
            {
                mode = "error";
                MessageBox.Show("2");
                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

            }

            //Check The store Code Area and Route if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                Sp_date_ordered,
                Sp_fox,
                Sp_store_name,
                Sp_route,
                Sp_area,
                Sp_category,
                Sp_item_code,
                Sp_description,
                Sp_uom,
                Sp_qty,
                "1",
                "",
                "",
                this.SpDateNeeded,
                "getbystore_code_store_are_store_route");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();




            }
            else
            {
                mode = "error";
                MessageBox.Show("3");
                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

            }

            //Check The Item Code if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                Sp_date_ordered,
                Sp_fox,
                Sp_store_name,
                Sp_route,
                Sp_area,
                Sp_category,
                Sp_item_code,
                Sp_description,
                Sp_uom,
                Sp_qty,
                "1",
                "",
                "",
                this.SpDateNeeded,
                "getby_item_code");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();




            }
            else
            {
                mode = "error";
                this.ErrorDetails = "Item Code";
 
                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

            }

            //Check The Area if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                Sp_date_ordered,
                Sp_fox,
                Sp_store_name,
                Sp_route,
                Sp_area,
                Sp_category,
                Sp_item_code,
                Sp_description,
                Sp_uom,
                Sp_qty,
                "1",
                "",
                "",
                this.SpDateNeeded,
                "get_area_name");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();




            }
            else
            {
                mode = "error";
                MessageBox.Show("5");
                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

            }

            //Check The Route if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                Sp_date_ordered,
                Sp_fox,
                Sp_store_name,
                Sp_route,
                Sp_area,
                Sp_category,
                Sp_item_code,
                Sp_description,
                Sp_uom,
                Sp_qty,
                "1",
                "",
                "",
                this.SpDateNeeded,
                "get_route_name");

            if (dSet.Tables[0].Rows.Count > 0)
            {
              




            }
            else
            {
                mode = "error";
                MessageBox.Show("6");
                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

            }

            //Check The Sub Category if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                Sp_date_ordered,
                Sp_fox,
                Sp_store_name,
                Sp_route,
                Sp_area,
                Sp_category,
                Sp_item_code,
                Sp_description,
                Sp_uom,
                Sp_qty,
                "1",
                "",
                "",
                this.SpDateNeeded,
                "get_sub_category");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();




            }
            else
            {
                mode = "error";
                MessageBox.Show("7");
                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

            }

            //Check The Primary Unit if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                Sp_date_ordered,
                Sp_fox,
                Sp_store_name,
                Sp_route,
                Sp_area,
                Sp_category,
                Sp_item_code,
                Sp_description,
                Sp_uom,
                Sp_qty,
                "1",
                "",
                "",
                this.SpDateNeeded,
                "get_Primary_Unit");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();




            }
            else
            {
                mode = "error";
                MessageBox.Show("8");
                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

            }

            //Validate Quantity if Number Gago!
            decimal d2;
            if (decimal.TryParse(Sp_qty, out d2))
            {


            }
            else
            {

                mode = "error";
                MessageBox.Show("9");
                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;
            }


            //Check The if store order already created at the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                Sp_date_ordered,
                Sp_fox,
                Sp_store_name,
                Sp_route,
                Sp_area,
                Sp_category,
                Sp_item_code,
                Sp_description,
                Sp_uom,
                Sp_qty,
                "1",
                "",
                "",
                this.SpDateNeeded,
                "getbydata_manual");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();

                mode = "error";
                this.ErrorDetails = "Duplicate Order";
                //MessageBox.Show("10");
                dgvRawMats.Rows[Convert.ToInt32(Mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;



            }
            else
            {

            }


            //Check The Item Code && Subcategory if existg on the system PUSSY
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                Sp_date_ordered,
                Sp_fox,
                Sp_store_name,
                Sp_route,
                Sp_area,
                Sp_category,
                Sp_item_code,
                Sp_description,
                Sp_uom,
                Sp_qty,
                "1",
                "",
                "",
                this.SpDateNeeded,
                "getby_item_code_and_category");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();




            }
            else
            {
                mode = "error";
                this.ErrorDetails = "Category";
                //MessageBox.Show("11");
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


                    this.dgvRawMats.CurrentCell = this.dgvRawMats.Rows[0].Cells[this.dgvRawMats.CurrentCell.ColumnIndex];
                    return;
                }
            }

            this.SaveMethod1();
        }


        private void InsertDataPerRow()
        {



            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                Sp_date_ordered,
                Sp_fox,
                Sp_store_name,
                Sp_route,
                Sp_area,
                Sp_category,
                Sp_item_code,
                Sp_description,
                Sp_uom,
                Sp_qty,
                "1",
                "",
                 Convert.ToInt32(User_id).ToString(),
                 this.SpDateNeeded,
                "add");



            if (this.dgvRawMats.Rows.Count >= 1)
            {
                int i = this.dgvRawMats.CurrentRow.Index + 1;
                if (i >= -1 && i < this.dgvRawMats.Rows.Count)
                    this.dgvRawMats.CurrentCell = this.dgvRawMats.Rows[i].Cells[0];
                else
                {


                    if (mode == "error")
                    {
                        this.GlobalStatePopup.ErrorNotify(this.ErrorDetails);
                    }
                    else
                    {

                        this.dgvRawMats.CurrentCell = this.dgvRawMats.Rows[0].Cells[this.dgvRawMats.CurrentCell.ColumnIndex];
                     
                        this.GlobalStatePopup.ImportSuccessFully();
                        frmImportConsolidatedOrder_Load(new object(), new System.EventArgs());
                    }


                    this.dgvRawMats.CurrentCell = this.dgvRawMats.Rows[0].Cells[this.dgvRawMats.CurrentCell.ColumnIndex];
                    return;
                }
            }

            this.InsertDataPerRow();
        }


    


 

        private void matbtnUpload_Click(object sender, EventArgs e)
        {

        }

        private void matbtnUpload_Click_1(object sender, EventArgs e)
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
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to upload? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.SaveMethod1();
                }
                else
                {
                    this.matbtnUpload.Visible = true;
                    return;
                }


            }
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.GlobalStatePopup.ErrorNotify(this.ErrorDetails);
        }

        private void dgvRawMats_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvRawMats.ClearSelection();
        }
    }
}
