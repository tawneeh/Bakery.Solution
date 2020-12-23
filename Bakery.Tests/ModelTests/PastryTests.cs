using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryPrice_ReturnsPastryPrice_Int()
    {
      Pastry newPastry = new Pastry(1);
      int result = newPastry.GetPastryPrice();
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void GetPastryPrice_ReturnsDealPrice_Int()
    {
      Pastry newPastry = new Pastry(4);
      int multipleOfThree = 4 / 3;
      int result = 4 * 2 - multipleOfThree;
      Assert.AreEqual(7, result);
    }

  }
}