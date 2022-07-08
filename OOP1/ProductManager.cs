using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("ID {0} , Name {1}",product.ID,product.ProductName);
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " :  has been updated");
        }
    }
}
