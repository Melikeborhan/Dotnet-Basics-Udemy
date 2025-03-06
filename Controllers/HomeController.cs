using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class HomeController:Controller //Controller daki özelliklerin HomeController a geçmesini sağladık.
{
    //localhost:5052/home/index      localhost:5052/ 
    public ActionResult Index()
    {
        return View();   //  View/Home/Index.cshtml
    }
    



//localhost:5052/home/about
    public ActionResult About()  //View/Home/About.cshtml
    {
        return View();
    }

//localhost:5052/home/contact
    public ActionResult Contact()   //View/Home/Contact.cshtml
    {
        return View();
    }
}