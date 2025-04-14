using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

    public class ProductsController:Controller
    {
         List<Product> urunler = new List<Product>{
            new Product{
                productId = 1,
                productName = "Samsung S24 Ultra",
                productDetail = "Samsung S24 Ultra 512 GB SSD 16 GB RAM",
                productPrice = 70000,
                productImage = "tel-1.jpg",
                productIsStock = true,
                IsHome = true
                
            },
            new Product{
                productId = 2,
                productName = "Iphone 14 Pro",
                productDetail = "Iphone 14 Pro 512 GB SSD 16 GB RAM",
                productPrice = 120000,
                productImage = "tel-2.jpg",
                productIsStock = true,
                IsHome = true
            },
            new Product{
                productId = 3,
                productName = "Google Pixel 7",
                productDetail = "Google Pixel 7 128 GB SSD 8 GB RAM",
                productPrice = 60000,
                productImage = "tel-3.jpg",
                productIsStock = true,
                IsHome = false
            },
            new Product{
                productId = 4,
                productName = "Xiaomi 13 Pro",
                productDetail = "Xiaomi 13 Pro 256 GB SSD 12 GB RAM",
                productPrice = 50000,
                productImage = "tel-4.jpg",
                productIsStock = true,
                IsHome = false
            },
            new Product{
                productId = 5,
                productName = "Oppo Find X5 Pro",
                productDetail = "Oppo Find X5 Pro 256 GB SSD 12 GB RAM",
                productPrice = 40000,
                productImage = "tel-5.jpg",
                productIsStock = true,
                IsHome = false
            }
        };
        public ActionResult Index(){

     


            return View(urunler);
        }

        public ActionResult List(){
            
            return View(urunler);
        }

        public ActionResult Details(int id){

        Product? urun = urunler.Where(m => m.productId == id).FirstOrDefault(); 
  
        
        return View(urun);
        }

        public ActionResult Update(){
            return View();
        }

        
        
    }
