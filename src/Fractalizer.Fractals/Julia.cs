using System;
using Fractalizer.Common;
using Fractalizer.Fractals.Contracts;

namespace Fractalizer.Fractals
{
   
    public sealed class Julia : Fractal
    {

        private static readonly Lazy<Julia> instance =
                                new Lazy<Julia>(() => new Julia());

        public static Julia Instance => instance.Value;

        private Julia() { }


        public override int GetNextPixel(int coordX, int coordY, int iterations)
        {

            double xValue = this.XStartValue + this.xOffset*coordX;
            double yValue = this.YStartValue + this.yOffset*coordY;

            ComplexPoint c = new ComplexPoint(0, -0.8);
            ComplexPoint z = new ComplexPoint(xValue, yValue);

            int it = 0;
            do
            {
                it++;
                z.Sqrt();
                z += c;

                if (z.GetModulus() > FractalsConstants.RangeRadius) break;

            } while (it < iterations);

            return it;
        }

    }
}