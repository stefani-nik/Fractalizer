namespace Fractalizer.Core.Controls
{
    partial class NewtonSettingsPanel
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
            this.lblChooseEquation = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // lblChooseEquation
            // 
            this.lblChooseEquation.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblChooseEquation.Location = new System.Drawing.Point(0, 0);
            this.lblChooseEquation.Name = "lblChooseEquation";
            this.lblChooseEquation.Size = new System.Drawing.Size(137, 29);
            this.lblChooseEquation.TabIndex = 2;
            this.lblChooseEquation.Text = "Choose equation";
            this.lblChooseEquation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(143, 0);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(136, 29);
            this.metroComboBox1.TabIndex = 3;
            this.metroComboBox1.UseSelectable = true;
            // 
            // NewtonSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.lblChooseEquation);
            this.Name = "NewtonSettingsPanel";
            this.Size = new System.Drawing.Size(282, 29);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblChooseEquation;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
    }
}
