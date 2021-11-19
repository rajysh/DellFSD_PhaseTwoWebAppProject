using Day2_ConfiguringMVCWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Day2_ConfiguringMVCWebApp.Controllers
{
    public class StudentController : Controller
    {
        public static List<Student> students = new List<Student>()
        {
            new Student(){ Id = 101, Name = "Kartik Sharma", City = "Delhi", Gender = "Male"},
            new Student(){ Id = 102, Name = "Gautami Bhalla", City = "Mumbai", Gender = "Female"},
            new Student(){ Id =103, Name = "John Smith", City = "Delhi", Gender = "Male"},
            new Student(){ Id = 104, Name = "Queen Kochhar", City = "Mumbai", Gender = "Female"},
            new Student(){ Id = 105, Name = "Roger Lee", City = "Delhi", Gender = "Male"}
        };
    
        public IActionResult Index()
        {
            ViewBag.Message = "Student Management System";
            ViewBag.StudentCount = students.Count;
            ViewBag.StudentList = students;
            return View();
        }
    }
}
