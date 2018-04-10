using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Fractalizer.Core.Contracts;
using MetroFramework.Controls;

namespace Fractalizer.Core.Forms
{
    public partial class FractalPicturePanel : MetroUserControl
    {

        private Point zoomStart = Point.Empty;
        private Point zoomEnd = Point.Empty;
        private Rectangle zoomRectangle;
        private bool isZooming = false;
        private bool isFractalRendered = false;

        private readonly IRenderer renderer;
        private readonly BackgroundWorker backgroundWorker;

        public FractalPicturePanel()
        {
            InitializeComponent();
            this.renderer = new Renderer();
            this.backgroundWorker = new BackgroundWorker();
            this.InitializeBackgroundWorker();
            this.fractalImg.MouseDown += new MouseEventHandler(picBox_MouseDown);
            this.fractalImg.MouseUp += new MouseEventHandler(picBox_MouseUp);
            this.fractalImg.MouseMove += new MouseEventHandler(picBox_MouseMove);

        }


        public void RenderFractal()
        {
            if (!this.backgroundWorker.IsBusy)
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
            this.fractalImg.Image = renderer.RenderMandelbrot(zoomStart, zoomEnd,128);
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
                this.zoomRectangle.Height = (int)zoomHeight;

                ControlPaint.DrawReversibleFrame(zoomRectangle, this.BackColor, FrameStyle.Dashed);
            }
        }

    }
}
