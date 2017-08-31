using Task01;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task01.Tests
{

    [TestClass]
    public class SegmentTests
    {
        [TestMethod]
        public void LengthOfSegment1()
        {
            Point pointF = new Point(0, 0, 0);
            Point pointS = new Point(4, 2, 4);
            int expected = 6;

            Segment segment = new Segment(pointF, pointS);
            double lengthOfSegment = segment.Length;

            Assert.AreEqual(expected, lengthOfSegment);
        }

        [TestMethod]
        public void LengthOfSegment2()
        {
            Point pointF = new Point(3, 1, -5);
            Point pointS = new Point(4, 2, 4);
            double expected = 9.1104;

            Segment segment = new Segment(pointF, pointS);
            double lengthOfSegment = Math.Round(segment.Length, 4);

            Assert.AreEqual(expected, lengthOfSegment);
        }

        [TestMethod]
        public void LengthOfSegmentZero()
        {
            Point pointF = new Point();
            Point pointS = new Point();
            double expected = 0;

            Segment segment = new Segment(pointF, pointS);
            double lengthOfSegment = segment.Length;

            Assert.AreEqual(expected, lengthOfSegment);
        }

        [TestMethod]
        public void LengthOfSegmentOne()
        {
            Point pointF = new Point(1, 2, 3);
            Point pointS = new Point(1, 2, 2);
            double expected = 1;

            Segment segment = new Segment(pointF, pointS);
            double lengthOfSegment = segment.Length;

            Assert.AreEqual(expected, lengthOfSegment);
        }

        [TestMethod()]
        public void DistanceToSegmentTest1()
        {
            Point pointF = new Point(0, 0, 0);
            Point pointS = new Point(4, 2, 4);
            Point pointC = new Point(3, 3, 4);
            double expected = 1.374;

            Segment segment = new Segment(pointF, pointS);
            double lengthOfSegment = segment.DistanceToSegment(pointC);

            Assert.AreEqual(expected, Math.Round(lengthOfSegment,3));
        }

        [TestMethod()]
        public void DistanceToSegmentTest2()
        {
            Point pointF = new Point(-2, 4, 5);
            Point pointS = new Point(2, -2, 4);
            Point pointC = new Point(3, 13, -4);
            double expected = 13.237;

            Segment segment = new Segment(pointF, pointS);
            double lengthOfSegment = segment.DistanceToSegment(pointC);

            Assert.AreEqual(expected, Math.Round(lengthOfSegment, 3));
        }

        [TestMethod()]
        public void DistanceToSegmentTest3()
        {
            Point pointF = new Point(1, 1, 0);
            Point pointS = new Point(4, 2, 2);
            Point pointC = new Point(3, -3, 0);
            double expected = 4.44;

            Segment segment = new Segment(pointF, pointS);
            double lengthOfSegment = segment.DistanceToSegment(pointC);

            Assert.AreEqual(expected, Math.Round(lengthOfSegment, 3));
        }
    }
}
