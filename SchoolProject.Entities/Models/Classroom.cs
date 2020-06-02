using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Entities.Models
{
    public class Classroom : BaseEntity
    {
        public Classroom()
        {
            Students = new List<Student>();
        }
        public string Name { get; set; }
        //Bir sınıfta birden fazla ögrenci olur.OneToMany relation
        public ICollection<Student> Students { get; set; }
    }
}
