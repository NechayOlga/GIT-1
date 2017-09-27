using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class NotExistentTypeAverageTypeCommandException:Exception
    {
        public NotExistentTypeAverageTypeCommandException(string message) : base(message) { }
    }
}
