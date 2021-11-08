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

namespace ULTRAMAVERICK.Report
{
    public partial class frmReport : MaterialForm
    {
        string Rpt_Path = "";
        ReportDocument rpt = new ReportDocument();
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
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

            else if (myglobal.REPORT_NAME == "DailyFGTotalProduction")
            {
                rpt.Load(Rpt_Path + "\\DailyReportFGProduction.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;
                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "DailyProductionReportx")
            {
                rpt.Load(Rpt_Path + "\\DailyProd.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;
                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "DailyFGTotalDelayed")
            {
                rpt.Load(Rpt_Path + "\\FinishedGoodDelay.rpt");
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
            else if (myglobal.REPORT_NAME == "ProductionPlanning")
            {
                rpt.Load(Rpt_Path + "\\DailyProd.rpt");
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


            else if (myglobal.REPORT_NAME == "StockoutMaterials")
            {
                rpt.Load(Rpt_Path + "\\DailyMaterialOut.rpt");
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


            else if (myglobal.REPORT_NAME == "StockINMaterials")
            {
                rpt.Load(Rpt_Path + "\\DailyMaterialReceipt.rpt");
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

            else if (myglobal.REPORT_NAME == "FGInventoryMovementReport")
            {
                rpt.Load(Rpt_Path + "\\FGInventoryMovementReport.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;
                string ddate3 = myglobal.DATE_REPORT3;
                string ddate4 = myglobal.DATE_REPORT4;
                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                rpt.SetParameterValue("@ddate3", ddate3);
                rpt.SetParameterValue("@ddate4", ddate4);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "FGInventory")
            {
                rpt.Load(Rpt_Path + "\\FGInventorytransdate.rpt");
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
            else if (myglobal.REPORT_NAME == "FGInventorySearchFeedCode")
            {
                rpt.Load(Rpt_Path + "\\FGInventoryFeedCode.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;
                string ddate3 = myglobal.DATE_REPORT3;
                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                rpt.SetParameterValue("@feed_code", ddate3);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }


            else if (myglobal.REPORT_NAME == "ReprocessReport")
            {
                rpt.Load(Rpt_Path + "\\ReprocessRpt.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;
                string ddate3 = myglobal.DATE_REPORT3;
                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                //rpt.SetParameterValue("@feed_code", ddate3);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "TheoScadaPrint")
            {
                rpt.Load(Rpt_Path + "\\TheoScadaPrint.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;
                string ddate3 = myglobal.DATE_REPORT3;
                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                //rpt.SetParameterValue("@feed_code", ddate3);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }



            else if (myglobal.REPORT_NAME == "RepackingEntryPrint")
            {
                rpt.Load(Rpt_Path + "\\RepackingEntryPrint.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;
                string ddate3 = myglobal.DATE_REPORT3;
                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                //rpt.SetParameterValue("@feed_code", ddate3);
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

            else if (myglobal.REPORT_NAME == "ReprocessReportProdID")
            {
                rpt.Load(Rpt_Path + "\\ReprocessRptProdID.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                string ddate2 = myglobal.DATE_REPORT2;
                string ddate3 = myglobal.DATE_REPORT3;
                rpt.SetParameterValue("@ddate", ddate);
                rpt.SetParameterValue("@ddate2", ddate2);
                rpt.SetParameterValue("@prodid", ddate3);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "FGMoveOrderPickSlipwithcustomersurveyRePrint")
            {
                rpt.Load(Rpt_Path + "\\FGMoveOrderPickSlipwithcustomersurveyRePrint.rpt");
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

            else if (myglobal.REPORT_NAME == "FGMoveOrder")
            {
                rpt.Load(Rpt_Path + "\\FGMoveOrderPickSlipwithcustomersurvey.rpt");

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


            else if (myglobal.REPORT_NAME == "FGMiscellaneousIssue")
            {
                rpt.Load(Rpt_Path + "\\FGMiscellaneousIssuePickSlip.rpt");

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

            else if (myglobal.REPORT_NAME == "FGMiscellaneousReceipt")
            {
                rpt.Load(Rpt_Path + "\\FGMiscellaneousReceiptPickSlip.rpt");

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



            else if (myglobal.REPORT_NAME == "FGMoveOrderReprint")
            {
                rpt.Load(Rpt_Path + "\\FGMoveOrderPickSlipwithcustomersurveyReprint.rpt");

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
            else if (myglobal.REPORT_NAME == "MacroMaterialHistoryTracking")
            {
                rpt.Load(Rpt_Path + "\\MacroMaterialHistoryTracking.rpt");
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

            else if (myglobal.REPORT_NAME == "FGReceivedReports")
            {
                rpt.Load(Rpt_Path + "\\FGReceivedReports.rpt");
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

            else if (myglobal.REPORT_NAME == "FGTransactionVarianceReport")
            {
                rpt.Load(Rpt_Path + "\\FGTransactionVarianceReport.rpt");
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


            else if (myglobal.REPORT_NAME == "FGTransactReceivedReports")
            {
                rpt.Load(Rpt_Path + "\\FGTransactReceivedReports.rpt");
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

            else if (myglobal.REPORT_NAME == "FGStockonhandReports")
            {
                rpt.Load(Rpt_Path + "\\FGStockonhandReports.rpt");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                rpt.Refresh();
                //string ddate = myglobal.DATE_REPORT;
                //string ddate2 = myglobal.DATE_REPORT2;

                //rpt.SetParameterValue("@ddate", ddate);
                //rpt.SetParameterValue("@ddate2", ddate2);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "FGVarianceReport")
            {
                rpt.Load(Rpt_Path + "\\FGVarianceReport.rpt");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                rpt.Refresh();
                //string ddate = myglobal.DATE_REPORT;
                //string ddate2 = myglobal.DATE_REPORT2;

                //rpt.SetParameterValue("@ddate", ddate);
                //rpt.SetParameterValue("@ddate2", ddate2);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "DailyMacroReceiving")
            {
                rpt.Load(Rpt_Path + "\\DailyMacroReceiving.rpt");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;

                rpt.SetParameterValue("@ddate", ddate);

                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "DailyMicroReceiving")
            {
                rpt.Load(Rpt_Path + "\\DailyMicroReceiving.rpt");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;

                rpt.SetParameterValue("@ddate", ddate);

                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "FGTrackingRawMaterials")
            {
                rpt.Load(Rpt_Path + "\\FGTrackingRawMaterials.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                //string prod_id = myglobal.DATE_REPORT;
                rpt.SetParameterValue("@ddate", ddate);
                //rpt.SetParameterValue("@prod_id", prod_id);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "FGTrackingRawMaterialsMacro")
            {
                rpt.Load(Rpt_Path + "\\FGTrackingRawMaterialsMacro.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                //rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                //string prod_id = myglobal.DATE_REPORT;
                rpt.SetParameterValue("@ddate", ddate);
                //rpt.SetParameterValue("@prod_id", prod_id);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "DailyTimeRecordPerEmployee")
            {


                if ((myglobal.selected_only == 1) && (myglobal.with_date == 0))
                {
                    rpt.Load(Rpt_Path + "\\DailyTimeRecordPerEmployee.rpt");
                    rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                    rpt.Refresh();

                    crV1.SelectionFormula = "{Command.employee_id} = " + myglobal.temp_id + "";

                    crV1.ReportSource = rpt;
                    crV1.Refresh();
                }
                else if ((myglobal.selected_only == 1) && (myglobal.with_date == 1))
                {
                    rpt.Load(Rpt_Path + "\\DailyTimeRecordPerEmployee1.rpt");
                    rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                    rpt.Refresh();

                    rpt.SetParameterValue("@a", myglobal.DATE_START);
                    rpt.SetParameterValue("@b", myglobal.DATE_END);
                    rpt.SetParameterValue("@c", myglobal.temp_id);
                    rpt.SetParameterValue("@d", myglobal.employee_name);
                    //crV1.SelectionFormula = "{Command.employee_id} = " + Convert.ToString(myglobal.temp_id) + " AND Date({Command.attendance_date}) >= #" + myglobal.DATE_START + "# AND Date({Command.attendance_date}) <= #" + myglobal.DATE_END + "#";

                    crV1.ReportSource = rpt;
                    crV1.Refresh();
                }
                else if (myglobal.with_date == 1)
                {
                    rpt.Load(Rpt_Path + "\\DailyTimeRecordPerEmployeeAS.rpt");
                    rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                    rpt.Refresh();

                    rpt.SetParameterValue("@a", myglobal.DATE_START);
                    rpt.SetParameterValue("@b", myglobal.DATE_END);
                    //crV1.SelectionFormula = "Date({Command.attendance_date}) >= #" + myglobal.DATE_START + "# AND Date({Command.attendance_date}) <= #" + myglobal.DATE_END + "#";

                    crV1.ReportSource = rpt;
                    crV1.Refresh();
                }
            }

            else if (myglobal.REPORT_NAME == "BARCODE")
            {
                rpt.Load(Rpt_Path + "\\BarCode.rpt");
                rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();

                crV1.SelectionFormula = "{Command.employee_id} = " + myglobal.temp_id + "";
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "EmployeeList")
            {
                rpt.Load(Rpt_Path + "\\EmployeeList.rpt");
                rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();

                //crV1.SelectionFormula = "{Command.employee_id} = " + myglobal.temp_id + "";
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "Absent")
            {
                rpt.Load(Rpt_Path + "\\ListofAbsent.rpt");
                rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();

                //crV1.SelectionFormula = "DATE({Command.Attendance_Date}) = DATE('" + myglobal.DATE_REPORT + "')";
                //crV1.ReportSource = rpt;
                //crV1.Refresh();
                string ddate = myglobal.DATE_START.ToString("yyyy-MM-dd");
                rpt.SetParameterValue("@attendance", "'" + ddate + "'");

                //single_parameter("@attendance", myglobal.DATE_START);
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "MANPOWER")
            {
                rpt.Load(Rpt_Path + "\\MIS.rpt");
                rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();

                crV1.ReportSource = rpt;
                crV1.Refresh();
            }














            else if (myglobal.REPORT_NAME == "IDRepackReport")
            {
                rpt.Load(Rpt_Path + "\\IDRepackReport.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();

                crV1.SelectionFormula = "{Command.rp_item_description} like '*" + myglobal.Searchcategory + "*' or  {Command.rp_classification} like '*" + myglobal.Searchcategory + "*'or  {Command.rp_item_code} like '*" + myglobal.Searchcategory + "*' or  {Command.rp_mfg_date} like '*" + myglobal.Searchcategory + "*'  AND  {Command.rp_expiry_date} like '*" + myglobal.Filter + "*'";






                rpt.SetParameterValue("Approved", myglobal.rp_item_description);
                rpt.SetParameterValue("Validity", myglobal.validity);
                rpt.SetParameterValue("Position", myglobal.position);

                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "DryReceivingBarcode")
            {
                rpt.Load(Rpt_Path + "\\DryReceivingBarcode.rpt");
                //rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();


                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "DryReceivingBarcodeReprint")
            {
                rpt.Load(Rpt_Path + "\\DryReceivingBarcodeReprint.rpt");
                //rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();


                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            //else if (myglobal.REPORT_NAME == "IDRepackReportMain")
            //{
            //    rpt.Load(Rpt_Path + "\\IDRepackReportMain.rpt");
            //    rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
            //    ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
            //    rpt.Refresh();

            //    crV1.SelectionFormula = "{Command.rp_item_description} like '*" + myglobal.Searchcategory + "*' or  {Command.rp_classification} like '*" + myglobal.Searchcategory + "*'or  {Command.rp_item_code} like '*" + myglobal.Searchcategory + "*' or  {Command.rp_mfg_date} like '*" + myglobal.Searchcategory + "*'  AND  {Command.rp_expiry_date} like '*" + myglobal.Filter + "*'";






            //    rpt.SetParameterValue("Approved", myglobal.rp_item_description);
            //    rpt.SetParameterValue("Validity", myglobal.validity);
            //    rpt.SetParameterValue("Position", myglobal.position);

            //    crV1.ReportSource = rpt;
            //    crV1.Refresh();
            //}

            else if (myglobal.REPORT_NAME == "BMXIDRepackReport")
            {
                rpt.Load(Rpt_Path + "\\BMXIDRepackReport.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();

                crV1.SelectionFormula = "{Command.bmx_proddate} like '*" + myglobal.Searchcategory + "*'  AND  {Command.bmx_feed_code} like '*" + myglobal.Filter + "*'";


                rpt.SetParameterValue("Approved", myglobal.rp_item_description);
                rpt.SetParameterValue("Validity", myglobal.validity);
                rpt.SetParameterValue("Position", myglobal.position);

                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "IDFGReprintBags")
            {
                rpt.Load(Rpt_Path + "\\IDFGReprintBags.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();

                crV1.SelectionFormula = "{Command.fg_proddate} like '*" + myglobal.Searchcategory + "*'  AND  {Command.fg_feed_code} like '*" + myglobal.Filter + "*'";






                rpt.SetParameterValue("Approved", myglobal.rp_item_description);
                rpt.SetParameterValue("Validity", myglobal.validity);
                rpt.SetParameterValue("Position", myglobal.position);

                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "IDFGReprintBagsreprint")
            {
                rpt.Load(Rpt_Path + "\\MainFgPrintingBarcodeReprint.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();



                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "PrintBMX")
            {
                //rpt.Load(Rpt_Path + "\\MainMicroBasemixedPrinting.rpt");
                rpt.Load(Rpt_Path + "\\bmx.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();



                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "IDFGReprintBulk")
            {
                rpt.Load(Rpt_Path + "\\IDFGReprintBulk.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();

                crV1.SelectionFormula = "{Command.fg_proddate} like '*" + myglobal.Searchcategory + "*'  AND  {Command.fg_feed_code} like '*" + myglobal.Filter + "*'";






                rpt.SetParameterValue("Approved", myglobal.rp_item_description);
                rpt.SetParameterValue("Validity", myglobal.validity);
                rpt.SetParameterValue("Position", myglobal.position);

                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "IDFGReprintBulkreprint")
            {
                rpt.Load(Rpt_Path + "\\MainFgBulkPrintingReprint.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();


                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "MicroBook")
            {
                rpt.Load(Rpt_Path + "\\DrybarcodeModule.rpt");
                //rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();

                //crV1.SelectionFormula = "{Command.rp_item_description} like '*" + myglobal.Searchcategory + "*' or  {Command.rp_classification} like '*" + myglobal.Searchcategory + "*'or  {Command.rp_item_code} like '*" + myglobal.Searchcategory + "*' or  {Command.rp_mfg_date} like '*" + myglobal.Searchcategory + "*'  AND  {Command.rp_expiry_date} like '*" + myglobal.Filter + "*'";





                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "MicroBookAcidifier")
            {
                rpt.Load(Rpt_Path + "\\MicroBookAcidifier.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();


                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "MicroAll")
            {
                rpt.Load(Rpt_Path + "\\MicroAll.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();


                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "MacroAll")
            {
                rpt.Load(Rpt_Path + "\\MacroAll.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();


                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "IDBasedMixReportMainReprint2")
            {
                rpt.Load(Rpt_Path + "\\MainMicroBasemixedPrintingReprint.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();


                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "MicroBookCholine")
            {
                rpt.Load(Rpt_Path + "\\MicroBookCholine.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();


                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "MacroBookValidate")
            {
                rpt.Load(Rpt_Path + "\\MacroBookValidate.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();


                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "MacroBookTheoretical1")
            {
                rpt.Load(Rpt_Path + "\\MacroBookTheoretical1.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();


                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "MacroBookTheoretical2")
            {
                rpt.Load(Rpt_Path + "\\MacroBookTheoretical2.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();


                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "MicroBookVit Pmx")
            {
                rpt.Load(Rpt_Path + "\\MicroBookVit Pmx.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();


                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "MicroBookValidate")
            {
                rpt.Load(Rpt_Path + "\\MicroBookValidate.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();


                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "MicroBookUSSOYA")
            {
                rpt.Load(Rpt_Path + "\\MicroBookUSSOYA.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();


                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "MicroBookMedication")
            {
                rpt.Load(Rpt_Path + "\\MicroBookMedication.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();


                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "MicroBookMin Pmx")
            {
                rpt.Load(Rpt_Path + "\\MicroBookMin Pmx.rpt");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                ///
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                rpt.Refresh();


                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "MacroBook")
            {
                rpt.Load(Rpt_Path + "\\MacroBook.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();

                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "MacroInventorys")
            {
                rpt.Load(Rpt_Path + "\\MacroInventoryPrint.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();

                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "ReprocessData")
            {
                rpt.Load(Rpt_Path + "\\ReprocessData.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();

                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "MixingCapacity")
            {
                rpt.Load(Rpt_Path + "\\MixingCapacity.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();

                crV1.ReportSource = rpt;
                crV1.Refresh();
            }


            else if (myglobal.REPORT_NAME == "MicroInventorys")
            {
                rpt.Load(Rpt_Path + "\\MicroInventoryPrint.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");11
                rpt.Refresh();

                crV1.ReportSource = rpt;
                crV1.Refresh();
            }


            else if (myglobal.REPORT_NAME == "Users")
            {
                rpt.Load(Rpt_Path + "\\Users.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();

                crV1.ReportSource = rpt;
                crV1.Refresh();
            }


            else if (myglobal.REPORT_NAME == "MaterialFastMoving")
            {
                rpt.Load(Rpt_Path + "\\MaterialFastMoving.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
                ////////rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();

                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "MaterialSlowMoving")
            {
                rpt.Load(Rpt_Path + "\\MaterialSlowMoving.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");

                rpt.Refresh();

                crV1.ReportSource = rpt;
                crV1.Refresh();
            }

            else if (myglobal.REPORT_NAME == "MaterialNonMoving")
            {
                rpt.Load(Rpt_Path + "\\MaterialNonMoving.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");

                rpt.Refresh();

                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "MaterialMoving")
            {
                rpt.Load(Rpt_Path + "\\MaterialMoving.rpt");
                rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");

                rpt.Refresh();

                crV1.ReportSource = rpt;
                crV1.Refresh();
            }



            else if (myglobal.REPORT_NAME == "IDReport(HW)")
            {
                rpt.Load(Rpt_Path + "\\IDReport(HW).rpt");
                rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();

                crV1.SelectionFormula = "{Command.lastname} like '*" + myglobal.Searchcategory + "*' or  {Command.firstname} like '*" + myglobal.Searchcategory + "*'or  {Command.department_name} like '*" + myglobal.Searchcategory + "*' or  {Command.position_name} like '*" + myglobal.Searchcategory + "*' AND  {Command.employment_status_name} like '*" + myglobal.Filter + "*'";




                //ParamField.Name = "Approved";
                //ParamValue.Value = myglobal.employee_name ;
                //ParamField.CurrentValues.Add(ParamValue);
                //ParamFields.Add(ParamField);
                //ParamField2.Name = "Validity";
                //ParamValue2.Value = myglobal.validity ;
                //ParamField2.CurrentValues.Add(ParamValue2);
                //ParamFields2.Add(ParamField2);=
                //crV1.ParameterFieldInfo = ParamFields;
                //crV1.ParameterFieldInfo = ParamFields2;

                rpt.SetParameterValue("Approved", myglobal.employee_name);
                rpt.SetParameterValue("Validity", myglobal.validity);
                rpt.SetParameterValue("Position", myglobal.position);

                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "LEAVE_REPORT")
            {
                rpt.Load(Rpt_Path + "\\LeaveReport.rpt");
                rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();


                //crV1.SelectionFormula = "{Command.ID} = " + myglobal.temp_id + "";

                //rpt.SetParameterValue("@startdate", myglobal.DATE_START);
                //rpt.SetParameterValue("@enddate", myglobal.DATE_END);
                //rpt.SetParameterValue("Position", myglobal.position);

                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "LEAVE_REPORTB1")
            {
                rpt.Load(Rpt_Path + "\\LeaveReportB1.rpt");
                rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();


                if (myglobal.rptflag == 1)
                {
                    //crV1.SelectionFormula = "{Command.employee_id} = " + Convert.ToString(myglobal.temp_id) + " AND Date({Command.attendance_date}) >= #" + myglobal.DATE_START + "# AND Date({Command.attendance_date}) <= #" + myglobal.DATE_END + "#";
                    //crV1.SelectionFormula = "{Command.ID} = " + myglobal.temp_id + "";
                    crV1.SelectionFormula = "{Command.ID} = " + myglobal.temp_id + " AND Date({Command.date_created}) >= #" + myglobal.DATE_START + "# AND Date({Command.date_created}) <= #" + myglobal.DATE_END + "#";

                }
                else if (myglobal.rptflag == 2)
                {
                    //crV1.SelectionFormula = "{Command.ID} = " + myglobal.temp_id + "";
                    crV1.SelectionFormula = "Date({Command.date_created}) >= #" + myglobal.DATE_START + "# AND Date({Command.date_created}) <= #" + myglobal.DATE_END + "#";
                }
                //crV1.SelectionFormula = "{Command.ID} = " + myglobal.temp_id + "";

                //rpt.SetParameterValue("@startdate", myglobal.DATE_START);
                //rpt.SetParameterValue("@enddate", myglobal.DATE_END);
                //rpt.SetParameterValue("Position", myglobal.position);


                crV1.ReportSource = rpt;
                crV1.Refresh();

            }

            else if (myglobal.REPORT_NAME == "VisitorsReport")
            {
                rpt.Load(Rpt_Path + "\\VisitorsReport.rpt");
                rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();

                crV1.SelectionFormula = "Date({Command.DATE}) >= #" + myglobal.DATE_START + "# AND Date({Command.DATE}) <= #" + myglobal.DATE_END + "#";


                rpt.SetParameterValue("@startdate", myglobal.DATE_START.ToString("dd/MM/yyyy"));
                rpt.SetParameterValue("@enddate", myglobal.DATE_END.ToString("dd/MM/yyyy"));
                //rpt.SetParameterValue("Position", myglobal.position);

                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
            else if (myglobal.REPORT_NAME == "AbsentReporNew")
            {


                if (myglobal.temp_id != 1)
                    rpt.Load(Rpt_Path + "\\ARall.rpt");
                else
                    rpt.Load(Rpt_Path + "\\ARallWith.rpt");
                rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_START.ToString("yyyy-MM-dd");
                rpt.SetParameterValue("@ddate", ddate);
                //rpt.SetParameterValue("@ddate", myglobal.DATE_START.ToString("dd/MM/yyyy"));
                //rpt.SetParameterValue("@ddate",DateTime.Now.ToString("yyyy-MM-dd"));
                //rpt.SetParameterValue("@ddate","2018-03-10");
                //rpt.SetParameterValue("Position", myglobal.position);
                crV1.ReportSource = rpt;
                crV1.Refresh();

            }

            else if (myglobal.REPORT_NAME == "DailyLate")
            {


                rpt.Load(Rpt_Path + "\\DailyReportLate.rpt");
                rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                string ddate = myglobal.DATE_REPORT;
                rpt.SetParameterValue("@ddate", ddate);

                //rpt.SetParameterValue("@ddate", myglobal.DATE_START.ToString("dd/MM/yyyy"));
                //rpt.SetParameterValue("@ddate",DateTime.Now.ToString("yyyy-MM-dd"));
                //rpt.SetParameterValue("@ddate","2018-03-10");
                //rpt.SetParameterValue("Position", myglobal.position);
                crV1.ReportSource = rpt;
                crV1.Refresh();

            }

            else if (myglobal.REPORT_NAME == "empecomplement")
            {
                rpt.Load("C:/Reports/EmployeesComplement.rpt"); //RemovedFromLoanList
                rpt.SetDatabaseLogon("sa", "Nescafe3in1");
                rpt.Refresh();
                crV1.ReportSource = rpt;
                crV1.Refresh();
            }
        }

        DataSet dset = new DataSet();
        private void frmReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            dset = g_objStoredProcCollection.sp_IDGenerator(0, "resetreceivingreprint", "", "", 6);
        }
    }
}
