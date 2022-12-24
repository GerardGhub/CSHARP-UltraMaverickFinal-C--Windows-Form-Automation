using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.API.Entities
{
    class Tbl_Stores
    {
        public int Stored_Id { get; set; }
        public string Store_Name { get; set; }
        public string Store_Area { get; set; }
        public string Store_Code { get; set; }
        public string Store_Route { get; set; }
        public bool Is_Active { get; set; }
        public string Date_Added { get; set; }
        public string Added_By { get; set; }
        public string Modified_Date { get; set; }
        public string Modified_By { get; set; }
        public string Region { get; set; }
        public string Mode { get; set; }
    }
}
