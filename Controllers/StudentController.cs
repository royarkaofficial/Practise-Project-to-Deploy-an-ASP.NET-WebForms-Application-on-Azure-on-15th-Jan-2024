using Microsoft.AspNetCore.Mvc;
using WebAppMVCDeploy.Models;

namespace WebAppMVCDeploy.Controllers
{
    public class StudentController : Controller
    {
        List<Student> student = new List<Student>()
        {
            new Student { Id = 1, Name = "Sam", Class = "8A", Age = 16, Address = "123SomeWhere"},
            new Student { Id = 2, Name = "Arun", Class = "8B", Age = 17, Address = "321 Some Street"},
            new Student { Id = 3, Name = "Arjun", Class = "8C", Age = 16, Address = "432 some where "},
        };
        public IActionResult Index()
        {
            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Student());
        }

        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (ModelState.IsValid)
            {
                student.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
