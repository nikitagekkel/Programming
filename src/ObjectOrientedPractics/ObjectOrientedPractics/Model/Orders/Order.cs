using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Хранит данные о заказе
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор ID заказа
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Хранит общую стоимость заказа
        /// </summary>
        public double Ammount { get; }

        /// <summary>
        /// Возвращает и задает адрес покупателя в заказе
        /// </summary>
        public Adress Adress { get; set; }

        /// <summary>
        /// Возвращает и задает список товаров в заказе
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Возвращает и задает дату создания заказа
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Возвращает и задает статус заказа
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Хранит имя покупателя
        /// </summary>
        public string FullName { get; }
       
        /// <summary>
        /// Возвращает и задает скидку на товары.
        /// </summary>
        public double DiscountAmount { get; set; }
        
        /// <summary>
        /// Создает экземпляр класса
        /// </summary>
        /// <param name="ammount">Стоимость заказа</param>
        /// <param name="adress">Адрес доставки</param>
        /// <param name="items">Товары в заказе</param>
        /// <param name="creationDate">Дата создания заказа</param>
        /// <param name="fullName">Имя покупателя</param>
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
