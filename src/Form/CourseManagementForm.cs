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
        }

        // CourseListBox_SelectedIndexChanged
        private void CourseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CourseListBox.SelectedIndex < 0) return;
            _formViewModel.GenerateEditableFieldContens(CourseListBox.SelectedIndex);
        }
    }
}
