using System;
using Fractalizer.Common;
using Fractalizer.Fractals.Contracts;
using Fractalizer.Strategies.Contracts;

namespace Fractalizer.Fractals
{
 
    public sealed class Newton : Fractal, IFractalStrategy
    {

        private static readonly Lazy<Newton> instance =
                                new Lazy<Newton>(() => new Newton());

        public static Newton Instance => instance.Value;

        private Newton() { }

        public override int GetNextPixel(int coordX, int coordY, int iterations, string parameters= null)
        {

            double xValue = this.XStartValue + this.xOffset * coordX;
            double yValue = this.YStartValue + this.yOffset*coordY;


            ComplexPoint z = new ComplexPoint(xValue, yValue);
            ComplexPoint z1 = new ComplexPoint(1,0);
            ComplexPoint dz = new ComplexPoint(1,0);

            int it = 0;


            if (xValue != 0 || yValue != 0)
            {
                while (it < iterations && z1.GetModulusSquared() > 0.00000001)
                {

                    //z1 = ComplexPoint.Pow(z, 3) - (double)2;
                    //dz = 3 * ComplexPoint.Pow(z, 2);
                    //ComplexPoint temp = z1 / dz;
                    //z -= temp;

                    //z1 = ComplexPoint.Pow(z, 6) + ComplexPoint.Pow(z,3) - 1;
                    //dz = 6* ComplexPoint.Pow(z,5) + 3 * ComplexPoint.Pow(z, 2);
                    //ComplexPoint temp = z1 / dz;
                    //z -= temp;

                    z1 = ComplexPoint.Pow(z, 3) - (2 * z) + 2.0;
                    dz = 3 * ComplexPoint.Pow(z, 2) - 2.0;
                    ComplexPoint temp = z1 / dz;
                    z -= temp;

                    it++;
                }
            }
               

            return it;
        }

    }
}