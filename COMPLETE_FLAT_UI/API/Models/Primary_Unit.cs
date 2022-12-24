using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.API.Entities
{
    public class Primary_Unit
    {
        public int Unit_Id { get; set; }
        public string Unit_Desc { get; set; }
        public string Pm_Added_By { get; set; }
        public string Pm_Added_At { get; set; }
        public string Pm_Updated_At { get; set; }
        public string Pm_Updated_By { get; set; }
        public bool Is_Active { get; set; }
        public string Mode { get; set; }
    }
}
