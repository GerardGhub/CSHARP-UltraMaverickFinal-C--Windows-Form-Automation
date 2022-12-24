using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.API.Entities
{
    class ParentForms
    {
        public int Parent_Id { get; set; }
        public string Parent_Form_Name { get; set; }
        public DateTime Created_At { get; set; }
        public string Created_By { get; set; }
        public string Updated_At { get; set; }
        public string Updated_By { get; set; }
        public bool Is_Active { get; set; }
        public string Department { get; set; }
        public int UserRightsId { get; set; }
        public int Total_Touched { get; set; }
        public string Mode { get; set; }
    }
}
