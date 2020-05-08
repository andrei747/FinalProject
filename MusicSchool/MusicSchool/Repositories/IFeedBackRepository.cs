using MusicSchool.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSchool.Repositories
{
    public interface IFeedBackRepository
    {
        Courses GetCourses(int CourseId);
        void Save();


    }
}
