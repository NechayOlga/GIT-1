using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecruitment
{
  public class InvalidNumberOfCriterionException : Exception
  {
    const string INVALIDNUMBEROFCRITERION = "Invalid criterion number, enter one more";
    public InvalidNumberOfCriterionException(string message = INVALIDNUMBEROFCRITERION) : base(message) { }
  }
}
