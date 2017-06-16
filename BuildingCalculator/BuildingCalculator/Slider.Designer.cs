namespace BuildingCalculator
{
    partial class Slider
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
            this.Markup = new System.Windows.Forms.TableLayoutPanel();
            this.Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Prev = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.CurrentIndex = new System.Windows.Forms.Label();
            this.LengthT = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.TextBox();
            this.Width = new System.Windows.Forms.TextBox();
            this.WidthT = new System.Windows.Forms.Label();
            this.Markup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Markup
            // 
            this.Markup.ColumnCount = 3;
            this.Markup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Markup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Markup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Markup.Controls.Add(this.Remove, 0, 0);
            this.Markup.Controls.Add(this.Add, 2, 0);
            this.Markup.Controls.Add(this.Prev, 0, 5);
            this.Markup.Controls.Add(this.Next, 2, 5);
            this.Markup.Controls.Add(this.CurrentIndex, 1, 0);
            this.Markup.Controls.Add(this.LengthT, 0, 1);
            this.Markup.Controls.Add(this.Length, 0, 2);
            this.Markup.Controls.Add(this.Width, 0, 4);
            this.Markup.Controls.Add(this.WidthT, 0, 3);
            this.Markup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Markup.Location = new System.Drawing.Point(0, 0);
            this.Markup.Name = "Markup";
            this.Markup.RowCount = 6;
            this.Markup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Markup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Markup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Markup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Markup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Markup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Markup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Markup.Size = new System.Drawing.Size(204, 272);
            this.Markup.TabIndex = 0;
            // 
            // Remove
            // 
            this.Remove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Remove.Location = new System.Drawing.Point(3, 3);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(62, 39);
            this.Remove.TabIndex = 0;
            this.Remove.Text = "-";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Slider_Controls_Click);
            // 
            // Add
            // 
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(139, 3);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(62, 39);
            this.Add.TabIndex = 1;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Slider_Controls_Click);
            // 
            // Prev
            // 
            this.Prev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prev.Location = new System.Drawing.Point(3, 228);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(62, 41);
            this.Prev.TabIndex = 2;
            this.Prev.Text = "<";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Slider_Controls_Click);
            // 
            // Next
            // 
            this.Next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Next.Location = new System.Drawing.Point(139, 228);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(62, 41);
            this.Next.TabIndex = 3;
            this.Next.Text = ">";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Slider_Controls_Click);
            // 
            // CurrentIndex
            // 
            this.CurrentIndex.AutoSize = true;
            this.CurrentIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentIndex.Location = new System.Drawing.Point(71, 0);
            this.CurrentIndex.Name = "CurrentIndex";
            this.CurrentIndex.Size = new System.Drawing.Size(62, 45);
            this.CurrentIndex.TabIndex = 4;
            this.CurrentIndex.Text = "1";
            this.CurrentIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LengthT
            // 
            this.LengthT.AutoSize = true;
            this.Markup.SetColumnSpan(this.LengthT, 3);
            this.LengthT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LengthT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthT.Location = new System.Drawing.Point(3, 45);
            this.LengthT.Name = "LengthT";
            this.LengthT.Size = new System.Drawing.Size(198, 45);
            this.LengthT.TabIndex = 5;
            this.LengthT.Text = "Длина";
            this.LengthT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Length
            // 
            this.Length.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Markup.SetColumnSpan(this.Length, 3);
            this.Length.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Length.Location = new System.Drawing.Point(3, 93);
            this.Length.MaxLength = 4;
            this.Length.Multiline = true;
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(198, 39);
            this.Length.TabIndex = 6;
            this.Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Length.TextChanged += new System.EventHandler(this.Params_Input);
            this.Length.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Params_KeyDown);
            // 
            // Width
            // 
            this.Markup.SetColumnSpan(this.Width, 3);
            this.Width.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Width.Location = new System.Drawing.Point(3, 183);
            this.Width.MaxLength = 4;
            this.Width.Multiline = true;
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(198, 39);
            this.Width.TabIndex = 8;
            this.Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Width.TextChanged += new System.EventHandler(this.Params_Input);
            this.Width.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Params_KeyDown);
            // 
            // WidthT
            // 
            this.WidthT.AutoSize = true;
            this.Markup.SetColumnSpan(this.WidthT, 3);
            this.WidthT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WidthT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthT.Location = new System.Drawing.Point(3, 135);
            this.WidthT.Name = "WidthT";
            this.WidthT.Size = new System.Drawing.Size(198, 45);
            this.WidthT.TabIndex = 7;
            this.WidthT.Text = "Ширина";
            this.WidthT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Slider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Markup);
            this.Name = "Slider";
            this.Size = new System.Drawing.Size(204, 272);
            this.Markup.ResumeLayout(false);
            this.Markup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Markup;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label CurrentIndex;
        private System.Windows.Forms.Label LengthT;
        private System.Windows.Forms.TextBox Length;
        private System.Windows.Forms.Label WidthT;
        private System.Windows.Forms.TextBox Width;
    }
}
