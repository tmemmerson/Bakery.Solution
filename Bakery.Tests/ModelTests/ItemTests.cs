using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void OrderPrompt_PromptingTheCustomerForOrderItems_Yes()
    {
      Console.WriteLine("Welcome to Emmerson's Bakery!")
      Console.WriteLine("______________________________")
      Console.WriteLine("A loaf of bread is $5, or buy 2 and get 1 free!")
      Console.WriteLine("Our pastries are $2 or 3 for $5")
      Console.WriteLine("______________________________")
      Console.WriteLine("Would you like to place an order? Yes/No")

      Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    }

  }
}