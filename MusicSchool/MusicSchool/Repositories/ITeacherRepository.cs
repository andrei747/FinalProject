using MusicSchool.Areas.Admin.Models;
using MusicSchool.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teachers = MusicSchool.Areas.Admin.Models.Teachers;

namespace MusicSchool.Repositories
{
    public interface ITeacherRepository
    {
        IEnumerable<Teachers> AllTeachers();

        Teachers GetTeachersById(int TeacherId);
        void CreateTeacher(Teachers newteachers);
        void DeleteTeacher(int TeacherId);
        void SaveChanges();
        



    }
}
