namespace BuildingCalculator.FormComponents
{
    partial class TipForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TipText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TipText
            // 
            this.TipText.AutoSize = true;
            this.TipText.Location = new System.Drawing.Point(12, 19);
            this.TipText.MaximumSize = new System.Drawing.Size(140, 0);
            this.TipText.Name = "TipText";
            this.TipText.Size = new System.Drawing.Size(0, 13);
            this.TipText.TabIndex = 0;
            this.TipText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 430);
            this.ControlBox = false;
            this.Controls.Add(this.TipText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TipForm";
            this.ShowInTaskbar = false;
            this.Text = "Подсказка";
            this.Load += new System.EventHandler(this.TipForm_Load);
            this.MouseEnter += new System.EventHandler(this.TipForm_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TipText;
    }
}