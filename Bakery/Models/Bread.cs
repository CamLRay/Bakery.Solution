using System.Collections.Generic;

namespace Bakery
{
  public class Bread
  {
    private static List<Bread> _breadOrder = new List<Bread> {};

    public Bread()
    {
      _breadOrder.Add(this);
    }
    public Bread(int num)
    {
      for (int i = 0; i < num; i++)
      {
        _breadOrder.Add(this);
      }
    }

    public static List<Bread> GetOrder()
    {
      return _breadOrder;
    }

    public static void ClearAll()
    {
      _breadOrder.Clear();
    }

    public static int PriceCalc()
    {
      int breadTotal = 0;
      for(int i = 1; i <= _breadOrder.Count; i++)
      {
        if((i % 3) != 0)
        {
          breadTotal += 5;
        }
      }
      return breadTotal;
    }
  }
}