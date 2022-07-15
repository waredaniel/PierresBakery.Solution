using System;
using Bakery.Models;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("\n---Welcome to Pierre's Bakery---");
      Console.WriteLine("---Home of the finest Breads and Pastries that money can buy---");
      Console.WriteLine("---Our Bread is priced at $5/loaf (or buy 2 get 1 free)");

      Console.WriteLine("\nWould you like to place an order? (Y/N)");
      string initialResponse = Console.ReadLine();
      if (initialResponse.ToLower() == "y" || initialResponse.ToLower() == "yes")
      {
        Console.WriteLine("Great, how many loaves of Bread would you like?");
        int breadOrder = int.Parse(Console.ReadLine());
        var orderBread = new Bread(breadOrder);
        Console.WriteLine("Fantastic. " + orderBread.BreadAmount + " loaves will run you " + orderBread.BreadCost());
      }
      else 
      {
        Console.WriteLine("We hope you change your mind!");
      }
    }
  }
}