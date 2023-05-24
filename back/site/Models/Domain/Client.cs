namespace site.Models.Domain
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public LinkedList<Order> Order { get; set; } = new();
    }
}
