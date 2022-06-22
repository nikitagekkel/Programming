using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные координат.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Уникальный идентификатор точки X.
        /// </summary>
        private int _x;

        /// <summary>
        /// Уникальный идентификатор точки Y.
        /// </summary>
        private int _y;

        /// <summary>
        /// Возвращает и задает координату X. Может быть только пложительным числом.
        /// </summary>
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(X), value);
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задает координату Y. Может быть только пложительным числом.
        /// </summary>
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Y), value);
                _y = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата X. Состоит из числа.</param>
        /// <param name="y">Координата Y. Состоит из числа.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
