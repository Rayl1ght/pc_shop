using site.Models.Domain;

namespace site.Models
{
    public class AddClientViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        public LinkedList<Order> Order { get; set; } = new();
    }
}
