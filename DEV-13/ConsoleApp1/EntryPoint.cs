using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecruitment
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      int OutputedSum = int.Parse(Console.ReadLine());
      int OutputedProductivity = int.Parse(Console.ReadLine());
      CriterionChooser criterionChooser = new CriterionChooser();
      criterionChooser.ChooseCriterion(OutputedSum, OutputedProductivity);
      Console.ReadKey();
    }
  }
}
