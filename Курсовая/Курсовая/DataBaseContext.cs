﻿using Microsoft.EntityFrameworkCore;
using Курсовая.Models.UserModel;

namespace CourseWork
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
