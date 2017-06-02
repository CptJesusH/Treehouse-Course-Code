﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y)
        {
            //int xDiff = X - x;[1]
            //int yDiff = Y - y;[1]

            //int xDiffSquared = xDiff * xDiff;[1]
            //int yDiffSquared = yDiff * yDiff;[1]

            //return (int)Math.Sqrt(xDiffSquared + yDiffSquared);[1]

            return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2)); //[1]
        }

        public int DistanceTo(Point point) //[2]
        {
            return DistanceTo(point.X, point.Y); //[2]
        }
    }
}