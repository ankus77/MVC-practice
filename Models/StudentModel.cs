using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstWebApp.Models
{
    public class StudentModel
    {
        [Display(Name = "Student Roll")]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }

    }
}