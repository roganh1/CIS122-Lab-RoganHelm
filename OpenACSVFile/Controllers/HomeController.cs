using Microsoft.AspNetCore.Mvc;
using OpenACSVFile.Models;

namespace OpenACSVFile.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            FileGateway aGateway = new FileGateway();
            List<Person> aListOfPeople = aGateway.GetPeople("C:/Users/wacky/Downloads/Names.csv");
            ViewBag.ListOfPeople = aListOfPeople;
            return View();
        }
    }
}
