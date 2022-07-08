using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PascalCase //camelCase
            Product product1 = new();
            product1.ID = 1;
            product1.CategoryID = 2;
            product1.ProductName = "Masa";
            product1.UniPrice = 500;
            product1.UnitsInStock = 3;

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
