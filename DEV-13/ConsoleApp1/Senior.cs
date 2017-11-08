using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Senior : Employee
  {
    public int Salary
    {
      get
      {
        return salary;
      }
      private set
      {
        salary = 1000;
      }
    }
    public int Productivity
    {
      get
      {
        return productivity;
      }
      private set
      {
        productivity = 500;
      }
    }
  }
}
