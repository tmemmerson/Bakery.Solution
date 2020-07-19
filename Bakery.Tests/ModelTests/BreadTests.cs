using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void FreeBread_CalculateFreeBreadPromoCount_FreeBread()
    {
    Assert.AreEqual(2, Bakery.FreeBread(4));
    Assert.AreEqual(7, Bakery.FreeBread(14));
    }

  }
}