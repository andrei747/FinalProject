using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MusicSchool.Areas.Admin.Models.DataDbContext
{
    public class MusicSchoolContext : DbContext
    {

        public MusicSchoolContext(DbContextOptions<MusicSchoolContext> options) : base(options)
        {



        }

        public DbSet<Courses> Courses { get; set; }
        public DbSet<Teachers> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)//metoda pt a creea date in DbSet<TEntity>
        
                
                                            // acestea pot fi instantiate mai departe
                                           //de asemenea se creeaza modul cum DB ar trebui create cu Migrations
         {
                modelBuilder.Entity<Courses>().HasData(

                    new Courses
                    {
                    
                        CourseName = "PianoCourses",
                        TeacherId = 1
                       
                    },
                    new Courses
                    {
                        
                        CourseName = "ViolinCourses",
                        TeacherId = 2
                        
                    },
                    new Courses
                    {
                        
                        CourseName = "GuitarCourses",
                        TeacherId = 3
                        
                    },
                    new Courses
                    {
                        
                        CourseName = "Canto",
                        TeacherId = 4
                        
                    }
                    );
            _ = modelBuilder.Entity<Teachers>().HasData(

               new Teachers
               {
                   TeacherId = 1,
                   FirstName = "Alexandra",
                   LastName = "Dariescu",
                   
                   ShortDescription = "Alexandra Dariescu este o pianistă solo de origine română.",
                   ImageUrl = "~/images/dariescu.jpg",
                   




               },
               new Teachers
               {
                   TeacherId = 2,
                   FirstName = "Alexandru",
                   LastName = "Tomescu",

                   ShortDescription = "Alexandru Tomescu (n. 15 septembrie 1976, București, România) este un violonist român,",
                   ImageUrl = "~/images/tomescu.jpg"

               },
               new Teachers
               {
                   TeacherId = 3,
                   FirstName = "Carlos",
                   LastName = "Santana",
                   
                   ShortDescription = " Carlos Santana născut la 20 iulie 1947 este un chitarist mexican și american. ",
                   ImageUrl = "~/images/santana.jpg"


               },
               new Teachers
               {
                   TeacherId = 4,
                   FirstName = "Irina",
                   LastName = "Rimes",
                   
                   ShortDescription = "Irina Rimes este o cântăreață și compozitoare din Republica Moldova ",
                   ImageUrl = "~/images/rimes.jpg"


               }

               );



    }   }

}
    
