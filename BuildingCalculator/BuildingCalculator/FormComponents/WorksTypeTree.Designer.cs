namespace BuildingCalculator.FormComponents
{
    partial class WorksTypeTree
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
            this.MarkUp = new System.Windows.Forms.TableLayoutPanel();
            this.Title = new System.Windows.Forms.Label();
            this.SearchT = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.WorksList = new System.Windows.Forms.TreeView();
            this.MarkUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // MarkUp
            // 
            this.MarkUp.ColumnCount = 1;
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MarkUp.Controls.Add(this.Title, 0, 0);
            this.MarkUp.Controls.Add(this.SearchT, 0, 1);
            this.MarkUp.Controls.Add(this.Search, 0, 2);
            this.MarkUp.Controls.Add(this.WorksList, 0, 3);
            this.MarkUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarkUp.Location = new System.Drawing.Point(3, 3);
            this.MarkUp.Name = "MarkUp";
            this.MarkUp.RowCount = 4;
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 285F));
            this.MarkUp.Size = new System.Drawing.Size(277, 421);
            this.MarkUp.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(79, 3);
            this.Title.Margin = new System.Windows.Forms.Padding(3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(119, 44);
            this.Title.TabIndex = 0;
            this.Title.Text = "Название";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchT
            // 
            this.SearchT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SearchT.AutoSize = true;
            this.SearchT.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchT.Location = new System.Drawing.Point(98, 53);
            this.SearchT.Margin = new System.Windows.Forms.Padding(3);
            this.SearchT.Name = "SearchT";
            this.SearchT.Size = new System.Drawing.Size(80, 44);
            this.SearchT.TabIndex = 2;
            this.SearchT.Text = "Поиск";
            this.SearchT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Search.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(24, 103);
            this.Search.Multiline = true;
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(229, 41);
            this.Search.TabIndex = 3;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            this.Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Search_KeyPress);
            // 
            // WorksList
            // 
            this.WorksList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WorksList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorksList.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorksList.HideSelection = false;
            this.WorksList.Location = new System.Drawing.Point(3, 150);
            this.WorksList.Name = "WorksList";
            this.WorksList.Size = new System.Drawing.Size(271, 279);
            this.WorksList.TabIndex = 4;
            this.WorksList.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.WorksList_BeforeCheck);
            this.WorksList.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.WorksList_AfterCheck);
            this.WorksList.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.WorksList_BeforeSelect);
            // 
            // WorksTypeTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.MarkUp);
            this.Name = "WorksTypeTree";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(283, 427);
            this.MarkUp.ResumeLayout(false);
            this.MarkUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label Title;
        public System.Windows.Forms.Label SearchT;
        private System.Windows.Forms.TextBox Search;
        public System.Windows.Forms.TreeView WorksList;
        public System.Windows.Forms.TableLayoutPanel MarkUp;
    }
}
