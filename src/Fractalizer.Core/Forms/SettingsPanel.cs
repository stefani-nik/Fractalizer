using System;
using System.Data;
using MetroFramework.Controls;

namespace Fractalizer.Core.Forms
{
    public partial class SettingsPanel : MetroUserControl
    {
        private FractalPicturePanel fractalPicturePanel;

        public SettingsPanel(FractalPicturePanel frPicPanel)
        {
            fractalPicturePanel = frPicPanel;
            InitializeComponent();
            this.btnRender.Click += new EventHandler(metroButton1_Click);
        }



        private void SettingsPanel_Load(object sender, System.EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, System.EventArgs e)
        {
            fractalPicturePanel.RenderFractal();
        }

    }
}
