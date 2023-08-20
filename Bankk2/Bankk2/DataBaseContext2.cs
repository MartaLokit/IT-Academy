using Bankk2.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using static System.Reflection.Metadata.BlobBuilder;

namespace Курсовая
{
    public class DataBaseContext2:DbContext
    {
        public DbSet<DaraCard> DataCard { get; set; }
        public DataBaseContext2(DbContextOptions<DataBaseContext2> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DaraCard>().ToTable("DataCard");
            modelBuilder.Entity<DaraCard>()
                .HasKey(e => e.UserEmail);
        }
    }
}
