using MusicSchool.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using MusicSchool.Areas.Admin.Models.DataDbContext;
using Microsoft.EntityFrameworkCore;

namespace MusicSchool.Repositories
{
    public class CoursesRepository :ICoursesRepository
    {

        private readonly MusicSchoolContext _musicSchoolContext;

        public CoursesRepository(MusicSchoolContext musicSchoolContext)//injectam in Repo Dbcontext
        {
            _musicSchoolContext = musicSchoolContext;
        }

        public IEnumerable<Courses> AllCourses()//metoda se afiseaza in controller-ul Courses
        {
           
            return _musicSchoolContext.Courses.Include(c => c.Teacher).ToList();//se returneaza toate cursurile intr-o lista

        }


        public void CreateCourse(Courses newcourses)
        {
            _musicSchoolContext.Add(newcourses);
            _musicSchoolContext.SaveChanges();
        }

        public void DeleteCourse(int CourseId)
        {
            var course = _musicSchoolContext.Courses.SingleOrDefault(c => c.CourseId == CourseId);
            _musicSchoolContext.Courses.Remove(course);
            _musicSchoolContext.SaveChanges();
        }

        public void EditCourse(Courses courses)
        {
            throw new NotImplementedException();
        }

        public Courses GetCoursesById(int CourseId)
        {
            return _musicSchoolContext.Courses.FirstOrDefault(c => c.CourseId == CourseId); 
        }

        public void SaveChanges()
        {
            _musicSchoolContext.SaveChanges();
        }



    }
}
