namespace Fractalizer.Core.Controls
{
    partial class StatusPanel
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
            this.renderingProgressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.lblRendering = new MetroFramework.Controls.MetroLabel();
            this.lblRenderingTime = new MetroFramework.Controls.MetroLabel();
            this.lblTime = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // renderingProgressSpinner
            // 
            this.renderingProgressSpinner.Location = new System.Drawing.Point(116, 3);
            this.renderingProgressSpinner.Maximum = 100;
            this.renderingProgressSpinner.Name = "renderingProgressSpinner";
            this.renderingProgressSpinner.Size = new System.Drawing.Size(116, 26);
            this.renderingProgressSpinner.TabIndex = 0;
            this.renderingProgressSpinner.UseSelectable = true;
            // 
            // lblRendering
            // 
            this.lblRendering.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblRendering.Location = new System.Drawing.Point(0, 3);
            this.lblRendering.Name = "lblRendering";
            this.lblRendering.Size = new System.Drawing.Size(110, 26);
            this.lblRendering.TabIndex = 1;
            this.lblRendering.Text = "Rendering..";
            this.lblRendering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRenderingTime
            // 
            this.lblRenderingTime.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblRenderingTime.Location = new System.Drawing.Point(238, 3);
            this.lblRenderingTime.Name = "lblRenderingTime";
            this.lblRenderingTime.Size = new System.Drawing.Size(121, 26);
            this.lblRenderingTime.TabIndex = 2;
            this.lblRenderingTime.Text = "Rendering Time";
            this.lblRenderingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTime.Location = new System.Drawing.Point(365, 3);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(81, 26);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblRenderingTime);
            this.Controls.Add(this.lblRendering);
            this.Controls.Add(this.renderingProgressSpinner);
            this.Name = "StatusPanel";
            this.Size = new System.Drawing.Size(450, 30);
            this.Location = new System.Drawing.Point(0, 670);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner renderingProgressSpinner;
        private MetroFramework.Controls.MetroLabel lblRendering;
        private MetroFramework.Controls.MetroLabel lblRenderingTime;
        private MetroFramework.Controls.MetroLabel lblTime;
    }
}
