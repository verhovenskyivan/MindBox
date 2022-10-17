using MindBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace MindBox_Test
{
    public class Tests
    {
        private double MinumumBorderOfRadius = 1e-3;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsRadiusZero()
        {
            Assert.Catch<ArgumentException>(() => new Circle(0d));
        }

        [Test]

        public void IsRadiusNegative()
        {
            Assert.Catch<ArgumentException>(() => new Circle(-1d));
        }
        public void Test()
        {
            Assert.Pass();
        }

        [Test]
        public void GetSquareTest()
        {
            var radius = 2;
            var circle = new Circle(radius);
            var expectedValue = Math.PI * Math.Pow(radius, 2d);

            double square = (double)circle.GetSquare();

            Assert.Less(Math.Abs(square - expectedValue), MinumumBorderOfRadius);
        }
    }
}