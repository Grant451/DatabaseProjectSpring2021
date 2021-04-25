using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationData.Models
{
    public class PartSearch
    {
        public string PartName { get; }
        public int Quantity { get; }
        public string Price { get; }
        public string QuantityStatus { get; }

        internal PartSearch(string partname, int quantity, string quantityStatus)
        {
            Quantity = quantity;
            PartName = partname;
            QuantityStatus = quantityStatus;
        }

        internal PartSearch(int quantity, string price)
        {
            Quantity = quantity;
            Price = price;
        }

        internal PartSearch(string partName, string price)
        {
            PartName = partName;
            Price = price;
        }
    }
}
