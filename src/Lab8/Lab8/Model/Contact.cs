using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Model
{
    public class Contact
    {
        public EventHandler<EventArgs> ContactChanged;
        private string _fullName;
        private string _phoneNumber;
        private string _adress;
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                _fullName = value;
                ContactChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
                ContactChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public string Adress
        {
            get
            {
                return _adress;
            }
            set
            {
                _adress = value;
                ContactChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public Contact(
            string fullName,
            string phoneNumber,
            string adress)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Adress = adress;
        }
    }
}
