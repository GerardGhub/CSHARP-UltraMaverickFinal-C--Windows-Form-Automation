using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.Class
{
    public class import_drywh_rawmats
    {
        public int Item_id { get; set; }
        public string Item_code { get; set; }
        public string Item_description { get; set; }
        public string Item_type { get; set; }
        public string Item_class { get; set; }
        public string Major_category { get; set; }
        public string Sub_category { get; set; }
        public string Primary_unit { get; set; }
        public string Conversion { get; set; }
    }

    public class store_masterlist
    {
        public int Store_id { get; set; }
        public string Store_name { get; set; }
        public string Store_area { get; set; }
        public string Store_code { get; set; }
        public string Store_route { get; set; }


    }

    public class store_order_dry_wh_orders
    {
        public int Primary_id { get; set; }
        public int Order_id { get; set; }
        public string Date_ordered { get; set; }
        public string Fox { get; set; }
        public string Store_name { get; set; }
        public string Route { get; set; }
        public string Area { get; set; }
        public string Category { get; set; }
        public string Item_code { get; set; }
        public string Description { get; set; }
        public string Uom { get; set; }
        public string Qty { get; set; }
        public string DateNeeded { get; set; }

    }

        public class approve_po_summary
    {

        public int PrimaryID { get; set; }
        public string ProjectID { get; set; }
        public string actual_remaining_receiving {get; set;}
        public string ProjectName { get; set; }
        public string pr_number { get; set; }
        public string pr_date { get; set; }
        public string po_number { get; set; }
        public string po_date { get; set; }
        public string item_code { get; set; }
        public string item_description { get; set; }
        public string qty_order { get; set; }
        public string qty_delivered { get; set; }
        public string qty_billed { get; set; }
        public string qty_uom { get; set; }
        public string unit_price { get; set; }
        public string Supplier { get; set; }
    }
}
