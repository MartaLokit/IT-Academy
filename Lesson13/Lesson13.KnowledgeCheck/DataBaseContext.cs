using Lesson13.KnowledgeCheck.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson13.KnowledgeCheck
{
	public class DataBaseContext : DbContext
	{
		public DbSet<Product>products{get;set;}
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().ToTable("Products");
		}
	}
}
