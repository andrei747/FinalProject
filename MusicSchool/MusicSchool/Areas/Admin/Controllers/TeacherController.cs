using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicSchool.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicSchool.Repositories;

namespace MusicSchool.Areas.Admin.Controllers
{
    
    [Area("Admin")]//atribut ce se pune inaintea oricarui controller din Area pt a se putea vedea in web
    public class TeacherController : Controller
    {
        private readonly ITeacherRepository _repository;//se injecteaza interfata din Repo potrivita in controller

        public TeacherController(ITeacherRepository repository)
        {
            _repository = repository;
        }

        // GET: Teachers
        public ActionResult Index()
        {
            return View(_repository.AllTeachers());///se apeleaza metoda din TeachersRepository pt a se putea vedea in web
        }

        // GET: Teachers/Details/5
        public ActionResult Details(int id)
        {
            var teacher = _repository.GetTeachersById(id);
            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        // GET: Teachers/Create
        [HttpGet]
        public ActionResult Create()
        {

            

            return View();
        }

        // POST: Teachers/Create
        [HttpPost, ActionName("Create")]      
        public ActionResult Create(Teachers newteachers) 
        {
            if (ModelState.IsValid)
            {
                _repository.CreateTeacher(newteachers);
                return RedirectToAction(nameof(Index));

            }
            
            return View(newteachers);
            
        
        }

        // GET: Teachers/Edit/5
        public ActionResult Edit(int id)
        {

            Teachers teachers = _repository.GetTeachersById(id);
            if (teachers == null)
            {
                return NotFound();
            }
            
            return View(teachers);
          
        }



         
        [HttpPost, ActionName("Edit")]
        public async Task<IActionResult> EditPost(int id)
        {
            var teacherToUpdate = _repository.GetTeachersById(id);
            bool isUpdated = await TryUpdateModelAsync<Teachers>(
                                     teacherToUpdate,
                                     "",
                                     c => c.TeacherId,
                                     c => c.FirstName,
                                     c => c.LastName,                                   
                                     c => c.ShortDescription,
                                     c => c.ImageUrl);
            if (isUpdated == true)
            {
                _repository.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
           
            return View(teacherToUpdate);

        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var teacher = _repository.GetTeachersById(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return View(teacher);
        }

        // POST: Teachers/Delete/5
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmation(int id)
        {
            _repository.DeleteTeacher(id);
            return RedirectToAction(nameof(Index));

             
        }
    }
}

      

    
