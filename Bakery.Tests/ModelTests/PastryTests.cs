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
      Pastry newPastry = new Pastry(2, "1");
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryAmount_ReturnsPastryAmount_String()
    {
      string pastryAmount = "1";
      Pastry newPastry = new Pastry(2, pastryAmount);
      string result = newPastry.PastryAmount;
      Assert.AreEqual(pastryAmount, result);
    }
  }
}