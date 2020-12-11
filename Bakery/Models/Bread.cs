using System.Collections.Generic;
namespace Bakery.Models

{
    public class Bread
    {
        private int _price { get; set; }

        public Bread(string price) // should be int (good fail)
        {
            _price = _price;
        }
    }
}
