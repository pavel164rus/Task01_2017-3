using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class Segment
    {
        public Point FirstPoint { get; set; }

        public Point SecondPoint { get; set; }

        public Segment(Point firstPoint, Point secondPoint)
        {
            this.FirstPoint = firstPoint;
            this.SecondPoint = secondPoint;
        }

        public double Length { get { return DistancePointToPoint(FirstPoint, SecondPoint); } }
        //public double Length => Math.Sqrt(Math.Pow(SecondPoint.X - FirstPoint.X, 2) + Math.Pow(SecondPoint.Y - FirstPoint.Y, 2) + Math.Pow(SecondPoint.Z - FirstPoint.Z, 2));

        public double DistanceToSegment(Point point)
        {
            double DistanceAB = Length;
            double DistanceAC = DistancePointToPoint(FirstPoint, point);
            double DistanceBC = DistancePointToPoint(SecondPoint, point);

            double semiperimeter = (DistanceAB + DistanceAC + DistanceBC) / 2;

            double result = 2 * (Math.Sqrt(semiperimeter*(semiperimeter-DistanceAB)*(semiperimeter-DistanceAC)*(semiperimeter-DistanceBC))) / DistanceAB;
            return result;
        }

        private double DistancePointToPoint(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2) + Math.Pow(b.Z - a.Z, 2));
        }
    }
}
