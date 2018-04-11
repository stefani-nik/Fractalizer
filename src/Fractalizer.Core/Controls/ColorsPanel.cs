using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Fractalizer.Core.Controls
{
    public partial class ColorsPanel : MetroUserControl
    {
        public ColorsPanel()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnShowColor.BackColor = colorDialog.Color;
            }
        }

        public Color GetBaseColor()
        {
            return this.colorDialog.Color;
        }
    }
}
