using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.Class
{
    public class import_drywh_rawmats
    {
        public int item_id { get; set; }
        public string item_code { get; set; }
        public string item_description { get; set; }
        public string item_type { get; set; }
        public string item_class { get; set; }
        public string major_category { get; set; }
        public string sub_category { get; set; }
        public string primary_unit { get; set; }
        public string conversion { get; set; }
    }

    public class store_masterlist
    {
        public int store_id { get; set; }
        public string store_name { get; set; }
        public string store_area { get; set; }
        public string store_code { get; set; }
        public string store_route { get; set; }


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
