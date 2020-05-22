using MusicSchool.Areas.Admin.Models;
using MusicSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Courses = MusicSchool.Areas.Admin.Models.Courses;

namespace MusicSchool.Repositories
{
    public interface IFeedBackRepository
    {
        Courses GetAllCourses(int CourseId);
        void GetFeedbacks(Feedback newfeedback);
        void Save();
       
    } 
}
