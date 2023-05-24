namespace site.Models.Domain
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public LinkedList<Order> Order { get; set; } = new();
    }
}
