using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.API.Entities
{
    public class Avg_Order_Trend
    {
        public int Avg_Id { get; set; }
        public string Avg_Desc { get; set; }
        public int Avg_Days { get; set; }
        public string Added_By { get; set; }
        public string Date_Added { get; set; }
        public bool Is_Active { get; set; }
        public string Updated_By { get; set; }
        public string Updated_Date { get; set; }
        public string Mode { get; set; }
    }
}
