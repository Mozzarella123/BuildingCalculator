namespace BuildingCalculator.FormComponents
{
    partial class SelectDoorsWindows
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Doors = new System.Windows.Forms.TabPage();
            this.Windows = new System.Windows.Forms.TabPage();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Doors.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Doors);
            this.tabControl1.Controls.Add(this.Windows);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(819, 589);
            this.tabControl1.TabIndex = 0;
            // 
            // Doors
            // 
            this.Doors.Controls.Add(this.label1);
            this.Doors.Controls.Add(this.radioButton1);
            this.Doors.Location = new System.Drawing.Point(4, 29);
            this.Doors.Name = "Doors";
            this.Doors.Padding = new System.Windows.Forms.Padding(3);
            this.Doors.Size = new System.Drawing.Size(811, 556);
            this.Doors.TabIndex = 0;
            this.Doors.Text = "Двери";
            this.Doors.UseVisualStyleBackColor = true;
            // 
            // Windows
            // 
            this.Windows.Location = new System.Drawing.Point(4, 29);
            this.Windows.Name = "Windows";
            this.Windows.Padding = new System.Windows.Forms.Padding(3);
            this.Windows.Size = new System.Drawing.Size(811, 556);
            this.Windows.TabIndex = 1;
            this.Windows.Text = "Окна";
            this.Windows.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "200x300";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Шаблон 1";
            // 
            // SelectDoorsWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 589);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SelectDoorsWindows";
            this.Text = "SelectDoorsWindows";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectDoorsWindows_FormClosing);
            this.Load += new System.EventHandler(this.SelectDoorsWindows_Load);
            this.tabControl1.ResumeLayout(false);
            this.Doors.ResumeLayout(false);
            this.Doors.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Doors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TabPage Windows;
    }
}