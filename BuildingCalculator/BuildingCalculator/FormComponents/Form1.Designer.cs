﻿namespace BuildingCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.опцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.админкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomTabs = new System.Windows.Forms.TabControl();
            this.FirstRoom = new System.Windows.Forms.TabPage();
            this.tabContent1 = new BuildingCalculator.TabContent();
            this.AddRoom = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.RoomTabs.SuspendLayout();
            this.FirstRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опцииToolStripMenuItem,
            this.рассчитатьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 37);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // опцииToolStripMenuItem
            // 
            this.опцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.админкаToolStripMenuItem});
            this.опцииToolStripMenuItem.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            this.опцииToolStripMenuItem.Size = new System.Drawing.Size(94, 33);
            this.опцииToolStripMenuItem.Text = "Опции";
            // 
            // админкаToolStripMenuItem
            // 
            this.админкаToolStripMenuItem.Name = "админкаToolStripMenuItem";
            this.админкаToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.админкаToolStripMenuItem.Text = "Админка";
            this.админкаToolStripMenuItem.Click += new System.EventHandler(this.админкаToolStripMenuItem_Click);
            // 
            // рассчитатьToolStripMenuItem
            // 
            this.рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
            this.рассчитатьToolStripMenuItem.Size = new System.Drawing.Size(151, 33);
            this.рассчитатьToolStripMenuItem.Text = "Рассчитать";
            this.рассчитатьToolStripMenuItem.Click += new System.EventHandler(this.Calculate);
            // 
            // RoomTabs
            // 
            this.RoomTabs.Controls.Add(this.FirstRoom);
            this.RoomTabs.Controls.Add(this.AddRoom);
            this.RoomTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomTabs.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomTabs.Location = new System.Drawing.Point(0, 37);
            this.RoomTabs.Name = "RoomTabs";
            this.RoomTabs.SelectedIndex = 0;
            this.RoomTabs.Size = new System.Drawing.Size(669, 467);
            this.RoomTabs.TabIndex = 34;
            this.RoomTabs.TabStop = false;
            this.RoomTabs.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.RoomTabs_Selecting);
            this.RoomTabs.DoubleClick += new System.EventHandler(this.RoomTabs_DoubleClick);
            // 
            // FirstRoom
            // 
            this.FirstRoom.Controls.Add(this.tabContent1);
            this.FirstRoom.Location = new System.Drawing.Point(4, 38);
            this.FirstRoom.Name = "FirstRoom";
            this.FirstRoom.Padding = new System.Windows.Forms.Padding(3);
            this.FirstRoom.Size = new System.Drawing.Size(661, 425);
            this.FirstRoom.TabIndex = 0;
            this.FirstRoom.Text = "Комната";
            this.FirstRoom.UseVisualStyleBackColor = true;
            // 
            // tabContent1
            // 
            this.tabContent1.BackColor = System.Drawing.SystemColors.Window;
            this.tabContent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContent1.Font = new System.Drawing.Font("Roboto Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabContent1.Location = new System.Drawing.Point(3, 3);
            this.tabContent1.Name = "tabContent1";
            this.tabContent1.Size = new System.Drawing.Size(655, 419);
            this.tabContent1.TabIndex = 0;
            // 
            // AddRoom
            // 
            this.AddRoom.Location = new System.Drawing.Point(4, 38);
            this.AddRoom.Name = "AddRoom";
            this.AddRoom.Size = new System.Drawing.Size(661, 425);
            this.AddRoom.TabIndex = 1;
            this.AddRoom.Text = "+";
            this.AddRoom.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 504);
            this.Controls.Add(this.RoomTabs);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.RoomTabs.ResumeLayout(false);
            this.FirstRoom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem опцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem админкаToolStripMenuItem;
        private System.Windows.Forms.TabControl RoomTabs;
        private System.Windows.Forms.TabPage FirstRoom;
        private System.Windows.Forms.TabPage AddRoom;
        private TabContent tabContent1;
        private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem;
    }
}

