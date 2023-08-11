namespace ECommerceProject.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public List<LineItem> Items { get; set; }
    }
}
