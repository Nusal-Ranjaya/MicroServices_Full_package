using Microsoft.EntityFrameworkCore;
using Products.Entity;
using System.Security.Cryptography.X509Certificates;
namespace Products.ProductDbContext
{
    public class ProductAppDbContext : DbContext
    {
        public ProductAppDbContext(DbContextOptions<ProductAppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> products { get; set; }
    }
}
