using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Fractalizer.Core.Contracts;
using Fractalizer.Core.Decorators;
using Fractalizer.Core.Forms;
using Fractalizer.Fractals;
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
        private string fractalParameters = null;
        private int iterations = 0;
        private readonly StatusPanel statusPanel;
        private string fractal = null;

        private readonly IRenderer renderer = Renderer.Instance;
        private readonly BackgroundWorker backgroundWorker;
        private readonly Dictionary<string, IFractalStrategy> strategies;
        

        public FractalPicturePanel(StatusPanel statPanel)
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
            this.statusPanel = statPanel;
            this.statusPanel.Hide();
        }


        public void RenderFractal(int it, Color color, string parameters)
        {
            this.baseColor = color;
            this.fractalParameters = parameters;
            this.iterations = it;
           

            if (!this.backgroundWorker.IsBusy && renderer != null)
            {
                this.statusPanel.Show();
                backgroundWorker.RunWorkerAsync();
            }
        }

        public Dictionary<string, string> GetFractalParameters()
        {
            return strategies[this.fractal].GetFractalParameters();
        }

        public void SetStrategy(string fractalName)
        {
            this.fractal = fractalName;
            renderer.Strategy = strategies[this.fractal];
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
            this.statusPanel.StartStatusRendering();
            this.fractalImg.Image = renderer.RenderFractal(zoomStart, zoomEnd, iterations,baseColor, fractalParameters);
        }

        private void backgroundWorker_RunWorkerCompleted(
            object sender,
            RunWorkerCompletedEventArgs e)
        {
            this.isFractalRendered = true;
            string timeStr = renderer.GetRenderingTime();
            this.statusPanel.SetRenderingTime(timeStr);
            this.statusPanel.StopStatusRendering();
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
