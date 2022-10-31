using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using OpenACSVFile.Models;

namespace OpenACSVFile.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            FileGateway aGateway = new FileGateway();
            try
            {
                List<Person> aListOfPeople = aGateway.GetPeople("C:/Users/wacky/Downloads/Names.csv");
            }catch(FileNotFoundException ex)
            {
                ViewBag.Error = "You chose the wrong File, please try again";
                List<Person> aListOfPeople = new List();
            }
            ViewBag.ListOfPeople = aListOfPeople;
            finally
            {
                return View();
            }
        }
    }
}
