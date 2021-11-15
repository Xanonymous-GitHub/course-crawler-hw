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
        private List<List<bool>> _courseTimeStates;

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
            _formViewModel.CourseTypeComboBoxItems.ForEach(symbol => CourseTypeComboBox.Items.Add(symbol));
            UpdateCourseWeekTimeCheckBoxGridView();
            TriggerFieldValidationAndUseResult();
        }

        // BindCompomentsToData
        private void BindCompomentsToData()
        {
            CourseListBox.DataBindings.Add(nameof(CourseListBox.DataSource), _formViewModel, nameof(_formViewModel.CoursesToBeEditStrList));
            _formViewModel.PropertyChanged += UpdateDisplayedCompoments;
        }

        // UpdateCourseWeekTimeCheckBoxGridView
        private void UpdateCourseWeekTimeCheckBoxGridView()
        {
            List<List<bool>> newStates = _formViewModel.CourseWeekTimeCheckStates;
            if (newStates == null || CourseWeekTimeCheckBoxGridView.VirtualMode) return;

            _courseTimeStates = newStates;

            CourseWeekTimeCheckBoxGridView.Rows.Clear();
            int totalCheckedAmount = 0;

            for (int i = 0; i < Consts.CourseTimePeriodNameChars.Length; i++)
            {
                (DataGridViewRow row, int checkedAmountInRow) = GenerateCourseWeekTimeCheckBoxGridViewSingleRowContents(i, _courseTimeStates);
                CourseWeekTimeCheckBoxGridView.Rows.Add(row);
                totalCheckedAmount += checkedAmountInRow;
            }
            _currentCheckedCourseTimes = totalCheckedAmount;
        }

        // GenerateCourseWeekTimeCheckBoxGridViewSingleRowContents
        private (DataGridViewRow row, int checkedAmountInRow) GenerateCourseWeekTimeCheckBoxGridViewSingleRowContents(int periodIndex, List<List<bool>> checkStates)
        {
            DataGridViewRow row = new();
            int checkAmount = 0;
            string periodName = Consts.CourseTimePeriodNameChars[periodIndex].ToString();

            row.Cells.Add(new DataGridViewTextBoxCell { Value = periodName });

            foreach (List<bool> dailyStates in checkStates)
            {
                if (dailyStates == null)
                {
                    row.Cells.Add(new DataGridViewCheckBoxCell { Value = false });
                    continue;
                }

                bool state = dailyStates[periodIndex];
                checkAmount += Convert.ToInt32(state);
                row.Cells.Add(new DataGridViewCheckBoxCell { Value = state });
            }

            return (row, checkAmount);
        }

        // UpdateDisplayedCompoments
        private void UpdateDisplayedCompoments(object sender, PropertyChangedEventArgs e)
        {
            CourseClassComboBox.Items.Clear();
            SupportedDataSourceInfo.GetAllCombinedNames.ForEach(name => CourseClassComboBox.Items.Add(name));
            ICourse course = _formViewModel.CurrentEditingContent.course;
            int dataSourceIndex = _formViewModel.CurrentEditingContent.dataSourceIndex;
            _shouldSkipValidation = true;

            CourseNumberTextBox.Text = course?.Serial;
            CourseNameTextBox.Text = course?.Name;
            CourseLevelTextBox.Text = course?.Level;
            CourseCreditTextBox.Text = course?.Credit;
            CourseRemarkTextBox.Text = course?.Remark;
            CourseTeacherTextBox.Text = string.Join(string.Empty, course?.Teachers ?? new string[] { });
            CourseTAsTextBox.Text = string.Join(string.Empty, course?.TAs ?? new string[] { });
            CourseLanguageTextBox.Text = course?.Language.ToOriginString();
            CourseTypeComboBox.SelectedIndex = CourseTypeComboBox.Items.IndexOf(course?.Type.ToOriginString() ?? string.Empty);
            CourseClassComboBox.SelectedIndex = dataSourceIndex;
            CourseEnabledComboBox.SelectedIndex = course?.IsEnabled == true ? 0 : 1;

            bool hasCourseHour = int.TryParse(course?.Hour, out int hour);
            CourseHourComboBox.SelectedIndex = hasCourseHour ? Math.Min(hour - 1, Consts.CourseHourComboBoxMaxSelectIndex) : -1;

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
                CourseEnabledComboBox.SelectedIndex,
            };

            if (expectSelectedComboBoxIndexes.Contains(-1)) return false;

            bool courseNumberIsNaN = !int.TryParse(CourseNumberTextBox.Text.Trim(), out _);
            bool courseLevelIsNaN = !int.TryParse(CourseLevelTextBox.Text.Trim(), out _);
            bool courseCreditIsNaN = !float.TryParse(CourseCreditTextBox.Text.Trim(), out _);

            if (courseNumberIsNaN || courseLevelIsNaN || courseCreditIsNaN) return false;

            if (_currentCheckedCourseTimes != CourseHourComboBox.SelectedIndex + 1) return false;

            if (!Consts.LanguageSymbols.Contains(CourseLanguageTextBox.Text.Trim())) return false;

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
                _courseTimeStates[e.ColumnIndex - 1][e.RowIndex] = !isCurrentCheckBoxSelected;

                _currentCheckedCourseTimes += !isCurrentCheckBoxSelected ? 1 : -1;

                TriggerFieldValidationAndUseResult();
            }
        }

        // TriggerFieldValidationAndUseResult
        private void TriggerFieldValidationAndUseResult()
        {
            if (_shouldSkipValidation) return;
            bool isValid = ValidateEditingCompomentValues();

            if (isValid)
            {
                if (Utils.OR((int)_displayStatus, 4, 5))
                    _displayStatus = CourseManagementFormDisplayStatus.EditingNewCourseAndValid;
                else
                    _displayStatus = CourseManagementFormDisplayStatus.EditingCourseAndValid;
            }
            else
            {
                if (Utils.OR((int)_displayStatus, 4, 5))
                    _displayStatus = CourseManagementFormDisplayStatus.EditingNewCourseButInvalid;
                else
                    _displayStatus = CourseManagementFormDisplayStatus.EditingCourseButInvalid;
            }

            UpdateDisplayedCompomentEnabledStatus();
        }

        // SaveCourseButton_Click
        private void SaveCourseButton_Click(object sender, EventArgs e)
        {
            _formViewModel.UpdateCourse
            (
                CourseNumberTextBox.Text.Trim(),
                CourseNameTextBox.Text.Trim(),
                CourseLevelTextBox.Text.Trim(),
                CourseCreditTextBox.Text.Trim(),
                CourseTeacherTextBox.Text.Trim(),
                CourseTypeComboBox.Items[CourseTypeComboBox.SelectedIndex].ToString(),
                CourseTAsTextBox.Text.Trim(),
                CourseLanguageTextBox.Text.Trim(),
                CourseRemarkTextBox.Text.Trim(),
                CourseHourComboBox.Items[CourseHourComboBox.SelectedIndex].ToString(),
                CourseClassComboBox.SelectedIndex,
                _courseTimeStates,
                _displayStatus == CourseManagementFormDisplayStatus.EditingNewCourseAndValid,
                isEnabled: CourseEnabledComboBox.SelectedIndex != 1
            );

            CourseListBox.SelectedIndex = _formViewModel.DefaultCourseListBoxSelectedIndex;
            _formViewModel.GenerateEditableFieldContens(CourseListBox.SelectedIndex);
            _displayStatus = CourseManagementFormDisplayStatus.EditingFiledsNotChangedOrSaved;
            UpdateDisplayedCompomentEnabledStatus();
            MessageBox.Show(Consts.SuccessfullySaveCourse);
        }

        // AddCourseButton_Click
        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            _formViewModel.GenerateEmptyFieldContens();
            _displayStatus = CourseManagementFormDisplayStatus.EditingNewCourseButInvalid;
            UpdateDisplayedCompomentEnabledStatus();
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

        /// Import All CSIE Course from NTUT in academic 110.
        /// 
        /// <summary>
        /// Because we don't know what year should be imported and the requirement spec did not say what 'all' means,
        /// so I will use the 110 year and 'all' CSIE courses in this feature.
        /// 
        /// Suggest make the spec more clear next time.
        /// </summary>
        private void ImportAllCSIECourseButton_Click(object sender, EventArgs e)
        {
            List<(string, string, string)> newDataSourcesToBeImported = new()
            {
                ("資工", "一", "2676"),
                ("資工", "二", "2550"),
                // The "資工三" is a default imported course table, so we don't need to import it again here.
                ("資工", "四", "2314"),
                ("資工", "所", "2701"),
            };

            foreach ((string, string, string) source in newDataSourcesToBeImported)
            {
                SupportedDataSourceInfo.AddSourceInfo(source);
            }

            _formViewModel.LoadCourses(shouldNotifyAllDepartmentListener: true);
            ImportAllCSIECourseButton.Enabled = false;
            _formViewModel.GenerateEmptyFieldContens();
            SetupDefaultStates();
            CourseListBox.ClearSelected();
        }

        // CourseEnabledComboBox_SelectedIndexChanged
        private void CourseEnabledComboBox_SelectedIndexChanged(object sender, EventArgs e) => TriggerFieldValidationAndUseResult();
    }
}
