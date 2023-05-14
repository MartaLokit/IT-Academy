using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library
{
	public class DataBaseContext:DbContext
	{
		public DbSet<Book> book { get; set; }
        public DbSet<Author> author { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options)
        {
            
        }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Book>().ToTable("Book");
			modelBuilder.Entity<Author>().ToTable("Author");
		}
	}
}
