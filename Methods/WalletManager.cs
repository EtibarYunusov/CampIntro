using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class WalletManager
    {
        public void AddProduct(Product product)
        {
            Console.WriteLine("Product has added! : " + product.ProductName);
        }
    }
}
