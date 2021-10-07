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

        private string _currentDepartmentName = "123";
        private string _currentTableName = "123"; 

        private readonly SelectCourseFormViewModel _formViewModel = new();


        private void SelectCourseForm_Load(object sender, EventArgs e)
        {
            UpdateCourseGridView();
        }

        private void UpdateCourseGridView()
        {
            List<string[]> courseRows = _formViewModel.GetCourseTableRows(_currentDepartmentName, _currentTableName);

            courseRows.ForEach(row => CourseGridView.Rows.Add(row));
            CourseGridView.NotifyCurrentCellDirty(true);
        }

        private void CourseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && CourseGridView.Columns[e.ColumnIndex].Name == CourseSelectionBoxColumn.Name)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)CourseGridView.Rows[e.RowIndex].Cells[CourseSelectionBoxColumn.Name];
                bool isCurrentCheckBoxSelected = Convert.ToBoolean(checkCell.Value);

                _formViewModel.ChangeCourseSelectionStatus(_currentDepartmentName, _currentTableName, e.RowIndex, !isCurrentCheckBoxSelected);

                checkCell.Value = !isCurrentCheckBoxSelected;
                CourseGridView.NotifyCurrentCellDirty(true);
                CourseGridView.Invalidate();
            }
        }

        private void CourseGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!CourseGridView.IsCurrentCellDirty) return;

            SubmitCourseSelectionButton.Enabled = _formViewModel.IsAnyCourseSelected(_currentDepartmentName, _currentTableName);
        }

        private void SubmitCourseSelectionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("北科大名校實屬牛逼", "", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
        }
    }
}
