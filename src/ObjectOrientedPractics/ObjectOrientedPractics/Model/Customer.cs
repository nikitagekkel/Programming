namespace ObjectOrientedPractics.Model
{
    class Customer
    {
        private int _id;
        private string _fullName;
        private string _adress;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                value = IdGenerator.GetNextId();
                _id = value;
            }
        }

        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
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
                _adress = value;
            }
        }

        public Customer(
            string fullName,
            string adress)
        {
            FullName = fullName;
            Adress = adress;
        }
    }
}
