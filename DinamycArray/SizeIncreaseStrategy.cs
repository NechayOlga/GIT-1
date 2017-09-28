using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamycArray
{
    class SizeIncreaseStrategy
    {
        public int TwoSizeIncrease(int[] array)
        {
            int size = array.Length;
            size = size * 2;
            return size;
        }
    }
}
