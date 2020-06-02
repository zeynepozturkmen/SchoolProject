using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Entities.Models
{
    public class Student : BaseEntity
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int TeacherId { get; set; }
        public int ClassroomId { get; set; }
        public Teacher Teacher { get; set; }
        public Classroom Classroom { get; set; }

    }
}
