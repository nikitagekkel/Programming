using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Customer
    {
        private string _fullName;
        private string _adress;
        public int Id { get; set; }

        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                ValueValidator.AssertEmptyValue(value, nameof(FullName));
                _fullName = value;
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
                ValueValidator.AssertStringOnLength(value, 500, nameof(Adress));
                ValueValidator.AssertEmptyValue(value, nameof(Adress));
                _adress = value;
            }
        }

        public Customer(
            string fullName,
            string adress)
        {
            FullName = fullName;
            Adress = adress;
            Id = IdGenerator.GetNextId();
        }
    }
}
