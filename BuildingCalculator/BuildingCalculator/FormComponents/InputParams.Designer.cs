namespace BuildingCalculator.FormComponents
{
    partial class inputparams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inputparams));
            this.Paramname = new System.Windows.Forms.Label();
            this.ParamInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WorkTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Paramname
            // 
            this.Paramname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Paramname.AutoSize = true;
            this.Paramname.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Paramname.Location = new System.Drawing.Point(347, 0);
            this.Paramname.Name = "Paramname";
            this.Paramname.Size = new System.Drawing.Size(119, 52);
            this.Paramname.TabIndex = 0;
            this.Paramname.Text = "параметр";
            this.Paramname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ParamInput
            // 
            this.ParamInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ParamInput.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParamInput.Location = new System.Drawing.Point(215, 3);
            this.ParamInput.Multiline = true;
            this.ParamInput.Name = "ParamInput";
            this.ParamInput.Size = new System.Drawing.Size(126, 46);
            this.ParamInput.TabIndex = 1;
            this.ParamInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ParamInput_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.ParamInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Paramname, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.WorkTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(739, 52);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // WorkTitle
            // 
            this.WorkTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.WorkTitle.AutoSize = true;
            this.WorkTitle.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkTitle.Location = new System.Drawing.Point(3, 0);
            this.WorkTitle.Name = "WorkTitle";
            this.WorkTitle.Size = new System.Drawing.Size(206, 52);
            this.WorkTitle.TabIndex = 2;
            this.WorkTitle.Text = "Название работы";
            this.WorkTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(533, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ввести";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputparams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(739, 52);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "inputparams";
            this.Text = "Ввод параметров";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.inputparams_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label WorkTitle;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label Paramname;
        public System.Windows.Forms.TextBox ParamInput;
    }
}