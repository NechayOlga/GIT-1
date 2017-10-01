using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConsistingOfRepeatingElements
{
    class NumbersArrayCreator
    {
        public double[] CreateArray(Random randomNumber, Random randomMemory)
        {
            double[] numbersArray = new double[randomMemory.Next(1, 10)];
            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = randomNumber.NextDouble();
            }
            return numbersArray;
        }
    }
}
