using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler
{
    internal sealed class CourseSelectionResultFormViewModel
    {
        private CourseTable GenerateSelectedCourseTable()
        {
            GetSelectedCourseUseCase getSelectedCourseUseCase = new();
            List<ICourse> selectedCourses = getSelectedCourseUseCase.Do();

            return new CourseTable(Constants.SelectedCourse, selectedCourses);
        }

        public List<string[]> GetSelectedCourseTableRows()
        {
            CourseTable table = GenerateSelectedCourseTable();
            List<List<string>> tableRows = CourseTableDto.FromTableToRows(table);
            List<string[]> tableRowsStr = new();

            for (int i = 0; i < tableRows.Count; i++)
            {
                tableRowsStr.Add(new string[] { Constants.UnselectCourse });
                foreach (string col in tableRows[i])
                {
                    List<string> tmp = tableRowsStr[i].ToList();
                    tmp.Add(col);
                    tableRowsStr[i] = tmp.ToArray();
                }
            }

            return tableRowsStr;
        }
    }
}
