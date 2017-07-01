namespace BuildingCalculator.Classes
{
    partial class Element
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
            this.Param1Inp = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.Label();
            this.Param1T = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Param2T = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.MarkUp = new System.Windows.Forms.TableLayoutPanel();
            this.Area = new System.Windows.Forms.Label();
            this.AreaInp = new System.Windows.Forms.TextBox();
            this.MarkUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(3, 3);
            this.Title.Margin = new System.Windows.Forms.Padding(3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(119, 41);
            this.Title.TabIndex = 0;
            this.Title.Text = "Название";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContInp
            // 
            this.ContInp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ContInp.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContInp.Location = new System.Drawing.Point(222, 3);
            this.ContInp.MaxLength = 5;
            this.ContInp.Multiline = true;
            this.ContInp.Name = "ContInp";
            this.ContInp.Size = new System.Drawing.Size(57, 41);
            this.ContInp.TabIndex = 1;
            // 
            // Param1Inp
            // 
            this.Param1Inp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Param1Inp.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Param1Inp.Location = new System.Drawing.Point(433, 3);
            this.Param1Inp.MaxLength = 5;
            this.Param1Inp.Multiline = true;
            this.Param1Inp.Name = "Param1Inp";
            this.Param1Inp.Size = new System.Drawing.Size(94, 41);
            this.Param1Inp.TabIndex = 2;
            // 
            // Count
            // 
            this.Count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Count.AutoSize = true;
            this.Count.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count.Location = new System.Drawing.Point(128, 3);
            this.Count.Margin = new System.Windows.Forms.Padding(3);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(88, 41);
            this.Count.TabIndex = 3;
            this.Count.Text = "Кол-во";
            this.Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Param1T
            // 
            this.Param1T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Param1T.AutoSize = true;
            this.Param1T.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Param1T.Location = new System.Drawing.Point(285, 3);
            this.Param1T.Margin = new System.Windows.Forms.Padding(3);
            this.Param1T.Name = "Param1T";
            this.Param1T.Size = new System.Drawing.Size(142, 41);
            this.Param1T.TabIndex = 4;
            this.Param1T.Text = "Параметр 1";
            this.Param1T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(765, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Шаблон";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Param2T
            // 
            this.Param2T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Param2T.AutoSize = true;
            this.Param2T.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Param2T.Location = new System.Drawing.Point(534, 3);
            this.Param2T.Margin = new System.Windows.Forms.Padding(3);
            this.Param2T.Name = "Param2T";
            this.Param2T.Size = new System.Drawing.Size(142, 41);
            this.Param2T.TabIndex = 6;
            this.Param2T.Text = "Параметр 2";
            this.Param2T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBox1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(879, 3);
            this.comboBox1.MaxLength = 5;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 37);
            this.comboBox1.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox3.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(682, 3);
            this.textBox3.MaxLength = 5;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(77, 41);
            this.textBox3.TabIndex = 8;
            // 
            // MarkUp
            // 
            this.MarkUp.ColumnCount = 9;
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MarkUp.Controls.Add(this.Title, 0, 0);
            this.MarkUp.Controls.Add(this.comboBox1, 8, 0);
            this.MarkUp.Controls.Add(this.textBox3, 6, 0);
            this.MarkUp.Controls.Add(this.label3, 7, 0);
            this.MarkUp.Controls.Add(this.Count, 1, 0);
            this.MarkUp.Controls.Add(this.ContInp, 2, 0);
            this.MarkUp.Controls.Add(this.Param2T, 5, 0);
            this.MarkUp.Controls.Add(this.Param1T, 3, 0);
            this.MarkUp.Controls.Add(this.Param1Inp, 4, 0);
            this.MarkUp.Controls.Add(this.Area, 0, 1);
            this.MarkUp.Controls.Add(this.AreaInp, 4, 1);
            this.MarkUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarkUp.Location = new System.Drawing.Point(0, 0);
            this.MarkUp.Name = "MarkUp";
            this.MarkUp.RowCount = 2;
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MarkUp.Size = new System.Drawing.Size(1011, 95);
            this.MarkUp.TabIndex = 9;
            // 
            // Area
            // 
            this.Area.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Area.AutoSize = true;
            this.MarkUp.SetColumnSpan(this.Area, 4);
            this.Area.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.Location = new System.Drawing.Point(311, 50);
            this.Area.Margin = new System.Windows.Forms.Padding(3);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(116, 42);
            this.Area.TabIndex = 9;
            this.Area.Text = "Площадь";
            this.Area.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AreaInp
            // 
            this.AreaInp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AreaInp.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaInp.Location = new System.Drawing.Point(433, 50);
            this.AreaInp.MaxLength = 5;
            this.AreaInp.Multiline = true;
            this.AreaInp.Name = "AreaInp";
            this.AreaInp.Size = new System.Drawing.Size(95, 42);
            this.AreaInp.TabIndex = 10;
            // 
            // Element
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MarkUp);
            this.Name = "Element";
            this.Size = new System.Drawing.Size(1011, 95);
            this.MarkUp.ResumeLayout(false);
            this.MarkUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel MarkUp;
        private System.Windows.Forms.Label Area;
        public System.Windows.Forms.Label Title;
        public System.Windows.Forms.TextBox ContInp;
        public System.Windows.Forms.TextBox Param1Inp;
        public System.Windows.Forms.Label Param1T;
        public System.Windows.Forms.Label Param2T;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox AreaInp;
    }
}
