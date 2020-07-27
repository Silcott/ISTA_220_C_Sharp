﻿#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Point
    {
        private int x, y;
        private static int objectCount = 0;

        public Point()
        {
            this.x = -1;
            this.y = -1;
            objectCount++;
        }

        public Point(int xVar, int yVar)
        {
            x = xVar;
            y = yVar;
            objectCount++;
        }

        public double DistanceTo(Point other)
        {
            int xDiff = this.x - other.x;
            int yDiff = this.y - other.y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }

        public static int ObjectCount() => objectCount;
    }
}
