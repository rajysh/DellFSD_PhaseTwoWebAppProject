using Day3_CoreMVCConcepts.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day3_CoreMVCConcepts.Controllers
{
    public class EmployeeController : Controller
    {
        //public JsonResult Index()
        //{
        //    EmployeeRepository employeeRepository = new EmployeeRepository();
        //    var employees = employeeRepository.GetEmployees();

        //    return Json(employees);
        //}
        EmployeeRepository employeeRepository = new EmployeeRepository();
        public IActionResult Index()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            var employees = employeeRepository.GetEmployees();

            return View(employees);
        }

        public IActionResult Details(int employeeId)
        {
            var employee = employeeRepository.GetEmployeeId(employeeId);
            return View(employee);
        }
    }
}
