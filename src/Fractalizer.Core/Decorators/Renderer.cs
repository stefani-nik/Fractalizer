using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fractalizer.Common;
using Fractalizer.Core.Contracts;
using Fractalizer.Core.Controls;
using Fractalizer.Core.Forms;
using Fractalizer.Fractals.Contracts;
using Fractalizer.Strategies.Contracts;

namespace Fractalizer.Core.Decorators
{
    /// <summary>
    /// Class responsible for rendering the Mandelbrot set 
    /// and getting information about its parameters
    /// </summary>
    public class Renderer : IRenderer
    {

        private List<Color> palette;
        private readonly Stopwatch renderTimer;
        private IFractalStrategy strategy;

        private static readonly Lazy<Renderer> instance =
                               new Lazy<Renderer>(() => new Renderer());

        public static Renderer Instance => instance.Value;
        
        public IFractalStrategy Strategy
        {
            set
            {
                if (value != null)
                    this.strategy = value;
            }
        }


        public Bitmap MyBitmap;


        private Renderer()
        {
            //this.palette = ColorsManager.LoadPalette();
            this.MyBitmap = new Bitmap(FormConstants.PicturePanelWidth, FormConstants.PicturePanelHeight);
            this.renderTimer = new Stopwatch();
        }


        /// <summary>
        /// Multithreading rendering of the chosen fractal
        /// </summary>
        public Bitmap RenderFractal(Point start, Point end, int iterations, Color baseColor, string fractalParams)
        {
           
            this.renderTimer.Start();
            this.palette = ColorUtility.LoadPalette(baseColor);

            // If the points are not empty the fractal is zoom and adjustment of the parameters is needed
            if (start != Point.Empty && end != Point.Empty)
            {
                strategy.AdjustParameters(start.X,start.Y, end.X, end.Y);
            }


            int width = MyBitmap.Width;
            int height = MyBitmap.Height;
            int bytesPerPixel = Image.GetPixelFormatSize(MyBitmap.PixelFormat) / 8; // The default is 32 bits

            BitmapData data = MyBitmap.LockBits(new Rectangle(0, 0, MyBitmap.Width, MyBitmap.Height),
                                                    ImageLockMode.ReadWrite, MyBitmap.PixelFormat);


            IntPtr PtrFirstPixel = data.Scan0; // pointer to the first pixel of the bitmap
            byte[] pixels = new byte[width * height * bytesPerPixel];

            var options = new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount - 1 };


            Parallel.For(0, height, options, y =>
            {

                for (int x = 0; x < width; x++)
                {
                    int index = ((y * width) + x) * bytesPerPixel;

                    int iter = strategy.GetNextPixel(x, y, iterations, fractalParams);
                    Color pixelColor = iter == iterations ? Color.White : palette[iter % palette.Count];

                    pixels[index + 0] = pixelColor.B;
                    pixels[index + 1] = pixelColor.G;
                    pixels[index + 2] = pixelColor.R;
                    pixels[index + 3] = pixelColor.A;

                }
            });


            // Copy the Pixels array from start index 0 into the data of the Bitmap 
            Marshal.Copy(pixels, 0, PtrFirstPixel, pixels.Length);

            MyBitmap.UnlockBits(data);

            this.renderTimer.Stop();

            return MyBitmap;
        }

        //public string GetCurrentX()
        //{
        //    return this..XStartValue.ToString(CultureInfo.InvariantCulture);
        //}
        //public string GetCurrentY()
        //{
        //    return this.fractal.YStartValue.ToString(CultureInfo.InvariantCulture);
        //}
        //public string GetCurrentRangeStart()
        //{
        //    return this.fractal.XRange.ToString(CultureInfo.InvariantCulture);
        //}
        //public string GetCurrentRangeEnd()
        //{
        //    return this.fractal.YRange.ToString(CultureInfo.InvariantCulture);
        //}


        /// public 

        //public string GetParameters()
        //{
        //    return this.settingsPanel.GetComplexNumber();
        //} 


        public string GetRenderingTime()
        {
            TimeSpan ts = renderTimer.Elapsed;
            renderTimer.Reset();
            return $"{ts.Seconds:D2}:{ts.Milliseconds:D2}";
        }
    }
}