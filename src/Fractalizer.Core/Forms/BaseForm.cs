using MetroFramework.Forms;

namespace Fractalizer.Core.Forms
{
    public partial class BaseForm : MetroForm
    {
        public BaseForm()
        {
            InitializeComponent();
            this.Controls.Add(new SettingsPanel());
            this.Controls.Add(new ColorsPanel());
            this.Controls.Add(new FractalPicturePanel());
        }
    }
}
