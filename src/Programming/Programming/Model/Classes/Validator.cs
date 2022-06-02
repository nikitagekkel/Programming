using System;

namespace Programming.Model.Classes
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(string nameProperty, int value)
        {
            
            if (value < 0)
            {
                throw new ArgumentException($"Error, {nameProperty} field can consist only of english characters");
            }
        }
        public static void AssertOnPositiveValue(string nameProperty, double value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Error, {nameProperty} field can consist only of english characters");
            }
        }
    }
}
