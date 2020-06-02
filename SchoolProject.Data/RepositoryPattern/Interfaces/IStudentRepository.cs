using SchoolProject.Data.Context;
using SchoolProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.RepositoryPattern.Interfaces
{
    public interface IStudentRepository: IRepository<Student>
    {
    }
}
