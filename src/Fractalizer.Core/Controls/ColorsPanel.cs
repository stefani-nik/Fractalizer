using System;
using MetroFramework.Controls;

namespace Fractalizer.Core.Forms
{
    public partial class ColorsPanel : MetroUserControl
    {
        public ColorsPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }
    }
}
