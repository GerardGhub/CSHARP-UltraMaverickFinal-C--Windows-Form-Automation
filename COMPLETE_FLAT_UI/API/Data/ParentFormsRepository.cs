using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULTRAMAVERICK.API.Interfaces;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.API.Data
{
    class ParentFormsRepository : IParentFormsRepository
    {
        readonly myclasses xClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
       public  DataSet dSet = new DataSet();
        public int TotalRecords = 0;
        public int DsetCount = 0;
        private void ConnectionInit()
        {
            g_objStoredProcCollection = xClass.g_objStoredProc.GetCollections(); 
        }

        public void GetStorePreparations(DataGridView DataGridViews)
        {
            try
            {

                this.xClass.fillDataGridViewMajorSp(DataGridViews, "searchorderForApprovalinDryWH_isApprovedforPreparation", this.dSet);

                this.TotalRecords = DataGridViews.RowCount;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void GetStoreOrderForApproval(DataGridView DataGridViews)
        {
           
            try
            {

                this.xClass.fillDataGridViewMajorSp(DataGridViews, "searchorderForApprovalinDryWH", this.dSet);

                this.TotalRecords = DataGridViews.RowCount;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void GetStoreOrderApproved(DataGridView DataGridViews)
        {
            this.ConnectionInit();
            try
            {

                this.xClass.fillDataGridViewMajorSp(DataGridViews, "searchorderForApprovalinDryWH_isApproved", this.dSet);

                this.TotalRecords = DataGridViews.RowCount;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void GetInternalOrderForScheduling(DataGridView DataGridViews)
        {
            try
            {
                xClass.fillDataGridView(DataGridViews, "Internal_Order_FilterByDate", this.dSet);
                this.TotalRecords = DataGridViews.RowCount;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void GetInternalOrderApproved(DataGridView DataGridViews)
        {
            try
            {

                this.xClass.fillDataGridViewMajorSp(DataGridViews, "searchMRSInternalPreparationDateSync", this.dSet);

                this.TotalRecords = DataGridViews.RowCount;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void GetInternalPreparation(DataGridView DataGridViews)
        {
            try
            {

                this.xClass.fillDataGridViewMajorSp(DataGridViews, "searchorderForApprovalinDryWH_isApprovedforPreparation_Internal", this.dSet);

                this.TotalRecords = DataGridViews.RowCount;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
