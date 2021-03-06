﻿using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Fractalizer.Core.Controls
{
    public partial class ColorsPanel : MetroUserControl
    {
        public ColorsPanel()
        {
            InitializeComponent();
        }

        public Color GetBaseColor()
        {
            return this.colorDialog.Color;
        }

        public bool IsColorful()
        {
            return this.colorfulCheckBox.Checked;
        }

        // Toggle color panel elements

        private void AdjustCheckboxProperties()
        {
            if (this.colorfulCheckBox.Checked)
            {
                this.btnColor.Hide();
                this.btnShowColor.BackgroundImage = Image.FromFile(
                                                    AppDomain.CurrentDomain.BaseDirectory
                                                    .Replace("\\bin\\Debug\\", "")
                                                    + "\\Assets\\colorful-btn.bmp");
            }
            else
            {
                this.btnColor.Show();
                this.btnShowColor.BackgroundImage = null;
                this.btnShowColor.BackColor = colorDialog.Color;
            }
            
        }

        #region EventHandlers
        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.btnShowColor.BackColor = colorDialog.Color;
            }
        }

        private void colorfulCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            AdjustCheckboxProperties();
        }

        #endregion
    }
}
