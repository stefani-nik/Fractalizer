using System;
using Fractalizer.Common;
using Fractalizer.Fractals.Contracts;
using Fractalizer.Strategies.Contracts;

namespace Fractalizer.Fractals
{
   
    public sealed class Julia : Fractal, IFractalStrategy
    {

        private static readonly Lazy<Julia> instance =
                                new Lazy<Julia>(() => new Julia());

        public static Julia Instance => instance.Value;

        private Julia() { }

        private ComplexPoint complexPoint = default(ComplexPoint);
        private int iterations = 0;

        public override int GetNextPixel(int coordX, int coordY)
        {

            double xValue = this.XStartValue + this.xOffset*coordX;
            double yValue = this.YStartValue + this.yOffset*coordY;

            ComplexPoint c = this.complexPoint;
            ComplexPoint z = new ComplexPoint(xValue, yValue);

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
            this.complexPoint = ComplexPoint.GetPointFromString(parameters);
        }

    }
}