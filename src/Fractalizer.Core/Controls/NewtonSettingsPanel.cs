using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        public string GetParameters()
        {
            return String.Empty;
        }
    }
}
