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
    public partial class frmImportStore : MaterialForm
    {

        DataSet dSet = new DataSet();
        DataSet dSet_temp = new DataSet();
        private IStoredProcedures objStorProc = null;
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        readonly myclasses myClass = new myclasses();
        string mode = "";
        public frmImportStore()
        {
            InitializeComponent();
        }

        public string mat_row_number { get; set; }
        public int user_id { get; set; }
        //Storer
        public string sp_store_name { get; set; }
        public string sp_store_code { get; set; }
        public string sp_store_area { get; set; }
        public string sp_store_route { get; set; }
        public string SpRegion { get; set; }

        private void frmImportStore_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.dgvRawMats.Columns[0].Width = 100;// The id column 
            this.CallOthers();
        }

        private void ConnectionInit()
        {
            this.objStorProc = myClass.g_objStoredProc.GetCollections();
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
            catch (Exception)
            {

                this.GlobalStatePopup.DocumentAlreadyOpen();
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
            this.matbtnUpload.Enabled = true;
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
            dset_emp_SearchEngines = objStorProc.sp_getMajorTables("StoreBindingImport");

        }
        private void doSearchInTextBox()
        {
            try
            {
                if (dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEngines.Tables[0]);

                  if (myglobal.global_module == "Active")
                    {
                        dv.RowFilter = "store_name = '" + sp_store_name + "' ";
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
                    this.SpRegion = this.dgvRawMats.CurrentRow.Cells["region"].Value.ToString();
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
                    List<Store_masterlist> Import_Stores = new List<Store_masterlist>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Store_masterlist Store = new Store_masterlist();


                        Store.Store_name = dt.Rows[i]["Store"].ToString();
                        Store.Store_code = dt.Rows[i]["Code"].ToString();
                        Store.Store_area = dt.Rows[i]["Area"].ToString();
                        Store.Store_route = dt.Rows[i]["Route"].ToString();
                        Store.Region = dt.Rows[i]["Region"].ToString();

                        Import_Stores.Add(Store);
                    }
                    drymaterialsBindingSource.DataSource = Import_Stores;
                }

            }
            catch (Exception)
            {
                this.GlobalStatePopup.InvalidDocumentTemplate();
            }
            this.CallOthers();
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            cbosheet.Enabled = true;
        }






        private void SaveMethod1()
        {
            //Check The store if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_tbl_stores(0,
                sp_store_name,
                sp_store_area,
                sp_store_code,
                sp_store_route, 
                Convert.ToString(user_id), "", 
                Convert.ToString(user_id), "", 
                "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                mode = "error";
                dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].Cells["store_code"].Style.BackColor = Color.DarkOrange;
                dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].Cells["store_code"].Style.SelectionBackColor = Color.DarkOrange;
            }
            else
            {
           
            }

            //Area Name
            dSet.Clear();
            dSet = objStorProc.sp_tbl_stores(0,
            sp_store_name,
            sp_store_area,
            sp_store_code,
            sp_store_route,
            Convert.ToString(user_id), 
            "", 
            Convert.ToString(user_id), 
            "", 
            "", 
            "get_area_name");

            if (dSet.Tables[0].Rows.Count > 0)
            {

                mode = "error";
                dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].Cells["store_area"].Style.BackColor = Color.DarkOrange;
                dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].Cells["store_area"].Style.SelectionBackColor = Color.DarkOrange;

            }
            else
            {
 

            }

            //Route Name

            dSet.Clear();
            dSet = objStorProc.sp_tbl_stores(0,
                sp_store_name,
                sp_store_area,
                sp_store_code,
                sp_store_route,
                Convert.ToString(user_id), 
                "",
                Convert.ToString(user_id), 
                "", 
                "", 
                "get_route_name");

            if (dSet.Tables[0].Rows.Count > 0)
            {
  

            }
            else
            {
                mode = "error";
                dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].Cells["store_route"].Style.BackColor = Color.DarkOrange;
                dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].Cells["store_route"].Style.SelectionBackColor = Color.DarkOrange;


            }



            //Store Code

            dSet.Clear();
            dSet = objStorProc.sp_tbl_stores(0,
                sp_store_name,
                sp_store_area,
                sp_store_code,
                sp_store_route,
                Convert.ToString(user_id), 
                "", 
                Convert.ToString(user_id), 
                "", 
                "",
                "getbystorecode");

            if (dSet.Tables[0].Rows.Count > 0)
            {
              

                mode = "error";
                dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].Cells["store_code"].Style.BackColor = Color.DarkOrange;
                dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].Cells["store_code"].Style.SelectionBackColor = Color.DarkOrange;



            }
            else
            {
            
            }




            //Store Region

            dSet.Clear();
            dSet = objStorProc.sp_tblRegion(0,
                SpRegion,
                sp_store_area,
                sp_store_code,
                sp_store_route,
                Convert.ToString(user_id),
                "",
                "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {


    



            }
            else
            {
                mode = "error";
                dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].Cells["region"].Style.BackColor = Color.DarkOrange;
                dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].Cells["region"].Style.SelectionBackColor = Color.DarkOrange;
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
                        this.GlobalStatePopup.ErrorNotify("Check the data to proceed");
                    }
                    else
                    {                
                        this.dgvRawMats.CurrentCell = this.dgvRawMats.Rows[0].Cells[this.dgvRawMats.CurrentCell.ColumnIndex];
                        this.InsertDataPerRow();
                    }

                  
                    this.dgvRawMats.CurrentCell = this.dgvRawMats.Rows[0].Cells[this.dgvRawMats.CurrentCell.ColumnIndex];
                    this.dgvRawMats.ClearSelection();
                    return;
                }
            }

            this.SaveMethod1();
        }

        private void InsertDataPerRow()
        {


            //Check The store if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_tbl_stores(0,
                sp_store_name,
                sp_store_area,
                sp_store_code,
                sp_store_route,
                Convert.ToString(user_id),
                "", 
                Convert.ToString(user_id), 
                "", 
                "",
                "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                mode = "error";
                //dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange
            }
            else
            {
              
            }

            dSet.Clear();
            dSet = objStorProc.sp_tbl_stores(0,
            sp_store_name,
            sp_store_area,
            sp_store_code,
            sp_store_route,
            Convert.ToString(user_id), 
            "", 
            Convert.ToString(user_id), 
            "", 
            this.SpRegion, 
            "add");



            if (dgvRawMats.Rows.Count >= 1)
            {
                int i = dgvRawMats.CurrentRow.Index + 1;
                if (i >= -1 && i < dgvRawMats.Rows.Count)
                    dgvRawMats.CurrentCell = dgvRawMats.Rows[i].Cells[0];
                else
                {


                    if (mode == "error")
                    {
                        this.GlobalStatePopup.ErrorNotify("Check the data to proceed");
                    }
                    else
                    {

                        this.dgvRawMats.CurrentCell = this.dgvRawMats.Rows[0].Cells[this.dgvRawMats.CurrentCell.ColumnIndex];
    
                        this.GlobalStatePopup.SuccessFullySave();
                    }


                    this.dgvRawMats.CurrentCell = this.dgvRawMats.Rows[0].Cells[this.dgvRawMats.CurrentCell.ColumnIndex];
                    return;
                }
            }

            this.InsertDataPerRow();
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
                this.dgvRawMats.CurrentCell = this.dgvRawMats.Rows[0].Cells[this.dgvRawMats.CurrentCell.ColumnIndex];

                //Start
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to import the data? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void dgvRawMats_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            myClass.DataGridViewBindingClearSelection(this.dgvRawMats);
        }
    }
}
