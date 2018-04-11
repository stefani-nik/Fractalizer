using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Fractalizer.Common
{
    public static class ColorUtility
    {
        //private Color baseColor;
        private static List<Color> palette;

        public static  List<Color> LoadPalette(Color baseColor)
        {
            palette = new List<Color>();

            for (float i = 0.0f; i <= 1.0f; i += 0.05f)
            {
                Color shade = Color.FromArgb(baseColor.A,
                (int)(baseColor.R * i), (int)(baseColor.G * i), (int)(baseColor.B * i));
                palette.Add(shade);
            }
            return palette;
        }
    }
}
