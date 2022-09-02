using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.API.Entities
{
    class TblRoute
    {
        public int Route_Id { get; set; }
        public string Route_Name { get; set; }
        public bool Is_Active { get; set; }
        public string Added_By { get; set; }
        public string Date_Added { get; set; }
        public string Modified_By { get; set; }
        public string Modified_At { get; set; }
        public string Mode { get; set; }
    }
}
