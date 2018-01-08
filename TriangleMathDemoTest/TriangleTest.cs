using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleMathDemo;

namespace TriangleMathDemo.Test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Sides if the triangle can be 0 or less")]
        public void Triangle_0and1and2_Exception0OrNegativeSide()
        {
            // Arrange
            double a = 0;
            double b = 1;
            double c = 2;

            // Act
            Triangle triangle = new Triangle(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Right triangle with sides 2, 2, 2 can not exist")]
        public void Triangle_2and2and2_ExceptionNotTriangle()
        {
            // Arrange
            double a = 2;
            double b = 2;
            double c = 2;

            // Act
            Triangle triangle = new Triangle(a, b, c);
        }

        [TestMethod]
        public void Square_3and4and5_6returned()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double excpected = 6;

            // Act
            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.Square();

            // Assert
            Assert.AreEqual(excpected, actual);
        }
    }
}
