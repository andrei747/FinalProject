using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicSchool.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        [ForeignKey("Courses")]
        public int CourseId { get; set; }


    }
}
