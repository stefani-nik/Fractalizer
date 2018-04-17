using System.Collections.Generic;
using System.Globalization;
using Fractalizer.Common;

namespace Fractalizer.Fractals.Contracts
{
    public abstract class Fractal
    {
        public double XStartValue { get; private set; }

        public double YStartValue { get; private set; }

        public double XRange { get; private set; }

        public double YRange { get; private set; }

        protected double xOffset = Constants.StartOffsetX;
        protected double yOffset = Constants.StartOffsetY;


        public void AdjustParameters(int zoomStartX, int zoomStartY, int zoomEndX, int zoomEndY)
        {
            double startX = this.XRange * zoomStartX / Constants.PicturePanelWidth;
            double startY = this.YRange * zoomStartY / Constants.PicturePanelWidth;

            double endX = this.XRange * zoomEndX / Constants.PicturePanelWidth;
            double endY = this.YRange * zoomEndY / Constants.PicturePanelWidth;


            this.XStartValue += startX;
            this.YStartValue += startY;

            this.XRange = endX - startX;
            this.YRange = endY - startY;

            this.xOffset = (endX - startX) / (double)Constants.PicturePanelWidth;
            this.yOffset = (endY - startY) / (double)Constants.PicturePanelWidth;

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
            this.XStartValue = Constants.StartValueX;
            this.YStartValue = Constants.StartValueY;
            this.XRange = Constants.XRange;
            this.YRange = Constants.YRange;
            this.xOffset = Constants.StartOffsetX;
            this.yOffset = Constants.StartOffsetY;
        }

        public abstract  int GetNextPixel(int coordX, int coordY);

        public abstract void SetCustomParameters(int iterations, string parameters = null);


    }
}
