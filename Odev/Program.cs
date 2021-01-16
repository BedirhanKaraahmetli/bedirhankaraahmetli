using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            Products product1 = new Products(); 
            product1.productName = "iPhone 12 Pro Max";
            product1.productDes = "Apple iPhone";
            product1.productPrice = 1299;

            Products product2 = new Products(); 
            product2.productName = "MacBook Pro 16inches";
            product2.productDes = "Apple MacBook";
            product2.productPrice = 2999;

            Products product3 = new Products(); 
            product3.productName = "AirPods Pro";
            product3.productDes = "Apple AirPods";
            product3.productPrice = 249;

            Products product4 = new Products(); 
            product4.productName = "iPad Pro ";
            product4.productDes = "Apple iPad";
            product4.productPrice = 799;

            Products[] productss = new Products[] 
            {
                product1, product2, product3, product4   
            };

            Console.WriteLine("----------Foreach----------"); //I write here with foreach 
            foreach (Products product in productss)
            {
                Console.WriteLine("Product Name : " +  product.productName);
                Console.WriteLine("Product Description : " + product.productDes);
                Console.WriteLine("Product Price : " +  product.productPrice + "$");
                Console.WriteLine("");
                Console.WriteLine("");
            }

            Console.WriteLine("----------For----------"); ////I write here with for
            for (int i = 0; i < productss.Length; i++)
            {
                Console.WriteLine("Product Name : " + productss[i].productName);
                Console.WriteLine("Product Description : " + productss[i].productDes);
                Console.WriteLine("Product Price : " + productss[i].productPrice + "$");
                Console.WriteLine("");
                Console.WriteLine("");
            }

            Console.WriteLine("----------While----------"); ////I write here with while 
            int b = 0;
            while (b < productss.Length)
            {
                Console.WriteLine("Product Name : " + productss[b].productName);
                Console.WriteLine("Product Description : " + productss[b].productDes);
                Console.WriteLine("Product Price : " + productss[b].productPrice + "$");
                Console.WriteLine("");
                Console.WriteLine("");
                b++;
            }   
        }
    }

    class Products 
    {
        public string productName { get; set; }
        public string productDes { get; set; }
        public int productPrice { get; set; }
    }
}
