using System;
using System.Collections.Generic;

namespace ArrayConsistingOfRepeatingElements
{
    /// <summary>
    /// Class contains the entry point of program.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// First the object of type SuperArrayCreator is created.
        /// Then the method to create list of double[] calls.
        /// Output super array.
        /// The object of RepeatingNumbersArrayCreator class is created.
        /// The method of class ArrayCheck calls and checking of emptiness of result array takes place.
        /// If result array is empty, the massege of its emptiness outputs,
        /// else the result array outputs.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Outputer outputer = new Outputer();
                Random randomValue = new Random();
                Random randomNumber = new Random();
                Random randomSize = new Random();
                SuperArrayCreator superArrayCreator = new SuperArrayCreator();
                List<double[]> superArray = superArrayCreator.CreateSuperArray(randomValue, randomNumber, randomSize);
                outputer.OutputInitialArrays(superArray);

                RepeatingNumbersArrayCreator repeatingNumbersVreator = new RepeatingNumbersArrayCreator();

                ArrayChecker arrayChecker = new ArrayChecker();
                bool checker = arrayChecker.CheckArrayEmptiness(repeatingNumbersVreator.CreateRepeatingNumbersArray(superArray));
                if (checker == true)
                {

                    outputer.OutputMessegeOfEmptiness();
                }
                else
                {
                    outputer.OutputResultArray(repeatingNumbersVreator.CreateRepeatingNumbersArray(superArray));
                }
                Console.ReadKey();
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("It's memory exception.");
            }
        }
    }
}
