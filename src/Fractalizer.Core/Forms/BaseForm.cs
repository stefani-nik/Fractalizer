using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Fractalizer.Common;
using Fractalizer.Core.Contracts;
using MetroFramework.Forms;

namespace Fractalizer.Core.Forms
{
    public partial class BaseForm : MetroForm
    {
        #region Members

        #endregion

        private SettingsPanel settingsPanel;
        private FractalPicturePanel fractalPicturePannel;
        public BaseForm()
        {
            this.fractalPicturePannel = new FractalPicturePanel();
            this.settingsPanel = new SettingsPanel(this.fractalPicturePannel);
            InitializeComponent();
            this.Controls.Add(fractalPicturePannel);
            this.Controls.Add(settingsPanel);
            //this.UpdateFormFields();
        }

   
    }
}
