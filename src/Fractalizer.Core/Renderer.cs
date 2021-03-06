﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Fractalizer.Common;
using Fractalizer.Common.Contracts;
using Fractalizer.Core.Contracts;
using Fractalizer.Strategies.Contracts;

namespace Fractalizer.Core
{
    /// <summary>
    /// Class responsible for rendering the chosen fractal 
    /// and getting information about its parameters
    /// </summary>
    public class Renderer : IRenderer
    {
        private readonly Stopwatch renderTimer;
        private IFractalStrategy strategy;

        private readonly IColorManager colorManager;

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
            this.MyBitmap = new Bitmap(Constants.PicturePanelWidth, Constants.PicturePanelHeight);
            this.renderTimer = new Stopwatch();
            this.colorManager = new ColorManager();
        }


        /// <summary>
        /// Multithreading rendering of the chosen fractal
        /// </summary>
        public Bitmap RenderFractal(Point start, Point end, int iterations, Color baseColor, string fractalParams)
        {
           
            this.renderTimer.Start();
            List<Color> palette = baseColor == Color.Empty 
                                ? colorManager.LoadColorfulPalette().ToList() 
                                : colorManager.LoadSingleColorPalette(baseColor).ToList();

            this.strategy.SetCustomParameters(iterations, fractalParams);

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

                    int iter = strategy.GetNextPixel(x, y);
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


        public string GetRenderingTime()
        {
            TimeSpan ts = renderTimer.Elapsed;
            renderTimer.Reset();
            return $"{ts.Seconds:D2}:{ts.Milliseconds:D2}";
        }
    }
}