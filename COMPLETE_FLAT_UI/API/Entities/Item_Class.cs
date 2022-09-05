using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.API.Entities
{
    class Item_Class
    {
        public int Item_Class_Id { get; set; }
        public string Item_Class_Desc { get; set; }
        public string Item_Added_By { get; set; }
        public string Item_Added_At { get; set; }
        public string Item_Updated_At { get; set; }
        public string Item_Updated_By { get; set; }
        public bool Is_Active { get; set; }
        public string Mode { get; set; }

    }
}
