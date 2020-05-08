using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicSchool.Areas.Admin.Models
{
    public class Courses 
    {
        [Key]
       [ForeignKey("Teachers")]
        public int TeacherId { get; set; }

        [Required]
        
        public string CourseName { get; set; }
       
        
        public Teachers Teacher { get; set; } 
        
    }
}
 