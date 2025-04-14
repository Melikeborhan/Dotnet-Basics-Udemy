namespace dotnet_basics.Models;

    public class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string productDetail { get; set; }
        public double productPrice { get; set; }
        public string productImage { get; set; }
        public bool  productIsStock { get; set; }

        public int StockPieces {get; set;}

        public bool IsHome { get; set; }
        
    }
