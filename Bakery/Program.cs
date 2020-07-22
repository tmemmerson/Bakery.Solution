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
      Console.WriteLine("Would you like to place an order? Y/N"); //pass
      string orderResponse =  Console.ReadLine(); //pass
      if (orderResponse == "yes" || orderResponse == "Y" || orderResponse == "y") //pass
      {
        Console.WriteLine(">>>>>How many loaves of bread would you like to purchase?"); //pass
        
        string breadResponse = Console.ReadLine(); //pass
        int breadCount = Int32.Parse(breadResponse); //pass
        BreadItem newBreadItem = new BreadItem(breadCount);

        Console.WriteLine("Bread Loaves: " + breadResponse); //pass
        Console.WriteLine(">>>>>How many pastries would you like to purchase?"); //pass
        
        string pastryResponse = Console.ReadLine(); //pass
        int pastryCount = Int32.Parse(pastryResponse); //pass
        PastryItem newPastryItem = new PastryItem(pastryCount); //pass

        Console.WriteLine("Pastries: " + pastryResponse);
      
        
        
        newBreadItem.ReceiptPrintoutBread(breadCount);
        Salutation.salutationPrintout();
      }

      else
      {
        Console.WriteLine("Please Come Again!");
      }

    }
  }
}