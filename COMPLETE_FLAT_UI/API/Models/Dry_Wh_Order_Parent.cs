using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.API.Entities
{
    class Dry_Wh_Order_Parent
    {
        public int Id { get; set; }
        public string Approved_Preparation { get; set;}
        public string Fox { get; set; }
        public string Store_Name { get; set; }
        public string Route { get; set; }
        public string Area { get; set; }
        public string Category { get; set; }
        public int Start_By_User_Id { get; set; }
        public bool Is_Approved { get; set; }
        public int Is_Approved_By { get; set; }
        public string Is_Approved_Prepa_Date { get; set; }
        public bool Is_Active { get; set; }
        public string Is_for_validation { get; set; }
        public bool Is_Prepared { get; set; }
        public string Force_Prepared_Status { get; set; }
        public string Is_Wh_Checker_Cancel { get; set; }
        public string Start_Production { get; set; }
        public string End_Production { get; set; }
        public string Is_Prepared_Date { get; set; }
        public int Prepared_Allocated_Qty { get; set; }
        public int Total_State_Repack { get; set; }
        public string End_Time_Stamp_Per_Items { get; set; }
        public bool Is_Wh_Approved { get; set; }
        public string Is_Wh_Approved_By { get; set; }
        public string Is_Wh_Approved_Date { get; set; }
        public string Wh_Checker_Move_Order_No { get; set; }
        public bool Is_Selected { get; set; }
        public string Is_Selected_Move_Order_Date { get; set; }
        public string Is_Selected_Move_Order_By { get; set; }
        public int Print_Count { get; set; }
        public string Is_Cancel_By { get; set; }
        public DateTime Is_Cancel_Date { get; set; }
        public string Is_Cancelled_Reason { get; set; }

   }
}
