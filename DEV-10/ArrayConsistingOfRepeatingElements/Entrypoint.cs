using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConsistingOfRepeatingElements
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Outputer outputer = new Outputer();
            Random randomValue = new Random();
            Random randomNumber = new Random();
            Random randomMemory = new Random();
            SuperArrayCreator superArrayCreator = new SuperArrayCreator();
            List<double[]> superArray = superArrayCreator.CreateSuperArray(randomValue, randomNumber, randomMemory);
            outputer.OutputInitialArrays(superArray);

            RepeatingNumbersArrayCreator repeatingNumbersVreator = new RepeatingNumbersArrayCreator();
            outputer.OutputResultArray(repeatingNumbersVreator.CreateRepeatingNumbersArray(superArray));
            Console.ReadKey();
        }
    }
}
