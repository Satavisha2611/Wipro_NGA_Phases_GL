using System.ComponentModel.DataAnnotations;

namespace CustomerInformation.Models
{
    public class Wallet
    {
        [Key]
        public int WalletId { get; set; }
        public int CustId { get; set; }
        public string WalletType { get; set; }
        public decimal WalletAmount { get; set; }

    }
}
