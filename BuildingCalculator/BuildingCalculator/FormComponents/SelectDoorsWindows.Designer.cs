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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выбратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Doors);
            this.tabControl1.Controls.Add(this.Windows);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(819, 556);
            this.tabControl1.TabIndex = 0;
            // 
            // Doors
            // 
            this.Doors.AutoScroll = true;
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
            this.Windows.Size = new System.Drawing.Size(811, 523);
            this.Windows.TabIndex = 1;
            this.Windows.Text = "Окна";
            this.Windows.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выбратьToolStripMenuItem
            // 
            this.выбратьToolStripMenuItem.Name = "выбратьToolStripMenuItem";
            this.выбратьToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.выбратьToolStripMenuItem.Text = "Выбрать";
            this.выбратьToolStripMenuItem.Click += new System.EventHandler(this.выбратьToolStripMenuItem_Click);
            // 
            // SelectDoorsWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 589);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SelectDoorsWindows";
            this.Text = "SelectDoorsWindows";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectDoorsWindows_FormClosing);
            this.Load += new System.EventHandler(this.SelectDoorsWindows_Load);
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage Doors;
        private System.Windows.Forms.TabPage Windows;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выбратьToolStripMenuItem;
        public System.Windows.Forms.TabControl tabControl1;
    }
}