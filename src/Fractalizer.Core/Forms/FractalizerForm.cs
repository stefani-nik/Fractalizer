﻿using System.ComponentModel;
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

        private SettingsPanel settingsPanel;
        private FractalPicturePanel fractalPicturePanel;
        private StatusPanel statusPanel;

        public FractalizerForm()
        {
            this.statusPanel = new StatusPanel();
            this.fractalPicturePanel = new FractalPicturePanel();
            this.settingsPanel = new SettingsPanel();

            this.settingsPanel.FormPicturePanel = this.fractalPicturePanel;
            this.fractalPicturePanel.FormSettingsPanel = this.settingsPanel;
            this.fractalPicturePanel.FormStatusPanel = this.statusPanel;
           
            InitializeComponent();
            this.Controls.Add(fractalPicturePanel);
            this.Controls.Add(settingsPanel);
            this.Controls.Add(statusPanel);

            this.statusPanel.Hide();

        }

   
    }
}
