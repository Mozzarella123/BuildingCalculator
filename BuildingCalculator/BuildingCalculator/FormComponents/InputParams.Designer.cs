namespace BuildingCalculator.FormComponents
{
    partial class inputparams
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
            this.Paramname = new System.Windows.Forms.Label();
            this.ParamInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Paramname
            // 
            this.Paramname.AutoSize = true;
            this.Paramname.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Paramname.Location = new System.Drawing.Point(12, 9);
            this.Paramname.Name = "Paramname";
            this.Paramname.Size = new System.Drawing.Size(102, 29);
            this.Paramname.TabIndex = 0;
            this.Paramname.Text = "Введите";
            // 
            // ParamInput
            // 
            this.ParamInput.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParamInput.Location = new System.Drawing.Point(12, 41);
            this.ParamInput.Multiline = true;
            this.ParamInput.Name = "ParamInput";
            this.ParamInput.Size = new System.Drawing.Size(254, 42);
            this.ParamInput.TabIndex = 1;
            this.ParamInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ParamInput_KeyDown);
            // 
            // inputparams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 105);
            this.Controls.Add(this.ParamInput);
            this.Controls.Add(this.Paramname);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "inputparams";
            this.Text = "Ввод параметров";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.inputparams_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Paramname;
        private System.Windows.Forms.TextBox ParamInput;
    }
}