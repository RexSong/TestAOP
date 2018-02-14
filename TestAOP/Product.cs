using Microsoft.Practices.ObjectBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAOP
{
    public class Product : IProduct
    {
        [InjectionMethod]
        public void Produce(IMaterial m)
        {
            if (m.Ready())
            {
                System.Console.WriteLine("Product is produced");
            }
            else
            {
                System.Console.WriteLine("Product is not produced");
            }
            
        }
    }
}
