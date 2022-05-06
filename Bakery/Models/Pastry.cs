using System.Collections.Generic;

namespace Bakery
{
  public class Pastry
  {
    public string Type { get; set; }
    private static List<Pastry> _PastryOrder = new List<Pastry> {};

    public Pastry()
    {
      Type = "Pastry of the day";
      _PastryOrder.Add(this);
    }
    public Pastry(int num)
    {
      Type = "Pastry of the day";
      for (int i = 0; i < num; i++)
      {
        _PastryOrder.Add(this);
      }
    }

    public Pastry(int num, string type)
    {
      Type = type;
      for (int i = 0; i < num; i++)
      {
        _PastryOrder.Add(this);
      }
    }
    
    public static List<Pastry> GetOrder()
    {
      return _PastryOrder;
    }

    public static void ClearAll()
    {
      _PastryOrder.Clear();
    }

    public static int PriceCalc()
    {
      int PastryTotal = 0;
      for(int i = 1; i <= _PastryOrder.Count; i++)
      {
        if((i % 3) != 0)
        {
          PastryTotal += 2;
        }
        else
        {
          PastryTotal++;
        }
      }
      return PastryTotal;
    }
  }
}