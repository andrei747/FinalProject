using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace MusicSchool.Areas.Admin.Models
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
        public string ShortDescription { get; set; }

        public string ImageUrl { get; set; }   
       
        public virtual Courses Courses { get; set; }
                      
    }
}
