using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicSchool.Repositories;

namespace MusicSchool.Controllers
{
    public class CoursesController : Controller
    {

        private ICoursesRepository coursesRepo;
        // GET: Courses

        public CoursesController(ICoursesRepository courseRepo)
        {
            coursesRepo = courseRepo;



        }
        public ActionResult Index()
        {



            return View();
        }
        public ActionResult IndexViolin()
        {



            return View();
        }
        public ActionResult IndexGuitar()
        {

             

            return View();
        }
        public ActionResult IndexCanto(int TeacherId)
        {
            var t1 = coursesRepo.GetCoursesById(TeacherId);
            if (t1 == null)
            {
                return NotFound();
            }

            return View(t1);
        }
        
    }
}