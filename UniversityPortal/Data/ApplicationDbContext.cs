using Microsoft.EntityFrameworkCore;
using UniversityPortal.Models.Entities;

namespace UniversityPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { } // [cite: 1296]

        public DbSet<Student> Students { get; set; } // Represents the Students table [cite: 1308]
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}
