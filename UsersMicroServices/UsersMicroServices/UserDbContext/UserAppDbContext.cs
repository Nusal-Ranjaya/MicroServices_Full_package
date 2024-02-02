using Microsoft.EntityFrameworkCore;
using UsersMicroServices.Entity;
namespace UsersMicroServices.UserDbContext
{
    public class UserAppDbContext : DbContext
    {
        public UserAppDbContext(DbContextOptions<UserAppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
