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
      Bread newBread = new Bread(5, 1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod] // test two
    public void GetBreadAmount_ReturnsBreadAmount_Int()
    {
      int breadAmount = 1;
      Bread newBread = new Bread(5, breadAmount);
      int result = newBread.BreadAmount;
      Assert.AreEqual(breadAmount, result);
    }
  }
}