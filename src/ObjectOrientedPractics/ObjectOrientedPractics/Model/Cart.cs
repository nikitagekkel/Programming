using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Model
{
    public class Cart
    {
        public List<Item> Items { get; set; }
        private double _ammount;
        public double Ammount
        {
            get
            {
                _ammount = 0;
                if (Items.Count != 0)
                {
                    foreach (Item item in Items)
                    {
                        _ammount += item.Cost;
                    }
                }
                return _ammount;
            }
        }

        public Cart(
            List<Item> items)
        {
            Items = items;
        }
    }
}
