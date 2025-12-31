using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversityPortal.Data;
using UniversityPortal.ViewModel; // Fixed namespace

namespace UniversityPortal.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProfessorController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> MyCourses(Guid professorId)
        {
            var courses = await _context.Courses
                .Where(c => c.ProfessorId == professorId)
                .ToListAsync();

            var viewModel = new ProfessorCoursesViewModel // Simplified reference
            {
                ProfessorName = "Dr. Smith",
                AssignedCourses = courses
            };

            return View(viewModel);
        }
    }
}