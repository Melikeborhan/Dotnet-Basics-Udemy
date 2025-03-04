using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class HomeController:Controller //Controller daki özelliklerin HomeController a geçmesini sağladık.
{
    //localhost:5052/home/index      localhost:5052/ 
    public string Index()
    {
        return "home/index veya home/ sayfası";
    }
    



//localhost:5052/home/about
    public string About()
    {
        return "about sayfasıyım";
    }

//localhost:5052/home/contact
    public string Contact()
    {
        return "ben contact sayfasıyım";
    }
}