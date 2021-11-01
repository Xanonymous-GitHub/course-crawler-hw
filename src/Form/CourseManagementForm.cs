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
        private bool _shouldSkipValidation = true;
        private int _currentCheckedCourseTimes;
        private CourseManagementFormDisplayStatus _displayStatus;

        // CourseManagementForm_Load
        private void CourseManagementForm_Load(object sender, EventArgs e)
        {
            BindCompomentsToData();
            CourseListBox.ClearSelected();
            _shouldSkipValidation = false;
        }

        // SetupDefaultState
        private void SetupDefaultStates()
        {
            _displayStatus = CourseManagementFormDisplayStatus.NotSpecifiedCourseToBeEdited;
            CourseEnabledComboBox.SelectedIndex = _formViewModel.DefaultCourseEnabledComboBoxSelectedIndex;
            _formViewModel.CourseClassComboBoxItems.ForEach(name => CourseClassComboBox.Items.Add(name));
            _formViewModel.CourseTypeComboBoxItems.ForEach(symbol => CourseTypeComboBox.Items.Add(symbol));
            UpdateCourseWeekTimeCheckBoxGridView();
            TriggerFieldValidationAndUseResult();
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
            List<List<bool>> newStates = _formViewModel.CourseWeekTimeCheckStates;
            if (newStates == null || CourseWeekTimeCheckBoxGridView.VirtualMode) return;
            
            CourseWeekTimeCheckBoxGridView.Rows.Clear();
            for (int i = 0; i < newStates.Count; i++)
            {
                CourseWeekTimeCheckBoxGridView.Rows.Add
                (
                    GenerateCourseWeekTimeCheckBoxGridViewSingleRowContents(Consts.CourseTimePeriodNameChars[i].ToString(), newStates[i])
                );
            }
            _currentCheckedCourseTimes = _formViewModel.CourseWeekTimeCheckBoxInitialCheckedAmount;
        }

        // UpdateDisplayedCompoments
        private void UpdateDisplayedCompoments(object sender, PropertyChangedEventArgs e)
        {
            ICourse course = _formViewModel.CurrentEditingContent.course;
            int dataSourceIndex = _formViewModel.CurrentEditingContent.dataSourceIndex;
            _shouldSkipValidation = true;

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
            _shouldSkipValidation = false;
        }

        // UpdateDisplayedCompomentEnabledStatus
        private void UpdateDisplayedCompomentEnabledStatus()
        {
            SaveCourseButton.Enabled = Utils.OR(_displayStatus, CourseManagementFormDisplayStatus.EditingCourseAndValid, CourseManagementFormDisplayStatus.EditingNewCourseAndValid);
            AddCourseButton.Enabled = !Utils.OR(_displayStatus, CourseManagementFormDisplayStatus.EditingNewCourseAndValid, CourseManagementFormDisplayStatus.EditingNewCourseButInvalid);

            EditCourseGroupBox.Enabled = _displayStatus != CourseManagementFormDisplayStatus.NotSpecifiedCourseToBeEdited;
            CourseWeekTimeCheckBoxGridView.Enabled = _displayStatus != CourseManagementFormDisplayStatus.NotSpecifiedCourseToBeEdited;
        }

        // ValidateEditingCompomentValues
        private bool ValidateEditingCompomentValues()
        {
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

            if (_currentCheckedCourseTimes != CourseHourComboBox.SelectedIndex + 1) return false;

            return true;
        }

        // CourseListBox_SelectedIndexChanged
        private void CourseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CourseListBox.SelectedIndex < 0)
            {
                _displayStatus = CourseManagementFormDisplayStatus.NotSpecifiedCourseToBeEdited;
                UpdateDisplayedCompomentEnabledStatus();
                return;
            }

            _displayStatus = CourseManagementFormDisplayStatus.EditingFiledsNotChangedOrSaved;
            UpdateDisplayedCompomentEnabledStatus();
            _formViewModel.GenerateEditableFieldContens(CourseListBox.SelectedIndex);
        }

        // CourseWeekTimeCheckBoxGridView_CellContentClick
        private void CourseWeekTimeCheckBoxGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)CourseWeekTimeCheckBoxGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                bool isCurrentCheckBoxSelected = (bool)checkCell.Value;

                checkCell.Value = !isCurrentCheckBoxSelected;

                _currentCheckedCourseTimes += !isCurrentCheckBoxSelected ? 1 : -1;

                TriggerFieldValidationAndUseResult();
            }
        }

        // TriggerFieldValidationAndUseResult
        private void TriggerFieldValidationAndUseResult()
        {
            if (_shouldSkipValidation) return;
            bool isValid = ValidateEditingCompomentValues();
            _displayStatus = isValid ? CourseManagementFormDisplayStatus.EditingCourseAndValid : CourseManagementFormDisplayStatus.EditingCourseButInvalid;
            UpdateDisplayedCompomentEnabledStatus();
        }

        private DataGridViewRow GenerateCourseWeekTimeCheckBoxGridViewSingleRowContents(string periodName, List<bool> singleRowCheckStates)
        {
            DataGridViewRow row = new();
            row.Cells.Add(new DataGridViewTextBoxCell{ Value = periodName });

            if (singleRowCheckStates == null)
            {
                for(int i = 0; i < 7; i++)
                {
                    row.Cells.Add(new DataGridViewCheckBoxCell { Value = false });
                }
            }
            else
            {
                foreach (bool state in singleRowCheckStates)
                {
                    row.Cells.Add(new DataGridViewCheckBoxCell { Value = state });
                }
            }
            
            return row;
        }

        // SaveCourseButton_Click
        private void SaveCourseButton_Click(object sender, EventArgs e)
        {

        }

        // CourseNumberTextBox_TextChanged
        private void CourseNumberTextBox_TextChanged(object sender, EventArgs e) => TriggerFieldValidationAndUseResult();

        // CourseNameTextBox_TextChanged
        private void CourseNameTextBox_TextChanged(object sender, EventArgs e) => TriggerFieldValidationAndUseResult();

        // CourseLevelTextBox_TextChanged
        private void CourseLevelTextBox_TextChanged(object sender, EventArgs e) => TriggerFieldValidationAndUseResult();

        // CourseCreditTextBox_TextChanged
        private void CourseCreditTextBox_TextChanged(object sender, EventArgs e) => TriggerFieldValidationAndUseResult();

        // CourseTeacherTextBox_TextChanged
        private void CourseTeacherTextBox_TextChanged(object sender, EventArgs e) => TriggerFieldValidationAndUseResult();

        // CourseTypeComboBox_SelectedIndexChanged
        private void CourseTypeComboBox_SelectedIndexChanged(object sender, EventArgs e) => TriggerFieldValidationAndUseResult();

        // CourseTAsTextBox_TextChanged
        private void CourseTAsTextBox_TextChanged(object sender, EventArgs e) => TriggerFieldValidationAndUseResult();

        // CourseLanguageTextBox_TextChanged
        private void CourseLanguageTextBox_TextChanged(object sender, EventArgs e) => TriggerFieldValidationAndUseResult();

        // CourseRemarkTextBox_TextChanged
        private void CourseRemarkTextBox_TextChanged(object sender, EventArgs e) => TriggerFieldValidationAndUseResult();

        // CourseHourComboBox_SelectedIndexChanged
        private void CourseHourComboBox_SelectedIndexChanged(object sender, EventArgs e) => TriggerFieldValidationAndUseResult();

        // CourseClassComboBox_SelectedIndexChanged
        private void CourseClassComboBox_SelectedIndexChanged(object sender, EventArgs e) => TriggerFieldValidationAndUseResult();
    }
}
