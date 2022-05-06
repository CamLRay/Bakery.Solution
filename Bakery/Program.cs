using System;
using System.Collections.Generic;
using Bakery;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to Tender Loaf Bakery");
    Shopping();
  }

  static void Shopping()
  {
  Console.WriteLine("Would you like to order Bread or Pastry today? (B):Bread (P):Pastry");
  string select = Console.ReadLine().ToUpper();
  switch(select)
    {
      case "P":
        PastrySelect();
        break;

      case "PASTRY":
        PastrySelect();
        break;

      case "B":
        BreadSelect();
        break;

      case "BREAD":
        BreadSelect();
        break;

      default:
        Console.WriteLine("Please select Bread or Pastry.");
        Shopping();
        break;
    }

  Console.WriteLine("Would you like to order anything else? (Y/N)");
  string selectMore = Console.ReadLine().ToUpper();
  switch(selectMore)
    {
      case "Y":
        Shopping();
        break;

      default:
        FinalizeOrder();
        break;
    } 
  }

  public static void FinalizeOrder()
  {
    string total = (Bread.PriceCalc() + Pastry.PriceCalc()).ToString();
    DisplayOrder();
    Console.WriteLine("Is your order correct? (Y/N)");
    switch(Console.ReadLine().ToUpper())
    {
      case "N":
        Bread.ClearAll();
        Pastry.ClearAll();
        Console.WriteLine("Your order has been cleared, please resubmit your order.");
        Shopping();
        break;

      default:
        Console.WriteLine("Your total is $" + total +". Thank you for shopping at Tender Loaf Bakery");
        break;
    }
  }

  public static void BreadSelect()
  {
    Console.WriteLine("How many loaves of bread would you like? Enter a number ie. 5.");
    int loaves = int.Parse(Console.ReadLine());
    Bread newBreadOrder = new Bread(loaves);
    Console.WriteLine(loaves+ " loaves have been added to your order. Total bread cost is $" + Bread.PriceCalc().ToString() + ".");
  }

  public static void PastrySelect()
  {
    Console.WriteLine("How many pastries would you like? Enter a number ie. 5.");
    int pastries = int.Parse(Console.ReadLine());
    Pastry newBreadOrder = new Pastry(pastries);
    Console.WriteLine(pastries+ " pastries have been added to your order. Total pastry cost is $" +Pastry.PriceCalc().ToString() + ".");
  }

  public static void DisplayOrder()
  {
    List<Bread> breadOrder = Bread.GetOrder();
    List<Pastry> pastryOrder = Pastry.GetOrder();
    if(breadOrder.Count > 0)
    {
      Console.WriteLine("Your bread order is:");
      for(int i = 0; i < breadOrder.Count; i++)
      {
        Console.WriteLine((i+1).ToString() + ": " + breadOrder[i].Type);
      }
    }
    if(pastryOrder.Count > 0)
    {
      Console.WriteLine("Your Pastry order is:");
      for(int i = 0; i < pastryOrder.Count; i++)
      {
        Console.WriteLine((i+1).ToString() + ": " + pastryOrder[i].Type);
      }
    }
  }
}