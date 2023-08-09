using Microsoft.EntityFrameworkCore;
using Users.Models;

namespace Users
{
    public class DBaseContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DBaseContext(DbContextOptions<DBaseContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<User>().ToTable("User");
        }
    }
}
