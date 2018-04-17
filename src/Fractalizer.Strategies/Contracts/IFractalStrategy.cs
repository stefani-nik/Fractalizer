using System;
using System.Collections.Generic;

namespace Fractalizer.Strategies.Contracts
{
    public interface IFractalStrategy
    {
        int GetNextPixel(int coordX, int coordY);
        Dictionary<string, string> GetFractalParameters();
        void AdjustParameters(int zoomStartX, int zoomStartY, int zoomEndX, int zoomEndY);
        void SetCustomParameters(int it, string parameters = null);
    }
}
