using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProject.Models
{
    public class Product
    {
        public Product()
        {
            Categories = new HashSet<ProductCategory>();
        }

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Product Name is required.")]
        [Display(Name = "Product Name")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Product Name must be between 3 and 100 characters.")]
        public string Name { get; set; } = "";
        [Range(.99, 10000)]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Price is required.")]
        public decimal Price { get; set; } = 0.00m;
        public string ImageUrl { get; set; } = "";
        public int? BusinessId { get; set; } = null!;
        public Business Business { get; set; }
        [Required]
        [MinLength(1, ErrorMessage = "A Product must have at least one category.")]
        public virtual ICollection<ProductCategory> Categories { get; set; }
    }
}
