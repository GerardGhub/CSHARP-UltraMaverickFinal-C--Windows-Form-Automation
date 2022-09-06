using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.API.Entities
{
    public class Item_Type
    {
        public int Item_Type_Id { get; set; }
        public string Item_Type_Desc { get; set; }
        public string It_Added_By { get; set; }
        public string It_Added_At { get; set; }
        public string It_Updated_At { get; set; }
        public string It_Updated_By { get; set; }
        public bool Is_Active { get; set; }
        public string Mode { get; set; }



    }
}
