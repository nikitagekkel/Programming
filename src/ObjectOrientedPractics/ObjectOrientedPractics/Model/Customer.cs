using ObjectOrientedPractics.Services;

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

        /// <summary>
        /// Уникальный идентификатор адреса покупателя
        /// </summary>
        private string _adress;

        /// <summary>
        /// Возвращает и задает уникальный Id покупателя
        /// </summary>
        public int Id { get; set; }

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
        /// Возвращает и задает адрес покупателя.
        /// Адрес не может превышать 500 символов или быть пустым
        /// </summary>
        public string Adress
        {
            get
            {
                return _adress;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Adress));
                ValueValidator.AssertEmptyValue(value, nameof(Adress));
                _adress = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullName">Полное имя покупателя</param>
        /// <param name="adress">Адрес покупателя</param>
        public Customer(
            string fullName,
            string adress)
        {
            FullName = fullName;
            Adress = adress;
            Id = IdGenerator.GetNextId();
        }
    }
}
