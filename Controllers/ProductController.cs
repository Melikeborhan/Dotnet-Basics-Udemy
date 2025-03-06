using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

    public class ProductController:Controller
    {
        //localhost:5052/home/index 
        public string Index(){
            return "localhost:5052/products   veya  localhost:5052/products/Index ";
        }

        public string List(){
            return "localhost:5052/products/list";
        }

        public string Details(){
            return "localhost:5052/products/details";
        }

        public string Update(){
            return "localhost:5052/products/update";
        }

        
        
    }
