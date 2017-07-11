namespace BuildingCalculator.FormComponents
{
    partial class NewForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.InputParamsTab = new System.Windows.Forms.TabPage();
            this.RoomTabs = new System.Windows.Forms.TabControl();
            this.FirstRoom = new System.Windows.Forms.TabPage();
            this.roomTabContent1 = new BuildingCalculator.FormComponents.RoomTabContent();
            this.AddRoomTab = new System.Windows.Forms.TabPage();
            this.ViewTab = new System.Windows.Forms.TabPage();
            this.finaltable = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.SettingTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.RepotRooms = new System.Windows.Forms.CheckBox();
            this.SaveSetBut = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.CheckBox();
            this.ChangeSaveDirectory = new System.Windows.Forms.Button();
            this.UnitsT = new System.Windows.Forms.Label();
            this.SaveDirectoryInp = new System.Windows.Forms.TextBox();
            this.Units = new System.Windows.Forms.Panel();
            this.mRadio = new System.Windows.Forms.RadioButton();
            this.cmRadio = new System.Windows.Forms.RadioButton();
            this.SaveDirectoryT = new System.Windows.Forms.Label();
            this.AdminTable = new System.Windows.Forms.TableLayoutPanel();
            this.WorksListLabel = new System.Windows.Forms.Label();
            this.DownloadfromExcel = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.AdminWorks = new BuildingCalculator.FormComponents.WorksTypeTree();
            this.MenuMarkup = new System.Windows.Forms.TableLayoutPanel();
            this.InputParamsBut = new System.Windows.Forms.Button();
            this.ViewBut = new System.Windows.Forms.Button();
            this.SettingsBut = new System.Windows.Forms.Button();
            this.RoomResT = new System.Windows.Forms.Label();
            this.CreateReportBut = new System.Windows.Forms.Button();
            this.RefreshTable = new System.Windows.Forms.Button();
            this.SummT = new System.Windows.Forms.Label();
            this.ExcelDownloadDialog = new System.Windows.Forms.OpenFileDialog();
            this.SelectReportDirDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.MainTabs.SuspendLayout();
            this.InputParamsTab.SuspendLayout();
            this.RoomTabs.SuspendLayout();
            this.FirstRoom.SuspendLayout();
            this.ViewTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finaltable)).BeginInit();
            this.SettingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.Units.SuspendLayout();
            this.AdminTable.SuspendLayout();
            this.MenuMarkup.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.MainTabs);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MenuMarkup);
            this.splitContainer1.Size = new System.Drawing.Size(1077, 583);
            this.splitContainer1.SplitterDistance = 914;
            this.splitContainer1.TabIndex = 0;
            // 
            // MainTabs
            // 
            this.MainTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.MainTabs.Controls.Add(this.InputParamsTab);
            this.MainTabs.Controls.Add(this.ViewTab);
            this.MainTabs.Controls.Add(this.SettingTab);
            this.MainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabs.Location = new System.Drawing.Point(0, 0);
            this.MainTabs.Margin = new System.Windows.Forms.Padding(0);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(914, 583);
            this.MainTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTabs.TabIndex = 0;
            this.MainTabs.TabStop = false;
            // 
            // InputParamsTab
            // 
            this.InputParamsTab.AutoScroll = true;
            this.InputParamsTab.Controls.Add(this.RoomTabs);
            this.InputParamsTab.Location = new System.Drawing.Point(4, 32);
            this.InputParamsTab.Name = "InputParamsTab";
            this.InputParamsTab.Padding = new System.Windows.Forms.Padding(3);
            this.InputParamsTab.Size = new System.Drawing.Size(906, 547);
            this.InputParamsTab.TabIndex = 0;
            this.InputParamsTab.Text = "Ввод данных";
            this.InputParamsTab.UseVisualStyleBackColor = true;
            // 
            // RoomTabs
            // 
            this.RoomTabs.Controls.Add(this.FirstRoom);
            this.RoomTabs.Controls.Add(this.AddRoomTab);
            this.RoomTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomTabs.Location = new System.Drawing.Point(3, 3);
            this.RoomTabs.Margin = new System.Windows.Forms.Padding(0);
            this.RoomTabs.Name = "RoomTabs";
            this.RoomTabs.SelectedIndex = 0;
            this.RoomTabs.Size = new System.Drawing.Size(900, 541);
            this.RoomTabs.TabIndex = 0;
            this.RoomTabs.SelectedIndexChanged += new System.EventHandler(this.RoomTabs_SelectedIndexChanged);
            this.RoomTabs.DoubleClick += new System.EventHandler(this.RoomTabs_DoubleClick);
            // 
            // FirstRoom
            // 
            this.FirstRoom.Controls.Add(this.roomTabContent1);
            this.FirstRoom.Location = new System.Drawing.Point(4, 29);
            this.FirstRoom.Name = "FirstRoom";
            this.FirstRoom.Padding = new System.Windows.Forms.Padding(3);
            this.FirstRoom.Size = new System.Drawing.Size(892, 508);
            this.FirstRoom.TabIndex = 0;
            this.FirstRoom.Text = "Комната";
            this.FirstRoom.UseVisualStyleBackColor = true;
            // 
            // roomTabContent1
            // 
            this.roomTabContent1.AutoScroll = true;
            this.roomTabContent1.BackColor = System.Drawing.SystemColors.Window;
            this.roomTabContent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomTabContent1.Location = new System.Drawing.Point(3, 3);
            this.roomTabContent1.Name = "roomTabContent1";
            this.roomTabContent1.Size = new System.Drawing.Size(886, 502);
            this.roomTabContent1.TabIndex = 0;
            // 
            // AddRoomTab
            // 
            this.AddRoomTab.Location = new System.Drawing.Point(4, 29);
            this.AddRoomTab.Name = "AddRoomTab";
            this.AddRoomTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddRoomTab.Size = new System.Drawing.Size(892, 508);
            this.AddRoomTab.TabIndex = 1;
            this.AddRoomTab.Text = "+";
            this.AddRoomTab.UseVisualStyleBackColor = true;
            // 
            // ViewTab
            // 
            this.ViewTab.AutoScroll = true;
            this.ViewTab.Controls.Add(this.finaltable);
            this.ViewTab.Controls.Add(this.label3);
            this.ViewTab.Location = new System.Drawing.Point(4, 32);
            this.ViewTab.Name = "ViewTab";
            this.ViewTab.Size = new System.Drawing.Size(906, 547);
            this.ViewTab.TabIndex = 2;
            this.ViewTab.Text = "Просмотр";
            this.ViewTab.UseVisualStyleBackColor = true;
            // 
            // finaltable
            // 
            this.finaltable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.finaltable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.finaltable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.finaltable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Count,
            this.Price,
            this.Summ});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.finaltable.DefaultCellStyle = dataGridViewCellStyle2;
            this.finaltable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finaltable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.finaltable.Location = new System.Drawing.Point(0, 0);
            this.finaltable.Name = "finaltable";
            this.finaltable.RowHeadersVisible = false;
            this.finaltable.RowTemplate.Height = 28;
            this.finaltable.Size = new System.Drawing.Size(906, 547);
            this.finaltable.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.HeaderText = "Наименование";
            this.Title.Name = "Title";
            // 
            // Count
            // 
            this.Count.HeaderText = "Кол-во";
            this.Count.Name = "Count";
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            // 
            // Summ
            // 
            this.Summ.HeaderText = "Сумма";
            this.Summ.Name = "Summ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Просмотр";
            // 
            // SettingTab
            // 
            this.SettingTab.AutoScroll = true;
            this.SettingTab.Controls.Add(this.splitContainer2);
            this.SettingTab.Location = new System.Drawing.Point(4, 32);
            this.SettingTab.Name = "SettingTab";
            this.SettingTab.Size = new System.Drawing.Size(906, 547);
            this.SettingTab.TabIndex = 3;
            this.SettingTab.Text = "Настройки";
            this.SettingTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.RepotRooms);
            this.splitContainer2.Panel1.Controls.Add(this.SaveSetBut);
            this.splitContainer2.Panel1.Controls.Add(this.Help);
            this.splitContainer2.Panel1.Controls.Add(this.ChangeSaveDirectory);
            this.splitContainer2.Panel1.Controls.Add(this.UnitsT);
            this.splitContainer2.Panel1.Controls.Add(this.SaveDirectoryInp);
            this.splitContainer2.Panel1.Controls.Add(this.Units);
            this.splitContainer2.Panel1.Controls.Add(this.SaveDirectoryT);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.AdminTable);
            this.splitContainer2.Panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.splitContainer2_Panel2_MouseClick);
            this.splitContainer2.Size = new System.Drawing.Size(906, 547);
            this.splitContainer2.SplitterDistance = 474;
            this.splitContainer2.TabIndex = 9;
            // 
            // RepotRooms
            // 
            this.RepotRooms.AutoSize = true;
            this.RepotRooms.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepotRooms.Location = new System.Drawing.Point(20, 174);
            this.RepotRooms.Name = "RepotRooms";
            this.RepotRooms.Size = new System.Drawing.Size(351, 33);
            this.RepotRooms.TabIndex = 10;
            this.RepotRooms.Text = "Разбивать отчёт по формам";
            this.RepotRooms.UseVisualStyleBackColor = true;
            // 
            // SaveSetBut
            // 
            this.SaveSetBut.Location = new System.Drawing.Point(19, 284);
            this.SaveSetBut.Name = "SaveSetBut";
            this.SaveSetBut.Size = new System.Drawing.Size(202, 38);
            this.SaveSetBut.TabIndex = 9;
            this.SaveSetBut.Text = "Сохранить настройки";
            this.SaveSetBut.UseVisualStyleBackColor = true;
            this.SaveSetBut.Click += new System.EventHandler(this.SaveSetBut_Click);
            // 
            // Help
            // 
            this.Help.AutoSize = true;
            this.Help.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Help.Location = new System.Drawing.Point(19, 25);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(337, 33);
            this.Help.TabIndex = 2;
            this.Help.Text = "Включить режим обучения";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // ChangeSaveDirectory
            // 
            this.ChangeSaveDirectory.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeSaveDirectory.Location = new System.Drawing.Point(241, 241);
            this.ChangeSaveDirectory.Margin = new System.Windows.Forms.Padding(0);
            this.ChangeSaveDirectory.Name = "ChangeSaveDirectory";
            this.ChangeSaveDirectory.Size = new System.Drawing.Size(166, 40);
            this.ChangeSaveDirectory.TabIndex = 8;
            this.ChangeSaveDirectory.Text = "Изменить";
            this.ChangeSaveDirectory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ChangeSaveDirectory.UseVisualStyleBackColor = true;
            this.ChangeSaveDirectory.Click += new System.EventHandler(this.ChangeSaveDirectory_Click);
            // 
            // UnitsT
            // 
            this.UnitsT.AutoSize = true;
            this.UnitsT.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnitsT.Location = new System.Drawing.Point(15, 61);
            this.UnitsT.Name = "UnitsT";
            this.UnitsT.Size = new System.Drawing.Size(237, 29);
            this.UnitsT.TabIndex = 4;
            this.UnitsT.Text = "Единицы измерения";
            // 
            // SaveDirectoryInp
            // 
            this.SaveDirectoryInp.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveDirectoryInp.Location = new System.Drawing.Point(19, 242);
            this.SaveDirectoryInp.Multiline = true;
            this.SaveDirectoryInp.Name = "SaveDirectoryInp";
            this.SaveDirectoryInp.ReadOnly = true;
            this.SaveDirectoryInp.Size = new System.Drawing.Size(206, 36);
            this.SaveDirectoryInp.TabIndex = 7;
            // 
            // Units
            // 
            this.Units.Controls.Add(this.mRadio);
            this.Units.Controls.Add(this.cmRadio);
            this.Units.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Units.Location = new System.Drawing.Point(20, 95);
            this.Units.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Units.Name = "Units";
            this.Units.Size = new System.Drawing.Size(188, 71);
            this.Units.TabIndex = 5;
            // 
            // mRadio
            // 
            this.mRadio.AutoSize = true;
            this.mRadio.Checked = true;
            this.mRadio.Location = new System.Drawing.Point(6, 37);
            this.mRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mRadio.Name = "mRadio";
            this.mRadio.Size = new System.Drawing.Size(113, 33);
            this.mRadio.TabIndex = 1;
            this.mRadio.TabStop = true;
            this.mRadio.Text = "Метры";
            this.mRadio.UseVisualStyleBackColor = true;
            // 
            // cmRadio
            // 
            this.cmRadio.AutoSize = true;
            this.cmRadio.Location = new System.Drawing.Point(6, 5);
            this.cmRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmRadio.Name = "cmRadio";
            this.cmRadio.Size = new System.Drawing.Size(176, 33);
            this.cmRadio.TabIndex = 0;
            this.cmRadio.Text = "Сантиметры";
            this.cmRadio.UseVisualStyleBackColor = true;
            // 
            // SaveDirectoryT
            // 
            this.SaveDirectoryT.AutoSize = true;
            this.SaveDirectoryT.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveDirectoryT.Location = new System.Drawing.Point(15, 210);
            this.SaveDirectoryT.Name = "SaveDirectoryT";
            this.SaveDirectoryT.Size = new System.Drawing.Size(294, 29);
            this.SaveDirectoryT.TabIndex = 6;
            this.SaveDirectoryT.Text = "Место сохранения отчёта";
            // 
            // AdminTable
            // 
            this.AdminTable.ColumnCount = 2;
            this.AdminTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.64935F));
            this.AdminTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.35065F));
            this.AdminTable.Controls.Add(this.WorksListLabel, 0, 0);
            this.AdminTable.Controls.Add(this.DownloadfromExcel, 0, 1);
            this.AdminTable.Controls.Add(this.Clear, 1, 1);
            this.AdminTable.Controls.Add(this.AdminWorks, 0, 2);
            this.AdminTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminTable.Enabled = false;
            this.AdminTable.Location = new System.Drawing.Point(0, 0);
            this.AdminTable.Name = "AdminTable";
            this.AdminTable.RowCount = 4;
            this.AdminTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.719851F));
            this.AdminTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.98701F));
            this.AdminTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.AdminTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.95454F));
            this.AdminTable.Size = new System.Drawing.Size(428, 547);
            this.AdminTable.TabIndex = 5;
            // 
            // WorksListLabel
            // 
            this.WorksListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.WorksListLabel.AutoSize = true;
            this.AdminTable.SetColumnSpan(this.WorksListLabel, 2);
            this.WorksListLabel.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorksListLabel.Location = new System.Drawing.Point(133, 10);
            this.WorksListLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.WorksListLabel.Name = "WorksListLabel";
            this.WorksListLabel.Size = new System.Drawing.Size(161, 27);
            this.WorksListLabel.TabIndex = 2;
            this.WorksListLabel.Text = "Список работ";
            // 
            // DownloadfromExcel
            // 
            this.DownloadfromExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DownloadfromExcel.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownloadfromExcel.Location = new System.Drawing.Point(3, 50);
            this.DownloadfromExcel.Name = "DownloadfromExcel";
            this.DownloadfromExcel.Size = new System.Drawing.Size(210, 64);
            this.DownloadfromExcel.TabIndex = 4;
            this.DownloadfromExcel.Text = "Загрузить из Excel";
            this.DownloadfromExcel.UseVisualStyleBackColor = true;
            this.DownloadfromExcel.Click += new System.EventHandler(this.DownloadfromExcel_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Clear.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(219, 50);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(206, 64);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Очистить список";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // AdminWorks
            // 
            this.AdminWorks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdminTable.SetColumnSpan(this.AdminWorks, 2);
            this.AdminWorks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminWorks.Location = new System.Drawing.Point(3, 120);
            this.AdminWorks.Name = "AdminWorks";
            this.AdminWorks.Padding = new System.Windows.Forms.Padding(3);
            this.AdminTable.SetRowSpan(this.AdminWorks, 2);
            this.AdminWorks.Size = new System.Drawing.Size(422, 424);
            this.AdminWorks.TabIndex = 6;
            // 
            // MenuMarkup
            // 
            this.MenuMarkup.AutoScroll = true;
            this.MenuMarkup.ColumnCount = 1;
            this.MenuMarkup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MenuMarkup.Controls.Add(this.InputParamsBut, 0, 0);
            this.MenuMarkup.Controls.Add(this.ViewBut, 0, 1);
            this.MenuMarkup.Controls.Add(this.SettingsBut, 0, 2);
            this.MenuMarkup.Controls.Add(this.RoomResT, 0, 5);
            this.MenuMarkup.Controls.Add(this.CreateReportBut, 0, 4);
            this.MenuMarkup.Controls.Add(this.RefreshTable, 0, 3);
            this.MenuMarkup.Controls.Add(this.SummT, 0, 6);
            this.MenuMarkup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuMarkup.Location = new System.Drawing.Point(0, 0);
            this.MenuMarkup.Name = "MenuMarkup";
            this.MenuMarkup.RowCount = 7;
            this.MenuMarkup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MenuMarkup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MenuMarkup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MenuMarkup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuMarkup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuMarkup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuMarkup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuMarkup.Size = new System.Drawing.Size(159, 583);
            this.MenuMarkup.TabIndex = 0;
            this.MenuMarkup.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuMarkup_Paint);
            // 
            // InputParamsBut
            // 
            this.InputParamsBut.BackColor = System.Drawing.Color.LightGray;
            this.InputParamsBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputParamsBut.FlatAppearance.BorderSize = 0;
            this.InputParamsBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputParamsBut.Location = new System.Drawing.Point(0, 0);
            this.InputParamsBut.Margin = new System.Windows.Forms.Padding(0);
            this.InputParamsBut.Name = "InputParamsBut";
            this.InputParamsBut.Size = new System.Drawing.Size(159, 50);
            this.InputParamsBut.TabIndex = 0;
            this.InputParamsBut.Text = "Ввод данных";
            this.InputParamsBut.UseVisualStyleBackColor = false;
            this.InputParamsBut.Click += new System.EventHandler(this.MenuClick);
            // 
            // ViewBut
            // 
            this.ViewBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewBut.FlatAppearance.BorderSize = 0;
            this.ViewBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewBut.Location = new System.Drawing.Point(0, 50);
            this.ViewBut.Margin = new System.Windows.Forms.Padding(0);
            this.ViewBut.Name = "ViewBut";
            this.ViewBut.Size = new System.Drawing.Size(159, 50);
            this.ViewBut.TabIndex = 1;
            this.ViewBut.Text = "Просмотр";
            this.ViewBut.UseVisualStyleBackColor = true;
            this.ViewBut.Click += new System.EventHandler(this.MenuClick);
            // 
            // SettingsBut
            // 
            this.SettingsBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsBut.FlatAppearance.BorderSize = 0;
            this.SettingsBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBut.Location = new System.Drawing.Point(0, 100);
            this.SettingsBut.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsBut.Name = "SettingsBut";
            this.SettingsBut.Size = new System.Drawing.Size(159, 50);
            this.SettingsBut.TabIndex = 2;
            this.SettingsBut.Text = "Настройки";
            this.SettingsBut.UseVisualStyleBackColor = true;
            this.SettingsBut.Click += new System.EventHandler(this.MenuClick);
            // 
            // RoomResT
            // 
            this.RoomResT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoomResT.AutoSize = true;
            this.RoomResT.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomResT.Location = new System.Drawing.Point(3, 294);
            this.RoomResT.Name = "RoomResT";
            this.RoomResT.Size = new System.Drawing.Size(153, 24);
            this.RoomResT.TabIndex = 6;
            // 
            // CreateReportBut
            // 
            this.CreateReportBut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateReportBut.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateReportBut.Location = new System.Drawing.Point(3, 209);
            this.CreateReportBut.Name = "CreateReportBut";
            this.CreateReportBut.Size = new System.Drawing.Size(153, 82);
            this.CreateReportBut.TabIndex = 3;
            this.CreateReportBut.Text = "Создать отчет";
            this.CreateReportBut.UseVisualStyleBackColor = true;
            this.CreateReportBut.Click += new System.EventHandler(this.CreateReportBut_Click);
            // 
            // RefreshTable
            // 
            this.RefreshTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshTable.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshTable.Location = new System.Drawing.Point(3, 153);
            this.RefreshTable.Name = "RefreshTable";
            this.RefreshTable.Size = new System.Drawing.Size(153, 50);
            this.RefreshTable.TabIndex = 5;
            this.RefreshTable.Text = "Обновить";
            this.RefreshTable.UseVisualStyleBackColor = true;
            this.RefreshTable.Click += new System.EventHandler(this.RefreshTable_Click);
            // 
            // SummT
            // 
            this.SummT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SummT.AutoSize = true;
            this.SummT.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SummT.Location = new System.Drawing.Point(3, 559);
            this.SummT.Name = "SummT";
            this.SummT.Size = new System.Drawing.Size(153, 24);
            this.SummT.TabIndex = 7;
            // 
            // ExcelDownloadDialog
            // 
            this.ExcelDownloadDialog.FileName = "openFileDialog1";
            this.ExcelDownloadDialog.Filter = "Excel Таблица|*.xls;*.xlsx;\"";
            this.ExcelDownloadDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 583);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.MainTabs.ResumeLayout(false);
            this.InputParamsTab.ResumeLayout(false);
            this.RoomTabs.ResumeLayout(false);
            this.FirstRoom.ResumeLayout(false);
            this.ViewTab.ResumeLayout(false);
            this.ViewTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finaltable)).EndInit();
            this.SettingTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.Units.ResumeLayout(false);
            this.Units.PerformLayout();
            this.AdminTable.ResumeLayout(false);
            this.AdminTable.PerformLayout();
            this.MenuMarkup.ResumeLayout(false);
            this.MenuMarkup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel MenuMarkup;
        private System.Windows.Forms.Button InputParamsBut;
        private System.Windows.Forms.Button ViewBut;
        private System.Windows.Forms.Button SettingsBut;
        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.TabPage InputParamsTab;
        private System.Windows.Forms.TabControl RoomTabs;
        private System.Windows.Forms.TabPage FirstRoom;
        private System.Windows.Forms.TabPage AddRoomTab;
        private System.Windows.Forms.TabPage ViewTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage SettingTab;
        private RoomTabContent roomTabContent1;
        private System.Windows.Forms.CheckBox Help;
        private System.Windows.Forms.Label UnitsT;
        private System.Windows.Forms.Panel Units;
        private System.Windows.Forms.RadioButton mRadio;
        private System.Windows.Forms.RadioButton cmRadio;
        private System.Windows.Forms.Button ChangeSaveDirectory;
        private System.Windows.Forms.TextBox SaveDirectoryInp;
        private System.Windows.Forms.Label SaveDirectoryT;
        private System.Windows.Forms.DataGridView finaltable;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel AdminTable;
        private System.Windows.Forms.Label WorksListLabel;
        private System.Windows.Forms.Button DownloadfromExcel;
        private System.Windows.Forms.Button Clear;
        private WorksTypeTree AdminWorks;
        private System.Windows.Forms.OpenFileDialog ExcelDownloadDialog;
        private System.Windows.Forms.Button SaveSetBut;
        private System.Windows.Forms.FolderBrowserDialog SelectReportDirDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summ;
        private System.Windows.Forms.Button CreateReportBut;
        private System.Windows.Forms.CheckBox RepotRooms;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button RefreshTable;
        public System.Windows.Forms.Label RoomResT;
        private System.Windows.Forms.Label SummT;
    }
}