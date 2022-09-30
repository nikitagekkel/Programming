using System;

namespace ObjectOrientedPractics.Model
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

        public static void AssertFloatInInterval(float value, int minLength, int maxLength, string propertyName)
        {
            if (value < minLength | value > maxLength)
            {
                throw new ArgumentException($"{propertyName} must be from {minLength} to {maxLength}");
            }
        }
    }
}