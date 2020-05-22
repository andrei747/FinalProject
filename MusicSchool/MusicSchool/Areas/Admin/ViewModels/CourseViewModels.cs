using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSchool.Areas.Admin.ViewModels
{
    public class CourseViewModels
    {

        [Required]
        public string CourseName { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string ShortDescription { get; set; }

        public string ImageUrl { get; set; }



    }
}
