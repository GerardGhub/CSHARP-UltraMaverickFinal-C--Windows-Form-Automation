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



        public void AddCustomer(int Cust_Id, string Cust_Name, string Cust_Type, string Cust_Company, string Cust_Mobile, string Cust_Leadman, string Cust_Address, int Cust_Added_By, string Cust_Date_Added, string Cust_Updated_By, string Cust_Date_Updated, bool Is_Active, string Mode)
        {
            g_objStoredProcCollection = xClass.g_objStoredProc.GetCollections();
            dSet.Clear();
            dSet = g_objStoredProcCollection.sp_tblCustomers(
                0,
                Cust_Name,
                Cust_Type,
                Cust_Company,
                Cust_Mobile,
                Cust_Leadman,
                Cust_Address,
                Cust_Added_By,
                Cust_Date_Added,
                Cust_Updated_By,
                Cust_Date_Updated,
                Is_Active,
                "add");
        }

        public void PutDeactivatedCustomer(int Cust_Id, string Cust_Name, string Cust_Type, string Cust_Company, string Cust_Mobile, string Cust_Leadman, string Cust_Address, int Cust_Added_By, string Cust_Date_Added, string Cust_Updated_By, string Cust_Date_Updated, bool Is_Active, string Mode)
        {
            g_objStoredProcCollection = xClass.g_objStoredProc.GetCollections();
            dSet.Clear();
            dSet = g_objStoredProcCollection.sp_tblCustomers(
                Cust_Id,
                Cust_Name,
                Cust_Type,
                Cust_Company,
                Cust_Mobile,
                Cust_Leadman,
                Cust_Address,
                Cust_Added_By,
                Cust_Date_Added,
                Cust_Updated_By,
                Cust_Date_Updated,
                Is_Active,
                "delete");
        }

        public void PutActivatedCustomer(int Cust_Id, string Cust_Name, string Cust_Type, string Cust_Company, string Cust_Mobile, string Cust_Leadman, string Cust_Address, int Cust_Added_By, string Cust_Date_Added, string Cust_Updated_By, string Cust_Date_Updated, bool Is_Active, string Mode)
        {
            g_objStoredProcCollection = xClass.g_objStoredProc.GetCollections();
            dSet.Clear();
            dSet = g_objStoredProcCollection.sp_tblCustomers(
                Cust_Id,
                Cust_Name,
                Cust_Type,
                Cust_Company,
                Cust_Mobile,
                Cust_Leadman,
                Cust_Address,
                Cust_Added_By,
                Cust_Date_Added,
                Cust_Updated_By,
                Cust_Date_Updated,
                Is_Active,
                "delete_activation");
        }

        public void PutCustomer(int Cust_Id, string Cust_Name, string Cust_Type, string Cust_Company, string Cust_Mobile, string Cust_Leadman, string Cust_Address, int Cust_Added_By, string Cust_Date_Added, string Cust_Updated_By, string Cust_Date_Updated, bool Is_Active, string Mode)
        {
            g_objStoredProcCollection = xClass.g_objStoredProc.GetCollections();
            dSet.Clear();
            dSet = g_objStoredProcCollection.sp_tblCustomers(
                Cust_Id,
                Cust_Name,
                Cust_Type,
                Cust_Company,
                Cust_Mobile,
                Cust_Leadman,
                Cust_Address,
                Cust_Added_By,
                Cust_Date_Added,
                Cust_Updated_By,
                Cust_Date_Updated,
                Is_Active,
                "edit");


        }
    }
}
