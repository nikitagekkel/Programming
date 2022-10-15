using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Item
    {

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
        private double _cost;

        /// <summary>
        /// Возвращает и задает жанр книги. 
        /// </summary>
        public int Id { get; set; }

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
                ValueValidator.AssertEmptyValue(value, Name);
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
                ValueValidator.AssertEmptyValue(value, Info);
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задает название книги.
        /// Длина названия не может быть больше 100 символов.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                ValueValidator.AssertFloatInInterval(value, 0, 100000, nameof(Cost));
                _cost = value;
            }
        }

        public Item(
            string name,
            string info,
            float cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Id = IdGenerator.GetNextId();
        }
    }
}
