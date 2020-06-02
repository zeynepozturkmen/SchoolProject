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
    public class ClassroomRepository: Repository<Classroom>,IClassroomRepository
    {
        public ClassroomRepository(SchoolDbContext context):base(context)
        {

        }
    }
}
