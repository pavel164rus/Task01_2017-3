﻿namespace Task01
{
    public class Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public Point()
        {

        }

        public Point(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}