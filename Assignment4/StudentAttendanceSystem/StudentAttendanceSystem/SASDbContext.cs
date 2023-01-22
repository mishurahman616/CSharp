using Microsoft.EntityFrameworkCore;
using StudentAttendanceSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceSystem
{
    public class SASDbContext:DbContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssembly;
        public SASDbContext()
        {
            _connectionString = "Server=ASUS\\SQLEXPRESS;Database=SAS;Trusted_Connection=True;encrypt=false";
            _migrationAssembly = Assembly.GetExecutingAssembly().GetName().Name;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString, x => x.MigrationsAssembly(_migrationAssembly));
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Schedule>().ToTable("Schedules");
            modelBuilder.Entity<CourseRegistration>().ToTable("CourseRegistrations");
            modelBuilder.Entity<CourseRegistration>().HasKey((x) => new {x.CourseId, x.StudentId});
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
    }
}
