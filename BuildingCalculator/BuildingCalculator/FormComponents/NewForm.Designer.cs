﻿namespace BuildingCalculator.FormComponents
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.InputParamsTab = new System.Windows.Forms.TabPage();
            this.RoomTabs = new System.Windows.Forms.TabControl();
            this.FirstRoom = new System.Windows.Forms.TabPage();
            this.roomTabContent1 = new BuildingCalculator.FormComponents.RoomTabContent();
            this.AddRoomTab = new System.Windows.Forms.TabPage();
            this.ViewTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.SettingTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.worksTypeTree1 = new BuildingCalculator.FormComponents.WorksTypeTree();
            this.MenuMarkup = new System.Windows.Forms.TableLayoutPanel();
            this.InputParamsBut = new System.Windows.Forms.Button();
            this.ViewBut = new System.Windows.Forms.Button();
            this.SettingsBut = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.MainTabs.SuspendLayout();
            this.InputParamsTab.SuspendLayout();
            this.RoomTabs.SuspendLayout();
            this.FirstRoom.SuspendLayout();
            this.ViewTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SettingTab.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(1077, 583);
            this.splitContainer1.SplitterDistance = 914;
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
            this.MainTabs.Size = new System.Drawing.Size(914, 583);
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
            this.InputParamsTab.Size = new System.Drawing.Size(906, 547);
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
            this.RoomTabs.Size = new System.Drawing.Size(900, 541);
            this.RoomTabs.TabIndex = 0;
            this.RoomTabs.SelectedIndexChanged += new System.EventHandler(this.RoomTabs_SelectedIndexChanged);
            this.RoomTabs.DoubleClick += new System.EventHandler(this.RoomTabs_DoubleClick);
            // 
            // FirstRoom
            // 
            this.FirstRoom.Controls.Add(this.roomTabContent1);
            this.FirstRoom.Location = new System.Drawing.Point(4, 29);
            this.FirstRoom.Name = "FirstRoom";
            this.FirstRoom.Padding = new System.Windows.Forms.Padding(3);
            this.FirstRoom.Size = new System.Drawing.Size(892, 508);
            this.FirstRoom.TabIndex = 0;
            this.FirstRoom.Text = "Комната";
            this.FirstRoom.UseVisualStyleBackColor = true;
            // 
            // roomTabContent1
            // 
            this.roomTabContent1.AutoScroll = true;
            this.roomTabContent1.BackColor = System.Drawing.SystemColors.Window;
            this.roomTabContent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomTabContent1.Location = new System.Drawing.Point(3, 3);
            this.roomTabContent1.Name = "roomTabContent1";
            this.roomTabContent1.Size = new System.Drawing.Size(886, 502);
            this.roomTabContent1.TabIndex = 0;
            // 
            // AddRoomTab
            // 
            this.AddRoomTab.Location = new System.Drawing.Point(4, 29);
            this.AddRoomTab.Name = "AddRoomTab";
            this.AddRoomTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddRoomTab.Size = new System.Drawing.Size(892, 508);
            this.AddRoomTab.TabIndex = 1;
            this.AddRoomTab.Text = "+";
            this.AddRoomTab.UseVisualStyleBackColor = true;
            // 
            // ViewTab
            // 
            this.ViewTab.AutoScroll = true;
            this.ViewTab.Controls.Add(this.dataGridView1);
            this.ViewTab.Controls.Add(this.label3);
            this.ViewTab.Location = new System.Drawing.Point(4, 32);
            this.ViewTab.Name = "ViewTab";
            this.ViewTab.Size = new System.Drawing.Size(906, 547);
            this.ViewTab.TabIndex = 2;
            this.ViewTab.Text = "Просмотр";
            this.ViewTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Count,
            this.Price,
            this.Summ});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(906, 547);
            this.dataGridView1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Просмотр";
            // 
            // SettingTab
            // 
            this.SettingTab.AutoScroll = true;
            this.SettingTab.Controls.Add(this.button1);
            this.SettingTab.Controls.Add(this.textBox1);
            this.SettingTab.Controls.Add(this.label2);
            this.SettingTab.Controls.Add(this.panel1);
            this.SettingTab.Controls.Add(this.label1);
            this.SettingTab.Controls.Add(this.checkBox1);
            this.SettingTab.Controls.Add(this.worksTypeTree1);
            this.SettingTab.Location = new System.Drawing.Point(4, 32);
            this.SettingTab.Name = "SettingTab";
            this.SettingTab.Size = new System.Drawing.Size(906, 547);
            this.SettingTab.TabIndex = 3;
            this.SettingTab.Text = "Настройки";
            this.SettingTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(234, 195);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Изменить";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 196);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(206, 36);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Место сохранения отчёта";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(13, 88);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 71);
            this.panel1.TabIndex = 5;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 37);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(113, 33);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Метры";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 5);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(176, 33);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Сантиметры";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Единицы измерения";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(12, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(337, 33);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Включить режим обучения";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // worksTypeTree1
            // 
            this.worksTypeTree1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.worksTypeTree1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.worksTypeTree1.Location = new System.Drawing.Point(620, 3);
            this.worksTypeTree1.Name = "worksTypeTree1";
            this.worksTypeTree1.Padding = new System.Windows.Forms.Padding(3);
            this.worksTypeTree1.Size = new System.Drawing.Size(283, 400);
            this.worksTypeTree1.TabIndex = 1;
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
            this.MenuMarkup.Size = new System.Drawing.Size(159, 583);
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
            this.InputParamsBut.Size = new System.Drawing.Size(159, 50);
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
            this.ViewBut.Size = new System.Drawing.Size(159, 50);
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
            this.SettingsBut.Size = new System.Drawing.Size(159, 50);
            this.SettingsBut.TabIndex = 2;
            this.SettingsBut.Text = "Настройки";
            this.SettingsBut.UseVisualStyleBackColor = true;
            this.SettingsBut.Click += new System.EventHandler(this.MenuClick);
            // 
            // Title
            // 
            this.Title.HeaderText = "Наименование";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.HeaderText = "Кол-во";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Summ
            // 
            this.Summ.HeaderText = "Сумма";
            this.Summ.Name = "Summ";
            this.Summ.ReadOnly = true;
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 583);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.SettingTab.ResumeLayout(false);
            this.SettingTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private RoomTabContent roomTabContent1;
        private WorksTypeTree worksTypeTree1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summ;
    }
}