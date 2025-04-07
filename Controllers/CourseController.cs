using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;



    public class CourseController : Controller
    {
        //localhost:5052/course
        //localhost:5052/course/index
        public ActionResult  Index()  //Index axtion methodu default olarak çağırılan bir methoddurprogram.cs içinde {action=Index} derken default olarak ındex olur
        {
            return View();
        }

        
        //localhost:5052/course/list

        public ActionResult  List()
        {
            // Course kurs1 = new Course();

            // kurs1.Title = "Javascript kursu";
            // kurs1.Image = "tel-1.jpg";

            // Course kurs2 = new Course();
            // kurs2.Title = "React kursu";
            // kurs2.Image = "tel-2.jpg";


            // //Course[] kurslar = [kurs1,kurs2];

            // List<Course> kurslar = new List<Course>{
            //     kurs1,kurs2
            // }; //List kurslar adında bir liste tanımladık



            //yukarıda uzun uzun yazmak yerıne su yontemle de yazılabılır
            List<Course> kurslar = new List<Course>{
                new Course
                {
                    Title = "Javascript kursu",
                    Image = "tel-1.jpg",
                    IsActive = true
                },
                new Course
                {
                    Title = "React kursu",
                    Image = "tel-2.jpg",
                    IsActive = false
                }
            };




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
