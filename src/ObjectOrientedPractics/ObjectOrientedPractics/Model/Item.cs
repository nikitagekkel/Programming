using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит элемент "Товар" и его данные
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Событие смены имени заказа
        /// </summary>
        public event EventHandler<EventArgs> NameChanged;
        /// <summary>
        /// Событие смены информации о заказе
        /// </summary>

        public event EventHandler<EventArgs> InfoChanged;
        
        /// <summary>
        /// Событие смены имени стоимости заказа
        /// </summary>
        public event EventHandler<EventArgs> CostChanged;
        
        /// <summary>
        /// Уникальный идентификатор названия товара
        /// </summary>
        private string _name;

        /// <summary>
        /// Уникальный идентификатор информации о товаре
        /// </summary>
        private string _info;

        /// <summary>
        /// Уникальный идентификатор стоимости товара
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает и задает уникальный Id товара
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возвращает и задает категорию товара
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает и задает название товара.
        /// Длина названия не может превышать 200 символов
        /// или быть пустой
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                ValueValidator.AssertEmptyValue(value, Name);
                _name = value;
                NameChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Возвращает и задает информацию о товаре.
        /// Длина информации не может превышать 1000 символов
        /// или быть пустой
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                ValueValidator.AssertEmptyValue(value, Info);
                _info = value;
                InfoChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Возвращает и задает цену товара.
        /// Цена должна быть в промежутке от 0 до 100000
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                ValueValidator.AssertFloatInInterval(value, 0, 100000, nameof(Cost));
                _cost = value;
                CostChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>
        /// </summary>
        /// <param name="name">Название товара</param>
        /// <param name="info">Информация о товаре</param>
        /// <param name="cost">Цена товара</param>
        /// <param name="category">Категория товара</param>
        public Item(
            string name,
            string info,
            float cost,
            Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
            Id = ItemIdGenerator.GetNextId();
        }
    }
}
