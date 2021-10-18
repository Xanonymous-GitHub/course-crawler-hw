using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;

namespace CourseCrawler
{
    internal sealed class FetchDepartmentCourseTableUseCase : IUseCase<Department>
    {
        public FetchDepartmentCourseTableUseCase(string departmentName, string tableName)
        {
            _departmentName = departmentName;
            _tableName = tableName;
        }

        private readonly string _departmentName, _tableName;

        private readonly Store _store = Store.Instance;

        // FetchNeededRawHtmlTableRows
        private HtmlNodeCollection FetchNeededRawHtmlTableRows()
        {
            Uri targetUri = Utils.GetDepartmentCourseTableUri(_departmentName, _tableName);
            CrawlerUseCase crawlerUseCase = new(targetUri);

            Result<HtmlDocument> crawledResult = crawlerUseCase.Do();

            if (crawledResult.Success != true)
            {
                Utils.ShowDebugBox("Fail to Fetch course tables !!");
                return null;
            }

            const string neededContentFilterString = "//body/table";
            HtmlNodeCollection courseTableRows = (crawledResult as SuccessResult<HtmlDocument>).Data.DocumentNode.SelectSingleNode(neededContentFilterString).ChildNodes;

            const int unneededCourseTableRowOnTopAmount = 3;
            for (int i = 0; i < unneededCourseTableRowOnTopAmount; i++)
            {
                courseTableRows.RemoveAt(0);
            }

            courseTableRows.RemoveAt(courseTableRows.Count - 1);
            return courseTableRows;
        }

        // GenerateCourses
        private List<ICourse> GenerateCourses(HtmlNodeCollection courseTableRows)
        {
            List<ICourse> courses = new();

            foreach (HtmlNode row in courseTableRows)
            {
                HtmlNodeCollection nodeTableDatas = row.ChildNodes;
                nodeTableDatas.RemoveAt(0);
                courses.Add(CourseDto.FromElementStrings(nodeTableDatas.Select(element => element.InnerText).ToArray()));
            }

            return courses;
        }

        // GenerateDepartment
        private Department GenerateDepartment(List<ICourse> courses)
        {
            GetDepartmentUseCase getDepartmentUseCase = new(_departmentName);
            Department department = getDepartmentUseCase.Do();

            CourseTable table = new(_tableName, courses);

            if (department == null)
            {
                department = new(_departmentName, table);
            }
            else
            {
                department.CourseTables[_tableName] = table;
            }

            return department;
        }

        // Do this usecase
        public Department Do()
        {
            HtmlNodeCollection courseTableRows = FetchNeededRawHtmlTableRows();
            if (courseTableRows == null) return null;

            List<ICourse> courses = GenerateCourses(courseTableRows);
            Department department = GenerateDepartment(courses);

            _store.Update(_departmentName, department);
            return department;
        }
    }
}
