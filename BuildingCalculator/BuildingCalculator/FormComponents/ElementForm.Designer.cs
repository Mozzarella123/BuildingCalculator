namespace BuildingCalculator.FormComponents
{
    partial class ElementForm
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
            this.Title = new System.Windows.Forms.Label();
            this.ContInp = new System.Windows.Forms.TextBox();
            this.WidthInp = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.Label();
            this.Param1T = new System.Windows.Forms.Label();
            this.PatternT = new System.Windows.Forms.Label();
            this.MarkUp = new System.Windows.Forms.TableLayoutPanel();
            this.PatternSelect = new System.Windows.Forms.ComboBox();
            this.Param2T = new System.Windows.Forms.Label();
            this.HeightInp = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.MarkUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(3, 35);
            this.Title.Margin = new System.Windows.Forms.Padding(3);
            this.Title.Name = "Title";
            this.MarkUp.SetRowSpan(this.Title, 2);
            this.Title.Size = new System.Drawing.Size(194, 29);
            this.Title.TabIndex = 0;
            this.Title.Text = "Название";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContInp
            // 
            this.ContInp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ContInp.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContInp.Location = new System.Drawing.Point(309, 4);
            this.ContInp.MaxLength = 5;
            this.ContInp.Multiline = true;
            this.ContInp.Name = "ContInp";
            this.ContInp.Size = new System.Drawing.Size(81, 41);
            this.ContInp.TabIndex = 1;
            this.ContInp.TextChanged += new System.EventHandler(this.ContInp_TextChanged);
            // 
            // WidthInp
            // 
            this.WidthInp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WidthInp.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthInp.Location = new System.Drawing.Point(309, 53);
            this.WidthInp.MaxLength = 5;
            this.WidthInp.Multiline = true;
            this.WidthInp.Name = "WidthInp";
            this.WidthInp.Size = new System.Drawing.Size(81, 41);
            this.WidthInp.TabIndex = 2;
            this.WidthInp.TextChanged += new System.EventHandler(this.WidthInp_TextChanged);
            // 
            // Count
            // 
            this.Count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Count.AutoSize = true;
            this.Count.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count.Location = new System.Drawing.Point(203, 10);
            this.Count.Margin = new System.Windows.Forms.Padding(3);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(100, 29);
            this.Count.TabIndex = 3;
            this.Count.Text = "Кол-во";
            this.Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Param1T
            // 
            this.Param1T.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Param1T.AutoSize = true;
            this.Param1T.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Param1T.Location = new System.Drawing.Point(203, 59);
            this.Param1T.Margin = new System.Windows.Forms.Padding(3);
            this.Param1T.Name = "Param1T";
            this.Param1T.Size = new System.Drawing.Size(100, 29);
            this.Param1T.TabIndex = 4;
            this.Param1T.Text = "Ширина";
            this.Param1T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatternT
            // 
            this.PatternT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PatternT.AutoSize = true;
            this.PatternT.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatternT.Location = new System.Drawing.Point(396, 10);
            this.PatternT.Margin = new System.Windows.Forms.Padding(3);
            this.PatternT.Name = "PatternT";
            this.PatternT.Size = new System.Drawing.Size(101, 29);
            this.PatternT.TabIndex = 5;
            this.PatternT.Text = "Шаблон";
            this.PatternT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MarkUp
            // 
            this.MarkUp.ColumnCount = 6;
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MarkUp.Controls.Add(this.Title, 0, 0);
            this.MarkUp.Controls.Add(this.Count, 1, 0);
            this.MarkUp.Controls.Add(this.PatternSelect, 4, 0);
            this.MarkUp.Controls.Add(this.WidthInp, 2, 1);
            this.MarkUp.Controls.Add(this.ContInp, 2, 0);
            this.MarkUp.Controls.Add(this.PatternT, 3, 0);
            this.MarkUp.Controls.Add(this.Param1T, 1, 1);
            this.MarkUp.Controls.Add(this.Param2T, 3, 1);
            this.MarkUp.Controls.Add(this.HeightInp, 4, 1);
            this.MarkUp.Controls.Add(this.Delete, 5, 0);
            this.MarkUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarkUp.Location = new System.Drawing.Point(10, 10);
            this.MarkUp.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.MarkUp.Name = "MarkUp";
            this.MarkUp.RowCount = 2;
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MarkUp.Size = new System.Drawing.Size(884, 99);
            this.MarkUp.TabIndex = 9;
            // 
            // PatternSelect
            // 
            this.PatternSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PatternSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PatternSelect.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatternSelect.FormattingEnabled = true;
            this.PatternSelect.Items.AddRange(new object[] {
            "Сменить тип ",
            "Окно ",
            "Дверь"});
            this.PatternSelect.Location = new System.Drawing.Point(503, 6);
            this.PatternSelect.MaxLength = 5;
            this.PatternSelect.Name = "PatternSelect";
            this.PatternSelect.Size = new System.Drawing.Size(201, 37);
            this.PatternSelect.TabIndex = 7;
            this.PatternSelect.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // Param2T
            // 
            this.Param2T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Param2T.AutoSize = true;
            this.Param2T.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Param2T.Location = new System.Drawing.Point(396, 59);
            this.Param2T.Margin = new System.Windows.Forms.Padding(3);
            this.Param2T.Name = "Param2T";
            this.Param2T.Size = new System.Drawing.Size(101, 29);
            this.Param2T.TabIndex = 6;
            this.Param2T.Text = "Высота";
            this.Param2T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightInp
            // 
            this.HeightInp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HeightInp.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightInp.Location = new System.Drawing.Point(503, 53);
            this.HeightInp.MaxLength = 5;
            this.HeightInp.Multiline = true;
            this.HeightInp.Name = "HeightInp";
            this.HeightInp.Size = new System.Drawing.Size(117, 41);
            this.HeightInp.TabIndex = 8;
            this.HeightInp.TextChanged += new System.EventHandler(this.WidthInp_TextChanged);
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Delete.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(712, 23);
            this.Delete.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.Delete.Name = "Delete";
            this.MarkUp.SetRowSpan(this.Delete, 2);
            this.Delete.Size = new System.Drawing.Size(138, 52);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // ElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.MarkUp);
            this.Name = "ElementForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(904, 119);
            this.MarkUp.ResumeLayout(false);
            this.MarkUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label PatternT;
        private System.Windows.Forms.TableLayoutPanel MarkUp;
        public System.Windows.Forms.Label Title;
        public System.Windows.Forms.TextBox ContInp;
        public System.Windows.Forms.TextBox WidthInp;
        public System.Windows.Forms.Label Param1T;
        public System.Windows.Forms.ComboBox PatternSelect;
        private System.Windows.Forms.Button Delete;
        public System.Windows.Forms.Label Param2T;
        public System.Windows.Forms.TextBox HeightInp;
    }
}
