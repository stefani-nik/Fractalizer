using System.Collections.Generic;
using System.Drawing;

namespace Fractalizer.Common.Contracts
{
    public interface IColorManager
    {
        IEnumerable<Color> LoadSingleColorPalette(Color baseColor);
        IEnumerable<Color> LoadColorfulPalette();

    }
}
