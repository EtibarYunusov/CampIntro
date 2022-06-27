using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.ProductName = "Apple";
            product.Price = 5;
            product.Description = "Apple of Guba";

            Product productTwo = new Product();
            productTwo.Id = 2;
            productTwo.ProductName = "Watermelon";
            productTwo.Price = 2;
            productTwo.Description = "Watermelon of Sabirabad";

            Product productThree = new Product();
            productThree.Id = 3;
            productThree.ProductName = "Lemon";
            productThree.Price = 5;
            productThree.Description = "Lemon of Astara";

            Product[] products = { product, productTwo, productThree };
            foreach (Product prod in products)
            {
                Console.WriteLine("\n"+prod.Id+" : "+prod.ProductName+" : "+prod.Price+" : "+prod.Description);
            }

            Console.WriteLine("--------------Methods--------------");
            WalletManager manager = new WalletManager();
            manager.AddProduct(product);
            manager.AddProduct(productTwo);
        }
    }
}
