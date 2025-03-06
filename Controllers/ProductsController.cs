using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

    public class ProductsController:Controller
    {
        //localhost:5052/home/index 
        public ActionResult Index(){
            return View();
        }

        public ActionResult List(){
            return View();
        }

        public ActionResult Details(){
            return View();
        }

        public ActionResult Update(){
            return View();
        }

        
        
    }
