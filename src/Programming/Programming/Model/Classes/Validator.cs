using System;

namespace Programming.Model.Geometry
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(string nameProperty, int value)
        {

            if (value < 0)
            {
                throw new ArgumentException($"Error, {nameProperty} field can consist only of positive values");
            }
        }

        public static void AssertOnPositiveValue(string nameProperty, double value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Error, {nameProperty} field can consist only of postive values");
            }
        }

        public static void AssertValueInRange(string nameProperty, int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Error, value in {nameProperty} field is out of range from {min} to {max}");
            }
        }

        public static void AssertValueInRange(string nameProperty, double value, double min, double max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Error, value in {nameProperty} field is out of range from {min} to {max}");
            }
        }
    }
}
