using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker.Models;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void CheckType_IsASide_String()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("What the hell this is a triangle", testTriangle.CheckType(1, 3, 4));
    }
  }
}