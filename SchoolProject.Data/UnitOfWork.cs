using SchoolProject.Data.Context;
using SchoolProject.Data.RepositoryPattern.Interfaces;
using SchoolProject.Data.RepositoryPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private SchoolDbContext _schoolDbContext;
   
        public UnitOfWork(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
            Student = new StudentRepository(_schoolDbContext);
            Teacher = new TeacherRepository(_schoolDbContext);
            Classroom = new ClassroomRepository(_schoolDbContext);
        }
        public IClassroomRepository Classroom{ get; private set; }

        public IStudentRepository Student { get; private set; }

        public ITeacherRepository Teacher { get; private set; }

        public int Complete()
        {
           return _schoolDbContext.SaveChanges();
        }

        public void Dispose()
        {
            _schoolDbContext.Dispose();
        }
    }
}
