using Castle.Core;
using Castle.DynamicProxy;
using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAOP
{
    public class ComponentRegistration : IRegistration
    {
        public void Register(IKernelInternal kernel)
        {
            kernel.Register(
                Component.For<IInterceptor>()
                    .ImplementedBy<LoggingInterceptor>().Named("myloginterceptor"));
            kernel.Register(
                Component.For<IMaterial>()
                         .ImplementedBy<Material>());
            kernel.Register(
                Component.For<IProduct>()
                         .ImplementedBy<Product>());
        }
    }
}
