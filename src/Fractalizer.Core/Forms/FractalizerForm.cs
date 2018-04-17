using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Fractalizer.Common;
using Fractalizer.Core.Contracts;
using Fractalizer.Core.Controls;
using MetroFramework.Forms;

namespace Fractalizer.Core.Forms
{
    public partial class FractalizerForm : MetroForm
    {
        #region Members

        #endregion

        public SettingsPanel settingsPanel;
        public FractalPicturePanel fractalPicturePanel;
        public StatusPanel statusPanel;

        public FractalizerForm()
        {
            this.statusPanel = new StatusPanel();
            this.fractalPicturePanel = new FractalPicturePanel(this.statusPanel);
            this.settingsPanel = new SettingsPanel(this.fractalPicturePanel);
            this.fractalPicturePanel.settingsPanel = this.settingsPanel;
             InitializeComponent();
            this.Controls.Add(fractalPicturePanel);
            this.Controls.Add(settingsPanel);
            this.Controls.Add(statusPanel);
            //this.Activate();
            //this.UpdateFormFields();
        }

   
    }
}
