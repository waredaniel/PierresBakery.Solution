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
      if (initialResponse.ToLower() == "y")
      {
        Console.WriteLine("Great, how many loaves of Bread would you like?");
        int breadAmount = int.Parse(Console.ReadLine());
        Console.WriteLine("");
      }
      else 
      {
        Console.WriteLine("We hope you change your mind!");
      }
    }
  }
}