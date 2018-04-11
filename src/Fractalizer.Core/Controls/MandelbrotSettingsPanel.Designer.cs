namespace Fractalizer.Core.Controls
{
    partial class MandelbrotSettingsPanel
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
            this.lblXvalue = new MetroFramework.Controls.MetroLabel();
            this.txtBoxXvalue = new MetroFramework.Controls.MetroTextBox();
            this.lblYvalue = new MetroFramework.Controls.MetroLabel();
            this.txtBoxYvalue = new MetroFramework.Controls.MetroTextBox();
            this.lblXrange = new MetroFramework.Controls.MetroLabel();
            this.txtBoxXrange = new MetroFramework.Controls.MetroTextBox();
            this.lblYrange = new MetroFramework.Controls.MetroLabel();
            this.txtBoxYrange = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // lblXvalue
            // 
            this.lblXvalue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblXvalue.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblXvalue.Location = new System.Drawing.Point(3, 3);
            this.lblXvalue.Name = "lblXvalue";
            this.lblXvalue.Size = new System.Drawing.Size(100, 23);
            this.lblXvalue.TabIndex = 0;
            this.lblXvalue.Text = "X start value";
            this.lblXvalue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblXvalue.Click += new System.EventHandler(this.lblXvalue_Click);
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
            this.txtBoxXvalue.Lines = new string[] {
        "metroTextBox1"};
            this.txtBoxXvalue.Location = new System.Drawing.Point(109, 3);
            this.txtBoxXvalue.MaxLength = 32767;
            this.txtBoxXvalue.Name = "txtBoxXvalue";
            this.txtBoxXvalue.PasswordChar = '\0';
            this.txtBoxXvalue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxXvalue.SelectedText = "";
            this.txtBoxXvalue.SelectionLength = 0;
            this.txtBoxXvalue.SelectionStart = 0;
            this.txtBoxXvalue.ShortcutsEnabled = true;
            this.txtBoxXvalue.Size = new System.Drawing.Size(75, 23);
            this.txtBoxXvalue.TabIndex = 1;
            this.txtBoxXvalue.Text = "metroTextBox1";
            this.txtBoxXvalue.UseSelectable = true;
            this.txtBoxXvalue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxXvalue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblYvalue
            // 
            this.lblYvalue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYvalue.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblYvalue.Location = new System.Drawing.Point(205, 3);
            this.lblYvalue.Name = "lblYvalue";
            this.lblYvalue.Size = new System.Drawing.Size(100, 23);
            this.lblYvalue.TabIndex = 2;
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
            this.txtBoxYvalue.Lines = new string[] {
        "metroTextBox1"};
            this.txtBoxYvalue.Location = new System.Drawing.Point(311, 3);
            this.txtBoxYvalue.MaxLength = 32767;
            this.txtBoxYvalue.Name = "txtBoxYvalue";
            this.txtBoxYvalue.PasswordChar = '\0';
            this.txtBoxYvalue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxYvalue.SelectedText = "";
            this.txtBoxYvalue.SelectionLength = 0;
            this.txtBoxYvalue.SelectionStart = 0;
            this.txtBoxYvalue.ShortcutsEnabled = true;
            this.txtBoxYvalue.Size = new System.Drawing.Size(75, 23);
            this.txtBoxYvalue.TabIndex = 3;
            this.txtBoxYvalue.Text = "metroTextBox1";
            this.txtBoxYvalue.UseSelectable = true;
            this.txtBoxYvalue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxYvalue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblXrange
            // 
            this.lblXrange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblXrange.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblXrange.Location = new System.Drawing.Point(404, 3);
            this.lblXrange.Name = "lblXrange";
            this.lblXrange.Size = new System.Drawing.Size(100, 23);
            this.lblXrange.TabIndex = 4;
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
            this.txtBoxXrange.Lines = new string[] {
        "metroTextBox2"};
            this.txtBoxXrange.Location = new System.Drawing.Point(510, 3);
            this.txtBoxXrange.MaxLength = 32767;
            this.txtBoxXrange.Name = "txtBoxXrange";
            this.txtBoxXrange.PasswordChar = '\0';
            this.txtBoxXrange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxXrange.SelectedText = "";
            this.txtBoxXrange.SelectionLength = 0;
            this.txtBoxXrange.SelectionStart = 0;
            this.txtBoxXrange.ShortcutsEnabled = true;
            this.txtBoxXrange.Size = new System.Drawing.Size(75, 23);
            this.txtBoxXrange.TabIndex = 5;
            this.txtBoxXrange.Text = "metroTextBox2";
            this.txtBoxXrange.UseSelectable = true;
            this.txtBoxXrange.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxXrange.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblYrange
            // 
            this.lblYrange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYrange.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblYrange.Location = new System.Drawing.Point(607, 3);
            this.lblYrange.Name = "lblYrange";
            this.lblYrange.Size = new System.Drawing.Size(100, 23);
            this.lblYrange.TabIndex = 6;
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
            this.txtBoxYrange.Lines = new string[] {
        "metroTextBox3"};
            this.txtBoxYrange.Location = new System.Drawing.Point(713, 3);
            this.txtBoxYrange.MaxLength = 32767;
            this.txtBoxYrange.Name = "txtBoxYrange";
            this.txtBoxYrange.PasswordChar = '\0';
            this.txtBoxYrange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxYrange.SelectedText = "";
            this.txtBoxYrange.SelectionLength = 0;
            this.txtBoxYrange.SelectionStart = 0;
            this.txtBoxYrange.ShortcutsEnabled = true;
            this.txtBoxYrange.Size = new System.Drawing.Size(75, 23);
            this.txtBoxYrange.TabIndex = 7;
            this.txtBoxYrange.Text = "metroTextBox3";
            this.txtBoxYrange.UseSelectable = true;
            this.txtBoxYrange.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxYrange.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MandelbrotSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBoxYrange);
            this.Controls.Add(this.lblYrange);
            this.Controls.Add(this.txtBoxXrange);
            this.Controls.Add(this.lblXrange);
            this.Controls.Add(this.txtBoxYvalue);
            this.Controls.Add(this.lblYvalue);
            this.Controls.Add(this.txtBoxXvalue);
            this.Controls.Add(this.lblXvalue);
            this.Name = "MandelbrotSettingsPanel";
            this.Size = new System.Drawing.Size(823, 29);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblXvalue;
        private MetroFramework.Controls.MetroTextBox txtBoxXvalue;
        private MetroFramework.Controls.MetroLabel lblYvalue;
        private MetroFramework.Controls.MetroTextBox txtBoxYvalue;
        private MetroFramework.Controls.MetroLabel lblXrange;
        private MetroFramework.Controls.MetroTextBox txtBoxXrange;
        private MetroFramework.Controls.MetroLabel lblYrange;
        private MetroFramework.Controls.MetroTextBox txtBoxYrange;
    }
}
