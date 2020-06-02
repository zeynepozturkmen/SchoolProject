using SchoolProject.Business.IServices;
using SchoolProject.Entities.Models;
using SchoolProject.WebUI.Model;
using SchoolProject.WebUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolProject.WebUI.Controllers
{
    public class ClassroomController : Controller
    {
        // GET: Classroom
        private IClassroomService _classroomService;
        public ClassroomController(IClassroomService classroomService)
        {
            _classroomService = classroomService;
        }
        public ActionResult Index()
        {
            return View(_classroomService.GetAllClassroom());
        }
        public ActionResult AddClassroom()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddClassroom(ClassroomRequestModel model)
        {
            var newClassroom = new Classroom();
            newClassroom.Name = model.ClassroomName;
            newClassroom.IsActive = model.IsActive;
            _classroomService.CreateClassroom(newClassroom);
            return RedirectToAction("Index");

        }

        [HttpPost]
        public JsonResult DeleteClassroom(int id)
        {
            var classroom = _classroomService.GetClassroomById(id);
            classroom.IsDeleted = true;
            if (classroom == null)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            _classroomService.UpdateClassroom(classroom);
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        public ActionResult UpdateClassroom(int id)
        {
            var model = new ClassroomRequestModel();
            model.Classroom = _classroomService.GetClassroomById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult UpdateClassroom(ClassroomRequestModel model)
        {
            var findClassroom = _classroomService.GetClassroomById(model.ClassroomId);
            findClassroom.Name = model.ClassroomName;
            findClassroom.IsActive = model.IsActive;

            _classroomService.UpdateClassroom(findClassroom);

            return RedirectToAction("Index");

        }
    }
}