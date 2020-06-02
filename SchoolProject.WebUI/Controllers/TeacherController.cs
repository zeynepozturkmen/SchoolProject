using SchoolProject.Business.IServices;
using SchoolProject.Entities.Models;
using SchoolProject.WebUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolProject.WebUI.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        private ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        public ActionResult Index()
        {
            return View(_teacherService.GetAllTeacher());
        }

        public ActionResult AddTeacher()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTeacher(TeacherRequestModel model)
        {
            var newTeacher = new Teacher();
            newTeacher.FullName = model.FullName;
            newTeacher.Email = model.Email;
            newTeacher.PhoneNumber = model.PhoneNumber;
            newTeacher.Address = model.Address;

            _teacherService.CreateTeacher(newTeacher);

            return RedirectToAction("Index");

        }

        [HttpPost]
        public JsonResult DeleteTeacher(int id)
        {
            var teacher = _teacherService.GetTeacherById(id);
            teacher.IsDeleted = true;
            if (teacher == null)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            _teacherService.UpdateTeacher(teacher);
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        public ActionResult UpdateTeacher(int id)
        {
            var model = new TeacherRequestModel();
            model.Teacher = _teacherService.GetTeacherById(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult UpdateTeacher(TeacherRequestModel model)
        {
            var findStudent = _teacherService.GetTeacherById(model.TeacherId);
            findStudent.FullName = model.FullName;
            findStudent.Email = model.Email;
            findStudent.PhoneNumber = model.PhoneNumber;
            findStudent.Address = model.Address;

            _teacherService.UpdateTeacher(findStudent);

            return RedirectToAction("Index");

        }
    }
}