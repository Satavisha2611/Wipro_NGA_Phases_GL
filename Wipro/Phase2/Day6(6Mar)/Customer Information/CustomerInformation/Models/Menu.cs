using System.ComponentModel.DataAnnotations;
using Microsoft.CodeAnalysis.Elfie.Model.Tree;

namespace CustomerInformation.Models
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        public string? ItemName { get; set; }
        public string? ItemType { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }
        public string? Rating { get; set; }
  
    }
}
