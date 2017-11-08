using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecruitment
{
  class Program
  {
    static void Main(string[] args)
    {
      Counter counter = new Counter();
      StringBuilder stringBuilder = new StringBuilder();
      List<List<int>> arrayForTwo = new List<List<int>>(counter.ForFour(8));
      for (int i = 0; i < arrayForTwo.Count; i++)
      {
        Console.WriteLine(arrayForTwo[i][0] + " " + arrayForTwo[i][1] + " " + arrayForTwo[i][2] + " " + arrayForTwo[i][3]);
      }
      Console.ReadKey();
    }
  }
}
