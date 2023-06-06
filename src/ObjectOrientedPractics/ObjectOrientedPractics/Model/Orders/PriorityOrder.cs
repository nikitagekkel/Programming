using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model.Orders
{
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Время доставки.
        /// </summary>
        private string _deliveryTime;

        public PriorityOrder(double ammount, Adress adress, List<Item> items,
            DateTime creationDate, string fullName, string deliveryTime)
            : base(ammount, adress, items, creationDate, fullName)
        {
            DeliveryTime = deliveryTime;
        }

        /// <summary>
        /// Возвращает и задает время доставки.
        /// </summary>
        public string DeliveryTime
        {
            get => _deliveryTime;
            set => _deliveryTime = value;
        }
    }
}
