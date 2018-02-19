using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAOP
{
    public class DependencyResolver
    {
        private static IWindsorContainer _container;

        //Initialize the container
        public static void Initialize()
        {
            _container = new WindsorContainer();
            //_container.Register(new ComponentRegistration());
            _container.Register(
                        Component.For<LoggingInterceptor>().LifeStyle.Transient,
                        Component.For<IMaterial>().ImplementedBy<Material>().LifeStyle.Transient,
                        Component.For<IProduct>().ImplementedBy<Product>().LifeStyle.Transient);
        }

        //Resolve types
        public static T For<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
