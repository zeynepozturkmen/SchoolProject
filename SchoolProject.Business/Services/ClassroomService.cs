using SchoolProject.Business.IServices;
using SchoolProject.Data;
using SchoolProject.Data.Context;
using SchoolProject.Data.RepositoryPattern.Interfaces;
using SchoolProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Business.Services
{
    public class ClassroomService : IClassroomService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ClassroomService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Classroom CreateClassroom(Classroom classroom)
        {
            _unitOfWork.Classroom.Add(classroom);
            _unitOfWork.Complete();
            return classroom;
        }

        public void DeleteClassroom(int id)
        {
            _unitOfWork.Classroom.Remove(id);

        }

        public IEnumerable<Classroom> GetAllClassroom()
        {
            return _unitOfWork.Classroom.GetAll();
        }

        public Classroom GetClassroomById(int id)
        {
            return _unitOfWork.Classroom.GetById(id);
        }

        public Classroom UpdateClassroom(Classroom classroom)
        {
            _unitOfWork.Classroom.Update(classroom);
            return classroom;
        }
    }
}
