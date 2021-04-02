using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {

            Productt product1 = new Productt();
            product1.ProductName = "Phone";
            product1.Price = 500;
            product1.UnitsInStock = 150;

            Productt product2 = new Productt();
            product2.ProductName = "Computer";
            product2.Price = 1000;
            product2.UnitsInStock = 3520;

            Productt product3 = new Productt();
            product3.ProductName = "Playstation 5";
            product3.Price = 600;
            product3.UnitsInStock = 450;

            Productt product4 = new Productt();
            product4.ProductName = "Xbox One S";
            product4.Price = 400;
            product4.UnitsInStock = 550;


            Productt[] products = new Productt[] { 
            product1 , product2 , product3 , product4
            };

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName + " : " + product.Price + " : " + product.UnitsInStock);
                
            }

            Console.WriteLine("Sayfa Sonu*----------------------*");

            for (var i = 0; i < products.Length; i = i + 1)
            {
                Console.WriteLine(products[i].ProductName + " : " + products[i].Price + "  : " + products[i].UnitsInStock);
            }
            Console.WriteLine("Sayfa Sonu*----------------------*");

            int a = 0;
            while (a<products.Length)
            {
                Console.WriteLine(products[a].ProductName + " : " + products[a].Price + "  : " + products[a].UnitsInStock);
                a = a + 1;
            }


        }




        class Productt
        {
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public int UnitsInStock { get; set; }
            

        }


    }
}
