using site.Models.Domain;

namespace site.Models
{
    public class UpdateProductViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string DeliveryTime { get; set; }
        public LinkedList<Order> Order { get; set; } = new();
    }
}
