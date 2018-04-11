using System.Drawing;
using Fractalizer.Fractals.Contracts;

namespace Fractalizer.Core.Contracts
{
    public interface IRenderer
    {
        Fractal Fractal { set; }
        Bitmap RenderFractal(Point start, Point end, int iterations, Color baseColor);
        string GetCurrentX();
        string GetCurrentY();
        string GetCurrentRangeStart();
        string GetCurrentRangeEnd();
        string GetRenderingTime();
    }
}