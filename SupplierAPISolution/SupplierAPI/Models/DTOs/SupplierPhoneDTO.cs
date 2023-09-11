using System.ComponentModel.DataAnnotations;

namespace SupplierAPI.Models.DTOs
{
    public class SupplierPhoneDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Suppliers phone number is manditory")]
        [RegularExpression(@"^(\+91[\-\s]?)?[0]?(91)?[789]\d{9}$", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }
    }
}
