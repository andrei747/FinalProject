using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicSchool.Models
{
    public class Courses
    {

        [Key]
        public int CourseId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 7)]
        public string CourseName { get; set; }

        public string Description { get; set; }

        public virtual Feedback Feedback { get; set; }
    }
}
