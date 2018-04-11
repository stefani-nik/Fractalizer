using System;
using System.Drawing;
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
        }
    }
}
