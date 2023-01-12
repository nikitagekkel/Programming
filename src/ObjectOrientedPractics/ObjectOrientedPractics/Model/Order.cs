using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {
        public int Id { get; }
        public double Ammount { get; }
        public Adress Adress { get; set; }
        public List<Item> Items { get; set; }
        public DateTime CreationDate { get; set; }
        public OrderStatus Status { get; set; }
        public string FullName { get; }
        public Order(
            double ammount,
            Adress adress,
            List<Item> items,
            DateTime creationDate,
            string fullName)
        {
            Id = OrderIdGenerator.GetNextId();
            Ammount = ammount;
            Adress = adress;
            Items = items;
            CreationDate = creationDate;
            Status = OrderStatus.New;
            FullName = fullName;
        }
    }
}
