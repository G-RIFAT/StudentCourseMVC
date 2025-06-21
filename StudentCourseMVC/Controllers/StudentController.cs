using Microsoft.AspNetCore.Mvc;
using StudentCourseMVC.Data;
using StudentCourseMVC.Models;

namespace StudentCourseMVC.Controllers
{

    public class StudentController : Controller
    {
        StudenCourseDbContext _context;
        public StudentController(StudenCourseDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string statusFilter)
        {
            var students = _context.Students.ToList();

            if (!string.IsNullOrEmpty(statusFilter) && Enum.TryParse<StudentEntity.StatusEnum>(statusFilter, out var statusEnum))
            {
                students = students.Where(s => s.Status == statusEnum).ToList();
            }

            return View(students);
        }
        

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentCourseMVC.Models.StudentEntity student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }



    }
}
