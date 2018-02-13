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
    public class LoggingCallHandlerAttribute : HandlerAttribute
    {
        private readonly int order;

        public LoggingCallHandlerAttribute(int order)
        {
            this.order = order;
        }
        public override ICallHandler CreateHandler(IUnityContainer container)
        {
            return new LoggingCallHandler() { Order = order };
        }
    }
}
