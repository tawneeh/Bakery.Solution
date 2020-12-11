using System.Collections.Generic;
namespace Bakery.Models

{
    public class Bread
    {
        private int _price { get; set; }
        public int BreadAmount { get; set; }
        // private static List<Bread> _instances = new List<Bread> {};

        public Bread(int price, int breadAmount)
        {
            _price = 5 * breadAmount;
            BreadAmount = breadAmount;
            // _instances.Add(this);
        }
    }
}