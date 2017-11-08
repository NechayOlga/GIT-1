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
      counter.OutputedSum = 3000;
      counter.SalaryForFourEmployees();
      Console.WriteLine(counter.ResultList());
      Console.ReadKey();
    }
  }
}
