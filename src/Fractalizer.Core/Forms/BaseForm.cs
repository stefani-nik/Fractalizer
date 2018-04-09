using MetroFramework.Forms;

namespace Fractalizer.Core.Forms
{
    public partial class BaseForm : MetroForm
    {
        public BaseForm()
        {
            InitializeComponent();
            this.Controls.Add(new SettingsPanel());
            this.Controls.Add(new FractalPicturePanel());
        }

        private void BaseForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
