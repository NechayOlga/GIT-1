using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DetermineTriangleType.Tests
{
  [TestClass]
  public class BuilderTests
  {
    const string EQUILATERAL = "Triangle is equilateral";
    const string ISOSCELES = "Triangle is isosceles";
    const string VERSALITE = "Triangle is versalite";

    Sides sidesForVersatileTriangle = new Sides()
    {
      sideA = 1,
      sideB = 2,
      sideC = 3
    };

    Sides sidesForEquilateralTriangle = new Sides()
    {
      sideA = 1,
      sideB = 1,
      sideC = 1
    };

    Sides sidesForIsoscelesTriangle = new Sides()
    {
      sideA = 1,
      sideB = 1,
      sideC = 2
    };
    [TestMethod]
    public void TestDetermineType_sideA_1_sideB_2_sidec_3_VERSATILE_return()
    {
      //arrange
      Builder builder = new Builder(sidesForVersatileTriangle);

      //act
      TriangleType actual = builder.DetermineType(sidesForVersatileTriangle);
      TriangleType expected = TriangleType.VERSATILE;

      //assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDetermineType_sideA_1_sideB_1_sidec_1__EQUILATERAL_return()
    {
      //arrange
      Builder builder = new Builder(sidesForEquilateralTriangle);

      //act
      TriangleType actual = builder.DetermineType(sidesForEquilateralTriangle);
      TriangleType expected = TriangleType.EQUILATERAL;

      //assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDetermineType_sideA_1_sideB_1_sidec_2__ISOSCELES_return()
    {
      //arrange
      Builder builder = new Builder(sidesForIsoscelesTriangle);

      //act
      TriangleType actual = builder.DetermineType(sidesForIsoscelesTriangle);
      TriangleType expected = TriangleType.ISOSCELES;

      //assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestBuild_sideA_1_sideB_1_sidec_1__EQUILATERAL_return()
    {
      //arrange
      Builder builder = new Builder(sidesForEquilateralTriangle);

      //act
      Triangle actual = builder.Build(sidesForEquilateralTriangle);

      //assert
      Assert.IsInstanceOfType(actual, typeof(Equilateral));
    }

    [TestMethod]
    public void TestBuild_sideA_1_sideB_2_sidec_3__VERSATILE_return()
    {
      //arrange
      Builder builder = new Builder(sidesForVersatileTriangle);

      //act
      Triangle actual = builder.Build(sidesForVersatileTriangle);

      //assert
      Assert.IsInstanceOfType(actual, typeof(Versatile));
    }

    [TestMethod]
    public void TestBuild_sideA_1_sideB_1_sidec_2__ISOSCELES_return()
    {
      //arrange
      Builder builder = new Builder(sidesForIsoscelesTriangle);

      //act
      Triangle actual = builder.Build(sidesForIsoscelesTriangle);

      //assert
      Assert.IsInstanceOfType(actual, typeof(Isosceles));
    }
  }
}
