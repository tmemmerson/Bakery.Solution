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
      Console.WriteLine("Welcome to Emmerson's Bakery");
      Start();
    }

    public static void Start()
    {
      Console.WriteLine("welcome to bakery");


      string userResponse = Console.ReadLine();


      Start();
    }
  }
}