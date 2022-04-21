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
using ULTRAMAVERICK.Report;


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
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            if (myClass.g_objStoredProc.getConnected() == true)
            {
                g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections();


                this.Rpt_Path = ULTRAMAVERICK.Properties.Settings.Default.fdg;

                //Rpt_Path = ini.IniReadValue("PATH", "Report_Path");
                this.dgvReprinting.Columns[0].Width = 50;// The id column
                this.dgvReprinting.Columns[3].Width = 150;// The id column
                //xClass.ActivitiesLogs(userinfo.emp_name + " Generated " + myglobal.REPORT_NAME + " Report");
            }
            else
            {
                MessageBox.Show("Unable to connect in sql server", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }



            this.DataRefresher();

            this.dset = g_objStoredProcCollection.sp_IDGenerator(1, "SearchRepacking", "All", mattxtReceivingID.Text, 1);
           this.dgvReprinting.DataSource = dset.Tables[0];

       

            for (int i = 0; i <= dgvReprinting.RowCount; i++)
            {
                try
                {
                    this.dgvReprinting.Rows[i].Cells["selected"].Value = false;
                }
                catch (Exception) { }
            }

        

      
           this.lbltotalrecords.Text = dgvReprinting.RowCount.ToString();
      
      




            //objStorProc = xClass.g_objStoredProc.GetCollections();

            myglobal.global_module = "Active";
            this.load_search();
        }
        private void DataRefresher()
        {
            dset = g_objStoredProcCollection.sp_IDGenerator(0, "resetreceivingreprint", "", "", 6);
        }
        DataSet dset_emp1 = new DataSet();
        private void load_search()
        {

            dset_emp1.Clear();

            dset_emp1 = objStorProc.sp_getMajorTables("searchreceivingreprintDry");

            this.doSearch();


        }

        private void doSearch()
        {
            try
            {
                if (dset_emp1.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp1.Tables[0]);
                    if (myglobal.global_module == "EMPLOYEE")
                    {
           
                    }
                    else if (myglobal.global_module == "Active")
                    {

                        dv.RowFilter = "date_added = '" + bunifuDatepickerReceivingDate.Text + "'" +
                            " and item_code like '%" + txtItemCode.Text + "%'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {
                        //dv.RowFilter = "visitors_lastname like '%" + txtsearch.Text + "%' or visitors_firstname like '%" + txtsearch.Text + "%'";
                    }
                   this.dgvReprinting.DataSource = dv;
                   this.lbltotalrecords.Text = dgvReprinting.RowCount.ToString();

                    //gerard
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 20.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
//END
        }

        private void bunifuDatepickerReceivingDate_onValueChanged(object sender, EventArgs e)
        {
            this.doSearch();
        }

        private void txtItemCode_TextChanged(object sender, EventArgs e)
        {
            this.doSearch();
        }

        private void bunifuDatepickerReceivingDate_ValueChanged(object sender, EventArgs e)
        {
            this.doSearch();
            //this.mattxtReceivingID.Visible = true;
        }

        private void bunifuDatepickerReceivingDate_onValueChanged_1(object sender, EventArgs e)
        {
            this.doSearch();
        }
        private void Print()
        {
   
            for (int i = 0; i <= dgvReprinting.RowCount - 1; i++)
            {
                try
                {
                    if (dgvReprinting.CurrentRow != null)
                    {

                        if (Convert.ToBoolean(dgvReprinting.Rows[i].Cells["selected"].Value) == true)
                        {
                            this.dgvReprinting.CurrentCell = this.dgvReprinting.Rows[i].Cells[this.dgvReprinting.CurrentCell.ColumnIndex];
                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepacking", "", "", 1);

                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepackcount10", "", "", 10);
                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepackcount9", "", "", 9);

                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepackcount8", "", "", 8);
                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepackcount7", "", "", 7);
                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepackcount6", "", "", 6);
                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepackcount5", "", "", 5);
                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepackcount4", "", "", 4);
                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepackcount3", "", "", 3);
                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepackcount2", "", "", 2);
                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepackcount", "", "", 1);
                        }
                        else
                        {
                            //dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepacking", "", "", 1);

                        }
                    }
                }
                catch (Exception ex)
                {

                    dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepacking", "", "", 0);
                    MessageBox.Show(ex.Message);
                }

            }


            myglobal.REPORT_NAME = "DryReceivingBarcodeReprint";


            rpt.Load(Rpt_Path + "\\DryReceivingBarcodeReprint.rpt");
            rpt.SetDatabaseLogon("sa", "ULtR@MaVD3p0t2o22");



            rpt.Refresh();
            
     




                crV1.ReportSource = rpt;
                crV1.Refresh();



            frmReport frmReport = new frmReport();
            frmReport.ShowDialog();

            //frmReport frmReport = new frmReport();
            //frmReport.MdiParent = this.MdiParent;
            //frmReport.Show();


        }



        private void matbtnPrint_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Print the Barcode Receiving Entry ? ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Print();
            }
            else
            {
     
                return;
            }


        }
    }

}
