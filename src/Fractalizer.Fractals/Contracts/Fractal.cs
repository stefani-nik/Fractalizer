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


        public abstract  int GetNextPixel(int coordX, int coordY, int iterations);
    }
}
