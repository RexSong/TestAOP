using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAOP
{
    public class Product : IProduct
    {
        public void Produce()
        {
            System.Console.WriteLine("Product is produced");
        }
    }
}
