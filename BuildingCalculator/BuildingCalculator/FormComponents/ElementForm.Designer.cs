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
            this.Param1Inp = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.Label();
            this.Param1T = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MarkUp = new System.Windows.Forms.TableLayoutPanel();
            this.Param2T = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Param2Inp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MarkUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(3, 22);
            this.Title.Margin = new System.Windows.Forms.Padding(3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(119, 29);
            this.Title.TabIndex = 0;
            this.Title.Text = "Название";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContInp
            // 
            this.ContInp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ContInp.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContInp.Location = new System.Drawing.Point(276, 16);
            this.ContInp.MaxLength = 5;
            this.ContInp.Multiline = true;
            this.ContInp.Name = "ContInp";
            this.ContInp.Size = new System.Drawing.Size(81, 41);
            this.ContInp.TabIndex = 1;
            // 
            // Param1Inp
            // 
            this.Param1Inp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Param1Inp.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Param1Inp.Location = new System.Drawing.Point(276, 91);
            this.Param1Inp.MaxLength = 5;
            this.Param1Inp.Multiline = true;
            this.Param1Inp.Name = "Param1Inp";
            this.Param1Inp.Size = new System.Drawing.Size(81, 41);
            this.Param1Inp.TabIndex = 2;
            // 
            // Count
            // 
            this.Count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Count.AutoSize = true;
            this.Count.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count.Location = new System.Drawing.Point(128, 22);
            this.Count.Margin = new System.Windows.Forms.Padding(3);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(142, 29);
            this.Count.TabIndex = 3;
            this.Count.Text = "Кол-во";
            this.Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Param1T
            // 
            this.Param1T.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Param1T.AutoSize = true;
            this.Param1T.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Param1T.Location = new System.Drawing.Point(128, 97);
            this.Param1T.Margin = new System.Windows.Forms.Padding(3);
            this.Param1T.Name = "Param1T";
            this.Param1T.Size = new System.Drawing.Size(142, 29);
            this.Param1T.TabIndex = 4;
            this.Param1T.Text = "Параметр 1";
            this.Param1T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Шаблон";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MarkUp
            // 
            this.MarkUp.ColumnCount = 6;
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MarkUp.Controls.Add(this.Title, 0, 0);
            this.MarkUp.Controls.Add(this.Count, 1, 0);
            this.MarkUp.Controls.Add(this.comboBox1, 4, 0);
            this.MarkUp.Controls.Add(this.Param1Inp, 2, 1);
            this.MarkUp.Controls.Add(this.ContInp, 2, 0);
            this.MarkUp.Controls.Add(this.label3, 3, 0);
            this.MarkUp.Controls.Add(this.button1, 5, 0);
            this.MarkUp.Controls.Add(this.Param1T, 1, 1);
            this.MarkUp.Controls.Add(this.Param2T, 3, 1);
            this.MarkUp.Controls.Add(this.Param2Inp, 4, 1);
            this.MarkUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarkUp.Location = new System.Drawing.Point(0, 0);
            this.MarkUp.Name = "MarkUp";
            this.MarkUp.RowCount = 2;
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MarkUp.Size = new System.Drawing.Size(892, 149);
            this.MarkUp.TabIndex = 9;
            // 
            // Param2T
            // 
            this.Param2T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Param2T.AutoSize = true;
            this.Param2T.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Param2T.Location = new System.Drawing.Point(363, 97);
            this.Param2T.Margin = new System.Windows.Forms.Padding(3);
            this.Param2T.Name = "Param2T";
            this.Param2T.Size = new System.Drawing.Size(142, 29);
            this.Param2T.TabIndex = 6;
            this.Param2T.Text = "Параметр 2";
            this.Param2T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Сменить тип ",
            "Нестандартный"});
            this.comboBox1.Location = new System.Drawing.Point(511, 18);
            this.comboBox1.MaxLength = 5;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 37);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Param2Inp
            // 
            this.Param2Inp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MarkUp.SetColumnSpan(this.Param2Inp, 2);
            this.Param2Inp.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Param2Inp.Location = new System.Drawing.Point(511, 91);
            this.Param2Inp.MaxLength = 5;
            this.Param2Inp.Multiline = true;
            this.Param2Inp.Name = "Param2Inp";
            this.Param2Inp.Size = new System.Drawing.Size(117, 41);
            this.Param2Inp.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(739, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MarkUp);
            this.Name = "ElementForm";
            this.Size = new System.Drawing.Size(892, 149);
            this.MarkUp.ResumeLayout(false);
            this.MarkUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel MarkUp;
        public System.Windows.Forms.Label Title;
        public System.Windows.Forms.TextBox ContInp;
        public System.Windows.Forms.TextBox Param1Inp;
        public System.Windows.Forms.Label Param1T;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label Param2T;
        public System.Windows.Forms.TextBox Param2Inp;
    }
}
