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
            this.ClassManageTabPage = new System.Windows.Forms.TabPage();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.EditCourseGroupBox = new System.Windows.Forms.GroupBox();
            this.CourseListBox = new System.Windows.Forms.ListBox();
            this.SaveCourseButton = new System.Windows.Forms.Button();
            this.CourseSectionEditGridView = new System.Windows.Forms.DataGridView();
            this.CourseSectionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SundaySectionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MondaySectionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TuesdaySectionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.WednesdaySectionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ThursdaySectionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FridaySectionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SaturdaySectionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CourseToEditComboBox = new System.Windows.Forms.ComboBox();
            this.CourseNumberLabel = new System.Windows.Forms.Label();
            this.CourseNameLabel = new System.Windows.Forms.Label();
            this.CourseLevelLabel = new System.Windows.Forms.Label();
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
            this.ManagementTabControll.Location = new System.Drawing.Point(12, 12);
            this.ManagementTabControll.Name = "ManagementTabControll";
            this.ManagementTabControll.SelectedIndex = 0;
            this.ManagementTabControll.Size = new System.Drawing.Size(2413, 1372);
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
            this.CourseManageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CourseManageTabPage.Size = new System.Drawing.Size(2397, 1325);
            this.CourseManageTabPage.TabIndex = 0;
            this.CourseManageTabPage.Text = "課程管理";
            this.CourseManageTabPage.UseVisualStyleBackColor = true;
            // 
            // ClassManageTabPage
            // 
            this.ClassManageTabPage.Location = new System.Drawing.Point(8, 39);
            this.ClassManageTabPage.Name = "ClassManageTabPage";
            this.ClassManageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassManageTabPage.Size = new System.Drawing.Size(2397, 1325);
            this.ClassManageTabPage.TabIndex = 1;
            this.ClassManageTabPage.Text = "班級管理";
            this.ClassManageTabPage.UseVisualStyleBackColor = true;
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(6, 1222);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(561, 97);
            this.AddCourseButton.TabIndex = 0;
            this.AddCourseButton.Text = "新增課程";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            // 
            // EditCourseGroupBox
            // 
            this.EditCourseGroupBox.Controls.Add(this.CourseLevelLabel);
            this.EditCourseGroupBox.Controls.Add(this.CourseNameLabel);
            this.EditCourseGroupBox.Controls.Add(this.CourseNumberLabel);
            this.EditCourseGroupBox.Controls.Add(this.CourseToEditComboBox);
            this.EditCourseGroupBox.Controls.Add(this.CourseSectionEditGridView);
            this.EditCourseGroupBox.Location = new System.Drawing.Point(573, 6);
            this.EditCourseGroupBox.Name = "EditCourseGroupBox";
            this.EditCourseGroupBox.Size = new System.Drawing.Size(1818, 1204);
            this.EditCourseGroupBox.TabIndex = 1;
            this.EditCourseGroupBox.TabStop = false;
            this.EditCourseGroupBox.Text = "編輯課程";
            // 
            // CourseListBox
            // 
            this.CourseListBox.FormattingEnabled = true;
            this.CourseListBox.ItemHeight = 24;
            this.CourseListBox.Location = new System.Drawing.Point(6, 6);
            this.CourseListBox.Name = "CourseListBox";
            this.CourseListBox.Size = new System.Drawing.Size(561, 1204);
            this.CourseListBox.TabIndex = 2;
            // 
            // SaveCourseButton
            // 
            this.SaveCourseButton.Location = new System.Drawing.Point(2109, 1222);
            this.SaveCourseButton.Name = "SaveCourseButton";
            this.SaveCourseButton.Size = new System.Drawing.Size(282, 97);
            this.SaveCourseButton.TabIndex = 3;
            this.SaveCourseButton.Text = "儲存";
            this.SaveCourseButton.UseVisualStyleBackColor = true;
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
            this.CourseSectionEditGridView.Location = new System.Drawing.Point(6, 553);
            this.CourseSectionEditGridView.Name = "CourseSectionEditGridView";
            this.CourseSectionEditGridView.ReadOnly = true;
            this.CourseSectionEditGridView.RowHeadersVisible = false;
            this.CourseSectionEditGridView.RowHeadersWidth = 82;
            this.CourseSectionEditGridView.RowTemplate.Height = 38;
            this.CourseSectionEditGridView.Size = new System.Drawing.Size(1806, 645);
            this.CourseSectionEditGridView.TabIndex = 0;
            this.CourseSectionEditGridView.VirtualMode = true;
            // 
            // CourseSectionColumn
            // 
            this.CourseSectionColumn.HeaderText = "節數";
            this.CourseSectionColumn.MinimumWidth = 10;
            this.CourseSectionColumn.Name = "CourseSectionColumn";
            this.CourseSectionColumn.ReadOnly = true;
            // 
            // SundaySectionColumn
            // 
            this.SundaySectionColumn.HeaderText = "日";
            this.SundaySectionColumn.MinimumWidth = 10;
            this.SundaySectionColumn.Name = "SundaySectionColumn";
            this.SundaySectionColumn.ReadOnly = true;
            // 
            // MondaySectionColumn
            // 
            this.MondaySectionColumn.HeaderText = "一";
            this.MondaySectionColumn.MinimumWidth = 10;
            this.MondaySectionColumn.Name = "MondaySectionColumn";
            this.MondaySectionColumn.ReadOnly = true;
            // 
            // TuesdaySectionColumn
            // 
            this.TuesdaySectionColumn.HeaderText = "二";
            this.TuesdaySectionColumn.MinimumWidth = 10;
            this.TuesdaySectionColumn.Name = "TuesdaySectionColumn";
            this.TuesdaySectionColumn.ReadOnly = true;
            this.TuesdaySectionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TuesdaySectionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // WednesdaySectionColumn
            // 
            this.WednesdaySectionColumn.HeaderText = "三";
            this.WednesdaySectionColumn.MinimumWidth = 10;
            this.WednesdaySectionColumn.Name = "WednesdaySectionColumn";
            this.WednesdaySectionColumn.ReadOnly = true;
            this.WednesdaySectionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WednesdaySectionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ThursdaySectionColumn
            // 
            this.ThursdaySectionColumn.HeaderText = "四";
            this.ThursdaySectionColumn.MinimumWidth = 10;
            this.ThursdaySectionColumn.Name = "ThursdaySectionColumn";
            this.ThursdaySectionColumn.ReadOnly = true;
            this.ThursdaySectionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ThursdaySectionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FridaySectionColumn
            // 
            this.FridaySectionColumn.HeaderText = "五";
            this.FridaySectionColumn.MinimumWidth = 10;
            this.FridaySectionColumn.Name = "FridaySectionColumn";
            this.FridaySectionColumn.ReadOnly = true;
            this.FridaySectionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FridaySectionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SaturdaySectionColumn
            // 
            this.SaturdaySectionColumn.HeaderText = "六";
            this.SaturdaySectionColumn.MinimumWidth = 10;
            this.SaturdaySectionColumn.Name = "SaturdaySectionColumn";
            this.SaturdaySectionColumn.ReadOnly = true;
            // 
            // CourseToEditComboBox
            // 
            this.CourseToEditComboBox.FormattingEnabled = true;
            this.CourseToEditComboBox.Location = new System.Drawing.Point(40, 75);
            this.CourseToEditComboBox.Name = "CourseToEditComboBox";
            this.CourseToEditComboBox.Size = new System.Drawing.Size(339, 32);
            this.CourseToEditComboBox.TabIndex = 1;
            // 
            // CourseNumberLabel
            // 
            this.CourseNumberLabel.AutoSize = true;
            this.CourseNumberLabel.Location = new System.Drawing.Point(402, 78);
            this.CourseNumberLabel.Name = "CourseNumberLabel";
            this.CourseNumberLabel.Size = new System.Drawing.Size(85, 24);
            this.CourseNumberLabel.TabIndex = 2;
            this.CourseNumberLabel.Text = "課號(*)";
            // 
            // CourseNameLabel
            // 
            this.CourseNameLabel.AutoSize = true;
            this.CourseNameLabel.Location = new System.Drawing.Point(586, 83);
            this.CourseNameLabel.Name = "CourseNameLabel";
            this.CourseNameLabel.Size = new System.Drawing.Size(133, 24);
            this.CourseNameLabel.TabIndex = 3;
            this.CourseNameLabel.Text = "課程名稱(*)";
            // 
            // CourseLevelLabel
            // 
            this.CourseLevelLabel.AutoSize = true;
            this.CourseLevelLabel.Location = new System.Drawing.Point(392, 241);
            this.CourseLevelLabel.Name = "CourseLevelLabel";
            this.CourseLevelLabel.Size = new System.Drawing.Size(85, 24);
            this.CourseLevelLabel.TabIndex = 4;
            this.CourseLevelLabel.Text = "階段(*)";
            // 
            // CourseManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2437, 1396);
            this.Controls.Add(this.ManagementTabControll);
            this.Controls.Add(this.CommingSoonLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.Name = "CourseManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Management";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseSectionColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SundaySectionColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MondaySectionColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TuesdaySectionColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn WednesdaySectionColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ThursdaySectionColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FridaySectionColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SaturdaySectionColumn;
        private System.Windows.Forms.ComboBox CourseToEditComboBox;
        private System.Windows.Forms.Label CourseLevelLabel;
        private System.Windows.Forms.Label CourseNameLabel;
        private System.Windows.Forms.Label CourseNumberLabel;
    }
}