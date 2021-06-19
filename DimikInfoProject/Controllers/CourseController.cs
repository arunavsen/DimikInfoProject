using DimikInfoProject.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DimikInfoProject.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CourseController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            ViewBag.PageUrl = this.ControllerContext.RouteData.Values["controller"].ToString();

            return View();
        }


        public PartialViewResult CourseList()
        {
            ViewBag.PageUrl = this.ControllerContext.RouteData.Values["controller"].ToString();

            var courseList = _db.Courses.ToList();
            return PartialView(courseList);
        }

    }
}
