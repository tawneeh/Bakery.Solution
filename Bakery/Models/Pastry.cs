using System.Collections.Generic;
namespace Bakery.Models

{
    public class Pastry
    {
        public string PastryAmount { get; set; }
        private static List<Pastry> _instances = new List<Pastry> {};

        public Pastry(int price, string pastryAmount)
        {
            price = 2;
            PastryAmount = pastryAmount;
            _instances.Add(this);
        }

    }
}