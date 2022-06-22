using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Производит проверки на положительное число и нахождение в диапозоне.
    /// </summary>
    public static class Validator
    {

        /// <summary>
        /// Проверяет, является ли int число положительным.
        /// </summary>
        /// <param name="value">Число.</param>
        /// <param name="nameProperty">Имя передаваемого аргумента.</param>
        public static void AssertOnPositiveValue(string nameProperty, int value)
        {

            if (value < 0)
            {
                throw new ArgumentException($"Error, {nameProperty} field can consist only of positive values");
            }
        }

        /// <summary>
        /// Проверяет, является ли double число положительным.
        /// </summary>
        /// <param name="value">Число.</param>
        /// <param name="nameProperty">Имя передаваемого аргумента.</param>
        public static void AssertOnPositiveValue(string nameProperty, double value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Error, {nameProperty} field can consist only of postive values");
            }
        }

        /// <summary>
        /// Проверяет, входит ли int число в диапазон.
        /// </summary>
        /// <param name="value">Число.</param>
        /// <param name="nameProperty">Имя передаваемого аргумента.</param>
        /// <param name="min">Начало диапазона.</param>
        /// <param name="max">Конец диапазона.</param>
        public static void AssertValueInRange(string nameProperty, int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Error, value in {nameProperty} field is out of range from {min} to {max}");
            }
        }

        /// <summary>
        /// Проверяет, входит ли double число в диапазон.
        /// </summary>
        /// <param name="value">Число.</param>
        /// <param name="nameProperty">Имя передаваемого аргумента.</param>
        /// <param name="min">Начало диапазона.</param>
        /// <param name="max">Конец диапазона.</param>
        public static void AssertValueInRange(string nameProperty, double value, double min, double max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Error, value in {nameProperty} field is out of range from {min} to {max}");
            }
        }
    }
}
