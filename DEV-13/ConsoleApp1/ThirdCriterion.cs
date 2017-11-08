﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecruitment
{
  public class ThirdCriterion : Criterion
  {
    public List<int> Salary;
    public List<int> Productivity = new List<int>();
    public List<string> Result = new List<string>();
    public List<List<int>> placementOfNumbers = new List<List<int>>();
    public int OutputedSum;
    public int OutputedProductivity;
    public NumberOfEmployeesGenerator numberOfEmployeesGenerator;
    public BoundsOfQuantityFinder boundsOfQuantityFinder = new BoundsOfQuantityFinder();
    public Employee employee;

    public void ProductivityForFourEmployees()
    {
      Salary = new List<int>();
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

          Salary.Add((placementOfNumbers[i][0] * junior.salary + placementOfNumbers[i][1] * middle.salary +
          placementOfNumbers[i][2] * senior.salary + placementOfNumbers[i][3] * lead.salary));
          StringBuilder resultString = new StringBuilder();
          resultString.Append((placementOfNumbers[i][0].ToString()));
          resultString.Append(junior.nameOfCategory);
          resultString.Append((placementOfNumbers[i][1].ToString()));
          resultString.Append(middle.nameOfCategory);
          resultString.Append((placementOfNumbers[i][2].ToString()));
          resultString.Append(senior.nameOfCategory);
          resultString.Append((placementOfNumbers[i][3].ToString()));
          resultString.Append(lead.nameOfCategory);
          Result.Add(resultString.ToString());
        }
      }
    }
    public int FindIndexOfMaxJunior()
    {
      int countNumber = placementOfNumbers[0][0];
      int counter = 0;
      for(int i = 0; i < placementOfNumbers.Count; i++)
      {
        if(placementOfNumbers[i][0] > countNumber)
        {
          countNumber = placementOfNumbers[i][0];
          counter = i;
        }
      }
      return counter;
    }
    public string ResultList()
    {
      return Result[FindIndexOfMaxJunior() - 1];
    }
  }
}

