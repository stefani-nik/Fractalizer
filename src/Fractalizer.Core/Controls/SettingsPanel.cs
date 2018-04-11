using System;
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
            this.btnRender.Click += new EventHandler(metroButton1_Click);
        }



        private void SettingsPanel_Load(object sender, System.EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, System.EventArgs e)
        {
            string selected = this.fractalComboBox.SelectedItem
                                .ToString()
                                .Split(' ')[0]
                                .Trim();

            fractalPicturePanel.RenderFractal(selected);
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
