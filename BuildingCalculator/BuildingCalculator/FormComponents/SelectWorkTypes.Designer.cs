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
            this.CalculateBut = new System.Windows.Forms.Button();
            this.SelectWorksTree = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RoomTitle = new System.Windows.Forms.Label();
            this.searchInp = new System.Windows.Forms.TextBox();
            this.SearchT = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculateBut
            // 
            this.CalculateBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel1.SetColumnSpan(this.CalculateBut, 2);
            this.CalculateBut.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateBut.Location = new System.Drawing.Point(196, 397);
            this.CalculateBut.Name = "CalculateBut";
            this.CalculateBut.Size = new System.Drawing.Size(162, 62);
            this.CalculateBut.TabIndex = 3;
            this.CalculateBut.Text = "Рассчитать";
            this.CalculateBut.UseVisualStyleBackColor = true;
            this.CalculateBut.Click += new System.EventHandler(this.Calculate);
            // 
            // SelectWorksTree
            // 
            this.SelectWorksTree.CheckBoxes = true;
            this.tableLayoutPanel1.SetColumnSpan(this.SelectWorksTree, 2);
            this.SelectWorksTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectWorksTree.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectWorksTree.HideSelection = false;
            this.SelectWorksTree.Location = new System.Drawing.Point(10, 87);
            this.SelectWorksTree.Margin = new System.Windows.Forms.Padding(10);
            this.SelectWorksTree.Name = "SelectWorksTree";
            this.SelectWorksTree.Size = new System.Drawing.Size(534, 297);
            this.SelectWorksTree.TabIndex = 4;
            this.SelectWorksTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.SelectWorksTree_AfterCheck);
            this.SelectWorksTree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.SelectWorksTree_BeforeSelect);
            this.SelectWorksTree.DoubleClick += new System.EventHandler(this.SelectWorksTree_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 281F));
            this.tableLayoutPanel1.Controls.Add(this.CalculateBut, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SelectWorksTree, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.RoomTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchInp, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SearchT, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.16751F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.83249F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(554, 462);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // RoomTitle
            // 
            this.RoomTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RoomTitle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.RoomTitle, 2);
            this.RoomTitle.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomTitle.Location = new System.Drawing.Point(240, 5);
            this.RoomTitle.Margin = new System.Windows.Forms.Padding(5);
            this.RoomTitle.Name = "RoomTitle";
            this.RoomTitle.Size = new System.Drawing.Size(74, 29);
            this.RoomTitle.TabIndex = 5;
            this.RoomTitle.Text = "label1";
            this.RoomTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchInp
            // 
            this.searchInp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchInp.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchInp.Location = new System.Drawing.Point(283, 42);
            this.searchInp.Multiline = true;
            this.searchInp.Name = "searchInp";
            this.searchInp.Size = new System.Drawing.Size(260, 32);
            this.searchInp.TabIndex = 6;
            this.searchInp.TextChanged += new System.EventHandler(this.searchInp_TextChanged);
            this.searchInp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchInp_KeyPress);
            // 
            // SearchT
            // 
            this.SearchT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SearchT.AutoSize = true;
            this.SearchT.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchT.Location = new System.Drawing.Point(96, 42);
            this.SearchT.Margin = new System.Windows.Forms.Padding(3);
            this.SearchT.Name = "SearchT";
            this.SearchT.Size = new System.Drawing.Size(80, 32);
            this.SearchT.TabIndex = 7;
            this.SearchT.Text = "Поиск";
            // 
            // SelectWorkTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 462);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SelectWorkTypes";
            this.Text = "Выбрать работы для отчёта";
            this.Load += new System.EventHandler(this.SelectWorkTypes_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CalculateBut;
        private System.Windows.Forms.TreeView SelectWorksTree;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label RoomTitle;
        private System.Windows.Forms.TextBox searchInp;
        private System.Windows.Forms.Label SearchT;
    }
}