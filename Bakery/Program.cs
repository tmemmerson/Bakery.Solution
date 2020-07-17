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
      Console.WriteLine("             _|=|__________");
      Console.WriteLine("            /               ");
      Console.WriteLine("           /Emmerson's Bakery");
      Console.WriteLine("          /__________________ ");
      Console.WriteLine("           ||  || /--| ||  ||");
      Console.WriteLine("           ||  || | .| ||  ||");
      Console.WriteLine("           ||__||_|__|_||__||");
      Console.WriteLine("           |-|-|-|====|-|-|-| ");
      Console.WriteLine("        ^^^^^^^^^^====^^^^^^^^^^^");
      Console.WriteLine(" ");
      Console.WriteLine("      ----------------------------");      
      Console.WriteLine("      Welcome to Emmerson's Bakery");
      Console.WriteLine("      ----------------------------");
      Console.WriteLine(" ");
      Console.WriteLine(" ____________________MENU____________________");
      Console.WriteLine("|                                            |");
      Console.WriteLine("|     Loaves of Freshly Made Bread: $5/ea    |");
      Console.WriteLine("|     Assorted Pastries: $2/ea               |");
      Console.WriteLine("|                                            |");
      Console.WriteLine("|____________________________________________|");
      Console.WriteLine(" ");
      Console.WriteLine(" _____________Current Promotions_____________");
      Console.WriteLine("|                                            |");
      Console.WriteLine("|      Pastries Promotion: 3x for $5         |");          
      Console.WriteLine("|      Bread Promotion: Buy 2 Get 1 Free     |");
      Console.WriteLine("|____________________________________________|");
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
        int freeBread = breadCount / 2;
        int pastryBundles = pastryCount / 3;
        int pastrySingles = pastryCount % 3;
        int breadTotal = breadCount + freeBread;
        int pastrySinglesCost = pastrySingles * 2;
        int pastryBundlesCost = pastryBundles * 5;
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
        Console.WriteLine("| Pastries (3 ct.): " + pastryBundles);
        Console.WriteLine("| Pastries (1 ct.): " + pastrySingles);
        Console.WriteLine("| Total Quantity: " + pastryCount);
        Console.WriteLine("| Pastries Total: $" + pastryTotalCost +".00");
        Console.WriteLine("|___________________________________|");
        Console.WriteLine("| ORDER TOTAL PRICE: $" + receiptTotal + ".00");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("     888888 88  88    db    88b 88 88  dP     Yb  dP  dP''Yb 88   88");
        Console.WriteLine("       88   88  88   dPYb   88Yb88 88odP       YbdP  dP   Yb 88   88");
        Console.WriteLine("       88   888888  dP__Yb  88 Y88 88'Yb        8P   Yb   dP Y8   8P");
        Console.WriteLine("       88   88  88 dP'  'Yb 88  Y8 88  Yb      dP     YbodP  `YbodP'");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("                            _|=|__________");
        Console.WriteLine("                           /               ");
        Console.WriteLine("                          /Emmerson's Bakery");
        Console.WriteLine("                         /__________________ ");
        Console.WriteLine("                          ||  || /--| ||  ||");
        Console.WriteLine("                          ||  || | .| ||  ||");
        Console.WriteLine("                          ||__||_|__|_||__||");
        Console.WriteLine("                          |-|-|-|====|-|-|-| ");
        Console.WriteLine("                       ^^^^^^^^^^====^^^^^^^^^^^");
        Console.WriteLine(" ");
        Console.WriteLine("                     ----------------------------");      
        Console.WriteLine("                          Please Come Again!");
        Console.WriteLine("                     ----------------------------");
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