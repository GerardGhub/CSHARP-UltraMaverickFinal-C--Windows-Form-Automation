using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.API.Entities
{
    public class Department
    {
        public int Department_Id { get; set; }
        public string Department_Name { get; set; }
        public string Created_By { get; set; }
        public string Created_At { get; set; }
        public string Updated_At { get; set; }
        public string Updated_By { get; set; }
        public string Is_Active { get; set; }
        public string Primary_User_Id { get; set; }
        public string Location_Id { get; set; }
        public string Mode { get; set; }

    }
}
