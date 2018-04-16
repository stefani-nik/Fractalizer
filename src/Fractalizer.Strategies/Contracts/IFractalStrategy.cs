namespace Fractalizer.Strategies.Contracts
{
    public interface IFractalStrategy
    {
        int GetNextPixel(int coordX, int coordY, int iterations);
        void AdjustParameters(int zoomStartX, int zoomStartY, int zoomEndX, int zoomEndY);
    }
}
