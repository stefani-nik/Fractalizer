using System;

namespace Fractalizer.Strategies.Contracts
{
    public interface IFractalStrategy
    {
        int GetNextPixel(int coordX, int coordY);
        void AdjustParameters(int zoomStartX, int zoomStartY, int zoomEndX, int zoomEndY);
        void SetCustomParameters(int it, string parameters = null);
    }
}
