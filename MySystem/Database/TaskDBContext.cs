using Microsoft.EntityFrameworkCore;
using MySystem.Forms;
using MySystem.Models;
using MySystem.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MySystem.Models.Course;
using static MySystem.Models.students;
using static MySystem.Models.Class;

namespace MySystem.Database
{
     public class TaskDBContext: DbContext
    {
        public DbSet<students> student { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<YearLevels> Year { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Class> Classes { get;set;}
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
        public DbSet<ClassSubject> ClassSubjects { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(
                "server=localhost;database=schooldb;user=root;password=;",
                new MySqlServerVersion(new Version(8, 0, 34))
            );
        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<students>()
                .HasKey(s => s.StudentID); // Configures StudentKey as the PK

            modelBuilder.Entity<YearLevels>()
               .HasKey(s => s.YearID);

            modelBuilder.Entity<Course>()
               .HasKey(s => s.CourseID);

            modelBuilder.Entity<Course>()
            .HasIndex(c => c.courseCode)
            .IsUnique();

            modelBuilder.Entity<students>()
            .ToTable("students");

            modelBuilder.Entity<Teachers>()
            .HasIndex(c => c.TeacherID)
            .IsUnique();

            modelBuilder.Entity<Class>()
              .HasIndex(c => c.ClassID)
              .IsUnique();

            modelBuilder.Entity<StudentClass>()
                .HasIndex(sc => new { sc.StudentID, sc.ClassID })
                .IsUnique();

            modelBuilder.Entity<ClassSubject>()
                .HasIndex(cs => new { cs.ClassID, cs.SubjectID })
                .IsUnique();
        }


    }
}
