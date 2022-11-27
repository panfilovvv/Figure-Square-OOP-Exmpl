using System;

namespace Figures
{
    public partial class Circle : Figure
    {
        private double Radius;
        private double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
        public Circle (double r)
        {
            if (r <= 0)
            {
                throw new Exception("Radius musts be bigger than zero!");
            }
            Radius = r;
            this.Perimeter = 2 * Math.PI * Radius;
            this.Square = GetSquare();
        }
    }
}
