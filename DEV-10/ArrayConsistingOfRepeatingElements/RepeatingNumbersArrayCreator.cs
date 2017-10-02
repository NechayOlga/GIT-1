using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConsistingOfRepeatingElements
{
    /// <summary>
    /// This class is for creating result array with numbers, which are the same in two
    /// or more arrays.
    /// </summary>
    class RepeatingNumbersArrayCreator
    {
        /// <summary>
        /// Method CreateRepeatingNumbersArray creates the array, which is consist 
        /// of values from all arrays, numbers which are equal with the set accuracy epsilon.
        /// </summary>
        /// <param name="superArray">the list, which contains all arrays</param>
        /// <returns>result array of real values</returns>
        public List<double> CreateRepeatingNumbersArray(List<double[]> superArray)
        {         
            List<double> repeatingNumbersArray = new List<double>();
            for (int i = 0; i < superArray.Count - 1; i++)
            {
                for(int j = 0; j < superArray[i].Length; j++)
                {
                    for (int l = i + 1; l < superArray.Count; l++)
                    {
                        const double epsilon = double.Epsilon;
                        int count = 0;
                        for (int k = 0; k < superArray[l].Length; k++)
                        {
                            if (Math.Abs(superArray[i][j] - superArray[l][k]) <= epsilon)
                            {
                                count++;
                                break;
                            }
                        }
                        if (count >= 1)
                        {
                            if(repeatingNumbersArray.Count == 0)
                            {
                                repeatingNumbersArray.Add(superArray[i][j]);
                                break;
                            }
                            else
                            {
                                for (int h = 0; h < repeatingNumbersArray.Count; h++)
                                {
                                    if (!(repeatingNumbersArray.Contains(superArray[i][j])))
                                    {
                                        repeatingNumbersArray.Add(superArray[i][j]);
                                        break;
                                    }
                                }
                            }                           
                        }                       
                    }
                }             
            }
            return repeatingNumbersArray;
        }
    }
}
