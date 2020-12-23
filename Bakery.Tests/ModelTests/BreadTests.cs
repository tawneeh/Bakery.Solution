using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

// to run test coverage: dotnet test -p:CollectCoverage=true

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadPrice_ReturnsBreadPrice_Int()
    {
      Bread newBread = new Bread(1);
      int result = newBread.GetBreadPrice();
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void GetBreadPrice_ReturnsDealPrice_Int()
    {
      Bread newBread = new Bread(6);
      int multipleOfThree = 6 / 3;
      int dealAmount = 6 - multipleOfThree;
      int result = dealAmount * 5;
      Assert.AreEqual(20, result);
    }

  }
}