using Microsoft.EntityFrameworkCore;
using Book.Models;
namespace Book
{
    public class DataBaseContext:DbContext
    {
        public DbSet<Books> book { get; set; }
        public DbSet<Author> author { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>().ToTable("Book");
            modelBuilder.Entity<Author>().ToTable("Author");
        }
    }
}
