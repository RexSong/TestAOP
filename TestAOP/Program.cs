using System;
using Unity;
using Unity.Interception.ContainerIntegration;
using Unity.Interception.Interceptors.InstanceInterceptors.InterfaceInterception;
using Microsoft.Practices.Unity.Configuration;

namespace TestAOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //var container = new UnityContainer().LoadConfiguration();
            var container = new UnityContainer();
            container.AddNewExtension<Interception>();
            container.RegisterType<IProduct, Product>();
            container.RegisterType<IMaterial, Material>();
            container.Configure<Interception>().SetInterceptorFor<IProduct>(new InterfaceInterceptor());
            container.Configure<Interception>().SetInterceptorFor<IMaterial>(new InterfaceInterceptor());
            
            IProduct pro = container.Resolve<IProduct>();
            IMaterial m = container.Resolve<IMaterial>();
            pro.Produce(m);
            Console.Read();
        }
    }
}
