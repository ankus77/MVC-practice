using FirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index1()
        {
            var x =new ContentResult();
            x.Content = "ankus nayak is a good boy";
            return x;
           // return View();
        }
        public ActionResult GetStudent()
        {
            var studentList = new List<StudentModel>();
            var studentObj = new StudentModel() { StudentId = 1, StudentName = "my", StudentEmail = "xyz@emaill.com" };
        
            
            studentList.Add(studentObj);
            return View(studentList);
        }
    }
}