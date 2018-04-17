using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Fractalizer.Common
{
    public static class ColorUtility
    {
        //private Color baseColor;
        private static List<Color> palette;

        public static List<Color> LoadPalette(Color baseColor)
        {
           palette = new List<Color>();

            //Parallel.For(15,100, i =>
            //{
            //    Color shade = Color.FromArgb(baseColor.A,
            //    (int)(baseColor.R * i / 100.0f), (int)(baseColor.G * i / 100.0f), (int)(baseColor.B * i / 100.0f));
            //    palette.Add(shade);
            //});

            for (float i = 0.15f; i <= 1.0f; i += 0.025f)
            {
                Color shade = Color.FromArgb(baseColor.A,
                    (int) (baseColor.R*i), (int) (baseColor.G*i), (int) (baseColor.B*i));
                palette.Add(shade);
            }
            return palette;
        }

    }
}
