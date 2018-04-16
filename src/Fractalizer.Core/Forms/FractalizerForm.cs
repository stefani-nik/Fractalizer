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
        public FractalPicturePanel fractalPicturePannel;

        public FractalizerForm()
        {
            this.fractalPicturePannel = new FractalPicturePanel();
            this.settingsPanel = new SettingsPanel(this.fractalPicturePannel);
            InitializeComponent();
            this.Controls.Add(fractalPicturePannel);
            this.Controls.Add(settingsPanel);
            this.Activate();
            //this.UpdateFormFields();
        }

   
    }
}
