using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamycArray
{
    class Inputer
    {
        string[] array = Console.ReadLine().Split();
        public int[] NumbersArray()
        {
            int[] numbersArray = new int [array.Length];
            for(int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = int.Parse(array[i]);
            }
            return numbersArray;
        }
        public int InputNumber()
        {
            int number = int.Parse(Console.ReadLine());
            return number;
        }
    }
}
