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
      ThirdCriterion thirdCriterion = new ThirdCriterion();
      thirdCriterion.OutputedProductivity = 10000;
      thirdCriterion.ProductivityForFourEmployees();
      Console.WriteLine(thirdCriterion.ResultList());
      Console.ReadKey();
    }
  }
}
