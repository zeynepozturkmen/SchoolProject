using SchoolProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Business.IServices
{
    public interface IClassroomService
    {
        IEnumerable<Classroom> GetAllClassroom();
        Classroom GetClassroomById(int id);
        Classroom CreateClassroom(Classroom classroom);
        Classroom UpdateClassroom(Classroom classroom);
        void DeleteClassroom(int id);
    }
}
