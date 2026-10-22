using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05
{
    internal class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void MoveTo(double newX, double newY)
        {
            X = newX;
            Y = newY;
        }

        public double DistanceToOrigin()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public void PrintPoint()
        {
            Console.WriteLine($"Точка: ({X}, {Y})");
        }
    }
}
