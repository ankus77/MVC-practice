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
            //return x;
            return View("Index");
        }
        public ActionResult GetStudents()
        {
            var studentList = new List<StudentModel>();


            studentList.Add(new StudentModel() { StudentId = 1, StudentName = "my", StudentEmail = "xyz@emaill.com" });
            studentList.Add(new StudentModel() { StudentId = 2, StudentName = "my2", StudentEmail = "xyz2@emaill.com" });
            studentList.Add(new StudentModel() { StudentId = 3, StudentName = "my3", StudentEmail = "xyz2@emaill.com" });


            return View(studentList);
        }
        public ActionResult GetStudentById(int id)
        {
            var studentObj = new StudentModel();

            //
            var studentList = new List<StudentModel>();


            studentList.Add(new StudentModel() { StudentId = 1, StudentName = "my", StudentEmail = "xyz@emaill.com" });
            studentList.Add(new StudentModel() { StudentId = 2, StudentName = "my2", StudentEmail = "xyz2@emaill.com" });
            studentList.Add(new StudentModel() { StudentId = 3, StudentName = "my3", StudentEmail = "xyz2@emaill.com" });


            studentObj= studentList.Find(x => x.StudentId == id);
            //
            return View(studentObj);
        }
    }
}