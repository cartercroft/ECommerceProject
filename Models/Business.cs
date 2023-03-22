using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
    public class Business
    {
        public Business()
        {
            Products = new HashSet<Product>();
        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Owner is required.")]
        public IdentityUser? Owner { get; set; }
        [Required(ErrorMessage = "Business Name is required.")]
        [Display(Name = "Business Name")]
        [StringLength(100, ErrorMessage = "Business Name must be 100 characters or less.")]
        public string Name { get; set; } = "";

        public virtual ICollection<Product> Products { get; set; }
    }
}
