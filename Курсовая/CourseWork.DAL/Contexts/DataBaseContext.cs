using Microsoft.EntityFrameworkCore;
using CourseWork.DAL.Entities;

namespace CourseWork.DAL.DbContexts
{
    public class DataBaseContext : DbContext
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
