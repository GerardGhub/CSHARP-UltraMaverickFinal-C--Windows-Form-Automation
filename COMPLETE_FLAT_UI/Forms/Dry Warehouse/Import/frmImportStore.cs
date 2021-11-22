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
  
        public string sp_user_id { get; set; }
    
 
        //Expirable
        public string sp_is_expirable { get; set; }
        //Storer
        public string sp_store_name { get; set; }
        public string sp_store_code { get; set; }
        public string sp_store_area { get; set; }
        public string sp_store_route { get; set; }

        private void frmImportStore_Load(object sender, EventArgs e)
        {
            objStorProc = xClass.g_objStoredProc.GetCollections();
            // TODO: This line of code loads data into the 'ultraMaverickDBDataSet.tbl_stores' table. You can move, or remove it, as needed.
          //Remove muna eto
            //////this.tbl_storesTableAdapter.Fill(this.ultraMaverickDBDataSet.tbl_stores);

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


        }
        private void cbosheet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.CallOthers();


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
                    if (myglobal.global_module == "EMPLOYEE")
                    {

                    }
                    else if (myglobal.global_module == "Active")
                    {

                        dv.RowFilter = "store_name = '" + sp_store_name + "' ";

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

        private void ErrorNotify()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Uploading Interupt Check the data to proceed";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Red;
            popup.Popup();

            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);

            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }


        private void SavedNotify()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Raw Materials Successfully Upload";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Green;
            popup.Popup();

            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);

            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


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
                Convert.ToString(user_id), "", Convert.ToString(user_id), "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();

                mode = "error";

                dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;



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
                Convert.ToString(user_id), "", Convert.ToString(user_id), "", "get_area_name");

            if (dSet.Tables[0].Rows.Count > 0)
            {



            }
            else
            {
                mode = "error";

                dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

            }

            //Route Name

            dSet.Clear();
            dSet = objStorProc.sp_tbl_stores(0,
                sp_store_name,
                sp_store_area,
                sp_store_code,
                sp_store_route,
                Convert.ToString(user_id), "", Convert.ToString(user_id), "", "get_route_name");

            if (dSet.Tables[0].Rows.Count > 0)
            {


            }
            else
            {


                mode = "error";

                dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;
            }



            //Store Code

            dSet.Clear();
            dSet = objStorProc.sp_tbl_stores(0,
                sp_store_name,
                sp_store_area,
                sp_store_code,
                sp_store_route,
                Convert.ToString(user_id), "", Convert.ToString(user_id), "", "getbystorecode");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();

                mode = "error";

                dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;



            }
            else
            {
            
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
                        this.ErrorNotify();
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


            //Check The store if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_tbl_stores(0,
                sp_store_name,
                sp_store_area,
                sp_store_code,
                sp_store_route,
                Convert.ToString(user_id), "", Convert.ToString(user_id), "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();

                mode = "error";

                dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;



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
                Convert.ToString(user_id), "", Convert.ToString(user_id), "", "add");



            if (dgvRawMats.Rows.Count >= 1)
            {
                int i = dgvRawMats.CurrentRow.Index + 1;
                if (i >= -1 && i < dgvRawMats.Rows.Count)
                    dgvRawMats.CurrentCell = dgvRawMats.Rows[i].Cells[0];
                else
                {


                    if (mode == "error")
                    {
                        this.ErrorNotify();
                    }
                    else
                    {

                        this.dgvRawMats.CurrentCell = this.dgvRawMats.Rows[0].Cells[this.dgvRawMats.CurrentCell.ColumnIndex];
                        //this.saveMode();  //Update All Data here
                        this.SavedNotify();
                    }


                    this.dgvRawMats.CurrentCell = this.dgvRawMats.Rows[0].Cells[this.dgvRawMats.CurrentCell.ColumnIndex];
                    return;
                }
            }

            this.InsertDataPerRow();
        }
        public bool saveMode()

        {

            sp_user_id = userinfo.user_id.ToString(); // ID of User
            dSet.Clear();
            dSet = objStorProc.sp_Raw_Materials_Dry(0,
                Convert.ToString(user_id), item_type_main, item_class_main, major_category_main, sub_category_main, primary_unit_main, "", "", "", "", "", sp_user_id, 0, "final_save_bulk_data_status_POSummary");

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
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to import a new Store? ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
    }
}
