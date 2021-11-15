using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using HtmlAgilityPack;

namespace CourseCrawler
{
    public sealed class FetchDepartmentCourseTableUseCase : IUseCase<Department>
    {
        public FetchDepartmentCourseTableUseCase(int supportedDataSourceIndex)
        {
            _supportedDataSourceIndex = supportedDataSourceIndex;
            _departmentName = SupportedDataSourceInfo.GetDepartmentName(_supportedDataSourceIndex);
            _tableName = SupportedDataSourceInfo.GetTableName(_supportedDataSourceIndex);
        }

        private readonly int _supportedDataSourceIndex;

        private readonly string _departmentName, _tableName;

        private readonly Store _store = Store.Instance;

        // FetchNeededRawHtmlTableRows
        private HtmlNodeCollection FetchNeededRawHtmlTableRows()
        {
            Uri targetUri = Utils.GetDepartmentCourseTableUri(_supportedDataSourceIndex);
            CrawlerUseCase crawlerUseCase = new(targetUri);

            Result<HtmlDocument> crawledResult = crawlerUseCase.Do();

            if (crawledResult.Success != true)
            {
                Utils.ShowDebugBox(Consts.MsgFailToFetchResources);
                return null;
            }

            const string neededContentFilterString = "//body/table";
            HtmlNodeCollection courseTableRows = (crawledResult as SuccessResult<HtmlDocument>).Data.DocumentNode.SelectSingleNode(neededContentFilterString).ChildNodes;
            if (courseTableRows == null)
            {
                Utils.ShowDebugBox(Consts.MsgFailToFetchResources);
                return null;
            }

            const int unneededCourseTableRowOnTopAmount = 3;
            for (int i = 0; i < unneededCourseTableRowOnTopAmount; i++)
            {
                courseTableRows.RemoveAt(0);
            }

            courseTableRows.RemoveAt(courseTableRows.Count - 1);

            try
            {
                return courseTableRows;
            } 
            catch
            {
                return null;
            };
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

        // GenerateCourseTable
        private CourseTable GenerateCourseTable(List<ICourse> courses) => new(_tableName, courses);

        // GenerateDepartment
        private Department GenerateDepartment(CourseTable courseTable)
        {
            GetDepartmentUseCase getDepartmentUseCase = new(_departmentName);
            Department department = getDepartmentUseCase.Do();

            if (department == null)
            {
                department = new(_departmentName, courseTable);
            }
            else
            {
                department.CourseTables[_tableName] = courseTable;
            }

            return department;
        }

        // Do this usecase
        public Department Do()
        {
            HtmlNodeCollection courseTableRows = FetchNeededRawHtmlTableRows();
            if (courseTableRows == null) return null;

            List<ICourse> courses = GenerateCourses(courseTableRows);
            CourseTable courseTable = GenerateCourseTable(courses);

            ObservableDictionary<string, Department> allDepartments;
            if (_store.Exist(Consts.AllDepartments))
            {
                allDepartments = _store.Use<ObservableDictionary<string, Department>>(Consts.AllDepartments);
            }
            else
            {
                allDepartments = new();
            }

            allDepartments.ShouldNotifyChanges = false;

            Department department;
            
            if (allDepartments.ContainsKey(_departmentName))
            {
                allDepartments[_departmentName].CourseTables.Add(_tableName, courseTable);
                department = allDepartments[_departmentName];
            }
            else
            {
                department = GenerateDepartment(courseTable);
                allDepartments.Add(_departmentName, department);
            }
            
            allDepartments.ShouldNotifyChanges = true;

            _store.Update(Consts.AllDepartments, allDepartments);

            return department;
        }
    }
}
