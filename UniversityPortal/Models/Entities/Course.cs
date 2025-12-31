namespace UniversityPortal.Models.Entities
{
    public class Course
    {
        public Guid Id { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int CreditHours { get; set; }
        public int Capacity { get; set; }

        // Relationship: One Professor manages the course
        public Guid ProfessorId { get; set; }
        public Professor Professor { get; set; }

        // Relationship: Many students can enroll
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
