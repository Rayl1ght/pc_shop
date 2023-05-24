using site.Models.Domain;

namespace site.Models
{
    public class AddpRroductViewModel
    {


        public string Name { get; set; }
        public decimal Price { get; set; }
        public LinkedList<Order> Order { get; set; } = new();
    }
}
