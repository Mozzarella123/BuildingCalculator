﻿namespace BuildingCalculator
{
    partial class TabContent
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
            this.multiSliders1 = new BuildingCalculator.MultiSliders();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.TextBox();
            this.Length = new System.Windows.Forms.TextBox();
            this.LengthT = new System.Windows.Forms.Label();
            this.WidthT = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // multiSliders1
            // 
            this.multiSliders1.Location = new System.Drawing.Point(323, 36);
            this.multiSliders1.Name = "multiSliders1";
            this.multiSliders1.Size = new System.Drawing.Size(229, 362);
            this.multiSliders1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Width);
            this.groupBox1.Controls.Add(this.Length);
            this.groupBox1.Controls.Add(this.LengthT);
            this.groupBox1.Controls.Add(this.WidthT);
            this.groupBox1.Location = new System.Drawing.Point(55, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 276);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Комната";
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
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Calculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calculate.FlatAppearance.BorderSize = 0;
            this.Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calculate.Location = new System.Drawing.Point(55, 331);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(209, 51);
            this.Calculate.TabIndex = 33;
            this.Calculate.Text = "Рассчитать";
            this.Calculate.UseVisualStyleBackColor = false;
            // 
            // TabContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.multiSliders1);
            this.Name = "TabContent";
            this.Size = new System.Drawing.Size(643, 471);
            this.Load += new System.EventHandler(this.TabContent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MultiSliders multiSliders1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.TextBox Length;
        private System.Windows.Forms.Label LengthT;
        private System.Windows.Forms.Label WidthT;
        private System.Windows.Forms.Button Calculate;
    }
}