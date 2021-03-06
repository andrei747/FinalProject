﻿using System;
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
        public int CourseId { get; set; }
         
        [Required]
        
        public string CourseName { get; set; }
        [ForeignKey("Teachers")]
        public virtual Teachers Teacher { get; set; }
       
    }
}
 