using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module.Allocation_Process.Class
{
    class frmAllocationModuleClasses
    {
        public string sp_qty_finder { get; set; }

        public int sp_total_row_allocated { get; set; }
        public string Sp_Store_Name { get; set; }

        public int Allocated_Quantity { get; set; }

        public string UnitOfMeasure { get; set; }

        public int user_id { get; set; }
    }
}
