using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationData.Models
{
    public class PartSearch
    {
        public int Quantity { get; }

        public int Price { get; }

        internal PartSearch(int quantity, int price)
        {
            Quantity = quantity;
            Price = price;
        }
    }
}
