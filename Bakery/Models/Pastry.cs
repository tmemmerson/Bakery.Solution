using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Models
{
    public class PastryItem
  {
    public int PastryCount { get; set; }

    public PastryItem(int pastryCount)
    {
      PastryCount = pastryCount;
    }

    public static int PastryBundleCalc(int pastryCount)
    {
      int pastryCountBundles = pastryCount / 3;
      return pastryCountBundles;
    }

    public static int PastrySinglesCalc(int pastryCount)
    {
      int pastryCountSingles = pastryCount % 3;
      return pastryCountSingles;
    }

    public static int PastryBundleCostCalc(int pastryCount)
    {
      int pastryBundleCost = (pastryCount / 3) * 5;
      return pastryBundleCost;
    }

    public static int PastrySinglesCostCalc(int pastryCount)
    {
      int pastrySinglesCost = (pastryCount % 3) * 2;
      return pastrySinglesCost;
    }
      public static int PastryCustomerCost(int pastryCountSingles, int pastryCountBundles)
    {
      int pastryCustomerCost = (pastryCountSingles * 2) + (pastryCountBundles * 5);
      return pastryCustomerCost;
    }
    public static int PastryTotalCount(int pastryCount)
    {
      int pastryTotalCount = pastryCount;
      return pastryTotalCount;
    }
    public void ReceiptPrintoutPastry (int pastryCount)
    {  
        Console.WriteLine("                  |                                   |");
        Console.WriteLine("                  |      Pastries (3 ct.): " + PastryBundleCalc(pastryCount) + "          |");
        Console.WriteLine("                  |      Pastries (1 ct.): " + PastrySinglesCalc(pastryCount) + "          |");
        Console.WriteLine("                  |      Total Quantity: " + PastryTotalCount(pastryCount) + "           |");
        Console.WriteLine("                  |      Pastries Total: $" + PastryCustomerCost(PastrySinglesCalc(pastryCount), PastryBundleCalc(pastryCount)) +".00       |");
        Console.WriteLine("                  |___________________________________|");
    }

    
  }
  }
