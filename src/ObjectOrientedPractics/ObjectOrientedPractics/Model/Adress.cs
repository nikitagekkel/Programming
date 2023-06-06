using ObjectOrientedPractics.Services;
using System;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит элемент "Адрес" и его данные
    /// </summary>
    public class Adress
    {
        /// <summary>
        /// Событие возникающее при смене адреса
        /// </summary>
        public EventHandler<EventArgs> AddressChanged;

        /// <summary>
        /// Уникальный идентификатор индекса в адресе
        /// </summary>
        private int _index;

        /// <summary>
        /// Уникальный идентификатор страны в адресе
        /// </summary>
        private string _country;

        /// <summary>
        /// Уникальный идентификатор страны в адресе
        /// </summary>
        private string _city;

        /// <summary>
        /// Уникальный идентификатор улицы в адресе
        /// </summary>
        private string _street;

        /// <summary>
        /// Уникальный идентификатор номера дома в адресе
        /// </summary>
        private string _building;
        /// <summary>
        /// Уникальный идентификатор квартиры в адресе
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Вовзращает и задает индекс в адресе.
        /// Длина адреса не может превышать 6 символов
        /// или быть пустой
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                ValueValidator.AssertIntInInterval(value, 0, 6, nameof(Index));
                _index = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Вовзращает и задает страну в адресе.
        /// Длина названия страны не может превышать
        /// 50 символов или быть пустой
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                ValueValidator.AssertEmptyValue(value, nameof(Country));
                _country = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Вовзращает и задает
        /// название города в адресе.
        /// Длина названия города не может превышать
        /// 50 символов или быть пустой
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                ValueValidator.AssertEmptyValue(value, nameof(City));
                _city = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Вовзращает и задает
        /// название улицы в адресе.
        /// Длина адреса не может
        /// превышать 6 символов или быть пустой
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                ValueValidator.AssertEmptyValue(value, nameof(Street));
                _street = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Вовзращает и задает
        /// номер строения в адресе.
        /// Длина адреса не может превышать
        /// 10 символов или быть пустой
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                ValueValidator.AssertEmptyValue(value, nameof(Building));
                _building = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Вовзращает и задает
        /// номер квартиры в адресе.
        /// Длина номера квартиры не может превышать
        /// 6 символов или быть пустой
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                ValueValidator.AssertEmptyValue(value, nameof(Apartment));
                _apartment = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Adress"/>
        /// </summary>
        /// <param name="index">Индекс в адресе</param>
        /// <param name="country">Страна в адресе</param>
        /// <param name="city">Город в адресе</param>
        /// <param name="street">Улица в адресе</param>
        /// <param name="building">Номер строения
        /// в адресе</param>
        /// <param name="apartment">Номер квартиры
        /// в адресе</param>
        public Adress(
            int index,
            string country,
            string city,
            string street,
            string building,
            string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
