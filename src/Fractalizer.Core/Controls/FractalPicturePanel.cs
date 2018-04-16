using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Fractalizer.Core.Contracts;
using Fractalizer.Core.Decorators;
using Fractalizer.Fractals;
using Fractalizer.Fractals.Contracts;
using Fractalizer.Strategies.Contracts;
using MetroFramework.Controls;

namespace Fractalizer.Core.Controls
{
    public partial class FractalPicturePanel : MetroUserControl
    {

        private Point zoomStart = Point.Empty;
        private Point zoomEnd = Point.Empty;
        private Rectangle zoomRectangle;
        private bool isZooming = false;
        private bool isFractalRendered = false;
        private Color baseColor = Color.Black;

        private IRenderer renderer = Renderer.Instance;
        private readonly BackgroundWorker backgroundWorker;
        private readonly Dictionary<string, IFractalStrategy> strategies;

        public FractalPicturePanel()
        {
            InitializeComponent();
            this.backgroundWorker = new BackgroundWorker();
            this.InitializeBackgroundWorker();
            this.fractalImg.MouseDown += new MouseEventHandler(picBox_MouseDown);
            this.fractalImg.MouseUp += new MouseEventHandler(picBox_MouseUp);
            this.fractalImg.MouseMove += new MouseEventHandler(picBox_MouseMove);

            this.strategies = new Dictionary<string, IFractalStrategy>
            {
                    {  "Mandelbrot", Mandelbrot.Instance },
                    { "Julia", Julia.Instance },
                    { "Newton", Newton.Instance }
            };

        }


        public void RenderFractal(string fractalName, Color color)
        {
            //var assembly = AppDomain.CurrentDomain.Load("Fractalizer.Fractals");
            //var fractalType = assembly.GetType("Fractalizer.Fractals." + fractalName);

            //if (fractalType != null)
            //{
            //    var instance = (Fractal)fractalType
            //        .GetProperty("Instance", BindingFlags.Public | BindingFlags.Static)
            //        .GetValue(null);

            //    renderer.Fractal = instance;
            //}

            renderer.Strategy = strategies[fractalName];

            this.baseColor = color;
            if (!this.backgroundWorker.IsBusy && renderer != null)
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        private bool MouseIsOverPicture(Control c)
        {
            return c.ClientRectangle.Contains(c.PointToClient(fractalImg.PointToScreen(zoomEnd)));
        }

        private void InitializeBackgroundWorker()
        {
            this.backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
        }




        // TODO
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.fractalImg.Image = renderer.RenderFractal(zoomStart, zoomEnd, 128,baseColor);
        }

        private void backgroundWorker_RunWorkerCompleted(
            object sender,
            RunWorkerCompletedEventArgs e)
        {
            this.isFractalRendered = true;
            //this.lblTimer.Text = renderer.GetRenderingTime();
            //this.UpdateFormFields();
        }


        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !backgroundWorker.IsBusy && isFractalRendered)
            {
                this.zoomStart = new Point(e.X, e.Y);
                Point rectStart = fractalImg.PointToScreen(new Point(e.X, e.Y));
                this.zoomRectangle = new Rectangle(rectStart.X, rectStart.Y, 0, 0);
                this.isZooming = true;
            }
        }
        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isZooming && !backgroundWorker.IsBusy && isFractalRendered)
            {
                isFractalRendered = false;
                this.backgroundWorker.RunWorkerAsync();
            }

            this.zoomStart = Point.Empty;
            this.zoomEnd = Point.Empty;
            this.isZooming = false;
        }


        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {

            if (isZooming && MouseIsOverPicture(this.fractalImg) && !backgroundWorker.IsBusy && isFractalRendered)
            {

                ControlPaint.DrawReversibleFrame(zoomRectangle, this.BackColor, FrameStyle.Dashed);

                double zoomWidth = e.X - zoomStart.X;
                double zoomHeight = e.Y - zoomStart.Y;

                if (zoomWidth > zoomHeight)
                {
                    zoomHeight = zoomWidth;
                }
                else
                {
                    zoomWidth = zoomHeight;
                }

                this.zoomEnd = new Point((int)(zoomStart.X + zoomWidth), (int)(zoomStart.Y + zoomHeight));

                this.zoomRectangle.Width = (int)zoomWidth;
                this.zoomRectangle.Height = (int)zoomHeight / 2;

                ControlPaint.DrawReversibleFrame(zoomRectangle, this.BackColor, FrameStyle.Dashed);
            }
        }

    }
}
