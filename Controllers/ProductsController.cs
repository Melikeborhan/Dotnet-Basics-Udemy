using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

    public class ProductsController:Controller
    {
         List<Product> urunler = new List<Product>{
            new Product{
                productName = "Samsung S24 Ultra",
                productDetail = "Samsung S24 Ultra 512 GB SSD 16 GB RAM",
                productPrice = 70000,
                productImage = "tel-1.jpg",
                productIsStock = true,
                IsHome = true
                
            },
            new Product{
                productName = "Iphone 14 Pro",
                productDetail = "Iphone 14 Pro 512 GB SSD 16 GB RAM",
                productPrice = 120000,
                productImage = "tel-2.jpg",
                productIsStock = true,
                IsHome = true
            },
            new Product{
                productName = "Google Pixel 7",
                productDetail = "Google Pixel 7 128 GB SSD 8 GB RAM",
                productPrice = 60000,
                productImage = "tel-3.jpg",
                productIsStock = true,
                IsHome = false
            },
            new Product{
                productName = "Xiaomi 13 Pro",
                productDetail = "Xiaomi 13 Pro 256 GB SSD 12 GB RAM",
                productPrice = 50000,
                productImage = "tel-4.jpg",
                productIsStock = true,
                IsHome = false
            },
            new Product{
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
