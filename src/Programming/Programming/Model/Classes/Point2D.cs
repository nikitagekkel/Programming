﻿using System;

namespace Programming.Model.Classes
{
    public class Point2D
    {
        private int _x;

        private int _y;

        public int X
        {
            get
            {
                return _x;
            }
            private set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            private set
            {
                _y = value;
            }
        }

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
