namespace Fractalizer.Core.Controls
{
    partial class JuliaSettingsPanel
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
            this.juliaComplexNumberComboBox = new MetroFramework.Controls.MetroComboBox();
            this.lblChooseComplex = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // juliaComplexNumberComboBox
            // 
            this.juliaComplexNumberComboBox.FormattingEnabled = true;
            this.juliaComplexNumberComboBox.ItemHeight = 23;
            this.juliaComplexNumberComboBox.Items.AddRange(new object[] {
            "0.4+0.6i",
            "0.285+0i",
            "0.285+0.01i",
            "0.45+0.1428i",
            "-0.70176+(-0.3842i)",
            "-0.835+(-0.2321i)",
            "-0.8+0.156i",
            "-0.7269+0.1889i",
            "0+(-0.8i)"});
            this.juliaComplexNumberComboBox.Location = new System.Drawing.Point(185, 3);
            this.juliaComplexNumberComboBox.Name = "juliaComplexNumberComboBox";
            this.juliaComplexNumberComboBox.Size = new System.Drawing.Size(136, 29);
            this.juliaComplexNumberComboBox.TabIndex = 0;
            this.juliaComplexNumberComboBox.UseSelectable = true;
            this.juliaComplexNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.juliaComplexNumberComboBox_SelectedIndexChanged);
            this.juliaComplexNumberComboBox.SelectedIndex = 0;
            // 
            // lblChooseComplex
            // 
            this.lblChooseComplex.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblChooseComplex.Location = new System.Drawing.Point(3, 3);
            this.lblChooseComplex.Name = "lblChooseComplex";
            this.lblChooseComplex.Size = new System.Drawing.Size(176, 29);
            this.lblChooseComplex.TabIndex = 1;
            this.lblChooseComplex.Text = "Choose complex number";
            this.lblChooseComplex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JuliaSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblChooseComplex);
            this.Controls.Add(this.juliaComplexNumberComboBox);
            this.Name = "JuliaSettingsPanel";
            this.Size = new System.Drawing.Size(327, 36);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox juliaComplexNumberComboBox;
        private MetroFramework.Controls.MetroLabel lblChooseComplex;
    }
}
