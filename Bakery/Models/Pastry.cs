using System;
using System.Collections.Generic;
namespace Bakery.Models

{
    public class Pastry
    {
        private int _price { get; set; }
        public string PastryAmount { get; set; }
        private static List<Pastry> _instances = new List<Pastry> {};

        public Pastry(int price, string pastryAmount)
        {
            _price = 2;
            PastryAmount = pastryAmount;
            _instances.Add(this);
        }
        public int GetPastryTotalPrice()
        {
            PastryAmount = PastryAmount;
            int pastries = Convert.ToInt32(PastryAmount);
            return _price * pastries;
        }

    }
}