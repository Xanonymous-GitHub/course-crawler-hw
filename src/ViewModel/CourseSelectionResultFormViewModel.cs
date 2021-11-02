using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler
{
    internal sealed class CourseSelectionResultFormViewModel : Bindable
    {
        public CourseSelectionResultFormViewModel()
        {
            GenerateSelectedCourseTable();
            RegistryDepartmentPropertyChangedEventHandlers();
        }

        private CourseTable _selectedCourseTable;
        private ObservableDictionary<string, Department> _allDepartments;

        // GenerateSelectedCourseTable
        private void GenerateSelectedCourseTable()
        {
            List<ICourse> checkedCourse = new();

            GetAllDepartmentsUseCase getAllDepartmentsUseCase = new();
            _allDepartments = getAllDepartmentsUseCase.Do();

            foreach (KeyValuePair<string, Department> kvp in _allDepartments)
            {
                foreach (KeyValuePair<string, ICourseTable> _kvp in kvp.Value.CourseTables)
                {
                    foreach (ICourse course in _kvp.Value.Courses)
                    {
                        if (course.IsSelected)
                            checkedCourse.Add(course);
                    }
                }
            }

            _selectedCourseTable = new(Consts.SelectedCourse, checkedCourse);
        }

        // RegistryDepartmentPropertyChangedEventHandlers
        public void RegistryDepartmentPropertyChangedEventHandlers()
        {
            _allDepartments.PropertyChanged += HandleDepartmentPropertyChanged;
        }

        // HandleDepartmentPropertyChanged
        public void HandleDepartmentPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            GenerateSelectedCourseTable();
            DirectlyNotifyPropertyChanged();
        }

        // GetSelectedCourseTableRows
        public List<string[]> GetSelectedCourseTableRows()
        {
            List<List<string>> tableRows = CourseTableDto.FromTableToRows(_selectedCourseTable);
            List<List<string>> shouldDisplayedtableRows = new();

            for (int i = 0; i < tableRows.Count; i++)
            {
                List<string> rowWithUnselectButton = new() { Consts.UnselectCourse };
                foreach (string colValue in tableRows[i])
                {
                    rowWithUnselectButton.Add(colValue);
                }

                shouldDisplayedtableRows.Add(rowWithUnselectButton);
            }

            return shouldDisplayedtableRows.Select(row => row.ToArray()).ToList();
        }

        // UnselectedCourse
        public void UnselectedCourse(int unselectIndex)
        {
            _selectedCourseTable.Courses[unselectIndex].MakeUnselected();
            _allDepartments.DirectlyNotifyPropertyChanged();
        }
    }
}
