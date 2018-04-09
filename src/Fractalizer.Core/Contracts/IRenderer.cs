using System.Drawing;

namespace Fractalizer.Core.Contracts
{
    public interface IRenderer
    {
        Bitmap RenderMandelbrot(Point start, Point end, int iterations);
        string GetCurrentX();
        string GetCurrentY();
        string GetCurrentRangeStart();
        string GetCurrentRangeEnd();
        string GetRenderingTime();
    }
}