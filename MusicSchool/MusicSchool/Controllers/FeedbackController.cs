using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicSchool.Repositories;

namespace MusicSchool.Controllers
{
    public class FeedbackController : Controller
    {

        private readonly IFeedBackRepository _feedbackrepository;


        public FeedbackController(IFeedBackRepository  feedbackrepository) 
        {
            _feedbackrepository = feedbackrepository; 
        }
        // GET: Feedback
        public ActionResult Index()
        {


            return View();
        }

        // GET: Feedback/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Feedback/Create
        [HttpGet]
        public ActionResult Create()
        {



            return View();
        }

        // POST: Teachers/Create
        [HttpPost, ActionName("Create")]
        public ActionResult Create(Feedback newfeedback)
        {
            if (ModelState.IsValid)
            {
                _feedbackrepository.GetCourses(newfeedback);
                return RedirectToAction(nameof(Index));

            }

            return View(newfeedback);


        }

        // GET: Feedback/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Feedback/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Feedback/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Feedback/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}