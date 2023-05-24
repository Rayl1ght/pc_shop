using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using site.Models.Domain;
namespace site.Data
{
    public class MVCMagazinDbContext : DbContext
    {
        public MVCMagazinDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Order> Order { get; set; }

    }
}
