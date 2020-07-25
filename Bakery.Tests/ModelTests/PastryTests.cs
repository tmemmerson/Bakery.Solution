using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryBundle_CalculateNumberOfPastryBundles_PastryBundleCalc()
    {
    PastryItem newPastryItem = new PastryItem(11);

    Assert.AreEqual(3, newPastryItem.PastryBundleCalc(11));
    }

    [TestMethod]
    public void PastrySingles_CalculateNumberOfSinglePastriesOwed_PastrySinglesCalc()
    {
    PastryItem newPastryItem = new PastryItem(11);

    Assert.AreEqual(2, newPastryItem.PastrySinglesCalc(11));
    }

    [TestMethod]
    public void PastryBundleCost_CalculateCostOfPastryBundles_PastryBundleCostCalc()
    {
    PastryItem newPastryItem = new PastryItem(11);

    Assert.AreEqual(15, newPastryItem.PastryBundleCostCalc(11));
    }
    
    [TestMethod]
    public void PastrySinglesCost_CalculateCostOfPastrySingles_PastrySinglesCostCalc()
    {
    PastryItem newPastryItem = new PastryItem(11);

    Assert.AreEqual(4, newPastryItem.PastrySinglesCostCalc(11));
    }
  }
}