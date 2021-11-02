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
    public partial class CourseSelectionResultForm : Form
    {
        public CourseSelectionResultForm()
        {
            InitializeComponent();
        }

        private readonly CourseSelectionResultFormViewModel _formViewModel = new();

        // Use latest selected course info to draw the gridView.
        private void UpdateCourseGridView()
        {
            List<string[]> courseRows = _formViewModel.GetSelectedCourseTableRows();

            CourseGridView.Rows.Clear();
            courseRows.ForEach(row => CourseGridView.Rows.Add(row));
            CourseGridView.NotifyCurrentCellDirty(true);
        }

        // Event handler for CourseSelectionResultForm Load.
        private void CourseSelectionResultForm_Load(object sender, EventArgs e)
        {
            _formViewModel.PropertyChanged += HandleVMChanged;
            UpdateCourseGridView();
        }

        // HandleVMChanged
        public void HandleVMChanged(object sender, PropertyChangedEventArgs e)
        {
            UpdateCourseGridView();
        }

        // Event handler for CourseGridView CellContentClick.
        private void CourseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && CourseGridView.Columns[e.ColumnIndex].Name == UnselectCourseButtonColumn.Name)
            {
                _formViewModel.UnselectedCourse(e.RowIndex);
            }
        }

        private void CourseSelectionResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _formViewModel.PropertyChanged -= HandleVMChanged;
        }
    }
}
