using System.Collections.Generic;
namespace Bakery.Models

{
    public class Bread
    {
        public string BreadAmount { get; set; }
        private static List<Bread> _instances = new List<Bread> {};

        public Bread(int price, string breadAmount)
        {
            price = 5;
            BreadAmount = breadAmount;
            _instances.Add(this);
        }

    }
}