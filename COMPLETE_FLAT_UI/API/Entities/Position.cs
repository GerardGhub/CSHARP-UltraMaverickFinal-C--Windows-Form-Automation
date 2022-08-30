using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.API.Entities
{
    class Position
    {
        public int Position_Id { get; set; }
        public string Position_Name { get; set; }
        public string Department_Id { get; set; }
        public string Created_By { get; set; }
        public string Created_At { get; set; }
        public string Modified_By { get; set; }
        public string Modified_Date { get; set; }
        public bool Is_Active { get; set; }
        public string Primary_User_Id { get; set; }
        public string Mode { get; set; }
    }
}
