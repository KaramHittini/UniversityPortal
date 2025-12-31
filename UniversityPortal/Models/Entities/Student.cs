namespace UniversityPortal.Models.Entities
{
    public class Student
    {
        public Guid Id { get; set; } //Auto generated unique Id
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }
    }
}
