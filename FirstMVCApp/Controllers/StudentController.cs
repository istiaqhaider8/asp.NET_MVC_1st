using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public string SayHello()
        {
            return "<h1>Hello Asp.NET MVC</h2>";
        }

        static List<Student> students = new List<Student>();

        public string Entry(Student student)
        {
            students.Add(student);
            return "Name: "+student.Name+ " Email: " + student.Email + " RegNo: " + student.RegNo + " Entry";
        }

        public string Search(int RegNo)
        {
            var studnet = students.Where(c => c.RegNo == RegNo).FirstOrDefault();

            var message = "Here No Data";

            if(studnet != null)
            {
                message = "Student Search Result(S)..............<br/>";
                message += "Name: " + studnet.Name + " Email: " + studnet.Email + " RegNo: " + studnet.RegNo + "";
            }
            return message;

        }

       
    }
}