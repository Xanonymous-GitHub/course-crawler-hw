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
            this.CourseSectionEditGridView = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.CourseSectionEditGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CommingSoonLabel
            // 
            this.CommingSoonLabel.AutoSize = true;
            this.CommingSoonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.CommingSoonLabel.Location = new System.Drawing.Point(55, 208);
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
            this.ManagementTabControll.Size = new System.Drawing.Size(1906, 1158);
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
            this.CourseManageTabPage.Size = new System.Drawing.Size(1890, 1111);
            this.CourseManageTabPage.TabIndex = 0;
            this.CourseManageTabPage.Text = "課程管理";
            this.CourseManageTabPage.UseVisualStyleBackColor = true;
            // 
            // SaveCourseButton
            // 
            this.SaveCourseButton.Location = new System.Drawing.Point(1601, 1002);
            this.SaveCourseButton.Name = "SaveCourseButton";
            this.SaveCourseButton.Size = new System.Drawing.Size(283, 98);
            this.SaveCourseButton.TabIndex = 3;
            this.SaveCourseButton.Text = "儲存";
            this.SaveCourseButton.UseVisualStyleBackColor = true;
            // 
            // CourseListBox
            // 
            this.CourseListBox.FormattingEnabled = true;
            this.CourseListBox.ItemHeight = 24;
            this.CourseListBox.Location = new System.Drawing.Point(6, 6);
            this.CourseListBox.Name = "CourseListBox";
            this.CourseListBox.Size = new System.Drawing.Size(558, 988);
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
            this.EditCourseGroupBox.Controls.Add(this.CourseSectionEditGridView);
            this.EditCourseGroupBox.Location = new System.Drawing.Point(574, 11);
            this.EditCourseGroupBox.Name = "EditCourseGroupBox";
            this.EditCourseGroupBox.Size = new System.Drawing.Size(1310, 990);
            this.EditCourseGroupBox.TabIndex = 1;
            this.EditCourseGroupBox.TabStop = false;
            this.EditCourseGroupBox.Text = "編輯課程";
            // 
            // CourseClassComboBox
            // 
            this.CourseClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseClassComboBox.FormattingEnabled = true;
            this.CourseClassComboBox.Location = new System.Drawing.Point(406, 392);
            this.CourseClassComboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CourseClassComboBox.Name = "CourseClassComboBox";
            this.CourseClassComboBox.Size = new System.Drawing.Size(194, 32);
            this.CourseClassComboBox.TabIndex = 22;
            // 
            // CourseClassLabel
            // 
            this.CourseClassLabel.AutoSize = true;
            this.CourseClassLabel.Location = new System.Drawing.Point(309, 405);
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
            this.CourseHourComboBox.Location = new System.Drawing.Point(102, 392);
            this.CourseHourComboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CourseHourComboBox.Name = "CourseHourComboBox";
            this.CourseHourComboBox.Size = new System.Drawing.Size(194, 32);
            this.CourseHourComboBox.TabIndex = 20;
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
            this.CourseRemarkTextBox.Location = new System.Drawing.Point(78, 301);
            this.CourseRemarkTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CourseRemarkTextBox.Name = "CourseRemarkTextBox";
            this.CourseRemarkTextBox.Size = new System.Drawing.Size(920, 36);
            this.CourseRemarkTextBox.TabIndex = 18;
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
            this.CourseLanguageTextBox.Location = new System.Drawing.Point(744, 210);
            this.CourseLanguageTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CourseLanguageTextBox.Name = "CourseLanguageTextBox";
            this.CourseLanguageTextBox.Size = new System.Drawing.Size(555, 36);
            this.CourseLanguageTextBox.TabIndex = 16;
            // 
            // CourseLanguageLabel
            // 
            this.CourseLanguageLabel.AutoSize = true;
            this.CourseLanguageLabel.Location = new System.Drawing.Point(626, 226);
            this.CourseLanguageLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CourseLanguageLabel.Name = "CourseLanguageLabel";
            this.CourseLanguageLabel.Size = new System.Drawing.Size(106, 24);
            this.CourseLanguageLabel.TabIndex = 4;
            this.CourseLanguageLabel.Text = "授課語言";
            // 
            // CourseTAsTextBox
            // 
            this.CourseTAsTextBox.Location = new System.Drawing.Point(127, 210);
            this.CourseTAsTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CourseTAsTextBox.Name = "CourseTAsTextBox";
            this.CourseTAsTextBox.Size = new System.Drawing.Size(487, 36);
            this.CourseTAsTextBox.TabIndex = 15;
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
            this.CourseTypeComboBox.Location = new System.Drawing.Point(1084, 126);
            this.CourseTypeComboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CourseTypeComboBox.Name = "CourseTypeComboBox";
            this.CourseTypeComboBox.Size = new System.Drawing.Size(215, 32);
            this.CourseTypeComboBox.TabIndex = 13;
            // 
            // CourseTypeLabel
            // 
            this.CourseTypeLabel.AutoSize = true;
            this.CourseTypeLabel.Location = new System.Drawing.Point(1011, 139);
            this.CourseTypeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CourseTypeLabel.Name = "CourseTypeLabel";
            this.CourseTypeLabel.Size = new System.Drawing.Size(61, 24);
            this.CourseTypeLabel.TabIndex = 12;
            this.CourseTypeLabel.Text = "修(*)";
            // 
            // CourseTeacherTextBox
            // 
            this.CourseTeacherTextBox.Location = new System.Drawing.Point(722, 123);
            this.CourseTeacherTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CourseTeacherTextBox.Name = "CourseTeacherTextBox";
            this.CourseTeacherTextBox.Size = new System.Drawing.Size(277, 36);
            this.CourseTeacherTextBox.TabIndex = 11;
            // 
            // CourseTeacherLabel
            // 
            this.CourseTeacherLabel.AutoSize = true;
            this.CourseTeacherLabel.Location = new System.Drawing.Point(624, 139);
            this.CourseTeacherLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CourseTeacherLabel.Name = "CourseTeacherLabel";
            this.CourseTeacherLabel.Size = new System.Drawing.Size(85, 24);
            this.CourseTeacherLabel.TabIndex = 10;
            this.CourseTeacherLabel.Text = "教師(*)";
            // 
            // CourseCreditTextBox
            // 
            this.CourseCreditTextBox.Location = new System.Drawing.Point(372, 123);
            this.CourseCreditTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CourseCreditTextBox.Name = "CourseCreditTextBox";
            this.CourseCreditTextBox.Size = new System.Drawing.Size(241, 36);
            this.CourseCreditTextBox.TabIndex = 9;
            // 
            // CourseCreditLabel
            // 
            this.CourseCreditLabel.AutoSize = true;
            this.CourseCreditLabel.Location = new System.Drawing.Point(275, 139);
            this.CourseCreditLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CourseCreditLabel.Name = "CourseCreditLabel";
            this.CourseCreditLabel.Size = new System.Drawing.Size(85, 24);
            this.CourseCreditLabel.TabIndex = 8;
            this.CourseCreditLabel.Text = "學分(*)";
            // 
            // CourseLevelTextBox
            // 
            this.CourseLevelTextBox.Location = new System.Drawing.Point(102, 123);
            this.CourseLevelTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CourseLevelTextBox.Name = "CourseLevelTextBox";
            this.CourseLevelTextBox.Size = new System.Drawing.Size(160, 36);
            this.CourseLevelTextBox.TabIndex = 7;
            // 
            // CourseNameTextBox
            // 
            this.CourseNameTextBox.Location = new System.Drawing.Point(769, 32);
            this.CourseNameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CourseNameTextBox.Name = "CourseNameTextBox";
            this.CourseNameTextBox.Size = new System.Drawing.Size(530, 36);
            this.CourseNameTextBox.TabIndex = 6;
            // 
            // CourseNumberTextBox
            // 
            this.CourseNumberTextBox.Location = new System.Drawing.Point(340, 32);
            this.CourseNumberTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CourseNumberTextBox.Name = "CourseNumberTextBox";
            this.CourseNumberTextBox.Size = new System.Drawing.Size(274, 36);
            this.CourseNumberTextBox.TabIndex = 5;
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
            this.CourseNameLabel.Location = new System.Drawing.Point(624, 48);
            this.CourseNameLabel.Name = "CourseNameLabel";
            this.CourseNameLabel.Size = new System.Drawing.Size(133, 24);
            this.CourseNameLabel.TabIndex = 3;
            this.CourseNameLabel.Text = "課程名稱(*)";
            // 
            // CourseNumberLabel
            // 
            this.CourseNumberLabel.AutoSize = true;
            this.CourseNumberLabel.Location = new System.Drawing.Point(244, 48);
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
            this.CourseEnabledComboBox.Size = new System.Drawing.Size(228, 32);
            this.CourseEnabledComboBox.TabIndex = 1;
            // 
            // CourseSectionEditGridView
            // 
            this.CourseSectionEditGridView.AllowUserToAddRows = false;
            this.CourseSectionEditGridView.AllowUserToDeleteRows = false;
            this.CourseSectionEditGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CourseSectionEditGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.CourseSectionEditGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseSectionEditGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseSectionColumn,
            this.SundaySectionColumn,
            this.MondaySectionColumn,
            this.TuesdaySectionColumn,
            this.WednesdaySectionColumn,
            this.ThursdaySectionColumn,
            this.FridaySectionColumn,
            this.SaturdaySectionColumn});
            this.CourseSectionEditGridView.Location = new System.Drawing.Point(6, 491);
            this.CourseSectionEditGridView.Name = "CourseSectionEditGridView";
            this.CourseSectionEditGridView.ReadOnly = true;
            this.CourseSectionEditGridView.RowHeadersVisible = false;
            this.CourseSectionEditGridView.RowHeadersWidth = 82;
            this.CourseSectionEditGridView.RowTemplate.Height = 38;
            this.CourseSectionEditGridView.Size = new System.Drawing.Size(1295, 493);
            this.CourseSectionEditGridView.TabIndex = 0;
            this.CourseSectionEditGridView.VirtualMode = true;
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
            this.AddCourseButton.Location = new System.Drawing.Point(6, 1003);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(561, 98);
            this.AddCourseButton.TabIndex = 0;
            this.AddCourseButton.Text = "新增課程";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            // 
            // ClassManageTabPage
            // 
            this.ClassManageTabPage.Location = new System.Drawing.Point(8, 39);
            this.ClassManageTabPage.Name = "ClassManageTabPage";
            this.ClassManageTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.ClassManageTabPage.Size = new System.Drawing.Size(1890, 1111);
            this.ClassManageTabPage.TabIndex = 1;
            this.ClassManageTabPage.Text = "班級管理";
            this.ClassManageTabPage.UseVisualStyleBackColor = true;
            // 
            // CourseManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1930, 1194);
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
            ((System.ComponentModel.ISupportInitialize)(this.CourseSectionEditGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView CourseSectionEditGridView;
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