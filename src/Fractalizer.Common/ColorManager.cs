using System.Collections.Generic;
using System.Drawing;
using Fractalizer.Common.Contracts;

namespace Fractalizer.Common
{
    public class ColorManager : IColorManager
    {
        private List<Color> palette;
        public int interval = Constants.ColorsInterval;

        public IEnumerable<Color> LoadSingleColorPalette(Color baseColor)
        {
           this.palette = new List<Color>();

            for (float i = 0.15f; i <= 1.0f; i += 0.025f)
            {
                Color shade = Color.FromArgb(baseColor.A,
                    (int) (baseColor.R*i), (int) (baseColor.G*i), (int) (baseColor.B*i));
                this.palette.Add(shade);
            }
            return this.palette;
        }

        public IEnumerable<Color> LoadColorfulPalette()
        {
           this.palette = new List<Color>();

            for (int green = 0; green < 255; green += interval)
            {
                for (int blue = 0; blue < 255; blue += interval)
                {
                    for (int red = 0; red < 255; red += interval)
                    {
                        this.palette.Add(Color.FromArgb(255, red, green, blue));
                    }
                }
            }
            return this.palette;
        }

    }
}
