using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication2.Models;

namespace WebApplication2
{
    /// <summary>
    /// Summary description for Handler1
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string name = context.Request.QueryString["name"];
            StudentContext studentContext = new StudentContext();
            Student student = studentContext.StudentList.Single(stud => stud.Name == name);
            Student[] student1 = studentContext.StudentList.ToArray();
            // List<Student> student = studentContext.StudentList.ToList();
            foreach (var item in student1)
            {
                context.Response.Write(item.Name);
            }
            context.Response.ContentType = "text/plain";
            context.Response.Write(student.Name + " " + student.Surname);
            
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}