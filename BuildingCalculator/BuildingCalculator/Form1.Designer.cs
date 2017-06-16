namespace BuildingCalculator
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
            this.slider1 = new BuildingCalculator.Slider();
            this.slider2 = new BuildingCalculator.Slider();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WidthT = new System.Windows.Forms.Label();
            this.LengthT = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.TextBox();
            this.Width = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // slider1
            // 
            this.slider1.Location = new System.Drawing.Point(18, 67);
            this.slider1.Name = "slider1";
            this.slider1.Size = new System.Drawing.Size(172, 308);
            this.slider1.TabIndex = 20;
            // 
            // slider2
            // 
            this.slider2.Location = new System.Drawing.Point(207, 67);
            this.slider2.Name = "slider2";
            this.slider2.Size = new System.Drawing.Size(172, 308);
            this.slider2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Двери";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(253, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Окна";
            // 
            // WidthT
            // 
            this.WidthT.AutoSize = true;
            this.WidthT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthT.Location = new System.Drawing.Point(58, 149);
            this.WidthT.Name = "WidthT";
            this.WidthT.Size = new System.Drawing.Size(105, 29);
            this.WidthT.TabIndex = 22;
            this.WidthT.Text = "Ширина";
            // 
            // LengthT
            // 
            this.LengthT.AutoSize = true;
            this.LengthT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthT.Location = new System.Drawing.Point(67, 46);
            this.LengthT.Name = "LengthT";
            this.LengthT.Size = new System.Drawing.Size(87, 29);
            this.LengthT.TabIndex = 23;
            this.LengthT.Text = "Длина";
            // 
            // Length
            // 
            this.Length.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Length.Location = new System.Drawing.Point(21, 90);
            this.Length.MaxLength = 4;
            this.Length.Multiline = true;
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(172, 45);
            this.Length.TabIndex = 24;
            this.Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Length.TextChanged += new System.EventHandler(this.Input_Room);
            this.Length.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Length_KeyDown);
            // 
            // Width
            // 
            this.Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Width.Location = new System.Drawing.Point(21, 194);
            this.Width.MaxLength = 4;
            this.Width.Multiline = true;
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(172, 45);
            this.Width.TabIndex = 25;
            this.Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Width.TextChanged += new System.EventHandler(this.Input_Room);
            this.Width.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Length_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(58, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Комната";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Width);
            this.groupBox1.Controls.Add(this.Length);
            this.groupBox1.Controls.Add(this.LengthT);
            this.groupBox1.Controls.Add(this.WidthT);
            this.groupBox1.Location = new System.Drawing.Point(21, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 276);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.slider2);
            this.groupBox2.Controls.Add(this.slider1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(247, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 421);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 587);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Slider slider1;
        private Slider slider2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label WidthT;
        private System.Windows.Forms.Label LengthT;
        private System.Windows.Forms.TextBox Length;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

