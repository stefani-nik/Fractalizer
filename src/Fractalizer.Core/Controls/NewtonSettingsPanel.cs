using System;
using System.Windows.Forms;
using Fractalizer.Core.Contracts;

namespace Fractalizer.Core.Controls
{
    public partial class NewtonSettingsPanel : UserControl, ICustomSettingsPanel
    {
        public string Params { get; set; }

        public NewtonSettingsPanel()
        {
            InitializeComponent();
            AdjustParams();
        }

        public string GetParameters()
        {
            return this.newtonEquationComboBox.SelectedItem.ToString();
        }

        private void AdjustParams()
        {
            this.Params = this.newtonEquationComboBox.SelectedItem.ToString();
        }

        private void newtonEquationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdjustParams();
        }
    }
}
