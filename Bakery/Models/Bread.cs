using System.Collections.Generic;

namespace Bakery
{
  public class Bread
  {
    private static List<Bread> _breadOrders = new List<Bread> {};

    public Bread()
    {_breadOrders.Add(this);
    }
  }
}