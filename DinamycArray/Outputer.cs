using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamycArray
{
    class Outputer
    {
        public void Output(int[] array)
        {
            foreach (int numbers in array)
            {
                Console.Write(numbers + " ");
            }
        }
    }
}
