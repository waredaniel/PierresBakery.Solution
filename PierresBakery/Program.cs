using System;
using Bakery.Models;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("\n--- Welcome to Pierre's Bakery ---");
      Console.WriteLine("--- Home of the Finest Breads and Pastries that Money Can Buy ---");
      Console.WriteLine("--- Our Bread is priced at $5/loaf (or buy 2 get 1 free!) ---");
      Console.WriteLine("--- Pastries are currently $2 each (or 3 for $5!) ---");
      Console.WriteLine("\nWould you like to place an order? (Y/N)");
      string initialResponse = Console.ReadLine();
      if (initialResponse.ToLower() == "y" || initialResponse.ToLower() == "yes")
      {
        //Bread Order
         Console.WriteLine("\nGreat, how many loaves of Bread would you like?");
        int breadOrder = int.Parse(Console.ReadLine());
        var orderBread = new Bread(breadOrder);
        Console.WriteLine("\nFantastic. " + orderBread.BreadAmount + " loaves will run you $" + orderBread.BreadCost());
        //Pastry Order
        Console.WriteLine("\nHow many Pastries would you like to add to your order?");
        int pastryOrder = int.Parse(Console.ReadLine());
        var orderPastry = new Pastry(pastryOrder);
        Console.WriteLine("\nOk. " + orderPastry.PastryAmount + " pastries will come to $" + orderPastry.PastryCost());
        //Checkout
        double orderTotal = (orderPastry.PastryCost() + orderBread.BreadCost());
        Console.WriteLine("\nAlright, let me just box that up for you. I'm sure you'll enjoy our baked goods!");
        Console.WriteLine("\nYour order comes to $" + orderTotal + ". Have a wonderful day!");
      }
      else 
      {
        Console.WriteLine("Come back soon, we hope you change your mind!");
      }
    }
      // public static void OrderBread()
      // {
      //   Console.WriteLine("Great, how many loaves of Bread would you like?");
      //   int breadOrder = int.Parse(Console.ReadLine());
      //   var orderBread = new Bread(breadOrder);
      //   Console.WriteLine("Fantastic. " + orderBread.BreadAmount + " loaves will run you $" + orderBread.BreadCost());
      //   OrderPastry();

      // }
      // public static void OrderPastry()
      // {
      //   Console.WriteLine("Would you like to add any Pastries to your order?");
      //   int pastryOrder = int.Parse(Console.ReadLine());
      //   var orderPastry = new Pastry(pastryOrder);
      //   Console.WriteLine("Ok. " + orderPastry.PastryAmount + " pastries will come to $" + orderPastry.PastryCost());
      //   OrderTotal();

      // }
      // public static double OrderTotal()
      // {
      //   double orderTotal = (orderPastry.PastryCost);
      //   Console.WriteLine("Alright, let me just box that up for you. I'm sure you'll enjoy our baked goods");
      //   Console.WriteLine("Your order somes to $" + orderTotal);
      // }
  }
}