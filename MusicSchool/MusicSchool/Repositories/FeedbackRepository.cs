using MusicSchool.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using MusicSchool.Areas.Admin.Models.DataDbContext;
using Microsoft.EntityFrameworkCore;
using MusicSchool.Models;

namespace MusicSchool.Repositories
{
    public class FeedbackRepository : IFeedBackRepository
    {

        private MusicSchoolContext _FeedbackContext;
        public FeedbackRepository (MusicSchoolContext FeedbackContext) 
        {
           _FeedbackContext = FeedbackContext;//se injecteaza datele in parametrul musicSchoolContext
        }
        public Areas.Admin.Models.Courses GetAllCourses(int CourseId)
        {
            return _FeedbackContext.Courses.FirstOrDefault(c => c.CourseId == CourseId);
        }
          
        public void GetFeedbacks(Feedback newfeedback)
        {
           _FeedbackContext.Add(newfeedback);
            _FeedbackContext.SaveChanges();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
