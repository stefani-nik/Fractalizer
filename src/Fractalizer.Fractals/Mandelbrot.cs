using System;
using Fractalizer.Common;
using Fractalizer.Fractals.Contracts;

namespace Fractalizer.Fractals
{
    /// <summary>
    /// The actual Mandelbrot set class
    /// </summary>
    public sealed class Mandelbrot : IFractal
    {

        private static readonly Lazy<Mandelbrot> instance = 
                                new Lazy<Mandelbrot>(() => new Mandelbrot());

        public static Mandelbrot Instance => instance.Value;

        private Mandelbrot() { }


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

            ComplexPoint c = new ComplexPoint(xValue, yValue);
            ComplexPoint z = new ComplexPoint(0, 0);

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
            double startX = this.XRange * zoomStartX / FormConstants.PicturePanelWidth;
            double startY = this.YRange * zoomStartY / FormConstants.PicturePanelHeight;

            double endX = this.XRange * zoomEndX / FormConstants.PicturePanelWidth;
            double endY = this.YRange * zoomEndY / FormConstants.PicturePanelHeight;


            this.XStartValue += startX;
            this.YStartValue += startY;

            this.XRange = endX - startX;
            this.YRange = endY - startY;

            this.xOffset = (endX - startX) / (double)FormConstants.PicturePanelWidth;
            this.yOffset = (endY - startY) / (double)FormConstants.PicturePanelHeight;

        }

    }
}