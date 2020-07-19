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

      Welcome.welcomePrintout();
      Console.WriteLine("Would you like to place an order? Y/N");
      string orderResponse =  Console.ReadLine();
      if (orderResponse == "yes" || orderResponse == "Y" || orderResponse == "y") //need to implement toUpper to standardize string evaluation
      {
        Console.WriteLine(">>>>>How many loaves of bread would you like to purchase?");
        string breadResponse = Console.ReadLine();
        Console.WriteLine("Bread Loaves: " + breadResponse);
        Console.WriteLine(">>>>>How many pastries would you like to purchase?");
        string pastryResponse = Console.ReadLine();
        Console.WriteLine("Pastries: " + pastryResponse);
        int breadCount = Int32.Parse(breadResponse);
        int pastryCount = Int32.Parse(pastryResponse);

        int freeBread = FreeBread(breadCount);
        int breadTotal = breadCount + freeBread;
        int pastryBundlesCost = CalculatePastryBundleCost(pastryCount);

        int pastrySingles = pastryCount % 3;
        int pastrySinglesCost = pastrySingles * 2;
        int pastryTotalCost = pastrySinglesCost + pastryBundlesCost;
        int breadTotalCost = breadCount * 5;
        int receiptTotal = breadTotalCost + pastryTotalCost;
        Console.WriteLine(" ___________________________________");
        Console.WriteLine("|              RECEIPT              |");
        Console.WriteLine("|___________________________________|");
        Console.WriteLine("| Loave(s): " + breadCount); 
        Console.WriteLine("| Free Loave(s): " + freeBread);
        Console.WriteLine("| Total Quantity: " + breadTotal);
        Console.WriteLine("| Loaves Total: $" + breadTotalCost +".00");
        Console.WriteLine("|___________________________________|");
        Console.WriteLine("|                                   |");
        Console.WriteLine("| Pastries (3 ct.): "); Salu
        Console.WriteLine("| Pastries (1 ct.): " + pastrySingles);
        Console.WriteLine("| Total Quantity: " + pastryCount);
        Console.WriteLine("| Pastries Total: $" + pastryTotalCost +".00");
        Console.WriteLine("|___________________________________|");
        Console.WriteLine("| ORDER TOTAL PRICE: $" + receiptTotal + ".00");
        Salutation.salutationPrintout();
      }
      else
      {
        Console.WriteLine("Please Come Again!");
      }
        
    }

    public static void Start()
    {
      string userResponse = Console.ReadLine();
    }
  }
}