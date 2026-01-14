using Microsoft.EntityFrameworkCore;
using MySystem.Models;
using MySystem.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MySystem.Models.Students;
using static MySystem.Models.Course;


namespace MySystem.Database
{
     public class TaskDBContext: DbContext
    {
        public DbSet<Students> student { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<YearLevels> Year { get; set; }
        public DbSet<Course> courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(
                "server=localhost;database=dbTask;user=root;password=;",
                new MySqlServerVersion(new Version(8, 0, 34))
            );
        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>()
                .HasKey(s => s.stuID); // Configures StudentKey as the PK

            modelBuilder.Entity<YearLevels>()
               .HasKey(s => s.YearID);

            modelBuilder.Entity<Course>()
               .HasKey(s => s.CourseID);

            modelBuilder.Entity<Course>()
            .HasIndex(c => c.courseCode)
            .IsUnique();
        }

    }
}
