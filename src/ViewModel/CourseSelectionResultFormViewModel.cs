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
            List<List<string>> tableRows = CourseTableDto.FromTableToRows(_selectedCourseTable);
            List<List<string>> shouldDisplayedtableRows = new();

            for (int i = 0; i < tableRows.Count; i++)
            {
                List<string> rowWithUnselectButton = new() { Constants.UnselectCourse };
                foreach (string colValue in tableRows[i])
                {
                    rowWithUnselectButton.Add(colValue);
                }

                shouldDisplayedtableRows.Add(rowWithUnselectButton);
            }

            return shouldDisplayedtableRows.Select(row => row.ToArray()).ToList();
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
