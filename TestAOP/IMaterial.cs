using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAOP
{
    [LoggingCallHandler(1)]
    public interface IMaterial
    {
        bool Ready();
    }
}
