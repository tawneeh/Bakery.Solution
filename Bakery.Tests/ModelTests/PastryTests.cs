using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System.Collections.Generic;
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
    public void GetBreadAmount_ReturnsBreadAmount_String()
    {
      string breadAmount = "1";
      Bread newBread = new Bread(5, breadAmount);
      string result = newBread.BreadAmount;
      Assert.AreEqual(breadAmount, result);
    }
  }
}