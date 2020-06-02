using SchoolProject.Data.RepositoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IClassroomRepository Classroom { get; }
        IStudentRepository Student { get; }
        ITeacherRepository Teacher { get; }
        int Complete();
    }
}
