using System;

namespace TestAOP
{
    class Program
    {
        static void Main(string[] args)
        {
            DependencyResolver.Initialize();
            var m = DependencyResolver.For<IMaterial>();
            var pro = DependencyResolver.For<IProduct>();
            pro.Produce(m);
            Console.Read();
        }
    }
}
