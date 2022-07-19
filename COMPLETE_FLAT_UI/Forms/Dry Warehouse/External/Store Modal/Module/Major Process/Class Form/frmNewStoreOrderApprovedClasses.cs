using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module.Major_Process.Class_Form
{
   class frmNewStoreOrderApprovedClasses
    {

        public int sp_user_id { get; set; }
        public string mode { get; set; }
        public int sp_order_id { get; set; }
        public string sp_date_ordered { get; set; }
        public string sp_fox { get; set; }
        public string sp_store_name { get; set; }
        public string sp_route { get; set; }
        public string sp_area { get; set; }
        public string sp_category { get; set; }
        public string sp_item_code { get; set; }
        public string sp_description { get; set; }
        public string sp_uom { get; set; }
        public string sp_qty { get; set; }

        public string is_issue_for_approval { get; set; }
        public string sp_StockOnHand { get; set; }
        public string sp_Allocated_Qty { get; set; }

        public string Sp_Reserved_Qty { get; set; }
        public int Sp_Allocation_Identity { get; set; }

    }
}
