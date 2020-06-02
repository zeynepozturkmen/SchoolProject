using SchoolProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolProject.WebUI.Model
{
    public class TeacherRequestModel
    {
        public Teacher Teacher = new Teacher();
        public int TeacherId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}