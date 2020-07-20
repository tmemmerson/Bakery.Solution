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
    public static int FreeBread(int breadCount)
    {
      return breadCount / 2;
    }
            
    public static int CalculatePastryBundleCost(int pastryCount)
    {
      int pastryBundles = pastryCount / 3;
      return pastryBundles * 5;
    }

    static void Main()
    {
      Welcome.welcomePrintout(); //call welcome printout to start encounter
      Console.WriteLine("Would you like to place an order? Y/N"); //prompt user for order
      string orderResponse =  Console.ReadLine(); //set user response to string variable
      if (orderResponse == "yes" || orderResponse == "Y" || orderResponse == "y") //evaluate user response. need to implement toUpper to standardize string evaluation
      {
        Console.WriteLine(">>>>>How many loaves of bread would you like to purchase?"); //prompt user for bread quantity
        string breadResponse = Console.ReadLine(); //set user bread input to string variable
        Console.WriteLine("Bread Loaves: " + breadResponse); //display back bread input information
        Console.WriteLine(">>>>>How many pastries would you like to purchase?"); //prompt user for pastry quantity
        string pastryResponse = Console.ReadLine(); //set user pastry input to string variable 
        Console.WriteLine("Pastries: " + pastryResponse); //display back pastry input information
        int breadCount = Int32.Parse(breadResponse); // convert bread input to int
        int pastryCount = Int32.Parse(pastryResponse); //convert pastry input to int
        int freeBread = FreeBread(breadCount); //calculate free bread loaves promotion total
        int breadTotal = breadCount + freeBread; //calculate total loaves owed to user
        int pastryBundlesCost = CalculatePastryBundleCost(pastryCount); //calculate cost of all bundled pastries
        int pastrySingles = pastryCount % 3; //calculate quantity of pastries unqualified for bundle promo
        int pastrySinglesCost = pastrySingles * 2; //calculate  cost of unbundled pastries
        int pastryTotalCost = pastrySinglesCost + pastryBundlesCost; //calculate total cost of all pastries
        int breadTotalCost = breadCount * 5; //calculate total cost of all bread
        int receiptTotal = breadTotalCost + pastryTotalCost; //calculate cost of all bread and all pastries
        int pastryBundleReceiptPrint = pastryCount / 3; //intermediate variable for printout return. will remove in refactoring.
        Console.WriteLine(" ___________________________________"); 
        Console.WriteLine("|              RECEIPT              |");
        Console.WriteLine("|___________________________________|");
        Console.WriteLine("| Loave(s): " + breadCount); 
        Console.WriteLine("| Free Loave(s): " + freeBread);
        Console.WriteLine("| Total Quantity: " + breadTotal);
        Console.WriteLine("| Loaves Total: $" + breadTotalCost +".00");
        Console.WriteLine("|___________________________________|");
        Console.WriteLine("|                                   |");
        Console.WriteLine("| Pastries (3 ct.): " + pastryBundleReceiptPrint);
        Console.WriteLine("| Pastries (1 ct.): " + pastrySingles);
        Console.WriteLine("| Total Quantity: " + pastryCount);
        Console.WriteLine("| Pastries Total: $" + pastryTotalCost +".00");
        Console.WriteLine("|___________________________________|");
        Console.WriteLine("| ORDER TOTAL PRICE: $" + receiptTotal + ".00"); //user receipt printout
        Salutation.salutationPrintout(); //call salutation printout
      }

      else
      {
        Console.WriteLine("Please Come Again!"); //terminate
      }

    }
  }
}