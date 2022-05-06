using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Pastry.ClearAll();
    }
    [TestMethod]
    public void PastryConstructor_CreatePastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryOrder_GetsPastryOrderList_ListOfPastry()
    {
      Pastry newPastry = new Pastry();

      Assert.AreEqual(1, Pastry.GetOrder().Count);
    }

    [TestMethod]
    public void PastryConstructor_AddsMultiplePastry_ListOfPastry()
    {
      Pastry newPastry = new Pastry(3);

      Assert.AreEqual(3, Pastry.GetOrder().Count);
    }

    [TestMethod]
    public void PastryConstructor_PastryPricingAndSale_Pastry()
    {
      string type = "scone";
      Pastry newPastry = new Pastry(1, type);
      Assert.AreEqual("scone", newPastry.Type);
    }

    [TestMethod]
    public void PriceCalc_CalculatesThePriceOfASingleLoaf_intPrice()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(2, Pastry.PriceCalc());
    }

    [TestMethod]
    public void PriceCalc_CalculatesThePriceOfTwoLoaves_intPrice()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(4, Pastry.PriceCalc());
    }

    [TestMethod]
    public void PriceCalc_CalculatesThePriceOfThreeLoaves_intPrice()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(5, Pastry.PriceCalc());
    }

    [TestMethod]
    public void PriceCalc_CalculatesThePriceOfManyLoaves_intPrice()
    {
      Pastry newPastry = new Pastry(6);
      Assert.AreEqual(10, Pastry.PriceCalc());
    }
  }
}