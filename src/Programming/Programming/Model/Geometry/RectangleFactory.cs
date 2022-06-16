using Programming.Model.Enums;
using System;

namespace Programming.Model.Geometry
{
    public static class RectangleFactory
    {
        public static Rectangle Randomazie()
        {
            Random rnd = new();
            double newHeight = rnd.Next(1, 300);
            double newWidth = rnd.Next(1, 300);
            int newX = rnd.Next(1, 300);
            int newY = rnd.Next(1, 300);
            Point2D newCenter = new(newX, newY);
            Array color = Enum.GetValues(typeof(Colour));
            Colour randomColor = (Colour)color.GetValue(rnd.Next(color.Length));
            Rectangle rectangle = new(
                newHeight, newWidth, randomColor.ToString(), newCenter);
            return rectangle;
        }

        public static Rectangle Randomazie(int canvasWidth, int canvasHeigth)
        {
            int margin = 15;
            Random rnd = new();
            double newWidth = rnd.Next(10, canvasWidth/3);
            double newHeight = rnd.Next(10, canvasHeigth/3);
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
