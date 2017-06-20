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
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(216, 304);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(134, 34);
            this.Calculate.TabIndex = 3;
            this.Calculate.Text = "Рассчитать";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // SelectWorksTree
            // 
            this.SelectWorksTree.CheckBoxes = true;
            this.SelectWorksTree.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectWorksTree.Location = new System.Drawing.Point(0, 0);
            this.SelectWorksTree.Name = "SelectWorksTree";
            this.SelectWorksTree.Size = new System.Drawing.Size(573, 286);
            this.SelectWorksTree.TabIndex = 4;
            this.SelectWorksTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.SelectWorksTree_AfterCheck);
            this.SelectWorksTree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.SelectWorksTree_BeforeSelect);
            this.SelectWorksTree.DoubleClick += new System.EventHandler(this.SelectWorksTree_DoubleClick);
            // 
            // SelectWorkTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 366);
            this.Controls.Add(this.SelectWorksTree);
            this.Controls.Add(this.Calculate);
            this.Name = "SelectWorkTypes";
            this.Text = "SelectWorkTypes";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TreeView SelectWorksTree;
    }
}