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


        public double XStartValue { get; private set; } = FractalsConstants.StartValueX;

        public double YStartValue { get; private set; } = FractalsConstants.StartValueY;

        public double XRange { get; private set; } = FractalsConstants.XRange;

        public double YRange { get; private set; } = FractalsConstants.YRange;

        private double xOffset = FractalsConstants.StartOffsetX;
        private double yOffset = FractalsConstants.StartOffsetY;

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
            double startX = this.XRange * zoomStartX / FormConstants.PicturePanelWidth; // TODO work with constants
            double startY = this.YRange * zoomStartY / FormConstants.PicturePanelWidth;

            double endX = this.XRange * zoomEndX / FormConstants.PicturePanelWidth;
            double endY = this.YRange * zoomEndY / FormConstants.PicturePanelWidth;


            this.XStartValue += startX;
            this.YStartValue += startY;

            this.XRange = endX - startX;
            this.YRange = endY - startY;

            this.xOffset = (endX - startX) / (double)FormConstants.PicturePanelWidth;
            this.yOffset = (endY - startY) / (double)FormConstants.PicturePanelWidth;

        }

    }
}