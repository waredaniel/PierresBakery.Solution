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
        if (i == 0)
        {
          breadTotal += 0;
        }
        else if (i % 3 == 0)
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
    private static double _PastryCost = 2;
    public int PastryAmount { get; set; }

    public static double pastryCost
    {
      get { return _PastryCost; }
    }

    public Pastry(int pastryAmount)
    {
      _PastryCost = pastryCost;
      PastryAmount = pastryAmount;
    }

    public double PastryCost()
    {
      double pastryTotal = 0;
      double pastryDiscount = (0.5 * pastryCost);
      for (int i = 0; i <= PastryAmount; i++)
      {
        if (i == 0)
        {
          pastryTotal += 0;
        }
        else if (i % 3 == 0)
        {
          pastryTotal += pastryDiscount ;
        }
        else
        {
          pastryTotal += pastryCost;
        }
      }
      return pastryTotal;
    }
  }
} 