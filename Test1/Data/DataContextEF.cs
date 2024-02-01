using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using Test1.Models;

namespace Test1.Data
{
    class DataContextEF : DbContext
    {
        public DbSet<Computer>? Computer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(@"Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=True;
                Trusted_Connection=false;User Id=sa;Password=SQLConnect1;",
                options => options.EnableRetryOnFailure());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TutorialAppSchema");
            //modelBuilder.Entity<Computer>().ToTable("Computer", "TutorialAppSchema");

            //If we don't have any primary key
            //modelBuilder.Entity<Computer>().ToTable("Computer").HasNoKey();

            //To set primary key
            modelBuilder.Entity<Computer>().ToTable("Computer").HasKey(c => c.ComputerId);
        }


    }
}