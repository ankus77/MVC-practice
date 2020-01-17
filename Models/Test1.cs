using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstWebApp.Models
{
    //create a data class
    public class Test1
    {
        [Display(Name="Employee Id")]
         public int EmpId { get; set; }
        [Display(Name ="Employee Name")]
        public string EmpName { get; set; }
        [Display(Name ="Mobile Number")]
        public string EmpPhoneNumber { get; set; }
        [Display(Name ="Project Id")]
        public int EmpProjectId { get; set; }


    }
}