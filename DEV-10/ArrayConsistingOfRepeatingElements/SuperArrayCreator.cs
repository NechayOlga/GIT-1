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
        public List<double[]> CreateSuperArray(Random randomValue, Random randomNumber, Random randomMemory)
        {
            int N = randomValue.Next(1, 20);
            List<double[]> superArray = new List<double[]>();
            NumbersArrayCreator numbersArrayCreator = new NumbersArrayCreator();                    
            for(int i = 0; i < N; i++)
            {
                superArray.Add(numbersArrayCreator.CreateArray(randomNumber, randomMemory));
            }
            return superArray;
        }
    }
}
