using System.Collections.Generic;

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
      return (resultArray.Count == 0);
    }
  }
}
