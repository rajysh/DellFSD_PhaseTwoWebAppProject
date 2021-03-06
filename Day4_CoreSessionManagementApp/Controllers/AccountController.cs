using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day4_CoreSessionManagementApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if(username!=null && password!=null)
            {
                if(username.Equals("admin") && password.Equals("admin"))
                {
                    HttpContext.Session.SetString("uname", username);
                    //HttpContext.Session.SetString("pwd", password);
                    return View("Success");
                }
                else
                {
                    ViewBag.Error = "Invalid Credentials";
                    return View("Index");
                }
            }
            else
            {
                ViewBag.Error = "Enter your Credentials.";
                return View("Index");
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("uname");
            //HttpContext.Session.Clear();
            return View("Index");
        }
    }
}
