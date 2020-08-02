using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

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
      int breadPrice = 5;
      int breadCountCost = breadCount * breadPrice;
      return breadCountCost;
    }
    public void ReceiptPrintoutBread (int breadCount)
    {   
      WriteLine("                   ___________________________________"); 
      WriteLine("                  |              RECEIPT              |");
      WriteLine("                  |___________________________________|");
      WriteLine("                  |                                   |");
      WriteLine("                  |      Loave(s): " + breadCount +"                 |"); 
      WriteLine("                  |      Free Loave(s): " + FreeBreadCalc(breadCount)+"             |");
      WriteLine("                  |      Total Quantity: " + BreadTotalCount(breadCount, FreeBreadCalc(breadCount))+"           |");
      WriteLine("                  |      Loaves Total: $" + BreadCustomerCost(breadCount) +".00         |");
      WriteLine("                  |___________________________________|");
    }
  }
  }

  