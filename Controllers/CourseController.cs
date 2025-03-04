using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

    public class CourseController : Controller
    {
        //localhost:5052/course
        //localhost:5052/course/index
        public string  Index()  //Index axtion methodu default olarak çağırılan bir methoddurprogram.cs içinde {action=Index} derken default olarak ındex olur
        {
            return "course/Index  veya  course/  sayfası";
        }

        
        //localhost:5052/course/list

        public string  List()
        {
            return "ben list sayfasıyım";
        }
        

        //localhost:5052/course/details
        public string  Details()
        {
            return "ben Details sayfasıyım";
        }
    }
