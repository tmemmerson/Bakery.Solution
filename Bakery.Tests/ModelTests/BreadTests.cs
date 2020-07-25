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
    BreadItem newBreadItem = new BreadItem(14);

    Assert.AreEqual(7, newBreadItem.FreeBreadCalc(14));
    }


    [TestMethod]
    public void BreadTotalCount_CalculateTotalLoavesOwed_BreadTotalCount()
    {
    BreadItem newBreadItem = new BreadItem(14);

    Assert.AreEqual(21, newBreadItem.BreadTotalCount(14,7));
    }


    [TestMethod]
    public void BreadCustomerCost_CalculateCostToCustomer_BreadCustomerCost()
    {
    BreadItem newBreadItem = new BreadItem(14);

    Assert.AreEqual(70, newBreadItem.BreadCustomerCost(14));
    }
    
  }
}