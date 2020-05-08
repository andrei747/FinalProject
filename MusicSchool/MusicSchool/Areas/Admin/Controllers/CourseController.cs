using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicSchool.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using MusicSchool.Repositories;

namespace MusicSchool.Areas.Admin.Controllers
{
    [Area("Admin")]//atribut ce se pune inaintea oricarui controller din Area pt a se putea vedea in web
    public class CourseController : Controller
    {

        private ICoursesRepository _coursesrepositories;//se injecteaza interfata din Repo potrivita in controller
        
        public CourseController(ICoursesRepository coursesRepository)
        {
            _coursesrepositories = coursesRepository;

           

        }

        // GET: Courses
        public ActionResult Index()//returnam prin actiunea Index toate cursurile 
        {
             
            
            return View(_coursesrepositories.AllCourses());//se apeleaza metoda din CoursesRepository si se transmit in View-ul aferent
        }

      

        // GET: Courses/Details/5
        public ActionResult Details(int id)
        {
            var course = _coursesrepositories.GetCoursesById(id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        [HttpGet]
        public ActionResult Create()
        {


            return View();
        }

        // POST: Courses/Create
        [HttpPost, ActionName("Create")]
        public ActionResult Create(Courses newcourses)
        {
            if (ModelState.IsValid)
            {
                _coursesrepositories.CreateCourse(newcourses);
                return RedirectToAction(nameof(Index));

            }

            return View(newcourses);

                
            
        }

        // GET: Courses/Edit/5
        public ActionResult Edit(int id)
        {
            Courses courses = _coursesrepositories.GetCoursesById(id);
            if (courses == null)
            {
                return NotFound();
            }

            return View(courses);
        }

        // POST: Courses/Edit/5
        [HttpPost, ActionName("Edit")]
        public async Task<IActionResult> EditPost(int id)
        {
            var courseToUpdate = _coursesrepositories.GetCoursesById(id);
            bool isUpdated = await TryUpdateModelAsync<Courses>(
                                     courseToUpdate,
                                     "",
                                     c => c.TeacherId,
                                     c => c.CourseName);
                                     
            if (isUpdated == true)
            {
                _coursesrepositories.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(courseToUpdate);

        }

        // GET: Courses/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var course = _coursesrepositories.GetCoursesById(id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }

        // POST: Teachers/Delete/5
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmation(int id)
        {
            _coursesrepositories.DeleteCourse(id);
            return RedirectToAction(nameof(Index));


        }
    }
}