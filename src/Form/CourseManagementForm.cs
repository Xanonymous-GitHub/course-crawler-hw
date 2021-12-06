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
            
            _courseTabViewModel = new();
            _classTabViewModel = new();

            SetupDefaultStates();
        }

        private readonly CourseManagementFormViewModel _courseTabViewModel;
        private readonly ClassManagementTabViewModel _classTabViewModel;
        private bool _shouldSkipValidation = true;
        private bool _editingNewClass = false;
        private int _currentCheckedCourseTimes;
        private CourseManagementTabDisplayStatus _courseManageTabDisplayStatus;
        private ClassManagementTabDisplayStatus _classManageTabDisplayStatus;
        private List<List<bool>> _courseTimeStates;

        // CourseManagementForm_Load
        private void CourseManagementForm_Load(object sender, EventArgs e)
        {
            _classTabViewModel.GenerateClassList();
            BindCompomentsToData();
            CourseListBox.ClearSelected();
            _shouldSkipValidation = false;
        }

        // SetupDefaultState
        private void SetupDefaultStates()
        {
            _courseManageTabDisplayStatus = CourseManagementTabDisplayStatus.NotSpecifiedCourseToBeEdited;
            CourseEnabledComboBox.SelectedIndex = _courseTabViewModel.DefaultCourseEnabledComboBoxSelectedIndex;
            _courseTabViewModel.CourseTypeComboBoxItems.ForEach(symbol => CourseTypeComboBox.Items.Add(symbol));
            UpdateCourseWeekTimeCheckBoxGridView();
            TriggerFieldValidationAndUseResult();
            UpdateClassManagementTabDisplayedCompomentEnabledStatus();
        }

        // BindCompomentsToData
        private void BindCompomentsToData()
        {
            CourseListBox.DataBindings.Add(nameof(CourseListBox.DataSource), _courseTabViewModel, nameof(_courseTabViewModel.CoursesToBeEditStrList));
            _courseTabViewModel.PropertyChanged += UpdateDisplayedCompoments;
            UpdateClassListBoxContent();
        }

        private void UpdateClassListBoxContent()
        {
            _classTabViewModel.GenerateClassList();
            ClassListBox.Items.Clear();
            _classTabViewModel.DepartmentNamesToShow.ForEach(name => ClassListBox.Items.Add(name));
        }

        // UpdateCourseWeekTimeCheckBoxGridView
        private void UpdateCourseWeekTimeCheckBoxGridView()
        {
            List<List<bool>> newStates = _courseTabViewModel.CourseWeekTimeCheckStates;
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
            ICourse course = _courseTabViewModel.CurrentEditingContent.course;
            int dataSourceIndex = _courseTabViewModel.CurrentEditingContent.dataSourceIndex;
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
        private void UpdateCourseManagementTabDisplayedCompomentEnabledStatus()
        {
            SaveCourseButton.Enabled = Utils.OR(_courseManageTabDisplayStatus, CourseManagementTabDisplayStatus.EditingCourseAndValid, CourseManagementTabDisplayStatus.EditingNewCourseAndValid);
            AddCourseButton.Enabled = !Utils.OR(_courseManageTabDisplayStatus, CourseManagementTabDisplayStatus.EditingNewCourseAndValid, CourseManagementTabDisplayStatus.EditingNewCourseButInvalid);

            EditCourseGroupBox.Enabled = _courseManageTabDisplayStatus != CourseManagementTabDisplayStatus.NotSpecifiedCourseToBeEdited;
            CourseWeekTimeCheckBoxGridView.Enabled = _courseManageTabDisplayStatus != CourseManagementTabDisplayStatus.NotSpecifiedCourseToBeEdited;
        }

        // UpdateClassManagementTabDisplayedCompomentEnabledStatus
        private void UpdateClassManagementTabDisplayedCompomentEnabledStatus()
        {
            AddClassToEditButton.Enabled = Utils.OR(_classManageTabDisplayStatus, ClassManagementTabDisplayStatus.NotSpecifiedClassToBeEdited, ClassManagementTabDisplayStatus.ShowingExistedClass);
            ClassNameTextBox.Enabled = _classManageTabDisplayStatus != ClassManagementTabDisplayStatus.NotSpecifiedClassToBeEdited;
            AddClassButton.Enabled = _classManageTabDisplayStatus == ClassManagementTabDisplayStatus.EditingNewClassAndValid;
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
                _courseManageTabDisplayStatus = CourseManagementTabDisplayStatus.NotSpecifiedCourseToBeEdited;
                UpdateCourseManagementTabDisplayedCompomentEnabledStatus();
                return;
            }

            _courseManageTabDisplayStatus = CourseManagementTabDisplayStatus.EditingFiledsNotChangedOrSaved;
            UpdateCourseManagementTabDisplayedCompomentEnabledStatus();
            _courseTabViewModel.GenerateEditableFieldContens(CourseListBox.SelectedIndex);
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
                if (Utils.OR((int)_courseManageTabDisplayStatus, 4, 5))
                    _courseManageTabDisplayStatus = CourseManagementTabDisplayStatus.EditingNewCourseAndValid;
                else
                    _courseManageTabDisplayStatus = CourseManagementTabDisplayStatus.EditingCourseAndValid;
            }
            else
            {
                if (Utils.OR((int)_courseManageTabDisplayStatus, 4, 5))
                    _courseManageTabDisplayStatus = CourseManagementTabDisplayStatus.EditingNewCourseButInvalid;
                else
                    _courseManageTabDisplayStatus = CourseManagementTabDisplayStatus.EditingCourseButInvalid;
            }

            UpdateCourseManagementTabDisplayedCompomentEnabledStatus();
        }

        // SaveCourseButton_Click
        private void SaveCourseButton_Click(object sender, EventArgs e)
        {
            _courseTabViewModel.UpdateCourse
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
                _courseManageTabDisplayStatus == CourseManagementTabDisplayStatus.EditingNewCourseAndValid,
                isEnabled: CourseEnabledComboBox.SelectedIndex != 1
            );

            CourseListBox.SelectedIndex = _courseTabViewModel.DefaultCourseListBoxSelectedIndex;
            _courseTabViewModel.GenerateEditableFieldContens(CourseListBox.SelectedIndex);
            _courseManageTabDisplayStatus = CourseManagementTabDisplayStatus.EditingFiledsNotChangedOrSaved;
            UpdateCourseManagementTabDisplayedCompomentEnabledStatus();
            MessageBox.Show(Consts.SuccessfullySaveCourse);
        }

        // AddCourseButton_Click
        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            _courseTabViewModel.GenerateEmptyFieldContens();
            _courseManageTabDisplayStatus = CourseManagementTabDisplayStatus.EditingNewCourseButInvalid;
            UpdateCourseManagementTabDisplayedCompomentEnabledStatus();
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
        private async void ImportAllCSIECourseButton_Click(object sender, EventArgs e)
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

            await Task.Run(() => new ProgressForm().ShowDialog());

            _courseTabViewModel.LoadCourses(shouldNotifyAllDepartmentListener: true);

            ImportAllCSIECourseButton.Enabled = false;
            _courseTabViewModel.GenerateEmptyFieldContens();
            SetupDefaultStates();
            CourseListBox.ClearSelected();

            UpdateClassListBoxContent();
        }

        // CourseEnabledComboBox_SelectedIndexChanged
        private void CourseEnabledComboBox_SelectedIndexChanged(object sender, EventArgs e) => TriggerFieldValidationAndUseResult();

        private void ClassListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseInClassListBox.Items.Clear();
            int selectedIndex = ClassListBox.SelectedIndex;
            if (selectedIndex < 0)
            {
                if (_editingNewClass)
                {
                    _classManageTabDisplayStatus = ClassManagementTabDisplayStatus.EditingNewClassButInvalid;
                    _editingNewClass = false;
                }
                else
                {
                    _classManageTabDisplayStatus = ClassManagementTabDisplayStatus.NotSpecifiedClassToBeEdited;
                }

                ClassNameTextBox.Text = string.Empty;
                UpdateClassManagementTabDisplayedCompomentEnabledStatus();
                return;
            }

            string className = _classTabViewModel.DepartmentNamesToShow[selectedIndex];
            ClassNameTextBox.Text = className;

            _classTabViewModel.GenerateCoursesByClassName(className);
            _classTabViewModel.CoursesToShow.ForEach(courseName => CourseInClassListBox.Items.Add(courseName));

            _classManageTabDisplayStatus = ClassManagementTabDisplayStatus.ShowingExistedClass;
            UpdateClassManagementTabDisplayedCompomentEnabledStatus();
        }

        private void AddClassToEditButton_Click(object sender, EventArgs e)
        {
            _classManageTabDisplayStatus = ClassManagementTabDisplayStatus.EditingNewClassButInvalid;
            _editingNewClass = true;
            ClassListBox.SelectedIndex = -1;
        }

        private void ClassNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Utils.OR((int)_classManageTabDisplayStatus, 2, 3)) return;

            bool isValid = ClassNameTextBox.Text.Trim() != string.Empty;
            _classManageTabDisplayStatus = isValid ? ClassManagementTabDisplayStatus.EditingNewClassAndValid : ClassManagementTabDisplayStatus.EditingNewClassButInvalid;
            UpdateClassManagementTabDisplayedCompomentEnabledStatus();
        }

        private void AddClassButton_Click(object sender, EventArgs e)
        {
            string newClassName = ClassNameTextBox.Text.Trim();
            ClassNameTextBox.Text = string.Empty;
            if (newClassName == string.Empty) return;

            _classTabViewModel.AddNewClass(newClassName);
            _classManageTabDisplayStatus = ClassManagementTabDisplayStatus.NotSpecifiedClassToBeEdited;
            UpdateClassListBoxContent();
            ClassListBox.SelectedIndex = ClassListBox.Items.Count - 1;
        }
    }
}
