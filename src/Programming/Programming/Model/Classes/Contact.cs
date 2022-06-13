using System;
using System.Text.RegularExpressions;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private int _number;

        private string _name;
        private string _surname;
        private static void AssertStringContainsOnlyLetters(string nameProperty, string value)
        {
            if (Regex.IsMatch(value, @"^[a-zA-Z]+$") != true)
            {
                throw new ArgumentException($"Error, {nameProperty} field can consist only of english characters");
            }
        }
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