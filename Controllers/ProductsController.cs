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

            //Samsung S24 Ultra
            //Samsung S24 Ultra 512 GB SSD 16 GB RAM
            //70.000 TL
            //tel-1.jpg

            string productName = "Samsung S24 Ultra";
            string productDetail = "Samsung S24 Ultra 512 GB SSD 16 GB RAM";
            double productPrice =  70000 ;
            string productImage = "tel-1.jpg";
            bool  productIsStock = true;


            ViewData["ProductName"] = productName;
            ViewData["ProductDetail"] = productDetail;
            ViewData["ProductPrice"] = productPrice;
            ViewData["ProductImage"] = productImage;
            ViewData["ProductIsStock"] = productIsStock;



            return View();
        }

        public ActionResult Update(){
            return View();
        }

        
        
    }
