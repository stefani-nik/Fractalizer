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
            this.lblXvalue = new MetroFramework.Controls.MetroLabel();
            this.txtBoxXvalue = new MetroFramework.Controls.MetroTextBox();
            this.lblYvalue = new MetroFramework.Controls.MetroLabel();
            this.txtBoxYvalue = new MetroFramework.Controls.MetroTextBox();
            this.lblXrange = new MetroFramework.Controls.MetroLabel();
            this.txtBoxXrange = new MetroFramework.Controls.MetroTextBox();
            this.lblYrange = new MetroFramework.Controls.MetroLabel();
            this.txtBoxYrange = new MetroFramework.Controls.MetroTextBox();
            this.juliaSettingsPanel = new Fractalizer.Core.Controls.JuliaSettingsPanel();
            this.colorsPanel1 = new Fractalizer.Core.Controls.ColorsPanel();
            this.newtonSettingsPanel1 = new Fractalizer.Core.Controls.NewtonSettingsPanel();
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
            this.fractalComboBox.SelectedIndexChanged += new System.EventHandler(this.fractalComboBox_SelectedIndexChanged);
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
            this.btnRender.Location = new System.Drawing.Point(1091, 39);
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
            // lblXvalue
            // 
            this.lblXvalue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblXvalue.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblXvalue.Location = new System.Drawing.Point(368, 87);
            this.lblXvalue.Name = "lblXvalue";
            this.lblXvalue.Size = new System.Drawing.Size(100, 23);
            this.lblXvalue.TabIndex = 12;
            this.lblXvalue.Text = "X start value";
            this.lblXvalue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxXvalue
            // 
            // 
            // 
            // 
            this.txtBoxXvalue.CustomButton.Image = null;
            this.txtBoxXvalue.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtBoxXvalue.CustomButton.Name = "";
            this.txtBoxXvalue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxXvalue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxXvalue.CustomButton.TabIndex = 1;
            this.txtBoxXvalue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxXvalue.CustomButton.UseSelectable = true;
            this.txtBoxXvalue.CustomButton.Visible = false;
            this.txtBoxXvalue.Enabled = false;
            this.txtBoxXvalue.Lines = new string[] {
        "0.0"};
            this.txtBoxXvalue.Location = new System.Drawing.Point(474, 87);
            this.txtBoxXvalue.MaxLength = 32767;
            this.txtBoxXvalue.Name = "txtBoxXvalue";
            this.txtBoxXvalue.PasswordChar = '\0';
            this.txtBoxXvalue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxXvalue.SelectedText = "";
            this.txtBoxXvalue.SelectionLength = 0;
            this.txtBoxXvalue.SelectionStart = 0;
            this.txtBoxXvalue.ShortcutsEnabled = true;
            this.txtBoxXvalue.Size = new System.Drawing.Size(75, 23);
            this.txtBoxXvalue.TabIndex = 13;
            this.txtBoxXvalue.Text = "0.0";
            this.txtBoxXvalue.UseSelectable = true;
            this.txtBoxXvalue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxXvalue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblYvalue
            // 
            this.lblYvalue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYvalue.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblYvalue.Location = new System.Drawing.Point(571, 87);
            this.lblYvalue.Name = "lblYvalue";
            this.lblYvalue.Size = new System.Drawing.Size(100, 23);
            this.lblYvalue.TabIndex = 14;
            this.lblYvalue.Text = "Y start value";
            this.lblYvalue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxYvalue
            // 
            // 
            // 
            // 
            this.txtBoxYvalue.CustomButton.Image = null;
            this.txtBoxYvalue.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtBoxYvalue.CustomButton.Name = "";
            this.txtBoxYvalue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxYvalue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxYvalue.CustomButton.TabIndex = 1;
            this.txtBoxYvalue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxYvalue.CustomButton.UseSelectable = true;
            this.txtBoxYvalue.CustomButton.Visible = false;
            this.txtBoxYvalue.Enabled = false;
            this.txtBoxYvalue.Lines = new string[] {
        "0.0"};
            this.txtBoxYvalue.Location = new System.Drawing.Point(677, 86);
            this.txtBoxYvalue.MaxLength = 32767;
            this.txtBoxYvalue.Name = "txtBoxYvalue";
            this.txtBoxYvalue.PasswordChar = '\0';
            this.txtBoxYvalue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxYvalue.SelectedText = "";
            this.txtBoxYvalue.SelectionLength = 0;
            this.txtBoxYvalue.SelectionStart = 0;
            this.txtBoxYvalue.ShortcutsEnabled = true;
            this.txtBoxYvalue.Size = new System.Drawing.Size(75, 23);
            this.txtBoxYvalue.TabIndex = 15;
            this.txtBoxYvalue.Text = "0.0";
            this.txtBoxYvalue.UseSelectable = true;
            this.txtBoxYvalue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxYvalue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblXrange
            // 
            this.lblXrange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblXrange.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblXrange.Location = new System.Drawing.Point(757, 86);
            this.lblXrange.Name = "lblXrange";
            this.lblXrange.Size = new System.Drawing.Size(100, 23);
            this.lblXrange.TabIndex = 16;
            this.lblXrange.Text = "X range";
            this.lblXrange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxXrange
            // 
            // 
            // 
            // 
            this.txtBoxXrange.CustomButton.Image = null;
            this.txtBoxXrange.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtBoxXrange.CustomButton.Name = "";
            this.txtBoxXrange.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxXrange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxXrange.CustomButton.TabIndex = 1;
            this.txtBoxXrange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxXrange.CustomButton.UseSelectable = true;
            this.txtBoxXrange.CustomButton.Visible = false;
            this.txtBoxXrange.Enabled = false;
            this.txtBoxXrange.Lines = new string[] {
        "0.0"};
            this.txtBoxXrange.Location = new System.Drawing.Point(843, 87);
            this.txtBoxXrange.MaxLength = 32767;
            this.txtBoxXrange.Name = "txtBoxXrange";
            this.txtBoxXrange.PasswordChar = '\0';
            this.txtBoxXrange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxXrange.SelectedText = "";
            this.txtBoxXrange.SelectionLength = 0;
            this.txtBoxXrange.SelectionStart = 0;
            this.txtBoxXrange.ShortcutsEnabled = true;
            this.txtBoxXrange.Size = new System.Drawing.Size(75, 23);
            this.txtBoxXrange.TabIndex = 17;
            this.txtBoxXrange.Text = "0.0";
            this.txtBoxXrange.UseSelectable = true;
            this.txtBoxXrange.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxXrange.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblYrange
            // 
            this.lblYrange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYrange.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblYrange.Location = new System.Drawing.Point(914, 87);
            this.lblYrange.Name = "lblYrange";
            this.lblYrange.Size = new System.Drawing.Size(100, 23);
            this.lblYrange.TabIndex = 18;
            this.lblYrange.Text = "Y range";
            this.lblYrange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxYrange
            // 
            // 
            // 
            // 
            this.txtBoxYrange.CustomButton.Image = null;
            this.txtBoxYrange.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtBoxYrange.CustomButton.Name = "";
            this.txtBoxYrange.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxYrange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxYrange.CustomButton.TabIndex = 1;
            this.txtBoxYrange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxYrange.CustomButton.UseSelectable = true;
            this.txtBoxYrange.CustomButton.Visible = false;
            this.txtBoxYrange.Enabled = false;
            this.txtBoxYrange.Lines = new string[] {
        "0.0"};
            this.txtBoxYrange.Location = new System.Drawing.Point(999, 87);
            this.txtBoxYrange.MaxLength = 32767;
            this.txtBoxYrange.Name = "txtBoxYrange";
            this.txtBoxYrange.PasswordChar = '\0';
            this.txtBoxYrange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxYrange.SelectedText = "";
            this.txtBoxYrange.SelectionLength = 0;
            this.txtBoxYrange.SelectionStart = 0;
            this.txtBoxYrange.ShortcutsEnabled = true;
            this.txtBoxYrange.Size = new System.Drawing.Size(75, 23);
            this.txtBoxYrange.TabIndex = 19;
            this.txtBoxYrange.Text = "0.0";
            this.txtBoxYrange.UseSelectable = true;
            this.txtBoxYrange.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxYrange.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // juliaSettingsPanel
            // 
            this.juliaSettingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.juliaSettingsPanel.Location = new System.Drawing.Point(17, 74);
            this.juliaSettingsPanel.Name = "juliaSettingsPanel";
            this.juliaSettingsPanel.Size = new System.Drawing.Size(327, 36);
            this.juliaSettingsPanel.TabIndex = 20;
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
            // newtonSettingsPanel1
            // 
            this.newtonSettingsPanel1.BackColor = System.Drawing.Color.Transparent;
            this.newtonSettingsPanel1.Location = new System.Drawing.Point(52, 80);
            this.newtonSettingsPanel1.Name = "newtonSettingsPanel1";
            this.newtonSettingsPanel1.Size = new System.Drawing.Size(282, 29);
            this.newtonSettingsPanel1.TabIndex = 21;
            // 
            // SettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.newtonSettingsPanel1);
            this.Controls.Add(this.juliaSettingsPanel);
            this.Controls.Add(this.txtBoxXrange);
            this.Controls.Add(this.txtBoxYvalue);
            this.Controls.Add(this.txtBoxYrange);
            this.Controls.Add(this.lblYrange);
            this.Controls.Add(this.lblXrange);
            this.Controls.Add(this.lblYvalue);
            this.Controls.Add(this.txtBoxXvalue);
            this.Controls.Add(this.lblXvalue);
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
        private MetroFramework.Controls.MetroLabel lblXvalue;
        private MetroFramework.Controls.MetroTextBox txtBoxXvalue;
        private MetroFramework.Controls.MetroLabel lblYvalue;
        private MetroFramework.Controls.MetroTextBox txtBoxYvalue;
        private MetroFramework.Controls.MetroLabel lblXrange;
        private MetroFramework.Controls.MetroTextBox txtBoxXrange;
        private MetroFramework.Controls.MetroLabel lblYrange;
        private MetroFramework.Controls.MetroTextBox txtBoxYrange;
        private JuliaSettingsPanel juliaSettingsPanel;
        private NewtonSettingsPanel newtonSettingsPanel1;
    }
}
