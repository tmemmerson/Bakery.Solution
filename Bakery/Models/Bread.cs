using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Models
{
    public class BreadItem
  {
    public int BreadCount { get; set; }

    public BreadItem(int breadCount)
    {
      BreadCount = breadCount;
    }

    public int FreeBreadCalc(int breadCount)
    {
      int breadPromoRate = 2;
      int breadCountFree = breadCount / breadPromoRate;
      return breadCountFree;
    }
    public int BreadTotalCount(int breadCount, int breadCountFree)
    {
      int totalLoaves = breadCount + breadCountFree;
      return totalLoaves;
    }
    public int BreadCustomerCost(int breadCount)
    {
/*       int breadPrice = 5;
      int breadCountCost = breadCount * breadPrice;
      return breadCountCost; */
    }


    public void ReceiptPrintoutBread (int breadCount)
    {   
      Console.WriteLine("                   ___________________________________"); 
      Console.WriteLine("                  |              RECEIPT              |");
      Console.WriteLine("                  |___________________________________|");
      Console.WriteLine("                  |                                   |");
      Console.WriteLine("                  |      Loave(s): " + breadCount +"                 |"); 
      Console.WriteLine("                  |      Free Loave(s): " + FreeBreadCalc(breadCount)+"             |");
      Console.WriteLine("                  |      Total Quantity: " + BreadTotalCount(breadCount, FreeBreadCalc(breadCount))+"           |");
      Console.WriteLine("                  |      Loaves Total: $" + BreadCustomerCost(breadCount) +".00         |");
      Console.WriteLine("                  |___________________________________|");
    }

  }
  
  }

  