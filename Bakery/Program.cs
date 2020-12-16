using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Wecome to Pierre's Bakery! Bread is $5 and Pastries are $2");
      Console.WriteLine("Would you like to order some delicious bread and pastries? If Yes [press 'Y']. Otherwise [press 'Enter']");
      string response = Console.ReadLine();
      if (response == "Y" || response == "y")
      {
      Console.WriteLine("How many loaves of bread would you like?");
      string loaves = Console.ReadLine();
      int loavesInt = int.Parse(loaves);
      Console.WriteLine("The Price is: $" + loavesInt * 5);
      }
      else
      {
        Main();
      }

    }
  }
}