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
            this.WidthT = new System.Windows.Forms.Label();
            this.LengthT = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.TextBox();
            this.Width = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // slider1
            // 
            this.slider1.Location = new System.Drawing.Point(429, 48);
            this.slider1.Name = "slider1";
            this.slider1.Size = new System.Drawing.Size(144, 247);
            this.slider1.TabIndex = 20;
            // 
            // slider2
            // 
            this.slider2.Location = new System.Drawing.Point(618, 48);
            this.slider2.Name = "slider2";
            this.slider2.Size = new System.Drawing.Size(144, 247);
            this.slider2.TabIndex = 21;
            // 
            // WidthT
            // 
            this.WidthT.AutoSize = true;
            this.WidthT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthT.Location = new System.Drawing.Point(17, 167);
            this.WidthT.Name = "WidthT";
            this.WidthT.Size = new System.Drawing.Size(105, 29);
            this.WidthT.TabIndex = 22;
            this.WidthT.Text = "Ширина";
            // 
            // LengthT
            // 
            this.LengthT.AutoSize = true;
            this.LengthT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthT.Location = new System.Drawing.Point(26, 75);
            this.LengthT.Name = "LengthT";
            this.LengthT.Size = new System.Drawing.Size(87, 29);
            this.LengthT.TabIndex = 23;
            this.LengthT.Text = "Длина";
            // 
            // Length
            // 
            this.Length.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Length.Location = new System.Drawing.Point(17, 116);
            this.Length.MaxLength = 4;
            this.Length.Multiline = true;
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(105, 38);
            this.Length.TabIndex = 24;
            // 
            // Width
            // 
            this.Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Width.Location = new System.Drawing.Point(17, 211);
            this.Width.MaxLength = 4;
            this.Width.Multiline = true;
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(105, 38);
            this.Width.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(464, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Двери";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(655, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Окна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Комната";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 587);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.LengthT);
            this.Controls.Add(this.WidthT);
            this.Controls.Add(this.slider2);
            this.Controls.Add(this.slider1);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Slider slider1;
        private Slider slider2;
        private System.Windows.Forms.Label WidthT;
        private System.Windows.Forms.Label LengthT;
        private System.Windows.Forms.TextBox Length;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

