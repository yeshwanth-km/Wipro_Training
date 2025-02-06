using System.ComponentModel.DataAnnotations;

namespace CRUDRazor.Models
{
    public class Product
    {
        [Key]
        public int ProId {  get; set; }
        public string? ProName { get; set; }
        public Decimal Price { get; set; }
        public string? Category { get; set; }
    }
}
