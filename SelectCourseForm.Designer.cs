namespace CourseCrawler
{
    partial class SelectCourseForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectCourseForm));
            this.courseGridView = new System.Windows.Forms.DataGridView();
            this.coursePanel = new System.Windows.Forms.Panel();
            this.submitCourseSelectionButton = new System.Windows.Forms.Button();
            this.getCourseSelectResultbutton = new System.Windows.Forms.Button();
            this.CourseSelectionBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CourseNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseLevelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseCreditColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseHourColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseTeacherColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SundayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MondayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuesdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WednesdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThursdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FridayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaturdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassroomColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinedPeopleAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GivenUpPeopleAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseAssistantColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeachingLanguageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutlineAndProgressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemarkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttachedPeopleAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsExperimentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).BeginInit();
            this.coursePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseGridView
            // 
            this.courseGridView.AllowUserToAddRows = false;
            this.courseGridView.AllowUserToDeleteRows = false;
            this.courseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseSelectionBoxColumn,
            this.CourseNumberColumn,
            this.CourseNameColumn,
            this.CourseLevelColumn,
            this.CourseCreditColumn,
            this.CourseHourColumn,
            this.CourseTypeColumn,
            this.CourseTeacherColumn,
            this.SundayColumn,
            this.MondayColumn,
            this.TuesdayColumn,
            this.WednesdayColumn,
            this.ThursdayColumn,
            this.FridayColumn,
            this.SaturdayColumn,
            this.ClassroomColumn,
            this.JoinedPeopleAmountColumn,
            this.GivenUpPeopleAmountColumn,
            this.CourseAssistantColumn,
            this.TeachingLanguageColumn,
            this.OutlineAndProgressColumn,
            this.RemarkColumn,
            this.AttachedPeopleAmountColumn,
            this.IsExperimentColumn});
            this.courseGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseGridView.Location = new System.Drawing.Point(0, 0);
            this.courseGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.courseGridView.Name = "courseGridView";
            this.courseGridView.ReadOnly = true;
            this.courseGridView.RowHeadersVisible = false;
            this.courseGridView.RowHeadersWidth = 51;
            this.courseGridView.RowTemplate.Height = 27;
            this.courseGridView.Size = new System.Drawing.Size(1238, 557);
            this.courseGridView.TabIndex = 0;
            // 
            // coursePanel
            // 
            this.coursePanel.Controls.Add(this.courseGridView);
            this.coursePanel.Location = new System.Drawing.Point(12, 13);
            this.coursePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.coursePanel.Name = "coursePanel";
            this.coursePanel.Size = new System.Drawing.Size(1238, 557);
            this.coursePanel.TabIndex = 1;
            // 
            // submitCourseSelectionButton
            // 
            this.submitCourseSelectionButton.Enabled = false;
            this.submitCourseSelectionButton.Location = new System.Drawing.Point(680, 615);
            this.submitCourseSelectionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.submitCourseSelectionButton.Name = "submitCourseSelectionButton";
            this.submitCourseSelectionButton.Size = new System.Drawing.Size(282, 75);
            this.submitCourseSelectionButton.TabIndex = 2;
            this.submitCourseSelectionButton.Text = "確認送出";
            this.submitCourseSelectionButton.UseVisualStyleBackColor = true;
            // 
            // getCourseSelectResultbutton
            // 
            this.getCourseSelectResultbutton.Location = new System.Drawing.Point(968, 615);
            this.getCourseSelectResultbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.getCourseSelectResultbutton.Name = "getCourseSelectResultbutton";
            this.getCourseSelectResultbutton.Size = new System.Drawing.Size(282, 75);
            this.getCourseSelectResultbutton.TabIndex = 3;
            this.getCourseSelectResultbutton.Text = "查看選課結果";
            this.getCourseSelectResultbutton.UseVisualStyleBackColor = true;
            // 
            // CourseSelectionBoxColumn
            // 
            this.CourseSelectionBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CourseSelectionBoxColumn.HeaderText = "選";
            this.CourseSelectionBoxColumn.MinimumWidth = 6;
            this.CourseSelectionBoxColumn.Name = "CourseSelectionBoxColumn";
            this.CourseSelectionBoxColumn.ReadOnly = true;
            this.CourseSelectionBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseSelectionBoxColumn.Width = 30;
            // 
            // CourseNumberColumn
            // 
            this.CourseNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CourseNumberColumn.HeaderText = "課號";
            this.CourseNumberColumn.MinimumWidth = 6;
            this.CourseNumberColumn.Name = "CourseNumberColumn";
            this.CourseNumberColumn.ReadOnly = true;
            this.CourseNumberColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseNumberColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CourseNumberColumn.Width = 45;
            // 
            // CourseNameColumn
            // 
            this.CourseNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CourseNameColumn.HeaderText = "課程名稱";
            this.CourseNameColumn.MinimumWidth = 6;
            this.CourseNameColumn.Name = "CourseNameColumn";
            this.CourseNameColumn.ReadOnly = true;
            this.CourseNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CourseNameColumn.Width = 75;
            // 
            // CourseLevelColumn
            // 
            this.CourseLevelColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CourseLevelColumn.HeaderText = "階段";
            this.CourseLevelColumn.MinimumWidth = 6;
            this.CourseLevelColumn.Name = "CourseLevelColumn";
            this.CourseLevelColumn.ReadOnly = true;
            this.CourseLevelColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseLevelColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CourseLevelColumn.Width = 45;
            // 
            // CourseCreditColumn
            // 
            this.CourseCreditColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CourseCreditColumn.HeaderText = "學分";
            this.CourseCreditColumn.MinimumWidth = 6;
            this.CourseCreditColumn.Name = "CourseCreditColumn";
            this.CourseCreditColumn.ReadOnly = true;
            this.CourseCreditColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseCreditColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CourseCreditColumn.Width = 45;
            // 
            // CourseHourColumn
            // 
            this.CourseHourColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CourseHourColumn.HeaderText = "時數";
            this.CourseHourColumn.MinimumWidth = 6;
            this.CourseHourColumn.Name = "CourseHourColumn";
            this.CourseHourColumn.ReadOnly = true;
            this.CourseHourColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseHourColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CourseHourColumn.Width = 45;
            // 
            // CourseTypeColumn
            // 
            this.CourseTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CourseTypeColumn.HeaderText = "修";
            this.CourseTypeColumn.MinimumWidth = 6;
            this.CourseTypeColumn.Name = "CourseTypeColumn";
            this.CourseTypeColumn.ReadOnly = true;
            this.CourseTypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseTypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CourseTypeColumn.Width = 30;
            // 
            // CourseTeacherColumn
            // 
            this.CourseTeacherColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CourseTeacherColumn.HeaderText = "教師";
            this.CourseTeacherColumn.MinimumWidth = 6;
            this.CourseTeacherColumn.Name = "CourseTeacherColumn";
            this.CourseTeacherColumn.ReadOnly = true;
            this.CourseTeacherColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseTeacherColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CourseTeacherColumn.Width = 45;
            // 
            // SundayColumn
            // 
            this.SundayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SundayColumn.HeaderText = "日";
            this.SundayColumn.MinimumWidth = 6;
            this.SundayColumn.Name = "SundayColumn";
            this.SundayColumn.ReadOnly = true;
            this.SundayColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SundayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SundayColumn.Width = 30;
            // 
            // MondayColumn
            // 
            this.MondayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MondayColumn.HeaderText = "一";
            this.MondayColumn.MinimumWidth = 6;
            this.MondayColumn.Name = "MondayColumn";
            this.MondayColumn.ReadOnly = true;
            this.MondayColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MondayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MondayColumn.Width = 30;
            // 
            // TuesdayColumn
            // 
            this.TuesdayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TuesdayColumn.HeaderText = "二";
            this.TuesdayColumn.MinimumWidth = 6;
            this.TuesdayColumn.Name = "TuesdayColumn";
            this.TuesdayColumn.ReadOnly = true;
            this.TuesdayColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TuesdayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TuesdayColumn.Width = 30;
            // 
            // WednesdayColumn
            // 
            this.WednesdayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.WednesdayColumn.HeaderText = "三";
            this.WednesdayColumn.MinimumWidth = 6;
            this.WednesdayColumn.Name = "WednesdayColumn";
            this.WednesdayColumn.ReadOnly = true;
            this.WednesdayColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.WednesdayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WednesdayColumn.Width = 30;
            // 
            // ThursdayColumn
            // 
            this.ThursdayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ThursdayColumn.HeaderText = "四";
            this.ThursdayColumn.MinimumWidth = 6;
            this.ThursdayColumn.Name = "ThursdayColumn";
            this.ThursdayColumn.ReadOnly = true;
            this.ThursdayColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ThursdayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ThursdayColumn.Width = 30;
            // 
            // FridayColumn
            // 
            this.FridayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FridayColumn.HeaderText = "五";
            this.FridayColumn.MinimumWidth = 6;
            this.FridayColumn.Name = "FridayColumn";
            this.FridayColumn.ReadOnly = true;
            this.FridayColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FridayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FridayColumn.Width = 30;
            // 
            // SaturdayColumn
            // 
            this.SaturdayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SaturdayColumn.HeaderText = "六";
            this.SaturdayColumn.MinimumWidth = 6;
            this.SaturdayColumn.Name = "SaturdayColumn";
            this.SaturdayColumn.ReadOnly = true;
            this.SaturdayColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SaturdayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SaturdayColumn.Width = 30;
            // 
            // ClassroomColumn
            // 
            this.ClassroomColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ClassroomColumn.HeaderText = "教室";
            this.ClassroomColumn.MinimumWidth = 6;
            this.ClassroomColumn.Name = "ClassroomColumn";
            this.ClassroomColumn.ReadOnly = true;
            this.ClassroomColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClassroomColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ClassroomColumn.Width = 45;
            // 
            // JoinedPeopleAmountColumn
            // 
            this.JoinedPeopleAmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.JoinedPeopleAmountColumn.HeaderText = "人";
            this.JoinedPeopleAmountColumn.MinimumWidth = 6;
            this.JoinedPeopleAmountColumn.Name = "JoinedPeopleAmountColumn";
            this.JoinedPeopleAmountColumn.ReadOnly = true;
            this.JoinedPeopleAmountColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.JoinedPeopleAmountColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.JoinedPeopleAmountColumn.Width = 30;
            // 
            // GivenUpPeopleAmountColumn
            // 
            this.GivenUpPeopleAmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.GivenUpPeopleAmountColumn.HeaderText = "撤";
            this.GivenUpPeopleAmountColumn.MinimumWidth = 6;
            this.GivenUpPeopleAmountColumn.Name = "GivenUpPeopleAmountColumn";
            this.GivenUpPeopleAmountColumn.ReadOnly = true;
            this.GivenUpPeopleAmountColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GivenUpPeopleAmountColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GivenUpPeopleAmountColumn.Width = 30;
            // 
            // CourseAssistantColumn
            // 
            this.CourseAssistantColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CourseAssistantColumn.HeaderText = "教學助理";
            this.CourseAssistantColumn.MinimumWidth = 6;
            this.CourseAssistantColumn.Name = "CourseAssistantColumn";
            this.CourseAssistantColumn.ReadOnly = true;
            this.CourseAssistantColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseAssistantColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CourseAssistantColumn.Width = 75;
            // 
            // TeachingLanguageColumn
            // 
            this.TeachingLanguageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TeachingLanguageColumn.HeaderText = "授課語言";
            this.TeachingLanguageColumn.MinimumWidth = 6;
            this.TeachingLanguageColumn.Name = "TeachingLanguageColumn";
            this.TeachingLanguageColumn.ReadOnly = true;
            this.TeachingLanguageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TeachingLanguageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TeachingLanguageColumn.Width = 75;
            // 
            // OutlineAndProgressColumn
            // 
            this.OutlineAndProgressColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.OutlineAndProgressColumn.HeaderText = "教學大綱與進度表";
            this.OutlineAndProgressColumn.MinimumWidth = 6;
            this.OutlineAndProgressColumn.Name = "OutlineAndProgressColumn";
            this.OutlineAndProgressColumn.ReadOnly = true;
            this.OutlineAndProgressColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OutlineAndProgressColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OutlineAndProgressColumn.Width = 81;
            // 
            // RemarkColumn
            // 
            this.RemarkColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RemarkColumn.HeaderText = "備註";
            this.RemarkColumn.MinimumWidth = 6;
            this.RemarkColumn.Name = "RemarkColumn";
            this.RemarkColumn.ReadOnly = true;
            this.RemarkColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RemarkColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RemarkColumn.Width = 41;
            // 
            // AttachedPeopleAmountColumn
            // 
            this.AttachedPeopleAmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AttachedPeopleAmountColumn.HeaderText = "隨班附讀";
            this.AttachedPeopleAmountColumn.MinimumWidth = 6;
            this.AttachedPeopleAmountColumn.Name = "AttachedPeopleAmountColumn";
            this.AttachedPeopleAmountColumn.ReadOnly = true;
            this.AttachedPeopleAmountColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AttachedPeopleAmountColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AttachedPeopleAmountColumn.Width = 54;
            // 
            // IsExperimentColumn
            // 
            this.IsExperimentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IsExperimentColumn.HeaderText = "實驗實習";
            this.IsExperimentColumn.MinimumWidth = 6;
            this.IsExperimentColumn.Name = "IsExperimentColumn";
            this.IsExperimentColumn.ReadOnly = true;
            this.IsExperimentColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IsExperimentColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IsExperimentColumn.Width = 54;
            // 
            // SelectCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1262, 703);
            this.Controls.Add(this.submitCourseSelectionButton);
            this.Controls.Add(this.coursePanel);
            this.Controls.Add(this.getCourseSelectResultbutton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SelectCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseCrawler by Xanonymous";
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).EndInit();
            this.coursePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView courseGridView;
        private System.Windows.Forms.Panel coursePanel;
        private System.Windows.Forms.Button submitCourseSelectionButton;
        private System.Windows.Forms.Button getCourseSelectResultbutton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CourseSelectionBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseLevelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseCreditColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseHourColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseTeacherColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SundayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MondayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuesdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WednesdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThursdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FridayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaturdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassroomColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoinedPeopleAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GivenUpPeopleAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseAssistantColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeachingLanguageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutlineAndProgressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemarkColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttachedPeopleAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsExperimentColumn;
    }
}

