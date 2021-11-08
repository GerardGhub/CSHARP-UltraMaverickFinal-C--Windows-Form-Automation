using COMPLETE_FLAT_UI.Models;
using CrystalDecisions.CrystalReports.Engine;
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

namespace ULTRAMAVERICK.Barcode_Reprinting
{
    public partial class frmBarcodeReprinting : MaterialForm
    {

        myclasses myClass = new myclasses();
        myclasses xClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        public DataSet dset = new DataSet();
        DataSet dset2 = new DataSet();
        DataSet dset3 = new DataSet();
        string mode;
        ReportDocument rpt = new ReportDocument();
        string Rpt_Path = "";
        DataSet dSet = new DataSet();
        IStoredProcedures objStorProc = null;
        public frmBarcodeReprinting()
        {
            InitializeComponent();
        }

        private void frmBarcodeReprinting_Load(object sender, EventArgs e)
        {
            if (myClass.g_objStoredProc.getConnected() == true)
            {
                g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections();


                Rpt_Path = ULTRAMAVERICK.Properties.Settings.Default.fdg;

                //Rpt_Path = ini.IniReadValue("PATH", "Report_Path");
                dgvReprinting.Columns[0].Width = 135;// The id column
                dgvReprinting.Columns[1].Width = 150;// The id column
                //xClass.ActivitiesLogs(userinfo.emp_name + " Generated " + myglobal.REPORT_NAME + " Report");
            }
            else
            {
                MessageBox.Show("Unable to connect in sql server", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }





            dset = g_objStoredProcCollection.sp_IDGenerator(1, "SearchRepacking", "All", mattxtSearch.Text, 1);
           dgvReprinting.DataSource = dset.Tables[0];

       

            for (int i = 0; i <= dgvReprinting.RowCount; i++)
            {
                try
                {
                    dgvReprinting.Rows[i].Cells["selected"].Value = false;
                }
                catch (Exception) { }
            }

        

      
           lbltotalrecords.Text = dgvReprinting.RowCount.ToString();
      
      




            objStorProc = xClass.g_objStoredProc.GetCollections();

            myglobal.global_module = "Active";
            //load_search();
        }
    }
}
