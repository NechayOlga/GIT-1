using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConsistingOfRepeatingElements
{
    class Outputer
    {
        public void OutputInitialArrays(List<double[]> superArray)
        {          
            for (int i = 0; i < superArray.Count; i++)
            {
                Console.Write("Array number: ");
                Console.WriteLine(i);
                for (int j = 0; j < superArray[i].Length; j++)
                {
                    Console.Write("Element number: ");
                    Console.Write(j + " ");
                    Console.WriteLine(superArray[i][j]);
                }
                Console.Write("***************************");
                Console.WriteLine();
            }
        }
        
        public void OutputResultArray(List<double> resultArray)
        {
            Console.WriteLine("Result array: ");
            foreach(double number in resultArray)
            {
                Console.WriteLine(number);
            }
        }
    }
}
