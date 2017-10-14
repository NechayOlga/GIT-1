using System;
using System.Text;
using System.Collections.Generic;

namespace ArrayConsistingOfRepeatingElements
{
  /// <summary>
  /// Class is for output arrays and messeges.
  /// </summary>
  class Outputer
  {
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
        StringBuilder ArrayNumber = new StringBuilder();
        ArrayNumber.Append(NUMBEROFARRAY);
        ArrayNumber.Append(i);
        Console.WriteLine(ArrayNumber);
        for (int j = 0; j < superArray[i].Length; j++)
        {
          StringBuilder ElementNumber = new StringBuilder();
          ElementNumber.Append(ELEMENTOFARRAY);
          ElementNumber.Append(j + " ");
          ElementNumber.Append(superArray[i][j]);
          Console.WriteLine(ElementNumber);
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
      foreach (double number in resultArray)
      {
        Console.WriteLine(number);
      }
    }
  }
}
