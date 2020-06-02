using SchoolProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Context
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext() : base("SchoolDbContext")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }

    }
}
