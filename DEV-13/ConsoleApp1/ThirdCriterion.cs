using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecruitment
{
  public class ThirdCriterion : Criterion
  {
    public List<int> NumberOfEmployees;
    public List<int> Productivity = new List<int>();
    public List<string> Result;
    public List<List<int>> placementOfNumbers = new List<List<int>>();
    public int OutputedSum;
    public int OutputedProductivity;
    public NumberOfEmployeesGenerator numberOfEmployeesGenerator;
    public BoundsOfQuantityFinder boundsOfQuantityFinder = new BoundsOfQuantityFinder();
    public Employee employee;

    public void ProductivityForFourEmployees()
    {
      NumberOfEmployees = new List<int>();
      Result = new List<string>();
      numberOfEmployeesGenerator = new NumberOfEmployeesGenerator();
      for (int p = boundsOfQuantityFinder.FindMinNumbersOfEmployeesFixProductivity(OutputedProductivity);
            p < boundsOfQuantityFinder.FindMaxNumbersOfEmployeesFixProductivity(OutputedProductivity); p++)
      {
        for (int i = 0; i < (p / 4) + 1; i++)
        {
          for (int j = i; j < ((p - i) / 3) + 1; j++)
          {
            for (int k = j; k < ((p - j) / 2) + 1; k++)
            {
              placementOfNumbers.Add(new List<int> { i, j, k, (p - i - j - k) });
              placementOfNumbers.Add(new List<int> { (p - i - j - k), k, j, i });
            }
          }
        }
      }
      for (int i = 0; i < placementOfNumbers.Count; i++)
      {
        if (
              placementOfNumbers[i][0] * junior.productivity +
              placementOfNumbers[i][1] * middle.productivity +
              placementOfNumbers[i][2] * senior.productivity +
              placementOfNumbers[i][3] * lead.productivity == OutputedProductivity)
        {

          NumberOfEmployees.Add((placementOfNumbers[i][0]));
          StringBuilder resultString = new StringBuilder();
          resultString.Append((placementOfNumbers[i][0].ToString()));
          resultString.Append(junior.nameOfCategory);
          resultString.Append((placementOfNumbers[i][1].ToString()));
          resultString.Append(middle.nameOfCategory);
          resultString.Append((placementOfNumbers[i][2].ToString()));
          resultString.Append(senior.nameOfCategory);
          resultString.Append((placementOfNumbers[i][3].ToString()));
          resultString.Append(lead.nameOfCategory);
          Result.Add(placementOfNumbers[i][0].ToString() + junior.nameOfCategory + placementOfNumbers[i][1].ToString() +
            middle.nameOfCategory + placementOfNumbers[i][2].ToString() + senior.nameOfCategory + placementOfNumbers[i][3].ToString()+
            lead.nameOfCategory);
        }
      }
    }
    public int FindIndexOfMaxJunior()
    {
      int countNumber = NumberOfEmployees[0];
      int counter = 0;
      for(int i = 0; i < NumberOfEmployees.Count; i++)
      {
        if(NumberOfEmployees[i] > countNumber)
        {
          countNumber = NumberOfEmployees[i];
          counter = i;
        }
      }
      return counter;
    }
    public string ResultList()
    {
      return Result[FindIndexOfMaxJunior()];
    }
  }
}

