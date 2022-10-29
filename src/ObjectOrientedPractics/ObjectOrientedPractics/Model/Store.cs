using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит списки всех товаров
    /// и покупателей
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Уникальный идентификатор списка товаров
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Уникальный идентификатор списка покупателей
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Возвращает и задает список товаров
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Возвращает и задает список покупателей
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса
        /// <see cref="Store"/>
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <param name="customers">Список покупателей</param>
        public Store(
            List<Item> items,
            List<Customer> customers)
        {
            Items = items;
            Customers = customers;
        }
    }
}
