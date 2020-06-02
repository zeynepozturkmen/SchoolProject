using SchoolProject.Data.Context;
using SchoolProject.Data.RepositoryPattern.Interfaces;
using SchoolProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.RepositoryPattern.Repositories
{
    public class TeacherRepository:Repository<Teacher>,ITeacherRepository
    {
        public TeacherRepository(SchoolDbContext context):base(context)
        {

        }
    }
}
