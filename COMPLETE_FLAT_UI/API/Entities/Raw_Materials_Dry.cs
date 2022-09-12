using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.API.Entities
{
   public  class Raw_Materials_Dry
    {
        public int Item_Id { get; set; }
        public string Item_Code { get; set; }
        public string Item_Description { get; set; }
        public string Item_Class { get; set; }
        public string Major_Category { get; set; }
        public string Sub_Category { get; set; }
        public string Primary_Unit { get; set; }
        public string Conversion { get; set; }
        public string Item_Type { get; set; }
        public string Created_At { get; set; }
        public string Created_By { get; set; }
        public string Updated_At { get; set; }
        public string Updated_By { get; set; }
        public bool Is_Active { get; set; }
        public double Buffer_Stock { get; set; }
        public int Expiration_Prompting { get; set; }
    }
}
