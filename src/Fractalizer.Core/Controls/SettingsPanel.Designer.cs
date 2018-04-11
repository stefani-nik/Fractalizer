using Fractalizer.Core.Forms;

namespace Fractalizer.Core.Controls
{
    partial class SettingsPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPanel));
            this.fractalComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.btnRender = new MetroFramework.Controls.MetroButton();
            this.lblFractalCombo = new MetroFramework.Controls.MetroLabel();
            this.lblIteration = new MetroFramework.Controls.MetroLabel();
            this.colorsPanel1 = new Fractalizer.Core.Controls.ColorsPanel();
            this.SuspendLayout();
            // 
            // fractalComboBox
            // 
            this.fractalComboBox.DisplayMember = "Mandelbrot";
            this.fractalComboBox.FormattingEnabled = true;
            this.fractalComboBox.ItemHeight = 23;
            this.fractalComboBox.Items.AddRange(new object[] {
            "Mandelbrot Set",
            "Julia Set",
            "Newton Set"});
            this.fractalComboBox.Location = new System.Drawing.Point(165, 0);
            this.fractalComboBox.Name = "fractalComboBox";
            this.fractalComboBox.Size = new System.Drawing.Size(160, 29);
            this.fractalComboBox.TabIndex = 6;
            this.fractalComboBox.Tag = "";
            this.fractalComboBox.UseSelectable = true;
            this.fractalComboBox.SelectedIndex = 0;
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Location = new System.Drawing.Point(581, 3);
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(198, 23);
            this.metroTrackBar1.TabIndex = 7;
            this.metroTrackBar1.Text = "metroTrackBar1";
            // 
            // btnRender
            // 
            this.btnRender.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRender.BackgroundImage")));
            this.btnRender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRender.Location = new System.Drawing.Point(1056, 3);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(154, 61);
            this.btnRender.TabIndex = 8;
            this.btnRender.Tag = "";
            this.btnRender.UseSelectable = true;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // lblFractalCombo
            // 
            this.lblFractalCombo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblFractalCombo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblFractalCombo.Location = new System.Drawing.Point(19, 0);
            this.lblFractalCombo.Name = "lblFractalCombo";
            this.lblFractalCombo.Size = new System.Drawing.Size(140, 29);
            this.lblFractalCombo.TabIndex = 10;
            this.lblFractalCombo.Text = "Choose fractal";
            // 
            // lblIteration
            // 
            this.lblIteration.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblIteration.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblIteration.Location = new System.Drawing.Point(371, 0);
            this.lblIteration.Name = "lblIteration";
            this.lblIteration.Size = new System.Drawing.Size(194, 29);
            this.lblIteration.TabIndex = 11;
            this.lblIteration.Text = "Number of iterations";
            // 
            // colorsPanel1
            // 
            this.colorsPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.colorsPanel1.Location = new System.Drawing.Point(819, 0);
            this.colorsPanel1.Name = "colorsPanel1";
            this.colorsPanel1.Size = new System.Drawing.Size(157, 39);
            this.colorsPanel1.TabIndex = 9;
            this.colorsPanel1.UseSelectable = true;
            // 
            // SettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.lblIteration);
            this.Controls.Add(this.lblFractalCombo);
            this.Controls.Add(this.colorsPanel1);
            this.Controls.Add(this.btnRender);
            this.Controls.Add(this.metroTrackBar1);
            this.Controls.Add(this.fractalComboBox);
            this.Location = new System.Drawing.Point(0, 72);
            this.Name = "SettingsPanel";
            this.Size = new System.Drawing.Size(1248, 66);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private MetroFramework.Controls.MetroButton btnRender;
        private ColorsPanel colorsPanel1;
        private MetroFramework.Controls.MetroComboBox fractalComboBox;
        private MetroFramework.Controls.MetroLabel lblFractalCombo;
        private MetroFramework.Controls.MetroLabel lblIteration;
    }
}
