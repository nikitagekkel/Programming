namespace Task3
{
    public class Person
    {
        private int _age;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0)
                {
                    _age = value;
                }
            }
        }

        public Person(string firstName,
            string lastName,
            int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}