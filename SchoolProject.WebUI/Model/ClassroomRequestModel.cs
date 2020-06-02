using SchoolProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolProject.WebUI.Model
{
    public class ClassroomRequestModel
    {
        public Classroom Classroom { get; set; }
        public int ClassroomId { get; set; }
        public string ClassroomName { get; set; }
        public bool IsActive { get; set; }
    }
}