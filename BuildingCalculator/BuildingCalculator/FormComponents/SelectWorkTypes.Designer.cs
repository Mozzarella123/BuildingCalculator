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
            this.Calculate = new System.Windows.Forms.Button();
            this.SelectWorksTree = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Calculate.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculate.Location = new System.Drawing.Point(205, 319);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(162, 44);
            this.Calculate.TabIndex = 3;
            this.Calculate.Text = "Рассчитать";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // SelectWorksTree
            // 
            this.SelectWorksTree.CheckBoxes = true;
            this.SelectWorksTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectWorksTree.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectWorksTree.Location = new System.Drawing.Point(10, 10);
            this.SelectWorksTree.Margin = new System.Windows.Forms.Padding(10);
            this.SelectWorksTree.Name = "SelectWorksTree";
            this.SelectWorksTree.Size = new System.Drawing.Size(553, 296);
            this.SelectWorksTree.TabIndex = 4;
            this.SelectWorksTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.SelectWorksTree_AfterCheck);
            this.SelectWorksTree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.SelectWorksTree_BeforeSelect);
            this.SelectWorksTree.DoubleClick += new System.EventHandler(this.SelectWorksTree_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Calculate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SelectWorksTree, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.3388F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.6612F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(573, 366);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // SelectWorkTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SelectWorkTypes";
            this.Text = "Выбрать работы для отчёта";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TreeView SelectWorksTree;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}