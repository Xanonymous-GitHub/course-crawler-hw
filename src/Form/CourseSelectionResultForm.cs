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

        private void UpdateCourseGridView()
        {
            List<string[]> courseRows = _formViewModel.GetSelectedCourseTableRows();

            CourseGridView.Rows.Clear();
            courseRows.ForEach(row => CourseGridView.Rows.Add(row));
            CourseGridView.NotifyCurrentCellDirty(true);
        }

        private void CourseSelectionResultForm_Load(object sender, EventArgs e)
        {
            UpdateCourseGridView();
        }

        private void CourseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && CourseGridView.Columns[e.ColumnIndex].Name == UnselectCourseButtonColumn.Name)
            {
                _formViewModel.UnselectedCourse(e.RowIndex);
                UpdateCourseGridView();
            }
        }
    }
}
