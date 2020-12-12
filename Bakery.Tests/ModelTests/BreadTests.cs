using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod] // test one
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(5, "1");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod] // test two
    public void GetBreadAmount_ReturnsBreadAmount_String()
    {
      string breadAmount = "1";
      Bread newBread = new Bread(5, breadAmount);
      string result = newBread.BreadAmount;
      Assert.AreEqual(breadAmount, result);
    }

    [TestMethod] // test three
    public void GetBreadTotalPrice_ReturnsBreadTotalPrice_Int()
    {
      string breadAmount = "1";
      Bread newBread = new Bread(5, breadAmount);
      int breadLoaves = Convert.ToInt32(breadAmount);
      int totalBreadPrice = breadLoaves * 5;
      int result = GetBreadTotalPrice();
      Assert.AreEqual(totalBreadPrice, result);
    }
  }
}