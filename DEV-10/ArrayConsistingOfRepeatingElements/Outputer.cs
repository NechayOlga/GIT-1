using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConsistingOfRepeatingElements
{
    /// <summary>
    /// Class is for output arrays and messeges.
    /// </summary>
    class Outputer
    {
        const string EMPTYARRAY = "Result array is empty. There are no the same numbers in all arrays.";
        const string NUMBEROFARRAY = "Array number: ";
        const string ELEMENTOFARRAY = "Element number: ";
        const string RESULARRAY = "Result array: ";

        /// <summary>
        /// Method OutputInitialArray outputs 
        /// list of all created arrays.
        /// </summary>
        /// <param name="superArray">list which contains all arrays</param>
        public void OutputInitialArrays(List<double[]> superArray)
        {          
            for (int i = 0; i < superArray.Count; i++)
            {
                Console.Write(NUMBEROFARRAY);
                Console.WriteLine(i);
                for (int j = 0; j < superArray[i].Length; j++)
                {
                    Console.Write(ELEMENTOFARRAY);
                    Console.Write(j + " ");
                    Console.WriteLine(superArray[i][j]);
                }
                Console.WriteLine();
            }
        }
        
        /// <summary>
        /// Method ouputs result array,
        ///which consists of equal elements.
        /// </summary>
        /// <param name="resultArray">the result array</param>
        public void OutputResultArray(List<double> resultArray)
        {
            Console.WriteLine(RESULARRAY);
            foreach(double number in resultArray)
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// Method outputs the massege of emptiness of result array.
        /// </summary>
        public void OutputMessegeOfEmptiness()
        {
            Console.WriteLine(EMPTYARRAY);
        }
    }
}
