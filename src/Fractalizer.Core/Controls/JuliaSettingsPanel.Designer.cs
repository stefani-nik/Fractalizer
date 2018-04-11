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
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.lblChooseComplex = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(185, 3);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(136, 29);
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.UseSelectable = true;
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
            this.Controls.Add(this.metroComboBox1);
            this.Name = "JuliaSettingsPanel";
            this.Size = new System.Drawing.Size(327, 36);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel lblChooseComplex;
    }
}
