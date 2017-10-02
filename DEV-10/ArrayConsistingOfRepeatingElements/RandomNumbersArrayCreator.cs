using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConsistingOfRepeatingElements
{
    /// <summary>
    /// Class is for creating the array of random real numbers.
    /// </summary>
    class RandomNumbersArrayCreator
    {
        const int MINSIZEVALUE = 1;
        const int MAXSIZEVALUE = 50;

        /// <summary>
        /// Method CreateArray creates array with
        /// random size and random elements.
        /// </summary>
        /// <param name="randomNumber">random value of array.</param>
        /// <param name="randomMemory">random size of array.</param>
        /// <returns>array with random size and random real values.</returns>
        public double[] CreateArray(Random randomNumber, Random randomSize)
        {
            double[] numbersArray = new double[randomSize.Next(MINSIZEVALUE, MAXSIZEVALUE)];
            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = randomNumber.NextDouble();
            }
            return numbersArray;
        }
    }
}
