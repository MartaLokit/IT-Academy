using Bankk2.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using static System.Reflection.Metadata.BlobBuilder;

namespace Курсовая
{
    public class DataBaseContext:DbContext
    {
        public DbSet<DataUserS> DataUsers { get; set; }
        public 
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataUserS>().ToTable("DataUserS");
            modelBuilder.Entity<DataUserS>()
                .HasKey(e => e.Email);
        }
    }
}
