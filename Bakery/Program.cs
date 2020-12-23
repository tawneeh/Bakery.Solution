using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Bonjour! Wecome to Pierre's Bakery. Bread is $5 and Pastries are $2. We also offer special deals!");
      Console.WriteLine("Would you like to order some delicious bread and pastries? If Yes [press 'Y']. Otherwise [press 'Enter'].");
      string response = Console.ReadLine();
      if (response == "Y" || response == "y")
      {
        Console.WriteLine("How many loaves of bread would you like?");
        string loaves = Console.ReadLine();
        int loavesInt = int.Parse(loaves);
        Bread newBread = new Bread(loavesInt);
        int breadPrice = newBread.GetBreadPrice();
        Console.WriteLine("The Price for your bread is: $" + breadPrice + ".");
        Console.WriteLine("How many pastries would you like?");
        string pastries = Console.ReadLine();
        int pastryInt = int.Parse(pastries);
        Pastry newPastry = new Pastry(pastryInt);
        int pastryPrice = newPastry.GetPastryPrice();
        Console.WriteLine("The Price for your pastries is $" + pastryPrice + ".");
        Console.WriteLine("Your grand total today is $" + (breadPrice + pastryPrice) + ". Bon appetit!");
        Console.WriteLine("Would you like to place another order? If Yes [press 'Y']. Otherwise [press 'Enter'].");
        string response2 = Console.ReadLine();
        if (response2 == "Y" || response2 == "y")
        {
          Main();
        }
        else
        {
          Console.WriteLine("Au revior!");
        }
      }
      else
      {   
        Main();
      }
    }
  }
}