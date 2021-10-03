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


            List<Course> courseRows = FetchCourseData(Constants.CoursePageUri);

            foreach (Course course in courseRows)
            {
                CourseGridView.Rows.Add(CourseDto.ToStringList(course));
            }
        }

        private List<Course> FetchCourseData(Uri uri)
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

            List<Course> courses = new();

            foreach (HtmlNode row in courseTableRows)
            {
                HtmlNodeCollection nodeTableDatas = row.ChildNodes;
                nodeTableDatas.RemoveAt(0);
                courses.Add(CourseDto.FromElementStrings(nodeTableDatas.Select(element => element.InnerText).ToArray()));
            }

            return courses;
        }
    }
}
