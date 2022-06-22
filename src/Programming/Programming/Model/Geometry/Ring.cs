using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит кольцо и его данные.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Уникальный идентификатор внешнего радиуса.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Уникальный идентификатор внутреннего радиуса.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Возвращает и задает координаты центра кольца.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задает внутренний радиус кольца. Должен быть меньше
        /// внутреннего радиуса.
        /// </summary>
        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                if (value < 0 || InnerRadius > OuterRadius)
                {
                    throw new ArgumentException("Error");
                }
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задает внешний радиус кольца. Должен быть больше
        /// внутреннего радиса кольца.
        /// </summary>
        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            set
            {
                if (value < 0 || OuterRadius < InnerRadius)
                {
                    throw new ArgumentException("Error");
                }
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задает плошадь кольца. Создается внутри поля
        /// и не может быть изменена.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(OuterRadius, 2) - Math.PI * Math.Pow(InnerRadius, 2);
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="innerRadius">Внутренний радиус. Должнен быть меньше внешнего.</param>
        /// <param name="outerRadius">Внешний радиус. Должен быть больше внутреннего.</param>
        /// <param name="center">Координаты центра кольца. Должны состоять из положительных чисел.</param>
        public Ring(double innerRadius, double outerRadius, Point2D center)
        {
            _innerRadius = innerRadius;
            _outerRadius = outerRadius;
            Center = center;
        }
    }
}
