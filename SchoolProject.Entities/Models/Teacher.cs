using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Entities.Models
{
    public class Teacher : BaseEntity
    {
        public Teacher()
        {
            Students = new List<Student>();
        }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
