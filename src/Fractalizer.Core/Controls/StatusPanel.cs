using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //public void StopStatusRendering()
        //{
        //    this.renderingProgressSpinner.Invoke(new Action(() => { renderingProgressSpinner.Hide(); }));
        //    this.lblRendering.Invoke(new Action(() => { lblRendering.Hide(); }));
        //    this.lblRenderingTime.Invoke(new Action(() => { lblRenderingTime.Show(); }));
        //    this.lblTime.Invoke(new Action(() => { renderingProgressSpinner.Show(); }));
        //}

        //public void StartStatusRendering()
        //{
        //    this.renderingProgressSpinner.Invoke(new Action(() => { renderingProgressSpinner.Show(); }));
        //    this.lblRendering.Invoke(new Action(() => { lblRendering.Show(); }));
        //    this.lblRenderingTime.Invoke(new Action(() => { lblRenderingTime.Hide(); }));
        //    this.lblTime.Invoke(new Action(() => { renderingProgressSpinner.Hide(); }));
        //}


        public void SetRenderingTime(string time)
        {
            this.lblTime.Text = time;
        }
    }
}
