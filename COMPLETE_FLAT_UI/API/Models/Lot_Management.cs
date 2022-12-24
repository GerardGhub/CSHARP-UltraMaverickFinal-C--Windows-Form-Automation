using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.API.Entities
{
    class Lot_Management
    {
        public int Id { get; set; }
        public string Lot_Number { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Added_By { get; set; }
        public string Date_Added { get; set; }
        public string Updated_By { get; set; }
        public string Date_Updated { get; set; }
        public bool Is_Active { get; set; }
        public string Deactivate_By { get; set; }
        public string Deactivate_Date { get; set; }
        public string Mode { get; set; }

    }
}
