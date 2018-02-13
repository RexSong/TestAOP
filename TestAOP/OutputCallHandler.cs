using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Interception;
using Unity.Interception.PolicyInjection.Pipeline;

namespace TestAOP
{
    public class OutputCallHandler : ICallHandler
    {
        public int Order { get ; set; }

        public bool Before { get; set; }
        public bool After { get; set; }
        public string Message { get; set; }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            if (this.Before == true)
            {
                Console.WriteLine(this.Message);
            }
              
            IMethodReturn result = getNext()(input, getNext);
              
            if (result.Exception != null)
            {
                Console.Error.WriteLine(result.Exception.Message);
            }
            else
            {
                if(this.After == true)
                {
                    Console.WriteLine(this.Message);
                }
            }
            return (result);
        }
    }
}
