using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class HomeController:Controller 
{
    
    public ActionResult Index()
    {
        int sayi1 = 10;
        int sayi2 = 20;

        int toplam = sayi1 + sayi2;

        ViewData["Toplam"] = toplam; //Toplam key toplam value değeridir Diğer index kısmında bu değeri göstermek için Toplam keyini kullanırız kullanıyoruz.
        return View();   
    }
    

    public ActionResult About()  
    {
        return View();
    }


    public ActionResult Contact()   
    {
        return View();
    }
}