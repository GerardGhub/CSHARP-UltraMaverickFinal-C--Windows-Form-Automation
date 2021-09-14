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
using MaterialSkin;
using MaterialSkin.Controls;
using Z.Dapper.Plus;
using Tulpep.NotificationWindow;
using ExcelDataReader;
using ULTRAMAVERICK.Class;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;
using System.Data.SqlClient;
using COMPLETE_FLAT_UI.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Import
{

    public partial class frmImportRawMatsExcel : MaterialForm
    {
        myclasses xClass = new myclasses();
        DataSet dSet = new DataSet();
        DataSet dSet_temp = new DataSet();
        IStoredProcedures objStorProc = null;
        string mode = "";
        public frmImportRawMatsExcel()
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
        
        private void frmImportRawMatsExcel_Load(object sender, EventArgs e)
        {
            objStorProc = xClass.g_objStoredProc.GetCollections();
            // TODO: This line of code loads data into the 'ultraMaverickDBDataSet.Raw_Materials_Dry' table. You can move, or remove it, as needed.
            this.raw_Materials_DryTableAdapter.Fill(this.ultraMaverickDBDataSet.Raw_Materials_Dry);
            //dgvRawMats.Rows[2].DefaultCellStyle.BackColor = Color.Yellow;
            dgvRawMats.Columns[0].Width = 100;// The id column 
            CallOthers();
        }
        private void CallOthers()
        {
            lbltotalrecords.Text = dgvRawMats.Rows.Count.ToString();
            user_id = userinfo.user_id;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
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
                //dgvRawMats.DataSource = dt;
                if (dt != null)
                {
                    List<import_drywh_rawmats> Import_dry_rawMats = new List<import_drywh_rawmats>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        import_drywh_rawmats Import_dry_rawMat = new import_drywh_rawmats();
                        //Import_Po_Summary.recipe_id = dt.Rows[i]["recipe_id"].ToString();
                        Import_dry_rawMat.item_code = dt.Rows[i]["ITEM CODE"].ToString();
                        Import_dry_rawMat.item_description = dt.Rows[i]["DESCRIPTION"].ToString();
                        Import_dry_rawMat.primary_unit = dt.Rows[i]["PRIMARY UNIT"].ToString();
                        Import_dry_rawMat.item_type = dt.Rows[i]["ITEM TYPE"].ToString();
                        Import_dry_rawMat.item_class = dt.Rows[i]["ITEM CLASS"].ToString();
                        Import_dry_rawMat.major_category = dt.Rows[i]["MAJOR CATEGORY"].ToString();
                        Import_dry_rawMat.sub_category = dt.Rows[i]["SUB CATEGORY"].ToString();
             
                        Import_dry_rawMat.conversion = dt.Rows[i]["CONVERSION"].ToString();

                     
                        Import_dry_rawMats.Add(Import_dry_rawMat);
                    }
                    drymaterialsBindingSource.DataSource = Import_dry_rawMats;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            CallOthers();
        }

        private void drymaterialsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dgvRawMats_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvRawMats.CurrentRow != null)
            {
                if (dgvRawMats.CurrentRow.Cells["item_code"].Value != null)
                {
                    item_id_main = dgvRawMats.CurrentRow.Cells["item_id"].Value.ToString();
                    item_code_main = dgvRawMats.CurrentRow.Cells["item_code"].Value.ToString();
                    conversion_main = dgvRawMats.CurrentRow.Cells["conversion"].Value.ToString();
                    item_type_main = dgvRawMats.CurrentRow.Cells["item_type"].Value.ToString();
                    item_class_main = dgvRawMats.CurrentRow.Cells["item_class"].Value.ToString();
                    major_category_main = dgvRawMats.CurrentRow.Cells["major_category"].Value.ToString();
                    sub_category_main = dgvRawMats.CurrentRow.Cells["sub_category"].Value.ToString();
                    primary_unit_main = dgvRawMats.CurrentRow.Cells["primary_unit"].Value.ToString();

                    if(lbltotalrecords.Text =="0")
                    {

                    }
                        else
                    {
                       mat_row_number = Convert.ToInt32(dgvRawMats.CurrentCell.RowIndex).ToString();
                    }



                }
            }

        }

        private void cbosheet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CallOthers();

           
            matbtnUpload.Visible = true;
            mode = "";
            dgvRawMats_CurrentCellChanged(sender, e);
        }

        private void SaveMethod1()
        {
            dSet.Clear();
            dSet = objStorProc.sp_Raw_Materials_Dry(0,
                item_code_main, item_type_main, item_class_main, major_category_main, sub_category_main, primary_unit_main, "", "", "", "", "", "", "getdetailsforBulkInsertItemCode");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();


                mode = "error";

                dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;
         
            }
            else
            {


            }

            //Item Type
            dSet.Clear();
            dSet = objStorProc.sp_Raw_Materials_Dry(0,
                item_code_main, item_type_main, item_class_main, major_category_main, sub_category_main, primary_unit_main, "", "", "", "", "", "", "getdetailsforBulkInsertItemType");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();




            }
            else
            {

                mode = "error";

                dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;
            }



            //Item Class

            dSet.Clear();
            dSet = objStorProc.sp_Raw_Materials_Dry(0,
                item_code_main, item_type_main, item_class_main, major_category_main, sub_category_main, primary_unit_main, "", "", "", "", "", "", "getdetailsforBulkInsertItemClass");

            if (dSet.Tables[0].Rows.Count > 0)
            {


            }
            else
            {

                mode = "error";

                dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;
            }

            //Major Category

            dSet.Clear();
            dSet = objStorProc.sp_Raw_Materials_Dry(0,
                item_code_main, item_type_main, item_class_main, major_category_main, sub_category_main, primary_unit_main, "", "", "", "", "", "", "getdetailsforBulkInsertMajorCategory");

            if (dSet.Tables[0].Rows.Count > 0)
            {


            }
            else
            {

                mode = "error";

                dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;
            }

            //Sub Category

            dSet.Clear();
            dSet = objStorProc.sp_Raw_Materials_Dry(0,
                item_code_main, item_type_main, item_class_main, major_category_main, sub_category_main, primary_unit_main, "", "", "", "", "", "", "getdetailsforBulkInsertSubCategory");

            if (dSet.Tables[0].Rows.Count > 0)
            {
          

            }
            else
            {

                mode = "error";

                dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;
            }

            //Primary Unit

            dSet.Clear();
            dSet = objStorProc.sp_Raw_Materials_Dry(0,
                item_code_main, item_type_main, item_class_main, major_category_main, sub_category_main, primary_unit_main, "", "", "", "", "", "", "getdetailsforBulkInsertPrimaryUnit");

            if (dSet.Tables[0].Rows.Count > 0)
            {



            }
            else
            {

                mode = "error";

                dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;
            }

            //KG COMPARISON BUGOK KA

            if(primary_unit_main =="KILOGRAM")
            {
                if(conversion_main =="1")
                {

                }
                else
                {
                    mode = "error";
                    dgvRawMats.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;
                }
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
                        ErrorNotify();
                    }
                    else
                    {
                  
                        //btnimport_Click(sender, e);
                        SaveinDatabase();
                    }

                    //MessageBox.Show("Your reach the limit ");
                    this.dgvRawMats.CurrentCell = this.dgvRawMats.Rows[0].Cells[this.dgvRawMats.CurrentCell.ColumnIndex];
                    return;
                }
            }

            SaveMethod1();
        }

        private string m_ConnectionString = ULTRAMAVERICK.Properties.Settings.Default.hr_application_conn2;
        private void SaveinDatabase()
        {
            try
            {
                // string connectionString = "Server=.;Database=Fedoramain;User Id=;Password=;";
                //string connectionString = @"Server=FM-MMERCADO-L;Initial Catalog=Fedoramain;Integrated Security=SSPI";
                //String connectionString = @"Data Source=10.10.2.16,1433\SQLEXPRESS;Initial Catalog=Fedoramain;User ID=sa;Password=FMf3dor@2o20;MultipleActiveResultSets=true";

                String connectionString = m_ConnectionString;
                DapperPlusManager.Entity<import_drywh_rawmats>().Table("Raw_Materials_Dry");
                List<import_drywh_rawmats> Import_Po_Summarys = drymaterialsBindingSource.DataSource as List<import_drywh_rawmats>;
                if (Import_Po_Summarys != null)
                {
                    using (IDbConnection db = new SqlConnection(connectionString))
                    {
                        db.BulkInsert(Import_Po_Summarys);
                    }
                }


                SavedNotify();
              
                matbtnUpload.Visible = false;





                saveMode();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public bool saveMode()

        {

            dSet.Clear();
            dSet = objStorProc.sp_Raw_Materials_Dry(0,
                Convert.ToString(user_id), item_type_main, item_class_main, major_category_main, sub_category_main, primary_unit_main, "", "", "", "", "", "", "final_save_bulk_data_status_only");

            return false;

        }



        private void matbtnUpload_Click(object sender, EventArgs e)
        {

            if(lbltotalrecords.Text =="0")
            {
                //return;
            }

            if (cbosheet.Text.Trim() == string.Empty)
            {
            }
            else
            {



                matbtnUpload.Visible = false;

                //Start
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to import a new  raw materials ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SaveMethod1();
                }
                else
                {
                    matbtnUpload.Visible = true;
                    return;
                }


            }









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

        private void dgvRawMats_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            cbosheet.Enabled = true;
        }
    }
}
