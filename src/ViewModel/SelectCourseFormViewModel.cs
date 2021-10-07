using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace CourseCrawler
{
    internal sealed class SelectCourseFormViewModel
    {
        public SelectCourseFormViewModel() { }

        private CourseTable GetTable(string departmentName, string tableName)
        {
            GetDepartmentUseCase getDepartmentUseCase = new(departmentName);
            Department department = getDepartmentUseCase.Do();

            if (department != null)
            {
                bool hasTable = department.CourseTables.TryGetValue(tableName, out ICourseTable table);
                if (hasTable) return (CourseTable)table;
            }

            FetchDepartmentCourseTableUseCase fetchDepartmentCourseTableUseCase = new(departmentName, tableName);
            department = fetchDepartmentCourseTableUseCase.Do();
            return (CourseTable)department.CourseTables[tableName];
        }

        public List<string[]> GetCourseTableRows(string departmentName, string tableName)
        {
            CourseTable table = GetTable(departmentName, tableName);
            return CourseTableDto.FromTableToRows(table);
        }

        public bool IsAnyCourseSelected(string departmentName, string tableName)
        {
            CourseTable table = GetTable(departmentName, tableName);
            return table.IsAnyCourseSelected;
        }

        public void ChangeCourseSelectionStatus(string departmentName, string tableName, int index, bool isSelected)
        {
            CourseTable table = GetTable(departmentName, tableName);
            if (isSelected)
            {
                table.Courses[index].MakeSelected();
            }
            else
            {
                table.Courses[index].MakeUnselected();
            }
        }
    }
}
