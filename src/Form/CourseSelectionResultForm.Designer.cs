namespace CourseCrawler
{
    partial class CourseSelectionResultForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseSelectionResultForm));
            this.CoursePanel = new System.Windows.Forms.Panel();
            this.CourseGridView = new System.Windows.Forms.DataGridView();
            this.UnselectCourseButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CourseNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseLevelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseCreditColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseHourColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseTeachersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SundayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MondayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuesdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WednesdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThursdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FridayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaturdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassroomsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GivenUpStudentAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanguageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutlineAndProgressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemarkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttachedStudentAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsExperimentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoursePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CoursePanel
            // 
            this.CoursePanel.Controls.Add(this.CourseGridView);
            this.CoursePanel.Location = new System.Drawing.Point(11, 10);
            this.CoursePanel.Name = "CoursePanel";
            this.CoursePanel.Size = new System.Drawing.Size(1029, 416);
            this.CoursePanel.TabIndex = 2;
            // 
            // CourseGridView
            // 
            this.CourseGridView.AllowUserToAddRows = false;
            this.CourseGridView.AllowUserToDeleteRows = false;
            this.CourseGridView.AllowUserToResizeColumns = false;
            this.CourseGridView.AllowUserToResizeRows = false;
            this.CourseGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.CourseGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.CourseGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.CourseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UnselectCourseButtonColumn,
            this.CourseNumberColumn,
            this.CourseNameColumn,
            this.CourseLevelColumn,
            this.CourseCreditColumn,
            this.CourseHourColumn,
            this.CourseTypeColumn,
            this.CourseTeachersColumn,
            this.SundayColumn,
            this.MondayColumn,
            this.TuesdayColumn,
            this.WednesdayColumn,
            this.ThursdayColumn,
            this.FridayColumn,
            this.SaturdayColumn,
            this.ClassroomsColumn,
            this.StudentAmountColumn,
            this.GivenUpStudentAmountColumn,
            this.TAsColumn,
            this.LanguageColumn,
            this.OutlineAndProgressColumn,
            this.RemarkColumn,
            this.AttachedStudentAmountColumn,
            this.IsExperimentColumn});
            this.CourseGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CourseGridView.Location = new System.Drawing.Point(0, 0);
            this.CourseGridView.MultiSelect = false;
            this.CourseGridView.Name = "CourseGridView";
            this.CourseGridView.ReadOnly = true;
            this.CourseGridView.RowHeadersVisible = false;
            this.CourseGridView.RowHeadersWidth = 51;
            this.CourseGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CourseGridView.RowTemplate.Height = 27;
            this.CourseGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.CourseGridView.Size = new System.Drawing.Size(1029, 416);
            this.CourseGridView.TabIndex = 0;
            this.CourseGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseGridView_CellContentClick);
            // 
            // UnselectCourseButtonColumn
            // 
            this.UnselectCourseButtonColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.UnselectCourseButtonColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.UnselectCourseButtonColumn.HeaderText = "退";
            this.UnselectCourseButtonColumn.MinimumWidth = 60;
            this.UnselectCourseButtonColumn.Name = "UnselectCourseButtonColumn";
            this.UnselectCourseButtonColumn.ReadOnly = true;
            this.UnselectCourseButtonColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UnselectCourseButtonColumn.Width = 60;
            // 
            // CourseNumberColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CourseNumberColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.CourseNumberColumn.HeaderText = "課號";
            this.CourseNumberColumn.MinimumWidth = 6;
            this.CourseNumberColumn.Name = "CourseNumberColumn";
            this.CourseNumberColumn.ReadOnly = true;
            this.CourseNumberColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseNumberColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CourseNumberColumn.Width = 43;
            // 
            // CourseNameColumn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CourseNameColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.CourseNameColumn.HeaderText = "課程名稱";
            this.CourseNameColumn.MinimumWidth = 6;
            this.CourseNameColumn.Name = "CourseNameColumn";
            this.CourseNameColumn.ReadOnly = true;
            this.CourseNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CourseNameColumn.Width = 73;
            // 
            // CourseLevelColumn
            // 
            this.CourseLevelColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CourseLevelColumn.HeaderText = "階段";
            this.CourseLevelColumn.MinimumWidth = 40;
            this.CourseLevelColumn.Name = "CourseLevelColumn";
            this.CourseLevelColumn.ReadOnly = true;
            this.CourseLevelColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseLevelColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CourseLevelColumn.Width = 43;
            // 
            // CourseCreditColumn
            // 
            this.CourseCreditColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CourseCreditColumn.HeaderText = "學分";
            this.CourseCreditColumn.MinimumWidth = 40;
            this.CourseCreditColumn.Name = "CourseCreditColumn";
            this.CourseCreditColumn.ReadOnly = true;
            this.CourseCreditColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseCreditColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CourseCreditColumn.Width = 43;
            // 
            // CourseHourColumn
            // 
            this.CourseHourColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CourseHourColumn.HeaderText = "時數";
            this.CourseHourColumn.MinimumWidth = 40;
            this.CourseHourColumn.Name = "CourseHourColumn";
            this.CourseHourColumn.ReadOnly = true;
            this.CourseHourColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseHourColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CourseHourColumn.Width = 43;
            // 
            // CourseTypeColumn
            // 
            this.CourseTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CourseTypeColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.CourseTypeColumn.HeaderText = "修";
            this.CourseTypeColumn.MinimumWidth = 6;
            this.CourseTypeColumn.Name = "CourseTypeColumn";
            this.CourseTypeColumn.ReadOnly = true;
            this.CourseTypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseTypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CourseTypeColumn.Width = 28;
            // 
            // CourseTeachersColumn
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CourseTeachersColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.CourseTeachersColumn.HeaderText = "教師";
            this.CourseTeachersColumn.MinimumWidth = 80;
            this.CourseTeachersColumn.Name = "CourseTeachersColumn";
            this.CourseTeachersColumn.ReadOnly = true;
            this.CourseTeachersColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseTeachersColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CourseTeachersColumn.Width = 80;
            // 
            // SundayColumn
            // 
            this.SundayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SundayColumn.HeaderText = "日";
            this.SundayColumn.MinimumWidth = 60;
            this.SundayColumn.Name = "SundayColumn";
            this.SundayColumn.ReadOnly = true;
            this.SundayColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SundayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SundayColumn.Width = 60;
            // 
            // MondayColumn
            // 
            this.MondayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MondayColumn.HeaderText = "一";
            this.MondayColumn.MinimumWidth = 60;
            this.MondayColumn.Name = "MondayColumn";
            this.MondayColumn.ReadOnly = true;
            this.MondayColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MondayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MondayColumn.Width = 60;
            // 
            // TuesdayColumn
            // 
            this.TuesdayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TuesdayColumn.HeaderText = "二";
            this.TuesdayColumn.MinimumWidth = 60;
            this.TuesdayColumn.Name = "TuesdayColumn";
            this.TuesdayColumn.ReadOnly = true;
            this.TuesdayColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TuesdayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TuesdayColumn.Width = 60;
            // 
            // WednesdayColumn
            // 
            this.WednesdayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.WednesdayColumn.HeaderText = "三";
            this.WednesdayColumn.MinimumWidth = 60;
            this.WednesdayColumn.Name = "WednesdayColumn";
            this.WednesdayColumn.ReadOnly = true;
            this.WednesdayColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.WednesdayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WednesdayColumn.Width = 60;
            // 
            // ThursdayColumn
            // 
            this.ThursdayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ThursdayColumn.HeaderText = "四";
            this.ThursdayColumn.MinimumWidth = 60;
            this.ThursdayColumn.Name = "ThursdayColumn";
            this.ThursdayColumn.ReadOnly = true;
            this.ThursdayColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ThursdayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ThursdayColumn.Width = 60;
            // 
            // FridayColumn
            // 
            this.FridayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FridayColumn.HeaderText = "五";
            this.FridayColumn.MinimumWidth = 60;
            this.FridayColumn.Name = "FridayColumn";
            this.FridayColumn.ReadOnly = true;
            this.FridayColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FridayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FridayColumn.Width = 60;
            // 
            // SaturdayColumn
            // 
            this.SaturdayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SaturdayColumn.HeaderText = "六";
            this.SaturdayColumn.MinimumWidth = 60;
            this.SaturdayColumn.Name = "SaturdayColumn";
            this.SaturdayColumn.ReadOnly = true;
            this.SaturdayColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SaturdayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SaturdayColumn.Width = 60;
            // 
            // ClassroomsColumn
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassroomsColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.ClassroomsColumn.HeaderText = "教室";
            this.ClassroomsColumn.MinimumWidth = 200;
            this.ClassroomsColumn.Name = "ClassroomsColumn";
            this.ClassroomsColumn.ReadOnly = true;
            this.ClassroomsColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClassroomsColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ClassroomsColumn.Width = 200;
            // 
            // StudentAmountColumn
            // 
            this.StudentAmountColumn.HeaderText = "人";
            this.StudentAmountColumn.MinimumWidth = 30;
            this.StudentAmountColumn.Name = "StudentAmountColumn";
            this.StudentAmountColumn.ReadOnly = true;
            this.StudentAmountColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentAmountColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StudentAmountColumn.Width = 30;
            // 
            // GivenUpStudentAmountColumn
            // 
            this.GivenUpStudentAmountColumn.HeaderText = "撤";
            this.GivenUpStudentAmountColumn.MinimumWidth = 30;
            this.GivenUpStudentAmountColumn.Name = "GivenUpStudentAmountColumn";
            this.GivenUpStudentAmountColumn.ReadOnly = true;
            this.GivenUpStudentAmountColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GivenUpStudentAmountColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GivenUpStudentAmountColumn.Width = 30;
            // 
            // TAsColumn
            // 
            this.TAsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TAsColumn.HeaderText = "教學助理";
            this.TAsColumn.MinimumWidth = 6;
            this.TAsColumn.Name = "TAsColumn";
            this.TAsColumn.ReadOnly = true;
            this.TAsColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TAsColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TAsColumn.Width = 73;
            // 
            // LanguageColumn
            // 
            this.LanguageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LanguageColumn.HeaderText = "授課語言";
            this.LanguageColumn.MinimumWidth = 6;
            this.LanguageColumn.Name = "LanguageColumn";
            this.LanguageColumn.ReadOnly = true;
            this.LanguageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LanguageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LanguageColumn.Width = 73;
            // 
            // OutlineAndProgressColumn
            // 
            this.OutlineAndProgressColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OutlineAndProgressColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.OutlineAndProgressColumn.HeaderText = "教學大綱與進度表";
            this.OutlineAndProgressColumn.MinimumWidth = 75;
            this.OutlineAndProgressColumn.Name = "OutlineAndProgressColumn";
            this.OutlineAndProgressColumn.ReadOnly = true;
            this.OutlineAndProgressColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OutlineAndProgressColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OutlineAndProgressColumn.Width = 75;
            // 
            // RemarkColumn
            // 
            this.RemarkColumn.HeaderText = "備註";
            this.RemarkColumn.MinimumWidth = 200;
            this.RemarkColumn.Name = "RemarkColumn";
            this.RemarkColumn.ReadOnly = true;
            this.RemarkColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RemarkColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RemarkColumn.Width = 200;
            // 
            // AttachedStudentAmountColumn
            // 
            this.AttachedStudentAmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AttachedStudentAmountColumn.HeaderText = "隨班附讀";
            this.AttachedStudentAmountColumn.MinimumWidth = 6;
            this.AttachedStudentAmountColumn.Name = "AttachedStudentAmountColumn";
            this.AttachedStudentAmountColumn.ReadOnly = true;
            this.AttachedStudentAmountColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AttachedStudentAmountColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AttachedStudentAmountColumn.Width = 52;
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
            this.IsExperimentColumn.Width = 52;
            // 
            // CourseSelectionResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 437);
            this.Controls.Add(this.CoursePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "CourseSelectionResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Selection Result";
            this.Load += new System.EventHandler(this.CourseSelectionResultForm_Load);
            this.CoursePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CourseGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CoursePanel;
        private System.Windows.Forms.DataGridView CourseGridView;
        private System.Windows.Forms.DataGridViewButtonColumn UnselectCourseButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseLevelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseCreditColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseHourColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseTeachersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SundayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MondayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuesdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WednesdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThursdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FridayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaturdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassroomsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GivenUpStudentAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanguageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutlineAndProgressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemarkColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttachedStudentAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsExperimentColumn;
    }
}