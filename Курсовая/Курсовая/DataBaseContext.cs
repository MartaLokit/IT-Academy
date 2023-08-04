using Microsoft.EntityFrameworkCore;
using Курсовая.Models.UserModel;
using static System.Reflection.Metadata.BlobBuilder;

namespace Курсовая
{
    public class DataBaseContext:DbContext
    {
        public DbSet<DataUser> DataUsers { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataUser>().ToTable("DataUser");
            modelBuilder.Entity<DataUser>()
                .HasKey(e => e.ID);

        }
    }
}
