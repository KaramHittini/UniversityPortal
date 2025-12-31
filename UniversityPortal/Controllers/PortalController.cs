using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddStudentViewModel viewModel)
        {
            var student = new Student
            {
                Id = Guid.NewGuid(),
                Name = viewModel.Name,
                Email = viewModel.Email,
                Department = viewModel.Department
            };
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
