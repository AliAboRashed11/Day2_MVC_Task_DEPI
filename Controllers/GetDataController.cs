using Day2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day2.Controllers
{
    public class GetDataController : Controller
    {
        DBContextCourse course = new DBContextCourse();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetallInstructor()
        {

            var Instructors = course.Instructors.Include(a => a.Course).Include(y => y.Department).ToList();
            return View("GetallInstructor", Instructors);
        }

        public IActionResult GetallTran()
        {
            ViewData["Name"] = "Ali";
            var Trainees = course.Trainees.Include(y => y.Department).ToList();
            return View("GetallTran", Trainees);
        }




        public IActionResult GetallInstId(int id)
        {
            ViewData["Name"] = "Instructor";
            var Instractor = course.Instructors.Include(a => a.Course).Include(y => y.Department).FirstOrDefault(a => a.Id == id);
            return View("GetallInstId", Instractor);
        }


        public IActionResult deleteId(int id)
        {


            var Instractor = course.Instructors.FirstOrDefault(a => a.Id==id);
            course.Instructors.Remove(Instractor);
            course.SaveChanges();

            return Content(" Instructor has deleted ");
        }

        public IActionResult AddInstructor(Instructor instructor)
        {


            course.Instructors.Add(instructor);

            course.SaveChanges();


            return Content(" Hellow worled ");
        }
        public IActionResult UpdateInstructor(int id)
        {

            var instructor = course.Instructors.Include(x => x.Course).Include(x => x.Department).FirstOrDefault(x => x.Id == id);

            course.SaveChanges();


            return Content(" Instructor has updated ");
        }

    }
}
