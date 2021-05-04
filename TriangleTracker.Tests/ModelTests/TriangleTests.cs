using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker.Models;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    // public void CheckType_IsASide_String()
    // {
    //   Triangle testTriangle = new Triangle();
    //   Assert.AreEqual("What the hell this is a triangle", testTriangle.CheckType(1, 3, 4));
    // }
    public void CheckType_IsNotATriangle_String()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("That is not a triangle", testTriangle.CheckType(50, 30, 1));
    }
    [TestMethod]
    public void CheckType_IsAScaleneTriangle_String()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("What the hell this is a scalene triangle", testTriangle.CheckType(1, 2, 3));
    }
    [TestMethod]
    public void CheckType_IsAEqualateralTriangle_String()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("What the hell this is a equalateral triangle", testTriangle.CheckType(3, 3, 3));
    }
    [TestMethod]
    public void CheckType_IsAnIsoscelesTriangle_String()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("What the hell this is an isosceles triangle", testTriangle.CheckType(2, 2, 3));
    }
  }
}



