using SchoolProject.Business.IServices;
using SchoolProject.Data;
using SchoolProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Business.Services
{
    public class TeacherService: ITeacherService
    {
        private readonly IUnitOfWork _unitOfWork;
        public TeacherService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Teacher CreateTeacher(Teacher teacher)
        {
            _unitOfWork.Teacher.Add(teacher);
            return teacher;
        }

        public void DeleteTeacher(int id)
        {
            _unitOfWork.Teacher.Remove(id);

        }

        public IEnumerable<Teacher> GetAllTeacher()
        {
            return _unitOfWork.Teacher.GetAll();
        }

        public Teacher GetTeacherById(int id)
        {
            return _unitOfWork.Teacher.GetById(id);
        }

        public Teacher UpdateTeacher(Teacher teacher)
        {
            _unitOfWork.Teacher.Update(teacher);
            return teacher;
        }
    }
}

