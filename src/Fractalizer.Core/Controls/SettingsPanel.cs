using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Fractalizer.Core.Controls
{
    public partial class SettingsPanel : MetroUserControl
    {
        private readonly FractalPicturePanel fractalPicturePanel;

        public SettingsPanel(FractalPicturePanel frPicPanel)
        {
            fractalPicturePanel = frPicPanel;
            InitializeComponent();
            this.btnRender.Click += new EventHandler(btnRender_Click);
        }


        private void btnRender_Click(object sender, EventArgs e)
        {
            string selected = this.fractalComboBox.SelectedItem
                              .ToString()
                              .Split(' ')[0]
                              .Trim();
            Color baseColor = this.colorsPanel1.GetBaseColor();
            fractalPicturePanel.RenderFractal(selected,baseColor);
            mandelbrotSettingsPanel1.Show();
        }

        //TODO: FIX
        private void iterationsTrackBar_ValueChanged(object sender, EventArgs e)
        {
            iterationsToolTip.SetToolTip(iterationsTrackBar, iterationsTrackBar.Value.ToString());
        }

        private void iterationsToolTip_Draw(object sender, System.Windows.Forms.DrawToolTipEventArgs e)
        {
            Font f = new Font("Arial", 16.0f);
            e.DrawBackground();
            e.DrawBorder();     
            e.Graphics.DrawString(e.ToolTipText, f, Brushes.White, new PointF(2, 2));
        }

        private void iterationsToolTip_Popup(object sender, System.Windows.Forms.PopupEventArgs e)
        {
            e.ToolTipSize = TextRenderer.MeasureText(iterationsTrackBar.Value.ToString(), new Font("Arial", 16.0f));
        }

        private void SettingsPanel_Load(object sender, EventArgs e)
        {
            this.mandelbrotSettingsPanel1.Hide();
        }
    }
}
