using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
    public class ProductCategory
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Category Name is required")]
        [Display(Name = "Category Name")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Category Name must be between 3 and 100 characters.")]
        public string Name { get; set; } = "";
        [StringLength(250, ErrorMessage = "Description must be 250 characters or less.")]
        [Display(Name = "Description")]
        public string Description { get; set; } = "";
        [JsonIgnore]
        public virtual ICollection<Product> Products { get; set; }

    }
}
