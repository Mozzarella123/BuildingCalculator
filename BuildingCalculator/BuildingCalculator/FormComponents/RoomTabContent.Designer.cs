namespace BuildingCalculator.FormComponents
{
    partial class RoomTabContent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.worksTypeTree1 = new BuildingCalculator.FormComponents.WorksTypeTree();
            this.MarkUp = new System.Windows.Forms.TableLayoutPanel();
            this.RoomTypeSelect = new System.Windows.Forms.ComboBox();
            this.RoomTypeT = new System.Windows.Forms.Label();
            this.TypeTabs = new System.Windows.Forms.TabControl();
            this.StandardRoom = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.RoomMarkup = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WidthInp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HeightInp = new System.Windows.Forms.TextBox();
            this.LengthInp = new System.Windows.Forms.TextBox();
            this.worktable = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.None_StandardRoom = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomMarkUp2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.AddElement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.MarkUp.SuspendLayout();
            this.TypeTabs.SuspendLayout();
            this.StandardRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.RoomMarkup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worktable)).BeginInit();
            this.None_StandardRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.RoomMarkUp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.worksTypeTree1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.MarkUp);
            this.splitContainer1.Size = new System.Drawing.Size(1148, 566);
            this.splitContainer1.SplitterDistance = 298;
            this.splitContainer1.TabIndex = 0;
            // 
            // worksTypeTree1
            // 
            this.worksTypeTree1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.worksTypeTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.worksTypeTree1.Location = new System.Drawing.Point(0, 0);
            this.worksTypeTree1.Name = "worksTypeTree1";
            this.worksTypeTree1.Padding = new System.Windows.Forms.Padding(3);
            this.worksTypeTree1.Size = new System.Drawing.Size(298, 566);
            this.worksTypeTree1.TabIndex = 0;
            // 
            // MarkUp
            // 
            this.MarkUp.AutoScroll = true;
            this.MarkUp.BackColor = System.Drawing.SystemColors.Window;
            this.MarkUp.ColumnCount = 3;
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 332F));
            this.MarkUp.Controls.Add(this.RoomTypeSelect, 1, 0);
            this.MarkUp.Controls.Add(this.RoomTypeT, 0, 0);
            this.MarkUp.Controls.Add(this.TypeTabs, 0, 1);
            this.MarkUp.Controls.Add(this.AddElement, 2, 0);
            this.MarkUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarkUp.Location = new System.Drawing.Point(0, 0);
            this.MarkUp.Name = "MarkUp";
            this.MarkUp.RowCount = 2;
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MarkUp.Size = new System.Drawing.Size(846, 566);
            this.MarkUp.TabIndex = 0;
            this.MarkUp.Paint += new System.Windows.Forms.PaintEventHandler(this.MarkUp_Paint);
            // 
            // RoomTypeSelect
            // 
            this.RoomTypeSelect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RoomTypeSelect.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomTypeSelect.FormattingEnabled = true;
            this.RoomTypeSelect.Items.AddRange(new object[] {
            "Стандартный",
            "Нестандартный"});
            this.RoomTypeSelect.Location = new System.Drawing.Point(233, 6);
            this.RoomTypeSelect.Name = "RoomTypeSelect";
            this.RoomTypeSelect.Size = new System.Drawing.Size(278, 37);
            this.RoomTypeSelect.TabIndex = 0;
            this.RoomTypeSelect.SelectedIndexChanged += new System.EventHandler(this.RoomTypeSelect_SelectedIndexChanged);
            // 
            // RoomTypeT
            // 
            this.RoomTypeT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RoomTypeT.AutoSize = true;
            this.RoomTypeT.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomTypeT.Location = new System.Drawing.Point(71, 10);
            this.RoomTypeT.Margin = new System.Windows.Forms.Padding(3);
            this.RoomTypeT.Name = "RoomTypeT";
            this.RoomTypeT.Size = new System.Drawing.Size(156, 29);
            this.RoomTypeT.TabIndex = 1;
            this.RoomTypeT.Text = "Тип комнаты";
            this.RoomTypeT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TypeTabs
            // 
            this.TypeTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.MarkUp.SetColumnSpan(this.TypeTabs, 3);
            this.TypeTabs.Controls.Add(this.StandardRoom);
            this.TypeTabs.Controls.Add(this.None_StandardRoom);
            this.TypeTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeTabs.Location = new System.Drawing.Point(3, 53);
            this.TypeTabs.Name = "TypeTabs";
            this.TypeTabs.SelectedIndex = 0;
            this.TypeTabs.Size = new System.Drawing.Size(840, 510);
            this.TypeTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TypeTabs.TabIndex = 2;
            this.TypeTabs.TabStop = false;
            // 
            // StandardRoom
            // 
            this.StandardRoom.AutoScroll = true;
            this.StandardRoom.BackColor = System.Drawing.SystemColors.Window;
            this.StandardRoom.Controls.Add(this.splitContainer2);
            this.StandardRoom.Location = new System.Drawing.Point(4, 32);
            this.StandardRoom.Name = "StandardRoom";
            this.StandardRoom.Padding = new System.Windows.Forms.Padding(3);
            this.StandardRoom.Size = new System.Drawing.Size(832, 474);
            this.StandardRoom.TabIndex = 0;
            this.StandardRoom.Text = "tabPage1";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.RoomMarkup);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.worktable);
            this.splitContainer2.Size = new System.Drawing.Size(826, 468);
            this.splitContainer2.SplitterDistance = 70;
            this.splitContainer2.TabIndex = 2;
            // 
            // RoomMarkup
            // 
            this.RoomMarkup.AutoSize = true;
            this.RoomMarkup.ColumnCount = 7;
            this.RoomMarkup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.RoomMarkup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.RoomMarkup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.RoomMarkup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.RoomMarkup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.RoomMarkup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.RoomMarkup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.RoomMarkup.Controls.Add(this.label2, 0, 0);
            this.RoomMarkup.Controls.Add(this.label3, 1, 0);
            this.RoomMarkup.Controls.Add(this.label4, 3, 0);
            this.RoomMarkup.Controls.Add(this.WidthInp, 4, 0);
            this.RoomMarkup.Controls.Add(this.label5, 5, 0);
            this.RoomMarkup.Controls.Add(this.HeightInp, 6, 0);
            this.RoomMarkup.Controls.Add(this.LengthInp, 2, 0);
            this.RoomMarkup.Dock = System.Windows.Forms.DockStyle.Top;
            this.RoomMarkup.Location = new System.Drawing.Point(0, 0);
            this.RoomMarkup.Name = "RoomMarkup";
            this.RoomMarkup.RowCount = 1;
            this.RoomMarkup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RoomMarkup.Size = new System.Drawing.Size(826, 64);
            this.RoomMarkup.TabIndex = 0;
            this.RoomMarkup.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.RoomMarkup_ControlRemoved);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 58);
            this.label2.TabIndex = 0;
            this.label2.Text = "Параметры комнаты";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(153, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Длина";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(348, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ширина";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WidthInp
            // 
            this.WidthInp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WidthInp.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthInp.Location = new System.Drawing.Point(454, 14);
            this.WidthInp.Name = "WidthInp";
            this.WidthInp.Size = new System.Drawing.Size(100, 36);
            this.WidthInp.TabIndex = 4;
            this.WidthInp.TextChanged += new System.EventHandler(this.LengthInp_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(560, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Высота";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightInp
            // 
            this.HeightInp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HeightInp.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightInp.Location = new System.Drawing.Point(661, 14);
            this.HeightInp.Name = "HeightInp";
            this.HeightInp.Size = new System.Drawing.Size(110, 36);
            this.HeightInp.TabIndex = 6;
            this.HeightInp.TextChanged += new System.EventHandler(this.LengthInp_TextChanged);
            // 
            // LengthInp
            // 
            this.LengthInp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LengthInp.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthInp.Location = new System.Drawing.Point(242, 14);
            this.LengthInp.Name = "LengthInp";
            this.LengthInp.Size = new System.Drawing.Size(100, 36);
            this.LengthInp.TabIndex = 1;
            this.LengthInp.TextChanged += new System.EventHandler(this.LengthInp_TextChanged);
            // 
            // worktable
            // 
            this.worktable.AllowUserToOrderColumns = true;
            this.worktable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.worktable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.worktable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.worktable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.worktable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Count,
            this.Price,
            this.Summ});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.worktable.DefaultCellStyle = dataGridViewCellStyle2;
            this.worktable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.worktable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.worktable.Location = new System.Drawing.Point(0, 0);
            this.worktable.Name = "worktable";
            this.worktable.RowHeadersVisible = false;
            this.worktable.RowTemplate.Height = 28;
            this.worktable.Size = new System.Drawing.Size(826, 394);
            this.worktable.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.HeaderText = "Наименование работ";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.HeaderText = "Кол-во";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Summ
            // 
            this.Summ.HeaderText = "Сумма";
            this.Summ.Name = "Summ";
            this.Summ.ReadOnly = true;
            this.Summ.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // None_StandardRoom
            // 
            this.None_StandardRoom.BackColor = System.Drawing.SystemColors.Window;
            this.None_StandardRoom.Controls.Add(this.dataGridView2);
            this.None_StandardRoom.Controls.Add(this.RoomMarkUp2);
            this.None_StandardRoom.Location = new System.Drawing.Point(4, 32);
            this.None_StandardRoom.Name = "None_StandardRoom";
            this.None_StandardRoom.Padding = new System.Windows.Forms.Padding(3);
            this.None_StandardRoom.Size = new System.Drawing.Size(832, 474);
            this.None_StandardRoom.TabIndex = 1;
            this.None_StandardRoom.Text = "tabPage2";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView2.Location = new System.Drawing.Point(3, 101);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(826, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Наименование работ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 189;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Кол-во";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 97;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 84;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 94;
            // 
            // RoomMarkUp2
            // 
            this.RoomMarkUp2.AutoScroll = true;
            this.RoomMarkUp2.ColumnCount = 7;
            this.RoomMarkUp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.RoomMarkUp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.RoomMarkUp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.RoomMarkUp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.RoomMarkUp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.RoomMarkUp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.RoomMarkUp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.RoomMarkUp2.Controls.Add(this.label1, 0, 0);
            this.RoomMarkUp2.Controls.Add(this.label7, 3, 0);
            this.RoomMarkUp2.Controls.Add(this.textBox4, 4, 0);
            this.RoomMarkUp2.Controls.Add(this.label8, 5, 0);
            this.RoomMarkUp2.Controls.Add(this.textBox5, 6, 0);
            this.RoomMarkUp2.Controls.Add(this.label6, 1, 0);
            this.RoomMarkUp2.Controls.Add(this.textBox6, 2, 0);
            this.RoomMarkUp2.Dock = System.Windows.Forms.DockStyle.Top;
            this.RoomMarkUp2.Location = new System.Drawing.Point(3, 3);
            this.RoomMarkUp2.Name = "RoomMarkUp2";
            this.RoomMarkUp2.RowCount = 1;
            this.RoomMarkUp2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RoomMarkUp2.Size = new System.Drawing.Size(826, 98);
            this.RoomMarkUp2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметры комнаты";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(387, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "Площадь пола";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(568, 31);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 36);
            this.textBox4.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(674, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 29);
            this.label8.TabIndex = 5;
            this.label8.Text = "Площадь потолка";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox5.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(891, 31);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(107, 36);
            this.textBox5.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(153, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Периметр";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(281, 31);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 36);
            this.textBox6.TabIndex = 1;
            // 
            // AddElement
            // 
            this.AddElement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddElement.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddElement.Location = new System.Drawing.Point(559, 3);
            this.AddElement.Name = "AddElement";
            this.AddElement.Size = new System.Drawing.Size(284, 44);
            this.AddElement.TabIndex = 3;
            this.AddElement.Text = "Добавить элемент";
            this.AddElement.UseVisualStyleBackColor = true;
            this.AddElement.Click += new System.EventHandler(this.AddElement_Click);
            // 
            // RoomTabContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.splitContainer1);
            this.Name = "RoomTabContent";
            this.Size = new System.Drawing.Size(1148, 566);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.MarkUp.ResumeLayout(false);
            this.MarkUp.PerformLayout();
            this.TypeTabs.ResumeLayout(false);
            this.StandardRoom.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.RoomMarkup.ResumeLayout(false);
            this.RoomMarkup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worktable)).EndInit();
            this.None_StandardRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.RoomMarkUp2.ResumeLayout(false);
            this.RoomMarkUp2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public WorksTypeTree worksTypeTree1;
        private System.Windows.Forms.TableLayoutPanel MarkUp;
        private System.Windows.Forms.ComboBox RoomTypeSelect;
        private System.Windows.Forms.Label RoomTypeT;
        private System.Windows.Forms.TabControl TypeTabs;
        private System.Windows.Forms.TabPage StandardRoom;
        private System.Windows.Forms.TabPage None_StandardRoom;
        private System.Windows.Forms.TableLayoutPanel RoomMarkup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddElement;
        private System.Windows.Forms.TableLayoutPanel RoomMarkUp2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        public System.Windows.Forms.TextBox LengthInp;
        public System.Windows.Forms.TextBox WidthInp;
        public System.Windows.Forms.TextBox HeightInp;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summ;
        public System.Windows.Forms.DataGridView worktable;
    }
}
