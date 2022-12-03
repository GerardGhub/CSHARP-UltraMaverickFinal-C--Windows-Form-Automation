using COMPLETE_FLAT_UI.Models;
using CrystalDecisions.CrystalReports.Engine;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Report
{
    public partial class frmReport : MaterialForm
    {
        string Rpt_Path = "";
        ReportDocument rpt = new ReportDocument();
        myclasses xClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;

        public frmReport()
        {
            InitializeComponent();
        }

        private void ConnectionInit()
        {
            this.g_objStoredProcCollection = xClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();


            crV1.Width = this.Width;
            crV1.Height = 10;

            Rpt_Path = ULTRAMAVERICK.Properties.Settings.Default.fdg;

            
            xClass.ActivitiesLogs(userinfo.emp_name + " Generated " + myglobal.REPORT_NAME + " Report");

            displayReport();
        }

        void displayReport()
        {
          
            if (myglobal.REPORT_NAME == "DailyFGTotal")
            {
                rpt.Load(Rpt_Path + "\\DailyReportFG.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;
                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            if (myglobal.REPORT_NAME == "StoreMoveOrderPickSlip")
            {
                rpt.Load(Rpt_Path + "\\StoreMoveOrderPickSlip.rpt");
                //rpt.SetDatabaseLogon("sa", "ULtR@MaVD3p0t2o22");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;
                string ddate3 = myglobal.DATE_REPORT3;
                string ddate4 = myglobal.DATE_REPORT4;
                string ddate5 = myglobal.DATE_REPORT5;


                rpt.SetParameterValue("@approved_prepa_date", ddate);
                rpt.SetParameterValue("@category", ddate2);
                rpt.SetParameterValue("@fox", ddate3);
                rpt.SetParameterValue("@username", ddate4);
                rpt.SetParameterValue("@parentIdentity", ddate5);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            if(myglobal.REPORT_NAME == "StoreMoveOrderPickSlipPreview")
            {
                rpt.Load(Rpt_Path + "\\StoreMoveOrderPickSlipPreview.rpt");
                             //rpt.SetDatabaseLogon("sa", "ULtR@MaVD3p0t2o22");
                    rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;
                string ddate3 = myglobal.DATE_REPORT3;
                string ddate4 = myglobal.DATE_REPORT4;
                string ddate5 = myglobal.DATE_REPORT5;


                rpt.SetParameterValue("@approved_prepa_date", ddate);
                rpt.SetParameterValue("@category", ddate2);
                rpt.SetParameterValue("@fox", ddate3);
                rpt.SetParameterValue("@username", ddate4);
                rpt.SetParameterValue("@parentIdentity", ddate5);
                crV1.ReportSource = rpt;
                crV1.Refresh();

            }






            else if (myglobal.REPORT_NAME == "MicroInventoryMovementPrint")
            {
                rpt.Load(Rpt_Path + "\\MicroInventoryMovementPrint.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;
                string ddate3 = myglobal.DATE_REPORT3;
                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                rpt.SetParameterValue("@ddate3", ddate3);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "MacroInventoryMovementPrint")
            {
                rpt.Load(Rpt_Path + "\\MacroInventoryMovementPrint.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;
                string ddate3 = myglobal.DATE_REPORT3;
                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                rpt.SetParameterValue("@ddate3", ddate3);
                //rpt.SetParameterValue("@feed_code", ddate3);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }




   









            else if (myglobal.REPORT_NAME == "QANewPrint")
            {
                rpt.Load(Rpt_Path + "\\QAReporting.rpt");

                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;

                //string ddate2 = myglobal.DATE_REPORT2;
                //string ddate3 = myglobal.DATE_REPORT3;
                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                //rpt.SetParameterValue("@feed_code", ddate3);
                crV1.ReportSource = rpt;
                crV1.Refresh();





            }

            //else if (myglobal.REPORT_NAME == "CustomerSurveyReport")
            //{
            //    rpt.Load(Rpt_Path + "\\CustomerSurveyReport.rpt");
            //    rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
            //    //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
            //    rpt.Refresh();
            //    string ddate = myglobal.DATE_REPORT;
            //    //string ddate2 = myglobal.DATE_REPORT2;
            //    //string ddate3 = myglobal.DATE_REPORT3;
            //    rpt.SetParameterValue("@ddate", ddate);
            //    //rpt.SetParameterValue("@ddate2", ddate2);
            //    //rpt.SetParameterValue("@feed_code", ddate3);
            //    crV1.ReportSource = rpt;
            //    crV1.Refresh();
            //}

            else if (myglobal.REPORT_NAME == "CustomerSurveyReportPrint")
            {
                rpt.Load(Rpt_Path + "\\CustomerSurveyReportPrint.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                //string ddate2 = myglobal.DATE_REPORT2;
                //string ddate3 = myglobal.DATE_REPORT3;
                rpt.SetParameterValue("@ddate", ddate);
                //rpt.SetParameterValue("@ddate2", ddate2);
                //rpt.SetParameterValue("@feed_code", ddate3);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "FGMoveOrderDone")
            {
                rpt.Load(Rpt_Path + "\\MoveOrderPickSlipDone.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;
                //string ddate3 = myglobal.DATE_REPORT3;
                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                //rpt.SetParameterValue("@feed_code", ddate3);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "FGMiscellaneousIssueReports")
            {
                rpt.Load(Rpt_Path + "\\FGMiscellaneousIssueReports.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;
                //string ddate3 = myglobal.DATE_REPORT3;
                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                //rpt.SetParameterValue("@feed_code", ddate3);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "FGMiscellaneousReceiptReports")
            {
                rpt.Load(Rpt_Path + "\\FGMiscellaneousReceiptReports.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;
                //string ddate3 = myglobal.DATE_REPORT3;
                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                //rpt.SetParameterValue("@feed_code", ddate3);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }


            else if (myglobal.REPORT_NAME == "MaterialsOut")
            {
                rpt.Load(Rpt_Path + "\\RawMaterialsOut.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                //string ddate2 = myglobal.DATE_REPORT2;
                //string ddate3 = myglobal.DATE_REPORT3;
                rpt.SetParameterValue("@ddate", ddate);
                //rpt.SetParameterValue("@ddate2", ddate2);
                //rpt.SetParameterValue("@feed_code", ddate3);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "MaterialsReceipt")
            {
                rpt.Load(Rpt_Path + "\\RawMaterialsReceipt.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                //string ddate2 = myglobal.DATE_REPORT2;
                //string ddate3 = myglobal.DATE_REPORT3;
                rpt.SetParameterValue("@ddate", ddate);
                //rpt.SetParameterValue("@ddate2", ddate2);
                //rpt.SetParameterValue("@feed_code", ddate3);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "FGInventorySearchFeedCodeOverAll")
            {
                rpt.Load(Rpt_Path + "\\FGInventoryFeedCodeOverAll.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();

                string ddate3 = myglobal.DATE_REPORT3;
                rpt.SetParameterValue("@feed_code", ddate3);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "DailyFGTotalPercentage")
            {
                rpt.Load(Rpt_Path + "\\DailyReportFGPercentage.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;

                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }


            else if (myglobal.REPORT_NAME == "FGMicroMaterialUsed")
            {
                rpt.Load(Rpt_Path + "\\FGMicroMaterialUsed.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;

                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "FGMicroMaterialUsedNew")
            {
                rpt.Load(Rpt_Path + "\\FGMicroMaterialUsedNew.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;

                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "MaterialUsedNewMacro")
            {
                rpt.Load(Rpt_Path + "\\FGMicroMaterialUsedNewMacro.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;

                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "MicroMaterialUsedNewProd")
            {
                rpt.Load(Rpt_Path + "\\FGMicroMaterialUsedNewProd.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;

                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "MacroMaterialUsedNewProd")
            {
                rpt.Load(Rpt_Path + "\\FGMacroMaterialUsedNewProd.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;

                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "FGMicroMaterialUsedProd")
            {
                rpt.Load(Rpt_Path + "\\FGMicroMaterialUsedProd.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;

                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "FGMicroMaterialUsedRepacking")
            {
                rpt.Load(Rpt_Path + "\\FGMicroMaterialUsedRepacking.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;

                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "MicroMaterialHistoryTracking")
            {
                rpt.Load(Rpt_Path + "\\MicroMaterialHistoryTracking.rpt");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;

                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "DryMaterialHistoryTracking")
            {
                rpt.Load(Rpt_Path + "\\DryMaterialHistoryTracking.rpt");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;

                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }












         














            else if (myglobal.REPORT_NAME == "DryReceivingBarcode")
            {
                rpt.Load(Rpt_Path + "\\DryReceivingBarcode.rpt");

                rpt.Refresh();
                

                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "DryReceivingBarcodeReprint")
            {
                rpt.Load(Rpt_Path + "\\DryReceivingBarcodeReprint.rpt");
                //rpt.SetDatabaseLogon("sa", "ULtR@MaVD3p0t2o22");

                rpt.Refresh();


                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
    

         
          
          
         
            else if (myglobal.REPORT_NAME == "MicroBook")
            {
                rpt.Load(Rpt_Path + "\\DrybarcodeModule.rpt");
                //rpt.SetDatabaseLogon("sa", "ULtR@MaVD3p0t2o22");

                rpt.Refresh();

                //crV1.SelectionFormula = "{Command.rp_item_description} like '*" + myglobal.Searchcategory + "*' or  {Command.rp_classification} like '*" + myglobal.Searchcategory + "*'or  {Command.rp_item_code} like '*" + myglobal.Searchcategory + "*' or  {Command.rp_mfg_date} like '*" + myglobal.Searchcategory + "*'  AND  {Command.rp_expiry_date} like '*" + myglobal.Filter + "*'";





                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
    

        }

        DataSet dset = new DataSet();
        private void frmReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            dset = g_objStoredProcCollection.sp_IDGenerator(0, "resetreceivingreprint", "", "", 6, 0);
        }
    }
}
