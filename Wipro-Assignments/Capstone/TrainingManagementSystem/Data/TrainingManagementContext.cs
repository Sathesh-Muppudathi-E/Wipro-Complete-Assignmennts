using Microsoft.EntityFrameworkCore;
using TrainingManagementSystem.Models;

namespace TrainingManagementSystem.Data
{
    public class TrainingManagementContext : DbContext
    {
        public TrainingManagementContext(DbContextOptions<TrainingManagementContext> options)
            : base(options)
        {
        }

        public DbSet<Batch> Batches { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your model here if needed
            base.OnModelCreating(modelBuilder);
        }
    }
}
