using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecruitment
{
  public class NumberOfEmployeesGenerator
  {
    public List<List<int>> placementOfNumbers = new List<List<int>>();
    public List<List<int>> ForFour(int number)
    {
      for (int i = 0; i < (number / 4) + 1; i++)
      {
        for (int j = i; j < ((number - i) / 3) + 1; j++)
        {
          for(int k = j; k < ((number - j) / 2) +1; k++)
          {
            placementOfNumbers.Add(new List<int> { i, j, k, (number - i - j - k) });
            placementOfNumbers.Add(new List<int> { (number - i - j - k), k, j, i });
          }     
        }
      }
      return placementOfNumbers;
    }
  }
}

