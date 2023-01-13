using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Services;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит элемент "Покупатель" и его данные
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Уникальный идентификатор полного имени покупателя
        /// </summary>
        private string _fullName;
        public List<Item> Items { get; set; }
        public List<Order> Orders { get; set; }
        public Cart Cart { get; }

        /// <summary>
        /// Уникальный идентификатор адреса покупателя
        /// </summary>
        public Adress Adress { get; set; }

        /// <summary>
        /// Возвращает и задает уникальный Id покупателя
        /// </summary>
        public int Id { get; }
        public bool IsPriority { get; set; }
        public List<IDiscount> Discounts { get; set; }


        /// <summary>
        /// Возвращает и задает полное имя покупателя.
        /// Имя не должно превышать 200 символов или быть пустым
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                ValueValidator.AssertEmptyValue(value, nameof(FullName));
                _fullName = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullName">Полное имя покупателя</param>
        /// <param name="adress">Адрес покупателя</param>
        public Customer(
            List<Item> items,
            List <Order> orders,
            string fullName,
            Adress adress,
            bool isPriority)
        {
            Items = items;
            Orders = orders;
            Cart = new Cart(Items)
            {
                Items = Items
            };
            FullName = fullName;
            Adress = adress;
            Id = CustomerIdGenerator.GetNextId();
            IsPriority = isPriority;
            Discounts = new List<IDiscount>
            {
                new PointsDiscount()
            };
        }
    }
}
