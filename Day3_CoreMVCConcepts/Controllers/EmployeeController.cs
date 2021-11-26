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
        //EmployeeRepository employeeRepository = new EmployeeRepository();
        IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository _employeeRepository)
        {
            employeeRepository = _employeeRepository;
        }


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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            employeeRepository.AddEmployee(employee);
            return RedirectToAction("Index");
        }

        public IActionResult GetEmployees([FromServices]IEmployeeRepository employeeRepository)
        {
            var employees = employeeRepository.GetEmployees();
            return View(employees);
        }
    }
}
