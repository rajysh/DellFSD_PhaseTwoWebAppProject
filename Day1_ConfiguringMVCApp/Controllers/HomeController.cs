using Microsoft.AspNetCore.Mvc;

namespace Day1_ConfiguringMVCApp.Controllers
{
    public class HomeController : Controller
    {
        // https://localhost:44383/
        //https://localhost:44383/home/index
        
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult About()
        {
            return View();
        }

        public ViewResult Contact()
        {
            return View("ContactPage");
        }

        public ActionResult Privacy()
        {
            return RedirectToAction("Index");
        }

        //https://localhost:44383/home/about
        public string Message()
        {
            return "Message Action Method - Home Controller";
        }
    }
}
