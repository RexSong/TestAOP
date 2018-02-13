using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Interception.PolicyInjection.Pipeline;
using Unity.Interception.PolicyInjection.Policies;

namespace TestAOP
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public class OutputCallHandlerAttribute : HandlerAttribute
    {
        public bool Before { get; set; }
        public bool After { get; set; }
        public String Message { get; set; }

        public OutputCallHandlerAttribute(string message)
        {
            this.Message = message;
        }

        public override ICallHandler CreateHandler(IUnityContainer container)
        {
            return (new OutputCallHandler() { After = this.After, Before = this.Before, Message = this.Message });
        }
    }
}
