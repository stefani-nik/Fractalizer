using System;
using Fractalizer.Common;
using Fractalizer.Fractals.Contracts;
using Fractalizer.Strategies.Contracts;

namespace Fractalizer.Fractals
{
   
    public sealed class Mandelbrot : Fractal, IFractalStrategy
    {

        private static readonly Lazy<Mandelbrot> instance = 
                                new Lazy<Mandelbrot>(() => new Mandelbrot());

        private Mandelbrot() { }
 
        private int iterations = 0;

        public static Mandelbrot Instance => instance.Value;

        /// <summary>
        /// Calculates the next pixel with the equation Z(n+1) = Z(n)^2 + C
        /// </summary>
        public override int GetNextPixel(int coordX, int coordY)
        {

            double xValue = this.XStartValue + this.xOffset * coordX;
            double yValue = this.YStartValue + this.yOffset * coordY;

            ComplexPoint c = new ComplexPoint(xValue, yValue);
            ComplexPoint z = new ComplexPoint(0, 0);

            int it = 0;
            do
            {
                it++;
                z.Sqrt();
                z += c;

                if (z.GetModulus() > Constants.RangeRadius) break;

            } while (it < this.iterations);

            return it;
        }

        public override void SetCustomParameters(int it, string parameters = null)
        {
            this.iterations = it;
        }

    }
}