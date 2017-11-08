using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StaffRecruitment.Tests
{
  [TestClass]
  public class BoundsOfQuantityFinderTests
  {
    [TestMethod]
    public void FindMaxNumbersOfEmployeesFixSumTests_outputedSalary_1800_juniorSalary_1000_18_returned()
    {
      //arrange
      int outputedSalary = 1800;
      int juniorSalary = 100;
      int numberOfEmployees = outputedSalary / juniorSalary;

      //act
      BoundsOfQuantityFinder boundsOfQuantityFinder = new BoundsOfQuantityFinder();
      boundsOfQuantityFinder.junior.salary = 100;
      int actual = boundsOfQuantityFinder.FindMaxNumbersOfEmployeesFixSum(outputedSalary);
      int expected = numberOfEmployees;

      //assert
      Assert.AreEqual(expected, actual);
    }
  }
}
