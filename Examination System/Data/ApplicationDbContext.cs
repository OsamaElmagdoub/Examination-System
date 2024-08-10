using Examination_System.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Examination_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            ChangeTracker.QueryTrackingBehavior=QueryTrackingBehavior.NoTracking;
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course>  Courses  { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Exam> Quizzes { get; set; }
        public DbSet<Choice> Choices { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Result> ResultsEvaluation { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ExaminationSystem;trusted_connection = true;TrustServerCertificate=True")
                .LogTo(log=>Debug.WriteLine(log),LogLevel.Information)
                .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationShip in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationShip.DeleteBehavior = DeleteBehavior.Restrict;
            }

            
        }
        
    }
    
}
