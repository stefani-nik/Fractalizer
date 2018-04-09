namespace Fractalizer.Fractals.Contracts
{
    public interface IFractal
    {
        double XStartValue { get; }
        double YStartValue { get; }
        double XRange { get; }
        double YRange { get; }
        int GetNextPixel(int coordX, int coordY, int iterations);
        void AdjustParameters(int zoomStartX, int zoomStartY, int zoomEndX, int zoomEndY);
    }
}