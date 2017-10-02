using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConsistingOfRepeatingElements
{ 
    /// <summary>
    /// This class checks is the result array empty or not
    /// </summary>
    class ArrayChecker
    {
        /// <summary>
        /// Method checks the array on emptiness
        /// </summary>
        /// <param name="resultArray">the result array</param>
        /// <returns>bool checker - the result of checking: true, if it's empty, else false. </returns>
        public bool CheckArrayEmptiness(List<double> resultArray)
        {
            bool checker;
            if(resultArray.Count == 0)
            {
                checker = true;
            }
            else
            {
                checker = false;
            }
            return checker;
        }
    }
}
