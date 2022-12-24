using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.API.Entities
{
    class TblCustomers
    {
        public int Cust_Id { get; set; }
        public string Cust_Name { get; set; }
        public string Cust_Type { get; set; }
        public string Cust_Company { get; set; }
        public int Cust_Mobile { get; set; }
        public string Cust_LeadMan { get; set; }
        public string Cust_Address { get; set; }
        public  int Cust_Added_By { get; set; }
        public string Cust_Date_Added { get; set; }
        public string Cust_Updated_by { get; set; }
        public bool Is_Active { get; set; }
        public string Mode { get; set; }
        public int TotalRecords { get; set; }
    }
}
