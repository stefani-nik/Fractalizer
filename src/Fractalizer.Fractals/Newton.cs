using System;
using Fractalizer.Common;
using Fractalizer.Fractals.Contracts;

namespace Fractalizer.Fractals
{
    /// <summary>
    /// The actual Mandelbrot set class
    /// </summary>
    public sealed class Newton : IFractal
    {

        private static readonly Lazy<Newton> instance =
                                new Lazy<Newton>(() => new Newton());

        public static Newton Instance => instance.Value;

        private Newton() { }


        public double XStartValue { get; private set; } = -4.0;//FractalsConstants.StartValueX;

        public double YStartValue { get; private set; } = -2.0;//FractalsConstants.StartValueY;

        public double XRange { get; private set; } = 8.0;//FractalsConstants.XRange;

        public double YRange { get; private set; } = 8.0; //FractalsConstants.YRange;

        private double xOffset = 0.01;//FractalsConstants.StartOffsetX;
        private double yOffset = 0.01;//FractalsConstants.StartOffsetY;

        /// <summary>
        /// Calculates the next pixel with the equation Z(n+1) = Z(n)^2 + C
        /// </summary>
        public int GetNextPixel(int coordX, int coordY, int iterations)
        {

            double xValue = this.XStartValue + this.xOffset * coordX;
            double yValue = this.YStartValue + this.yOffset * coordY;

            ComplexPoint c = new ComplexPoint(1, 1);
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

        /// <summary>
        /// Adjusts the parameters of the set according to the zoom strat and end points
        /// </summary>
        public void AdjustParameters(int zoomStartX, int zoomStartY, int zoomEndX, int zoomEndY)
        {
            double startX = this.XRange * zoomStartX / 800; // TODO work with constants
            double startY = this.YRange * zoomStartY / 800;

            double endX = this.XRange * zoomEndX / 800;
            double endY = this.YRange * zoomEndY / 800;


            this.XStartValue += startX;
            this.YStartValue += startY;

            this.XRange = endX - startX;
            this.YRange = endY - startY;

            this.xOffset = (endX - startX) / (double)800;
            this.yOffset = (endY - startY) / (double)800;

        }

    }
}