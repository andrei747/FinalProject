using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicSchool.Areas.Admin.Models
{
    public class FeedBack
    {
        [Key]
        public int Id { get; set; }

        public int CourseId { get; set; }

        public Courses courses { get; set; }
    }
}
