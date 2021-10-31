namespace CourseCrawler
{
    partial class CourseManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseManagementForm));
            this.CommingSoonLabel = new System.Windows.Forms.Label();
            this.ManagementTabControll = new System.Windows.Forms.TabControl();
            this.CourseManageTabPage = new System.Windows.Forms.TabPage();
            this.SaveCourseButton = new System.Windows.Forms.Button();
            this.CourseListBox = new System.Windows.Forms.ListBox();
            this.EditCourseGroupBox = new System.Windows.Forms.GroupBox();
            this.CourseClassComboBox = new System.Windows.Forms.ComboBox();
            this.CourseClassLabel = new System.Windows.Forms.Label();
            this.CourseHourComboBox = new System.Windows.Forms.ComboBox();
            this.CourseHourLabel = new System.Windows.Forms.Label();
            this.CourseRemarkTextBox = new System.Windows.Forms.TextBox();
            this.CourseRemarkLabel = new System.Windows.Forms.Label();
            this.CourseLanguageTextBox = new System.Windows.Forms.TextBox();
            this.CourseLanguageLabel = new System.Windows.Forms.Label();
            this.CourseTAsTextBox = new System.Windows.Forms.TextBox();
            this.CourseTAsLabel = new System.Windows.Forms.Label();
            this.CourseTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CourseTypeLabel = new System.Windows.Forms.Label();
            this.CourseTeacherTextBox = new System.Windows.Forms.TextBox();
            this.CourseTeacherLabel = new System.Windows.Forms.Label();
            this.CourseCreditTextBox = new System.Windows.Forms.TextBox();
            this.CourseCreditLabel = new System.Windows.Forms.Label();
            this.CourseLevelTextBox = new System.Windows.Forms.TextBox();
            this.CourseNameTextBox = new System.Windows.Forms.TextBox();
            this.CourseNumberTextBox = new System.Windows.Forms.TextBox();
            this.CourseLevelLabel = new System.Windows.Forms.Label();
            this.CourseNameLabel = new System.Windows.Forms.Label();
            this.CourseNumberLabel = new System.Windows.Forms.Label();
            this.CourseEnabledComboBox = new System.Windows.Forms.ComboBox();
            this.CourseWeekTimeCheckBoxGridView = new System.Windows.Forms.DataGridView();
            this.CourseSectionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SundaySectionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MondaySectionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TuesdaySectionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.WednesdaySectionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ThursdaySectionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FridaySectionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SaturdaySectionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.ClassManageTabPage = new System.Windows.Forms.TabPage();
            this.ManagementTabControll.SuspendLayout();
            this.CourseManageTabPage.SuspendLayout();
            this.EditCourseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseWeekTimeCheckBoxGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CommingSoonLabel
            // 
            this.CommingSoonLabel.AutoSize = true;
            this.CommingSoonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.CommingSoonLabel.Location = new System.Drawing.Point(34, 130);
            this.CommingSoonLabel.Name = "CommingSoonLabel";
            this.CommingSoonLabel.Size = new System.Drawing.Size(0, 69);
            this.CommingSoonLabel.TabIndex = 0;
            // 
            // ManagementTabControll
            // 
            this.ManagementTabControll.Controls.Add(this.CourseManageTabPage);
            this.ManagementTabControll.Controls.Add(this.ClassManageTabPage);
            this.ManagementTabControll.Location = new System.Drawing.Point(11, 11);
            this.ManagementTabControll.Margin = new System.Windows.Forms.Padding(2);
            this.ManagementTabControll.Name = "ManagementTabControll";
            this.ManagementTabControll.SelectedIndex = 0;
            this.ManagementTabControll.Size = new System.Drawing.Size(1173, 724);
            this.ManagementTabControll.TabIndex = 1;
            // 
            // CourseManageTabPage
            // 
            this.CourseManageTabPage.Controls.Add(this.SaveCourseButton);
            this.CourseManageTabPage.Controls.Add(this.CourseListBox);
            this.CourseManageTabPage.Controls.Add(this.EditCourseGroupBox);
            this.CourseManageTabPage.Controls.Add(this.AddCourseButton);
            this.CourseManageTabPage.Location = new System.Drawing.Point(4, 25);
            this.CourseManageTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.CourseManageTabPage.Name = "CourseManageTabPage";
            this.CourseManageTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.CourseManageTabPage.Size = new System.Drawing.Size(1165, 695);
            this.CourseManageTabPage.TabIndex = 0;
            this.CourseManageTabPage.Text = "課程管理";
            this.CourseManageTabPage.UseVisualStyleBackColor = true;
            // 
            // SaveCourseButton
            // 
            this.SaveCourseButton.Location = new System.Drawing.Point(985, 626);
            this.SaveCourseButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveCourseButton.Name = "SaveCourseButton";
            this.SaveCourseButton.Size = new System.Drawing.Size(174, 61);
            this.SaveCourseButton.TabIndex = 3;
            this.SaveCourseButton.Text = "儲存";
            this.SaveCourseButton.UseVisualStyleBackColor = true;
            // 
            // CourseListBox
            // 
            this.CourseListBox.FormattingEnabled = true;
            this.CourseListBox.ItemHeight = 15;
            this.CourseListBox.Location = new System.Drawing.Point(4, 4);
            this.CourseListBox.Margin = new System.Windows.Forms.Padding(2);
            this.CourseListBox.Name = "CourseListBox";
            this.CourseListBox.Size = new System.Drawing.Size(345, 619);
            this.CourseListBox.TabIndex = 2;
            this.CourseListBox.SelectedIndexChanged += new System.EventHandler(this.CourseListBox_SelectedIndexChanged);
            // 
            // EditCourseGroupBox
            // 
            this.EditCourseGroupBox.Controls.Add(this.CourseClassComboBox);
            this.EditCourseGroupBox.Controls.Add(this.CourseClassLabel);
            this.EditCourseGroupBox.Controls.Add(this.CourseHourComboBox);
            this.EditCourseGroupBox.Controls.Add(this.CourseHourLabel);
            this.EditCourseGroupBox.Controls.Add(this.CourseRemarkTextBox);
            this.EditCourseGroupBox.Controls.Add(this.CourseRemarkLabel);
            this.EditCourseGroupBox.Controls.Add(this.CourseLanguageTextBox);
            this.EditCourseGroupBox.Controls.Add(this.CourseLanguageLabel);
            this.EditCourseGroupBox.Controls.Add(this.CourseTAsTextBox);
            this.EditCourseGroupBox.Controls.Add(this.CourseTAsLabel);
            this.EditCourseGroupBox.Controls.Add(this.CourseTypeComboBox);
            this.EditCourseGroupBox.Controls.Add(this.CourseTypeLabel);
            this.EditCourseGroupBox.Controls.Add(this.CourseTeacherTextBox);
            this.EditCourseGroupBox.Controls.Add(this.CourseTeacherLabel);
            this.EditCourseGroupBox.Controls.Add(this.CourseCreditTextBox);
            this.EditCourseGroupBox.Controls.Add(this.CourseCreditLabel);
            this.EditCourseGroupBox.Controls.Add(this.CourseLevelTextBox);
            this.EditCourseGroupBox.Controls.Add(this.CourseNameTextBox);
            this.EditCourseGroupBox.Controls.Add(this.CourseNumberTextBox);
            this.EditCourseGroupBox.Controls.Add(this.CourseLevelLabel);
            this.EditCourseGroupBox.Controls.Add(this.CourseNameLabel);
            this.EditCourseGroupBox.Controls.Add(this.CourseNumberLabel);
            this.EditCourseGroupBox.Controls.Add(this.CourseEnabledComboBox);
            this.EditCourseGroupBox.Controls.Add(this.CourseWeekTimeCheckBoxGridView);
            this.EditCourseGroupBox.Location = new System.Drawing.Point(353, 7);
            this.EditCourseGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.EditCourseGroupBox.Name = "EditCourseGroupBox";
            this.EditCourseGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.EditCourseGroupBox.Size = new System.Drawing.Size(806, 619);
            this.EditCourseGroupBox.TabIndex = 1;
            this.EditCourseGroupBox.TabStop = false;
            this.EditCourseGroupBox.Text = "編輯課程";
            // 
            // CourseClassComboBox
            // 
            this.CourseClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseClassComboBox.FormattingEnabled = true;
            this.CourseClassComboBox.Location = new System.Drawing.Point(250, 245);
            this.CourseClassComboBox.Name = "CourseClassComboBox";
            this.CourseClassComboBox.Size = new System.Drawing.Size(121, 23);
            this.CourseClassComboBox.TabIndex = 22;
            this.CourseClassComboBox.SelectedIndexChanged += new System.EventHandler(this.CourseClassComboBox_SelectedIndexChanged);
            // 
            // CourseClassLabel
            // 
            this.CourseClassLabel.AutoSize = true;
            this.CourseClassLabel.Location = new System.Drawing.Point(190, 253);
            this.CourseClassLabel.Name = "CourseClassLabel";
            this.CourseClassLabel.Size = new System.Drawing.Size(54, 15);
            this.CourseClassLabel.TabIndex = 21;
            this.CourseClassLabel.Text = "班級(*)";
            // 
            // CourseHourComboBox
            // 
            this.CourseHourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseHourComboBox.FormattingEnabled = true;
            this.CourseHourComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.CourseHourComboBox.Location = new System.Drawing.Point(63, 245);
            this.CourseHourComboBox.Name = "CourseHourComboBox";
            this.CourseHourComboBox.Size = new System.Drawing.Size(121, 23);
            this.CourseHourComboBox.TabIndex = 20;
            this.CourseHourComboBox.SelectedIndexChanged += new System.EventHandler(this.CourseHourComboBox_SelectedIndexChanged);
            // 
            // CourseHourLabel
            // 
            this.CourseHourLabel.AutoSize = true;
            this.CourseHourLabel.Location = new System.Drawing.Point(5, 253);
            this.CourseHourLabel.Name = "CourseHourLabel";
            this.CourseHourLabel.Size = new System.Drawing.Size(54, 15);
            this.CourseHourLabel.TabIndex = 19;
            this.CourseHourLabel.Text = "時數(*)";
            // 
            // CourseRemarkTextBox
            // 
            this.CourseRemarkTextBox.Location = new System.Drawing.Point(48, 188);
            this.CourseRemarkTextBox.Name = "CourseRemarkTextBox";
            this.CourseRemarkTextBox.Size = new System.Drawing.Size(568, 25);
            this.CourseRemarkTextBox.TabIndex = 18;
            this.CourseRemarkTextBox.TextChanged += new System.EventHandler(this.CourseRemarkTextBox_TextChanged);
            // 
            // CourseRemarkLabel
            // 
            this.CourseRemarkLabel.AutoSize = true;
            this.CourseRemarkLabel.Location = new System.Drawing.Point(5, 198);
            this.CourseRemarkLabel.Name = "CourseRemarkLabel";
            this.CourseRemarkLabel.Size = new System.Drawing.Size(37, 15);
            this.CourseRemarkLabel.TabIndex = 17;
            this.CourseRemarkLabel.Text = "備註";
            // 
            // CourseLanguageTextBox
            // 
            this.CourseLanguageTextBox.Location = new System.Drawing.Point(458, 131);
            this.CourseLanguageTextBox.Name = "CourseLanguageTextBox";
            this.CourseLanguageTextBox.Size = new System.Drawing.Size(343, 25);
            this.CourseLanguageTextBox.TabIndex = 16;
            this.CourseLanguageTextBox.TextChanged += new System.EventHandler(this.CourseLanguageTextBox_TextChanged);
            // 
            // CourseLanguageLabel
            // 
            this.CourseLanguageLabel.AutoSize = true;
            this.CourseLanguageLabel.Location = new System.Drawing.Point(385, 141);
            this.CourseLanguageLabel.Name = "CourseLanguageLabel";
            this.CourseLanguageLabel.Size = new System.Drawing.Size(67, 15);
            this.CourseLanguageLabel.TabIndex = 4;
            this.CourseLanguageLabel.Text = "授課語言";
            // 
            // CourseTAsTextBox
            // 
            this.CourseTAsTextBox.Location = new System.Drawing.Point(78, 131);
            this.CourseTAsTextBox.Name = "CourseTAsTextBox";
            this.CourseTAsTextBox.Size = new System.Drawing.Size(301, 25);
            this.CourseTAsTextBox.TabIndex = 15;
            this.CourseTAsTextBox.TextChanged += new System.EventHandler(this.CourseTAsTextBox_TextChanged);
            // 
            // CourseTAsLabel
            // 
            this.CourseTAsLabel.AutoSize = true;
            this.CourseTAsLabel.Location = new System.Drawing.Point(5, 141);
            this.CourseTAsLabel.Name = "CourseTAsLabel";
            this.CourseTAsLabel.Size = new System.Drawing.Size(67, 15);
            this.CourseTAsLabel.TabIndex = 14;
            this.CourseTAsLabel.Text = "教學助理";
            // 
            // CourseTypeComboBox
            // 
            this.CourseTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseTypeComboBox.FormattingEnabled = true;
            this.CourseTypeComboBox.Location = new System.Drawing.Point(667, 79);
            this.CourseTypeComboBox.Name = "CourseTypeComboBox";
            this.CourseTypeComboBox.Size = new System.Drawing.Size(134, 23);
            this.CourseTypeComboBox.TabIndex = 13;
            this.CourseTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.CourseTypeComboBox_SelectedIndexChanged);
            // 
            // CourseTypeLabel
            // 
            this.CourseTypeLabel.AutoSize = true;
            this.CourseTypeLabel.Location = new System.Drawing.Point(622, 87);
            this.CourseTypeLabel.Name = "CourseTypeLabel";
            this.CourseTypeLabel.Size = new System.Drawing.Size(39, 15);
            this.CourseTypeLabel.TabIndex = 12;
            this.CourseTypeLabel.Text = "修(*)";
            // 
            // CourseTeacherTextBox
            // 
            this.CourseTeacherTextBox.Location = new System.Drawing.Point(444, 77);
            this.CourseTeacherTextBox.Name = "CourseTeacherTextBox";
            this.CourseTeacherTextBox.Size = new System.Drawing.Size(172, 25);
            this.CourseTeacherTextBox.TabIndex = 11;
            this.CourseTeacherTextBox.TextChanged += new System.EventHandler(this.CourseTeacherTextBox_TextChanged);
            // 
            // CourseTeacherLabel
            // 
            this.CourseTeacherLabel.AutoSize = true;
            this.CourseTeacherLabel.Location = new System.Drawing.Point(384, 87);
            this.CourseTeacherLabel.Name = "CourseTeacherLabel";
            this.CourseTeacherLabel.Size = new System.Drawing.Size(54, 15);
            this.CourseTeacherLabel.TabIndex = 10;
            this.CourseTeacherLabel.Text = "教師(*)";
            // 
            // CourseCreditTextBox
            // 
            this.CourseCreditTextBox.Location = new System.Drawing.Point(229, 77);
            this.CourseCreditTextBox.Name = "CourseCreditTextBox";
            this.CourseCreditTextBox.Size = new System.Drawing.Size(150, 25);
            this.CourseCreditTextBox.TabIndex = 9;
            this.CourseCreditTextBox.TextChanged += new System.EventHandler(this.CourseCreditTextBox_TextChanged);
            // 
            // CourseCreditLabel
            // 
            this.CourseCreditLabel.AutoSize = true;
            this.CourseCreditLabel.Location = new System.Drawing.Point(169, 87);
            this.CourseCreditLabel.Name = "CourseCreditLabel";
            this.CourseCreditLabel.Size = new System.Drawing.Size(54, 15);
            this.CourseCreditLabel.TabIndex = 8;
            this.CourseCreditLabel.Text = "學分(*)";
            // 
            // CourseLevelTextBox
            // 
            this.CourseLevelTextBox.Location = new System.Drawing.Point(63, 77);
            this.CourseLevelTextBox.Name = "CourseLevelTextBox";
            this.CourseLevelTextBox.Size = new System.Drawing.Size(100, 25);
            this.CourseLevelTextBox.TabIndex = 7;
            this.CourseLevelTextBox.TextChanged += new System.EventHandler(this.CourseLevelTextBox_TextChanged);
            // 
            // CourseNameTextBox
            // 
            this.CourseNameTextBox.Location = new System.Drawing.Point(473, 20);
            this.CourseNameTextBox.Name = "CourseNameTextBox";
            this.CourseNameTextBox.Size = new System.Drawing.Size(328, 25);
            this.CourseNameTextBox.TabIndex = 6;
            this.CourseNameTextBox.TextChanged += new System.EventHandler(this.CourseNameTextBox_TextChanged);
            // 
            // CourseNumberTextBox
            // 
            this.CourseNumberTextBox.Location = new System.Drawing.Point(209, 20);
            this.CourseNumberTextBox.Name = "CourseNumberTextBox";
            this.CourseNumberTextBox.Size = new System.Drawing.Size(170, 25);
            this.CourseNumberTextBox.TabIndex = 5;
            this.CourseNumberTextBox.TextChanged += new System.EventHandler(this.CourseNumberTextBox_TextChanged);
            // 
            // CourseLevelLabel
            // 
            this.CourseLevelLabel.AutoSize = true;
            this.CourseLevelLabel.Location = new System.Drawing.Point(4, 87);
            this.CourseLevelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CourseLevelLabel.Name = "CourseLevelLabel";
            this.CourseLevelLabel.Size = new System.Drawing.Size(54, 15);
            this.CourseLevelLabel.TabIndex = 4;
            this.CourseLevelLabel.Text = "階段(*)";
            // 
            // CourseNameLabel
            // 
            this.CourseNameLabel.AutoSize = true;
            this.CourseNameLabel.Location = new System.Drawing.Point(384, 30);
            this.CourseNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CourseNameLabel.Name = "CourseNameLabel";
            this.CourseNameLabel.Size = new System.Drawing.Size(84, 15);
            this.CourseNameLabel.TabIndex = 3;
            this.CourseNameLabel.Text = "課程名稱(*)";
            // 
            // CourseNumberLabel
            // 
            this.CourseNumberLabel.AutoSize = true;
            this.CourseNumberLabel.Location = new System.Drawing.Point(150, 30);
            this.CourseNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CourseNumberLabel.Name = "CourseNumberLabel";
            this.CourseNumberLabel.Size = new System.Drawing.Size(54, 15);
            this.CourseNumberLabel.TabIndex = 2;
            this.CourseNumberLabel.Text = "課號(*)";
            // 
            // CourseEnabledComboBox
            // 
            this.CourseEnabledComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseEnabledComboBox.FormattingEnabled = true;
            this.CourseEnabledComboBox.Items.AddRange(new object[] {
            "開課",
            "停開"});
            this.CourseEnabledComboBox.Location = new System.Drawing.Point(4, 22);
            this.CourseEnabledComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.CourseEnabledComboBox.Name = "CourseEnabledComboBox";
            this.CourseEnabledComboBox.Size = new System.Drawing.Size(142, 23);
            this.CourseEnabledComboBox.TabIndex = 1;
            // 
            // CourseWeekTimeCheckBoxGridView
            // 
            this.CourseWeekTimeCheckBoxGridView.AllowUserToAddRows = false;
            this.CourseWeekTimeCheckBoxGridView.AllowUserToDeleteRows = false;
            this.CourseWeekTimeCheckBoxGridView.AllowUserToResizeColumns = false;
            this.CourseWeekTimeCheckBoxGridView.AllowUserToResizeRows = false;
            this.CourseWeekTimeCheckBoxGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CourseWeekTimeCheckBoxGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.CourseWeekTimeCheckBoxGridView.ColumnHeadersHeight = 29;
            this.CourseWeekTimeCheckBoxGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CourseWeekTimeCheckBoxGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseSectionColumn,
            this.SundaySectionColumn,
            this.MondaySectionColumn,
            this.TuesdaySectionColumn,
            this.WednesdaySectionColumn,
            this.ThursdaySectionColumn,
            this.FridaySectionColumn,
            this.SaturdaySectionColumn});
            this.CourseWeekTimeCheckBoxGridView.Location = new System.Drawing.Point(4, 307);
            this.CourseWeekTimeCheckBoxGridView.Margin = new System.Windows.Forms.Padding(2);
            this.CourseWeekTimeCheckBoxGridView.MultiSelect = false;
            this.CourseWeekTimeCheckBoxGridView.Name = "CourseWeekTimeCheckBoxGridView";
            this.CourseWeekTimeCheckBoxGridView.ReadOnly = true;
            this.CourseWeekTimeCheckBoxGridView.RowHeadersVisible = false;
            this.CourseWeekTimeCheckBoxGridView.RowHeadersWidth = 82;
            this.CourseWeekTimeCheckBoxGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CourseWeekTimeCheckBoxGridView.RowTemplate.Height = 38;
            this.CourseWeekTimeCheckBoxGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.CourseWeekTimeCheckBoxGridView.Size = new System.Drawing.Size(797, 308);
            this.CourseWeekTimeCheckBoxGridView.TabIndex = 0;
            // 
            // CourseSectionColumn
            // 
            this.CourseSectionColumn.HeaderText = "節數";
            this.CourseSectionColumn.MinimumWidth = 10;
            this.CourseSectionColumn.Name = "CourseSectionColumn";
            this.CourseSectionColumn.ReadOnly = true;
            this.CourseSectionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseSectionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SundaySectionColumn
            // 
            this.SundaySectionColumn.HeaderText = "日";
            this.SundaySectionColumn.MinimumWidth = 10;
            this.SundaySectionColumn.Name = "SundaySectionColumn";
            this.SundaySectionColumn.ReadOnly = true;
            this.SundaySectionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MondaySectionColumn
            // 
            this.MondaySectionColumn.HeaderText = "一";
            this.MondaySectionColumn.MinimumWidth = 10;
            this.MondaySectionColumn.Name = "MondaySectionColumn";
            this.MondaySectionColumn.ReadOnly = true;
            this.MondaySectionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TuesdaySectionColumn
            // 
            this.TuesdaySectionColumn.HeaderText = "二";
            this.TuesdaySectionColumn.MinimumWidth = 10;
            this.TuesdaySectionColumn.Name = "TuesdaySectionColumn";
            this.TuesdaySectionColumn.ReadOnly = true;
            this.TuesdaySectionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // WednesdaySectionColumn
            // 
            this.WednesdaySectionColumn.HeaderText = "三";
            this.WednesdaySectionColumn.MinimumWidth = 10;
            this.WednesdaySectionColumn.Name = "WednesdaySectionColumn";
            this.WednesdaySectionColumn.ReadOnly = true;
            this.WednesdaySectionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ThursdaySectionColumn
            // 
            this.ThursdaySectionColumn.HeaderText = "四";
            this.ThursdaySectionColumn.MinimumWidth = 10;
            this.ThursdaySectionColumn.Name = "ThursdaySectionColumn";
            this.ThursdaySectionColumn.ReadOnly = true;
            this.ThursdaySectionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FridaySectionColumn
            // 
            this.FridaySectionColumn.HeaderText = "五";
            this.FridaySectionColumn.MinimumWidth = 10;
            this.FridaySectionColumn.Name = "FridaySectionColumn";
            this.FridaySectionColumn.ReadOnly = true;
            this.FridaySectionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SaturdaySectionColumn
            // 
            this.SaturdaySectionColumn.HeaderText = "六";
            this.SaturdaySectionColumn.MinimumWidth = 10;
            this.SaturdaySectionColumn.Name = "SaturdaySectionColumn";
            this.SaturdaySectionColumn.ReadOnly = true;
            this.SaturdaySectionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(4, 627);
            this.AddCourseButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(345, 61);
            this.AddCourseButton.TabIndex = 0;
            this.AddCourseButton.Text = "新增課程";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            // 
            // ClassManageTabPage
            // 
            this.ClassManageTabPage.Location = new System.Drawing.Point(4, 25);
            this.ClassManageTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.ClassManageTabPage.Name = "ClassManageTabPage";
            this.ClassManageTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.ClassManageTabPage.Size = new System.Drawing.Size(1165, 695);
            this.ClassManageTabPage.TabIndex = 1;
            this.ClassManageTabPage.Text = "班級管理";
            this.ClassManageTabPage.UseVisualStyleBackColor = true;
            // 
            // CourseManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1184, 659);
            this.Controls.Add(this.ManagementTabControll);
            this.Controls.Add(this.CommingSoonLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "CourseManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Management";
            this.Load += new System.EventHandler(this.CourseManagementForm_Load);
            this.ManagementTabControll.ResumeLayout(false);
            this.CourseManageTabPage.ResumeLayout(false);
            this.EditCourseGroupBox.ResumeLayout(false);
            this.EditCourseGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseWeekTimeCheckBoxGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CommingSoonLabel;
        private System.Windows.Forms.TabControl ManagementTabControll;
        private System.Windows.Forms.TabPage CourseManageTabPage;
        private System.Windows.Forms.TabPage ClassManageTabPage;
        private System.Windows.Forms.ListBox CourseListBox;
        private System.Windows.Forms.GroupBox EditCourseGroupBox;
        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.Button SaveCourseButton;
        private System.Windows.Forms.DataGridView CourseWeekTimeCheckBoxGridView;
        private System.Windows.Forms.ComboBox CourseEnabledComboBox;
        private System.Windows.Forms.Label CourseLevelLabel;
        private System.Windows.Forms.Label CourseNameLabel;
        private System.Windows.Forms.Label CourseNumberLabel;
        private System.Windows.Forms.TextBox CourseNameTextBox;
        private System.Windows.Forms.TextBox CourseNumberTextBox;
        private System.Windows.Forms.TextBox CourseLevelTextBox;
        private System.Windows.Forms.Label CourseTypeLabel;
        private System.Windows.Forms.TextBox CourseTeacherTextBox;
        private System.Windows.Forms.Label CourseTeacherLabel;
        private System.Windows.Forms.TextBox CourseCreditTextBox;
        private System.Windows.Forms.Label CourseCreditLabel;
        private System.Windows.Forms.ComboBox CourseTypeComboBox;
        private System.Windows.Forms.Label CourseTAsLabel;
        private System.Windows.Forms.TextBox CourseLanguageTextBox;
        private System.Windows.Forms.Label CourseLanguageLabel;
        private System.Windows.Forms.TextBox CourseTAsTextBox;
        private System.Windows.Forms.Label CourseHourLabel;
        private System.Windows.Forms.TextBox CourseRemarkTextBox;
        private System.Windows.Forms.Label CourseRemarkLabel;
        private System.Windows.Forms.ComboBox CourseHourComboBox;
        private System.Windows.Forms.ComboBox CourseClassComboBox;
        private System.Windows.Forms.Label CourseClassLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseSectionColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SundaySectionColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MondaySectionColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TuesdaySectionColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn WednesdaySectionColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ThursdaySectionColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FridaySectionColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SaturdaySectionColumn;
    }
}