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
            this.CommingSoonLabel.Location = new System.Drawing.Point(54, 208);
            this.CommingSoonLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CommingSoonLabel.Name = "CommingSoonLabel";
            this.CommingSoonLabel.Size = new System.Drawing.Size(0, 108);
            this.CommingSoonLabel.TabIndex = 0;
            // 
            // ManagementTabControll
            // 
            this.ManagementTabControll.Controls.Add(this.CourseManageTabPage);
            this.ManagementTabControll.Controls.Add(this.ClassManageTabPage);
            this.ManagementTabControll.Location = new System.Drawing.Point(18, 18);
            this.ManagementTabControll.Name = "ManagementTabControll";
            this.ManagementTabControll.SelectedIndex = 0;
            this.ManagementTabControll.Size = new System.Drawing.Size(1877, 1158);
            this.ManagementTabControll.TabIndex = 1;
            // 
            // CourseManageTabPage
            // 
            this.CourseManageTabPage.Controls.Add(this.SaveCourseButton);
            this.CourseManageTabPage.Controls.Add(this.CourseListBox);
            this.CourseManageTabPage.Controls.Add(this.EditCourseGroupBox);
            this.CourseManageTabPage.Controls.Add(this.AddCourseButton);
            this.CourseManageTabPage.Location = new System.Drawing.Point(8, 39);
            this.CourseManageTabPage.Name = "CourseManageTabPage";
            this.CourseManageTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.CourseManageTabPage.Size = new System.Drawing.Size(1861, 1111);
            this.CourseManageTabPage.TabIndex = 0;
            this.CourseManageTabPage.Text = "課程管理";
            this.CourseManageTabPage.UseVisualStyleBackColor = true;
            // 
            // SaveCourseButton
            // 
            this.SaveCourseButton.Location = new System.Drawing.Point(1576, 1002);
            this.SaveCourseButton.Name = "SaveCourseButton";
            this.SaveCourseButton.Size = new System.Drawing.Size(278, 98);
            this.SaveCourseButton.TabIndex = 3;
            this.SaveCourseButton.Text = "儲存";
            this.SaveCourseButton.UseVisualStyleBackColor = true;
            this.SaveCourseButton.Click += new System.EventHandler(this.SaveCourseButton_Click);
            // 
            // CourseListBox
            // 
            this.CourseListBox.FormattingEnabled = true;
            this.CourseListBox.ItemHeight = 24;
            this.CourseListBox.Location = new System.Drawing.Point(6, 6);
            this.CourseListBox.Name = "CourseListBox";
            this.CourseListBox.Size = new System.Drawing.Size(550, 988);
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
            this.EditCourseGroupBox.Location = new System.Drawing.Point(565, 11);
            this.EditCourseGroupBox.Name = "EditCourseGroupBox";
            this.EditCourseGroupBox.Size = new System.Drawing.Size(1290, 990);
            this.EditCourseGroupBox.TabIndex = 1;
            this.EditCourseGroupBox.TabStop = false;
            this.EditCourseGroupBox.Text = "編輯課程";
            // 
            // CourseClassComboBox
            // 
            this.CourseClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseClassComboBox.FormattingEnabled = true;
            this.CourseClassComboBox.Location = new System.Drawing.Point(400, 392);
            this.CourseClassComboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CourseClassComboBox.Name = "CourseClassComboBox";
            this.CourseClassComboBox.Size = new System.Drawing.Size(191, 32);
            this.CourseClassComboBox.TabIndex = 22;
            this.CourseClassComboBox.SelectedIndexChanged += new System.EventHandler(this.CourseClassComboBox_SelectedIndexChanged);
            // 
            // CourseClassLabel
            // 
            this.CourseClassLabel.AutoSize = true;
            this.CourseClassLabel.Location = new System.Drawing.Point(304, 405);
            this.CourseClassLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CourseClassLabel.Name = "CourseClassLabel";
            this.CourseClassLabel.Size = new System.Drawing.Size(85, 24);
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
            this.CourseHourComboBox.Location = new System.Drawing.Point(101, 392);
            this.CourseHourComboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CourseHourComboBox.Name = "CourseHourComboBox";
            this.CourseHourComboBox.Size = new System.Drawing.Size(191, 32);
            this.CourseHourComboBox.TabIndex = 20;
            this.CourseHourComboBox.SelectedIndexChanged += new System.EventHandler(this.CourseHourComboBox_SelectedIndexChanged);
            // 
            // CourseHourLabel
            // 
            this.CourseHourLabel.AutoSize = true;
            this.CourseHourLabel.Location = new System.Drawing.Point(8, 405);
            this.CourseHourLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CourseHourLabel.Name = "CourseHourLabel";
            this.CourseHourLabel.Size = new System.Drawing.Size(85, 24);
            this.CourseHourLabel.TabIndex = 19;
            this.CourseHourLabel.Text = "時數(*)";
            // 
            // CourseRemarkTextBox
            // 
            this.CourseRemarkTextBox.Location = new System.Drawing.Point(77, 301);
            this.CourseRemarkTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CourseRemarkTextBox.Name = "CourseRemarkTextBox";
            this.CourseRemarkTextBox.Size = new System.Drawing.Size(906, 36);
            this.CourseRemarkTextBox.TabIndex = 18;
            this.CourseRemarkTextBox.TextChanged += new System.EventHandler(this.CourseRemarkTextBox_TextChanged);
            // 
            // CourseRemarkLabel
            // 
            this.CourseRemarkLabel.AutoSize = true;
            this.CourseRemarkLabel.Location = new System.Drawing.Point(8, 317);
            this.CourseRemarkLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CourseRemarkLabel.Name = "CourseRemarkLabel";
            this.CourseRemarkLabel.Size = new System.Drawing.Size(58, 24);
            this.CourseRemarkLabel.TabIndex = 17;
            this.CourseRemarkLabel.Text = "備註";
            // 
            // CourseLanguageTextBox
            // 
            this.CourseLanguageTextBox.Location = new System.Drawing.Point(733, 210);
            this.CourseLanguageTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CourseLanguageTextBox.Name = "CourseLanguageTextBox";
            this.CourseLanguageTextBox.Size = new System.Drawing.Size(546, 36);
            this.CourseLanguageTextBox.TabIndex = 16;
            this.CourseLanguageTextBox.TextChanged += new System.EventHandler(this.CourseLanguageTextBox_TextChanged);
            // 
            // CourseLanguageLabel
            // 
            this.CourseLanguageLabel.AutoSize = true;
            this.CourseLanguageLabel.Location = new System.Drawing.Point(616, 226);
            this.CourseLanguageLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CourseLanguageLabel.Name = "CourseLanguageLabel";
            this.CourseLanguageLabel.Size = new System.Drawing.Size(106, 24);
            this.CourseLanguageLabel.TabIndex = 4;
            this.CourseLanguageLabel.Text = "授課語言";
            // 
            // CourseTAsTextBox
            // 
            this.CourseTAsTextBox.Location = new System.Drawing.Point(125, 210);
            this.CourseTAsTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CourseTAsTextBox.Name = "CourseTAsTextBox";
            this.CourseTAsTextBox.Size = new System.Drawing.Size(479, 36);
            this.CourseTAsTextBox.TabIndex = 15;
            this.CourseTAsTextBox.TextChanged += new System.EventHandler(this.CourseTAsTextBox_TextChanged);
            // 
            // CourseTAsLabel
            // 
            this.CourseTAsLabel.AutoSize = true;
            this.CourseTAsLabel.Location = new System.Drawing.Point(8, 226);
            this.CourseTAsLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CourseTAsLabel.Name = "CourseTAsLabel";
            this.CourseTAsLabel.Size = new System.Drawing.Size(106, 24);
            this.CourseTAsLabel.TabIndex = 14;
            this.CourseTAsLabel.Text = "教學助理";
            // 
            // CourseTypeComboBox
            // 
            this.CourseTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseTypeComboBox.FormattingEnabled = true;
            this.CourseTypeComboBox.Location = new System.Drawing.Point(1067, 126);
            this.CourseTypeComboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CourseTypeComboBox.Name = "CourseTypeComboBox";
            this.CourseTypeComboBox.Size = new System.Drawing.Size(212, 32);
            this.CourseTypeComboBox.TabIndex = 13;
            this.CourseTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.CourseTypeComboBox_SelectedIndexChanged);
            // 
            // CourseTypeLabel
            // 
            this.CourseTypeLabel.AutoSize = true;
            this.CourseTypeLabel.Location = new System.Drawing.Point(995, 139);
            this.CourseTypeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CourseTypeLabel.Name = "CourseTypeLabel";
            this.CourseTypeLabel.Size = new System.Drawing.Size(61, 24);
            this.CourseTypeLabel.TabIndex = 12;
            this.CourseTypeLabel.Text = "修(*)";
            // 
            // CourseTeacherTextBox
            // 
            this.CourseTeacherTextBox.Location = new System.Drawing.Point(710, 123);
            this.CourseTeacherTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CourseTeacherTextBox.Name = "CourseTeacherTextBox";
            this.CourseTeacherTextBox.Size = new System.Drawing.Size(273, 36);
            this.CourseTeacherTextBox.TabIndex = 11;
            this.CourseTeacherTextBox.TextChanged += new System.EventHandler(this.CourseTeacherTextBox_TextChanged);
            // 
            // CourseTeacherLabel
            // 
            this.CourseTeacherLabel.AutoSize = true;
            this.CourseTeacherLabel.Location = new System.Drawing.Point(614, 139);
            this.CourseTeacherLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CourseTeacherLabel.Name = "CourseTeacherLabel";
            this.CourseTeacherLabel.Size = new System.Drawing.Size(85, 24);
            this.CourseTeacherLabel.TabIndex = 10;
            this.CourseTeacherLabel.Text = "教師(*)";
            // 
            // CourseCreditTextBox
            // 
            this.CourseCreditTextBox.Location = new System.Drawing.Point(366, 123);
            this.CourseCreditTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CourseCreditTextBox.Name = "CourseCreditTextBox";
            this.CourseCreditTextBox.Size = new System.Drawing.Size(238, 36);
            this.CourseCreditTextBox.TabIndex = 9;
            this.CourseCreditTextBox.TextChanged += new System.EventHandler(this.CourseCreditTextBox_TextChanged);
            // 
            // CourseCreditLabel
            // 
            this.CourseCreditLabel.AutoSize = true;
            this.CourseCreditLabel.Location = new System.Drawing.Point(270, 139);
            this.CourseCreditLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CourseCreditLabel.Name = "CourseCreditLabel";
            this.CourseCreditLabel.Size = new System.Drawing.Size(85, 24);
            this.CourseCreditLabel.TabIndex = 8;
            this.CourseCreditLabel.Text = "學分(*)";
            // 
            // CourseLevelTextBox
            // 
            this.CourseLevelTextBox.Location = new System.Drawing.Point(101, 123);
            this.CourseLevelTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CourseLevelTextBox.Name = "CourseLevelTextBox";
            this.CourseLevelTextBox.Size = new System.Drawing.Size(158, 36);
            this.CourseLevelTextBox.TabIndex = 7;
            this.CourseLevelTextBox.TextChanged += new System.EventHandler(this.CourseLevelTextBox_TextChanged);
            // 
            // CourseNameTextBox
            // 
            this.CourseNameTextBox.Location = new System.Drawing.Point(757, 32);
            this.CourseNameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CourseNameTextBox.Name = "CourseNameTextBox";
            this.CourseNameTextBox.Size = new System.Drawing.Size(522, 36);
            this.CourseNameTextBox.TabIndex = 6;
            this.CourseNameTextBox.TextChanged += new System.EventHandler(this.CourseNameTextBox_TextChanged);
            // 
            // CourseNumberTextBox
            // 
            this.CourseNumberTextBox.Location = new System.Drawing.Point(334, 32);
            this.CourseNumberTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CourseNumberTextBox.Name = "CourseNumberTextBox";
            this.CourseNumberTextBox.Size = new System.Drawing.Size(270, 36);
            this.CourseNumberTextBox.TabIndex = 5;
            this.CourseNumberTextBox.TextChanged += new System.EventHandler(this.CourseNumberTextBox_TextChanged);
            // 
            // CourseLevelLabel
            // 
            this.CourseLevelLabel.AutoSize = true;
            this.CourseLevelLabel.Location = new System.Drawing.Point(6, 139);
            this.CourseLevelLabel.Name = "CourseLevelLabel";
            this.CourseLevelLabel.Size = new System.Drawing.Size(85, 24);
            this.CourseLevelLabel.TabIndex = 4;
            this.CourseLevelLabel.Text = "階段(*)";
            // 
            // CourseNameLabel
            // 
            this.CourseNameLabel.AutoSize = true;
            this.CourseNameLabel.Location = new System.Drawing.Point(614, 48);
            this.CourseNameLabel.Name = "CourseNameLabel";
            this.CourseNameLabel.Size = new System.Drawing.Size(133, 24);
            this.CourseNameLabel.TabIndex = 3;
            this.CourseNameLabel.Text = "課程名稱(*)";
            // 
            // CourseNumberLabel
            // 
            this.CourseNumberLabel.AutoSize = true;
            this.CourseNumberLabel.Location = new System.Drawing.Point(240, 48);
            this.CourseNumberLabel.Name = "CourseNumberLabel";
            this.CourseNumberLabel.Size = new System.Drawing.Size(85, 24);
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
            this.CourseEnabledComboBox.Location = new System.Drawing.Point(6, 35);
            this.CourseEnabledComboBox.Name = "CourseEnabledComboBox";
            this.CourseEnabledComboBox.Size = new System.Drawing.Size(225, 32);
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
            this.CourseWeekTimeCheckBoxGridView.Location = new System.Drawing.Point(6, 491);
            this.CourseWeekTimeCheckBoxGridView.MultiSelect = false;
            this.CourseWeekTimeCheckBoxGridView.Name = "CourseWeekTimeCheckBoxGridView";
            this.CourseWeekTimeCheckBoxGridView.ReadOnly = true;
            this.CourseWeekTimeCheckBoxGridView.RowHeadersVisible = false;
            this.CourseWeekTimeCheckBoxGridView.RowHeadersWidth = 82;
            this.CourseWeekTimeCheckBoxGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CourseWeekTimeCheckBoxGridView.RowTemplate.Height = 38;
            this.CourseWeekTimeCheckBoxGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.CourseWeekTimeCheckBoxGridView.Size = new System.Drawing.Size(1275, 493);
            this.CourseWeekTimeCheckBoxGridView.TabIndex = 0;
            this.CourseWeekTimeCheckBoxGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseWeekTimeCheckBoxGridView_CellContentClick);
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
            this.SundaySectionColumn.FalseValue = "False";
            this.SundaySectionColumn.HeaderText = "日";
            this.SundaySectionColumn.MinimumWidth = 10;
            this.SundaySectionColumn.Name = "SundaySectionColumn";
            this.SundaySectionColumn.ReadOnly = true;
            this.SundaySectionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SundaySectionColumn.TrueValue = "True";
            // 
            // MondaySectionColumn
            // 
            this.MondaySectionColumn.FalseValue = "False";
            this.MondaySectionColumn.HeaderText = "一";
            this.MondaySectionColumn.MinimumWidth = 10;
            this.MondaySectionColumn.Name = "MondaySectionColumn";
            this.MondaySectionColumn.ReadOnly = true;
            this.MondaySectionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MondaySectionColumn.TrueValue = "True";
            // 
            // TuesdaySectionColumn
            // 
            this.TuesdaySectionColumn.FalseValue = "False";
            this.TuesdaySectionColumn.HeaderText = "二";
            this.TuesdaySectionColumn.MinimumWidth = 10;
            this.TuesdaySectionColumn.Name = "TuesdaySectionColumn";
            this.TuesdaySectionColumn.ReadOnly = true;
            this.TuesdaySectionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TuesdaySectionColumn.TrueValue = "True";
            // 
            // WednesdaySectionColumn
            // 
            this.WednesdaySectionColumn.FalseValue = "False";
            this.WednesdaySectionColumn.HeaderText = "三";
            this.WednesdaySectionColumn.MinimumWidth = 10;
            this.WednesdaySectionColumn.Name = "WednesdaySectionColumn";
            this.WednesdaySectionColumn.ReadOnly = true;
            this.WednesdaySectionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.WednesdaySectionColumn.TrueValue = "True";
            // 
            // ThursdaySectionColumn
            // 
            this.ThursdaySectionColumn.FalseValue = "False";
            this.ThursdaySectionColumn.HeaderText = "四";
            this.ThursdaySectionColumn.MinimumWidth = 10;
            this.ThursdaySectionColumn.Name = "ThursdaySectionColumn";
            this.ThursdaySectionColumn.ReadOnly = true;
            this.ThursdaySectionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ThursdaySectionColumn.TrueValue = "True";
            // 
            // FridaySectionColumn
            // 
            this.FridaySectionColumn.FalseValue = "False";
            this.FridaySectionColumn.HeaderText = "五";
            this.FridaySectionColumn.MinimumWidth = 10;
            this.FridaySectionColumn.Name = "FridaySectionColumn";
            this.FridaySectionColumn.ReadOnly = true;
            this.FridaySectionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FridaySectionColumn.TrueValue = "True";
            // 
            // SaturdaySectionColumn
            // 
            this.SaturdaySectionColumn.FalseValue = "False";
            this.SaturdaySectionColumn.HeaderText = "六";
            this.SaturdaySectionColumn.MinimumWidth = 10;
            this.SaturdaySectionColumn.Name = "SaturdaySectionColumn";
            this.SaturdaySectionColumn.ReadOnly = true;
            this.SaturdaySectionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SaturdaySectionColumn.TrueValue = "True";
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(6, 1003);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(552, 98);
            this.AddCourseButton.TabIndex = 0;
            this.AddCourseButton.Text = "新增課程";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            // 
            // ClassManageTabPage
            // 
            this.ClassManageTabPage.Location = new System.Drawing.Point(8, 39);
            this.ClassManageTabPage.Name = "ClassManageTabPage";
            this.ClassManageTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.ClassManageTabPage.Size = new System.Drawing.Size(1861, 1111);
            this.ClassManageTabPage.TabIndex = 1;
            this.ClassManageTabPage.Text = "班級管理";
            this.ClassManageTabPage.UseVisualStyleBackColor = true;
            // 
            // CourseManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1894, 1054);
            this.Controls.Add(this.ManagementTabControll);
            this.Controls.Add(this.CommingSoonLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
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