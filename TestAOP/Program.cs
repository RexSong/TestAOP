using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Container;
using Microsoft.Practices.Unity.Configuration;
using Unity.Interception.ContainerIntegration;
using Microsoft.Practices.Unity.InterceptionExtension.Configuration;

namespace TestAOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer().LoadConfiguration();
            IProduct pro = container.Resolve<IProduct>();
            pro.Produce();
        }
    }
}
