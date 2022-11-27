using System;

namespace Figures
{
    public class Triangle : Figure
    {
        private double SideOne, SideTwo, SideThree;
        public double GetSquare()
        {
            return Math.Sqrt(Perimeter / 2 * (Perimeter / 2 - SideOne) * (Perimeter / 2 - SideTwo) * (Perimeter / 2 - SideThree));
        }
        public bool IsRight()
        {
            if (SideOne == SideTwo || SideOne == SideThree || SideTwo == SideThree)
            {
                return false;
            }
            if (SideOne > SideTwo && SideOne > SideThree)
            {
                if (SideOne * SideOne == SideTwo * SideTwo + SideThree * SideThree)
                {
                    return true;
                }
            }
            if (SideOne < SideTwo && SideTwo > SideThree)
            {
                if (SideTwo * SideTwo == SideOne * SideOne + SideThree * SideThree)
                {
                    return true;
                }
            }
            if (SideThree > SideTwo && SideOne < SideThree)
            {
                if (SideOne * SideOne + SideTwo * SideTwo == SideThree * SideThree)
                {
                    return true;
                }
            }
            return false;
        }
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new Exception("Sides must be bigger than zero!");
            }
            if (a >= b + c || b >= a + c || c >= a + b)
            {
                throw new Exception("Triangle does not exist!");
            }
            SideOne = a;
            SideTwo = b;
            SideThree = c;
            this.Perimeter = a + b + c;
            this.Square = GetSquare();
        }
    }
}
