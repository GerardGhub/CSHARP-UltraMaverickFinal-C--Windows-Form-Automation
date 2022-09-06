using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.API.Entities
{
    public class Major_Category
    {
        public int Major_Category_Id { get; set; }
        public string Major_Category_Desc { get; set; }
        public string Mc_Added_By { get; set; }
        public string Mc_Added_At { get; set; }
        public string Mc_Updated_At { get; set; }
        public string Mc_Updated_By { get; set; }
        public bool Is_Active { get; set; }
        public string Mode { get; set; }
    }
}
