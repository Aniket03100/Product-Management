using crud_application.Models;
using System.ComponentModel.DataAnnotations;

namespace crud_application.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }

        // Navigation property for related Products
        public ICollection<Product>? Products { get; set; } 
    }
}
