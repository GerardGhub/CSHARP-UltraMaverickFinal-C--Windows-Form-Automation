using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.API.Entities
{
    class DepartmentUnit
    {
        public int Unit_Id { get; set; }
        public string Unit_Description { get; set; }
        public string Department { get; set; }
        public string Updated_At { get; set; }
        public string Updated_By { get; set; }
        public string Created_At { get; set; }
        public string Created_By { get; set; }
        public bool Is_Active { get; set; }
        public int Department_Id { get; set; }
        public string Mode { get; set; }
    }
}
