using System.Drawing;

namespace Fractalizer.Core.Controls
{
    partial class ColorsPanel
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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnShowColor = new System.Windows.Forms.Button();
            this.colorfulCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // colorDialog
            // 
            this.colorDialog.Color = System.Drawing.Color.Red;
            this.colorDialog.FullOpen = true;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.White;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnColor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnColor.Location = new System.Drawing.Point(3, 3);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(98, 29);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnShowColor
            // 
            this.btnShowColor.BackColor = System.Drawing.Color.Red;
            this.btnShowColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowColor.Enabled = false;
            this.btnShowColor.Location = new System.Drawing.Point(117, 4);
            this.btnShowColor.Name = "btnShowColor";
            this.btnShowColor.Size = new System.Drawing.Size(35, 28);
            this.btnShowColor.TabIndex = 1;
            this.btnShowColor.UseVisualStyleBackColor = false;
            // 
            // colorfulCheckBox
            // 
            this.colorfulCheckBox.AutoSize = true;
            this.colorfulCheckBox.Location = new System.Drawing.Point(170, 10);
            this.colorfulCheckBox.Name = "colorfulCheckBox";
            this.colorfulCheckBox.Size = new System.Drawing.Size(94, 15);
            this.colorfulCheckBox.TabIndex = 2;
            this.colorfulCheckBox.Text = "Draw colorful";
            this.colorfulCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.colorfulCheckBox.UseSelectable = true;
            this.colorfulCheckBox.CheckStateChanged += new System.EventHandler(this.colorfulCheckBox_CheckStateChanged);
            // 
            // ColorsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.colorfulCheckBox);
            this.Controls.Add(this.btnShowColor);
            this.Controls.Add(this.btnColor);
            this.Name = "ColorsPanel";
            this.Size = new System.Drawing.Size(267, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnShowColor;
        private MetroFramework.Controls.MetroCheckBox colorfulCheckBox;
    }
}
