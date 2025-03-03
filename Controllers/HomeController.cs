using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class HomeController:Controller //Controller daki özelliklerin HomeController a geçmesini sağladık.
{
    //localhost:5052/home
    //localhost:5052/home/about
    //localhost:5052/home/contact
    //localhost:5052/home/detail

    public string About()
    {
        return "about sayfasıyım";
    }

    public string Contact()
    {
        return "ben contact sayfasıyım";
    }
}