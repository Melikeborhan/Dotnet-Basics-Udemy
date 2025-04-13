using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;



    public class CourseController : Controller
    {
        
        //listeyi tekrar tekrar yazmank yerıne Listeyi en üstten tanımladık böylece hepsinin erişimi sağlanmıs oldu
        List<Course> kurslar = new List<Course>{
                new Course
                {
                    Title = "Javascript kursu",
                    Image = "tel-1.jpg",
                    IsActive = true,
                    IsHome = true
                },
                new Course
                {
                    Title = "React kursu",
                    Image = "tel-2.jpg",
                    IsActive = true,
                    IsHome = false                },
                new Course
                {
                    Title = "Javascript kursu",
                    Image = "tel-1.jpg",
                    IsActive = true,
                    IsHome = false
                },
                new Course
                {
                    Title = "React kursu",
                    Image = "tel-2.jpg",
                    IsActive = true,
                    IsHome = true                },
                new Course
                {
                    Title = "Javascript kursu",
                    Image = "tel-1.jpg",
                    IsActive = true,
                    IsHome = true
                },
                new Course
                {
                    Title = "React kursu",
                    Image = "tel-2.jpg",
                    IsActive = true,
                    IsHome = true                },
                new Course
                {
                    Title = "Javascript kursu",
                    Image = "tel-1.jpg",
                    IsActive = true,
                    IsHome = true
                },
                new Course
                {
                    Title = "React kursu",
                    Image = "tel-2.jpg",
                    IsActive = true,
                    IsHome = false                },
                new Course
                {
                    Title = "Javascript kursu",
                    Image = "tel-1.jpg",
                    IsActive = true,
                    IsHome = true
                },
                new Course
                {
                    Title = "React kursu",
                    Image = "tel-2.jpg",
                    IsActive = true,
                    IsHome = false               
                     },
                new Course
                {
                    Title = "Javascript kursu",
                    Image = "tel-1.jpg",
                    IsActive = true,
                    IsHome = true
                },
                new Course
                {
                    Title = "React kursu",
                    Image = "tel-2.jpg",
                    IsActive = true,
                    IsHome = false                }
            };

        public ActionResult  Index()  
        {
            

            return View(kurslar);
        }

        
        //localhost:5052/course/list

        public ActionResult  List()
        {
            
          




            return View(kurslar);
        }
        

        //localhost:5052/course/details
        public ActionResult  Details()
        {
            Course kurs1 = new Course(); //kurs1 nesnesı tanımladık
            
            kurs1.Title = "Django kursu";
            kurs1.Image = "1.jpg";
            kurs1.IsActive = true;


            return View(kurs1);
        }
    }
