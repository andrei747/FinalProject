using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicSchool.Models
{
    public class Teachers
    {
        [Key]
        public int TeacherId { get; set; }

        [StringLength(20, MinimumLength = 3)]
        public string FirstName { get; set; }

        [StringLength(20, MinimumLength = 5)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 7)]
        public string CourseName { get; set; }
        [Required]
        [StringLength(250, MinimumLength = 100)]
        public string ShortDescription { get; set; }

        public string ImageUrl { get; set; }


        public int CourseId { get; set; }

        public virtual Courses Cursuri { get; set; }




    }
}
