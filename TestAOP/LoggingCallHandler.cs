using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Interception.PolicyInjection.Pipeline;

namespace TestAOP
{
    public class LoggingCallHandler : ICallHandler
    {
        public int Order { get; set; }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            //Before invoking
            WriteLog(String.Format("Invoking method {0} at {1}", input.MethodBase, DateTime.Now.ToLongTimeString()));

            var result = getNext().Invoke(input, getNext);

            //After invoking method
            if (result.Exception != null)
            {
                WriteLog(string.Format("Method {0} threw exception {1} at {2}", input.MethodBase, result.Exception.Message, DateTime.Now.ToLongTimeString()));
            }
            else
            {
                WriteLog(string.Format("Method {0} returned {1} at {2}", input.MethodBase, result.ReturnValue, DateTime.Now.ToLongTimeString()));
            }
            return result;
        }

        private void WriteLog(string message)
        {
            //do write log
            Console.WriteLine("Log: " + message);
        }
    }
}
