namespace BuildingCalculator
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ItemsinTree = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DownloadfromExcel = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SearchInp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(170, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список работ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ItemsinTree
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ItemsinTree, 2);
            this.ItemsinTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsinTree.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsinTree.FullRowSelect = true;
            this.ItemsinTree.HideSelection = false;
            this.ItemsinTree.Location = new System.Drawing.Point(10, 133);
            this.ItemsinTree.Margin = new System.Windows.Forms.Padding(10);
            this.ItemsinTree.Name = "ItemsinTree";
            this.ItemsinTree.Size = new System.Drawing.Size(482, 297);
            this.ItemsinTree.TabIndex = 3;
            this.ItemsinTree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.ItemsinTree_BeforeSelect);
            this.ItemsinTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ItemsinTree_NodeMouseClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.64935F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.35065F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ItemsinTree, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.DownloadfromExcel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Clear, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SearchInp, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.70615F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.36364F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.95454F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(502, 440);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // DownloadfromExcel
            // 
            this.DownloadfromExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DownloadfromExcel.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownloadfromExcel.Location = new System.Drawing.Point(12, 46);
            this.DownloadfromExcel.Name = "DownloadfromExcel";
            this.DownloadfromExcel.Size = new System.Drawing.Size(230, 40);
            this.DownloadfromExcel.TabIndex = 4;
            this.DownloadfromExcel.Text = "Загрузить из Excel";
            this.DownloadfromExcel.UseVisualStyleBackColor = true;
            this.DownloadfromExcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Clear.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(271, 46);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(213, 40);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Очистить список";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // SearchInp
            // 
            this.SearchInp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SearchInp.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.SearchInp.Location = new System.Drawing.Point(271, 92);
            this.SearchInp.Multiline = true;
            this.SearchInp.Name = "SearchInp";
            this.SearchInp.Size = new System.Drawing.Size(214, 28);
            this.SearchInp.TabIndex = 6;
            this.SearchInp.TextChanged += new System.EventHandler(this.Search);
            this.SearchInp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchInp_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(166, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Поиск:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel Таблица|*.xls;*.xlsx;\"";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 440);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.Text = "Список работ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView ItemsinTree;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button DownloadfromExcel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox SearchInp;
        private System.Windows.Forms.Label label2;
    }
}