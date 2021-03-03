using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Identity.Entities
{
    public class CustomerContext : IdentityDbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options)
           : base(options)
        {
        }

         public DbSet<Customer> Customers { get; set; }
    }
}