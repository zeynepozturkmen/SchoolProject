using SchoolProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Business.IServices
{
    public interface ITeacherService
    {
        IEnumerable<Teacher> GetAllTeacher();
        Teacher GetTeacherById(int id);
        Teacher CreateTeacher(Teacher teacher);
        Teacher UpdateTeacher(Teacher teacher);
        void DeleteTeacher(int id);
    }
}
