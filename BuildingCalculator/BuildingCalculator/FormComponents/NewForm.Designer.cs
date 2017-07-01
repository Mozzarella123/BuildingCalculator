namespace BuildingCalculator.FormComponents
{
    partial class NewForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.InputParamsTab = new System.Windows.Forms.TabPage();
            this.RoomTabs = new System.Windows.Forms.TabControl();
            this.FirstRoom = new System.Windows.Forms.TabPage();
            this.roomTabContent1 = new BuildingCalculator.FormComponents.RoomTabContent();
            this.AddRoomTab = new System.Windows.Forms.TabPage();
            this.ViewTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.SettingTab = new System.Windows.Forms.TabPage();
            this.worksTypeTree1 = new BuildingCalculator.FormComponents.WorksTypeTree();
            this.label4 = new System.Windows.Forms.Label();
            this.MenuMarkup = new System.Windows.Forms.TableLayoutPanel();
            this.InputParamsBut = new System.Windows.Forms.Button();
            this.ViewBut = new System.Windows.Forms.Button();
            this.SettingsBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.MainTabs.SuspendLayout();
            this.InputParamsTab.SuspendLayout();
            this.RoomTabs.SuspendLayout();
            this.FirstRoom.SuspendLayout();
            this.ViewTab.SuspendLayout();
            this.SettingTab.SuspendLayout();
            this.MenuMarkup.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MainTabs);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MenuMarkup);
            this.splitContainer1.Size = new System.Drawing.Size(962, 583);
            this.splitContainer1.SplitterDistance = 817;
            this.splitContainer1.TabIndex = 0;
            // 
            // MainTabs
            // 
            this.MainTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.MainTabs.Controls.Add(this.InputParamsTab);
            this.MainTabs.Controls.Add(this.ViewTab);
            this.MainTabs.Controls.Add(this.SettingTab);
            this.MainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabs.Location = new System.Drawing.Point(0, 0);
            this.MainTabs.Margin = new System.Windows.Forms.Padding(0);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(817, 583);
            this.MainTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTabs.TabIndex = 0;
            this.MainTabs.TabStop = false;
            // 
            // InputParamsTab
            // 
            this.InputParamsTab.AutoScroll = true;
            this.InputParamsTab.Controls.Add(this.RoomTabs);
            this.InputParamsTab.Location = new System.Drawing.Point(4, 32);
            this.InputParamsTab.Name = "InputParamsTab";
            this.InputParamsTab.Padding = new System.Windows.Forms.Padding(3);
            this.InputParamsTab.Size = new System.Drawing.Size(809, 547);
            this.InputParamsTab.TabIndex = 0;
            this.InputParamsTab.Text = "Ввод данных";
            this.InputParamsTab.UseVisualStyleBackColor = true;
            // 
            // RoomTabs
            // 
            this.RoomTabs.Controls.Add(this.FirstRoom);
            this.RoomTabs.Controls.Add(this.AddRoomTab);
            this.RoomTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomTabs.Location = new System.Drawing.Point(3, 3);
            this.RoomTabs.Margin = new System.Windows.Forms.Padding(0);
            this.RoomTabs.Name = "RoomTabs";
            this.RoomTabs.SelectedIndex = 0;
            this.RoomTabs.Size = new System.Drawing.Size(803, 541);
            this.RoomTabs.TabIndex = 0;
            this.RoomTabs.DoubleClick += new System.EventHandler(this.RoomTabs_DoubleClick);
            // 
            // FirstRoom
            // 
            this.FirstRoom.Controls.Add(this.roomTabContent1);
            this.FirstRoom.Location = new System.Drawing.Point(4, 29);
            this.FirstRoom.Name = "FirstRoom";
            this.FirstRoom.Padding = new System.Windows.Forms.Padding(3);
            this.FirstRoom.Size = new System.Drawing.Size(795, 508);
            this.FirstRoom.TabIndex = 0;
            this.FirstRoom.Text = "Комната";
            this.FirstRoom.UseVisualStyleBackColor = true;
            // 
            // roomTabContent1
            // 
            this.roomTabContent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomTabContent1.Location = new System.Drawing.Point(3, 3);
            this.roomTabContent1.Name = "roomTabContent1";
            this.roomTabContent1.Size = new System.Drawing.Size(789, 502);
            this.roomTabContent1.TabIndex = 0;
            // 
            // AddRoomTab
            // 
            this.AddRoomTab.Location = new System.Drawing.Point(4, 29);
            this.AddRoomTab.Name = "AddRoomTab";
            this.AddRoomTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddRoomTab.Size = new System.Drawing.Size(795, 508);
            this.AddRoomTab.TabIndex = 1;
            this.AddRoomTab.Text = "+";
            this.AddRoomTab.UseVisualStyleBackColor = true;
            // 
            // ViewTab
            // 
            this.ViewTab.AutoScroll = true;
            this.ViewTab.Controls.Add(this.label3);
            this.ViewTab.Location = new System.Drawing.Point(4, 32);
            this.ViewTab.Name = "ViewTab";
            this.ViewTab.Size = new System.Drawing.Size(809, 547);
            this.ViewTab.TabIndex = 2;
            this.ViewTab.Text = "Просмотр";
            this.ViewTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Просмотр";
            // 
            // SettingTab
            // 
            this.SettingTab.AutoScroll = true;
            this.SettingTab.Controls.Add(this.worksTypeTree1);
            this.SettingTab.Controls.Add(this.label4);
            this.SettingTab.Location = new System.Drawing.Point(4, 32);
            this.SettingTab.Name = "SettingTab";
            this.SettingTab.Size = new System.Drawing.Size(809, 547);
            this.SettingTab.TabIndex = 3;
            this.SettingTab.Text = "Настройки";
            this.SettingTab.UseVisualStyleBackColor = true;
            // 
            // worksTypeTree1
            // 
            this.worksTypeTree1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.worksTypeTree1.Location = new System.Drawing.Point(452, 18);
            this.worksTypeTree1.Name = "worksTypeTree1";
            this.worksTypeTree1.Padding = new System.Windows.Forms.Padding(3);
            this.worksTypeTree1.Size = new System.Drawing.Size(283, 427);
            this.worksTypeTree1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Настройки";
            // 
            // MenuMarkup
            // 
            this.MenuMarkup.ColumnCount = 1;
            this.MenuMarkup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MenuMarkup.Controls.Add(this.InputParamsBut, 0, 0);
            this.MenuMarkup.Controls.Add(this.ViewBut, 0, 1);
            this.MenuMarkup.Controls.Add(this.SettingsBut, 0, 2);
            this.MenuMarkup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuMarkup.Location = new System.Drawing.Point(0, 0);
            this.MenuMarkup.Name = "MenuMarkup";
            this.MenuMarkup.RowCount = 4;
            this.MenuMarkup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MenuMarkup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MenuMarkup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MenuMarkup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.MenuMarkup.Size = new System.Drawing.Size(141, 583);
            this.MenuMarkup.TabIndex = 0;
            // 
            // InputParamsBut
            // 
            this.InputParamsBut.BackColor = System.Drawing.Color.LightGray;
            this.InputParamsBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputParamsBut.FlatAppearance.BorderSize = 0;
            this.InputParamsBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputParamsBut.Location = new System.Drawing.Point(0, 0);
            this.InputParamsBut.Margin = new System.Windows.Forms.Padding(0);
            this.InputParamsBut.Name = "InputParamsBut";
            this.InputParamsBut.Size = new System.Drawing.Size(141, 50);
            this.InputParamsBut.TabIndex = 0;
            this.InputParamsBut.Text = "Ввод данных";
            this.InputParamsBut.UseVisualStyleBackColor = false;
            this.InputParamsBut.Click += new System.EventHandler(this.MenuClick);
            // 
            // ViewBut
            // 
            this.ViewBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewBut.FlatAppearance.BorderSize = 0;
            this.ViewBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewBut.Location = new System.Drawing.Point(0, 50);
            this.ViewBut.Margin = new System.Windows.Forms.Padding(0);
            this.ViewBut.Name = "ViewBut";
            this.ViewBut.Size = new System.Drawing.Size(141, 50);
            this.ViewBut.TabIndex = 1;
            this.ViewBut.Text = "Просмотр";
            this.ViewBut.UseVisualStyleBackColor = true;
            this.ViewBut.Click += new System.EventHandler(this.MenuClick);
            // 
            // SettingsBut
            // 
            this.SettingsBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsBut.FlatAppearance.BorderSize = 0;
            this.SettingsBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBut.Location = new System.Drawing.Point(0, 100);
            this.SettingsBut.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsBut.Name = "SettingsBut";
            this.SettingsBut.Size = new System.Drawing.Size(141, 50);
            this.SettingsBut.TabIndex = 2;
            this.SettingsBut.Text = "Настройки";
            this.SettingsBut.UseVisualStyleBackColor = true;
            this.SettingsBut.Click += new System.EventHandler(this.MenuClick);
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 583);
            this.Controls.Add(this.splitContainer1);
            this.Name = "NewForm";
            this.Text = "NewForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.MainTabs.ResumeLayout(false);
            this.InputParamsTab.ResumeLayout(false);
            this.RoomTabs.ResumeLayout(false);
            this.FirstRoom.ResumeLayout(false);
            this.ViewTab.ResumeLayout(false);
            this.ViewTab.PerformLayout();
            this.SettingTab.ResumeLayout(false);
            this.SettingTab.PerformLayout();
            this.MenuMarkup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel MenuMarkup;
        private System.Windows.Forms.Button InputParamsBut;
        private System.Windows.Forms.Button ViewBut;
        private System.Windows.Forms.Button SettingsBut;
        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.TabPage InputParamsTab;
        private System.Windows.Forms.TabControl RoomTabs;
        private System.Windows.Forms.TabPage FirstRoom;
        private System.Windows.Forms.TabPage AddRoomTab;
        private System.Windows.Forms.TabPage ViewTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage SettingTab;
        private System.Windows.Forms.Label label4;
        private RoomTabContent roomTabContent1;
        private WorksTypeTree worksTypeTree1;
    }
}