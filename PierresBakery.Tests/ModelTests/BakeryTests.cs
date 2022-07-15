using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadCost_ZeroBread_Int()
    {
      int breadAmount = 0;
      double breadCost = 0;
      Bread testOrder = new Bread(breadAmount);
      Assert.AreEqual(breadCost, testOrder.BreadCost());
    }
    [TestMethod]
    public void BreadCost_OneBread_Int()
    {
      int breadAmount = 1;
      double breadCost = 5;
      Bread testOrder = new Bread(breadAmount);
      Assert.AreEqual(breadCost, testOrder.BreadCost());
    }
    [TestMethod]
    public void BreadCost_TwoBread_Int()
    {
      int breadAmount = 2;
      double breadCost = 10;
      Bread testOrder = new Bread(breadAmount);
      Assert.AreEqual(breadCost, testOrder.BreadCost());
    }
     [TestMethod]
    public void BreadCost_ThreeBread_Int()
    {
      int breadAmount = 3;
      double breadCost = 10;
      Bread testOrder = new Bread(breadAmount);
      Assert.AreEqual(breadCost, testOrder.BreadCost());
    }
    [TestMethod]
    public void PastryCost_ZeroPastry_Int()
    {
      int pastryAmount = 0;
      double pastryCost = 0;
      Pastry testOrder = new Pastry(pastryAmount);
      Assert.AreEqual(pastryCost, testOrder.PastryCost());
    }
    [TestMethod]
    public void PastryCost_OnePastry_Int()
    {
      int pastryAmount = 0;
      double pastryCost = 0;
      Pastry testOrder = new Pastry(pastryAmount);
      Assert.AreEqual(pastryCost, testOrder.PastryCost());
    }
  }
}