using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecruitment
{
  class Counter
  {
    List<List<int>> placementOfTwoNumber = new List<List<int>>();
    public List<List<int>> ForTwo(int number)
    {
      for (int i = 0; i <= number; i++)
      {
        placementOfTwoNumber.Add(new List<int> { i, number - i });
      }
      return placementOfTwoNumber;
    }

    public List<List<int>> ForThree(int number)
    {
      for (int i = 0; i < (number / 3) + 1; i++)
      {
        for (int j = i; j < ((number - i) / 2) + 1; j++)
        {
          placementOfTwoNumber.Add(new List<int> { i, j, (number - i - j) });
          placementOfTwoNumber.Add(new List<int> { (number - i - j), j, i });
        }
      }
      return placementOfTwoNumber;
    }

    public List<List<int>> ForFour(int number)
    {
      for (int i = 0; i < (number / 4) + 1; i++)
      {
        for (int j = i; j < ((number - i) / 3) + 1; j++)
        {
          for(int k = j; k < ((number - j) / 2) +1; k++)
          {
            placementOfTwoNumber.Add(new List<int> { i, j, k, (number - i - j - k) });
            placementOfTwoNumber.Add(new List<int> { (number - i - j - k), k, j, i });
          }     
        }
      }
      return placementOfTwoNumber;
    }
  }

   /*public List<List<int>> ForFour(int number)
    {
      ForThree(number);
      int counter = placementOfTwoNumber.Count;
      int n = 0;
      for (int i = 0; i <= number; i++)
      {
        for (int j = counter * n; j < placementOfTwoNumber.Count; j++)
        {
          placementOfTwoNumber[j].Add(n);
        }
        if (i == number)
        {
          break;
        }
        ForThree(number);
        n++;
      }
      return placementOfTwoNumber;
    }*/
  }

