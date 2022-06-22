using Programming.Model.Classes;
using System;
using System.Text.RegularExpressions;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные контакта.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Уникальный идентификатор номера контакта.
        /// </summary>
        private int _number;

        /// <summary>
        /// Уникальный идентификатор имени контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Уникальный идентификатор фамилии контакта.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Проверяет, что строка содержит только буквы латинского алфавита.
        /// </summary>
        /// <param name="nameProperty">Проверямая строка.</param>
        /// <param name="value">Имя свойства или объекта, которое подлежит проверке.</param>

        private static void AssertStringContainsOnlyLetters(string nameProperty, string value)
        {
            if (Regex.IsMatch(value, @"^[a-zA-Z]+$") != true)
            {
                throw new ArgumentException(
                    $"Error, {nameProperty} field can consist only of english characters");
            }
        }

        /// <summary>
        /// Возвращает и задает номер контакта. Состоит только из положительного числа.
        /// </summary>
        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Number), value);
                _number = value;
            }
        }

        /// <summary>
        /// Возвращает и задает имя контакта. Состоит только из букв.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                AssertStringContainsOnlyLetters(nameof(Name), value);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает фамилию контакта. Состоит только из букв.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                AssertStringContainsOnlyLetters(nameof(Surname), value);
                _surname = value;
            }
        }
    }
}