using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class NotExistentCommandException : Exception
    {
        public NotExistentCommandException(string message) : base(message) { }
    }
}
