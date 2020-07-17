using Bakery;
using Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery
{
  public class Bakery
  {
    static void Main()
    {
      Console.WriteLine("     _|=|__________");
      Console.WriteLine("    /               ");
      Console.WriteLine("   /Emmerson's Bakery");
      Console.WriteLine("  /__________________ ");
      Console.WriteLine("   ||  || /--| ||  ||");
      Console.WriteLine("   ||  || | .| ||  ||");
      Console.WriteLine("   ||__||_|__|_||__||");
      Console.WriteLine("   |-|-|-|====|-|-|-| ");
      Console.WriteLine("^^^^^^^^^^====^^^^^^^^^^^");
      Console.WriteLine("Welcome to Emmerson's Bakery");
      Console.WriteLine("----------------------------");
      Console.WriteLine(" ");
      Console.WriteLine("Menu:");
      Console.WriteLine(" ");
      Console.WriteLine("Loaves of Made-Fresh Bread: $5/ea");
      Console.WriteLine("Assorted Pastries: $2/ea");
      Console.WriteLine(" ");
      Console.WriteLine(" ____________Current Promotions_____________");
      Console.WriteLine("|                                           |");
      Console.WriteLine("|     Pastries Promotion: 3x for $5         |");          
      Console.WriteLine("|     Bread Promotion: Buy 2 Get 1 Free     |");
      Console.WriteLine("|___________________________________________|");
      Console.WriteLine("Would you like to place an order? Y/N");
      string orderResponse =  Console.ReadLine();
      if (orderResponse == "yes" || orderResponse == "Y" || orderResponse == "y") //need to implement toUpper to standardize string evaluation
      {
        Console.WriteLine("How many loaves of bread would you like to purchase?");
        string breadResponse = Console.ReadLine();
        Console.WriteLine("Bread Loaves: " + breadResponse);
        Console.WriteLine("How many pastries would you like to purchase?");
        string pastryResponse = Console.ReadLine();
        Console.WriteLine("Bread Loaves: " + breadResponse);
        Console.WriteLine("Pastries: " + pastryResponse);
        int breadCount = Int32.Parse(breadResponse);
        int pastryCount = Int32.Parse(pastryResponse);
        int freeBread = breadCount / 2;
        int pastryDiscountedBundles = pastryCount / 3;
        int pastrySingles = pastryCount % 3;
        int breadTotal = breadCount + freeBread;
        Console.WriteLine(" ________Receipt____________________");
        Console.WriteLine("|                                   |");
        Console.WriteLine("| Loave(s): " + breadCount); 
        Console.WriteLine("| Free Loave(s): " + freeBread);
        Console.WriteLine("| Total: " + breadTotal);
        Console.WriteLine("|___________________________________|");
        Console.WriteLine("| Pastries (3 ct.): " + pastryDiscountedBundles);
        Console.WriteLine("| Pastries (1 ct.): " + pastrySingles);
        Console.WriteLine("| Total: " + pastryCount);
        Console.WriteLine("|___________________________________|");
      }
      else
      {
        Console.WriteLine("Please Come Again!");
      }
        



     /*  Start(); */
    }

    public static void Start()
    {


      string userResponse = Console.ReadLine();


      /* Start(); */
    }
  }
}