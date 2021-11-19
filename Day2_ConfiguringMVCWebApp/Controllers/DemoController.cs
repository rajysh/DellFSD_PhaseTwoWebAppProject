using Microsoft.AspNetCore.Mvc;

namespace Day2_ConfiguringMVCWebApp.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
