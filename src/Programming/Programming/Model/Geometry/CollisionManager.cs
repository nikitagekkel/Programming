using System;
using Programming.Model.Geometry;

namespace Programming.Model.Geometry
{
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            return rectangle1.Center.X < rectangle2.Center.X + rectangle2.Width &&
                   rectangle1.Center.X + rectangle1.Width > rectangle2.Center.X &&
                   rectangle1.Center.Y < rectangle2.Center.Y + rectangle2.Heigth &&
                   rectangle1.Heigth + rectangle1.Center.Y > rectangle2.Center.Y;
        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            int dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            int dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double c = Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2));
            double outerRadiusSum = ring1.OuterRadius + ring2.OuterRadius;
            if (c < outerRadiusSum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
