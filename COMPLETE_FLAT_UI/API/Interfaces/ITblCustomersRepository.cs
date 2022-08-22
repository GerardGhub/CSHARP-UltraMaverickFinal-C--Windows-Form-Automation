using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULTRAMAVERICK.API.Entities;

namespace ULTRAMAVERICK.API.Interfaces
{
   
    interface ITblCustomersRepository
    {

        void GetCustomer(System.Windows.Forms.DataGridView DataGridViews);

        void GetCustomerDeactivated(System.Windows.Forms.DataGridView DataGridViews);

        void GetCustomerSearchMajor(int TotalRecords);

        void AddCustomer(int Cust_Id,
            string Cust_Name, 
            string Cust_Type,
            string Cust_Company, 
            string Cust_Mobile, 
            string Cust_Leadman,
            string Cust_Address, 
            string Cust_Added_By, 
            string Cust_Date_Added, 
            string Cust_Updated_By, 
            string Cust_Date_Updated,
            bool Is_Active);
    }
}
