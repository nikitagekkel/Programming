using Programming.Model.Enums;
using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Создает прямоугольник.
    /// </summary>
    public static class RectangleFactory
    {
        /// <summary>
        /// Создает прямоугольник с параметрами, зависящими от размеров панели.
        /// </summary>
        /// <param name="canvasWidth">Ширина панели.</param>
        /// <param name="canvasHeigth">Высота панели.</param>
        /// <returns>
        /// Возвращает прямоугольник типа Rectangle.
        /// </returns>
        public static Rectangle Randomize(int canvasWidth, int canvasHeigth)
        {
            int margin = 15;
            Random rnd = new();
            double newWidth = rnd.Next(margin, canvasWidth / 3);
            double newHeight = rnd.Next(margin, canvasHeigth / 3);
            int newX = rnd.Next(margin, canvasWidth - (int)newWidth - margin);
            int newY = rnd.Next(margin, canvasHeigth - (int)newHeight - margin);
            Point2D newCenter = new(newX, newY);
            Array color = Enum.GetValues(typeof(Colour));
            Colour randomColor = (Colour)color.GetValue(rnd.Next(color.Length));
            Rectangle rectangle = new(
                newHeight, newWidth, randomColor.ToString(), newCenter);

            return rectangle;
        }
    }
}
