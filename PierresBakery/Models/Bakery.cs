using System;

namespace Bakery.Models
{
  public class Bread
  {
    private static double _BreadCost = 5;
    public int BreadAmount { get; set; }

    public static double breadCost
    {
      get { return _BreadCost; }
      // set { _BreadCost = }
    }

    public Bread(int breadAmount)
    {
      _BreadCost = breadCost;
      BreadAmount = breadAmount;
    }

    public double BreadCost()
    {
      double breadTotal = 0;
      for (int i = 0; i <= BreadAmount; i++)
      {
        if (i % 3 == 0)
        {
          breadTotal += 0;
        }
        else
        {
          breadTotal += breadCost;
        }
      }
      return breadTotal;
    }
  }

  public class Pastry
  {

  }
} 