using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        StudentContext studentContext = new StudentContext();
        // GET: Student
        public ActionResult Details(string name)
        {
            //StudentContext studentContext = new StudentContext();
            Student student= studentContext.StudentList.Single(stud => stud.Name == name);            
            //
            return View(student);
        }
        public ActionResult Index()
        {
            StudentContext studentContext = new StudentContext();
            List<Student> student = studentContext.StudentList.ToList();
            return View(student);
        }
        [HttpPost]
        public ActionResult Register(Student stud)
        {
            StudentContext studentContext = new StudentContext();
            Student student = studentContext.StudentList.Add(stud);
            return View(student);
        }
       
        public ActionResult Register()
        {
            return View();
        }


        public ActionResult Show()
        {              
            
            return Json(studentContext.Employees.ToList(),JsonRequestBehavior.AllowGet);
        }
        
    }
}