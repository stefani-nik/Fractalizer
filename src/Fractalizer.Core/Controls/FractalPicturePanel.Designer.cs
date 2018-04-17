﻿using System.Windows.Forms;
using Fractalizer.Common;

namespace Fractalizer.Core.Controls
{
    partial class FractalPicturePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FractalPicturePanel));
            this.fractalImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fractalImg)).BeginInit();
            this.SuspendLayout();
            // 
            // fractalImg
            // 
            this.fractalImg.BackColor = System.Drawing.Color.Transparent;
            this.fractalImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fractalImg.BackgroundImage")));
            this.fractalImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fractalImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fractalImg.Location = new System.Drawing.Point(-1, -1);
            this.fractalImg.Name = "fractalImg";
            this.fractalImg.Size = new System.Drawing.Size(1000, 450);
            this.fractalImg.TabIndex = 0;
            this.fractalImg.TabStop = false;
            // 
            // FractalPicturePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.fractalImg);
            this.Location = new System.Drawing.Point(150, 220);
            this.Name = "FractalPicturePanel";
            this.Size = new System.Drawing.Size(998, 448);
            ((System.ComponentModel.ISupportInitialize)(this.fractalImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox fractalImg;
    }
}
