using System.Windows.Forms;

namespace Fractalizer.Core.Controls
{
    public partial class StatusPanel : UserControl
    {
        public StatusPanel()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        public void StopStatusRendering()
        {
            this.renderingProgressSpinner.Hide();
            this.lblRendering.Hide();
            this.lblRenderingTime.Show();
            this.lblTime.Show();
        }

        public void StartStatusRendering()
        {
            this.renderingProgressSpinner.Show();
            this.lblRendering.Show();
            this.lblRenderingTime.Hide();
            this.lblTime.Hide();
        }

        public void SetRenderingTime(string time)
        {
            this.lblTime.Text = time;
        }
    }
}
