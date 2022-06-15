﻿using System;

namespace Programming.Model.Classes
{
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            int dX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            int dY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            double widthDifference = Math.Abs(rectangle1.Width + rectangle2.Width) / 2;
            double heigthDifference = Math.Abs(rectangle1.Heigth + rectangle2.Heigth) / 2;
            if (dX < widthDifference && dY < heigthDifference)
            {
                return true;
            }
            else
            {
                return false;
            }
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
