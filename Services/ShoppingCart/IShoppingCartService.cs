using ECommerceProject.Models;

namespace ECommerceProject.Services.ShoppingCart
{
    public interface IShoppingCartService
    {
        public List<Product> SelectedProducts { get; set; }
        public Action OnChange { get; set; }
        public Task AddProductToCart(int productId);
        public Task RemoveProductFromCart(int productId);
        public Task SetSelectedProducts(List<Product> products);
    }
}
