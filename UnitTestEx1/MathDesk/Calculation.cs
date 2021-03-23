using System;

namespace MathDesk
{
    internal class Calculation
    {
        public Calculation()
        {
        }

        internal int Square(int num1)
        {
            return num1 * num1;
        }

        internal double SquareRoot(int num1)
        {
            return Math.Sqrt(num1);
        }

        internal int Cube(int num1)
        {
            return num1 * num1 * num1;
        }
    }
}