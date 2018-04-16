using System;

namespace Fractalizer.Strategies.Contracts
{
    public interface IFractalStrategy
    {
        int GetNextPixel(int coordX, int coordY, int iterations, string parameters = null);
        void AdjustParameters(int zoomStartX, int zoomStartY, int zoomEndX, int zoomEndY);
    }
}
