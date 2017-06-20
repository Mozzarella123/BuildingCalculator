namespace BuildingCalculator.FormComponents
{
    partial class SelectWorkTypes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WorkTypeList = new System.Windows.Forms.CheckedListBox();
            this.checkall = new System.Windows.Forms.Button();
            this.uncheckall = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WorkTypeList
            // 
            this.WorkTypeList.CheckOnClick = true;
            this.WorkTypeList.FormattingEnabled = true;
            this.WorkTypeList.Location = new System.Drawing.Point(109, 58);
            this.WorkTypeList.Name = "WorkTypeList";
            this.WorkTypeList.Size = new System.Drawing.Size(353, 382);
            this.WorkTypeList.TabIndex = 0;
            // 
            // checkall
            // 
            this.checkall.Location = new System.Drawing.Point(110, 14);
            this.checkall.Name = "checkall";
            this.checkall.Size = new System.Drawing.Size(136, 38);
            this.checkall.TabIndex = 1;
            this.checkall.Text = "Выбрать все";
            this.checkall.UseVisualStyleBackColor = true;
            this.checkall.Click += new System.EventHandler(this.Edit_Puntcs);
            // 
            // uncheckall
            // 
            this.uncheckall.Location = new System.Drawing.Point(330, 14);
            this.uncheckall.Name = "uncheckall";
            this.uncheckall.Size = new System.Drawing.Size(132, 38);
            this.uncheckall.TabIndex = 2;
            this.uncheckall.Text = "Снять все";
            this.uncheckall.UseVisualStyleBackColor = true;
            this.uncheckall.Click += new System.EventHandler(this.Edit_Puntcs);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(213, 446);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(134, 34);
            this.Calculate.TabIndex = 3;
            this.Calculate.Text = "Рассчитать";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // SelectWorkTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 519);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.uncheckall);
            this.Controls.Add(this.checkall);
            this.Controls.Add(this.WorkTypeList);
            this.Name = "SelectWorkTypes";
            this.Text = "SelectWorkTypes";
            this.Click += new System.EventHandler(this.Edit_Puntcs);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox WorkTypeList;
        private System.Windows.Forms.Button checkall;
        private System.Windows.Forms.Button uncheckall;
        private System.Windows.Forms.Button Calculate;
    }
}