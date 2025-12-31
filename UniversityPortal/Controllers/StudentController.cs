using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversityPortal.Data;
using UniversityPortal.Models.Entities;

namespace UniversityPortal.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // List all available courses
        public async Task<IActionResult> Registration()
        {
            var courses = await _context.Courses.Include(c => c.Professor).ToListAsync();
            return View(courses);
        }
        public async Task<IActionResult> MySchedule(Guid studentId)
        {
            var enrollments = await _context.Enrollments
                .Include(e => e.Course)
                .ThenInclude(c => c.Professor)
                .Where(e => e.StudentId == studentId)
                .ToListAsync();

            return View(enrollments);
        }

        [HttpPost]
        public async Task<IActionResult> Register(Guid courseId, Guid studentId)
        {
            // Simple registration logic
            var enrollment = new Enrollment
            {
                Id = Guid.NewGuid(),
                StudentId = studentId,
                CourseId = courseId,
                EnrollmentDate = DateTime.Now
            };

            _context.Enrollments.Add(enrollment);
            await _context.SaveChangesAsync();

            return RedirectToAction("MySchedule");
        }
    }
}
