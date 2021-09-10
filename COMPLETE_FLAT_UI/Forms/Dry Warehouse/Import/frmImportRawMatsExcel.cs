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

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Import
{
    public partial class frmImportRawMatsExcel : MaterialForm
    {
        public frmImportRawMatsExcel()
        {
            InitializeComponent();
        }

        private void frmImportRawMatsExcel_Load(object sender, EventArgs e)
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
    }
}
