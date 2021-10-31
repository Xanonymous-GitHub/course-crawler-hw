using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseCrawler
{
    public partial class CourseManagementForm : Form
    {
        public CourseManagementForm()
        {
            InitializeComponent();

            _formViewModel = new();

            SetupDefaultStates();
        }

        private readonly CourseManagementFormViewModel _formViewModel;
        private bool shouldSkipValidation = false;

        // CourseManagementForm_Load
        private void CourseManagementForm_Load(object sender, EventArgs e)
        {
            BindCompomentsToData();
            CourseListBox.ClearSelected();
        }

        // SetupDefaultState
        private void SetupDefaultStates()
        {
            CourseEnabledComboBox.SelectedIndex = _formViewModel.DefaultCourseEnabledComboBoxSelectedIndex;
            _formViewModel.CourseClassComboBoxItems.ForEach(name => CourseClassComboBox.Items.Add(name));
            _formViewModel.CourseTypeComboBoxItems.ForEach(symbol => CourseTypeComboBox.Items.Add(symbol));
            UpdateCourseWeekTimeCheckBoxGridView();
        }

        // BindCompomentsToData
        private void BindCompomentsToData()
        {
            CourseListBox.DataSource = _formViewModel.CoursesToBeEditStrList;
            _formViewModel.PropertyChanged += UpdateDisplayedCompoments;
        }

        // UpdateCourseWeekTimeCheckBoxGridView
        private void UpdateCourseWeekTimeCheckBoxGridView()
        {
            List<string[]> newRows = _formViewModel.CourseWeekTimeCheckBoxRows;
            if (newRows == null || CourseWeekTimeCheckBoxGridView.VirtualMode) return;
            
            CourseWeekTimeCheckBoxGridView.Rows.Clear();
            newRows.ForEach(row => CourseWeekTimeCheckBoxGridView.Rows.Add(row));
        }

        // UpdateDisplayedCompoments
        private void UpdateDisplayedCompoments(object sender, PropertyChangedEventArgs e)
        {
            ICourse course = _formViewModel.CurrentEditingCourse.course;
            int dataSourceIndex = _formViewModel.CurrentEditingCourse.dataSourceIndex;
            shouldSkipValidation = true;

            CourseNumberTextBox.Text = course.Serial;
            CourseNameTextBox.Text = course.Name;
            CourseLevelTextBox.Text = course.Level;
            CourseCreditTextBox.Text = course.Credit;
            CourseRemarkTextBox.Text = course.Remark;
            CourseTeacherTextBox.Text = string.Join(string.Empty, course.Teachers);
            CourseTAsTextBox.Text = string.Join(string.Empty, course.TAs);
            CourseLanguageTextBox.Text = course.Language.ToOriginString();
            CourseTypeComboBox.SelectedIndex = CourseTypeComboBox.Items.IndexOf(course.Type.ToOriginString());
            CourseClassComboBox.SelectedIndex = dataSourceIndex;

            bool hasCourseHour = int.TryParse(course.Hour, out int hour);
            CourseHourComboBox.SelectedIndex = hasCourseHour ? hour - 1 : -1;

            UpdateCourseWeekTimeCheckBoxGridView();
            shouldSkipValidation = false;
        }

        // ValidateEditingCompomentValues
        private bool ValidateEditingCompomentValues()
        {
            if (shouldSkipValidation) return true;

            List<string> expectNonEmptyTextBoxTexts = new()
            {
                CourseNumberTextBox.Text.Trim(),
                CourseNameTextBox.Text.Trim(),
                CourseLevelTextBox.Text.Trim(),
                CourseCreditTextBox.Text.Trim(),
                CourseTeacherTextBox.Text.Trim(),
            };

            if (expectNonEmptyTextBoxTexts.Contains(string.Empty)) return false;

            List<int> expectSelectedComboBoxIndexes = new()
            {
                CourseTypeComboBox.SelectedIndex,
                CourseHourComboBox.SelectedIndex,
                CourseClassComboBox.SelectedIndex,
            };

            if (expectSelectedComboBoxIndexes.Contains(-1)) return false;

            bool courseNumberIsNaN = !int.TryParse(CourseNumberTextBox.Text.Trim(), out _);
            bool courseLevelIsNaN = !int.TryParse(CourseLevelTextBox.Text.Trim(), out _);
            bool courseCreditIsNaN = !float.TryParse(CourseCreditTextBox.Text.Trim(), out _);

            if (courseNumberIsNaN || courseLevelIsNaN || courseCreditIsNaN) return false;

            // TODO: validate if checked course time amount is equal the courseTime combobox.
            return true;
        }

        // CourseListBox_SelectedIndexChanged
        private void CourseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CourseListBox.SelectedIndex < 0) return;
            _formViewModel.GenerateEditableFieldContens(CourseListBox.SelectedIndex);
        }

        // CourseNumberTextBox_TextChanged
        private void CourseNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveCourseButton.Enabled = ValidateEditingCompomentValues();
        }

        // CourseNameTextBox_TextChanged
        private void CourseNameTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveCourseButton.Enabled = ValidateEditingCompomentValues();
        }

        // CourseLevelTextBox_TextChanged
        private void CourseLevelTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveCourseButton.Enabled = ValidateEditingCompomentValues();
        }

        // CourseCreditTextBox_TextChanged
        private void CourseCreditTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveCourseButton.Enabled = ValidateEditingCompomentValues();
        }

        // CourseTeacherTextBox_TextChanged
        private void CourseTeacherTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveCourseButton.Enabled = ValidateEditingCompomentValues();
        }

        // CourseTypeComboBox_SelectedIndexChanged
        private void CourseTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveCourseButton.Enabled = ValidateEditingCompomentValues();
        }

        // CourseTAsTextBox_TextChanged
        private void CourseTAsTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveCourseButton.Enabled = ValidateEditingCompomentValues();
        }

        // CourseLanguageTextBox_TextChanged
        private void CourseLanguageTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveCourseButton.Enabled = ValidateEditingCompomentValues();
        }

        // CourseRemarkTextBox_TextChanged
        private void CourseRemarkTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveCourseButton.Enabled = ValidateEditingCompomentValues();
        }

        // CourseHourComboBox_SelectedIndexChanged
        private void CourseHourComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveCourseButton.Enabled = ValidateEditingCompomentValues();
        }

        // CourseClassComboBox_SelectedIndexChanged
        private void CourseClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveCourseButton.Enabled = ValidateEditingCompomentValues();
        }
    }
}
