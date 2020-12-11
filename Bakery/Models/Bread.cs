using System;
using System.Collections.Generic;
namespace Bakery.Models

{
    public class Bread
    {
        private int _price { get; set; }
        public string BreadAmount { get; set; }
        // private static List<Bread> _instances = new List<Bread> {};

        public Bread(int price, string breadAmount)
        {
            _price = 5; // price = 5 * breadAmount as int!!
            BreadAmount = breadAmount;
            // _instances.Add(this);
        }

        public int GetBreadTotalPrice()
        {
            BreadAmount = BreadAmount;
            int breadLoaves = Convert.ToInt32(BreadAmount);
            return _price * breadLoaves;
        }
    }
}