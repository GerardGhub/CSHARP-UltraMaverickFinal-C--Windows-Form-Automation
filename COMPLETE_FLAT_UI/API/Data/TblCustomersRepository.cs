using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.API.Interfaces;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.API.Data
{
    class TblCustomersRepository : ITblCustomersRepository
    {
        myclasses xClass = new myclasses();
        public DataSet dSet = new DataSet();
        IStoredProcedures g_objStoredProcCollection = null;
        TblCustomers TblCustomersEntity = new TblCustomers();

        public void GetCustomer(DataGridView DataGridViews)
        {
            try
            {
     
            this.xClass.fillDataGridView(DataGridViews, "MoveOrder_Customers_Active", this.dSet);

            TblCustomersEntity.TotalRecords = DataGridViews.RowCount;
            }
            catch (Exception ex)
            {

            MessageBox.Show(ex.Message);
            }
        }

        public void GetCustomerDeactivated(DataGridView DataGridViews)
        {
            try
            {

                this.xClass.fillDataGridView(DataGridViews, "MoveOrder_Customers_Inactive", this.dSet);

            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void GetCustomerSearchMajor(int TotalRecords)
        {
            g_objStoredProcCollection = xClass.g_objStoredProc.GetCollections();
            this.dSet.Clear();
            this.dSet = g_objStoredProcCollection.sp_getMajorTables("MoveOrder_Customers_Active_Major");
            TotalRecords = dSet.Tables.Count;
        }
    }
}
