using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DetermineTriangleType.Tests
{
  /// <summary>
  /// Summary description for CheckerTests
  /// </summary>
  [TestClass]
  public class CheckerTests
  {
      const string INVALID_RESULT = "Triangle with unpositive sides is invalid";
      const string NOT_EXIST = "Triangle with such sides doesn't exist";
      public Sides sidesForValidTriangle = new Sides()
      {
        sideA = 1,
        sideB = 2,
        sideC = 3
      };
      public Sides sidesForInvalidTriangle = new Sides()
      {
        sideA = -1,
        sideB = 2,
        sideC = 3
      };
      public Sides sidesForExistenteTriangle = new Sides()
      {
        sideA = 1,
        sideB = 2,
        sideC = 1
      };
      public Sides sidesForNotExistenteTriangle = new Sides()
      {
        sideA = 1,
        sideB = 2,
        sideC = 88
      };

      [TestMethod]
      public void TestValidTriangleCheck_sideA_1_sideB_2_sideC_3_true_returned()
      {
        //arrange
        Checker checker = new Checker();

        //act
        bool actual = checker.ValidCheck(sidesForValidTriangle);
        bool expected = true;

        //assert
        Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void TestInvalidTriangleCheck_sideA_minus1_sideB_2_sideC_3_false_returned()
      {
        //arrange
        Checker checker = new Checker();

        //act
        bool actual = checker.ValidCheck(sidesForInvalidTriangle);
        bool expected = false;

        //assert
        Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void TestExistenteTriangleCheck_sideA_1_sideB_2_sideC_1_true_returned()
      {
        //arrange
        Checker checker = new Checker();

        //act
        bool actual = checker.ValidCheck(sidesForExistenteTriangle);
        bool expected = true;

        //assert
        Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void TestInvalidTriangleCheck_sideA_1_sideB_2_sideC_88_false_returned()
      {
        //arrange
        Checker checker = new Checker();

        //act
        bool actual = checker.ValidCheck(sidesForNotExistenteTriangle);
        bool expected = false;

        //assert
        Assert.AreEqual(expected, actual);
      }
    }
  }

