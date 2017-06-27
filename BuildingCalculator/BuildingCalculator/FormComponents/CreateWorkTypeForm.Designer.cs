namespace BuildingCalculator
{
    partial class CreateWorkTypeForm
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
            this.Listofparams = new System.Windows.Forms.ListBox();
            this.WorkTypeNameInp = new System.Windows.Forms.TextBox();
            this.WorkTypeName = new System.Windows.Forms.Label();
            this.formulat = new System.Windows.Forms.Label();
            this.ParamsT = new System.Windows.Forms.Label();
            this.AddType = new System.Windows.Forms.Button();
            this.Category = new System.Windows.Forms.ComboBox();
            this.CategoryT = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.formula = new BuildingCalculator.FormComponents.TextWithOperations();
            this.parameters = new BuildingCalculator.FormComponents.TextwithBut();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Listofparams
            // 
            this.Listofparams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Listofparams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Listofparams.FormattingEnabled = true;
            this.Listofparams.ItemHeight = 20;
            this.Listofparams.Location = new System.Drawing.Point(399, 46);
            this.Listofparams.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Listofparams.Name = "Listofparams";
            this.tableLayoutPanel1.SetRowSpan(this.Listofparams, 4);
            this.Listofparams.Size = new System.Drawing.Size(250, 244);
            this.Listofparams.TabIndex = 0;
            this.Listofparams.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            this.Listofparams.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // WorkTypeNameInp
            // 
            this.WorkTypeNameInp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.WorkTypeNameInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkTypeNameInp.Location = new System.Drawing.Point(62, 46);
            this.WorkTypeNameInp.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.WorkTypeNameInp.Multiline = true;
            this.WorkTypeNameInp.Name = "WorkTypeNameInp";
            this.WorkTypeNameInp.Size = new System.Drawing.Size(122, 23);
            this.WorkTypeNameInp.TabIndex = 1;
            // 
            // WorkTypeName
            // 
            this.WorkTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.WorkTypeName.AutoSize = true;
            this.WorkTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkTypeName.Location = new System.Drawing.Point(62, 6);
            this.WorkTypeName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.WorkTypeName.Name = "WorkTypeName";
            this.WorkTypeName.Size = new System.Drawing.Size(122, 28);
            this.WorkTypeName.TabIndex = 5;
            this.WorkTypeName.Text = "Наименование";
            this.WorkTypeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formulat
            // 
            this.formulat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.formulat.AutoSize = true;
            this.formulat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formulat.Location = new System.Drawing.Point(29, 81);
            this.formulat.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.formulat.Name = "formulat";
            this.formulat.Size = new System.Drawing.Size(187, 21);
            this.formulat.TabIndex = 6;
            this.formulat.Text = "Формула расчёта цены";
            this.formulat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ParamsT
            // 
            this.ParamsT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ParamsT.AutoSize = true;
            this.ParamsT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParamsT.Location = new System.Drawing.Point(270, 81);
            this.ParamsT.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ParamsT.Name = "ParamsT";
            this.ParamsT.Size = new System.Drawing.Size(97, 21);
            this.ParamsT.TabIndex = 7;
            this.ParamsT.Text = "Параметры";
            this.ParamsT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ParamsT.Click += new System.EventHandler(this.label3_Click);
            // 
            // AddType
            // 
            this.AddType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.SetColumnSpan(this.AddType, 2);
            this.AddType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddType.Location = new System.Drawing.Point(98, 245);
            this.AddType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.AddType.Name = "AddType";
            this.AddType.Size = new System.Drawing.Size(195, 27);
            this.AddType.TabIndex = 9;
            this.AddType.Text = "Добавить тип работ";
            this.AddType.UseVisualStyleBackColor = true;
            this.AddType.Click += new System.EventHandler(this.AddWorkType);
            // 
            // Category
            // 
            this.Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Category.Cursor = System.Windows.Forms.Cursors.Default;
            this.Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "Стены",
            "Пол",
            "Потолок",
            "Пол периметр",
            "Потолок периметр",
            "Разное"});
            this.Category.Location = new System.Drawing.Point(251, 46);
            this.Category.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(135, 28);
            this.Category.TabIndex = 10;
            // 
            // CategoryT
            // 
            this.CategoryT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CategoryT.AutoSize = true;
            this.CategoryT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryT.Location = new System.Drawing.Point(274, 6);
            this.CategoryT.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.CategoryT.Name = "CategoryT";
            this.CategoryT.Size = new System.Drawing.Size(89, 28);
            this.CategoryT.TabIndex = 11;
            this.CategoryT.Text = "Категория";
            this.CategoryT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.60163F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.2561F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.04684F));
            this.tableLayoutPanel1.Controls.Add(this.formula, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.WorkTypeName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Category, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.WorkTypeNameInp, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Listofparams, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.CategoryT, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.formulat, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ParamsT, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.parameters, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.AddType, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.76404F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.03501F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.15974F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.20131F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.81838F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(656, 297);
            this.tableLayoutPanel1.TabIndex = 12;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // formula
            // 
            this.formula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formula.Location = new System.Drawing.Point(1, 109);
            this.formula.Margin = new System.Windows.Forms.Padding(1);
            this.formula.Name = "formula";
            this.formula.Size = new System.Drawing.Size(244, 129);
            this.formula.TabIndex = 14;
            this.formula.Load += new System.EventHandler(this.formula_Load);
            // 
            // parameters
            // 
            this.parameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parameters.Location = new System.Drawing.Point(253, 114);
            this.parameters.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.parameters.Name = "parameters";
            this.parameters.Size = new System.Drawing.Size(132, 119);
            this.parameters.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(444, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Список параметров";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateWorkTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 297);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CreateWorkTypeForm";
            this.Text = "Создать тип работ";
            this.Load += new System.EventHandler(this.CreateWorkTypeForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Listofparams;
        private System.Windows.Forms.TextBox WorkTypeNameInp;
        private System.Windows.Forms.Label WorkTypeName;
        private System.Windows.Forms.Label formulat;
        private System.Windows.Forms.Label ParamsT;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.Label CategoryT;
        internal System.Windows.Forms.Button AddType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FormComponents.TextwithBut parameters;
        private System.Windows.Forms.Label label1;
        private FormComponents.TextWithOperations formula;
    }
}