using SchoolProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolProject.WebUI.Model
{
    public class StudentRequestModel
    {
        public Student Student = new Student();
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int TeacherId { get; set; }
        public int ClassroomId { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<Classroom> Classrooms { get; set; }
    }
}