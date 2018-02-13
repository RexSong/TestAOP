using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAOP
{
    public interface IProduct
    {
        [LoggingCallHandler(1)]
        void Produce();
    }
}
