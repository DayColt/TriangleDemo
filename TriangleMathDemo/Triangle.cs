using System;

namespace TriangleMathDemo
{
    public class Triangle
    {
        private double catheter1, catheter2, hypotenuse;
        /// <summary>
        /// Constructor for right triangle
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0) throw new ArgumentException("Sides in triangle can not be 0 or less");

            if (Math.Pow(side1, 2) == Math.Pow(side2, 2) + Math.Pow(side3, 2))
            {
                catheter1 = side2;
                catheter2 = side3;
                hypotenuse = side1;
            }
            else if (Math.Pow(side2, 2) == Math.Pow(side1, 2) + Math.Pow(side3, 2))
            {
                catheter1 = side1;
                catheter2 = side3;
                hypotenuse = side2;
            }
            else if (Math.Pow(side3, 2) == Math.Pow(side1, 2) + Math.Pow(side2, 2))
            {
                catheter1 = side1;
                catheter2 = side2;
                hypotenuse = side3;
            }
            else throw new ArgumentException($"Right triangle with sides {side1}, {side2}, {side3} can not exist");
        }

        /// <summary>
        /// Calculates the square of right triangle
        /// </summary>
        /// <returns></returns>
        public double Square()
        {
            return (catheter1 * catheter2) / 2;
        }
    }
}
