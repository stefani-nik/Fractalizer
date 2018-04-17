using System.Drawing;
using Fractalizer.Strategies.Contracts;

namespace Fractalizer.Core.Contracts
{
    public interface IRenderer
    {
        IFractalStrategy Strategy { set; }
        Bitmap RenderFractal(Point start, Point end, int iterations,
                            Color baseColor, string fractalParameters);
 
        string GetRenderingTime();
    }
}