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
      SecondCriterion secondCriterion = new SecondCriterion();
      StringBuilder stringBuilder = new StringBuilder();
      secondCriterion.OutputedProductivity = 3000;
      secondCriterion.ProductivityForFourEmployees();
      Console.WriteLine(secondCriterion.ResultList());
      Console.ReadKey();
    }
  }
}
