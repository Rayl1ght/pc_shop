using site.Models.Domain;

namespace site.Models
{
    public class AddEmployeeViewModel
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public string Identifier { get; set; }
        public LinkedList<Order> Order { get; set; } = new();
    }
}
