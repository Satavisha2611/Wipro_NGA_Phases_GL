using System.ComponentModel.DataAnnotations;

namespace CustomerInformation.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int CustId { get; set; }
        public int MenuId { get;set; }
        public int VendorId { get; set; }
        public int QtyOrd { get; set; }
        public decimal BillAmount { get; set; }
        public string OrderStatus { get; set; }
 
    }
}
