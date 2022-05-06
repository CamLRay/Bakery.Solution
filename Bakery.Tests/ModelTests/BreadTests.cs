using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearAll();
    }
    [TestMethod]
    public void BreadConstructor_CreateBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadOrder_GetsBreadOrderList_ListOfBread()
    {
      Bread newBread = new Bread();

      Assert.AreEqual(1, Bread.GetOrder().Count);
    }

    [TestMethod]
    public void BreadConstructor_AddsMultipleBread_ListOfBread()
    {
      Bread newBread = new Bread(3);

      Assert.AreEqual(3, Bread.GetOrder().Count);
    }

    [TestMethod]
    public void BreadConstructor_BreadPricingAndSale_Bread()
    {
      string type = "sourdough";
      Bread newBread = new Bread(1, type);
      Assert.AreEqual("sourdough", newBread.Type);
    }

    [TestMethod]
    public void PriceCalc_CalculatesThePriceOfASingleLoaf_intPrice()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(5, Bread.PriceCalc());
    }

    [TestMethod]
    public void PriceCalc_CalculatesThePriceOfTwoLoaves_intPrice()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(10, Bread.PriceCalc());
    }

    [TestMethod]
    public void PriceCalc_CalculatesThePriceOfThreeLoaves_intPrice()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(10, Bread.PriceCalc());
    }

    [TestMethod]
    public void PriceCalc_CalculatesThePriceOfManyLoaves_intPrice()
    {
      Bread newBread = new Bread(10);
      Assert.AreEqual(35, Bread.PriceCalc());
    }

    

  }
}