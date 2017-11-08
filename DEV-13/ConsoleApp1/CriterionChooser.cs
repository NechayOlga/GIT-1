using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecruitment
{
  enum SelectCriterion
  {
    FIRSTCRITERION = 1,
    SECONDCRITERION,
    THIRDCRITERION
  }
  public class CriterionChooser
  {
    public void ChooseCriterion(int outputedSum, int outputedProductivity)
    {
      bool checker = true;
      while (checker)
      {
        try
        {
          int criterionNumber = int.Parse(Console.ReadLine());
          switch (criterionNumber)
          {
            case 1:
              FirtstCriterion firstCriterion = new FirtstCriterion();
              firstCriterion.OutputedSum = outputedSum;
              firstCriterion.OutputedProductivity = outputedProductivity;
              firstCriterion.SalaryForFourEmployees();
              Console.WriteLine(firstCriterion.ResultList());
              break;
            case 2:
              SecondCriterion secondCriterion = new SecondCriterion();
              secondCriterion.OutputedSum = outputedSum;
              secondCriterion.OutputedProductivity = outputedProductivity;
              secondCriterion.ProductivityForFourEmployees();
              Console.WriteLine(secondCriterion.ResultList());
              break;
            case 3:
              ThirdCriterion thirdCriterion = new ThirdCriterion();
              thirdCriterion.OutputedSum = outputedSum;
              thirdCriterion.OutputedProductivity = outputedProductivity;
              thirdCriterion.ProductivityForFourEmployees();
              Console.WriteLine(thirdCriterion.ResultList());
              break;
            default:
              throw new InvalidNumberOfCriterionException();
          }
        }
        catch(Exception ex)
        {
          Console.WriteLine(ex);
          continue;
        }
      }
    }
  }
}
