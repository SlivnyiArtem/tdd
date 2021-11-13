﻿using System;
using System.Drawing;

namespace TagsCloudVisualization
{
    public static class PointExtensions
    {
        public static double GetDistanceToPoint(this Point thisPoint, Point anotherPoint)
        {
            return Math.Sqrt(Math.Pow(thisPoint.X - anotherPoint.X, 2) + Math.Pow(thisPoint.Y - anotherPoint.Y, 2));
        }
    }
}
