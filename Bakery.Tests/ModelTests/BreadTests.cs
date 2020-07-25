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
    public void FreeBread_CalculateFreeBreadPromoCount_FreeBreadCalc()
    {
    //arrange
    BreadItem newBreadItem = new BreadItem(14);

    //assert
    Assert.AreEqual(7, newBreadItem.FreeBreadCalc(14));
    }
  }
}