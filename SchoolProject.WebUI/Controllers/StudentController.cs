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
    public class StudentController : Controller
    {
        private IStudentService _studentservice;
        private ITeacherService _teacherService;
        private IClassroomService _classroomService;
        public StudentController(IStudentService service, ITeacherService teacherService, IClassroomService classroomService)
        {
            _studentservice = service;
            _teacherService = teacherService;
            _classroomService = classroomService;
        }
        public ActionResult Index()
        {
            return View(_studentservice.GetAllStudent());
        }

        public ActionResult AddStudent()
        {
            var model = new StudentRequestModel();
            model.Teachers = _teacherService.GetAllTeacher();
            model.Classrooms = _classroomService.GetAllClassroom();
            return View(model);
        }
        [HttpPost]
        public ActionResult AddStudent(StudentRequestModel model)
        {
            var newStudent = new Student();
            newStudent.ClassroomId = model.ClassroomId;
            newStudent.TeacherId = model.TeacherId;
            newStudent.FullName = model.FullName;
            newStudent.Email = model.Email;
            newStudent.PhoneNumber = model.PhoneNumber;
            newStudent.Address = model.Address;

            _studentservice.CreateStudent(newStudent);

            return RedirectToAction("Index");

        }

        [HttpPost]
        public JsonResult DeleteStudent(int id)
        {
            var student = _studentservice.GetStudentById(id);
            student.IsDeleted = true;
            if (student == null)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            _studentservice.UpdateStudent(student);
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        public ActionResult UpdateStudent(int id)
        {
            var model = new StudentRequestModel();
            model.Student= _studentservice.GetStudentById(id);
            model.Teachers = _teacherService.GetAllTeacher();
            model.Classrooms = _classroomService.GetAllClassroom();

            return View(model);
        }

        [HttpPost]
        public ActionResult UpdateStudent(StudentRequestModel model)
        {
            var findStudent = _studentservice.GetStudentById(model.StudentId);
            findStudent.ClassroomId = model.ClassroomId;
            findStudent.TeacherId = model.TeacherId;
            findStudent.FullName = model.FullName;
            findStudent.Email = model.Email;
            findStudent.PhoneNumber = model.PhoneNumber;
            findStudent.Address = model.Address;

            _studentservice.UpdateStudent(findStudent);

            return RedirectToAction("Index");

        }
    }
}