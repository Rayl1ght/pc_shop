namespace site.Models.Domain
{
    public class Order
    {
        public Guid Id { get; set; }

        public Guid? ClientID { get; set; }
        public Client? Client { get; set; }
        public Guid? EmployeeId { get; set; }
        public Employee? Employee { get; set; }

        public Guid? ProductId { get; set; }
        public Product? Product { get; set; }

        public string NumberContact { get; set; }
        public DateTime Data { get; set; }
    }
}
