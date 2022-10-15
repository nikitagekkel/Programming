using System;

namespace ObjectOrientedPractics.Services
{
    class ValueValidator
    {
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} must be less than {maxLength}");
            }
        }

        public static void AssertFloatInInterval(double value, int minLength, int maxLength, string propertyName)
        {
            if (value < minLength | value > maxLength)
            {
                throw new ArgumentException($"{propertyName} must be from {minLength} to {maxLength}");
            }
        }

        public static void AssertEmptyValue(string value, string propertyName)
        {
            if (value == "")
            {
                throw new ArgumentException($"Field must be not empty {propertyName}");
            }
        }
    }
}