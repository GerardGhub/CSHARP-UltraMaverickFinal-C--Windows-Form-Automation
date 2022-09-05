using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.API.Entities
{
    class TblStoreOrderManageSyncing
    {
        public int Id { get; set; }
        public string Time_From_Desc { get; set; }
        public string Time_From_To { get; set; }
        public bool Is_Active { get; set; }
        public string Added_By { get; set; }
        public string Date_Added { get; set; }
        public string Updated_By { get; set; }
        public string Updated_At { get; set; }
        public string Mode { get; set; }

    }
}
