using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class NegativeQuantityException:Exception
    {
        public NegativeQuantityException(string message) : base(message) { }
    }
}
