using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace CourseCrawler
{
    public partial class SelectCourseForm : Form
    {
        public SelectCourseForm()
        {
            InitializeComponent();
        }

        private void SelectCourseForm_Load(object sender, EventArgs e)
        {
            SetupCourseGridView();
        }

        private void SetupCourseGridView()
        {
            FetchCourseData(Constants.CoursePageUri);

            List<Course> courseRows = Store.Instance.Courses;

            foreach (Course course in courseRows)
            {
                CourseGridView.Rows.Add(CourseDto.ToStringList(course));
            }

            CourseGridView.NotifyCurrentCellDirty(true);
        }

        private void FetchCourseData(Uri uri)
        {
            CrawlerUseCase crawlerUseCase = new(uri);

            HtmlAgilityPack.HtmlDocument crawledResult = crawlerUseCase.Do();

            HtmlNodeCollection courseTableRows = crawledResult.DocumentNode.SelectSingleNode("//body/table").ChildNodes;

            const byte unneededCourseTableRowOnTopAmount = 3;
            for (byte i = 0; i < unneededCourseTableRowOnTopAmount; i++)
            {
                courseTableRows.RemoveAt(0);
            }

            courseTableRows.RemoveAt(courseTableRows.Count - 1);

            List<Course> courses = Store.Instance.Courses;

            foreach (HtmlNode row in courseTableRows)
            {
                HtmlNodeCollection nodeTableDatas = row.ChildNodes;
                nodeTableDatas.RemoveAt(0);
                courses.Add(CourseDto.FromElementStrings(nodeTableDatas.Select(element => element.InnerText).ToArray()));
            }
        }

        private void CourseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && CourseGridView.Columns[e.ColumnIndex].Name == "CourseSelectionBoxColumn")
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)CourseGridView.Rows[e.RowIndex].Cells["CourseSelectionBoxColumn"];
                List<Course> courses = Store.Instance.Courses;

                bool isCurrentCheckBoxSelected = Convert.ToBoolean(checkCell.Value);
                
                if (isCurrentCheckBoxSelected)
                {
                    courses[e.RowIndex].MakeUnselected();
                }
                else
                {
                    courses[e.RowIndex].MakeSelected();
                }

                checkCell.Value = !isCurrentCheckBoxSelected;
                CourseGridView.NotifyCurrentCellDirty(true);
                CourseGridView.Invalidate();
            }
        }

        private void CourseGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!CourseGridView.IsCurrentCellDirty) return;

            if (IsAnyCourseSelected())
            {
                SubmitCourseSelectionButton.Enabled = true;
            }
            else
            {
                SubmitCourseSelectionButton.Enabled = false;
            }
        }

        private bool IsAnyCourseSelected()
        {
            List<Course> courses = Store.Instance.Courses;

            foreach (Course course in courses)
            {
                if (course.IsSelected) return true;
            }

            return false;
        }

        private void SubmitCourseSelectionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("北科大名校實屬牛逼", "", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
        }
    }
}
