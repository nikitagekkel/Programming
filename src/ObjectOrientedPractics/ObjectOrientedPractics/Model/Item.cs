namespace ObjectOrientedPractics.Model
{
    public class Item
    {
        /// <summary>
        /// Возвращает и задает жанр книги. 
        /// </summary>
        private int _id;

        /// <summary>
        /// Уникальный идентификатор названия книги.
        /// </summary>
        private string _name;

        /// <summary>
        /// Уникальный идентификатор года выпуска книги.
        /// </summary>
        private string _info;

        /// <summary>
        /// Уникальный идентификатор количества страниц книги.
        /// </summary>
        private float _coast;

        /// <summary>
        /// Возвращает и задает название книги.
        /// Длина названия не может быть больше 100 символов.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает название книги.
        /// Длина названия не может быть больше 100 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает название книги.
        /// Длина названия не может быть больше 100 символов.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задает название книги.
        /// Длина названия не может быть больше 100 символов.
        /// </summary>
        public float Coast
        {
            get
            {
                return _coast;
            }
            set
            {
                ValueValidator.AssertFloatInInterval(value, 0, 100000, nameof(Coast));
                _coast = value;
            }
        }

        public Item(
            string name,
            string info,
            float coast)
        {
            Name = name;
            Info = info;
            Coast = coast;
        }
    }
}
