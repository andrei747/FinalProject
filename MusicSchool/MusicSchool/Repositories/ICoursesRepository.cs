using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicSchool.Areas.Admin.Models;
using MusicSchool.Models;
using Courses = MusicSchool.Areas.Admin.Models.Courses;
namespace MusicSchool.Repositories
{
    public interface ICoursesRepository
    {

        IEnumerable<Courses> AllCourses();

        Courses GetCoursesById(int CourseId);
        void CreateCourse(Courses courses);
        void EditCourse(Courses courses);
        void DeleteCourse(int CourseId);
        void SaveChanges();
    }
}
