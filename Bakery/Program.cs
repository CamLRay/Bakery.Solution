public class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to Tender Loaf Bakery");
    Console.WriteLine("Would you like to order Bread or Pastry today? (B):Bread (P):Pastry");
    string select = Console.ReadLine().ToUpper();
    switch(select)
      {
        case "B":
          PastrySelect();
          break;

        case "P":
          BreadSelect();
          break;
      }

  }
  public static void BreadSelect()
  {
    Console.WriteLine("How many loaves of bread would you like? Enter a number ie. 5.")
    int loaves = int.Parse(Console.ReadLine());
    Bread newBreadOrder = new Bread(loaves);
    Console.WriteLine(loaves+ " loaves have been added to your order.");
  }
}