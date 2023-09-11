using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace SupplierAPI.Models
{
    public class Supplier
    {
       
        public int Id { get; set; }
        [Required(ErrorMessage = "Supplier name is manditory")]
        public String Name { get; set; }
        [RegularExpression(@"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$", ErrorMessage = "Invalid email address")]
        public string   Email { get; set; }
        [Required(ErrorMessage = "Suppliers phone number is manditory")]
        [RegularExpression(@"^(\+91[\-\s]?)?[0]?(91)?[789]\d{9}$", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }

       
        public List<Product>? Products { get; set; }

    }
}
