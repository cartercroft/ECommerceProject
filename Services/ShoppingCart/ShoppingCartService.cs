using ECommerceProject.Models;
using ECommerceProject.Services.Products;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.JSInterop;

namespace ECommerceProject.Services.ShoppingCart
{
    public class ShoppingCartService : IShoppingCartService
    {
        private IProductService _productService { get; set; }
        private ProtectedSessionStorage BrowserStorage { get; set; }
        public ShoppingCartService(IProductService productService, ProtectedSessionStorage browserStorage)
        {
            _productService = productService;
            BrowserStorage = browserStorage;
        }
        public List<Product> SelectedProducts { get; set; } = new();
        public Action OnChange { get; set; }
        public async Task AddProductToCart(int productId)
        {
            var product = await _productService.Get(productId);
            if (!SelectedProducts.Contains(product))
            {
                SelectedProducts.Add(product);
                await BrowserStorage.SetAsync("SelectedProducts", SelectedProducts);
            }
            OnChange.Invoke();
        }
        public async Task RemoveProductFromCart(int productId)
        {
            var product = await _productService.Get(productId);
            if (SelectedProducts.Contains(product))
            {
                SelectedProducts.Remove(product);
                await BrowserStorage.SetAsync("SelectedProducts", SelectedProducts);
            }
            OnChange.Invoke();
        }
        public async Task SetSelectedProducts(List<Product> products)
        {
            SelectedProducts = products;
            OnChange.Invoke();
        }
    }
}
