using Bakery;
using Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Bakery.Logic;

namespace Bakery
{
  public class Bakery
  {
    static void Main()
    {
      Welcome.welcomePrintout(); 

      Console.WriteLine("Would you like to place an order? Y/N"); 
      string orderResponse =  Console.ReadLine(); 

      if (orderResponse == "yes" || orderResponse == "Y" || orderResponse == "y") 
      {
        Console.WriteLine(">>>>> How many loaves of bread would you like to purchase?"); 
        string breadResponse = Console.ReadLine(); 
        int breadCount = Int32.Parse(breadResponse); 
        BreadItem newBreadItem = new BreadItem(breadCount);
        Console.WriteLine(">>>>> Bread Loaves: " + breadResponse); 

        Console.WriteLine(">>>>> How many pastries would you like to purchase?"); 
        string pastryResponse = Console.ReadLine(); 
        int pastryCount = Int32.Parse(pastryResponse); 
        PastryItem newPastryItem = new PastryItem(pastryCount); 
        Console.WriteLine(">>>>> Pastries: " + pastryResponse);
      
        newBreadItem.ReceiptPrintoutBread(breadCount);
        newPastryItem.ReceiptPrintoutPastry(pastryCount);
        Salutation.salutationPrintout();
      }
      else
      {
        Console.WriteLine("Please Come Again!");
      }

    }
  }
}