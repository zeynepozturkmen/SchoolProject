using Ninject.Modules;
using SchoolProject.Business.IServices;
using SchoolProject.Business.Services;
using SchoolProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Business.DependencyResolve
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>().InSingletonScope();
            Bind<IClassroomService>().To<ClassroomService>().InSingletonScope();
            Bind<IStudentService>().To<StudentService>().InSingletonScope();
            Bind<ITeacherService>().To<TeacherService>().InSingletonScope();
        }
    }
}
