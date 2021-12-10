using Day5_CoreCodeFirstApproachApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Day5_CoreCodeFirstApproachApp.Controllers
{
    public class CompanyController : Controller
    {
        //ApplicationDBContext context = new ApplicationDBContext();
        ApplicationDBContext context;
        public IActionResult Index()
        {
            var companies = context.Companies.ToList();
            return View(companies);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Company company)
        {
            context.Add(company);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Details(int id)
        {
            //var company = context.Companies.Find(id);
            var company = context.Companies.Where(c => c.CompanyId == id).FirstOrDefault();
            return View(company);
        }

        public IActionResult Edit(int id)
        {
            //var company = context.Companies.Find(id);
            var company = context.Companies.Where(c => c.CompanyId == id).FirstOrDefault();

            return View(company);
        }

        [HttpPost]
        public IActionResult Edit(Company company)
        {
            context.Update(company);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var company = context.Companies.Find(id);
            return View(company);
        }

        [HttpPost]
        public IActionResult Delete(Company company)
        {
            var companyObj = context.Companies.Find(company.CompanyId);
            context.Remove(companyObj);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
