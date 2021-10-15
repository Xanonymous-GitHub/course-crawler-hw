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
    public partial class SelectCourseForm : Form
    {
        public SelectCourseForm()
        {
            InitializeComponent();

            _supportedCourseTableMapIndex.Add(new CourseTabSourceIndex(0, 2)); // 資工, 三
            _supportedCourseTableMapIndex.Add(new CourseTabSourceIndex(1, 6)); // 電子, 三甲
            _supportedCourseTableMapIndex.Add(new CourseTabSourceIndex(2, 10)); // 化工, 三乙
            _currentShownTabIndex = 0;

            _formViewModel = new(_currentDepartmentName, _currentTableName);
        }

        private readonly List<CourseTabSourceIndex> _supportedCourseTableMapIndex = new();

        private static int _currentShownTabIndex = 0;

        private string _currentDepartmentName => SupportedRange.DepartmentNames[_supportedCourseTableMapIndex[_currentShownTabIndex].DepartmentIndex];
        private string _currentTableName => SupportedRange.TableNames[_supportedCourseTableMapIndex[_currentShownTabIndex].TableIIndex];

        private SelectCourseFormViewModel _formViewModel;
        
        // Event handler when SelectCourseForm Loaded.
        private void SelectCourseForm_Load(object sender, EventArgs e)
        {
            UpdateCourseGridView();
        }
        
        // Use _currentDepartmentName & _currentTableName to fetch new course table data then redraw the gridview.
        private void UpdateCourseGridView()
        {
            _formViewModel.ChangeDisplayTable(_currentDepartmentName, _currentTableName);
            List<string[]> courseRows = _formViewModel.GetCourseTableRows();
            if (courseRows != null)
            {
                CourseGridView.Rows.Clear();
                courseRows.ForEach(row => CourseGridView.Rows.Add(row));
                ReDrawContents();
                CourseGridView.NotifyCurrentCellDirty(true);
            }
        }

        // Event handler when CourseGridView CellContentClick.
        private void CourseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && CourseGridView.Columns[e.ColumnIndex].Name == CourseSelectionBoxColumn.Name)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)CourseGridView.Rows[e.RowIndex].Cells[CourseSelectionBoxColumn.Name];

                bool isCurrentCheckBoxSelected = Convert.ToBoolean(checkCell.Value);

                _formViewModel.ChangeCourseCheckStatus(e.RowIndex, !isCurrentCheckBoxSelected);

                checkCell.Value = !isCurrentCheckBoxSelected;

                CourseGridView.NotifyCurrentCellDirty(true);
                CourseGridView.Invalidate();
            }
        }
        
        // Event handler when CourseGridView CellValueChanged.
        private void CourseGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!CourseGridView.IsCurrentCellDirty) return;

            ReDrawContents();
        }

        // Event handler when SubmitCourseSelectionButton Click.
        private void SubmitCourseSelectionButton_Click(object sender, EventArgs e)
        {
            Result<string> submitResult = _formViewModel.HandleSelectCourseSubmission();

            string resultMsg = submitResult.Success ? submitResult.Data : (submitResult as ErrorResult<string>).Message;

            MessageBox.Show(resultMsg, Constants.EmptyString, buttons: MessageBoxButtons.OK, icon: submitResult.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (submitResult.Success)
            {
                ReDrawContents();
                UpdateCourseGridView();
            }
        }

        // Event handler when GetCourseSelectResultbutton Click.
        private void GetCourseSelectResultbutton_Click(object sender, EventArgs e)
        {
            CourseSelectionResultForm courseSelectionResultForm = new();
            courseSelectionResultForm.ShowDialog();
            ReDrawContents();
            UpdateCourseGridView();
        }

        // ReConfigure the properties of Controllers in the form, exclude the gridView.
        private void ReDrawContents()
        {
            SubmitCourseSelectionButton.Enabled = _formViewModel.IsAnyCourseChecked();
            GetCourseSelectResultbutton.Enabled = _formViewModel.IsAnyCourseSelected();
        }

        // Event handler when CourseTableTabControl SelectedIndexChanged.
        private void CourseTableTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentShownTabIndex = CourseTableTabControl.SelectedIndex;
            UpdateCourseGridView();

            TabPage newTabPage = CourseTableTabControl.TabPages[Constants.TabPageNameTitle + (_currentShownTabIndex + 1).ToString()];
            newTabPage.SuspendLayout();
            newTabPage.Controls.Clear();
            newTabPage.Controls.Add(CoursePanel);
            newTabPage.ResumeLayout(true);
            newTabPage.Refresh();
            CourseTableTabControl.Refresh();
        }
    }
}
