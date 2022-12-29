using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {
        public Customer Customer { get; set; }
        public int Id { get; }
        public double Ammount { get; }
        public Adress Adress { get; set; }
        public List<Item> Items { get; set; }
        public DateTime CreationDate { get; }

        public Order(
            Customer customer)
        {
            Customer = customer;
            Id = Customer.Id;
            Ammount = Customer.Cart.Ammount;
            Adress = Customer.Adress;
            Items = Customer.Items;
            CreationDate = DateTime.UtcNow;
        }
    }
}
