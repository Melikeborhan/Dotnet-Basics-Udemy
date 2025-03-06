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
            return View();
        }
        

        //localhost:5052/course/details
        public ActionResult  Details()
        {
            return View();
        }
    }
