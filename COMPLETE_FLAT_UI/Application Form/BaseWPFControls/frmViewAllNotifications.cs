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

namespace ULTRAMAVERICK.BaseWPFControls
{
    public partial class frmViewAllNotifications : MaterialForm
    {
        DataSet dSet = new DataSet();
        myclasses xClass = new myclasses();
        public frmViewAllNotifications()
        {
            InitializeComponent();
        }

        private void frmViewAllNotifications_Load(object sender, EventArgs e)
        {
           
        }


        private void CancelledforStorePreparationatWarehouseChecker()      //method for loading available_menus
        {
            try
            {

                xClass.fillDataGridView(this.DatagridViewGuna1, "Store_Order_Cancelled_by_WH_Checker", dSet);

                this.lbltotalrecords.Text = this.DatagridViewGuna1.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void DispatchingforStorePreparationatWarehouseChecker()      //method for loading available_menus
        {
            try
            {

                xClass.fillDataGridView(this.gunaDgvLogisticCheckerDispatching, "Store_Order_Dispatched_by_Logistic_Checker", dSet);

                this.lbltotalrecords.Text = this.gunaDgvLogisticCheckerDispatching.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }


        private void showLabTestForReceiving()    //method for loading available_menus
        {
            // Try this Fuck!!
            dSet.Clear();
            try
            {

                xClass.fillDataGridView(this.dgvRawMats, "DryWarehouseLabTestReceivingViewing", dSet);

                this.lbltotalrecords.Text = this.dgvRawMats.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            this.DataGridVisibilityFalse();
        }


        private void DataGridVisibilityFalse()
        {
            this.dgvRawMats.Columns["mfg_date"].Visible = false;
            this.dgvRawMats.Columns["date_added"].Visible = false;
            this.dgvRawMats.Columns["exp_date"].Visible = false;
            this.dgvRawMats.Columns["lot_description"].Visible = false;
            this.dgvRawMats.Columns["STANDARDEXPIRYDAYS"].Visible = false;
            this.dgvRawMats.Columns["lot_no"].Visible = false;
            this.dgvRawMats.Columns["lab_request_date"].Visible = false;
            this.dgvRawMats.Columns["qty_received"].Visible = false;
            this.dgvRawMats.Columns["qa_approval_status"].Visible = false;
            this.dgvRawMats.Columns["qa_approval_date"].Visible = false;
            this.dgvRawMats.Columns["lab_result_released_date"].Visible = false;
            this.dgvRawMats.Columns["transaction_type"].Visible = false;
            this.dgvRawMats.Columns["RM_ITEM_LAST_USED"].Visible = false;
            this.dgvRawMats.Columns["qa_approval_by"].Visible = false;
            this.dgvRawMats.Columns["lab_result_released_by"].Visible = false;
            this.dgvRawMats.Columns["lab_access_code"].Visible = false;
            this.dgvRawMats.Columns["lab_request_by"].Visible = false;
            this.dgvRawMats.Columns["po_date"].Visible = false;
            this.dgvRawMats.Columns["po_number"].Visible = false;
            this.dgvRawMats.Columns["pr_date"].Visible = false;
            this.dgvRawMats.Columns["pr_no"].Visible = false;
            this.dgvRawMats.Columns["lab_cancel_remarks"].Visible = false;
            this.dgvRawMats.Columns["qa_supervisor_is_approve_status"].Visible = false;
            this.dgvRawMats.Columns["TotalLabtestRecords"].Visible = false;
            this.dgvRawMats.Columns["TotalLabtestRecordsCount"].Visible = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tPLogisticCheckerCancel)
            {
                
                this.CancelledforStorePreparationatWarehouseChecker();
            }
            else if (tabControl1.SelectedTab == tPCheckerDispatching)
            {
              
                this.DispatchingforStorePreparationatWarehouseChecker();
            }

            else if (tabControl1.SelectedTab == tPLabResultReceiving)
            {

                this.showLabTestForReceiving();
            }
            else
            {

            }
        }
    }
}
