using Day4_CoreViewModelApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day4_CoreViewModelApplication.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            DataRepository dataRepository= new DataRepository();
            return View(dataRepository.DataSource());
        }
    }
}
