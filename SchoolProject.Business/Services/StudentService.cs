using SchoolProject.Business.IServices;
using SchoolProject.Data;
using SchoolProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Business.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public StudentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
             
        }
        public Student CreateStudent(Student student)
        {
            student.Teacher = _unitOfWork.Teacher.GetById(student.TeacherId);
            student.Classroom = _unitOfWork.Classroom.GetById(student.ClassroomId);
            _unitOfWork.Student.Add(student);
            _unitOfWork.Complete();
            return student;
        }

        public void DeleteStudent(int id)
        {
            _unitOfWork.Student.Remove(id);
            _unitOfWork.Complete();

        }

        public IEnumerable<Student> GetAllStudent()
        {
            return _unitOfWork.Student.Where(x=>!x.IsDeleted).ToList();
        }

        public Student GetStudentById(int id)
        {
            return _unitOfWork.Student.GetById(id);
        }

        public Student UpdateStudent(Student student)
        {
            student.Teacher = _unitOfWork.Teacher.GetById(student.TeacherId);
            student.Classroom = _unitOfWork.Classroom.GetById(student.ClassroomId);
            _unitOfWork.Student.Update(student);
            _unitOfWork.Complete();
            return student;
        }
    }
}
