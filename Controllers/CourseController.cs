using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

    public class CourseController : Controller
    {
        //localhost:5052/course
        //localhost:5052/course/list

        public string  List()
        {
            return "ben list sayfasıyım";
        }
    }
