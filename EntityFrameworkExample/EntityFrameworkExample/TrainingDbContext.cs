using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkExample.Entities;
using System.Reflection;


namespace EntityFrameworkExample
{
    public class TrainingDbContext:DbContext
    {
        readonly private string _connectionString;
        readonly private string _migrationAssembly;
        
        public TrainingDbContext()
        {
            _connectionString = @"Server = ASUS\SQLEXPRESS; Database = CSharp; Trusted_Connection = True"; ;
            _migrationAssembly = Assembly.GetExecutingAssembly().GetName().Name;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString, (x)=>x.MigrationsAssembly(_migrationAssembly));
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().ToTable("Topics");
            modelBuilder.Entity<CourseRegistration>().ToTable("CourseRegistration");
            //modelBuilder.Entity<CourseRegistration>().HasKey("CourseId", "StudentId");
            modelBuilder.Entity<CourseRegistration>().HasKey((x) => new { x.CourseId, x.StudentId });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get;set; }
    }
}
