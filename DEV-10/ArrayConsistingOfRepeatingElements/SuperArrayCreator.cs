using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConsistingOfRepeatingElements
{
    class SuperArrayCreator
    {
        /// <summary>
        /// The class SuperArrayCreator is for creating list of arrays, 
        /// which consit of random real values.
        /// </summary>
        const int MINVALUEOFN = 1;
        const int MAXVALUEOFN = 40;

        /// <summary>
        /// The method called CreateSuperArray creates the list,
        /// which consists of random quantity of arrays with random
        /// double values.
        /// </summary>
        /// <param name="randomValue">random quantity of arrays.</param>
        /// <param name="randomElement">element of concrete array </param>
        /// <param name="randomSize">size of array with random elements</param>
        /// <returns>the list, which consists of arrays with random real elements. </returns>
        public List<double[]> CreateSuperArray(Random randomValue, Random randomElement, Random randomSize)
        {
            int N = randomValue.Next(MINVALUEOFN, MAXVALUEOFN);
            List<double[]> superArray = new List<double[]>();
            RandomNumbersArrayCreator numbersArrayCreator = new RandomNumbersArrayCreator();                    
            for(int i = 0; i < N; i++)
            {
                superArray.Add(numbersArrayCreator.CreateArray(randomElement, randomSize));
            }
            return superArray;
        }
    }
}
