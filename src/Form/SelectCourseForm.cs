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

            ResizeGridViewRemarkColumnWidth();

            _currentShownTabIndex = 0;

            _formViewModel = SelectCourseFormViewModel.UseCreateBy(_currentShownTabIndex);
        }

        private static int _currentShownTabIndex = 0;

        private SelectCourseFormViewModel _formViewModel;

        // ResizeGridViewRemarkColumnWidth
        private void ResizeGridViewRemarkColumnWidth()
        {
            const int remarkColumnIndex = 21;

            int columnTotalWidth = 0, gridViewWidth = 0;
            foreach(DataGridViewColumn col in CourseGridView.Columns)
            {
                columnTotalWidth += col.MinimumWidth;
                gridViewWidth += col.Width;
            }

            if (columnTotalWidth < gridViewWidth)
            {
                CourseGridView.Columns[remarkColumnIndex].MinimumWidth += (gridViewWidth - columnTotalWidth) / 2;
            }
        }

        // Event handler when SelectCourseForm Loaded.
        private void SelectCourseForm_Load(object sender, EventArgs e)
        {
            _formViewModel.PropertyChanged += HandleVMChanged;
            UpdateCourseGridView();
        }

        // HandleVMChanged
        public void HandleVMChanged(object sender, PropertyChangedEventArgs e)
        {
            UpdateCourseGridView();
        }

        // Use _currentDepartmentName & _currentTableName to fetch new course table data then redraw the gridview.
        private void UpdateCourseGridView()
        {
            _formViewModel.ChangeDisplayTable(_currentShownTabIndex);
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

                bool isCurrentCheckBoxSelected = checkCell.Value.ToString() == checkCell.TrueValue.ToString();

                _formViewModel.ChangeCourseCheckStatus(e.RowIndex, !isCurrentCheckBoxSelected);

                checkCell.Value = !isCurrentCheckBoxSelected ? checkCell.TrueValue : checkCell.FalseValue;
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

            MessageBox.Show(resultMsg, string.Empty, buttons: MessageBoxButtons.OK, icon: submitResult.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

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

            TabPage newTabPage = CourseTableTabControl.TabPages[Consts.TabPageNameTitle + (_currentShownTabIndex + 1).ToString()];
            
            if (newTabPage.Controls.Count != 0) return;

            newTabPage.SuspendLayout();
            newTabPage.Controls.Clear();
            newTabPage.Controls.Add(CoursePanel);
            newTabPage.ResumeLayout();
            newTabPage.Refresh();
            CourseTableTabControl.Refresh();
        }

        private void SelectCourseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _formViewModel.PropertyChanged -= HandleVMChanged;
        }
    }
}
