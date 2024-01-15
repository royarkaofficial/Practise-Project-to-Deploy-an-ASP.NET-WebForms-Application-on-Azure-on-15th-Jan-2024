using Microsoft.AspNetCore.Mvc;
using WebAppMVCDeploy.Models;

namespace WebAppMVCDeploy.Controllers
{
    public class TeacherController : Controller
    {
        List<Teacher> teacher = new List<Teacher>()
        {
            new Teacher { Id = 1, Name = "Mr.Pysics", TeachingSubject = "Physics"},
            new Teacher { Id = 2, Name = "Mr.Biology", TeachingSubject = "Biology"},
            new Teacher { Id = 3, Name = "Mr.Maths", TeachingSubject = "Maths"},
        };
        public IActionResult Index()
        {
            return View(teacher);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Teacher());
        }

        [HttpPost]
        public IActionResult Create(Teacher model)
        {
            if (ModelState.IsValid)
            {
                teacher.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
