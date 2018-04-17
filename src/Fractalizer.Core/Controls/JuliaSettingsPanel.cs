using System.Windows.Forms;
using Fractalizer.Core.Contracts;

namespace Fractalizer.Core.Controls
{
    public partial class JuliaSettingsPanel : UserControl, ICustomSettingsPanel
    {
        public string Params { get; set; }

        public JuliaSettingsPanel()
        {
            InitializeComponent();
            AdjustParams();
        }

        public string GetParameters()
        {
            return this.juliaComplexNumberComboBox.SelectedItem.ToString();
        }

        private void AdjustParams()
        {
            this.Params = this.juliaComplexNumberComboBox.SelectedItem.ToString();
        }

        #region EventHandlers
        private void juliaComplexNumberComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            AdjustParams();
        }
        #endregion
    }
}
