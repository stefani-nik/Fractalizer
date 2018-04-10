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

        /// <summary>
        /// Adjusts the parameters of the set according to the zoom strat and end points
        /// </summary>
        public void AdjustParameters(int zoomStartX, int zoomStartY, int zoomEndX, int zoomEndY)
        {
            double startX = this.XRange * zoomStartX / 900; // TODO work with constants
            double startY = this.YRange * zoomStartY / 900;

            double endX = this.XRange * zoomEndX / 900;
            double endY = this.YRange * zoomEndY / 900;


            this.XStartValue += startX;
            this.YStartValue += startY;

            this.XRange = endX - startX;
            this.YRange = endY - startY;

            this.xOffset = (endX - startX) / (double)900;
            this.yOffset = (endY - startY) / (double)900;

        }

    }
}