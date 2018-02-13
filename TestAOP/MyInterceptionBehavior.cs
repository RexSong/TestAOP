using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;

namespace TestAOP
{
    public class MyInterceptionBehavior : IInterceptionBehavior
    {
        public bool WillExecute => true;

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Type.EmptyTypes;
        }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            //before Invoke method

            if (input.MethodBase == typeof(IProduct).GetMethod("Produce"))
            {
                //do something
            }
            //method invoking
            IMethodReturn methodReturn = getNext().Invoke(input, getNext);

            //after method invoke
            return methodReturn;
        }

        
    }
}
