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
      Bread newBread = new Bread(2);
      int dealAmount = newBread.BreadAmount + 1;
      int result = dealAmount * Bread.Price - Bread.Price;
      Assert.AreEqual(10, result);
    }

  }
}