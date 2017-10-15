using System;
using System.Collections.Generic;

namespace ArrayConsistingOfRepeatingElements
{
  /// <summary>
  /// Class is for creating the array of random real numbers
  /// and super array of arrays, which contain random real numbers.
  /// </summary>
  class RandomNumbersArrayCreator
  {
    const int MINSIZEVALUE = 1;
    const int MAXSIZEVALUE = 50;
    const int MINVALUEOFN = 1;
    const int MAXVALUEOFN = 40;
    
    /// <summary>
    /// Method CreateArray creates array with
    /// random size and random elements.
    /// </summary>
    /// <param name="randomNumber">random value of array.</param>
    /// <param name="randomMemory">random size of array.</param>
    /// <returns>array with random size and random real values.</returns>
    public double[] CreateArray(Random randomNumber, Random randomSize)
    {
      double[] numbersArray = new double[randomSize.Next(MINSIZEVALUE, MAXSIZEVALUE)];
      for (int i = 0; i < numbersArray.Length; i++)
      {
        numbersArray[i] = randomNumber.NextDouble();
      }
      return numbersArray;
    }
    
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
      for (int i = 0; i < N; i++)
      {
        superArray.Add(CreateArray(randomElement, randomSize));
      }
      return superArray;
    }
  }
}
