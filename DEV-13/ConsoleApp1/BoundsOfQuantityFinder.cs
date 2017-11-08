using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecruitment
{
  public class BoundsOfQuantityFinder
  {
    public Junior junior = new Junior();
    public Lead lead = new Lead();
    public Middle middle = new Middle();
    public int FindMaxNumbersOfEmployeesFixSum(int outputedSum)
    {   
      int maxNumberOfEmployees = outputedSum / junior.salary;
      return maxNumberOfEmployees;
    }

    public int FindMinNumbersOfEmployeesFixSum(int outputedSum)
    {
      int minNumberOfEmployees = outputedSum / lead.salary;
      return minNumberOfEmployees;
    }
    public int FindMaxNumbersOfEmployeesFixProductivity(int outputedProductivity)
    {
      int maxNumberOfEmployees = outputedProductivity / junior.productivity;
      return maxNumberOfEmployees;
    }

    public int FindMinNumbersOfEmployeesFixProductivity(int outputedProductivity)
    {
      int minNumberOfEmployees = outputedProductivity / lead.productivity;
      return minNumberOfEmployees;
    }

    public int FindMaxNumbersWithoudJuniorsFixProductivity(int outputedProductivity)
    {
      int maxNumberOfEmployees = outputedProductivity / middle.productivity;
      return maxNumberOfEmployees;
    }
  }
}
