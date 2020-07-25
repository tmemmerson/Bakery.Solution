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

  }
}