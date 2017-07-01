namespace BuildingCalculator.FormComponents
{
    partial class RoomTabContent
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.worksTypeTree1 = new BuildingCalculator.FormComponents.WorksTypeTree();
            this.MarkUp = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TypeTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.MarkUp.SuspendLayout();
            this.TypeTabs.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.worksTypeTree1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MarkUp);
            this.splitContainer1.Size = new System.Drawing.Size(1021, 566);
            this.splitContainer1.SplitterDistance = 332;
            this.splitContainer1.TabIndex = 0;
            // 
            // worksTypeTree1
            // 
            this.worksTypeTree1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.worksTypeTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.worksTypeTree1.Location = new System.Drawing.Point(0, 0);
            this.worksTypeTree1.Name = "worksTypeTree1";
            this.worksTypeTree1.Padding = new System.Windows.Forms.Padding(3);
            this.worksTypeTree1.Size = new System.Drawing.Size(332, 566);
            this.worksTypeTree1.TabIndex = 0;
            // 
            // MarkUp
            // 
            this.MarkUp.ColumnCount = 2;
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 321F));
            this.MarkUp.Controls.Add(this.comboBox1, 1, 0);
            this.MarkUp.Controls.Add(this.label1, 0, 0);
            this.MarkUp.Controls.Add(this.TypeTabs, 0, 1);
            this.MarkUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarkUp.Location = new System.Drawing.Point(0, 0);
            this.MarkUp.Name = "MarkUp";
            this.MarkUp.RowCount = 4;
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MarkUp.Size = new System.Drawing.Size(685, 566);
            this.MarkUp.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(367, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип комнаты";
            // 
            // TypeTabs
            // 
            this.TypeTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.MarkUp.SetColumnSpan(this.TypeTabs, 2);
            this.TypeTabs.Controls.Add(this.tabPage1);
            this.TypeTabs.Controls.Add(this.tabPage2);
            this.TypeTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeTabs.Location = new System.Drawing.Point(3, 37);
            this.TypeTabs.Name = "TypeTabs";
            this.TypeTabs.SelectedIndex = 0;
            this.TypeTabs.Size = new System.Drawing.Size(679, 354);
            this.TypeTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TypeTabs.TabIndex = 2;
            this.TypeTabs.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(671, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(671, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RoomTabContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "RoomTabContent";
            this.Size = new System.Drawing.Size(1021, 566);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.MarkUp.ResumeLayout(false);
            this.MarkUp.PerformLayout();
            this.TypeTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public WorksTypeTree worksTypeTree1;
        private System.Windows.Forms.TableLayoutPanel MarkUp;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TypeTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
