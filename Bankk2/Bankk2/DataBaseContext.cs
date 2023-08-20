using Bankk2.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using static System.Reflection.Metadata.BlobBuilder;

namespace Курсовая
{
    public class DataBaseContext:DbContext
    {
        public DbSet<DataUserS> DataUsers { get; set; }
        public DbSet<DaraCard> DataCard { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataUserS>().ToTable("DataUser");
            modelBuilder.Entity<DataUserS>()
                .HasKey(e => e.Email);

            modelBuilder.Entity<DaraCard>().ToTable("DataCard");
            modelBuilder.Entity<DaraCard>()
                .HasKey(e => e.UserEmail);
        }
    }
}
