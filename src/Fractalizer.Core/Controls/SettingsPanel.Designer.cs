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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPanel));
            this.fractalComboBox = new MetroFramework.Controls.MetroComboBox();
            this.iterationsTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.btnRender = new MetroFramework.Controls.MetroButton();
            this.lblFractalCombo = new MetroFramework.Controls.MetroLabel();
            this.lblIterations = new MetroFramework.Controls.MetroLabel();
            this.iterationsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mandelbrotSettingsPanel1 = new Fractalizer.Core.Controls.MandelbrotSettingsPanel();
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
            this.fractalComboBox.Location = new System.Drawing.Point(174, 24);
            this.fractalComboBox.Name = "fractalComboBox";
            this.fractalComboBox.Size = new System.Drawing.Size(160, 29);
            this.fractalComboBox.TabIndex = 6;
            this.fractalComboBox.Tag = "";
            this.fractalComboBox.UseSelectable = true;
            // 
            // iterationsTrackBar
            // 
            this.iterationsTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.iterationsTrackBar.Location = new System.Drawing.Point(590, 30);
            this.iterationsTrackBar.Maximum = 500;
            this.iterationsTrackBar.Name = "iterationsTrackBar";
            this.iterationsTrackBar.Size = new System.Drawing.Size(198, 23);
            this.iterationsTrackBar.TabIndex = 7;
            this.iterationsTrackBar.Text = "iterationsTrackBar";
            this.iterationsTrackBar.Value = 128;
            this.iterationsTrackBar.ValueChanged += new System.EventHandler(this.iterationsTrackBar_ValueChanged);
            // 
            // btnRender
            // 
            this.btnRender.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRender.BackgroundImage")));
            this.btnRender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRender.Location = new System.Drawing.Point(1052, 49);
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
            this.lblFractalCombo.Location = new System.Drawing.Point(17, 24);
            this.lblFractalCombo.Name = "lblFractalCombo";
            this.lblFractalCombo.Size = new System.Drawing.Size(140, 29);
            this.lblFractalCombo.TabIndex = 10;
            this.lblFractalCombo.Text = "Choose fractal";
            // 
            // lblIterations
            // 
            this.lblIterations.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblIterations.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblIterations.Location = new System.Drawing.Point(368, 24);
            this.lblIterations.Name = "lblIterations";
            this.lblIterations.Size = new System.Drawing.Size(194, 29);
            this.lblIterations.TabIndex = 11;
            this.lblIterations.Text = "Number of iterations";
            // 
            // iterationsToolTip
            // 
            this.iterationsToolTip.AutomaticDelay = 1000;
            this.iterationsToolTip.BackColor = System.Drawing.SystemColors.GrayText;
            this.iterationsToolTip.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iterationsToolTip.OwnerDraw = true;
            this.iterationsToolTip.UseAnimation = false;
            this.iterationsToolTip.UseFading = false;
            this.iterationsToolTip.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.iterationsToolTip_Draw);
            this.iterationsToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.iterationsToolTip_Popup);
            // 
            // mandelbrotSettingsPanel1
            // 
            this.mandelbrotSettingsPanel1.BackColor = System.Drawing.Color.Transparent;
            this.mandelbrotSettingsPanel1.Location = new System.Drawing.Point(43, 80);
            this.mandelbrotSettingsPanel1.Name = "mandelbrotSettingsPanel1";
            this.mandelbrotSettingsPanel1.Size = new System.Drawing.Size(820, 30);
            this.mandelbrotSettingsPanel1.TabIndex = 12;
            // 
            // colorsPanel1
            // 
            this.colorsPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.colorsPanel1.Location = new System.Drawing.Point(857, 24);
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
            this.Controls.Add(this.mandelbrotSettingsPanel1);
            this.Controls.Add(this.lblIterations);
            this.Controls.Add(this.lblFractalCombo);
            this.Controls.Add(this.colorsPanel1);
            this.Controls.Add(this.btnRender);
            this.Controls.Add(this.iterationsTrackBar);
            this.Controls.Add(this.fractalComboBox);
            this.Location = new System.Drawing.Point(0, 72);
            this.Name = "SettingsPanel";
            this.Size = new System.Drawing.Size(1248, 126);
            this.Load += new System.EventHandler(this.SettingsPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTrackBar iterationsTrackBar;
        private MetroFramework.Controls.MetroButton btnRender;
        private ColorsPanel colorsPanel1;
        private MetroFramework.Controls.MetroComboBox fractalComboBox;
        private MetroFramework.Controls.MetroLabel lblFractalCombo;
        private MetroFramework.Controls.MetroLabel lblIterations;
        private System.Windows.Forms.ToolTip iterationsToolTip;
        private MandelbrotSettingsPanel mandelbrotSettingsPanel1;
    }
}
