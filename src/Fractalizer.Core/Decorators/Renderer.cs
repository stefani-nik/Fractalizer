﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Fractalizer.Common;
using Fractalizer.Core.Contracts;
using Fractalizer.Fractals;
using Fractalizer.Fractals.Contracts;

namespace Fractalizer.Core
{
    /// <summary>
    /// Class responsible for rendering the Mandelbrot set 
    /// and getting information about its parameters
    /// </summary>
    public class Renderer : IRenderer
    {

        public Bitmap MyBitmap;

        private readonly List<Color> palette;
        private readonly Fractal mandel;
        private readonly Stopwatch renderTimer;

        public Renderer() // add to constructor
        {
            this.palette = ColorsManager.LoadPalette();
            this.MyBitmap = new Bitmap(FormConstants.PicturePanelWidth, FormConstants.PicturePanelHeight);
            this.mandel = Newton.Instance;
            // this.fractal = fractal;
            this.renderTimer = new Stopwatch();
        }

        /// <summary>
        /// Multithreading rendering of the Mandelbrot set
        /// </summary>
        public Bitmap RenderMandelbrot(Point start, Point end, int iterations)
        {
            this.renderTimer.Start();

            // If the points are not empty the fractal is zoom and adjustment of the parameters is needed
            if (start != Point.Empty && end != Point.Empty)
            {
                mandel.AdjustParameters(start.X,start.Y, end.X, end.Y);
            }


            int width = MyBitmap.Width;
            int height = MyBitmap.Height;
            int bytesPerPixel = Bitmap.GetPixelFormatSize(MyBitmap.PixelFormat) / 8; // The default is 32 bits

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

                    int iter = mandel.GetNextPixel(x, y, 32);
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

        public string GetCurrentX()
        {
            return this.mandel.XStartValue.ToString(CultureInfo.InvariantCulture);
        }
        public string GetCurrentY()
        {
            return this.mandel.YStartValue.ToString(CultureInfo.InvariantCulture);
        }
        public string GetCurrentRangeStart()
        {
            return this.mandel.XRange.ToString(CultureInfo.InvariantCulture);
        }
        public string GetCurrentRangeEnd()
        {
            return this.mandel.YRange.ToString(CultureInfo.InvariantCulture);
        }

        public string GetRenderingTime()
        {
            TimeSpan ts = renderTimer.Elapsed;
            renderTimer.Reset();
            return $"{ts.Seconds:D2}:{ts.Milliseconds:D2}";
        }
    }
}