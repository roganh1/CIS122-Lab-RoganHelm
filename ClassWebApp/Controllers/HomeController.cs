using Microsoft.AspNetCore.Mvc;
using ClassWebApp.Models;

namespace ClassWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Student aStudent1 = new Student();
            Student aStudent2 = new Student();
            Student aStudent3 = new Student();
            List<Student> aListOfStudents = new List<Student>();

            aStudent1.FirstName = "Anna";
            aStudent1.LastName = "Brown";

            aStudent2.FirstName = "John";
            aStudent2.LastName = "Johnson";

            aStudent3.FirstName = "Bob";
            aStudent3.LastName = "Dole";

            aListOfStudents.Add(aStudent1);
            aListOfStudents.Add(aStudent2);
            aListOfStudents.Add(aStudent3);

            ViewBag.ListOfStudents = aListOfStudents;

            return View();
        }
    }
}
