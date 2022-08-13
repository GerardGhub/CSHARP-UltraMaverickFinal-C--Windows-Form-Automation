using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.API.Entities
{
    class DryWHReceipt
    {
        public int Id { get; set; }
        public string ParentDescription { get; set; }
        public int TransactionNo { get; set; }
        public int LotNumber { get; set; }
        public string LotDescription { get; set; }
        public string ManufacturingDate { get; set; }
        public string ExpirationDate { get; set; }
        public string ExpiryDays { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string Category { get; set; }
        public string Supplier { get; set; }
        public decimal Quantity { get; set; }
        public string Remarks { get; set; }
        public int AddedBy { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsActive { get; set; }
    }
}
