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
using System.Windows.Forms.DataVisualization.Charting;
using ULTRAMAVERICK.Class;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Import
{
    public partial class FrmImportMrsOrders : MaterialForm
    {
        DataSet dSet = new DataSet();
        DataSet dSet_temp = new DataSet();
        IStoredProcedures objStorProc = null;
        readonly myclasses myClass = new myclasses();
        string mode = "";
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        public FrmImportMrsOrders()
        {
            InitializeComponent();
        }

        public string Mat_row_number { get; set; }
        public int User_id { get; set; }
        public int Department_Id { get; set; }  
        public string ErrorDetails { get; set; }



        public int Mrs_Id { get; set; }
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

        private void FrmImportMrsOrders_Load(object sender, EventArgs e)
        {
            this.dry_wh_ordersTableAdapter.Fill(this.ultraMaverickDBDataSet.dry_wh_orders);
            this.ConnectionInt();
            this.DgvImportMrsOrder.Columns[0].Width = 100;// The id column 
            this.CallOthers();
            this.DataGridVisibleFalse();
        }

        private void ConnectionInt()
        {
            objStorProc = myClass.g_objStoredProc.GetCollections();
        }

        private void DataGridVisibleFalse()
        {
            this.DgvImportMrsOrder.Columns["foxDataGridViewTextBoxColumn"].Visible = false;
            this.DgvImportMrsOrder.Columns["storenameDataGridViewTextBoxColumn"].Visible = false;
            this.DgvImportMrsOrder.Columns["dateorderedDataGridViewTextBoxColumn"].Visible = false;
            this.DgvImportMrsOrder.Columns["routeDataGridViewTextBoxColumn"].Visible = false;
            this.DgvImportMrsOrder.Columns["categoryDataGridViewTextBoxColumn"].Visible = false;
            this.DgvImportMrsOrder.Columns["itemcodeDataGridViewTextBoxColumn"].Visible = false;
            this.DgvImportMrsOrder.Columns["descriptionDataGridViewTextBoxColumn"].Visible = false;
            this.DgvImportMrsOrder.Columns["qtyDataGridViewTextBoxColumn"].Visible = false;
            this.DgvImportMrsOrder.Columns["areaDataGridViewTextBoxColumn"].Visible = false;
            this.DgvImportMrsOrder.Columns["uomDataGridViewTextBoxColumn"].Visible = false;
        }

        private void CallOthers()
        {
            this.lbltotalrecords.Text = DgvImportMrsOrder.Rows.Count.ToString();
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

                this.GlobalStatePopup.DocumentAlreadyOpen();
            }

        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            this.cbosheet.Enabled = true;
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
                        Store.Fox = dt.Rows[i]["DEPARTMENT"].ToString();
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

                this.GlobalStatePopup.InvalidDocumentTemplate();
            }
            this.CallOthers();
        }

    


        private void cbosheet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.matbtnUpload.Enabled = true;
            this.mode = "";
            dgvRawMats_CurrentCellChanged(sender, e);

            if (this.lbltotalrecords.Text == "0")
            {

            }
    

        }

        private void dgvRawMats_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.DgvImportMrsOrder.CurrentRow != null)
            {
                if (this.DgvImportMrsOrder.CurrentRow.Cells["fox"].Value != null)
                {

                    this.Sp_date_ordered = this.DgvImportMrsOrder.CurrentRow.Cells["date_ordered"].Value.ToString();
                    this.Sp_fox = this.DgvImportMrsOrder.CurrentRow.Cells["fox"].Value.ToString();
                    this.Sp_item_code = this.DgvImportMrsOrder.CurrentRow.Cells["item_code"].Value.ToString();
                    this.Sp_description = this.DgvImportMrsOrder.CurrentRow.Cells["description"].Value.ToString();
                    this.Sp_uom = this.DgvImportMrsOrder.CurrentRow.Cells["uom"].Value.ToString();
                    this.Sp_qty = this.DgvImportMrsOrder.CurrentRow.Cells["qty"].Value.ToString();
                    this.SpDateNeeded = this.DgvImportMrsOrder.CurrentRow.Cells["DateNeeded"].Value.ToString();
                    if (this.lbltotalrecords.Text == "0")
                    {

                    }
                    else
                    {
                        this.Mat_row_number = Convert.ToInt32(this.DgvImportMrsOrder.CurrentCell.RowIndex).ToString();
                    }
          


                }
            }
        }

        private void SaveMethod1()
        {


       

                dSet.Clear();
                dSet = objStorProc
                .sp_material_request_logs(0,
                0,
                Sp_fox,
                Sp_description,
                Sp_qty,
                Sp_uom,
                Sp_area,
                Sp_category,
                Sp_item_code,
                Sp_description,
                Sp_uom,
                Sp_qty,
                this.Sp_date_ordered,
                this.Sp_store_name,
                "getbyDepartment_Name");


            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();
            }
            else
            {
                mode = "error";
                DgvImportMrsOrder.Rows[Convert.ToInt32(Mat_row_number)].Cells["fox"].Style.SelectionBackColor = Color.DarkOrange;
                DgvImportMrsOrder.Rows[Convert.ToInt32(Mat_row_number)].Cells["fox"].Style.BackColor = Color.DarkOrange;
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
                DgvImportMrsOrder.Rows[Convert.ToInt32(Mat_row_number)].Cells["item_code"].Style.SelectionBackColor = Color.DarkOrange;
                DgvImportMrsOrder.Rows[Convert.ToInt32(Mat_row_number)].Cells["item_code"].Style.BackColor = Color.DarkOrange;

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
                DgvImportMrsOrder.Rows[Convert.ToInt32(Mat_row_number)].Cells["uom"].Style.SelectionBackColor = Color.DarkOrange;
                DgvImportMrsOrder.Rows[Convert.ToInt32(Mat_row_number)].Cells["uom"].Style.BackColor = Color.DarkOrange;

            }

     




            //Validate Date
            DateTime dd;
            if (DateTime.TryParse(SpDateNeeded, out dd))
            {


            }
            else
            {

                mode = "error";
                DgvImportMrsOrder.Rows[Convert.ToInt32(Mat_row_number)].Cells["DateNeeded"].Style.SelectionBackColor = Color.DarkOrange;
                DgvImportMrsOrder.Rows[Convert.ToInt32(Mat_row_number)].Cells["DateNeeded"].Style.BackColor = Color.DarkOrange;
            }


            //Validate Date  <Date Now
            DateTime date1 = Convert.ToDateTime(SpDateNeeded);
            DateTime date2 = DateTime.UtcNow;
            if (date1 > date2)
            {


            }
            else
            {

                mode = "error";
                DgvImportMrsOrder.Rows[Convert.ToInt32(Mat_row_number)].Cells["DateNeeded"].Style.SelectionBackColor = Color.DarkOrange;
                DgvImportMrsOrder.Rows[Convert.ToInt32(Mat_row_number)].Cells["DateNeeded"].Style.BackColor = Color.DarkOrange;
            }



            try
            {
                decimal d2;
                if (decimal.TryParse(Sp_qty, out d2))
                {

                }
                else
                {

                    mode = "error";
     
                    DgvImportMrsOrder.Rows[Convert.ToInt32(Mat_row_number)].Cells["qty"].Style.SelectionBackColor = Color.DarkOrange;
                    DgvImportMrsOrder.Rows[Convert.ToInt32(Mat_row_number)].Cells["qty"].Style.BackColor = Color.DarkOrange;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



            decimal m2;
            if (decimal.TryParse(Sp_qty, out m2))
            {

                dSet.Clear();
                dSet = objStorProc
                    .sp_material_request_logs(0,
                    0,
                    Sp_item_code,
                    Sp_description,
                    Sp_qty,
                    Sp_uom,
                    Sp_area,
                    Sp_category,
                    Sp_item_code,
                    Sp_description,
                    Sp_uom,
                    Sp_qty,
                    this.Sp_date_ordered,
                    this.Sp_fox,
                    "getbydata_manual");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    //RawMatsAlreadyExist();

                    mode = "error";
                    this.ErrorDetails = "Duplicate Order";
                    this.GlobalStatePopup.ErrorNotify(ErrorDetails);

                    DgvImportMrsOrder.Rows[Convert.ToInt32(Mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;



                }


            }




            if (DgvImportMrsOrder.Rows.Count >= 1)
            {
                int i = DgvImportMrsOrder.CurrentRow.Index + 1;
                if (i >= -1 && i < DgvImportMrsOrder.Rows.Count)
                    DgvImportMrsOrder.CurrentCell = DgvImportMrsOrder.Rows[i].Cells[0];
                else
                {


                    if (mode == "error")
                    {
                        this.GlobalStatePopup.ErrorNotify(this.ErrorDetails);
                    }
                    else
                    {


                        this.DgvImportMrsOrder.CurrentCell = this.DgvImportMrsOrder.Rows[0].Cells[this.DgvImportMrsOrder.CurrentCell.ColumnIndex];
                        this.InsertDataPerRow();
                    }


                    this.DgvImportMrsOrder.CurrentCell = this.DgvImportMrsOrder.Rows[0].Cells[this.DgvImportMrsOrder.CurrentCell.ColumnIndex];
                    this.DgvImportMrsOrder.ClearSelection();
                    return;
                }
            }

            this.SaveMethod1();
        }


        private void InsertDataPerRow()
        {
            try
            {

                //Start Department ID Binding
                dSet.Clear();
                dSet = objStorProc.sp_department(0,
                this.Sp_fox,
                "",    "","","","","",     
                "getbyname");


                    Department_Id = Convert.ToInt32(dSet.Tables[0].Rows[0]["department_id"]);
               //End Department ID Binding


                dSet.Clear();
                dSet = objStorProc
                    .sp_material_request_master(0,
                    "Import Excel File",
                    Department_Id.ToString(),
                     Department_Id,
                    false,
                    userinfo.emp_name + ' ' + userinfo.emp_lastname,
                    "",
                    userinfo.user_id,
                   false,
                   "0",
                   this.Sp_date_ordered,
                   this.Sp_fox,
                    "getbydata_manual");


                if (dSet.Tables[0].Rows.Count > 0)
                {
                    //RawMatsAlreadyExist();
                    //FuckingShit
                    //this.Mrs_Id = Convert.ToInt32(dSet.Tables[0].Rows[0]["mrs_id"]);

                }
                else
                {
                    dSet.Clear();
                    dSet = objStorProc
                        .sp_material_request_master(0,
                        "Import Excel File",
                        "",
                        Department_Id,
                        false,
                        userinfo.emp_name + ' ' + userinfo.emp_lastname,
                        "",
                        userinfo.user_id,
                       false,
                       "0",
                       this.Sp_date_ordered,
                                      this.Sp_fox,
                        "add");
                }

                this.MrsParentDataValidation();


                dSet.Clear();
                dSet = objStorProc
                    .sp_material_request_logs(0,
                     this.Mrs_Id,
                    Sp_item_code,
                    Sp_description,
                    Sp_qty,
                    Sp_uom,
                    Sp_area,
                    Sp_category,
                    Sp_item_code,
                    Sp_description,
                    Sp_uom,
                    Sp_qty,
                             this.Sp_date_ordered,
                    this.Sp_fox,
                    "add");




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }





            if (this.DgvImportMrsOrder.Rows.Count >= 1)
            {
                int i = this.DgvImportMrsOrder.CurrentRow.Index + 1;
                if (i >= -1 && i < this.DgvImportMrsOrder.Rows.Count)
                    this.DgvImportMrsOrder.CurrentCell = this.DgvImportMrsOrder.Rows[i].Cells[0];
                else
                {


                    if (mode == "error")
                    {
                        this.GlobalStatePopup.ErrorNotify(this.ErrorDetails);
                    }
                    else
                    {

                        this.DgvImportMrsOrder.CurrentCell = this.DgvImportMrsOrder.Rows[0].Cells[this.DgvImportMrsOrder.CurrentCell.ColumnIndex];

                        this.GlobalStatePopup.ImportSuccessFully();
                     FrmImportMrsOrders_Load(new object(), new System.EventArgs());
                    }


                    this.DgvImportMrsOrder.CurrentCell = this.DgvImportMrsOrder.Rows[0].Cells[this.DgvImportMrsOrder.CurrentCell.ColumnIndex];
                    return;
                }
            }

            this.InsertDataPerRow();
        }


        private void MrsParentDataValidation()
        {
            this.ConnectionInt();
            dSet.Clear();
            dSet = objStorProc
            .sp_material_request_master(0,
            "Import Excel File",
            Department_Id.ToString(),
            Department_Id,
            false,
            userinfo.emp_name + ' ' + userinfo.emp_lastname,
            "",
            userinfo.user_id,
            false,
            "0",
            this.Sp_date_ordered,
            this.Sp_fox,
            "getbydata_manual");


            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.Mrs_Id = Convert.ToInt32(dSet.Tables[0].Rows[0]["mrs_id"]);
            }
        }

        private void dgvRawMats_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            myClass.DataGridViewBindingClearSelection(this.DgvImportMrsOrder);
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

                this.matbtnUpload.Enabled = false;
                this.DgvImportMrsOrder.CurrentCell = this.DgvImportMrsOrder.Rows[0].Cells[this.DgvImportMrsOrder.CurrentCell.ColumnIndex];

                //Start
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to upload the data? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.SaveMethod1();
                }
                else
                {
                    this.matbtnUpload.Enabled = true;
                    return;
                }


            }

        }
    }
}
