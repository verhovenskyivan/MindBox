using MindBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Triangle_Application;

namespace MindBox_Test
{
    public class TriangleTest
    {
        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        [TestCase(0, 0, 0)]
        public void InitTriangleWithErrorTest(double a, double b, double c)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Test]
        public void GetSquareTest()
        {
            // Data.
            double a = 3d, b = 4d, c = 5d;
            double result = 6d;
            var triangle = new Triangle(a, b, c);


            var square = triangle?.GetSquare();


            Assert.NotNull(square);
           
        }

        [Test]
        public void InitTriangleTest()
        {
           
            double a = 3d, b = 4d, c = 5d;

            
            var triangle = new Triangle(a, b, c);

          
            Assert.NotNull(triangle);
            Assert.Less(Math.Abs(triangle.A - a), MinimumValue.MinimumBorder);
            Assert.Less(Math.Abs(triangle.B - b), MinimumValue.MinimumBorder);
            Assert.Less(Math.Abs(triangle.C - c), MinimumValue.MinimumBorder);

            [Test]
            void InitNotTriangleTest()
            {
                Assert.Catch<ArgumentException>(() => new Triangle(2, 3, 4));
            }

        }
    } 
}