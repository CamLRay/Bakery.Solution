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

      Assert.AreEqual(1, Bread.GetBreadOrder().Count);
    }

    // [TestMethod]
    // public void BreadConstructor_AddsMultipleBread_ListOfBread()
    // {
    //   Bread newBread = new Bread(3);

    //   Assert.AreEqual(3, newBread.Count());
    // }

  }
}