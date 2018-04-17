using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Collections.Generic;
using Fractalizer.Core.Contracts;

namespace Fractalizer.Core.Controls
{
    public partial class SettingsPanel : MetroUserControl
    {
        private readonly FractalPicturePanel fractalPicturePanel;
        private readonly Dictionary<string, ICustomSettingsPanel> settingsPanels ;
        private ICustomSettingsPanel activeSettinsPanel;
        private string fractalParameters = null;

        public SettingsPanel(FractalPicturePanel frPicPanel)
        {
            fractalPicturePanel = frPicPanel;

            InitializeComponent();

            // this.HideSettingsPanels();
            this.settingsPanels = new Dictionary<string, ICustomSettingsPanel>
            {
                { "Julia" , this.juliaSettingsPanel },
                { "Newton", this.newtonSettingsPanel1 }
            };

            this.btnRender.Click += new EventHandler(btnRender_Click);
        }

        private void SettingsPanel_Load(object sender, EventArgs e)
        {
            HideSettingsPanels();
        }

        private void btnRender_Click(object sender, EventArgs e)
        {
            string selected = this.fractalComboBox.SelectedItem
                              .ToString()
                              .Split(' ')[0]
                              .Trim();
            Color baseColor = this.colorsPanel1.GetBaseColor();

            if(activeSettinsPanel != null)
            this.fractalParameters = this.activeSettinsPanel.Params;


            //HideSettingsPanels();
            // ShowSettingsPanel(selected);
            fractalPicturePanel.RenderFractal(selected,baseColor,fractalParameters);

        }

        //TODO: FIX
        private void iterationsTrackBar_ValueChanged(object sender, EventArgs e)
        {
            iterationsToolTip.SetToolTip(iterationsTrackBar, iterationsTrackBar.Value.ToString());
        }

        private void iterationsToolTip_Draw(object sender, System.Windows.Forms.DrawToolTipEventArgs e)
        {
            Font f = new Font("Arial", 16.0f);
            e.DrawBackground();
            e.DrawBorder();     
            e.Graphics.DrawString(e.ToolTipText, f, Brushes.White, new PointF(2, 2));
        }

        private void iterationsToolTip_Popup(object sender, System.Windows.Forms.PopupEventArgs e)
        {
            e.ToolTipSize = TextRenderer.MeasureText(iterationsTrackBar.Value.ToString(), new Font("Arial", 16.0f));
        }


        private void ShowSettingsPanel(string fractal)
        {


            if(settingsPanels.ContainsKey(fractal))
            {
                this.activeSettinsPanel = settingsPanels[fractal];
                this.activeSettinsPanel.Show();
            }

            //string fieldName = fractal.ToLower() + "SettingsPanel";
            //var field = this.GetType().GetField(fieldName, BindingFlags.DeclaredOnly |
            //                                      BindingFlags.Instance |
            //                                      BindingFlags.NonPublic).GetValue(this);
            
            //MethodInfo showMethod = field.GetType().GetMethod("Show");
            //showMethod.Invoke(field, null);
            
        }

        private void HideSettingsPanels()
        {
           // this.mandelbrotSettingsPanel.Hide();
            this.juliaSettingsPanel.Hide();
            this.newtonSettingsPanel1.Hide();
        }

        private void fractalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HideSettingsPanels();
            string selected = this.fractalComboBox.SelectedItem
                              .ToString()
                              .Split(' ')[0]
                              .Trim();
            this.ShowSettingsPanel(selected);
        }
    }
}
