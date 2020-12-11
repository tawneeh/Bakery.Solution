using System;
// using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Wecome to Pierre's Bakery!");
      Console.WriteLine("Would you like to order some delicious bread and pastries? If Yes [press 'Y']. Otherwise [press Enter]");
      string response = Console.ReadLine();
      if (response == "Y" || response == "y")
      {
      Console.WriteLine("How many loaves of bread would you like?");
      Bread newBread = new Bread(5, Console.ReadLine());

      int breadTotal = Bread.GetBreadTotalPrice(Console.ReadLine());
      Console.WriteLine("This is your order total: " breadTotal);
      }
      else
      {
        Main();
      }

    }
  }
}