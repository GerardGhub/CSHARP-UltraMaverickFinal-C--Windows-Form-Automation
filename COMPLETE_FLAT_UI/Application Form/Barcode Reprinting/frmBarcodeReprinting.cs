﻿using CrystalDecisions.CrystalReports.Engine;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Report;


namespace ULTRAMAVERICK.Barcode_Reprinting
{
    public partial class frmBarcodeReprinting : MaterialForm
    {
        readonly myclasses myClass = new myclasses();
        private IStoredProcedures g_objStoredProcCollection = null;
        public DataSet dset = new DataSet();
        DataSet dset2 = new DataSet();
        DataSet dset3 = new DataSet(); 
        ReportDocument rpt = new ReportDocument();
        string Rpt_Path = "";
        DataSet dSet = new DataSet();
        public frmBarcodeReprinting()
        {
            InitializeComponent();
        }

        private void frmBarcodeReprinting_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections

            if (myClass.g_objStoredProc.getConnected() == true)
            {
                g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections();
                this.Rpt_Path = ULTRAMAVERICK.Properties.Settings.Default.fdg;
                this.dgvReprinting.Columns[0].Width = 50;// The id column
                this.dgvReprinting.Columns[3].Width = 150;// The id column
            }
            else
            {
                MessageBox.Show("Unable to connect in sql server", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            this.DataRefresher();
            this.dset = g_objStoredProcCollection.sp_IDGenerator(1, "SearchRepacking", "All", mattxtReceivingID.Text, 1, 0);
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
           g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections();
            myglobal.global_module = "Active";
            this.load_search();
        }
        private void DataRefresher()
        {
            dset = g_objStoredProcCollection.sp_IDGenerator(0, "resetreceivingreprint", "", "", 6, 0);
        }
        DataSet dset_emp1 = new DataSet();
        private void load_search()
        {
            dset_emp1.Clear();
            dset_emp1 = g_objStoredProcCollection.sp_getMajorTables("searchreceivingreprintDry");
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

                    }
                   this.dgvReprinting.DataSource = dv;
                   this.lbltotalrecords.Text = dgvReprinting.RowCount.ToString();

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
                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepacking", "", "", 1, 0);

                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepackcount10", "", "", 10, 0);
                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepackcount9", "", "", 9, 0);

                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepackcount8", "", "", 8, 0);
                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepackcount7", "", "", 7, 0);
                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepackcount6", "", "", 6, 0);
                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepackcount5", "", "", 5, 0);
                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepackcount4", "", "", 4, 0);
                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepackcount3", "", "", 3, 0);
                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepackcount2", "", "", 2, 0);
                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepackcount", "", "", 1, 0);
                        }
     
                    }
                }
                catch (Exception ex)
                {
                    dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepacking", "", "", 0, 0);
                    MessageBox.Show(ex.Message);
                }
            }


            myglobal.REPORT_NAME = "DryReceivingBarcodeReprint";


            rpt.Load(Rpt_Path + "\\DryReceivingBarcodeReprint.rpt");
            //rpt.SetDatabaseLogon("sa", "ULtR@MaVD3p0t2o22");

            rpt.Refresh();      
                crV1.ReportSource = rpt;
                crV1.Refresh();
            frmReport frmReport = new frmReport();
            frmReport.ShowDialog();
        }



        private void matbtnPrint_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Print the Barcode Receiving Entry ? ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
