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

            //AYRI AYRI TANIMLAMA
            // string courseName1 = "js kursu";
            // string courseName2 = "React kursu";
            // string courseImage1 = "1.jpg";
            //string courseImage2 = "2.jpg";



            // string courseDetail1 = "js kursu açıklama";
            // string courseDetail2 = "React kursu açıklama";




            //DİZİ OLUŞTURARAK TANIMLAMA

            string[] courseNames = ["js kursu","React kursu"];
            string[] courseDetails = ["js kursu açıklama","React kursu açıklama"];
            string[] courseImages = ["course-img-1.jpg","course-img-2.jpg"];



            //DİZİ ELEMANLARINA ERİŞİM
            ViewData["courseName1"] = courseNames[0]; //js kursu
            ViewData["courseName2"] = courseNames[1]; //React kursu

            ViewData["courseDetail1"] = courseDetails[0]; //js kursu açıklama
            ViewData["courseDetail2"] = courseDetails[1]; //React kursu açıklama

            ViewData["courseImage1"] = courseImages[0];//course-img-1.jpg
            ViewData["courseImage2"] = courseImages[1];//course-img-2.jpg



            
            






            return View();
        }
        

        //localhost:5052/course/details
        public ActionResult  Details()
        {
            // string courseName = "Django kursu";

             int courseTime = 40;

            // bool courseIsOnline  = true;

            //bu sekılde dızı ıcıne alarak model kısmında su sekılde cagırırız:@Model[0]
            string[] courseNames = ["js kursu","React kursu"];

            //ya da bunu da ekleyerek model kısmında su sekılde cagırabılırız:@ViewData["courseTime"]
            ViewData["courseTime"] = courseTime;
            return View(courseTime);


            //return View("Details", courseName); //burada 2. parametrede belırtmemız gereklı Details adındaki cshtml sayfasına courseName  ısmınde bır tane string (obje)model gonderıyor demiş oluruz.

            // return View(courseTime); //burada modeli int olarak tanımladığımız için direkt  1. parametreden göndermemiz yeterlidir
        
            // return View(courseIsOnline);

            //return View(courseNames);

        
        
        
        }
    }
