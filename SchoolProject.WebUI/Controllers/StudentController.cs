using SchoolProject.Business.IServices;
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
        public StudentController(IStudentService service)
        {

            _studentservice = service;
        }
        public ActionResult Index()
        {

            return View(_studentservice.GetAllStudent());
        }

        public ActionResult AddStudent()
        {
            
            return View();
        }

    }
}