using System.Drawing;
using Fractalizer.Fractals.Contracts;
using Fractalizer.Strategies.Contracts;

namespace Fractalizer.Core.Contracts
{
    public interface IRenderer
    {
        //Fractal Fractal { set; }
        IFractalStrategy Strategy { set; }
        Bitmap RenderFractal(Point start, Point end, int iterations, Color baseColor);
       // string GetCurrentX();
       // string GetCurrentY();
       // string GetCurrentRangeStart();
       // string GetCurrentRangeEnd();
        string GetRenderingTime();
    }
}