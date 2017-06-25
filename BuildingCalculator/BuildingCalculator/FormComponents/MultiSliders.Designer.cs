namespace BuildingCalculator
{
    partial class MultiSliders
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
            this.slider = new BuildingCalculator.Slider();
            this.ElementsNames = new System.Windows.Forms.ComboBox();
            this.Sliders = new System.Windows.Forms.Panel();
            this.Sliders.SuspendLayout();
            this.SuspendLayout();
            // 
            // slider
            // 
            this.slider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slider.Location = new System.Drawing.Point(0, 0);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(223, 303);
            this.slider.TabIndex = 0;
            // 
            // ElementsNames
            // 
            this.ElementsNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ElementsNames.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElementsNames.FormattingEnabled = true;
            this.ElementsNames.Location = new System.Drawing.Point(6, 3);
            this.ElementsNames.Name = "ElementsNames";
            this.ElementsNames.Size = new System.Drawing.Size(216, 37);
            this.ElementsNames.TabIndex = 1;
            this.ElementsNames.SelectedIndexChanged += new System.EventHandler(this.SliderChanged);
            // 
            // Sliders
            // 
            this.Sliders.Controls.Add(this.slider);
            this.Sliders.Location = new System.Drawing.Point(3, 52);
            this.Sliders.Name = "Sliders";
            this.Sliders.Size = new System.Drawing.Size(223, 303);
            this.Sliders.TabIndex = 2;
            // 
            // MultiSliders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Sliders);
            this.Controls.Add(this.ElementsNames);
            this.Name = "MultiSliders";
            this.Size = new System.Drawing.Size(229, 362);
            this.Sliders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Slider slider;
        private System.Windows.Forms.ComboBox ElementsNames;
        private System.Windows.Forms.Panel Sliders;
    }
}
