using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Collections.Generic;
using Fractalizer.Common;
using Fractalizer.Core.Contracts;

namespace Fractalizer.Core.Controls
{
    public partial class SettingsPanel : MetroUserControl
    {
        private readonly Dictionary<string, ICustomSettingsPanel> settingsPanels;
        private ICustomSettingsPanel activeSettingsPanel;
        private string fractalParameters;

        public FractalPicturePanel FormPicturePanel { get; set; }

        public SettingsPanel()
        {

            InitializeComponent();
            this.SetDefaultParameters();

            this.settingsPanels = new Dictionary<string, ICustomSettingsPanel>
            {
                { "Julia" , this.juliaSettingsPanel },
                { "Newton", this.newtonSettingsPanel }
            };

            this.btnRender.Click += new EventHandler(btnRender_Click);
        }

       

        private void ShowSettingsPanels(string fractal)
        {
            if (settingsPanels == null || !settingsPanels.ContainsKey(fractal)) return;
            this.activeSettingsPanel = settingsPanels[fractal];
            this.activeSettingsPanel.Show();
        }

        private void HideSettingsPanels()
        {
            this.juliaSettingsPanel.Hide();
            this.newtonSettingsPanel.Hide();
        }

        public void UpdateFractalParameters()
        {
          
                var currentParams = this.FormPicturePanel.GetFractalParameters();

                this.txtBoxXvalue.Text = currentParams["XStartValue"];
                this.txtBoxYvalue.Text = currentParams["YStartValue"];
                this.txtBoxXrange.Text = currentParams["XRange"];
                this.txtBoxYrange.Text = currentParams["YRange"];
            
          
        }

        private void fractalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HideSettingsPanels();
            string selected = this.fractalComboBox.SelectedItem
                              .ToString()
                              .Split(' ')[0]
                              .Trim();

            this.ShowSettingsPanels(selected);

            this.FormPicturePanel?.SetStrategy(selected);
        }

        private void SetDefaultParameters()
        {
            this.txtBoxXvalue.Text = Constants.StartValueX.ToString();
            this.txtBoxYvalue.Text = Constants.StartValueY.ToString();
            this.txtBoxXrange.Text = Constants.XRange.ToString();
            this.txtBoxYrange.Text = Constants.YRange.ToString();
           
        }

        #region EventHandlers

        private void SettingsPanel_Load(object sender, EventArgs e)
        {
            this.HideSettingsPanels();
        }

        private void btnRender_Click(object sender, EventArgs e)
        {

            Color baseColor = this.colorsPanel.IsColorful() ? Color.Empty : this.colorsPanel.GetBaseColor();

            int iterations = this.iterationsTrackBar.Value;

            if (activeSettingsPanel != null)
                this.fractalParameters = this.activeSettingsPanel.Params;

            this.FormPicturePanel.SetDefaultParameters();
            this.FormPicturePanel.RenderFractal(iterations, baseColor, fractalParameters);

        }


        private void iterationsTrackBar_ValueChanged(object sender, EventArgs e)
        {
            this.iterationsToolTip.SetToolTip(iterationsTrackBar, iterationsTrackBar.Value.ToString());
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

        #endregion

    }
}
