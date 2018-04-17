using System.Collections.Generic;
using System.Globalization;
using Fractalizer.Common;

namespace Fractalizer.Fractals.Contracts
{
    public abstract class Fractal
    {
        public double XStartValue { get; private set; } = FractalsConstants.StartValueX;

        public double YStartValue { get; private set; } = FractalsConstants.StartValueY;

        public double XRange { get; private set; } = FractalsConstants.XRange;

        public double YRange { get; private set; } = FractalsConstants.YRange;

        protected double xOffset = FractalsConstants.StartOffsetX;
        protected double yOffset = FractalsConstants.StartOffsetY;


        public void AdjustParameters(int zoomStartX, int zoomStartY, int zoomEndX, int zoomEndY)
        {
            double startX = this.XRange * zoomStartX / FormConstants.PicturePanelWidth;
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

        public Dictionary<string, string> GetFractalParameters()
        {
            var parameters = new Dictionary<string, string>()
            {
                {"XStartValue", this.XStartValue.ToString(CultureInfo.InvariantCulture)},
                { "YStartValue", this.YStartValue.ToString(CultureInfo.InvariantCulture)},
                { "XRange", this.XRange.ToString(CultureInfo.InvariantCulture)},
                {"YRange", this.YRange.ToString(CultureInfo.InvariantCulture) }
            };

            return parameters;
        }

        public void SetDefaultParameters()
        {
            this.XStartValue = FractalsConstants.StartValueX;
            this.YStartValue = FractalsConstants.StartValueY;
            this.XRange = FractalsConstants.XRange;
            this.YRange = FractalsConstants.YRange;
            this.xOffset = FractalsConstants.StartOffsetX;
            this.yOffset = FractalsConstants.StartOffsetY;
        }

        public abstract  int GetNextPixel(int coordX, int coordY);

        public abstract void SetCustomParameters(int iterations, string parameters = null);


    }
}
