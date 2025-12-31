using UniversityPortal.Models.Entities;

namespace UniversityPortal.ViewModel // Ensure this matches your other ViewModels
{
    public class ProfessorCoursesViewModel
    {
        public string ProfessorName { get; set; }
        public List<Course> AssignedCourses { get; set; }
    }
}