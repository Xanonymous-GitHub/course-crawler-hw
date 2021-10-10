using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler
{
    internal sealed class CourseSelectionResultFormViewModel
    {
        public CourseSelectionResultFormViewModel()
        {
            GenerateSelectedCourseTable();
        }

        private CourseTable _selectedCourseTable;

        private void GenerateSelectedCourseTable()
        {
            GetSelectedCourseUseCase getSelectedCourseUseCase = new();
            List<ICourse> selectedCourses = getSelectedCourseUseCase.Do();

            _selectedCourseTable = new CourseTable(Constants.SelectedCourse, selectedCourses);
        }

        public List<string[]> GetSelectedCourseTableRows()
        {
            CourseTable table = _selectedCourseTable;
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

        public void UnselectedCourse(int unselectIndex)
        {
            _selectedCourseTable.Courses[unselectIndex].MakeUnselected();
            _selectedCourseTable.Courses.RemoveAt(unselectIndex);
            SaveSelectedCourseUseCase saveSelectedCourseUseCase = new(_selectedCourseTable.Courses);
            saveSelectedCourseUseCase.Do();
            GenerateSelectedCourseTable();
        }
    }
}
