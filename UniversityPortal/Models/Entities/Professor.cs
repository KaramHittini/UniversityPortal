namespace UniversityPortal.Models.Entities
{
    public class Professor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string OfficeHours { get; set; }

        // CHANGE THIS: Instead of string, use a collection for the relationship
        public ICollection<Course> Courses { get; set; }
    }
}