namespace UniversityPortal.Models.Entities
{
    public class Enrollment
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }

        public Guid CourseId { get; set; }
        public Course Course { get; set; }

        public string? Grade { get; set; } // Nullable until graded
        public DateTime EnrollmentDate { get; set; }
    }
}
