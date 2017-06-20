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
            this.WidthT = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.HeightT = new System.Windows.Forms.Label();
            this.Markup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Markup
            // 
            this.Markup.ColumnCount = 3;
            this.Markup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Markup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.Markup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.Markup.Controls.Add(this.Remove, 0, 0);
            this.Markup.Controls.Add(this.Add, 2, 0);
            this.Markup.Controls.Add(this.Prev, 0, 5);
            this.Markup.Controls.Add(this.Next, 2, 5);
            this.Markup.Controls.Add(this.CurrentIndex, 1, 0);
            this.Markup.Controls.Add(this.WidthT, 0, 1);
            this.Markup.Controls.Add(this.Width, 0, 2);
            this.Markup.Controls.Add(this.Height, 0, 4);
            this.Markup.Controls.Add(this.HeightT, 0, 3);
            this.Markup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Markup.Location = new System.Drawing.Point(0, 0);
            this.Markup.Name = "Markup";
            this.Markup.RowCount = 6;
            this.Markup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Markup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Markup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Markup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Markup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Markup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Markup.Size = new System.Drawing.Size(216, 291);
            this.Markup.TabIndex = 0;
            // 
            // Remove
            // 
            this.Remove.AutoSize = true;
            this.Remove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Remove.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Remove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Remove.FlatAppearance.BorderSize = 0;
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Remove.Location = new System.Drawing.Point(3, 3);
            this.Remove.Name = "Remove";
            this.Remove.Padding = new System.Windows.Forms.Padding(2);
            this.Remove.Size = new System.Drawing.Size(65, 43);
            this.Remove.TabIndex = 0;
            this.Remove.Text = "-";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Slider_Controls_Click);
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(146, 3);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(2);
            this.Add.Size = new System.Drawing.Size(67, 43);
            this.Add.TabIndex = 1;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Slider_Controls_Click);
            // 
            // Prev
            // 
            this.Prev.AutoSize = true;
            this.Prev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Prev.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Prev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Prev.FlatAppearance.BorderSize = 0;
            this.Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prev.Location = new System.Drawing.Point(3, 244);
            this.Prev.Name = "Prev";
            this.Prev.Padding = new System.Windows.Forms.Padding(2);
            this.Prev.Size = new System.Drawing.Size(65, 44);
            this.Prev.TabIndex = 2;
            this.Prev.Text = "<";
            this.Prev.UseVisualStyleBackColor = false;
            this.Prev.Click += new System.EventHandler(this.Slider_Controls_Click);
            // 
            // Next
            // 
            this.Next.AutoSize = true;
            this.Next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Next.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Next.FlatAppearance.BorderSize = 0;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Next.Location = new System.Drawing.Point(146, 244);
            this.Next.Name = "Next";
            this.Next.Padding = new System.Windows.Forms.Padding(2);
            this.Next.Size = new System.Drawing.Size(67, 44);
            this.Next.TabIndex = 3;
            this.Next.Text = ">";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Slider_Controls_Click);
            // 
            // CurrentIndex
            // 
            this.CurrentIndex.AutoSize = true;
            this.CurrentIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentIndex.Location = new System.Drawing.Point(74, 0);
            this.CurrentIndex.Name = "CurrentIndex";
            this.CurrentIndex.Size = new System.Drawing.Size(66, 49);
            this.CurrentIndex.TabIndex = 4;
            this.CurrentIndex.Text = "1";
            this.CurrentIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WidthT
            // 
            this.WidthT.AutoSize = true;
            this.Markup.SetColumnSpan(this.WidthT, 3);
            this.WidthT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WidthT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthT.Location = new System.Drawing.Point(3, 49);
            this.WidthT.Name = "WidthT";
            this.WidthT.Size = new System.Drawing.Size(210, 48);
            this.WidthT.TabIndex = 5;
            this.WidthT.Text = "Длина";
            this.WidthT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Width
            // 
            this.Width.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Width.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Markup.SetColumnSpan(this.Width, 3);
            this.Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Width.Location = new System.Drawing.Point(3, 100);
            this.Width.MaxLength = 4;
            this.Width.Multiline = true;
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(210, 42);
            this.Width.TabIndex = 6;
            this.Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Width.TextChanged += new System.EventHandler(this.Params_Input);
            // 
            // Height
            // 
            this.Height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Markup.SetColumnSpan(this.Height, 3);
            this.Height.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Height.Location = new System.Drawing.Point(3, 196);
            this.Height.MaxLength = 4;
            this.Height.Multiline = true;
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(210, 42);
            this.Height.TabIndex = 8;
            this.Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Height.TextChanged += new System.EventHandler(this.Params_Input);
            // 
            // HeightT
            // 
            this.HeightT.AutoSize = true;
            this.Markup.SetColumnSpan(this.HeightT, 3);
            this.HeightT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeightT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightT.Location = new System.Drawing.Point(3, 145);
            this.HeightT.Name = "HeightT";
            this.HeightT.Size = new System.Drawing.Size(210, 48);
            this.HeightT.TabIndex = 7;
            this.HeightT.Text = "Высота";
            this.HeightT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Slider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Markup);
            this.Name = "Slider";
            this.Size = new System.Drawing.Size(216, 291);
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
        private System.Windows.Forms.Label WidthT;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.Label HeightT;
        private System.Windows.Forms.TextBox Height;
    }
}
