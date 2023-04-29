using Microsoft.EntityFrameworkCore;

namespace AdventureWorkService.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }

        public DbSet<CustomerModel> Customers { get; set; }
    }
}
