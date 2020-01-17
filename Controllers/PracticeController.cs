using FirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class PracticeController : Controller
    {
        // GET: Practice
        public ActionResult IndexPractice()
        {
            return View();
        }
        public ActionResult GetEmployee()
        {
            var empList = new List<Test1>();
            empList.Add(new Test1() { EmpId = 1, EmpName = "ankus nayak", EmpPhoneNumber="100",EmpProjectId=1 });
            empList.Add(new Test1() { EmpId = 2, EmpName = "ankan nayak", EmpPhoneNumber = "101", EmpProjectId = 2 });
            empList.Add(new Test1() { EmpId = 3, EmpName = "sumita nayak", EmpPhoneNumber = "102", EmpProjectId = 1 });
            empList.Add(new Test1() { EmpId = 4, EmpName = "arun nayak", EmpPhoneNumber = "103", EmpProjectId = 2 });
            return View(empList);
        }
        public ActionResult GetEmployeeById(int n)
        {
            var empObject = new Test1();
            var empList = new List<Test1>();
            empList.Add(new Test1() { EmpId = 1, EmpName = "ankus nayak", EmpPhoneNumber = "100", EmpProjectId = 1 });
            empList.Add(new Test1() { EmpId = 2, EmpName = "ankan nayak", EmpPhoneNumber = "101", EmpProjectId = 2 });
            empList.Add(new Test1() { EmpId = 3, EmpName = "sumita nayak", EmpPhoneNumber = "102", EmpProjectId = 1 });
            empList.Add(new Test1() { EmpId = 4, EmpName = "arun nayak", EmpPhoneNumber = "103", EmpProjectId = 2 });
            empObject = empList.Find(x => x.EmpId == n);
            return View(empObject);

        }
    }
}