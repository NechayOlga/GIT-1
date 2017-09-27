using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    class InvalidValueException:Exception
    {
        public InvalidValueException(string messege) : base(messege) { }
    }
}
