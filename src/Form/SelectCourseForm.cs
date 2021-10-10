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
        }

        private const string _currentDepartmentName = "123"; // DEBUG
        private const string _currentTableName = "123"; // DEBUG

        private readonly SelectCourseFormViewModel _formViewModel = new(_currentDepartmentName, _currentTableName);
        private List<int> _currentSelectIndex = new();

        private void SelectCourseForm_Load(object sender, EventArgs e)
        {
            UpdateCourseGridView();
        }

        private void UpdateCourseGridView()
        {
            List<string[]> courseRows = _formViewModel.GetCourseTableRows();

            CourseGridView.Rows.Clear();
            courseRows.ForEach(row => CourseGridView.Rows.Add(row));
            DisableSelectedCourseCheckBox();
            CourseGridView.NotifyCurrentCellDirty(true);
        }

        private void CourseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && CourseGridView.Columns[e.ColumnIndex].Name == CourseSelectionBoxColumn.Name)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)CourseGridView.Rows[e.RowIndex].Cells[CourseSelectionBoxColumn.Name];
                if (_currentSelectIndex.Contains(e.RowIndex)) return;

                bool isCurrentCheckBoxSelected = Convert.ToBoolean(checkCell.Value);

                _formViewModel.ChangeCourseCheckStatus(e.RowIndex, !isCurrentCheckBoxSelected);

                checkCell.Value = !isCurrentCheckBoxSelected;

                CourseGridView.NotifyCurrentCellDirty(true);
                CourseGridView.Invalidate();
            }
        }

        private void CourseGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!CourseGridView.IsCurrentCellDirty) return;

            ReDrawContents();
        }

        private void SubmitCourseSelectionButton_Click(object sender, EventArgs e)
        {
            Result<string> submitResult = _formViewModel.HandleSelectCourseSubmission();

            string resultMsg = submitResult.Success ? submitResult.Data : (submitResult as ErrorResult<string>).Message;

            MessageBox.Show(resultMsg, "", buttons: MessageBoxButtons.OK, icon: submitResult.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            ReDrawContents();
            UpdateCourseGridView();
        }

        private void GetCourseSelectResultbutton_Click(object sender, EventArgs e)
        {
            CourseSelectionResultForm courseSelectionResultForm = new();
            courseSelectionResultForm.ShowDialog();
        }

        private void ReDrawContents()
        {
            SubmitCourseSelectionButton.Enabled = _formViewModel.IsAnyCourseChecked();
            GetCourseSelectResultbutton.Enabled = _formViewModel.IsAnyCourseSelected();
        }

        private void DisableSelectedCourseCheckBox()
        {
            _currentSelectIndex = _formViewModel.GetSelectedCourseIndex();
            foreach (int courseIndex in _currentSelectIndex)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)CourseGridView.Rows[courseIndex].Cells[CourseSelectionBoxColumn.Name];
                checkCell.Value = true;
            }
        }
    }
}
