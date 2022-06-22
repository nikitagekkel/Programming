using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит прямоугольник и его данные.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Уникальный идентификатор высоты прямоугольника.
        /// </summary>
        private double _height;

        /// <summary>
        /// Уникальный идентификатор ширины прямоугольника.
        /// </summary>
        private double _width;

        /// <summary>
        /// Уникальный идентификатор Id прямоугольника.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Возвращает идентификатор Id прямоугольника. Не может быть изменен.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возвращает и задает цвет прямоугольника. 
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает и задает координаты X и Y прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задает высоту прямоугольника. Состоит только из положительного числа.
        /// </summary>
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Height), value);
                _height = value;
            }
        }

        /// <summary>
        /// Возвращает и задает ширину прямоугольника. Состоит только из положительного числа.
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Width), value);
                _width = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="height">Высота. Должна состоять только из
        /// положительного числа.</param>
        /// <param name="width">Ширина. Должна состоять только из
        /// положительного числа.</param>
        /// <param name="color">Цвет. Должнен состоять
        /// только из букв.</param>
        /// <param name="center">Координаты X и Y. должны состоять
        /// только из положительных цифр.</param>
        public Rectangle(
            double height,
            double width,
            string color,
            Point2D center)
        {
            Height = height;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            Id = _allRectanglesCount;
        }
    }
}
