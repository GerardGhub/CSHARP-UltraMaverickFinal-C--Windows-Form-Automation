using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.API.Entities
{
    public class Sub_Category
    {
        public int Sub_Category_Id { get; set; }
        public string Sub_Category_Desc { get; set; }
        public string Sc_Added_By { get; set; }
        public string Sc_Added_At { get; set; }
        public string Sc_Updated_At {get; set;}
        public string Sc_Updated_By { get; set;}
        public bool Is_Active { get; set; }
        public string Is_Expirable { get; set; }
        public string Mode { get; set; }
    }
}
