using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // Add this line!
using UniversityPortal.Data;
using UniversityPortal.Models.Entities;
using UniversityPortal.ViewModel;

namespace UniversityPortal.Controllers
{
    public class PortalController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PortalController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var students = await _context.Students.ToListAsync(); // This now works
            return View(students);
        }

        // ... rest of your Create actions remain the same
    }
}
