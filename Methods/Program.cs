using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Description = "Daily Apple";
            product1.Id = 13;

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 80;
            product2.Description = "Fres Watermelon";

            Product[] products = new Product[] { product1 , product2 };

            //type - safe -- tip güvenli
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Description);
                Console.WriteLine(product.Price);
                Console.WriteLine("--------------------");
            }
            Console.WriteLine("-----Methods-----");

            //instance - örnek
            //encapsulation

            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);
            
            

        }
    }
}
//Dont Repeat Yourself - DRY - Clean Code - Best Practice