using _MaksKorz.Models;
using Microsoft.EntityFrameworkCore;

namespace _MaksKorz
{
    public class DataBaseContext:DbContext
    {
        public DbSet<Album> albums { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().ToTable("Album");
        }
    }
}
