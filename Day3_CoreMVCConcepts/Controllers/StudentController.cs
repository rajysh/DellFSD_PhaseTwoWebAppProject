using Day3_CoreMVCConcepts.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Day3_CoreMVCConcepts.Controllers
{
    public class StudentController : Controller
    {

        public static List<Student> students = new List<Student>()
        {
            new Student(){ StudentId = 101, Name = "Kartik Sharma", City = "Delhi", Gender = "Male"},
            new Student(){ StudentId = 102, Name = "Gautami Bhalla", City = "Mumbai", Gender = "Female"},
            new Student(){ StudentId =103, Name = "John Smith", City = "Delhi", Gender = "Male"},
            new Student(){ StudentId = 104, Name = "Queen Kochhar", City = "Mumbai", Gender = "Female"},
            new Student(){ StudentId = 105, Name = "Roger Lee", City = "Delhi", Gender = "Male"}
        };

        public IActionResult Index()
        {
            ViewBag.Message = "Student Management System";
            ViewBag.StudentCount = students.Count;
            ViewBag.StudentList = students;
            return View();
        }


        public IActionResult Details()
        {
            if(ViewData["Message"] == null)
                ViewData["Message"] = "New Message";
            else
                ViewData["Message"] = ViewData["Message"];
            
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "About";
            ViewData["StudentCount"] = students.Count;
            ViewData["StudentList"] = students;
            ViewBag.Message = "Student Management System";

            return View();
        }

        public IActionResult Info()
        {
            TempData["Message"] = "Info Page - Student Management System";
            TempData["StudentCount"] = students.Count;
            TempData["StudentList"] = students;
            ViewBag.Message = "Student Management System";

            return View();
        }


        public IActionResult RequestA()
        {
            //TempData["Msg"] = "Hello World";
            //    return RedirectToAction("RequestB");

            TempData["Msg"] = "Hello World";
            return View();
        }

        public IActionResult RequestB()
        {
            //if (TempData["Msg"] as string != null)
            //    return View();
            //return RedirectToAction("Index");

            if (TempData["Msg"] as string != null)
            {
                TempData["Msg"] = TempData["Msg"];
                return View();

            }
            else
                return RedirectToAction("Index");
        }
    }
}
