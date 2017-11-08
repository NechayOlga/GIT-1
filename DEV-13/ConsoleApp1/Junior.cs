using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Junior:Employee
  {
    public int Salary
    { get
      {
        return salary;
      }
      private set
      {
        salary = 300;
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
        productivity = 100;
      }
    }
  }
}
