using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

    public class ProductsController:Controller
    {
        //localhost:5052/home/index 
        public ActionResult Index(){

            string[] kurslar = {"js kursu","react kursu"};


            return View(kurslar);
        }

        public ActionResult List(){
             List<Product> urunler = new List<Product>{
            new Product{
                productName = "Samsung S24 Ultra",
                productDetail = "Samsung S24 Ultra 512 GB SSD 16 GB RAM",
                productPrice = 70000,
                productImage = "tel-1.jpg",
                productIsStock = true
            },
            new Product{
                productName = "Iphone 14 Pro",
                productDetail = "Iphone 14 Pro 512 GB SSD 16 GB RAM",
                productPrice = 120000,
                productImage = "tel-2.jpg",
                productIsStock = true
            },
        };
            return View(urunler);
        }

        public ActionResult Details(){

        Product product1 = new();

        product1.productName = "Samsung S24 Ultra";
        product1.productDetail = "Samsung S24 Ultra 512 GB SSD 16 GB RAM";
        product1.productPrice = 70000;
        product1.productImage = "tel-1.jpg";
        product1.productIsStock = false;
        product1.StockPieces = 100;
  
        
        return View(product1);
        }

        public ActionResult Update(){
            return View();
        }

        
        
    }
