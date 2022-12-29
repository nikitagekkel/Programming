using System;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Реализует валидацию данных
    /// </summary>
    class ValueValidator
    {
        /// <summary>
        /// Реализует валидацию данных типа <see cref="string"/>
        /// по максимальной длине
        /// </summary>
        /// <param name="value">Переданный элемент</param>
        /// <param name="maxLength">Максимальная допустимая длина</param>
        /// <param name="propertyName">Переданное название элемента</param>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} must be less than {maxLength}");
            }
        }

        /// <summary>
        /// Реализует валидацию данных типа <see cref="double"/>
        /// по минимальной и максимальной длине
        /// </summary>
        /// <param name="value">Переданный элемент</param>
        /// <param name="minLength">Минимальная допустимая длина</param>
        /// <param name="maxLength">Максимальная допустимая длина</param>
        /// <param name="propertyName">Переданное название элемента</param>
        public static void AssertFloatInInterval(
            double value, int minLength, int maxLength, string propertyName)
        {
            if (value < minLength | value > maxLength)
            {
                throw new ArgumentException(
                    $"{propertyName} must be from {minLength} to {maxLength}");
            }
        }

        /// <summary>
        /// Реализует валидацию данных типа <see cref="int"/>
        /// по минимальной и максимальной длине
        /// </summary>
        /// <param name="value">Переданный элемент</param>
        /// <param name="minLength">Минимальная допустимая длина</param>
        /// <param name="maxLength">Максимальная допустимая длина</param>
        /// <param name="propertyName">Переданное название элемента</param>
        public static void AssertIntInInterval(
            int value, int minLength, int maxLength, string propertyName)
        {
            if (value < minLength | value > maxLength)
            {
                throw new ArgumentException(
                    $"{propertyName} must be from {minLength} to {maxLength}");
            }
        }

        /// <summary>
        /// Реализует валидацию элемента типа <see cref="string"/>
        /// по тому, является ли элемент пустым
        /// </summary>
        /// <param name="value">Переданный элемент</param>
        /// <param name="propertyName">Название переданного элемента</param>
        public static void AssertEmptyValue(string value, string propertyName)
        {
            if (value == "")
            {
                throw new ArgumentException($"Field must be not empty {propertyName}");
            }
        }
    }
}