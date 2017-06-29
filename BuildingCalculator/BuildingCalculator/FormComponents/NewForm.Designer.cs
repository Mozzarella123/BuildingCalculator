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
            this.MenuMarkup = new System.Windows.Forms.TableLayoutPanel();
            this.InputParamsBut = new System.Windows.Forms.Button();
            this.CheckWorksBut = new System.Windows.Forms.Button();
            this.ViewBut = new System.Windows.Forms.Button();
            this.SettingsBut = new System.Windows.Forms.Button();
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.InputParamsTab = new System.Windows.Forms.TabPage();
            this.CheckWorksTab = new System.Windows.Forms.TabPage();
            this.ViewTab = new System.Windows.Forms.TabPage();
            this.SettingTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.MenuMarkup.SuspendLayout();
            this.MainTabs.SuspendLayout();
            this.InputParamsTab.SuspendLayout();
            this.CheckWorksTab.SuspendLayout();
            this.ViewTab.SuspendLayout();
            this.SettingTab.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.MenuMarkup);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MainTabs);
            this.splitContainer1.Size = new System.Drawing.Size(962, 409);
            this.splitContainer1.SplitterDistance = 184;
            this.splitContainer1.TabIndex = 0;
            // 
            // MenuMarkup
            // 
            this.MenuMarkup.ColumnCount = 1;
            this.MenuMarkup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MenuMarkup.Controls.Add(this.InputParamsBut, 0, 0);
            this.MenuMarkup.Controls.Add(this.CheckWorksBut, 0, 1);
            this.MenuMarkup.Controls.Add(this.ViewBut, 0, 2);
            this.MenuMarkup.Controls.Add(this.SettingsBut, 0, 3);
            this.MenuMarkup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuMarkup.Location = new System.Drawing.Point(0, 0);
            this.MenuMarkup.Name = "MenuMarkup";
            this.MenuMarkup.RowCount = 5;
            this.MenuMarkup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MenuMarkup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MenuMarkup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MenuMarkup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MenuMarkup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.MenuMarkup.Size = new System.Drawing.Size(184, 409);
            this.MenuMarkup.TabIndex = 0;
            // 
            // InputParamsBut
            // 
            this.InputParamsBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputParamsBut.FlatAppearance.BorderSize = 0;
            this.InputParamsBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputParamsBut.Location = new System.Drawing.Point(0, 0);
            this.InputParamsBut.Margin = new System.Windows.Forms.Padding(0);
            this.InputParamsBut.Name = "InputParamsBut";
            this.InputParamsBut.Size = new System.Drawing.Size(184, 50);
            this.InputParamsBut.TabIndex = 0;
            this.InputParamsBut.Text = "Ввод данных";
            this.InputParamsBut.UseVisualStyleBackColor = true;
            this.InputParamsBut.Click += new System.EventHandler(this.MenuClick);
            // 
            // CheckWorksBut
            // 
            this.CheckWorksBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckWorksBut.FlatAppearance.BorderSize = 0;
            this.CheckWorksBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckWorksBut.Location = new System.Drawing.Point(0, 50);
            this.CheckWorksBut.Margin = new System.Windows.Forms.Padding(0);
            this.CheckWorksBut.Name = "CheckWorksBut";
            this.CheckWorksBut.Size = new System.Drawing.Size(184, 50);
            this.CheckWorksBut.TabIndex = 1;
            this.CheckWorksBut.Text = "Выбор работ";
            this.CheckWorksBut.UseVisualStyleBackColor = true;
            this.CheckWorksBut.Click += new System.EventHandler(this.MenuClick);
            // 
            // ViewBut
            // 
            this.ViewBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewBut.FlatAppearance.BorderSize = 0;
            this.ViewBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewBut.Location = new System.Drawing.Point(0, 100);
            this.ViewBut.Margin = new System.Windows.Forms.Padding(0);
            this.ViewBut.Name = "ViewBut";
            this.ViewBut.Size = new System.Drawing.Size(184, 50);
            this.ViewBut.TabIndex = 2;
            this.ViewBut.Text = "Просмотр";
            this.ViewBut.UseVisualStyleBackColor = true;
            this.ViewBut.Click += new System.EventHandler(this.MenuClick);
            // 
            // SettingsBut
            // 
            this.SettingsBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsBut.FlatAppearance.BorderSize = 0;
            this.SettingsBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBut.Location = new System.Drawing.Point(0, 150);
            this.SettingsBut.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsBut.Name = "SettingsBut";
            this.SettingsBut.Size = new System.Drawing.Size(184, 50);
            this.SettingsBut.TabIndex = 3;
            this.SettingsBut.Text = "Настройки";
            this.SettingsBut.UseVisualStyleBackColor = true;
            this.SettingsBut.Click += new System.EventHandler(this.MenuClick);
            // 
            // MainTabs
            // 
            this.MainTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.MainTabs.Controls.Add(this.InputParamsTab);
            this.MainTabs.Controls.Add(this.CheckWorksTab);
            this.MainTabs.Controls.Add(this.ViewTab);
            this.MainTabs.Controls.Add(this.SettingTab);
            this.MainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabs.Location = new System.Drawing.Point(0, 0);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(774, 409);
            this.MainTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTabs.TabIndex = 0;
            this.MainTabs.TabStop = false;
            // 
            // InputParamsTab
            // 
            this.InputParamsTab.AutoScroll = true;
            this.InputParamsTab.Controls.Add(this.label1);
            this.InputParamsTab.Location = new System.Drawing.Point(4, 32);
            this.InputParamsTab.Name = "InputParamsTab";
            this.InputParamsTab.Padding = new System.Windows.Forms.Padding(3);
            this.InputParamsTab.Size = new System.Drawing.Size(766, 373);
            this.InputParamsTab.TabIndex = 0;
            this.InputParamsTab.Text = "tabPage1";
            this.InputParamsTab.UseVisualStyleBackColor = true;
            // 
            // CheckWorksTab
            // 
            this.CheckWorksTab.AutoScroll = true;
            this.CheckWorksTab.Controls.Add(this.label2);
            this.CheckWorksTab.Location = new System.Drawing.Point(4, 32);
            this.CheckWorksTab.Name = "CheckWorksTab";
            this.CheckWorksTab.Padding = new System.Windows.Forms.Padding(3);
            this.CheckWorksTab.Size = new System.Drawing.Size(766, 373);
            this.CheckWorksTab.TabIndex = 1;
            this.CheckWorksTab.Text = "tabPage2";
            this.CheckWorksTab.UseVisualStyleBackColor = true;
            // 
            // ViewTab
            // 
            this.ViewTab.AutoScroll = true;
            this.ViewTab.Controls.Add(this.label3);
            this.ViewTab.Location = new System.Drawing.Point(4, 32);
            this.ViewTab.Name = "ViewTab";
            this.ViewTab.Size = new System.Drawing.Size(766, 373);
            this.ViewTab.TabIndex = 2;
            this.ViewTab.Text = "tabPage3";
            this.ViewTab.UseVisualStyleBackColor = true;
            // 
            // SettingTab
            // 
            this.SettingTab.AutoScroll = true;
            this.SettingTab.Controls.Add(this.label4);
            this.SettingTab.Location = new System.Drawing.Point(4, 32);
            this.SettingTab.Name = "SettingTab";
            this.SettingTab.Size = new System.Drawing.Size(766, 373);
            this.SettingTab.TabIndex = 3;
            this.SettingTab.Text = "tabPage4";
            this.SettingTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ввод данных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Выбор работ";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Настройки";
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 409);
            this.Controls.Add(this.splitContainer1);
            this.Name = "NewForm";
            this.Text = "NewForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.MenuMarkup.ResumeLayout(false);
            this.MainTabs.ResumeLayout(false);
            this.InputParamsTab.ResumeLayout(false);
            this.InputParamsTab.PerformLayout();
            this.CheckWorksTab.ResumeLayout(false);
            this.CheckWorksTab.PerformLayout();
            this.ViewTab.ResumeLayout(false);
            this.ViewTab.PerformLayout();
            this.SettingTab.ResumeLayout(false);
            this.SettingTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel MenuMarkup;
        private System.Windows.Forms.Button InputParamsBut;
        private System.Windows.Forms.Button CheckWorksBut;
        private System.Windows.Forms.Button ViewBut;
        private System.Windows.Forms.Button SettingsBut;
        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.TabPage InputParamsTab;
        private System.Windows.Forms.TabPage CheckWorksTab;
        private System.Windows.Forms.TabPage ViewTab;
        private System.Windows.Forms.TabPage SettingTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}