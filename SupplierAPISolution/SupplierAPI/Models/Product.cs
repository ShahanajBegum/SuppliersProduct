using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplierAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Product name is manditory")]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int SupplierId { get; set;}

        [ForeignKey("SupplierId")]
        public Supplier? Supplier { get; set; }

        public bool IsNull { get; set; }
    }
}
