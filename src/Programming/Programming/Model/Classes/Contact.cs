using System;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private int _contactNumber;

        public string ContactName { get; set; }
        public string ContactSecondName { get; set; }
        
        public int ContacttNumber
        {
            get
            {
                return _contactNumber;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Error");
                }
                _contactNumber = value;
            }
        }
    }
}
