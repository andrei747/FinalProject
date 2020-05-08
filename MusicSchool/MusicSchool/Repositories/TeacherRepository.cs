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
   
        public class TeacherRepository : ITeacherRepository//luam metodele din interfata si le implementam aici
        {
            private MusicSchoolContext _musicSchoolContext;//injectam in Repo MusicDbcontext

            public TeacherRepository(MusicSchoolContext musicSchoolContext)
            {
                _musicSchoolContext = musicSchoolContext;//se injecteaza datele in parametrul musicSchoolContext
            }

            public IEnumerable<Teachers> AllTeachers()//metoda se aplica in controller-ul Teachers
            {

                return _musicSchoolContext.Teachers.ToList();//se returneaza toti profesorii intr-o lista

            }



            public void CreateTeacher(Teachers newteachers)
            {


                _musicSchoolContext.Add(newteachers);
                _musicSchoolContext.SaveChanges();

            }

            public void DeleteTeacher(int TeacherId)
            {
            var teacher = _musicSchoolContext.Teachers.SingleOrDefault(c => c.TeacherId == TeacherId);
            _musicSchoolContext.Teachers.Remove(teacher);
            _musicSchoolContext.SaveChanges();
        }



            public Teachers GetTeachersById(int TeacherId)
            {
                return _musicSchoolContext.Teachers.FirstOrDefault(t => t.TeacherId == TeacherId);
            }

          

            public void SaveChanges()
            {
                _musicSchoolContext.SaveChanges();
            }


        }
    
}
