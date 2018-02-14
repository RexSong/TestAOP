using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAOP
{
    public class Material : IMaterial
    {
        public bool Ready()
        {
            var r = new Random();
            var num = r.Next(100);
            if (num > 50)
            {
                return true;
            }
            return false;
        }
    }
}
